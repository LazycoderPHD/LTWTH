namespace Buoi2
{
  class Bai1
{
    static void DemKyTu(string s, int[] count)
    {
        string str = s.ToUpper();
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] != ' ')
            {
                count[str[i]]++;
            }
        }
        Console.WriteLine("- Cac ky tu trong chuoi la: ");
        for (int i = 'A'; i <= 'Z'; i++)
        {
            if (count[i] > 0)
            {
                Console.WriteLine($"{(char)i} : {count[i]}");
            }
        }
    }

    static void TimKyTu(int[] count)
    {
        int max = count['A'];
        char pos = 'A';
        for (int i = 'B'; i <= 'Z'; i++)
        {
            if (max < count[i])
            {
                max = count[i];
                pos = (char)i;
            }
        }
        Console.WriteLine($"First Max Freq: {pos} , {max}");
    }

    public static void Run1()
    {
        Console.Write("s = ");
        string s = Console.ReadLine()!;
        int[] count = new int[91];
        DemKyTu(s, count);
        TimKyTu(count);
    }
}
}