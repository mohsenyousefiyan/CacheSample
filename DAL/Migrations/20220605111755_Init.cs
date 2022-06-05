using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    PhoneNumber = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Tbl_Users",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[,]
                {
                    { 1, null, "FirstName1", "LastName1", null, "U1" },
                    { 73, null, "FirstName73", "LastName73", null, "U73" },
                    { 72, null, "FirstName72", "LastName72", null, "U72" },
                    { 71, null, "FirstName71", "LastName71", null, "U71" },
                    { 70, null, "FirstName70", "LastName70", null, "U70" },
                    { 69, null, "FirstName69", "LastName69", null, "U69" },
                    { 68, null, "FirstName68", "LastName68", null, "U68" },
                    { 67, null, "FirstName67", "LastName67", null, "U67" },
                    { 66, null, "FirstName66", "LastName66", null, "U66" },
                    { 65, null, "FirstName65", "LastName65", null, "U65" },
                    { 64, null, "FirstName64", "LastName64", null, "U64" },
                    { 63, null, "FirstName63", "LastName63", null, "U63" },
                    { 62, null, "FirstName62", "LastName62", null, "U62" },
                    { 61, null, "FirstName61", "LastName61", null, "U61" },
                    { 60, null, "FirstName60", "LastName60", null, "U60" },
                    { 59, null, "FirstName59", "LastName59", null, "U59" },
                    { 58, null, "FirstName58", "LastName58", null, "U58" },
                    { 57, null, "FirstName57", "LastName57", null, "U57" },
                    { 56, null, "FirstName56", "LastName56", null, "U56" },
                    { 55, null, "FirstName55", "LastName55", null, "U55" },
                    { 54, null, "FirstName54", "LastName54", null, "U54" },
                    { 53, null, "FirstName53", "LastName53", null, "U53" },
                    { 74, null, "FirstName74", "LastName74", null, "U74" },
                    { 52, null, "FirstName52", "LastName52", null, "U52" },
                    { 75, null, "FirstName75", "LastName75", null, "U75" },
                    { 77, null, "FirstName77", "LastName77", null, "U77" },
                    { 98, null, "FirstName98", "LastName98", null, "U98" },
                    { 97, null, "FirstName97", "LastName97", null, "U97" },
                    { 96, null, "FirstName96", "LastName96", null, "U96" },
                    { 95, null, "FirstName95", "LastName95", null, "U95" },
                    { 94, null, "FirstName94", "LastName94", null, "U94" },
                    { 93, null, "FirstName93", "LastName93", null, "U93" },
                    { 92, null, "FirstName92", "LastName92", null, "U92" },
                    { 91, null, "FirstName91", "LastName91", null, "U91" },
                    { 90, null, "FirstName90", "LastName90", null, "U90" },
                    { 89, null, "FirstName89", "LastName89", null, "U89" },
                    { 88, null, "FirstName88", "LastName88", null, "U88" },
                    { 87, null, "FirstName87", "LastName87", null, "U87" },
                    { 86, null, "FirstName86", "LastName86", null, "U86" },
                    { 85, null, "FirstName85", "LastName85", null, "U85" },
                    { 84, null, "FirstName84", "LastName84", null, "U84" },
                    { 83, null, "FirstName83", "LastName83", null, "U83" }
                });

            migrationBuilder.InsertData(
                table: "Tbl_Users",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[,]
                {
                    { 82, null, "FirstName82", "LastName82", null, "U82" },
                    { 81, null, "FirstName81", "LastName81", null, "U81" },
                    { 80, null, "FirstName80", "LastName80", null, "U80" },
                    { 79, null, "FirstName79", "LastName79", null, "U79" },
                    { 78, null, "FirstName78", "LastName78", null, "U78" },
                    { 76, null, "FirstName76", "LastName76", null, "U76" },
                    { 51, null, "FirstName51", "LastName51", null, "U51" },
                    { 50, null, "FirstName50", "LastName50", null, "U50" },
                    { 49, null, "FirstName49", "LastName49", null, "U49" },
                    { 22, null, "FirstName22", "LastName22", null, "U22" },
                    { 21, null, "FirstName21", "LastName21", null, "U21" },
                    { 20, null, "FirstName20", "LastName20", null, "U20" },
                    { 19, null, "FirstName19", "LastName19", null, "U19" },
                    { 18, null, "FirstName18", "LastName18", null, "U18" },
                    { 17, null, "FirstName17", "LastName17", null, "U17" },
                    { 16, null, "FirstName16", "LastName16", null, "U16" },
                    { 15, null, "FirstName15", "LastName15", null, "U15" },
                    { 14, null, "FirstName14", "LastName14", null, "U14" },
                    { 13, null, "FirstName13", "LastName13", null, "U13" },
                    { 12, null, "FirstName12", "LastName12", null, "U12" },
                    { 11, null, "FirstName11", "LastName11", null, "U11" },
                    { 10, null, "FirstName10", "LastName10", null, "U10" },
                    { 9, null, "FirstName9", "LastName9", null, "U9" },
                    { 8, null, "FirstName8", "LastName8", null, "U8" },
                    { 7, null, "FirstName7", "LastName7", null, "U7" },
                    { 6, null, "FirstName6", "LastName6", null, "U6" },
                    { 5, null, "FirstName5", "LastName5", null, "U5" },
                    { 4, null, "FirstName4", "LastName4", null, "U4" },
                    { 3, null, "FirstName3", "LastName3", null, "U3" },
                    { 2, null, "FirstName2", "LastName2", null, "U2" },
                    { 23, null, "FirstName23", "LastName23", null, "U23" },
                    { 24, null, "FirstName24", "LastName24", null, "U24" },
                    { 25, null, "FirstName25", "LastName25", null, "U25" },
                    { 26, null, "FirstName26", "LastName26", null, "U26" },
                    { 48, null, "FirstName48", "LastName48", null, "U48" },
                    { 47, null, "FirstName47", "LastName47", null, "U47" },
                    { 46, null, "FirstName46", "LastName46", null, "U46" },
                    { 45, null, "FirstName45", "LastName45", null, "U45" },
                    { 44, null, "FirstName44", "LastName44", null, "U44" },
                    { 43, null, "FirstName43", "LastName43", null, "U43" },
                    { 42, null, "FirstName42", "LastName42", null, "U42" },
                    { 41, null, "FirstName41", "LastName41", null, "U41" }
                });

            migrationBuilder.InsertData(
                table: "Tbl_Users",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "PhoneNumber", "UserName" },
                values: new object[,]
                {
                    { 40, null, "FirstName40", "LastName40", null, "U40" },
                    { 39, null, "FirstName39", "LastName39", null, "U39" },
                    { 99, null, "FirstName99", "LastName99", null, "U99" },
                    { 38, null, "FirstName38", "LastName38", null, "U38" },
                    { 36, null, "FirstName36", "LastName36", null, "U36" },
                    { 35, null, "FirstName35", "LastName35", null, "U35" },
                    { 34, null, "FirstName34", "LastName34", null, "U34" },
                    { 33, null, "FirstName33", "LastName33", null, "U33" },
                    { 32, null, "FirstName32", "LastName32", null, "U32" },
                    { 31, null, "FirstName31", "LastName31", null, "U31" },
                    { 30, null, "FirstName30", "LastName30", null, "U30" },
                    { 29, null, "FirstName29", "LastName29", null, "U29" },
                    { 28, null, "FirstName28", "LastName28", null, "U28" },
                    { 27, null, "FirstName27", "LastName27", null, "U27" },
                    { 37, null, "FirstName37", "LastName37", null, "U37" },
                    { 100, null, "FirstName100", "LastName100", null, "U100" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Users");
        }
    }
}
