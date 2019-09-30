using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FiasService.Data.Common.Entities
{
	[Table("addrobj")]
	public class FiasAddressObject : FiasCommonFields
	{
		/// <summary>
		/// Тип адресного объекта (г, ул и тп)
		/// </summary>
		[Column("shortname")]
		public string ShortName { get; set; }

		/// <summary>
		/// Формализованное название
		/// </summary>
		[Column("formalname")]
		public string FormalName { get; set; }

		/// <summary>
		/// Код автономии
		/// </summary>
		[Column("autocode")]
		public string AutoCode { get; set; }

		/// <summary>
		/// Код района
		/// </summary>
		[Column("areacode")]
		public string AreaCode { get; set; }

		/// <summary>
		/// Код города
		/// </summary>
		[Column("citycode")]
		public string CityCode { get; set; }

		/// <summary>
		/// Код внутригородского района
		/// </summary>
		[Column("ctarcode")]
		public string CtarCode { get; set; }

		/// <summary>
		/// Код населенного пункта
		/// </summary>
		[Column("placecode")]
		public string PlaceCode { get; set; }

		/// <summary>
		/// Код элемента планировочной структуры
		/// </summary>
		[Column("plancode")]
		public string PlanCode { get; set; }

		/// <summary>
		/// Код улицы
		/// </summary>
		[Column("streetcode")]
		public string StreetCode { get; set; }

		/// <summary>
		/// Код дополнительного адресообразующего элемента
		/// </summary>
		[Column("extrcode")]
		public string ExtrCode { get; set; }

		/// <summary>
		/// Код подчиненного дополнительного адресообразующего элемента
		/// </summary>
		[Column("sextcode")]
		public string SextCode { get; set; }

		/// <summary>
		/// Официальное наименование
		/// </summary>
		[Column("offname")]
		public string OffName { get; set; }

		/// <summary>
		/// Уровень адресного объекта
		/// </summary>
		[Column("aolevel")]
		public int AoLevel { get; set; }

		/// <summary>
		/// Идентификатор родительской записи
		/// </summary>
		[Column("parentguid")]
		public Guid ParentGuid { get; set; }

		/// <summary>
		/// Уникальный идентификатор записи
		/// </summary>
		[Column("aoid")]
		public Guid Aoid { get; set; }

		/// <summary>
		/// Идентификатор записи связывания с предыдущей исторической записью
		/// </summary>
		[Column("previd")]
		public Guid PrevId { get; set; }

		/// <summary>
		/// Идентификатор записи связывания с последующей исторической записью
		/// </summary>
		[Column("nextid")]
		public Guid NextId { get; set; }

		/// <summary>
		/// Код адресного элемента одной строкой с признаком актуальности из классификационного кода
		/// </summary>
		[Column("code")]
		public string Code { get; set; }

		/// <summary>
		/// Код адресного элемента одной строкой без признака актуальности (последних двух цифр)
		/// </summary>
		[Column("plaincode")]
		public string PlainCode { get; set; }

		/// <summary>
		/// Статус актуальности записи 0 - не актуальная, 1 - актуальная
		/// </summary>
		[Column("actstatus")]
		public int ActStatus { get; set; }

		/// <summary>
		/// Статус актуальности адресного объекта ФИАС на текущую дату
		/// </summary>
		[Column("livestatus")]
		public int LiveStatus { get; set; }

		/// <summary>
		/// Статус центра
		/// </summary>
		[Column("centstatus")]
		public int CentStatus { get; set; }

		/// <summary>
		/// Статус действия над записью – причина появления записи
		/// </summary>
		[Column("operstatus")]
		public int OperStatus { get; set; }

		/// <summary>
		/// Статус актуальности КЛАДР 4 (последние две цифры в коде)
		/// </summary>
		[Column("currstatus")]
		public int CurrStatus { get; set; }
	}
}
