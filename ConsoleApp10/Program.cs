namespace ConsoleApp10
{
    internal class Program
    {
        public static int Persistence(int num)
        {
            if (num < 10)
            {
                return 0;
            }
            int count = 0;

            while (num >= 10)
            {
                int product = 1;

                while (num > 0)
                {
                    product *= num % 10;
                    num /= 10;
                }
                num = product;
                count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для подсчета мультипликативной стойкости: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int num))
            {
                int result = Persistence(num);

                Console.WriteLine($"Мультипликативная стойкость числа {num} равна: {result}");
            }
            else
            {
                Console.WriteLine("Ошибка введено не коректное число");
            }
        }
    }
}
