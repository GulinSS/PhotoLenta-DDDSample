namespace GulinSerge.PhotoLenta.Domain.Services
{
	/// <summary>
	/// В каком порядке выводить результаты
	/// </summary>
	public enum FilterOrderType
	{
		/// <summary>
		/// От самых новых к ранним
		/// </summary>
		ByTime,

		/// <summary>
		/// От самого высокого рейтинга к низкому
		/// </summary>
		ByRating
	}
}