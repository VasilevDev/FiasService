using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiasService.Contract;
using FiasService.Data.Common.Entities;

namespace FiasService.Database
{
	public class FiasRepository : IFiasRepository
	{
		private readonly IDataStorageFactory contextCreator;

		public FiasRepository(IDataStorageFactory contextCreator)
		{
			this.contextCreator = contextCreator;
		}

		public BaseResult<Guid> Add(string tableName, IDictionary<string, string> fields)
		{
			var result = new BaseResult<Guid>();

			try
			{
				// todo: добавить проверку на наличие записи в таблице
				using (var db = contextCreator.Create())
				{
					var recId = Guid.NewGuid();

					if (tableName == "addrobj")
					{
						var item = new FiasAddressObject()
						{
							RecId = recId,
							RecName = "",
							RecDescription = "",
							RecCreated = DateTime.UtcNow,
							RecUpdated = DateTime.UtcNow,
							RecState = 1,
							RecCode = "",
							RecCreatedBy = "",
							RecUpdatedBy = "",

							Aoguid = Guid.Parse(fields["aoguid"]),
							Aoid = Guid.Parse(fields["aoid"]),
							ParentGuid = Guid.Parse(fields["parentguid"]),

							AoLevel = int.Parse(fields["aolevel"]),
							DivType = int.Parse(fields["divtype"]),

							ShortName = fields["shortname"],
							FormalName = fields["formalname"],
							OffName = fields["offname"],

							AutoCode = fields["autocode"],
							AreaCode = fields["areacode"],
							CityCode = fields["citycode"],
							CtarCode = fields["ctarcode"],
							ExtrCode = fields["extrcode"],
							PlaceCode = fields["placecode"],
							PlainCode = fields["plaincode"],
							PlanCode = fields["plancode"],
							SextCode = fields["sextcode"],
							RegionCode = fields["regioncode"],
							StreetCode = fields["streetcode"],
							Code = fields["code"],

							ActStatus = int.Parse(fields["actstatus"]),
							CurrStatus = int.Parse(fields["currstatus"]),
							CentStatus = int.Parse(fields["centstatus"]),
							OperStatus = int.Parse(fields["operstatus"]),
							LiveStatus = int.Parse(fields["livestatus"]),

							CadNum = fields["cadnum"],
							PostalCode = fields["postalcode"],
							NormDoc = fields["normdoc"],

							Okato = fields["okato"],
							Oktmo = fields["oktmo"],

							PrevId = Guid.Parse(fields["previd"]),
							NextId = Guid.Parse(fields["nextid"]),

							StartDate = DateTime.Parse(fields["startdate"]),
							EndDate = DateTime.Parse(fields["enddate"]),
							UpdateDate = DateTime.Parse(fields["updatedate"]),

							IfnsFl = fields["ifnsfl"],
							IfnsUl = fields["ifnsul"],
							TerrIfnsFl = fields["terrifnsfl"],
							TerrIfnsUl = fields["terrifnsul"]
						};

						db.AddressObjects.Add(item);
					}
					else if(tableName == "house")
					{
						var item = new FiasHouse()
						{
							RecId = recId,
							RecName = "",
							RecDescription = "",
							RecCreated = DateTime.UtcNow,
							RecUpdated = DateTime.UtcNow,
							RecState = 1,
							RecCode = "",
							RecCreatedBy = "",
							RecUpdatedBy = "",

							IfnsFl = fields["ifnsfl"],
							IfnsUl = fields["ifnsul"],
							TerrIfnsFl = fields["terrifnsfl"],
							TerrIfnsUl = fields["terrifnsul"],

							Okato = fields["okato"],
							Oktmo = fields["oktmo"],

							StartDate = DateTime.Parse(fields["startdate"]),
							EndDate = DateTime.Parse(fields["enddate"]),
							UpdateDate = DateTime.Parse(fields["updatedate"]),

							Aoguid = Guid.Parse(fields["aoguid"]),

							CadNum = fields["cadnum"],
							PostalCode = fields["postalcode"],
							RegionCode = fields["regioncode"],
							NormDoc = fields["normdoc"],

							DivType = int.Parse(fields["divtype"]),

							HouseId = Guid.Parse(fields["houseid"]),
							HouseGuid = Guid.Parse(fields["houseguid"]),

							HouseNum = fields["housenum"],
							BuildNum = fields["buildnum"],
							StructNum = fields["structnum"],

							EstStatus = int.Parse(fields["eststatus"]),
							StatStatus = int.Parse(fields["statstatus"]),
							StrStatus = int.Parse(fields["strstatus"]),

							Counter = int.Parse(fields["counter"])
						};

						db.Houses.Add(item);
					}

					db.SaveChanges();

					result.Success = true;
					result.Data = recId;
				}
			}
			catch (Exception ex)
			{
				result.Success = false;
				result.Message = $"Ошибка при попытке добавить запись в таблицу {tableName}. {ex.Message}.";
			}

			return result;
		}
	}
}
