using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FiasService.Data.Postgres.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:PostgresExtension:uuid-ossp", ",,");

            migrationBuilder.CreateTable(
                name: "addrobj",
                columns: table => new
                {
                    recid = table.Column<Guid>(nullable: false),
                    recname = table.Column<string>(nullable: false),
                    recdescription = table.Column<string>(nullable: true),
                    reccreated = table.Column<DateTime>(nullable: false),
                    recupdated = table.Column<DateTime>(nullable: false),
                    reccreatedby = table.Column<string>(nullable: false),
                    recupdatedby = table.Column<string>(nullable: true),
                    recstate = table.Column<int>(nullable: false),
                    reccode = table.Column<string>(nullable: true),
                    aoguid = table.Column<Guid>(nullable: false),
                    postalcode = table.Column<string>(nullable: true),
                    ifnsfl = table.Column<string>(nullable: true),
                    terrifnsfl = table.Column<string>(nullable: true),
                    ifnsul = table.Column<string>(nullable: true),
                    terrifnsul = table.Column<string>(nullable: true),
                    okato = table.Column<string>(nullable: true),
                    oktmo = table.Column<string>(nullable: true),
                    updatedate = table.Column<DateTime>(nullable: false),
                    startdate = table.Column<DateTime>(nullable: false),
                    enddate = table.Column<DateTime>(nullable: false),
                    normdoc = table.Column<string>(nullable: true),
                    cadnum = table.Column<string>(nullable: true),
                    divtype = table.Column<int>(nullable: false),
                    regioncode = table.Column<string>(nullable: true),
                    shortname = table.Column<string>(nullable: true),
                    formalname = table.Column<string>(nullable: true),
                    autocode = table.Column<string>(nullable: true),
                    areacode = table.Column<string>(nullable: true),
                    citycode = table.Column<string>(nullable: true),
                    ctarcode = table.Column<string>(nullable: true),
                    placecode = table.Column<string>(nullable: true),
                    plancode = table.Column<string>(nullable: true),
                    streetcode = table.Column<string>(nullable: true),
                    extrcode = table.Column<string>(nullable: true),
                    sextcode = table.Column<string>(nullable: true),
                    offname = table.Column<string>(nullable: true),
                    aolevel = table.Column<int>(nullable: false),
                    parentguid = table.Column<Guid>(nullable: false),
                    aoid = table.Column<Guid>(nullable: false),
                    previd = table.Column<Guid>(nullable: false),
                    nextid = table.Column<Guid>(nullable: false),
                    code = table.Column<string>(nullable: true),
                    plaincode = table.Column<string>(nullable: true),
                    actstatus = table.Column<int>(nullable: false),
                    livestatus = table.Column<int>(nullable: false),
                    centstatus = table.Column<int>(nullable: false),
                    operstatus = table.Column<int>(nullable: false),
                    currstatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_addrobj", x => x.recid);
                });

            migrationBuilder.CreateTable(
                name: "house",
                columns: table => new
                {
                    recid = table.Column<Guid>(nullable: false),
                    recname = table.Column<string>(nullable: false),
                    recdescription = table.Column<string>(nullable: true),
                    reccreated = table.Column<DateTime>(nullable: false),
                    recupdated = table.Column<DateTime>(nullable: false),
                    reccreatedby = table.Column<string>(nullable: false),
                    recupdatedby = table.Column<string>(nullable: true),
                    recstate = table.Column<int>(nullable: false),
                    reccode = table.Column<string>(nullable: true),
                    aoguid = table.Column<Guid>(nullable: false),
                    postalcode = table.Column<string>(nullable: true),
                    ifnsfl = table.Column<string>(nullable: true),
                    terrifnsfl = table.Column<string>(nullable: true),
                    ifnsul = table.Column<string>(nullable: true),
                    terrifnsul = table.Column<string>(nullable: true),
                    okato = table.Column<string>(nullable: true),
                    oktmo = table.Column<string>(nullable: true),
                    updatedate = table.Column<DateTime>(nullable: false),
                    startdate = table.Column<DateTime>(nullable: false),
                    enddate = table.Column<DateTime>(nullable: false),
                    normdoc = table.Column<string>(nullable: true),
                    cadnum = table.Column<string>(nullable: true),
                    divtype = table.Column<int>(nullable: false),
                    regioncode = table.Column<string>(nullable: true),
                    housenum = table.Column<string>(nullable: true),
                    eststatus = table.Column<int>(nullable: false),
                    buidnum = table.Column<string>(nullable: true),
                    structnum = table.Column<string>(nullable: true),
                    strstatus = table.Column<int>(nullable: false),
                    houseid = table.Column<Guid>(nullable: false),
                    houseguid = table.Column<Guid>(nullable: false),
                    statstatus = table.Column<int>(nullable: false),
                    counter = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_house", x => x.recid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "addrobj");

            migrationBuilder.DropTable(
                name: "house");
        }
    }
}
