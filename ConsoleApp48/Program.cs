using System;

namespace ConsoleApp48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car[] cars;
            int carcount=GetInputInt("Avtomobilin sayini daxil edin.",0,int.MaxValue);
            
            cars = new Car[carcount];  
            for (int i = 0; i < carcount; i++)
            {
                string Color = GetInputStr($"{i + 1}.Avtomobilin rengini daxil edin.", 1,int.MaxValue);
                string Brand = GetInputStr($"{i + 1}.Avtomobilin brend adini daxil edin.", 3, 100);
                double Milage = GetInputDouble($"{i+1}.Avtomobilin hazirki km-ni daxil edin.",0,double.MaxValue);
                double Fuelcapacity = GetInputDouble($"{i + 1}.Avtomobilin yanacaq tutumunu daxil edin.", 0, double.MaxValue);
                double Currentfuel = GetInputDouble($"{i + 1}.Avtomobilin hal-hazirki movcud olan yanacaqini daxil edin.", 0, double.MaxValue);
                double Fuelfor1km = GetInputDouble($"{i + 1}.Avtomobilin 1km-e serf etdiyi yanacaq miqdarini daxil edin.", 0, double.MaxValue);
                cars[i] = new Car(Color, Brand, Milage, Fuelcapacity, Currentfuel, Fuelfor1km);

            }
            Console.WriteLine("\n-------------------------------\n");
            string choise;
            bool check = true;

            do
            {
                Console.WriteLine("\n---------------Menu----------------\n");
                Console.WriteLine("1. Masinlari millage-e gore filtirle");
                Console.WriteLine("2. Butun masinlari goster");
                Console.WriteLine("3. Prosesi bitir");

                choise=Console.ReadLine();

                switch (choise)
                {
                    case "1":
                        double minMile = GetInputDouble("Minimum kilometri daxil edin:", 0, double.MaxValue);
                        double maxMile = GetInputDouble("Maksimum kilometri daxil edin:", 0, double.MaxValue);
                        var FilteredByMile = FilterbyMile(cars, minMile, maxMile);
                        Console.WriteLine("\n---------------Kilometir intervalli----------------\n");
                        foreach (var item in FilteredByMile)
                        {
                            Console.WriteLine(item.GetInfo());
                        }
                        break;
                        
                       
                    case "2":
                        Console.WriteLine("\n---------------Butun avtomobiller----------------\n");
                        foreach (var item in cars)
                        {
                            Console.WriteLine(item.GetInfo());
                        }
                        break;
                    case "3":
                        Console.WriteLine("\n---------------Butun avtomobiller----------------\n");
                        check = false;
                        break ;
                        default:
                        Console.WriteLine("Duzgun secim edin!");
                        break ;

                        
                           
                }
            } while (check);


        }

        static string GetInputStr(string inputname,int min,int max)
        {
            string input;
            do
            {
                Console.WriteLine(inputname);
                input = Console.ReadLine();
            } while (input.Length<min || input.Length>max);
            return input;
        }
       
        static double GetInputDouble(string inputname, double min, double max)
        {
            string inputStr;
            double input;
            do
            {
                Console.WriteLine(inputname);
                inputStr = Console.ReadLine();
                input=Convert.ToDouble(inputStr);
            } while (input < min || input > max);
            return input;
        }
        static int GetInputInt(string inputname, int min, int max)
        {
            string inputStr;
            double input;
            do
            {
                Console.WriteLine(inputname);
                inputStr = Console.ReadLine();
                input = Convert.ToDouble(inputStr);
            } while (input < min || input > max);
            return (int)input;
        }
        static Car[] FilterbyMile(Car[] cars, double minMile,double maxMile)
        {
           
            Car[] FilteredMile = new Car[0];
            int index = 0;
            foreach (var item in cars)
            {
                if (item.Milage>=minMile && item.Milage<=maxMile)
                {
                    Resize(ref FilteredMile, FilteredMile.Length + 1);
                    FilteredMile[FilteredMile.Length-1] = item;
                }
            }
            return FilteredMile;
        }
         static void Resize(ref Car[]cars,int newsize)
        {
            Car[] newArr = new Car[newsize];
            for (int i = 0; i < cars.Length; i++)
            {
                newArr[i] = cars[i];
            }
            cars = newArr;
        }
    }
}
