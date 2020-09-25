using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Competition.EF.Models;
namespace Competition.EF
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new CompetitionDbContext();
            Console.WriteLine(db.Events.Count());
            Console.ReadKey();
        }
    }
}
