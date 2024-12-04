namespace ConsoleApp4
{
    internal class Program
    {
        static void Main()
        {
            List<object> myList = new List<object>();

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                if(i % 2 == 0)
                {
                    myList.Add(random.Next(0, 10));
                    Console.WriteLine(myList[i]);
                }
                else
                {
                    myList.Add((float)random.NextDouble() + random.Next(0, 10));
                    Console.WriteLine(myList[i]);
                }
            }
            Console.WriteLine("---------");
            float result = SumList(myList);
            Console.WriteLine("---------");
            Console.WriteLine("Сумма: " + result);
        }

        public static float SumList(List<object> list)
        {
            float sum = 0;

            foreach (object obj in list)
            {
                if (obj is float f)
                {
                    sum += (float)f;
                    Console.WriteLine(sum);
                }
                else if (obj is int i)
                {
                    sum += (float)i;
                    Console.WriteLine(sum);
                }
            }

            return sum;
        }
    }
}
