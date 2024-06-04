namespace INT__FLOAT_Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* CAU a:
            Console.Write("Nhập một số nguyên không dấu 8 byte: ");
            ulong num = ulong.Parse(Console.ReadLine());

            ulong originalNum = num;
            ulong reversedNum = 0;
            while (num > 0)
            {
                reversedNum = reversedNum * 10 + (num % 10);
                num /= 10;
            }
            if (originalNum == reversedNum)
            {
                Console.WriteLine(+originalNum+ "là số Palindrome.");
            }
            else
            {
                Console.WriteLine(+originalNum+ "không phải là số Palindrome.");

            }
            */

            /* **************************************************************/

            /* CAU b:
            Console.Write("Nhập số phần tử của mảng: ");
            int n = int.Parse(Console.ReadLine());
            long[] arr = new long[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                arr[i] = long.Parse(Console.ReadLine());
            }

            // Tính tổng các phần tử
            long total = 0;
            foreach (long num in arr)
            {
                total += num;
            }

            Console.WriteLine("Tổng các phần tử trong mảng là: " +total);
            */



        } 
    }
}
