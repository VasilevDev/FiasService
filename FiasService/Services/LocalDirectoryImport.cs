using System;
using System.Collections.Generic;
using System.Xml;
using FiasService.Contract;
using FiasService.Database;
using SharpCompress.Archives;

namespace FiasService.Services
{
	public class LocalDirectoryImport : IFiasXmlImport<object>
	{
		private readonly IFiasRepository db;

		public LocalDirectoryImport(IFiasRepository db)
		{
			this.db = db;
		}

		public BaseResult<object> Import(string src)
		{
			var result = new BaseResult<object>();

			List<string> tables = new List<string>()
			{
				"ADDROBJ", "HOUSE"
			};

			try
			{
				// Открываем архив с файлами данных по ФИАС
				using (var archive = ArchiveFactory.Open(src))
				{
					// Цикл обхода архива с XML файлами с данными ФИАС
					foreach (var entry in archive.Entries)
					{
						string tableName = entry.Key.Split('_')[1];

						// Импортируем только нужные таблицы
						if (!tables.Contains(tableName)) continue;

						// Открываем поток на чтение XML файла ФИАС
						using (var stream = entry.OpenEntryStream())
						{
							XmlReader reader = XmlReader.Create(stream);

							// Цикл обхода XML файла ФИАС
							while (reader.Read())
							{
								if (reader.NodeType == XmlNodeType.Element)
								{
									// Атрибуты и их значения представляют собой название поля в таблице и значение соответственно
									if (reader.HasAttributes)
									{
										var record = new Dictionary<string, string>();

										// Цикл обхода всех полей записи таблицы
										while (reader.MoveToNextAttribute())
										{
											string fieldName = reader.Name.ToLower();
											string fieldValue = $"'{reader.Value.Replace("'", "").Replace('«', '"').Replace('»', '"')}'";

											record[fieldName] = fieldValue;
										}

										if (record.Count > 0)
										{
											db.Add(tableName.ToLower(), record);
										}
									}
								}
							}
						}
					}
				}

				result.Success = true;
				result.Data = null;
			}
			catch(Exception ex)
			{
				result.Success = false;
				result.Message = $"Ошибка при импорте данных ФИАС из локального источника. {ex.Message}.";
			}

			return result;
		}
	}
}
