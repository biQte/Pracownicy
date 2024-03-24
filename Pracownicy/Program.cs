using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pracownicy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PracownikBiurowy pracownik1 = new PracownikBiurowy
            { 
                firstName = "Jan",
                lastName = "Kowalski",
                salary = 4265.15m,
                amountOfWorkHours = 375
            };

            PracownikZdalny pracownik2 = new PracownikZdalny
            {
                firstName = "Wojciech",
                lastName = "Nowak",
                salary = 5250.65m,
                amountOfRemoteDays = 170
            };

            Manager manager1 = new Manager
            {
                firstName = "Łukasz",
                lastName = "Kowalski",
                salary = 10650.13m,
                annualBonus = 3000
            };

            pracownik1.showInformation();
            pracownik2.showInformation();
            manager1.showInformation();

            Thread.Sleep(1000 * 10);
        }
    }
}
