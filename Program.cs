using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();

            taxi.DriverName = "Kiki";
            taxi.OnDuty = true;
            taxi.NumPassanger = 2790;

            taxi.TaxiInfo();
            Console.WriteLine("------------------"); 
            taxi.PickUpPassanger();
            Console.WriteLine("------------------");
            taxi.DropOffPassanger();
            Console.ReadKey();
        }
    }

    public class Taxi{
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassanger { get; set; }

        public void TaxiInfo()
        {
        Console.WriteLine("Nama Driver : {0}", DriverName);
        Console.WriteLine("Sedang Bekerja : {0}", OnDuty);
        Console.WriteLine("Nomor Penumpang : {0}", NumPassanger);
        }

        public void PickUpPassanger()
        {
            Console.WriteLine("Sedang Mengangkut penumpang");
        
        }
        public void DropOffPassanger()
        {
            Console.WriteLine("Menurunkan penumpang");

        }
    }
}
