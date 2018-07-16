using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace ADO_LINQ_SQL
{
    class Program
    {
        private static DataContext dataContext;
        static void Main(string[] args)
        {
            // var dataContext = new DataContext("Data Source=192.168.110.195; Initial Catalog=MCS; User ID=sa; Password=Ev4865");
            // //podlkuchaetsya k baze dannyh
            //
            // Table<AccTab> accTab = dataContext.GetTable<AccTab>(); // vytawit vse dannye s tablicy v accTab
            //                                                        //Table<AccTab> -- AccTab imya tablicy, i kollekciya strok 
            //                                                        //dlya kajdoi tablicy svoi dataContext
            //
            // // Console.WriteLine(accTab.Count());//vyvedet kollvo strok s tablicy
            //
            // AccTab a = accTab.OrderBy(o => o.TabName).First();
            //
            // AccTab b = accTab.OrderBy(o => o.intTabID).First();


            //____________________________________________________________________

            dataContext = new DataContext("Data Source=192.168.110.195; Initial Catalog=CRCMS_new; User ID=sa; Password=Ev4865");
            Task2();
        }

        public static void Task1()
        {
            Table<Area> areas = dataContext.GetTable<Area>();
            foreach (Area item in areas.Where(w => w.WorkingPeople > 2))
            {
                Console.WriteLine(item.Name);
            }

            ////assocyacya
            //DataLoadOptions options = new DataLoadOptions();
            //options.AssociateWith<Area>(c=>c.Timers.Where(w=>w.DateFinish!=null));
            //options.LoadWith<Area>(t=>t.Timer);//zagruzit vse timer dlya tablicy Area
            //dataContext.LoadOptions = options;// prejdevremennaya sortirovka prymo iz istochnika
            //
            Table<Area> areas2 = dataContext.GetTable<Area>();// zagruziv AREA on zogruzit s nim TIMER
            foreach (Area item in areas2)
            {
                Console.WriteLine(item.Name);
                foreach (Timer timer in item.Timer)
                {
                    Console.WriteLine("\t" + timer.DateStart);

                }
            }
        }

        public static void Task2()
        {
            //b.Используя таблицу Area, отобразить отобразит только те зоны / участки которые
            //относятся к зоне разборке(AssemblyArea = 1)

          Table<Area> areas3 = dataContext.GetTable<Area>();

          AccTab a = areas3.OrderBy(o => o.).First();
            areas3.OrderBy()

          foreach (Area item in areas3.Where(a => a.AssemblyArea != null).Where(w=>(bool)w.AssemblyArea))
          {
              Console.WriteLine(item.Name + "\t\t" + item.AssemblyArea);

          }

        }
    }
}
