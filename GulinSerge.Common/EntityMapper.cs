using System;

namespace GulinSerge.Common
{
	/// <summary>
	/// Переводит объект одного интерфейса к другой реализации.
	/// Если сущность имеет конструктор с одним входным параметром типа <typeparam name="T"></typeparam>,
	/// то будет вызван он, в противном случае будет выполнена рефлексия
	/// </summary>
	public class EntityMapper<TIn, TOut>
		where TIn : Entity
		where TOut : class, TIn
	{
		public EntityMapper()
		{
			if (!typeof(TIn).IsInterface)
				throw new Exception("Только интерфейсы в качестве входных типов!");

			if (!typeof(TOut).IsClass)
				throw new Exception("Только реализации в качестве выходных типов!");
		}

		public TOut From(TIn o)
		{
			throw new NotImplementedException();
		}
	}
}
