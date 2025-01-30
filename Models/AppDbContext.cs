

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace EzeCarVentures.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
	public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed Brand
            modelBuilder.Entity<Brand>().HasData(new Brand { BrandId = 1, BrandName = "Toyota Camry",Description="Beauty" });
            modelBuilder.Entity<Brand>().HasData(new Brand { BrandId = 2, BrandName = "BMW",Description="Class" });
            modelBuilder.Entity<Brand>().HasData(new Brand { BrandId = 3, BrandName = "Mercedes",Description="Exotic" });

            //seed cars
  
            modelBuilder.Entity<Car>().HasData(new Car
            {
                CarId=001,
                BrandId=1,
                CarName="Toyota Camry 101",
                Price= 200000M,
                ShortName="T101",
                BrandName = "Toyota Camry",
                ShortDescription ="Beautiful car with Good Tires",
                LongDescription= "The ultimate sports car, this vehicle is designed for speed. Featuring a twin-turbocharged engine and a robust frame, it can handle sharp turns and curves with ease",
                ImageUrl = "https://img.freepik.com/free-vector/white-hatchback-car-isolated-white-vector_53876-67619.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=ais"
                

            });

            modelBuilder.Entity<Car>().HasData(new Car
            {
                CarId = 002,
                BrandId = 1,
                CarName = "Toyota Camry 102",
                Price = 210000M,
                ShortName = "T102",
                BrandName="Toyota Camry",
                ShortDescription = "Beautiful car with Good Tires",
                LongDescription = " Rear-wheel drive and four-wheel ABS. Digital keypad power door locks. Simulated wood trim on the dash and interior doors.",
                ImageUrl = "https://img.freepik.com/premium-vector/premium-car-illustration-vector-design-graphic_617770-2.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=ais"

            }); 

            modelBuilder.Entity<Car>().HasData(new Car
            {
                CarId = 003,
                BrandId = 1,
                CarName = "Toyota Camry 103",
                Price = 2241000M,
                ShortName = "T103",
                BrandName = "Toyota Camry",
                ShortDescription = "Beautiful car with Good Tires",
                LongDescription = " Digital keypad power door locks. Simulated wood trim on the dash and interior doors.",
                ImageUrl = "https://img.freepik.com/free-vector/black-sedan-car-isolated-white-vector_53876-67402.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=ais"
            });

            modelBuilder.Entity<Car>().HasData(new Car
            {
                CarId = 004,
                BrandId = 2,
                CarName = "BMW111",
                Price = 30040000M,
                ShortName = "B1",
                BrandName = "BMW",
                ShortDescription = "Beautiful car with Good Engines",
                LongDescription = "BMW cars are at the forefront of automotive technology, offering a range of cutting-edge features designed to enhance the driving experience. BMW’s iDrive infotainment system provides a user-friendly interface for controlling in-car features such as audio and navigation. Additionally, BMW’s ConnectedDrive technology offers a suite of connectivity services, such as real-time traffic information, remote control of the car from a smartphone, and the ability to stream music and podcasts on the go.",
                ImageUrl = "https://img.freepik.com/premium-vector/racing-city-car-illustration_173474-59.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=sph"
            });
            modelBuilder.Entity<Car>().HasData(new Car
            {
                CarId = 005,
                BrandId = 2,
                CarName = "BMW112",
                Price = 200000000M,
                ShortName = "B2",
                BrandName = "BMW",
                ShortDescription = "Beautiful car with Good Tires",
                LongDescription = "With its EfficientDynamics design system, purchasing a BMW is not only a luxury purchase but an environmentally conscious one.",
                ImageUrl = "https://img.freepik.com/free-vector/red-sports-car-black-background-vector_53876-67367.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=sph"

            });
            modelBuilder.Entity<Car>().HasData(new Car
            {

                CarId = 006,
                BrandId = 2,
                CarName = "BMW113",
                Price = 290000000M,
                ShortName = "B3",
                BrandName = "BMW",
                ShortDescription = "Beautiful car with Good Tires",
                LongDescription = "With its EfficientDynamics design system, purchasing this BMW is not only a luxury purchase but an environmentally conscious one.",
                ImageUrl = "https://img.freepik.com/premium-vector/blue-racing-sport-car_692865-16.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=sph"
            });
            modelBuilder.Entity<Car>().HasData(new Car
            {
                CarId = 007,
                BrandId = 3,
                CarName = "GLK 405",
                Price = 404000000M,
                ShortName = "G101",
                BrandName = "Mercedes",
                ShortDescription = "Beautiful car with Good Tires",
                LongDescription = "Your satisfaction is our primary concern in both sales and service. Mercedes-Benz of Westminster is held to the highest standards in the industry by Mercedes-Benz. We appreciatively provide thoughtful amenities fostered around convenience for our customers. Low prices, great customer attention and the highest quality service support for your vehicle. Mercedes-Benz slogan says it all – Das beste oder nichts! (The best or nothing)",
                ImageUrl = "https://img.freepik.com/premium-photo/generic-black-suv_2227-847.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=ais"

            });
            modelBuilder.Entity<Car>().HasData(new Car
            {

                CarId = 008,
                BrandId = 3,
                CarName = "4Matic",
                Price = 30000000M,
                ShortName = "M101",
                BrandName = "Mercedes",
                ShortDescription = "Beautiful car with Good Tires",
                LongDescription = "Mercedes-Benz knows fulfilling that destiny will take more than just plug-in hybrids and battery electric vehicles. That’s why they’ve driven innovation of renewable, zero-emission hydrogen fuel cell power. You can own the future, today with the B-Class F-CELL.",
                ImageUrl = "https://image.shutterstock.com/image-vector/luxury-premium-realistic-sedan-coupe-260nw-2265160149.jpg"
            });
            modelBuilder.Entity<Car>().HasData(new Car
            {

                CarId = 009,
                BrandId = 3,
                CarName = "Mercedes 202",
                Price = 25000000M,
                ShortName = "M101",
                BrandName = "Mercedes",
                ShortDescription = "Beautiful car with Good Tires",
                LongDescription = "The Mercedes-Benz family is devoted to the craft of automobile making. A Mercedes-Benz should always look like a Mercedes-Benz, and what we produce are vehicles that not only look, but feel and sound like nothing else on the road.",
                ImageUrl = "https://img.freepik.com/free-photo/vintage-car-with-license-plate-that-says-license-plate-it_1340-28354.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=sph"
            });
            modelBuilder.Entity<Car>().HasData(new Car
            {
                CarId = 010,
                BrandId = 1,
                CarName = "Toyota Camry 104",
                Price = 1504000M,
                ShortName = "T104",
                BrandName = "Toyota Camry",
                ShortDescription = "Beautiful car with Good Tires",
                LongDescription = " Leather steering wheel and seats. Height-adjustable and eight-way power driver and passenger seats. Simulated wood trim on the dash and interior doors.",
                ImageUrl = "https://img.freepik.com/free-vector/white-suv-car-black-background-vector_53876-64378.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=ais"

            });

            modelBuilder.Entity<Car>().HasData(new Car
            {
                CarId = 011,
                BrandId = 2,
                CarName = "BMW114",
                Price = 37400000M,
                ShortName = "B14",
                BrandName = "BMW",
                ShortDescription = "Beautiful car with Good Tires",
                LongDescription = " advanced technology makes its cars more convenient, comfortable, and safe to drive, while also improving the driving experience and providing drivers with the latest in automotive innovation. BMW drivers can feel confident that they are behind the wheel of a vehicle that is equipped with the most cutting-edge technology available.",
                ImageUrl = "https://img.freepik.com/premium-vector/car-illustration_74218-147.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=ais"

            });
            modelBuilder.Entity<Car>().HasData(new Car
            {
                CarId = 0012,
                BrandId = 3,
                CarName = "Benz1",
                Price = 404000000M,
                ShortName = "B101",
                BrandName = "Mercedes",
                ShortDescription = "Beautiful car with Good Tires",
                LongDescription = "Since inventing the first car, Mercedes-Benz has set the pace for what all cars might someday become. With an ongoing stream of firsts in safety, performance and driving there’s only one reason the world’s first automaker remains first in innovation. Carl Benz said it best: The love of inventing never dies.",
                ImageUrl = "https://img.freepik.com/free-photo/white-offroader-jeep-parking_114579-4007.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=ais"

            }); 

        }
    }
}
