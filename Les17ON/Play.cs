using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les17ON
{
    internal class Play
    {
        public void PlayGame()
        {
            Logistic log = new Logistic();

            log.EntersWork();

            string strExit = "exit";
            string str = null;

            bool isExit = true;

            while (isExit)
            {
                Console.WriteLine("\nПожалуйста нажмите Enter для генирации маршрута!!!\nили Exit для выхода!!!\n" + "|| Город " + log.ReturneLetter() + "|| колkичество желающих\t" + log.NumberOfPersons() + "|| расcтояние\t" + log.DistanseOfWay() + "|| вагонов\t" + log.ReturnWagons() + " || выручка\t" + log.ReturnCash() + "$");
                
                str = Console.ReadLine();

                if (str.ToLower() == strExit)

                        isExit = false;  
                
                str = null;
            }
        }
    }
}
