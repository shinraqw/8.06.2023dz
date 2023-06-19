namespace _8._06._2023dz
{

    public class CustomNumberComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            int sumX = GetDigitSum(x);
            int sumY = GetDigitSum(y);

            return sumX.CompareTo(sumY);
        }

        private int GetDigitSum(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
    }


    internal class Program
    {
        static void Main()
        {
            //1
            int[] numbers = { 121, 75, 81 };
            Array.Sort(numbers, new CustomNumberComparer());
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            //2
            string[] countries1 = { "Україна", "Польща", "США", "Німеччина", "Франція" };
            string[] countries2 = { "Франція", "Німеччина", "Італія", "Китай", "Україна" };

            // різниця
            var difference = countries1.Except(countries2);
            Console.WriteLine("Різниця між масивами:");
            foreach (string country in difference)
            {
                Console.WriteLine(country);
            }

            // перетин
            var intersection = countries1.Intersect(countries2);
            Console.WriteLine("\nПеретин масивів:");
            foreach (string country in intersection)
            {
                Console.WriteLine(country);
            }

            // об'єднання
            var union = countries1.Union(countries2);
            Console.WriteLine("\nОб'єднання масивів:");
            foreach (string country in union)
            {
                Console.WriteLine(country);
            }

            // вміст першого масиву без повторень
            var distinct = countries1.Distinct();
            Console.WriteLine("\nВміст першого масиву без повторень:");
            foreach (string country in distinct)
            {
                Console.WriteLine(country);
            }

            //3

            List<Device> devices1 = Device.CreateDevicesList1();
            List<Device> devices2 = Device.CreateDevicesList2();

            List<Device> difference3 = Device.GetDifference(devices1, devices2);
            Console.WriteLine("Різниця масивів за виробником:");
            Device.PrintDevices(difference3);

            List<Device> intersection3 = Device.GetIntersection(devices1, devices2);
            Console.WriteLine("\nПеретин масивів за виробником:");
            Device.PrintDevices(intersection3);

            List<Device> union3 = Device.GetUnion(devices1, devices2);
            Console.WriteLine("\nОб'єднання масивів за виробником:");
            Device.PrintDevices(union3);
        }
    }
}