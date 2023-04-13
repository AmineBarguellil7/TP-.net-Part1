using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Newcode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_Passenger_PassengersPassportNmber",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Passenger_PassportNmber",
                table: "Staff");

            migrationBuilder.DropForeignKey(
                name: "FK_Traveller_Passenger_PassportNmber",
                table: "Traveller");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Traveller",
                table: "Traveller");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Staff",
                table: "Staff");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Passenger",
                table: "Passenger");

            migrationBuilder.RenameTable(
                name: "Traveller",
                newName: "Travellers");

            migrationBuilder.RenameTable(
                name: "Staff",
                newName: "Staffs");

            migrationBuilder.RenameTable(
                name: "Passenger",
                newName: "Passengers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Travellers",
                table: "Travellers",
                column: "PassportNmber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Staffs",
                table: "Staffs",
                column: "PassportNmber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Passengers",
                table: "Passengers",
                column: "PassportNmber");

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    FlightFK = table.Column<int>(type: "int", nullable: false),
                    PassengerFK = table.Column<int>(type: "int", nullable: false),
                    VIP = table.Column<bool>(type: "bit", nullable: false),
                    Siege = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    prix = table.Column<double>(type: "float(2)", precision: 2, scale: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => new { x.PassengerFK, x.FlightFK });
                    table.ForeignKey(
                        name: "FK_Ticket_Flights_FlightFK",
                        column: x => x.FlightFK,
                        principalTable: "Flights",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ticket_Passengers_PassengerFK",
                        column: x => x.PassengerFK,
                        principalTable: "Passengers",
                        principalColumn: "PassportNmber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_FlightFK",
                table: "Ticket",
                column: "FlightFK");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_Passengers_PassengersPassportNmber",
                table: "FlightPassenger",
                column: "PassengersPassportNmber",
                principalTable: "Passengers",
                principalColumn: "PassportNmber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_Passengers_PassportNmber",
                table: "Staffs",
                column: "PassportNmber",
                principalTable: "Passengers",
                principalColumn: "PassportNmber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Travellers_Passengers_PassportNmber",
                table: "Travellers",
                column: "PassportNmber",
                principalTable: "Passengers",
                principalColumn: "PassportNmber",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_Passengers_PassengersPassportNmber",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_Passengers_PassportNmber",
                table: "Staffs");

            migrationBuilder.DropForeignKey(
                name: "FK_Travellers_Passengers_PassportNmber",
                table: "Travellers");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Travellers",
                table: "Travellers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Staffs",
                table: "Staffs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Passengers",
                table: "Passengers");

            migrationBuilder.RenameTable(
                name: "Travellers",
                newName: "Traveller");

            migrationBuilder.RenameTable(
                name: "Staffs",
                newName: "Staff");

            migrationBuilder.RenameTable(
                name: "Passengers",
                newName: "Passenger");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Traveller",
                table: "Traveller",
                column: "PassportNmber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Staff",
                table: "Staff",
                column: "PassportNmber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Passenger",
                table: "Passenger",
                column: "PassportNmber");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_Passenger_PassengersPassportNmber",
                table: "FlightPassenger",
                column: "PassengersPassportNmber",
                principalTable: "Passenger",
                principalColumn: "PassportNmber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Passenger_PassportNmber",
                table: "Staff",
                column: "PassportNmber",
                principalTable: "Passenger",
                principalColumn: "PassportNmber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Traveller_Passenger_PassportNmber",
                table: "Traveller",
                column: "PassportNmber",
                principalTable: "Passenger",
                principalColumn: "PassportNmber",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
