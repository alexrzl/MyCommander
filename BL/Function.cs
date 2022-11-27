using System.Text.RegularExpressions;

namespace BL
{
	public static class Function
	{
		/// <summary>
		/// Функция преобразования из даты (строка) и время (строка) в дату
		/// </summary>
		/// <param name="date">Дата (строка)</param>
		/// <param name="time">Время (строка)</param>
		/// <returns>Дата в формате dd.MM.yyyy HH:mm:ss</returns>
		public static DateTime ParseDate(string date, string time = "00:00:00")
		{
			if (!string.IsNullOrWhiteSpace(date))
			{
				var dateRegex = new Regex(@"\d{2}\.\d{2}\.\d{4}");
				var timeRegex = new Regex(@"\d{2}\:\d{2}\:\d{2}");

				if (dateRegex.Match(date).Success)
				{
					if (!timeRegex.Match(time).Success)
					{
						time = "00:00:00";
					}

					return DateTime.Parse($"{date} {time}");
				}
			}

			return new DateTime();
		}
		/// <summary>
		/// Объединение даты и времени
		/// </summary>
		/// <param name="date">Дата</param>
		/// <param name="time">Время</param>
		/// <returns>Дата в формате dd.MM.yyyy HH:mm:ss</returns>
		public static DateTime JoinDateTime(DateTime date, DateTime time)
			=> DateTime.Parse($"{date.ToString("dd.MM.yyyy")} {time.ToString("HH:mm:ss")}");
	}
}
