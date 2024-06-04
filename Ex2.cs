namespace INT_FLOAT_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* CAU 1:
             Console.Write("Nhập dãy số nguyên có dấu (1 byte), các số cách nhau bằng dấu cách: ");
             string[] input = Console.ReadLine().Split(' ');

             sbyte min = sbyte.MaxValue;
             sbyte max = sbyte.MinValue;
             foreach (string num in input)
             {
                 sbyte value = sbyte.Parse(num);
                 if (value < min)
                     min = value;
                 if (value > max)
                     max = value;
             }

             Console.WriteLine($"Giá trị nhỏ nhất: {min}");
             Console.WriteLine($"Giá trị lớn nhất: {max}");
             Console.ReadLine();
            */

            /* -----------------------------------------*/
            /* CAU 2:
            Console.Write("Nhập dãy số nguyên có dấu (1 byte), các số cách nhau bằng dấu cách: ");
            string[] input = Console.ReadLine().Split(' ');

            int sum = 0;
            foreach (string num in input)
            {
                sbyte value = sbyte.Parse(num);
                if (value % 2 == 0)
                    sum += value;
            }

            Console.WriteLine($"Tổng các số chẵn: {sum}");

            Console.ReadLine();
            */
            /* -----------------------------------------*/
            /* CAU 3:
             Console.Write("Nhập số nguyên không dấu (1 byte): ");
            byte n = byte.Parse(Console.ReadLine());

            // Tính tổng các số từ 1 đến n
            uint sum = 0;
            for (byte i = 1; i <= n; i++)
            {
                sum += i;
            }

            // In kết quả ra màn hình
            Console.WriteLine($"Tổng các số từ 1 đến {n}: {sum}");

            Console.ReadLine();
            */

            /* -----------------------------------------*/
            /* CAU 4:
             Console.Write("Nhập số nguyên không dấu (1 byte): ");
            byte input = byte.Parse(Console.ReadLine());

            // Tính tổng các chữ số của số đó
            byte sum = 0;
            while (input > 0)
            {
                sum += (byte)(input % 10);
                input /= 10;
            }

            // In kết quả ra màn hình
            Console.WriteLine($"Tổng các chữ số: {sum}");

            Console.ReadLine();
            */

        }
    }
}
