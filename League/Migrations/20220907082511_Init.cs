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
                name: "PlayerTeam",
                columns: table => new
                {
                    PlayerId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TeamId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerTeam", x => x.PlayerId);
                    table.ForeignKey(
                        name: "FK_PlayerTeam_Player_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerTeam_Team_TeamId",
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
                    { "1106bddf-f117-4c5d-b1e2-356cd9bdd70a", "68fd6261-5437-49b2-b34f-136b30014118", "User", "USER" },
                    { "deab2041-3070-4ff9-be07-42ad63798dc4", "bec39e37-d4da-4412-a74a-d714409cb8d6", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[,]
                {
                    { "a1a6aabf-9f5b-447d-b4ba-377a6fd3843e", "5573bb84-0143-4f93-9f09-6c12ad7731ca", "admin@mail.com", null, "ADMIN@MAIL.COM", "ADMIN-NAME", "AQAAAAEAACcQAAAAECNOsAr6QLR0TsL9PlvUBicowJVyvoGXLDU/1d5dFRoI6pjXMMVrgp9Cy7LjS1MmKg==", null, "8e74b73b-c5b8-4426-aac4-68c542b02a04", "Admin-name" },
                    { "b2e1e05b-e152-4e6b-9fea-a5874e86792d", "31e9970c-5070-4f74-a037-d9e6cf6c9bef", "user@mail.com", null, "USER@MAIL.COM", "USER-NAME", "AQAAAAEAACcQAAAAEN0DHQN9D1hxacsMi++SlJXovBT9f7zO49jKFPRRtXFXhPqQmLDEJY7pCC8UsGVZOw==", null, "ce4273d3-c40f-499e-b67a-da03d5b79a48", "User-name" }
                });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "Id", "Name", "country", "dob", "number", "profileImage" },
                values: new object[,]
                {
                    { new Guid("086d6d6f-d3ff-4e78-abd9-aee1d75a361c"), "Taniya Hudson", " Niger", new DateTime(1998, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "defausl.jpg" },
                    { new Guid("1b925330-09f7-4742-b41e-d56950b71171"), "Kaitlyn Roberson", " Libya1", new DateTime(2026, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, "defausl.jpg" },
                    { new Guid("1d1c1469-79a7-4f33-bf8a-adf71bf8c32b"), "Sierra Shaffer", " Eritrea", new DateTime(2005, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, "defausl.jpg" },
                    { new Guid("2e5fa678-95ac-48b8-851f-a16d163bd3b7"), "Rosa Bentley", " Equatorial Guinea", new DateTime(1993, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 67, "defausl.jpg" },
                    { new Guid("30e4137b-a9ce-4faa-b9d1-c4ceb6891f25"), "Sierra Shaffer", " Eswatini", new DateTime(2011, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, "defausl.jpg" },
                    { new Guid("32f294b4-57e3-4f58-bb10-5a8d9844f68e"), "Norah Torres", " Mauritania1", new DateTime(2001, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "defausl.jpg" },
                    { new Guid("34b1bf97-d1d0-47cd-9b59-1f378aed2f25"), "Nadia Boyer", " Cameroon", new DateTime(1996, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 62, "defausl.jpg" },
                    { new Guid("3ae54e9e-339f-4c42-8728-90c9c7f79c0d"), "Rachael Rangel", " Malawi", new DateTime(1997, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, "defausl.jpg" },
                    { new Guid("3cbfed23-4f91-4ce1-96bd-3cb852dd1260"), "Tara Singh", " Liberia", new DateTime(2029, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "defausl.jpg" },
                    { new Guid("52071bdd-d192-4836-974c-8b0e3cfcb439"), "Cassie Combs", " Comoros1", new DateTime(1992, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 84, "defausl.jpg" },
                    { new Guid("61b3f62c-58b5-4009-a1c3-b28304a0ae58"), "Madden Henson", " Libya1", new DateTime(1998, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 82, "defausl.jpg" },
                    { new Guid("64451079-d569-4da4-bf5e-92a11750a453"), "Cameron Bell", " Guinea-Bissau", new DateTime(2006, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 91, "defausl.jpg" },
                    { new Guid("64a7f7ba-e494-44ed-88b4-f566da496b0b"), "Mckenna Wallace", " Ghana", new DateTime(2000, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 65, "defausl.jpg" },
                    { new Guid("6b250e60-f315-4610-ba2d-eaed835d0497"), "Bradley Campos", " Côte d'Ivoire", new DateTime(2025, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 56, "defausl.jpg" },
                    { new Guid("765b92d4-fc9b-4753-926f-4a0481bf54d6"), "Stella Avila", " Libya1", new DateTime(2001, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "defausl.jpg" },
                    { new Guid("79fd9104-fe4d-46ae-9507-e68389ad5496"), "Kaya Odonnell", " Kenya", new DateTime(2015, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 62, "defausl.jpg" },
                    { new Guid("80bf7cc8-5716-45bb-a2bb-fb9e7529cc82"), "Alexis Stuart", " Seychelles", new DateTime(2013, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, "defausl.jpg" },
                    { new Guid("9be85e40-fb6e-470e-b1fc-e91dedfce251"), "Urijah Ali", " Sierra Leone", new DateTime(2020, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 55, "defausl.jpg" },
                    { new Guid("a19653d8-71dd-470e-b94b-85125522ada8"), "Elias Cummings", " Réunion3", new DateTime(2026, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 94, "defausl.jpg" },
                    { new Guid("a42a9e6c-53b7-498c-9813-ff446c35b35a"), "Kaiden Young", " Angola", new DateTime(2027, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 94, "defausl.jpg" },
                    { new Guid("a86e4fa9-26bf-411d-b33f-0eb4dc124560"), "Brandon Crawford", " Eswatini", new DateTime(1990, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "defausl.jpg" },
                    { new Guid("ac687c89-5191-4ad0-9384-bc80cfbdf492"), "Donald Frederick", " Tanzania", new DateTime(2018, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 54, "defausl.jpg" },
                    { new Guid("ac981e48-32cc-40a0-98d8-87bec08ccc2d"), "Kaya Odonnell", " Burundi", new DateTime(2019, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, "defausl.jpg" },
                    { new Guid("b0c02032-db80-4a25-8fbe-ed108dc21590"), "Elias Cummings", " Nigeria", new DateTime(2001, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 84, "defausl.jpg" },
                    { new Guid("b1a89664-c109-4794-9d9c-2d50e568141e"), "Brandon Crawford", " Lesotho", new DateTime(1996, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, "defausl.jpg" },
                    { new Guid("c3552ef3-cf23-4377-88cb-5a36bbbbfef7"), "Clay Sexton", " Somalia1", new DateTime(2018, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 54, "defausl.jpg" },
                    { new Guid("cd67c983-1252-44c9-8005-e28141002d89"), "Cameron Bell", " Malawi", new DateTime(2000, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 77, "defausl.jpg" },
                    { new Guid("cf5baa22-2e81-4714-a694-877ae864c37d"), "Gerardo Spencer", " South Africa", new DateTime(2001, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, "defausl.jpg" },
                    { new Guid("db2bf779-aa03-4e8d-a6c9-65e4a9901175"), "Mckenna Wallace", " Réunion3", new DateTime(2000, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, "defausl.jpg" },
                    { new Guid("e2aa0675-ae9e-4ecc-ac15-5a5191acf3d0"), "Messiah Flores", " Congo", new DateTime(2028, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 98, "defausl.jpg" },
                    { new Guid("e3ae6962-b5c9-4b8d-9a3a-aaa4eeebb120"), "Nayeli Hoover", " Niger", new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 92, "defausl.jpg" },
                    { new Guid("f8135fd6-0566-4481-b2d3-91a299b926d5"), "Geovanni Buck", " Libya1", new DateTime(2008, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 66, "defausl.jpg" },
                    { new Guid("fa0aed89-3a11-49e4-b94c-c69fc200738a"), "Kaitlyn Roberson", " Djibouti1", new DateTime(1991, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 86, "defausl.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "Id", "Name", "coatch", "country", "foundatoinDate", "logo" },
                values: new object[,]
                {
                    { new Guid("908e7ba6-c44a-45e8-b7a0-83cd1f772f02"), "Javion Shaffer", "Bradley Campos", " Eswatini", new DateTime(1993, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "default.jpg" },
                    { new Guid("ea153dd8-ee89-4c98-bb6a-6952deae7bd5"), "Jayden Barajas", "Madelynn Tapia", " Somalia1", new DateTime(2029, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "default.jpg" },
                    { new Guid("ef768f66-8c19-4e7c-8f4b-8fb828658080"), "Rosa Bentley", "Jenna Phelps", " Réunion3", new DateTime(2022, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "default.jpg" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1106bddf-f117-4c5d-b1e2-356cd9bdd70a", "a1a6aabf-9f5b-447d-b4ba-377a6fd3843e" },
                    { "deab2041-3070-4ff9-be07-42ad63798dc4", "b2e1e05b-e152-4e6b-9fea-a5874e86792d" }
                });

            migrationBuilder.InsertData(
                table: "PlayerTeam",
                columns: new[] { "PlayerId", "TeamId" },
                values: new object[,]
                {
                    { new Guid("086d6d6f-d3ff-4e78-abd9-aee1d75a361c"), new Guid("ef768f66-8c19-4e7c-8f4b-8fb828658080") },
                    { new Guid("1b925330-09f7-4742-b41e-d56950b71171"), new Guid("ea153dd8-ee89-4c98-bb6a-6952deae7bd5") },
                    { new Guid("1d1c1469-79a7-4f33-bf8a-adf71bf8c32b"), new Guid("ea153dd8-ee89-4c98-bb6a-6952deae7bd5") },
                    { new Guid("2e5fa678-95ac-48b8-851f-a16d163bd3b7"), new Guid("ef768f66-8c19-4e7c-8f4b-8fb828658080") },
                    { new Guid("30e4137b-a9ce-4faa-b9d1-c4ceb6891f25"), new Guid("ef768f66-8c19-4e7c-8f4b-8fb828658080") },
                    { new Guid("32f294b4-57e3-4f58-bb10-5a8d9844f68e"), new Guid("ea153dd8-ee89-4c98-bb6a-6952deae7bd5") },
                    { new Guid("34b1bf97-d1d0-47cd-9b59-1f378aed2f25"), new Guid("ea153dd8-ee89-4c98-bb6a-6952deae7bd5") },
                    { new Guid("3ae54e9e-339f-4c42-8728-90c9c7f79c0d"), new Guid("ea153dd8-ee89-4c98-bb6a-6952deae7bd5") },
                    { new Guid("3cbfed23-4f91-4ce1-96bd-3cb852dd1260"), new Guid("908e7ba6-c44a-45e8-b7a0-83cd1f772f02") },
                    { new Guid("52071bdd-d192-4836-974c-8b0e3cfcb439"), new Guid("ef768f66-8c19-4e7c-8f4b-8fb828658080") },
                    { new Guid("61b3f62c-58b5-4009-a1c3-b28304a0ae58"), new Guid("908e7ba6-c44a-45e8-b7a0-83cd1f772f02") },
                    { new Guid("64451079-d569-4da4-bf5e-92a11750a453"), new Guid("908e7ba6-c44a-45e8-b7a0-83cd1f772f02") },
                    { new Guid("64a7f7ba-e494-44ed-88b4-f566da496b0b"), new Guid("ea153dd8-ee89-4c98-bb6a-6952deae7bd5") },
                    { new Guid("6b250e60-f315-4610-ba2d-eaed835d0497"), new Guid("ef768f66-8c19-4e7c-8f4b-8fb828658080") },
                    { new Guid("765b92d4-fc9b-4753-926f-4a0481bf54d6"), new Guid("ef768f66-8c19-4e7c-8f4b-8fb828658080") },
                    { new Guid("79fd9104-fe4d-46ae-9507-e68389ad5496"), new Guid("908e7ba6-c44a-45e8-b7a0-83cd1f772f02") },
                    { new Guid("80bf7cc8-5716-45bb-a2bb-fb9e7529cc82"), new Guid("ef768f66-8c19-4e7c-8f4b-8fb828658080") },
                    { new Guid("9be85e40-fb6e-470e-b1fc-e91dedfce251"), new Guid("ef768f66-8c19-4e7c-8f4b-8fb828658080") },
                    { new Guid("a19653d8-71dd-470e-b94b-85125522ada8"), new Guid("ef768f66-8c19-4e7c-8f4b-8fb828658080") },
                    { new Guid("a42a9e6c-53b7-498c-9813-ff446c35b35a"), new Guid("908e7ba6-c44a-45e8-b7a0-83cd1f772f02") },
                    { new Guid("a86e4fa9-26bf-411d-b33f-0eb4dc124560"), new Guid("908e7ba6-c44a-45e8-b7a0-83cd1f772f02") },
                    { new Guid("ac687c89-5191-4ad0-9384-bc80cfbdf492"), new Guid("908e7ba6-c44a-45e8-b7a0-83cd1f772f02") },
                    { new Guid("ac981e48-32cc-40a0-98d8-87bec08ccc2d"), new Guid("908e7ba6-c44a-45e8-b7a0-83cd1f772f02") },
                    { new Guid("b0c02032-db80-4a25-8fbe-ed108dc21590"), new Guid("ea153dd8-ee89-4c98-bb6a-6952deae7bd5") },
                    { new Guid("b1a89664-c109-4794-9d9c-2d50e568141e"), new Guid("908e7ba6-c44a-45e8-b7a0-83cd1f772f02") },
                    { new Guid("c3552ef3-cf23-4377-88cb-5a36bbbbfef7"), new Guid("ef768f66-8c19-4e7c-8f4b-8fb828658080") },
                    { new Guid("cd67c983-1252-44c9-8005-e28141002d89"), new Guid("ea153dd8-ee89-4c98-bb6a-6952deae7bd5") },
                    { new Guid("cf5baa22-2e81-4714-a694-877ae864c37d"), new Guid("ef768f66-8c19-4e7c-8f4b-8fb828658080") },
                    { new Guid("db2bf779-aa03-4e8d-a6c9-65e4a9901175"), new Guid("ea153dd8-ee89-4c98-bb6a-6952deae7bd5") },
                    { new Guid("e2aa0675-ae9e-4ecc-ac15-5a5191acf3d0"), new Guid("ea153dd8-ee89-4c98-bb6a-6952deae7bd5") },
                    { new Guid("e3ae6962-b5c9-4b8d-9a3a-aaa4eeebb120"), new Guid("908e7ba6-c44a-45e8-b7a0-83cd1f772f02") },
                    { new Guid("f8135fd6-0566-4481-b2d3-91a299b926d5"), new Guid("908e7ba6-c44a-45e8-b7a0-83cd1f772f02") },
                    { new Guid("fa0aed89-3a11-49e4-b94c-c69fc200738a"), new Guid("ea153dd8-ee89-4c98-bb6a-6952deae7bd5") }
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
                name: "IX_PlayerTeam_TeamId",
                table: "PlayerTeam",
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
                name: "PlayerTeam");

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
                name: "Player");

            migrationBuilder.DropTable(
                name: "Team");
        }
    }
}
