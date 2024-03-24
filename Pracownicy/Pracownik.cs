using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Pracownicy
{
    public abstract class Pracownik
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public decimal salary { get; set; }

        public abstract void showInformation();

        public virtual decimal getAnnualSalary()
        {
            return salary * 12;
        }
    }

    public class Manager : Pracownik
    {
        public decimal annualBonus { get; set; }

        public override void showInformation()
        {
            Console.WriteLine($"Manager - Imię: {firstName}, Nazwisko: {lastName}, Wynagrodzenie miesięczne: {salary}zł, Roczny bonus: {annualBonus}zł, Wynagrodzenie roczne: {this.getAnnualSalary() + this.annualBonus}zł");
            Console.WriteLine("\r\n");
        }
    }

    public class PracownikBiurowy : Pracownik
    {
        public int amountOfWorkHours { get; set; }

        public override void showInformation()
        {
            Console.WriteLine($"Pracownik biurowy - Imię: {firstName}, Nazwisko: {lastName}, Wynagrodzenie miesięczne: {salary}zł, Ilość godzin pracy: {amountOfWorkHours}, Wynagrodzenie roczne: {this.getAnnualSalary()}zł");
            Console.WriteLine("\r\n");
        }
    }

    public class PracownikZdalny : Pracownik
    {
        public int amountOfRemoteDays { get; set; }

        public override void showInformation()
        {
            Console.WriteLine($"Pracownik zdalny - Imię: {firstName}, Nazwisko: {lastName}, Wynagrodzenie miesięczne: {salary}zł, Ilość dni zdalnych: {amountOfRemoteDays}, Wynagrodzenie roczne: {this.getAnnualSalary()}zł");
            Console.WriteLine("\r\n");
        }
    }
}

