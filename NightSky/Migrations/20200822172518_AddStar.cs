using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NightSkyPopulateDatabase.Migrations
{
    public partial class AddStar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Universe",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    hip = table.Column<int>(nullable: false),
                    hd = table.Column<int>(nullable: false),
                    hr = table.Column<string>(nullable: true),
                    gl = table.Column<string>(nullable: true),
                    bf = table.Column<string>(nullable: true),
                    proper = table.Column<string>(nullable: true),
                    ra = table.Column<int>(nullable: false),
                    dec = table.Column<int>(nullable: false),
                    dist = table.Column<int>(nullable: false),
                    pmra = table.Column<int>(nullable: false),
                    pmdec = table.Column<int>(nullable: false),
                    rv = table.Column<int>(nullable: false),
                    mag = table.Column<int>(nullable: false),
                    absmag = table.Column<int>(nullable: false),
                    spect = table.Column<int>(nullable: false),
                    ci = table.Column<int>(nullable: false),
                    x = table.Column<int>(nullable: false),
                    y = table.Column<int>(nullable: false),
                    z = table.Column<int>(nullable: false),
                    vx = table.Column<int>(nullable: false),
                    vy = table.Column<int>(nullable: false),
                    vz = table.Column<int>(nullable: false),
                    rarad = table.Column<int>(nullable: false),
                    decrad = table.Column<int>(nullable: false),
                    pmrarad = table.Column<int>(nullable: false),
                    pmdecrad = table.Column<int>(nullable: false),
                    bayer = table.Column<string>(nullable: true),
                    flam = table.Column<string>(nullable: true),
                    con = table.Column<string>(nullable: true),
                    comp = table.Column<int>(nullable: false),
                    comp_primary = table.Column<int>(nullable: false),
                    lum = table.Column<int>(nullable: false),
                    var_min = table.Column<int>(nullable: false),
                    var_max = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Universe", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Universe");
        }
    }
}
