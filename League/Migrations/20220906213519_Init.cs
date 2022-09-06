using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace League.Migrations
{
    public partial class Init : Migration
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
                name: "Player",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TeamId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
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
                    table.ForeignKey(
                        name: "FK_Player_Team_TeamId",
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
                    { "36a9cc46-246f-4be2-a26b-4613a14ea88b", "6e67a81b-7cd0-4f29-bb14-f6451530bac8", "Admin", "ADMIN" },
                    { "69af0914-f9d7-419f-9bca-d62e497d5d07", "c5e76094-54f3-45c1-9852-4863e4db9ece", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[,]
                {
                    { "73d4f91b-e124-4859-b501-2f9feb3f2f9f", "7f14fab6-6af4-4143-b223-7d76a66cdc4e", "user@mail.xyz", null, "USER@MAIL.XYZ", "USER-NAME", "AQAAAAEAACcQAAAAED00w2GzAUUOCxyhz/bsQODU+0oS5WgGm8TNNIq/Woo/a/tjh5f+W4fGfee+n86ESA==", null, "91dbaaff-be93-447a-8088-bd91759bf776", "User-name" },
                    { "bc3b73d3-3f25-4414-bace-3fef258dbb5a", "0b8de385-e027-4089-a8b3-214e796e5057", "admin@mail.xyz", null, "ADMIN@MAIL.XYZ", "ADMIN-NAME", "AQAAAAEAACcQAAAAEKb2h6rJNcXhKxBz3jinn498QxMC8O1j4LgcG6tD7FhmChbAna+RTl/0aUahWKJgwQ==", null, "0e9d2a8f-b321-47b4-beb0-5c34c4a1a438", "Admin-name" }
                });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "Id", "Name", "TeamId", "country", "dob", "number", "profileImage" },
                values: new object[,]
                {
                    { new Guid("0ce337f1-7196-4006-8d4c-cfcde6c951b8"), "Geovanni Buck", new Guid("00000000-0000-0000-0000-000000000000"), " Senegal", new DateTime(2021, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, "defausl.jpg" },
                    { new Guid("0f068910-5c16-4e28-b6a6-bde1b87697ba"), "Jazmin Schwartz", new Guid("00000000-0000-0000-0000-000000000000"), " Mauritania1", new DateTime(1995, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 68, "defausl.jpg" },
                    { new Guid("13e98150-0e45-4ec3-bb64-aa0c1aba0fb4"), "Julius Jacobson", new Guid("00000000-0000-0000-0000-000000000000"), " South Sudan", new DateTime(2012, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 58, "defausl.jpg" },
                    { new Guid("1a288631-0c77-46ad-bca7-830ee156f1e2"), "Elias Cummings", new Guid("00000000-0000-0000-0000-000000000000"), " Zimbabwe", new DateTime(2007, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 89, "defausl.jpg" },
                    { new Guid("1a70f71e-c056-4574-8385-287caaf64344"), "Madden Henson", new Guid("00000000-0000-0000-0000-000000000000"), " São Tomé and Príncipe", new DateTime(2025, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "defausl.jpg" },
                    { new Guid("2049d33c-2f3d-44f1-ac36-0c20c85116e6"), "Rosa Bentley", new Guid("00000000-0000-0000-0000-000000000000"), " South Sudan", new DateTime(2026, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 72, "defausl.jpg" },
                    { new Guid("2511c1e2-ad68-4692-b80f-2ba53be22366"), "Brandon Crawford", new Guid("00000000-0000-0000-0000-000000000000"), " Mali", new DateTime(2015, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, "defausl.jpg" },
                    { new Guid("25c6c96a-01e9-4e06-8700-b76ac8813c40"), "Kaya Odonnell", new Guid("00000000-0000-0000-0000-000000000000"), " Somalia1", new DateTime(2016, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "defausl.jpg" },
                    { new Guid("2b97df2a-d481-4140-afbb-4cd53e87e00d"), "Elias Cummings", new Guid("00000000-0000-0000-0000-000000000000"), " Eswatini", new DateTime(2009, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "defausl.jpg" },
                    { new Guid("32d501f0-80c4-450e-a755-2a24fb30e640"), "Alexis Stuart", new Guid("00000000-0000-0000-0000-000000000000"), " Egypt1", new DateTime(2009, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 75, "defausl.jpg" },
                    { new Guid("41b992f5-436d-47e2-addf-c623105b425b"), "Ansley Knight", new Guid("00000000-0000-0000-0000-000000000000"), " Madagascar", new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 54, "defausl.jpg" },
                    { new Guid("4c25a056-8e8d-4f28-b6f0-08444c458ce3"), "Kaitlyn Roberson", new Guid("00000000-0000-0000-0000-000000000000"), " Ethiopia", new DateTime(2026, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "defausl.jpg" },
                    { new Guid("58c5526a-7353-498f-a838-56797f2c42ad"), "Sierra Shaffer", new Guid("00000000-0000-0000-0000-000000000000"), " Libya1", new DateTime(1999, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "defausl.jpg" },
                    { new Guid("58d414f5-960f-4b8e-b461-4cbf4628f4ab"), "Jenna Phelps", new Guid("00000000-0000-0000-0000-000000000000"), " Cape Verde", new DateTime(2018, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "defausl.jpg" },
                    { new Guid("5f13a9ff-5900-41c7-a567-e4958c83ae0a"), "Gerardo Spencer", new Guid("00000000-0000-0000-0000-000000000000"), " Gabon", new DateTime(2011, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 65, "defausl.jpg" },
                    { new Guid("6523c7ce-2435-4251-833c-9f1ad25f611e"), "Tara Singh", new Guid("00000000-0000-0000-0000-000000000000"), " Réunion3", new DateTime(2011, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 53, "defausl.jpg" },
                    { new Guid("6be0b620-0e61-42e6-8838-2a17055c6edc"), "Clay Sexton", new Guid("00000000-0000-0000-0000-000000000000"), " Mauritius", new DateTime(2011, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 87, "defausl.jpg" },
                    { new Guid("728576e9-e1a9-4371-8868-7740dcd03fd0"), "Francis Garrett", new Guid("00000000-0000-0000-0000-000000000000"), " Niger", new DateTime(2020, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, "defausl.jpg" },
                    { new Guid("729052de-6a2e-411a-87f6-06134eda2977"), "Taniya Hudson", new Guid("00000000-0000-0000-0000-000000000000"), " Madagascar", new DateTime(2005, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 67, "defausl.jpg" },
                    { new Guid("87d9fa5e-ee3f-46a7-8b9b-56ada805e0ff"), "Josue Kelly", new Guid("00000000-0000-0000-0000-000000000000"), " Djibouti1", new DateTime(2026, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 59, "defausl.jpg" },
                    { new Guid("92b91252-130a-478d-8a18-24a03a0b4964"), "Jayden Barajas", new Guid("00000000-0000-0000-0000-000000000000"), " Burkina Faso", new DateTime(2019, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "defausl.jpg" },
                    { new Guid("940ce9ff-a97e-4c94-9b2d-925aa90c6ac2"), "Brandon Crawford", new Guid("00000000-0000-0000-0000-000000000000"), " Congo", new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, "defausl.jpg" },
                    { new Guid("acd9e19d-cae0-4884-b7ed-7f0119726aee"), "Brandon Crawford", new Guid("00000000-0000-0000-0000-000000000000"), " Gabon", new DateTime(2006, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 55, "defausl.jpg" },
                    { new Guid("b1f8c875-5c86-4c9c-a27d-cf298dab290b"), "Mckenna Wallace", new Guid("00000000-0000-0000-0000-000000000000"), " Eswatini", new DateTime(1993, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "defausl.jpg" },
                    { new Guid("b8861eef-9d1a-4e0f-8251-4df53fd65c22"), "Kaiden Young", new Guid("00000000-0000-0000-0000-000000000000"), " Mali", new DateTime(1991, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 59, "defausl.jpg" },
                    { new Guid("bb2f5cc1-08e2-4d27-8899-c441dae7d2ae"), "Chaz Stuart", new Guid("00000000-0000-0000-0000-000000000000"), " Mauritania1", new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 72, "defausl.jpg" },
                    { new Guid("c0026795-40c1-4d48-9658-434c023b3b76"), "Jenna Phelps", new Guid("00000000-0000-0000-0000-000000000000"), " Guinea-Bissau", new DateTime(2002, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "defausl.jpg" },
                    { new Guid("d8d91fc1-d533-454d-ab8c-f97697ceeac0"), "Ronnie Morse", new Guid("00000000-0000-0000-0000-000000000000"), " Senegal", new DateTime(2010, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, "defausl.jpg" },
                    { new Guid("dfc5c104-fa5e-450b-ba26-fd006c7ac16b"), "Miles Jimenez", new Guid("00000000-0000-0000-0000-000000000000"), " São Tomé and Príncipe", new DateTime(2017, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 92, "defausl.jpg" },
                    { new Guid("e2baf573-3b8e-4cfb-b027-47c9cdeb916d"), "Messiah Flores", new Guid("00000000-0000-0000-0000-000000000000"), " Comoros1", new DateTime(1995, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 97, "defausl.jpg" },
                    { new Guid("e555b30a-28ad-4647-a6ac-186bbfdddacf"), "Gerardo Spencer", new Guid("00000000-0000-0000-0000-000000000000"), " Morocco1", new DateTime(2019, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 86, "defausl.jpg" },
                    { new Guid("e9a3d811-a049-4128-9c19-b34de1f9ef0b"), "Julius Jacobson", new Guid("00000000-0000-0000-0000-000000000000"), " Eswatini", new DateTime(2029, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 73, "defausl.jpg" },
                    { new Guid("f3629775-4ba4-4494-b1aa-5dbec52d607b"), "Nayeli Hoover", new Guid("00000000-0000-0000-0000-000000000000"), " Seychelles", new DateTime(1997, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, "defausl.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "Id", "Name", "coatch", "country", "foundatoinDate", "logo" },
                values: new object[,]
                {
                    { new Guid("719156db-cf15-4630-9616-a2236828b471"), "Philippines", "Jordan", " Uganda", new DateTime(2016, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "default.jpg" },
                    { new Guid("7531d7c8-d544-413c-b5a7-ce8a548efea5"), "Jordan", "Laos", " South Africa", new DateTime(2001, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "default.jpg" },
                    { new Guid("f91733d7-8581-4784-8175-1f2ee237786a"), "Guam", "Bhutan", " Mozambique", new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "default.jpg" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "36a9cc46-246f-4be2-a26b-4613a14ea88b", "73d4f91b-e124-4859-b501-2f9feb3f2f9f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "69af0914-f9d7-419f-9bca-d62e497d5d07", "bc3b73d3-3f25-4414-bace-3fef258dbb5a" });

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
                name: "IX_Player_TeamId",
                table: "Player",
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
                name: "Player");

            migrationBuilder.DropTable(
                name: "RegisterationModel");

            migrationBuilder.DropTable(
                name: "SetRoleModel");

            migrationBuilder.DropTable(
                name: "TokenRequestModel");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Team");
        }
    }
}
