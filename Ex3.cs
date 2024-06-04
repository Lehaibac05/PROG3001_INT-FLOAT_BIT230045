namespace INT__FLOAT_Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* CAU a:
            Console.Write("Nhập số phần tử của mảng: ");
            int n = int.Parse(Console.ReadLine());
            ushort[] arr = new ushort[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập phần tử thứ" +(i + 1)+ ":" );
                arr[i] = ushort.Parse(Console.ReadLine());
            }

            ulong total = 0;
            foreach (ushort num in arr)
            {
                total += num;
            }

            Console.WriteLine("Tổng các phần tử trong mảng là: "+ total);
            */

            /* **************************************************************/

            /* CAU b:
            Console.Write("Nhập số phần tử của mảng: ");
            int n = int.Parse(Console.ReadLine());
            short[] arr = new short[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                arr[i] = short.Parse(Console.ReadLine());
            }

            long total = 0;
            foreach (short num in arr)
            {
                total += num;
            }

            Console.WriteLine("Tổng các phần tử trong mảng là: " + total);
            */
        }
    }
}
