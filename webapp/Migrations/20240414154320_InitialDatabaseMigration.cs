using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapp.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatabaseMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emri = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Pershkrimi = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Departme__B2079BCD553C1E5A", x => x.DepartmentID);
                });

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    ItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emri = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Inventor__727E83EB5E10EEBC", x => x.ItemID);
                });

            migrationBuilder.CreateTable(
                name: "Knowledge",
                columns: table => new
                {
                    KnowledgeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pershkrimi = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Knowledg__FF28F869B79B5A2E", x => x.KnowledgeID);
                });

            migrationBuilder.CreateTable(
                name: "Marketing",
                columns: table => new
                {
                    MarketingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Img = table.Column<byte[]>(type: "image", nullable: true),
                    Pershkrimi = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Marketin__4CCE5A4F57292385", x => x.MarketingID);
                });

            migrationBuilder.CreateTable(
                name: "Pacienti",
                columns: table => new
                {
                    PacientiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmriMbiemri = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Pass = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    DataLindjes = table.Column<DateOnly>(type: "date", nullable: true),
                    Gjinia = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Pacienti__924B0339492FDD79", x => x.PacientiID);
                });

            migrationBuilder.CreateTable(
                name: "Partners",
                columns: table => new
                {
                    PartnerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emri = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Pershkrimi = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Partners__39FD6332A640B7B5", x => x.PartnerID);
                });

            migrationBuilder.CreateTable(
                name: "SherbimiShtese",
                columns: table => new
                {
                    SherbimiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emri = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Pershkrimi = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Cmimi = table.Column<decimal>(type: "decimal(6,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Sherbimi__B22B16F9C24FBFF2", x => x.SherbimiID);
                });

            migrationBuilder.CreateTable(
                name: "Terapia",
                columns: table => new
                {
                    TerapiaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emri = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Pershkrimi = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Terapia__44F8DDC7F30F4C97", x => x.TerapiaID);
                });

            migrationBuilder.CreateTable(
                name: "Stafi",
                columns: table => new
                {
                    StafiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmriMbiemri = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Degree = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Orari = table.Column<TimeOnly>(type: "time", nullable: true),
                    Paga = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Stafi__979A23F0ED334B91", x => x.StafiID);
                    table.ForeignKey(
                        name: "FK__Stafi__Departmen__3D5E1FD2",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "DepartmentID");
                });

            migrationBuilder.CreateTable(
                name: "MedicalRecords",
                columns: table => new
                {
                    RecordID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pershkrimi = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Simptomat = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Diagnoza = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Rezultati = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    PacientiID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MedicalR__FBDF78C979AD22BB", x => x.RecordID);
                    table.ForeignKey(
                        name: "FK__MedicalRe__Pacie__5629CD9C",
                        column: x => x.PacientiID,
                        principalTable: "Pacienti",
                        principalColumn: "PacientiID");
                });

            migrationBuilder.CreateTable(
                name: "PacientNotes",
                columns: table => new
                {
                    NoteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pershkrimi = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    PacientiID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PacientN__EACE357F51446B04", x => x.NoteID);
                    table.ForeignKey(
                        name: "FK__PacientNo__Pacie__5165187F",
                        column: x => x.PacientiID,
                        principalTable: "Pacienti",
                        principalColumn: "PacientiID");
                });

            migrationBuilder.CreateTable(
                name: "Prescription",
                columns: table => new
                {
                    PrescriptionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Diagnoza = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Medicina = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    PacientiID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Prescrip__4013081262B37C45", x => x.PrescriptionID);
                    table.ForeignKey(
                        name: "FK__Prescript__Pacie__5CD6CB2B",
                        column: x => x.PacientiID,
                        principalTable: "Pacienti",
                        principalColumn: "PacientiID");
                });

            migrationBuilder.CreateTable(
                name: "Knowledge_Partners",
                columns: table => new
                {
                    PartnerID = table.Column<int>(type: "int", nullable: false),
                    KnowledgeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Knowledg__B60FECB4181C76A5", x => new { x.PartnerID, x.KnowledgeID });
                    table.ForeignKey(
                        name: "FK__Knowledge__Knowl__6C190EBB",
                        column: x => x.KnowledgeID,
                        principalTable: "Knowledge",
                        principalColumn: "KnowledgeID");
                    table.ForeignKey(
                        name: "FK__Knowledge__Partn__6B24EA82",
                        column: x => x.PartnerID,
                        principalTable: "Partners",
                        principalColumn: "PartnerID");
                });

            migrationBuilder.CreateTable(
                name: "Marketing_Sherbime",
                columns: table => new
                {
                    SherbimiID = table.Column<int>(type: "int", nullable: false),
                    MarketingID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Marketin__56E7F35D4AD19DE1", x => new { x.SherbimiID, x.MarketingID });
                    table.ForeignKey(
                        name: "FK__Marketing__Marke__778AC167",
                        column: x => x.MarketingID,
                        principalTable: "Marketing",
                        principalColumn: "MarketingID");
                    table.ForeignKey(
                        name: "FK__Marketing__Sherb__76969D2E",
                        column: x => x.SherbimiID,
                        principalTable: "SherbimiShtese",
                        principalColumn: "SherbimiID");
                });

            migrationBuilder.CreateTable(
                name: "Ankesat",
                columns: table => new
                {
                    AnkesaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ankesa = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    StafiID = table.Column<int>(type: "int", nullable: false),
                    PacientiID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Ankesat__932170085DBF0B35", x => x.AnkesaID);
                    table.ForeignKey(
                        name: "FK__Ankesat__Pacient__412EB0B6",
                        column: x => x.PacientiID,
                        principalTable: "Pacienti",
                        principalColumn: "PacientiID");
                    table.ForeignKey(
                        name: "FK__Ankesat__StafiID__403A8C7D",
                        column: x => x.StafiID,
                        principalTable: "Stafi",
                        principalColumn: "StafiID");
                });

            migrationBuilder.CreateTable(
                name: "Stafi_Inventory",
                columns: table => new
                {
                    InventoryID = table.Column<int>(type: "int", nullable: false),
                    StafiID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Stafi_In__EC8444EC5675982D", x => new { x.InventoryID, x.StafiID });
                    table.ForeignKey(
                        name: "FK__Stafi_Inv__Inven__4D94879B",
                        column: x => x.InventoryID,
                        principalTable: "Inventory",
                        principalColumn: "ItemID");
                    table.ForeignKey(
                        name: "FK__Stafi_Inv__Stafi__4E88ABD4",
                        column: x => x.StafiID,
                        principalTable: "Stafi",
                        principalColumn: "StafiID");
                });

            migrationBuilder.CreateTable(
                name: "Stafi_Knowledge",
                columns: table => new
                {
                    StafiID = table.Column<int>(type: "int", nullable: false),
                    KnowledgeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Stafi_Kn__1868AC76B8CF93CC", x => new { x.StafiID, x.KnowledgeID });
                    table.ForeignKey(
                        name: "FK__Stafi_Kno__Knowl__66603565",
                        column: x => x.KnowledgeID,
                        principalTable: "Knowledge",
                        principalColumn: "KnowledgeID");
                    table.ForeignKey(
                        name: "FK__Stafi_Kno__Stafi__656C112C",
                        column: x => x.StafiID,
                        principalTable: "Stafi",
                        principalColumn: "StafiID");
                });

            migrationBuilder.CreateTable(
                name: "Stafi_Marketing",
                columns: table => new
                {
                    StafiID = table.Column<int>(type: "int", nullable: false),
                    MarketingID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Stafi_Ma__7356C6540A58D2C4", x => new { x.StafiID, x.MarketingID });
                    table.ForeignKey(
                        name: "FK__Stafi_Mar__Marke__71D1E811",
                        column: x => x.MarketingID,
                        principalTable: "Marketing",
                        principalColumn: "MarketingID");
                    table.ForeignKey(
                        name: "FK__Stafi_Mar__Stafi__70DDC3D8",
                        column: x => x.StafiID,
                        principalTable: "Stafi",
                        principalColumn: "StafiID");
                });

            migrationBuilder.CreateTable(
                name: "Terminet",
                columns: table => new
                {
                    TerminiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataT = table.Column<DateOnly>(type: "date", nullable: true),
                    Ora = table.Column<TimeOnly>(type: "time", nullable: true),
                    Ceshtja = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    StafiID = table.Column<int>(type: "int", nullable: false),
                    PacientiID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Terminet__BDD5CEF0B2E0417E", x => x.TerminiID);
                    table.ForeignKey(
                        name: "FK__Terminet__Pacien__44FF419A",
                        column: x => x.PacientiID,
                        principalTable: "Pacienti",
                        principalColumn: "PacientiID");
                    table.ForeignKey(
                        name: "FK__Terminet__StafiI__440B1D61",
                        column: x => x.StafiID,
                        principalTable: "Stafi",
                        principalColumn: "StafiID");
                });

            migrationBuilder.CreateTable(
                name: "Vlersimet",
                columns: table => new
                {
                    VlersimiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sherbimi = table.Column<int>(type: "int", nullable: false),
                    Sjellja = table.Column<int>(type: "int", nullable: false),
                    StafiID = table.Column<int>(type: "int", nullable: false),
                    PacientiID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Vlersime__49DCD2F5F2CA39E9", x => x.VlersimiID);
                    table.ForeignKey(
                        name: "FK__Vlersimet__Pacie__48CFD27E",
                        column: x => x.PacientiID,
                        principalTable: "Pacienti",
                        principalColumn: "PacientiID");
                    table.ForeignKey(
                        name: "FK__Vlersimet__Stafi__47DBAE45",
                        column: x => x.StafiID,
                        principalTable: "Stafi",
                        principalColumn: "StafiID");
                });

            migrationBuilder.CreateTable(
                name: "Terapia_MedicalRecord",
                columns: table => new
                {
                    TerapiaID = table.Column<int>(type: "int", nullable: false),
                    RecordID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Terapia___CB452A4B2683290B", x => new { x.TerapiaID, x.RecordID });
                    table.ForeignKey(
                        name: "FK__Terapia_M__Recor__59FA5E80",
                        column: x => x.RecordID,
                        principalTable: "MedicalRecords",
                        principalColumn: "RecordID");
                    table.ForeignKey(
                        name: "FK__Terapia_M__Terap__59063A47",
                        column: x => x.TerapiaID,
                        principalTable: "Terapia",
                        principalColumn: "TerapiaID");
                });

            migrationBuilder.CreateTable(
                name: "Terapia_Prescription",
                columns: table => new
                {
                    TerapiaID = table.Column<int>(type: "int", nullable: false),
                    PrescriptionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Terapia___70F9ED46EF5B7246", x => new { x.TerapiaID, x.PrescriptionID });
                    table.ForeignKey(
                        name: "FK__Terapia_P__Presc__60A75C0F",
                        column: x => x.PrescriptionID,
                        principalTable: "Prescription",
                        principalColumn: "PrescriptionID");
                    table.ForeignKey(
                        name: "FK__Terapia_P__Terap__5FB337D6",
                        column: x => x.TerapiaID,
                        principalTable: "Terapia",
                        principalColumn: "TerapiaID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ankesat_PacientiID",
                table: "Ankesat",
                column: "PacientiID");

            migrationBuilder.CreateIndex(
                name: "IX_Ankesat_StafiID",
                table: "Ankesat",
                column: "StafiID");

            migrationBuilder.CreateIndex(
                name: "IX_Knowledge_Partners_KnowledgeID",
                table: "Knowledge_Partners",
                column: "KnowledgeID");

            migrationBuilder.CreateIndex(
                name: "IX_Marketing_Sherbime_MarketingID",
                table: "Marketing_Sherbime",
                column: "MarketingID");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRecords_PacientiID",
                table: "MedicalRecords",
                column: "PacientiID");

            migrationBuilder.CreateIndex(
                name: "IX_PacientNotes_PacientiID",
                table: "PacientNotes",
                column: "PacientiID");

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_PacientiID",
                table: "Prescription",
                column: "PacientiID");

            migrationBuilder.CreateIndex(
                name: "IX_Stafi_DepartmentID",
                table: "Stafi",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Stafi_Inventory_StafiID",
                table: "Stafi_Inventory",
                column: "StafiID");

            migrationBuilder.CreateIndex(
                name: "IX_Stafi_Knowledge_KnowledgeID",
                table: "Stafi_Knowledge",
                column: "KnowledgeID");

            migrationBuilder.CreateIndex(
                name: "IX_Stafi_Marketing_MarketingID",
                table: "Stafi_Marketing",
                column: "MarketingID");

            migrationBuilder.CreateIndex(
                name: "IX_Terapia_MedicalRecord_RecordID",
                table: "Terapia_MedicalRecord",
                column: "RecordID");

            migrationBuilder.CreateIndex(
                name: "IX_Terapia_Prescription_PrescriptionID",
                table: "Terapia_Prescription",
                column: "PrescriptionID");

            migrationBuilder.CreateIndex(
                name: "IX_Terminet_PacientiID",
                table: "Terminet",
                column: "PacientiID");

            migrationBuilder.CreateIndex(
                name: "IX_Terminet_StafiID",
                table: "Terminet",
                column: "StafiID");

            migrationBuilder.CreateIndex(
                name: "IX_Vlersimet_PacientiID",
                table: "Vlersimet",
                column: "PacientiID");

            migrationBuilder.CreateIndex(
                name: "IX_Vlersimet_StafiID",
                table: "Vlersimet",
                column: "StafiID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ankesat");

            migrationBuilder.DropTable(
                name: "Knowledge_Partners");

            migrationBuilder.DropTable(
                name: "Marketing_Sherbime");

            migrationBuilder.DropTable(
                name: "PacientNotes");

            migrationBuilder.DropTable(
                name: "Stafi_Inventory");

            migrationBuilder.DropTable(
                name: "Stafi_Knowledge");

            migrationBuilder.DropTable(
                name: "Stafi_Marketing");

            migrationBuilder.DropTable(
                name: "Terapia_MedicalRecord");

            migrationBuilder.DropTable(
                name: "Terapia_Prescription");

            migrationBuilder.DropTable(
                name: "Terminet");

            migrationBuilder.DropTable(
                name: "Vlersimet");

            migrationBuilder.DropTable(
                name: "Partners");

            migrationBuilder.DropTable(
                name: "SherbimiShtese");

            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "Knowledge");

            migrationBuilder.DropTable(
                name: "Marketing");

            migrationBuilder.DropTable(
                name: "MedicalRecords");

            migrationBuilder.DropTable(
                name: "Prescription");

            migrationBuilder.DropTable(
                name: "Terapia");

            migrationBuilder.DropTable(
                name: "Stafi");

            migrationBuilder.DropTable(
                name: "Pacienti");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
