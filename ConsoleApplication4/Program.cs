using ConsoleApplication4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            using (mcsContext db = new mcsContext())
            {
                foreach (var stopReason in db.TablesStopReasons)
                {
                    Console.WriteLine(stopReason.intStopReason + "\t" + stopReason.strReason);
                }

                //TableStopReason sr = new TableStopReason();       //Инсерт
                //sr.strReason = "";
                //db.TablesStopReasons.Add(sr);
                //db.SaveChanges();


                TableStopReason sr = db.TablesStopReasons.Find(1);      //Апдейт

                sr.strReason = "_*_";
                db.SaveChanges();

                db.TablesStopReasons.Remove(sr);
                db.SaveChanges();
            }
        }
    }
}
