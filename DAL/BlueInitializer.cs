using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainModel;
using DomainModel.Entities;
using DomainModel.Entity;

namespace DAL
{
    public static class BlueInitializer 
    {
        public static void Initialize (this BlueContext context, bool dropAlways = false)
        {
            // to drop database or not
            if (dropAlways)
                context.Database.EnsureDeleted();

            context.Database.EnsureCreated();

            // if db has been already seeded
            if (context.Hotels.Any())
                return;

            //Hotel hotel = BuildHotel();
            var addresses = new List<Address>()
            {
        

                new Address()
                        {
                            Street="Rue des prés",
                            ZipCode ="124675",
                            City ="Paris",
                            Latitude=12,
                            Logitude =150,
                            Country ="France",
                            Phone ="+3356124",
                            Email ="kqhdsq@gmail.com"

                        },
                new Address()
                        {
                            Street="Rue des paris",
                            ZipCode ="35300",
                            City ="Rennes",
                            Latitude=54,
                            Logitude =42,
                            Country ="Vietnam",
                            Phone ="+334235546",
                            Email ="trang@gmail.com"

                        },

                new Address()
                        {
                            Street="place Pompidou",
                            ZipCode ="45212",
                            City ="Lille",
                            Latitude=100,
                            Logitude =45,
                            Country ="Belgique",
                            Phone ="+4524466445",
                            Email ="lille@gmail.com"

                        },

                 new Address()
                        {
                            Street="place George",
                            ZipCode ="412031",
                            City ="Hanoi",
                            Latitude=47,
                            Logitude =123,
                            Country ="Laos",
                            Phone ="+4126489875",
                            Email ="hanoi@gmail.com"

                        },
                 new Address()
                        {
                            Street="PhuTho",
                            ZipCode ="845231",
                            City ="Viettri",
                            Latitude=41,
                            Logitude =24,
                            Country ="Vietnam",
                            Phone ="+8742364",
                            Email ="viettri@gmail.com"

                        },
                 new Address()
                        {
                            Street="Vietanm",
                            ZipCode ="455421",
                            City ="Foureee",
                            Latitude=45,
                            Logitude =124,
                            Country ="France",
                            Phone ="+3345467",
                            Email ="Foyrez@gmail.com"

                        },
                    };

            var hotels = new List<Hotel>()
            {


                new Hotel()
                        {
//                             
                            Name="Balzac",
                            Star = 4,
                            Address =addresses[0]
                            

                        },
                new Hotel()
                        {
                            Name="Luu",
                            Star = 3,
                            Address =addresses[1]

                        },

                new Hotel()
                        {
                            Name="Dell",
                            Star = 5,
                            Address =addresses[5]

                        },
                    };

            var customers = new List<Customer>()
            {


                new Customer()
                        {
                            FullName="Luu Huyen Trang",
                            DateOfBirth =DateTime.Now,
                            Address=addresses[2]


                        },
                new Customer()
                        {
                           FullName="Yattara Yacouba",
                            DateOfBirth =DateTime.Now,
                            Address=addresses[3]

                        },

                new Customer()
                        {
                            FullName="Alex Moyan",
                            DateOfBirth =DateTime.Now,
                            Address=addresses[4]

                        },
                };

            var rooms = new List<Room>()
            {


                new Room()
                        {
                            Name="Président",
                            Floor =4,
                            Caterogy="qkshdfze",
                            Hotel = hotels[0]
                        },
                new Room()
                        {
                           Name="Suite",
                            Floor =3,
                            Caterogy="trang",
                            Hotel = hotels[1]

                        },

                new Room()
                        {
                            Name="Président",
                            Floor =4,
                            Caterogy="qkshdfze",
                            Hotel = hotels[2]

                        },
                };

            var bookings = new List<Booking>()
            {


                new Booking()
                        {
                            Created=DateTime.Now.AddDays(1),
                            CheckIn =DateTime.Now.AddDays(3),
                            CheckOut=DateTime.Now.AddDays(6),
                            IsPaid = true,
                            Price = 245.20M,
                            Customer = customers[0]
                        },

                new Booking()
                        {
                            Created=DateTime.Now.AddDays(4),
                            CheckIn =DateTime.Now.AddDays(5),
                            CheckOut=DateTime.Now.AddDays(9),
                            IsPaid = true,
                            Price = 215.2M,
                            Customer = customers[1]
                        },

                new Booking()
                        {
                            Created=DateTime.Now.AddDays(2),
                            CheckIn =DateTime.Now.AddDays(7),
                            CheckOut=DateTime.Now.AddDays(12),
                            IsPaid = false,
                            Price = 245.4M,
                            Customer = customers[2]
                        },
                };


            var bookingrooms = new List<BookingRoom>()
            {


                new BookingRoom()
                        {
                            Booking =bookings[0],
                            Room =rooms[0]
                        },

                new BookingRoom()
                        {
                            Booking =bookings[1],
                            Room =rooms[1]
                        },

                new BookingRoom()
                        {
                            Booking =bookings[2],
                            Room =rooms[2]
                        },


            };


            context.Addresses.AddRange(addresses);

            context.Hotels.AddRange(hotels);

            context.Customers.AddRange(customers);

            context.Rooms.AddRange(rooms);

            context.Bookings.AddRange(bookings);

            context.BookingRooms.AddRange(bookingrooms);
            context.SaveChanges();


        }

    //    public static string GetString(string question)
    //    {
    //        string result;

    //        Console.WriteLine(question);
    //        result = Console.ReadLine();

    //        return result;
    //    }

    //    public static int GetInt(string question)
    //    {
    //        int result;
    //        int outResult = 0;
    //        string star;

    //        do
    //        {
    //            Console.WriteLine(question);
    //            star = Console.ReadLine();


    //        } while (!int.TryParse(star, out outResult));

    //         result = outResult;
    //         return result;
    //    }

    //    public static double GetDouble(string question)
    //    {
    //        double result;
    //        double outResult = 0;
    //        string star;

    //        do
    //        {
    //            Console.WriteLine(question);
    //            star = Console.ReadLine();


    //        } while (!double.TryParse(star, out outResult));

    //        result = outResult;
    //        return result;
    //    }

    //    public static Hotel BuildHotel()
    //    {
    //        Hotel result = new Hotel();

    //        Console.WriteLine("Build Hotel");
    //        result.Name = GetString("Name of Hotel");
    //        result.Star = GetInt("Star");
            

    //        return result;
    //    }

        
    //    public static Address BuildAddress()
    //    {
    //        Address result = new Address();
    //        Console.WriteLine("Build Address");

    //        result.Street = GetString("Street");
    //        result.ZipCode = GetString("ZipCode");
    //        result.City = GetString("City");
    //        result.Country = GetString("Country");
    //        result.Phone = GetString("Phone");
    //        result.Email = GetString("Email");
    //        result.Latitude = GetDouble("Latitude");
    //        result.Logitude = GetDouble("Longitude");


    //        return result;

    //    }

    }
}
