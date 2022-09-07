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
                    { "2fe8284b-b2f9-4615-85b9-2db38fbd0ce7", "5a71a0df-6486-4410-993a-939988b8e4f6", "Admin", "ADMIN" },
                    { "94316ed8-e8fd-44dc-9e9a-a14eab919615", "c671014f-8a7a-48e2-a7c3-1aaec1a30f65", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "ConcurrencyStamp", "Email", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[,]
                {
                    { "6056a156-d00d-49b4-89ed-7a20a67d68e8", "c8b25b5b-67f5-43b5-b3a1-51518de077b7", "admin@mail.com", null, "ADMIN@MAIL.COM", "ADMIN-NAME", "AQAAAAEAACcQAAAAEGktDHwQHsaeibvsPiZXTb/JPOe5Z3SvR5EYXJqZpRaUQNc6YJltyLpuJaEJDz4AJQ==", null, "e23b862d-867b-4d39-900b-11331182191e", "Admin-name" },
                    { "c8a9a1ae-809d-45e2-bcd6-5a2492df41cd", "cfac45c7-fb33-4b51-bc14-f30458ba76fc", "user@mail.com", null, "USER@MAIL.COM", "USER-NAME", "AQAAAAEAACcQAAAAEEbwZIFcX6/pPSplMrolrkYWnIHjQ74sX6kT2w6PBDVUMKrCBTGVfMPlz1B+j90joA==", null, "90ea6e4b-3eb8-4a2a-9649-4e3078a6553f", "User-name" }
                });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "Id", "Name", "country", "dob", "number", "profileImage" },
                values: new object[,]
                {
                    { new Guid("056c5015-3562-450b-89ca-491e1baf7002"), "Kaitlyn Roberson", " Benin", new DateTime(2009, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 62, "defausl.jpg" },
                    { new Guid("0c4c7ed2-9a42-445e-bae1-6e2c21ea9702"), "America Parrish", " Eritrea", new DateTime(2024, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, "defausl.jpg" },
                    { new Guid("0fc02f76-8e9c-4129-a020-117c4d89709b"), "Nadia Boyer", " Eswatini", new DateTime(2010, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 88, "defausl.jpg" },
                    { new Guid("14161cc5-fa8a-4b5a-829e-53b39bd5f96f"), "Sierra Shaffer", " Nigeria", new DateTime(1993, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 71, "defausl.jpg" },
                    { new Guid("1521f22a-b2e9-41bc-a1e0-89c419945019"), "Nadia Boyer", " Niger", new DateTime(2015, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 54, "defausl.jpg" },
                    { new Guid("2061d97e-338f-4fe6-a9f0-e16357169169"), "Bradley Campos", " Kenya", new DateTime(2013, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "defausl.jpg" },
                    { new Guid("222e6af2-e6e6-4469-a3e9-93aec0f0cfa7"), "Alexis Stuart", " Nigeria", new DateTime(2013, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 51, "defausl.jpg" },
                    { new Guid("25790383-4f35-4d9a-bd21-f71d51974e84"), "Cameron Bell", " Cape Verde", new DateTime(2013, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 77, "defausl.jpg" },
                    { new Guid("2fcbcec5-a6a3-46dc-aa19-b64ccc57fd97"), "Rachael Rangel", " South Africa", new DateTime(2012, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 64, "defausl.jpg" },
                    { new Guid("3ad576ef-30da-43d5-8ab9-0cbbe07e48f1"), "Francis Garrett", " Angola", new DateTime(2029, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 98, "defausl.jpg" },
                    { new Guid("61f07810-14fe-46da-a19e-40241fcf003d"), "Genevieve Alvarado", " Mauritania1", new DateTime(1990, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, "defausl.jpg" },
                    { new Guid("7319a7f7-d0dd-43ac-a516-1024b0289f4a"), "Donald Frederick", " Libya1", new DateTime(2015, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 54, "defausl.jpg" },
                    { new Guid("7dec8e20-54af-4500-8262-ed37adb60f4b"), "Mary Powers", " Seychelles", new DateTime(2003, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 65, "defausl.jpg" },
                    { new Guid("7ed4e691-07e5-478a-9396-d0fcba41080f"), "Francis Garrett", " Cameroon", new DateTime(1993, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 77, "defausl.jpg" },
                    { new Guid("8179e907-6910-4a0c-8183-a3e1f375e269"), "Bradley Campos", " Tunisia1", new DateTime(2009, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 98, "defausl.jpg" },
                    { new Guid("8214ad74-9564-4b15-b70b-2dea9d0a262a"), "Agustin Arias", " Ghana", new DateTime(1990, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, "defausl.jpg" },
                    { new Guid("8aa18562-783e-4ab7-91cf-a697cd6dd261"), "Cameron Bell", " Mauritius", new DateTime(1998, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, "defausl.jpg" },
                    { new Guid("8aef9d3f-36a3-4bc6-a91a-21bd92448ba3"), "Donald Frederick", " Ghana", new DateTime(2006, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 75, "defausl.jpg" },
                    { new Guid("8bad3297-ce67-400a-8d6d-ab36b7278325"), "Sierra Shaffer", " Equatorial Guinea", new DateTime(2013, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "defausl.jpg" },
                    { new Guid("9ddfadd1-b48c-44d0-b9dd-69e233d63b68"), "Josue Kelly", " Nigeria", new DateTime(1993, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, "defausl.jpg" },
                    { new Guid("a6e67247-9627-4a05-ae3d-c80d4fdfb3f9"), "Sierra Shaffer", " Burundi", new DateTime(1992, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 78, "defausl.jpg" },
                    { new Guid("af708704-33f1-4e53-b142-fd4a3cdbe1fc"), "Rachael Rangel", " Liberia", new DateTime(2016, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, "defausl.jpg" },
                    { new Guid("b0cab865-8eca-461f-bf24-8353a6c1b15d"), "Nadia Boyer", " Gambia", new DateTime(1997, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 98, "defausl.jpg" },
                    { new Guid("b57d1442-2389-4bf9-bd3a-5fd4b01a18fa"), "Norah Torres", " Malawi", new DateTime(2018, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 82, "defausl.jpg" },
                    { new Guid("c1b9c28d-6194-4093-8d39-28e44d5a3aac"), "Geovanni Buck", " Liberia", new DateTime(1991, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, "defausl.jpg" },
                    { new Guid("d3e1a894-dc6c-4116-8efa-39e1ce813e84"), "Taniya Hudson", " Burkina Faso", new DateTime(2008, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 80, "defausl.jpg" },
                    { new Guid("d549823b-07b9-4784-82c5-a051c2f1d283"), "Rachael Rangel", " Malawi", new DateTime(1998, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "defausl.jpg" },
                    { new Guid("ddf83261-73b7-46d6-8777-ff47e7673be6"), "Jenna Phelps", " Djibouti1", new DateTime(2010, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "defausl.jpg" },
                    { new Guid("e0c8af6e-9db6-42dd-a7a2-9df247e88b29"), "Nadia Boyer", " Congo", new DateTime(2011, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 87, "defausl.jpg" },
                    { new Guid("e315a20f-e3bb-432e-bafa-b1fbfcb02c75"), "Agustin Arias", " Cape Verde", new DateTime(2025, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 98, "defausl.jpg" },
                    { new Guid("f22ccec5-7698-4e4f-9494-071c9a6f080d"), "Elias Cummings", " Nigeria", new DateTime(2000, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 58, "defausl.jpg" },
                    { new Guid("fd483293-3066-4bcf-a474-a820b177ec90"), "Philip Ramos", " Congo DR2", new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "defausl.jpg" },
                    { new Guid("febf4050-ff14-4425-a362-69cbff365efb"), "Kaitlyn Roberson", " Botswana", new DateTime(1994, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, "defausl.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "Id", "Name", "coatch", "country", "foundatoinDate", "logo" },
                values: new object[,]
                {
                    { new Guid("4b7bc5b3-3914-47dc-8d83-1de3e437ff26"), "Kaitlyn Roberson", "Amari Riddle", " Ethiopia", new DateTime(2027, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "default.jpg" },
                    { new Guid("c9c42417-de22-469b-ba1e-11179ecb26a8"), "Urijah Ali", "Cameron Bell", " Burundi", new DateTime(1999, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "default.jpg" },
                    { new Guid("cea8a9ef-ca97-4901-9cbf-84eb88949949"), "Taniya Hudson", "Madden Henson", " Gambia", new DateTime(2013, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "default.jpg" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2fe8284b-b2f9-4615-85b9-2db38fbd0ce7", "6056a156-d00d-49b4-89ed-7a20a67d68e8" },
                    { "94316ed8-e8fd-44dc-9e9a-a14eab919615", "6056a156-d00d-49b4-89ed-7a20a67d68e8" },
                    { "2fe8284b-b2f9-4615-85b9-2db38fbd0ce7", "c8a9a1ae-809d-45e2-bcd6-5a2492df41cd" }
                });

            migrationBuilder.InsertData(
                table: "TeamPlayer",
                columns: new[] { "Id", "PlayerId", "TeamId" },
                values: new object[,]
                {
                    { new Guid("093e1c3e-fbe7-445f-8b98-63cb64b9dced"), new Guid("7dec8e20-54af-4500-8262-ed37adb60f4b"), new Guid("cea8a9ef-ca97-4901-9cbf-84eb88949949") },
                    { new Guid("16b58d92-56af-47c1-9f45-b24044e5fd2b"), new Guid("b0cab865-8eca-461f-bf24-8353a6c1b15d"), new Guid("cea8a9ef-ca97-4901-9cbf-84eb88949949") },
                    { new Guid("2452d543-8671-4336-afd7-6af7a021c729"), new Guid("056c5015-3562-450b-89ca-491e1baf7002"), new Guid("cea8a9ef-ca97-4901-9cbf-84eb88949949") },
                    { new Guid("25cab676-9cf1-4964-b1eb-6bc9bfb86af3"), new Guid("8214ad74-9564-4b15-b70b-2dea9d0a262a"), new Guid("cea8a9ef-ca97-4901-9cbf-84eb88949949") },
                    { new Guid("298cc4f4-77e1-4ef6-9a7f-8778c56c70b0"), new Guid("d3e1a894-dc6c-4116-8efa-39e1ce813e84"), new Guid("cea8a9ef-ca97-4901-9cbf-84eb88949949") },
                    { new Guid("319e15ec-5f5c-47dd-aa95-21a4beaf2e15"), new Guid("61f07810-14fe-46da-a19e-40241fcf003d"), new Guid("c9c42417-de22-469b-ba1e-11179ecb26a8") },
                    { new Guid("373a4c2c-b4da-47a8-83fe-5020bbc5679a"), new Guid("7ed4e691-07e5-478a-9396-d0fcba41080f"), new Guid("4b7bc5b3-3914-47dc-8d83-1de3e437ff26") },
                    { new Guid("3d8859a3-a6aa-45b6-9a2f-ad103587faaf"), new Guid("8aef9d3f-36a3-4bc6-a91a-21bd92448ba3"), new Guid("4b7bc5b3-3914-47dc-8d83-1de3e437ff26") },
                    { new Guid("452f6332-7a2e-49d1-9d2c-c95324528712"), new Guid("a6e67247-9627-4a05-ae3d-c80d4fdfb3f9"), new Guid("4b7bc5b3-3914-47dc-8d83-1de3e437ff26") },
                    { new Guid("4b124ac3-19b4-4175-8e35-2e10c4ebe420"), new Guid("9ddfadd1-b48c-44d0-b9dd-69e233d63b68"), new Guid("c9c42417-de22-469b-ba1e-11179ecb26a8") },
                    { new Guid("50ebecc7-e3b3-4db3-a2b7-b5ec29db62d4"), new Guid("e0c8af6e-9db6-42dd-a7a2-9df247e88b29"), new Guid("4b7bc5b3-3914-47dc-8d83-1de3e437ff26") },
                    { new Guid("55bf4b7f-4336-430d-9b40-61d5c84ab297"), new Guid("25790383-4f35-4d9a-bd21-f71d51974e84"), new Guid("cea8a9ef-ca97-4901-9cbf-84eb88949949") },
                    { new Guid("5665be06-d902-40b6-98fc-df8f75514613"), new Guid("3ad576ef-30da-43d5-8ab9-0cbbe07e48f1"), new Guid("c9c42417-de22-469b-ba1e-11179ecb26a8") },
                    { new Guid("5b2b3d93-6a85-4578-b21e-853984ffbebe"), new Guid("8bad3297-ce67-400a-8d6d-ab36b7278325"), new Guid("c9c42417-de22-469b-ba1e-11179ecb26a8") },
                    { new Guid("62fb97c5-7ebf-463d-a0f5-12f00e75a3ff"), new Guid("fd483293-3066-4bcf-a474-a820b177ec90"), new Guid("4b7bc5b3-3914-47dc-8d83-1de3e437ff26") },
                    { new Guid("81934ae3-3e60-439d-a617-dcf035bf7216"), new Guid("f22ccec5-7698-4e4f-9494-071c9a6f080d"), new Guid("c9c42417-de22-469b-ba1e-11179ecb26a8") },
                    { new Guid("89bdffd3-c05a-4694-9228-bbcfbbf2f7b3"), new Guid("c1b9c28d-6194-4093-8d39-28e44d5a3aac"), new Guid("4b7bc5b3-3914-47dc-8d83-1de3e437ff26") },
                    { new Guid("8a19a891-ca0c-4a95-a0d5-9d3fafc78520"), new Guid("b57d1442-2389-4bf9-bd3a-5fd4b01a18fa"), new Guid("cea8a9ef-ca97-4901-9cbf-84eb88949949") },
                    { new Guid("8a7f1e95-34d8-48aa-95ff-f96638f651a7"), new Guid("2fcbcec5-a6a3-46dc-aa19-b64ccc57fd97"), new Guid("c9c42417-de22-469b-ba1e-11179ecb26a8") },
                    { new Guid("8cafbf3d-02da-4603-8e21-91533497de06"), new Guid("2061d97e-338f-4fe6-a9f0-e16357169169"), new Guid("c9c42417-de22-469b-ba1e-11179ecb26a8") },
                    { new Guid("9515e360-7f7f-4e79-9bb8-5ab2a757bb06"), new Guid("e315a20f-e3bb-432e-bafa-b1fbfcb02c75"), new Guid("4b7bc5b3-3914-47dc-8d83-1de3e437ff26") },
                    { new Guid("a974dba1-cf61-4a8f-8984-b45fb1ec80af"), new Guid("1521f22a-b2e9-41bc-a1e0-89c419945019"), new Guid("cea8a9ef-ca97-4901-9cbf-84eb88949949") },
                    { new Guid("adf94636-f003-4476-a6b5-2d9a9d1a7873"), new Guid("ddf83261-73b7-46d6-8777-ff47e7673be6"), new Guid("c9c42417-de22-469b-ba1e-11179ecb26a8") },
                    { new Guid("c004a060-f36b-4cff-92a6-457e8471a505"), new Guid("14161cc5-fa8a-4b5a-829e-53b39bd5f96f"), new Guid("c9c42417-de22-469b-ba1e-11179ecb26a8") },
                    { new Guid("c4d1d8cc-9e2e-4a96-b25a-c1a53922ccc3"), new Guid("0c4c7ed2-9a42-445e-bae1-6e2c21ea9702"), new Guid("4b7bc5b3-3914-47dc-8d83-1de3e437ff26") },
                    { new Guid("c6a1a80d-3ada-4efb-be43-eab135a8a74b"), new Guid("0fc02f76-8e9c-4129-a020-117c4d89709b"), new Guid("c9c42417-de22-469b-ba1e-11179ecb26a8") },
                    { new Guid("ca43ef13-99a4-49d4-be21-5d82bddecb66"), new Guid("8179e907-6910-4a0c-8183-a3e1f375e269"), new Guid("4b7bc5b3-3914-47dc-8d83-1de3e437ff26") },
                    { new Guid("d2cb3053-9e39-4904-a3fa-455e64b63463"), new Guid("7319a7f7-d0dd-43ac-a516-1024b0289f4a"), new Guid("c9c42417-de22-469b-ba1e-11179ecb26a8") },
                    { new Guid("dda43b1e-f19b-48a1-9dc5-bd65f88ac897"), new Guid("af708704-33f1-4e53-b142-fd4a3cdbe1fc"), new Guid("cea8a9ef-ca97-4901-9cbf-84eb88949949") },
                    { new Guid("ddd56baa-488c-42bb-99ee-7de2202a8511"), new Guid("d549823b-07b9-4784-82c5-a051c2f1d283"), new Guid("cea8a9ef-ca97-4901-9cbf-84eb88949949") },
                    { new Guid("e089cf98-f99f-409c-879b-fb2bddd2cdbf"), new Guid("8aa18562-783e-4ab7-91cf-a697cd6dd261"), new Guid("4b7bc5b3-3914-47dc-8d83-1de3e437ff26") },
                    { new Guid("e2d1155d-f56c-453f-b42c-daf78fbc3c5e"), new Guid("222e6af2-e6e6-4469-a3e9-93aec0f0cfa7"), new Guid("cea8a9ef-ca97-4901-9cbf-84eb88949949") },
                    { new Guid("f54ca34d-a39c-4cf6-92f6-41d3981e0f56"), new Guid("febf4050-ff14-4425-a362-69cbff365efb"), new Guid("4b7bc5b3-3914-47dc-8d83-1de3e437ff26") }
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
