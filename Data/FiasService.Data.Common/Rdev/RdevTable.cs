using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FiasService.Data.Common.Rdev
{
	/// <summary>
	/// Обязательные поля для совместимости с RDEV
	/// </summary>
	public class RdevTable
	{
		public RdevTable()
		{
			RecState = 1; // Запись активна
		}

		/// <summary>
		/// Поле нужное для совместимости с RDEV
		/// </summary>
		[Key]
		[Column("recid", Order = 0)]
		public Guid RecId { get; set; }

		/// <summary>
		/// Поле нужное для совместимости с RDEV
		/// </summary>
		[Required]
		[Column("recname", Order = 1)]
		public virtual string RecName { get; set; }

		/// <summary>
		/// Поле нужное для совместимости с RDEV
		/// </summary>
		[Column("recdescription", Order = 2)]
		public string RecDescription { get; set; }

		/// <summary>
		/// Поле нужное для совместимости с RDEV
		/// </summary>
		[Required]
		[Column("reccreated", Order = 3)]
		public DateTime RecCreated { get; set; }

		/// <summary>
		/// Поле нужное для совместимости с RDEV
		/// </summary>
		[Column("recupdated", Order = 4)]
		public virtual DateTime RecUpdated { get; set; }

		/// <summary>
		/// Поле нужное для совместимости с RDEV
		/// </summary>
		[Required]
		[Column("reccreatedby", Order = 5)]
		public string RecCreatedBy { get; set; }

		/// <summary>
		/// Поле нужное для совместимости с RDEV
		/// </summary>
		[Column("recupdatedby", Order = 6)]
		public string RecUpdatedBy { get; set; }

		/// <summary>
		/// Поле нужное для совместимости с RDEV
		/// Состояние записи: 
		/// 0 - новая пустая
		/// 1 - актуальная
		/// 2 - удаленная
		/// </summary>
		[Column("recstate", Order = 7)]
		public int RecState { get; set; }

		/// <summary>
		/// Поле нужное для совместимости с RDEV
		/// </summary>
		[Column("reccode", Order = 8)]
		public string RecCode { get; set; }
	}
}
