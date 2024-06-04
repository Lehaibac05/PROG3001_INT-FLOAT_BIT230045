namespace INT__FLOAT_Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* CAU a:
            Console.Write("Nhập số phần tử của mảng: ");
            int n = int.Parse(Console.ReadLine());
            double[] arr = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                arr[i] = double.Parse(Console.ReadLine());
            }

            // Tính trung bình cộng
            double total = 0;
            foreach (double num in arr)
            {
                total += num;
            }
            double average = total / n;

            // In kết quả
            Console.WriteLine("Trung bình cộng của các phần tử trong mảng là: " + average);
            */

            /* *************************************************/
            /*CAU b:
            Console.Write("Nhập số phần tử của mảng: ");
            int n = int.Parse(Console.ReadLine());
            double[] arr = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                arr[i] = double.Parse(Console.ReadLine());
            }

            // Tìm giá trị lớn nhất và nhỏ nhất
            double max = arr[0];
            double min = arr[0];
            foreach (double num in arr)
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

            // In kết quả
            Console.WriteLine("Giá trị lớn nhất trong mảng là: " +max);
            Console.WriteLine("Giá trị nhỏ nhất trong mảng là: " +min);
            */

        }
    }
}
