namespace INT__FLOAT_Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* CAU a:
            Console.Write("Nhập số phần tử của mảng: ");
            int n = int.Parse(Console.ReadLine());
            float[] arr = new float[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                arr[i] = float.Parse(Console.ReadLine());
            }

            float max = arr[0];
            float min = arr[0];
            foreach (float num in arr)
            {
                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }
            }

            Console.WriteLine("Giá trị lớn nhất trong mảng là: "+ max);
            Console.WriteLine("Giá trị nhỏ nhất trong mảng là: "+ min);
            */

            /* *************************************************************/
            /* CAU b:
            Console.Write("Nhập số phần tử của mảng: ");
            int n = int.Parse(Console.ReadLine());
            float[] arr = new float[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                arr[i] = float.Parse(Console.ReadLine());
            }

            // Tính tổng các phần tử
            float total = 0;
            foreach (float num in arr)
            {
                total += num;
            }

            Console.WriteLine("Tổng các phần tử trong mảng là: " + total);
            */
        }
    }
}
