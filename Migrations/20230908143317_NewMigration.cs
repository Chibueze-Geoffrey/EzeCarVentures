using Microsoft.EntityFrameworkCore.Migrations;

namespace EzeCarVentures.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    BrandId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.BrandId);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarName = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ShortDescription = table.Column<string>(nullable: true),
                    LongDescription = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    BrandId = table.Column<int>(nullable: false),
                    BrandName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarId);
                    table.ForeignKey(
                        name: "FK_Cars_Brand_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brand",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brand",
                columns: new[] { "BrandId", "BrandName", "Description" },
                values: new object[] { 1, "Toyota Camry", "Beauty" });

            migrationBuilder.InsertData(
                table: "Brand",
                columns: new[] { "BrandId", "BrandName", "Description" },
                values: new object[] { 2, "BMW", "Class" });

            migrationBuilder.InsertData(
                table: "Brand",
                columns: new[] { "BrandId", "BrandName", "Description" },
                values: new object[] { 3, "Mercedes", "Exotic" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarId", "BrandId", "BrandName", "CarName", "ImageUrl", "LongDescription", "Price", "ShortDescription", "ShortName" },
                values: new object[,]
                {
                    { 1, 1, null, "Toyota Camry 101", "https://img.freepik.com/free-vector/white-hatchback-car-isolated-white-vector_53876-67619.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=ais", "The ultimate sports car, this vehicle is designed for speed. Featuring a twin-turbocharged engine and a robust frame, it can handle sharp turns and curves with ease", 20.4m, "Beautiful car with Good Tires", "T101" },
                    { 2, 1, null, "Toyota Camry 102", "https://img.freepik.com/premium-vector/premium-car-illustration-vector-design-graphic_617770-2.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=ais", " Rear-wheel drive and four-wheel ABS. Digital keypad power door locks. Simulated wood trim on the dash and interior doors.", 21.4m, "Beautiful car with Good Tires", "T102" },
                    { 3, 1, null, "Toyota Camry 103", "https://img.freepik.com/free-vector/black-sedan-car-isolated-white-vector_53876-67402.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=ais", " Digital keypad power door locks. Simulated wood trim on the dash and interior doors.", 22.4m, "Beautiful car with Good Tires", "T101" },
                    { 10, 1, null, "Toyota Camry 104", "https://img.freepik.com/free-vector/white-suv-car-black-background-vector_53876-64378.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=ais", " Leather steering wheel and seats. Height-adjustable and eight-way power driver and passenger seats. Simulated wood trim on the dash and interior doors.", 150.4m, "Beautiful car with Good Tires", "T104" },
                    { 4, 2, null, "BMW111", "https://img.freepik.com/premium-vector/racing-city-car-illustration_173474-59.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=sph", "BMW cars are at the forefront of automotive technology, offering a range of cutting-edge features designed to enhance the driving experience. BMW’s iDrive infotainment system provides a user-friendly interface for controlling in-car features such as audio and navigation. Additionally, BMW’s ConnectedDrive technology offers a suite of connectivity services, such as real-time traffic information, remote control of the car from a smartphone, and the ability to stream music and podcasts on the go.", 300.4m, "Beautiful car with Good Engines", "B1" },
                    { 5, 2, null, "BMW112", "https://img.freepik.com/free-vector/red-sports-car-black-background-vector_53876-67367.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=sph", "With its EfficientDynamics design system, purchasing a BMW is not only a luxury purchase but an environmentally conscious one.", 200.4m, "Beautiful car with Good Tires", "B2" },
                    { 6, 2, null, "BMW113", "https://img.freepik.com/premium-vector/blue-racing-sport-car_692865-16.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=sph", "With its EfficientDynamics design system, purchasing this BMW is not only a luxury purchase but an environmentally conscious one.", 200.4m, "Beautiful car with Good Tires", "B3" },
                    { 11, 2, null, "BMW114", "https://img.freepik.com/premium-vector/car-illustration_74218-147.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=ais", " advanced technology makes its cars more convenient, comfortable, and safe to drive, while also improving the driving experience and providing drivers with the latest in automotive innovation. BMW drivers can feel confident that they are behind the wheel of a vehicle that is equipped with the most cutting-edge technology available.", 370.4m, "Beautiful car with Good Tires", "T101" },
                    { 7, 3, null, "GLK 405", "https://img.freepik.com/premium-photo/generic-black-suv_2227-847.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=ais", "Your satisfaction is our primary concern in both sales and service. Mercedes-Benz of Westminster is held to the highest standards in the industry by Mercedes-Benz. We appreciatively provide thoughtful amenities fostered around convenience for our customers. Low prices, great customer attention and the highest quality service support for your vehicle. Mercedes-Benz slogan says it all – Das beste oder nichts! (The best or nothing)", 400.4m, "Beautiful car with Good Tires", "T101" },
                    { 8, 3, null, "4Matic", "https://image.shutterstock.com/image-vector/luxury-premium-realistic-sedan-coupe-260nw-2265160149.jpg", "Mercedes-Benz knows fulfilling that destiny will take more than just plug-in hybrids and battery electric vehicles. That’s why they’ve driven innovation of renewable, zero-emission hydrogen fuel cell power. You can own the future, today with the B-Class F-CELL.", 300.4m, "Beautiful car with Good Tires", "T101" },
                    { 9, 3, null, "Mercedes 202", "https://img.freepik.com/free-photo/vintage-car-with-license-plate-that-says-license-plate-it_1340-28354.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=sph", "The Mercedes-Benz family is devoted to the craft of automobile making. A Mercedes-Benz should always look like a Mercedes-Benz, and what we produce are vehicles that not only look, but feel and sound like nothing else on the road.", 250.4m, "Beautiful car with Good Tires", "T101" },
                    { 12, 3, null, "Benz1", "https://img.freepik.com/free-photo/white-offroader-jeep-parking_114579-4007.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=ais", "Since inventing the first car, Mercedes-Benz has set the pace for what all cars might someday become. With an ongoing stream of firsts in safety, performance and driving there’s only one reason the world’s first automaker remains first in innovation. Carl Benz said it best: The love of inventing never dies.", 400.4m, "Beautiful car with Good Tires", "T101" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_BrandId",
                table: "Cars",
                column: "BrandId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Brand");
        }
    }
}
