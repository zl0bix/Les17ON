using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les17ON
{
    internal class Logistic
    {
        public Random rnd = new Random();

        HashSet<int> citys = new HashSet<int>(26);

        int[] wagons = new int[] { 20, 36, 52 };

        public int DistanseOfWay() { return rnd.Next(500, 8001); }
        
        public int NumberOfPersons() { return rnd.Next(300,501);}  

        public int ReturnWagons()
        {
            int tmp = rnd.Next(1, 4);

            if (tmp == 1)

            {
                if (NumberOfPersons() % wagons[0] == 0)

                    return NumberOfPersons() / wagons[1];

                else

                    return NumberOfPersons() / wagons[0] + 1;
            }

            else if (tmp == 2)
            {
                if (NumberOfPersons() % wagons[1] == 0)

                    return NumberOfPersons() / wagons[1];

                else

                    return NumberOfPersons() / wagons[1] + 1;
            }

            else 
            {
               if (NumberOfPersons() % wagons[2] == 0)

                    return NumberOfPersons() / wagons[2];

                else

                    return  NumberOfPersons() / wagons[2] + 1;
            }
        }

        public int ReturnCash()
        {
            return rnd.Next(1,4) * NumberOfPersons() * DistanseOfWay() - 50000 * ReturnWagons();
        }


        public void EntersWork()
        {
            while (citys.Count < 26)
                citys.Add(rnd.Next(65, 91));
        }

        public void ShowCites()
        {
            int i = 1;

            foreach (var el in citys)

                Console.WriteLine(i++ + "\t" + el);
        }

        public char ReturneLetter()
        {
            if (citys.Count != 0)
            {
                int tmp = citys.First();

                citys.Remove(citys.First());

                return (char)tmp;
            }
            return (char)rnd.Next(97,122); // (int)a - 97
        }

        public char ReturnChar(int num) { return (char)num; }

        public int LangthOfHash() { return citys.Count; }
    }

}
