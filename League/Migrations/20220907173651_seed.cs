using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace League.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    number = table.Column<int>(type: "int", nullable: false),
                    profileImage = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    country = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dob = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RegisterationModel",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SetRoleModel",
                columns: table => new
                {
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    logo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    country = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    coatch = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    foundatoinDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TokenRequestModel",
                columns: table => new
                {
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TeamPlayer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    PlayerId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TeamId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamPlayer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamPlayer_Player_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamPlayer_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ec29a43e-ca00-41ad-a830-59e7bc99f252", "1419d974-450f-4dbe-a799-0902222a2d06", "User", "USER" },
                    { "f74b13a4-0178-4200-8783-6a5103329281", "d9a5cf58-2ea5-46dd-92bc-df2545d46e2b", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[,]
                {
                    { "58fd374a-9547-4eaa-af66-d9295fdac4bd", "f1c1502e-ef31-4bc9-8c74-07161fe94d62", "user@mail.com", null, "USER@MAIL.COM", "USER-NAME", "AQAAAAEAACcQAAAAEOWxnUYJQXPfTcJ7J2mNeuZRkU91IU3aNA5YUp9n/KC6itx+aitGYWXVWe/mXA7Y4w==", null, "2931039a-9080-4db2-a7af-64557f9b1eee", "User-name" },
                    { "d14f686b-1fc9-4587-899e-bdc7e10a883b", "12ed077a-4ac0-4e29-b61f-84ac144a6bd4", "admin@mail.com", null, "ADMIN@MAIL.COM", "ADMIN-NAME", "AQAAAAEAACcQAAAAED1R6DILjoj1CX253wPZfHrVijU6GKBLpUWfij7zQwOaj8eGjrlMy7DG45VZiPYRog==", null, "d68773bb-088a-49c4-af2a-8ecf2bf4b61a", "Admin-name" }
                });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "Id", "Name", "country", "dob", "number", "profileImage" },
                values: new object[,]
                {
                    { new Guid("033b3e4d-6bcf-44ca-a39b-f3b43eb52bda"), "Amari Riddle", " Benin", new DateTime(1999, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "defausl.jpg" },
                    { new Guid("0438a053-5ec4-49e8-a466-ccc783e82b4a"), "Messiah Flores", " Somalia1", new DateTime(1990, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, "defausl.jpg" },
                    { new Guid("047ac3b6-e5fd-4976-9eed-0e7489b9a179"), "Tara Singh", " Comoros1", new DateTime(2000, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "defausl.jpg" },
                    { new Guid("09608c1a-41fd-4c10-bf54-9168f4d8e26f"), "Jenna Phelps", " Burundi", new DateTime(2009, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 99, "defausl.jpg" },
                    { new Guid("0d2c6043-c3f2-4f42-bf93-a115e4fc9298"), "Nayeli Hoover", " Mozambique", new DateTime(2007, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "defausl.jpg" },
                    { new Guid("20146fa7-a20b-445b-8ffc-f4502232c43a"), "Mary Powers", " Somalia1", new DateTime(2029, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "defausl.jpg" },
                    { new Guid("285f01b4-5628-4d86-8c17-b8e21b651122"), "Sierra Shaffer", " Senegal", new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "defausl.jpg" },
                    { new Guid("2a4e7601-70ce-4109-9732-dd1c7ae29150"), "Donald Frederick", " Zambia", new DateTime(2012, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 68, "defausl.jpg" },
                    { new Guid("3a6e45e4-4dc0-48fd-91b4-f7508642c7a8"), "Brandon Crawford", " Zambia", new DateTime(2021, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, "defausl.jpg" },
                    { new Guid("64b1bcd5-8ab9-4eb3-a368-535861868b75"), "Mary Powers", " Réunion3", new DateTime(2004, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, "defausl.jpg" },
                    { new Guid("6726b5ab-ce06-446f-a195-800d4727a5fe"), "Jenna Phelps", " Kenya", new DateTime(2009, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "defausl.jpg" },
                    { new Guid("6a4c58d1-fbb4-458a-8075-2ba414117547"), "Tara Singh", " Niger", new DateTime(1992, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 78, "defausl.jpg" },
                    { new Guid("6e017a3e-5fb3-4a72-a073-282b9234b1f1"), "Nayeli Hoover", " Namibia", new DateTime(2009, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 63, "defausl.jpg" },
                    { new Guid("7c1a389c-d1f5-44b8-9d18-3d06e7186100"), "Genevieve Alvarado", " Nigeria", new DateTime(2006, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 58, "defausl.jpg" },
                    { new Guid("8985de20-c3b0-44fd-b4ae-38bc9e0fef19"), "Terrence Navarro", " Guinea", new DateTime(2029, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 82, "defausl.jpg" },
                    { new Guid("8b2033a0-2818-4d47-a895-b859a32acfab"), "Bradley Campos", " Mali", new DateTime(2029, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "defausl.jpg" },
                    { new Guid("8bae93c9-c1aa-4777-84e6-945c4ceb8a8b"), "Geovanni Buck", " Comoros1", new DateTime(1991, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, "defausl.jpg" },
                    { new Guid("8ed88691-c5e0-4a13-b196-8426e8a8f3d0"), "Tara Singh", " Zimbabwe", new DateTime(2006, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, "defausl.jpg" },
                    { new Guid("953f3442-aab2-4d98-bdc6-8a63b1b5b23c"), "Josue Kelly", " Uganda", new DateTime(1992, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "defausl.jpg" },
                    { new Guid("955434c7-a479-49f6-ad5e-706fcea6b506"), "Genevieve Alvarado", " Benin", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 54, "defausl.jpg" },
                    { new Guid("966cf1f1-900a-4329-9490-9822b4388d55"), "Tara Singh", " Côte d'Ivoire", new DateTime(2007, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 81, "defausl.jpg" },
                    { new Guid("9e9c4928-84f8-47ba-b596-f7ddbf16ae5d"), "Madden Henson", " Congo DR2", new DateTime(1995, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 81, "defausl.jpg" },
                    { new Guid("9fb7900e-bab0-4225-9ed9-e2521d73f02a"), "Josue Kelly", " Angola", new DateTime(1991, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, "defausl.jpg" },
                    { new Guid("a6e0a3c2-f6b5-4670-8f00-7502d8b3076c"), "Julius Jacobson", " Congo", new DateTime(2016, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "defausl.jpg" },
                    { new Guid("aaba9cb7-64ec-438c-98e5-954fdbf73e3b"), "Ronnie Morse", " Zimbabwe", new DateTime(2022, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "defausl.jpg" },
                    { new Guid("b773b589-92fc-4011-8382-6d33d52da914"), "Alexis Stuart", " Guinea", new DateTime(2029, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, "defausl.jpg" },
                    { new Guid("bd457779-dbb1-4453-9899-de3cc113c90a"), "Mckenna Wallace", " Lesotho", new DateTime(2016, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "defausl.jpg" },
                    { new Guid("d515e7c2-ef90-4ee0-9cb8-c410b07aba6b"), "Madelynn Tapia", " Mozambique", new DateTime(2022, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 95, "defausl.jpg" },
                    { new Guid("e64fde75-1388-41c7-9dd9-334dbd8e4b36"), "Josue Kelly", " Liberia", new DateTime(2002, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 97, "defausl.jpg" },
                    { new Guid("ef583876-0fd6-473c-9619-a407109b92d0"), "Rosa Bentley", " Namibia", new DateTime(2000, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 86, "defausl.jpg" },
                    { new Guid("f0df670d-69c7-41dd-b137-65e45c4847b3"), "Javion Shaffer", " Senegal", new DateTime(2025, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 76, "defausl.jpg" },
                    { new Guid("f81fb768-80ed-4475-a9bc-0bc9e65b0477"), "Jayden Barajas", " Mauritius", new DateTime(1996, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, "defausl.jpg" },
                    { new Guid("f83e95a0-b1d7-4473-aa77-4163d0a0ab44"), "Rachael Rangel", " Togo", new DateTime(2005, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 52, "defausl.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "Id", "Name", "coatch", "country", "foundatoinDate", "logo" },
                values: new object[,]
                {
                    { new Guid("44665309-03d6-461c-b322-7964f75cedd0"), "Jazmin Schwartz", "Bradley Campos", " Botswana", new DateTime(2027, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "default.jpg" },
                    { new Guid("a3cf8d44-2948-4db8-ac86-a609d8fbf886"), "Tara Singh", "Cassie Combs", " Nigeria", new DateTime(1999, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "default.jpg" },
                    { new Guid("ca14dbb4-c145-49ec-a3bd-4ab91b41ece7"), "Kaylee Guerra", "Madelynn Tapia", " Congo", new DateTime(2006, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "default.jpg" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ec29a43e-ca00-41ad-a830-59e7bc99f252", "58fd374a-9547-4eaa-af66-d9295fdac4bd" },
                    { "f74b13a4-0178-4200-8783-6a5103329281", "d14f686b-1fc9-4587-899e-bdc7e10a883b" }
                });

            migrationBuilder.InsertData(
                table: "TeamPlayer",
                columns: new[] { "Id", "PlayerId", "TeamId" },
                values: new object[,]
                {
                    { new Guid("121e18bd-6008-4f8f-82ff-aded2c226fd6"), new Guid("8b2033a0-2818-4d47-a895-b859a32acfab"), new Guid("a3cf8d44-2948-4db8-ac86-a609d8fbf886") },
                    { new Guid("14e0172c-98d5-473e-98ac-f82d2a9a361c"), new Guid("9e9c4928-84f8-47ba-b596-f7ddbf16ae5d"), new Guid("a3cf8d44-2948-4db8-ac86-a609d8fbf886") },
                    { new Guid("19e680b5-1514-44fc-a11c-9d39ffe7de58"), new Guid("a6e0a3c2-f6b5-4670-8f00-7502d8b3076c"), new Guid("a3cf8d44-2948-4db8-ac86-a609d8fbf886") },
                    { new Guid("1bfe6655-d83e-4f5d-93d6-f20d4e52ed2e"), new Guid("7c1a389c-d1f5-44b8-9d18-3d06e7186100"), new Guid("44665309-03d6-461c-b322-7964f75cedd0") },
                    { new Guid("33636c64-7cf9-461e-bf84-738b457c9e9a"), new Guid("9fb7900e-bab0-4225-9ed9-e2521d73f02a"), new Guid("ca14dbb4-c145-49ec-a3bd-4ab91b41ece7") },
                    { new Guid("3791c234-14db-410b-bd2d-2c77106297e8"), new Guid("ef583876-0fd6-473c-9619-a407109b92d0"), new Guid("44665309-03d6-461c-b322-7964f75cedd0") },
                    { new Guid("3dab0c68-9ed7-4cb3-9cbe-16766e26ec3c"), new Guid("2a4e7601-70ce-4109-9732-dd1c7ae29150"), new Guid("ca14dbb4-c145-49ec-a3bd-4ab91b41ece7") },
                    { new Guid("4af46ce2-4eee-47df-b158-3e11cff9353c"), new Guid("e64fde75-1388-41c7-9dd9-334dbd8e4b36"), new Guid("44665309-03d6-461c-b322-7964f75cedd0") },
                    { new Guid("4ce0b163-b651-4c45-84a5-5db3147e007a"), new Guid("6726b5ab-ce06-446f-a195-800d4727a5fe"), new Guid("44665309-03d6-461c-b322-7964f75cedd0") },
                    { new Guid("4fd916a5-405a-40a9-bdb2-835e8de62933"), new Guid("b773b589-92fc-4011-8382-6d33d52da914"), new Guid("44665309-03d6-461c-b322-7964f75cedd0") },
                    { new Guid("506dbf35-15a4-48bf-a08f-8ec098f7e63c"), new Guid("8ed88691-c5e0-4a13-b196-8426e8a8f3d0"), new Guid("a3cf8d44-2948-4db8-ac86-a609d8fbf886") },
                    { new Guid("51e2314b-2853-4644-ab67-7da23907f6e7"), new Guid("8bae93c9-c1aa-4777-84e6-945c4ceb8a8b"), new Guid("a3cf8d44-2948-4db8-ac86-a609d8fbf886") },
                    { new Guid("51e3de0f-f21e-4d43-bb2c-899f7d299c07"), new Guid("64b1bcd5-8ab9-4eb3-a368-535861868b75"), new Guid("a3cf8d44-2948-4db8-ac86-a609d8fbf886") },
                    { new Guid("59e15bf8-5188-4706-b602-1aa710ef9d94"), new Guid("f81fb768-80ed-4475-a9bc-0bc9e65b0477"), new Guid("44665309-03d6-461c-b322-7964f75cedd0") },
                    { new Guid("608b6803-5050-4087-ad30-b61f8efaecea"), new Guid("047ac3b6-e5fd-4976-9eed-0e7489b9a179"), new Guid("ca14dbb4-c145-49ec-a3bd-4ab91b41ece7") },
                    { new Guid("6cf2d5f4-5911-4161-95fe-e8018992ef18"), new Guid("285f01b4-5628-4d86-8c17-b8e21b651122"), new Guid("ca14dbb4-c145-49ec-a3bd-4ab91b41ece7") },
                    { new Guid("7758d267-48da-4d4d-b462-da8eaf3e780e"), new Guid("d515e7c2-ef90-4ee0-9cb8-c410b07aba6b"), new Guid("44665309-03d6-461c-b322-7964f75cedd0") },
                    { new Guid("80b9b124-f36c-445f-8e1c-c0d9c5991b5f"), new Guid("f0df670d-69c7-41dd-b137-65e45c4847b3"), new Guid("ca14dbb4-c145-49ec-a3bd-4ab91b41ece7") },
                    { new Guid("8c4b5f94-6b5b-4eb2-925b-c1cf4ae31cf0"), new Guid("aaba9cb7-64ec-438c-98e5-954fdbf73e3b"), new Guid("ca14dbb4-c145-49ec-a3bd-4ab91b41ece7") },
                    { new Guid("95298ac7-d8dc-4234-accf-114c0b397e9e"), new Guid("8985de20-c3b0-44fd-b4ae-38bc9e0fef19"), new Guid("ca14dbb4-c145-49ec-a3bd-4ab91b41ece7") },
                    { new Guid("9ea21d2e-dd06-4ea4-8c7f-d27eb9e08333"), new Guid("0438a053-5ec4-49e8-a466-ccc783e82b4a"), new Guid("44665309-03d6-461c-b322-7964f75cedd0") },
                    { new Guid("a8f71d7e-e2fc-4424-90fb-c0906a8e6193"), new Guid("3a6e45e4-4dc0-48fd-91b4-f7508642c7a8"), new Guid("44665309-03d6-461c-b322-7964f75cedd0") },
                    { new Guid("ade6484b-a672-4995-9f46-ebf415864623"), new Guid("6a4c58d1-fbb4-458a-8075-2ba414117547"), new Guid("a3cf8d44-2948-4db8-ac86-a609d8fbf886") },
                    { new Guid("b650282e-b676-4b74-bb25-a461a74bce6e"), new Guid("bd457779-dbb1-4453-9899-de3cc113c90a"), new Guid("a3cf8d44-2948-4db8-ac86-a609d8fbf886") },
                    { new Guid("b7633c3a-4348-4bbd-8cdd-7deee97cd750"), new Guid("f83e95a0-b1d7-4473-aa77-4163d0a0ab44"), new Guid("a3cf8d44-2948-4db8-ac86-a609d8fbf886") },
                    { new Guid("c186eaff-d533-44d6-ba15-37b7d37b5e83"), new Guid("955434c7-a479-49f6-ad5e-706fcea6b506"), new Guid("ca14dbb4-c145-49ec-a3bd-4ab91b41ece7") },
                    { new Guid("ca79fda0-f72b-45c3-87a6-88beb8ffe013"), new Guid("20146fa7-a20b-445b-8ffc-f4502232c43a"), new Guid("44665309-03d6-461c-b322-7964f75cedd0") },
                    { new Guid("d1aae722-3ffe-4637-87f7-cb503fe7bb50"), new Guid("953f3442-aab2-4d98-bdc6-8a63b1b5b23c"), new Guid("ca14dbb4-c145-49ec-a3bd-4ab91b41ece7") },
                    { new Guid("d6960aaa-13cc-4fe7-bd1c-79c7fc384399"), new Guid("6e017a3e-5fb3-4a72-a073-282b9234b1f1"), new Guid("a3cf8d44-2948-4db8-ac86-a609d8fbf886") },
                    { new Guid("da4e932c-94e1-48b5-9d07-8e950216a9fb"), new Guid("09608c1a-41fd-4c10-bf54-9168f4d8e26f"), new Guid("a3cf8d44-2948-4db8-ac86-a609d8fbf886") },
                    { new Guid("df627692-e41c-4bcb-9588-c8f5e79d2526"), new Guid("966cf1f1-900a-4329-9490-9822b4388d55"), new Guid("ca14dbb4-c145-49ec-a3bd-4ab91b41ece7") },
                    { new Guid("e35608ce-b696-419a-ab4a-a9dcf5d8114c"), new Guid("0d2c6043-c3f2-4f42-bf93-a115e4fc9298"), new Guid("ca14dbb4-c145-49ec-a3bd-4ab91b41ece7") },
                    { new Guid("f7a4add3-5df7-4052-9650-e894d5f54920"), new Guid("033b3e4d-6bcf-44ca-a39b-f3b43eb52bda"), new Guid("44665309-03d6-461c-b322-7964f75cedd0") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TeamPlayer_PlayerId",
                table: "TeamPlayer",
                column: "PlayerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TeamPlayer_TeamId",
                table: "TeamPlayer",
                column: "TeamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "RegisterationModel");

            migrationBuilder.DropTable(
                name: "SetRoleModel");

            migrationBuilder.DropTable(
                name: "TeamPlayer");

            migrationBuilder.DropTable(
                name: "TokenRequestModel");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "Team");
        }
    }
}
