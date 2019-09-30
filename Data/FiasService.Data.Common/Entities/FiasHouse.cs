using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FiasService.Data.Common.Entities
{
	[Table("house")]
	public class FiasHouse : FiasCommonFields
	{
		/// <summary>
		/// Номер дома
		/// </summary>
		[Column("housenum")]
		public string HouseNum { get; set; }

		/// <summary>
		/// Признак владения
		/// </summary>
		[Column("eststatus")]
		public int EstStatus { get; set; }

		/// <summary>
		/// Номер корпуса
		/// </summary>
		[Column("buidnum")]
		public string BuildNum { get; set; }

		/// <summary>
		/// Номер строения
		/// </summary>
		[Column("structnum")]
		public string StructNum { get; set; }

		/// <summary>
		/// Признак строения
		/// </summary>
		[Column("strstatus")]
		public int StrStatus { get; set; }

		/// <summary>
		/// Уникальный идентификатор дома
		/// </summary>
		[Column("houseid")]
		public Guid HouseId { get; set; }

		/// <summary>
		/// Глобальный идентификатор дома
		/// </summary>
		[Column("houseguid")]
		public Guid HouseGuid { get; set; }

		/// <summary>
		/// Состояние дома
		/// </summary>
		[Column("statstatus")]
		public int StatStatus { get; set; }

		/// <summary>
		/// Счетчик записей зданий для формирования классификационного кода
		/// </summary>
		[Column("counter")]
		public int Counter { get; set; }
	}
}
