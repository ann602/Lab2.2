using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib;

namespace Lab2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tablet[] arrTablets;
            Console.Write("Введіть кількість планшетів: ");
            int cntTablets = int.Parse(Console.ReadLine());
            arrTablets = new Tablet[cntTablets];
            Console.WriteLine();
            for (int i = 0; i < cntTablets; i++)
            {
                Console.Write("Введіть назву бренду:");
                string tbrand = Console.ReadLine();
                Console.Write("Введіть ціну:");
                string tprice = Console.ReadLine();
                Console.Write("Введіть вагу:");
                string tweight = Console.ReadLine();
                Console.Write("Введіть колір:");
                string tcolor = Console.ReadLine();
                Console.Write("Введіть діагональ екрана:");
                string tscreendiagonal = Console.ReadLine();
                Console.Write("Введіть частоту центрального процесора:");
                string cpufrequency = Console.ReadLine();
                Console.Write("Чи є sim-карта? (y-так, n-ні): ");
                ConsoleKeyInfo keyisthereasimcard = Console.ReadKey();
                Console.WriteLine();
                Console.Write("Чи є слот для карти пам'яті? (y-так, n-ні): ");
                ConsoleKeyInfo keyisthereamemorycardslot = Console.ReadKey();
                Console.WriteLine();
                Tablet OurTablet = new Tablet();
                OurTablet.brand = tbrand;
                OurTablet.price = int.Parse(tprice);
                OurTablet.color = tcolor;
                OurTablet.weight = int.Parse(tweight);
                OurTablet.screendiagonal = double.Parse(tscreendiagonal);
                OurTablet.CPUfrequency = double.Parse(cpufrequency);
                OurTablet.isthereasimcard = keyisthereasimcard.Key == ConsoleKey.Y ? true : false;
                OurTablet.isthereamemorycardslot = keyisthereamemorycardslot.Key == ConsoleKey.Y ? true : false;
                double tdiscountedPrice10 = OurTablet.discountedPrice();
                double tdiscountwitharegularcustomercard = OurTablet.discountwitharegularcustomercard();
                arrTablets[i] = OurTablet;
                Console.WriteLine();
            }
            foreach (Tablet t in arrTablets)
            {
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("Дані про об'єкт: ");
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("Бренд:" + t.brand);
                Console.WriteLine("Колір:" + t.color);
                Console.WriteLine("Вага:" + t.weight + " г");
                Console.WriteLine("Ціна:" + t.price + " грн");
                Console.WriteLine("Діагональ екрана:" + t.screendiagonal.ToString("0.0") + "''");
                Console.WriteLine("Частота центрального процесора:" + t.CPUfrequency.ToString("0.0") + " ГГц");
                Console.WriteLine(t.isthereasimcard ? "У мене є sim-карта." : "У мене немає sim-карти.");
                Console.WriteLine(t.isthereamemorycardslot ? "У мене є слот для карти пам'яті." : "У мене немає слота для карти пам'яті.");
                Console.WriteLine();
                Console.WriteLine("Ціна планшета зі знижкою 30%:" + t.discountedPrice().ToString("0.00") + " грн");
                Console.WriteLine("Ціна планшета зі знижкою 30% та знижкою постійного клієнта:" + t.discountwitharegularcustomercard().ToString("0.00") + "грн");
            }
            Console.ReadKey();
        }
    }
}
