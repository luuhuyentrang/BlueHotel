using DAL;
using System;
using System.Linq;

namespace AppliConsole
{
    public class Program
    {
        static void Main(string[] args)
        { // pour voir si le db marche 
           using ( BlueContext db = new BlueContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated()                    ;
                //var bookings = db.Bookings.ToList();
                var customers = db.Customers.ToList();

            }
            Console.WriteLine("Hello World!");

        }
    }
}
