using System.Linq.Expressions;

namespace INT_FLOAT_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* CAU a:
              int a , b;
              bool isValid = false;

              while (!isValid)
              {
                  try
                  {
                      Console.Write("Nhập số nguyên a: ");
                      a = int.Parse(Console.ReadLine());

                      Console.Write("Nhập số nguyên b: ");
                      b = int.Parse(Console.ReadLine());

                      isValid = true;
                  }
                  catch (FormatException)
                  {
                      Console.WriteLine("Lỗi: Bạn phải nhập số nguyên!");
                  }
              }

              Console.WriteLine("Tổng của a và b: " + (a + b));
              Console.WriteLine("Hiệu của a và b: " + (a - b));
              Console.WriteLine("Tích của a và b: " + (a * b));
              Console.WriteLine("Thương số nguyên của a và b: " + (a / b));
              Console.WriteLine("Thương số thực của a và b: " + ((double)a / b));

              Console.ReadLine(); 
            */

            /* -----------------------------------------*/
            /* CAU b:
            int[] numbers = new int[4];

            Console.WriteLine("Nhập 4 số nguyên:");
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Số thứ {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            Console.WriteLine("Tổng của các số trong mảng là: " + sum);
            Console.ReadLine(); 
            */

            /* -----------------------------------------*/
            /* CAU c:
            Console.Write("Nhập một số nguyên không dấu (4 byte): ");
            uint input = uint.Parse(Console.ReadLine());
            uint reversed = 0;
            while (input > 0)
            {
                reversed = (reversed * 10) + (input % 10);
                input /= 10;
            }

            Console.WriteLine($"Số đảo ngược: {reversed}");

            Console.ReadLine();
            */


        }
    }
}
