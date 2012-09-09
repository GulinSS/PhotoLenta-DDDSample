using System;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Autofac;
using Autofac.Core;
using Autofac.Integration.Mvc;
using AutofacContrib.NHibernate.Bytecode;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using GulinSerge.Common;
using GulinSerge.Common.NhibernateAdditions;
using GulinSerge.PhotoLenta.Domain.Implementors.Repositories;
using GulinSerge.PhotoLenta.Domain.Repositories;
using GulinSerge.PhotoLenta.Web.Stubs;
using GulinSerge.PhotoLenta.Web.View.Impl;
using NHibernate;
using NHibernate.ByteCode.Castle;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using NHibernate.Type;
using Environment = System.Environment;
using Module = Autofac.Module;

namespace GulinSerge.PhotoLenta.Web.View
{
	// Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	// visit http://go.microsoft.com/?LinkId=9394801

	public class MvcApplication : HttpApplication
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}

		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				"Default", // Route name
				"{controller}/{action}/{id}", // URL with parameters
				new {controller = "Gallery", action = "Index", id = UrlParameter.Optional} // Parameter defaults
				);
		}

		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();

			var builder = new ContainerBuilder();
			builder.RegisterControllers(Assembly.GetExecutingAssembly());
			builder.RegisterModelBinders(Assembly.GetExecutingAssembly());
			builder.RegisterModelBinderProvider();

			builder.RegisterGeneric(typeof(KeyValueProviderNHibernate<,>)).AsImplementedInterfaces();
			builder.RegisterType<QueryableProviderNHibernate>().AsImplementedInterfaces();
			builder.RegisterType<UserContainerImpl>().AsImplementedInterfaces();
			builder.RegisterType<UnitOfWorkImplNHibernate>().AsImplementedInterfaces()
				.InstancePerDependency();

			builder.RegisterAssemblyTypes(Assembly.GetAssembly(typeof(ImageLinkRepositoryImpl)))
				.Where(x => x.Name.EndsWith("Impl"))
				.AsImplementedInterfaces();

			builder.RegisterAssemblyTypes(Assembly.GetAssembly(typeof (WebAuthentificationImpl)))
				.Where(x => x.Name.EndsWith("Impl"))
				.AsImplementedInterfaces();

			builder.Register(x => NHibernateConfigure.SessionFactory)
				.As<ISessionFactory>()
				.SingleInstance();
			builder.Register(x => x.Resolve<ISessionFactory>().OpenSession())
				.As<ISession>()
				.InstancePerHttpRequest();

			IContainer container = builder.Build();
			DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
			NHibernateConfigure.Container = container;

			RegisterGlobalFilters(GlobalFilters.Filters);
			RegisterRoutes(RouteTable.Routes);
		}

		private static class NHibernateConfigure
		{
			static NHibernateConfigure()
			{
				var config = Fluently.Configure()
					.Database(SQLiteConfiguration.Standard.InMemory)
					.ExposeConfiguration(c => c.SetProperty(NHibernate.Cfg.Environment.ReleaseConnections, "on_close"))
					.ExposeConfiguration(c => c.SetProperty(NHibernate.Cfg.Environment.ProxyFactoryFactoryClass, typeof(ProxyFactoryFactory).AssemblyQualifiedName))
					.ExposeConfiguration(c => c.SetProperty(NHibernate.Cfg.Environment.Hbm2ddlAuto, "create"))
					.ExposeConfiguration(c => c.SetProperty(NHibernate.Cfg.Environment.ShowSql, "true"))
					.ExposeConfiguration(c => c.SetProperty(NHibernate.Cfg.Environment.FormatSql, "true"))
					//.ExposeConfiguration(BuildSchema)
					.BuildConfiguration()
					.SetInterceptor(new NHibernateAutofacInterceptor(() => Container));
				SessionFactory = config.BuildSessionFactory();
			}

			private static void BuildSchema(Configuration config)
			{
				new SchemaExport(config).SetOutputFile(@"./Schema.sql").Create(true, true);
			}

			public static ISessionFactory SessionFactory { get; private set; }
			public static IContainer Container { private get; set; }
		}

		private class NHibernateAutofacInterceptor : EmptyInterceptor
		{
			public NHibernateAutofacInterceptor(Func<IContainer> container)
			{
				Container = container;
			}

			private Func<IContainer> Container { get; set; }

			public override bool OnLoad(object entity, object id, object[] state, string[] propertyNames, IType[] types)
			{
				foreach (PropertyInfo property in entity.GetType().GetProperties())
				{
					if (property.PropertyType.IsInterface && property.PropertyType.IsNotPublic)
						property.SetValue(entity, Container().Resolve(property.PropertyType), null);
				}
				return true;
			}
		}
	}
}