using ConsoleApplication2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new MCSEntities())
            {
                foreach (var item in db.AccessTabs)
                {
                    Console.WriteLine(item.strTabName);
                }
            }
        }
    }
}
