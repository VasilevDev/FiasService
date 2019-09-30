using FiasService.Data.Common.Rdev;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FiasService.Data.Common.Entities
{
	public class FiasCommonFields : RdevTable
	{
		/// <summary>
		/// Глобальный идентификатор записи
		/// </summary>
		[Column("aoguid")]
		public Guid Aoguid { get; set; }

		/// <summary>
		/// Почтовый индекс
		/// </summary>
		[Column("postalcode")]
		public string PostalCode { get; set; }

		/// <summary>
		/// Код ИФНС ФЛ
		/// </summary>
		[Column("ifnsfl")]
		public string IfnsFl { get; set; }

		/// <summary>
		/// Код территориального участка ИФНС ФЛ
		/// </summary>
		[Column("terrifnsfl")]
		public string TerrIfnsFl { get; set; }

		/// <summary>
		/// Код ИФНС ЮЛ
		/// </summary>
		[Column("ifnsul")]
		public string IfnsUl { get; set; }

		/// <summary>
		/// Код территориального участка ИФНС ЮЛ
		/// </summary>
		[Column("terrifnsul")]
		public string TerrIfnsUl { get; set; }

		/// <summary>
		/// ОКАТО
		/// </summary>
		[Column("okato")]
		public string Okato { get; set; }

		/// <summary>
		/// ОКТМО
		/// </summary>
		[Column("oktmo")]
		public string Oktmo { get; set; }

		/// <summary>
		/// Дата внесения обновления записи
		/// </summary>
		[Column("updatedate")]
		public DateTime UpdateDate { get; set; }

		/// <summary>
		/// Начало действия записи
		/// </summary>
		[Column("startdate")]
		public DateTime StartDate { get; set; }

		/// <summary>
		/// Окончание действия записи
		/// </summary>
		[Column("enddate")]
		public DateTime EndDate { get; set; }

		/// <summary>
		/// Внешний ключ на нормативный документ
		/// </summary>
		[Column("normdoc")]
		public string NormDoc { get; set; }

		/// <summary>
		/// Кадастровый номер
		/// </summary>
		[Column("cadnum")]
		public string CadNum { get; set; }

		/// <summary>
		/// Тип деления
		/// </summary>
		[Column("divtype")]
		public int DivType { get; set; }

		/// <summary>
		/// Код региона
		/// </summary>
		[Column("regioncode")]
		public string RegionCode { get; set; }
	}
}
