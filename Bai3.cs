namespace Buoi2
{
    class Bai3
    {
        static string TachHoTen(string name)
        {
            int first = name.IndexOf(' ');
            int last = name.LastIndexOf(' ');
            string result = name + "\n";
            result = result + $"Ho : {name.Substring(0, first)}\n";
            result = result + $"Lot: {name.Substring(first + 1, last - first - 1)}\n";
            result = result + $"Ten: {name.Substring(last + 1)}\n";
            return result;
        }

       public static void Run3()
        {
            string path, pathInp, pathOut;
            while (true)
            {
                Console.Write("Enter path: ");
                path = Console.ReadLine()!;
                pathInp = path + "\\Names.txt";
                pathOut = path + "\\SplitNames.txt";

                if (File.Exists(pathInp) && File.Exists(pathOut))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("File not found!");
                }
            }

            string result = "";
            using (StreamReader sr = new StreamReader(pathInp))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    result += TachHoTen(line);
                }
            }

            using (StreamWriter sw = new StreamWriter(pathOut))
            {
                sw.Write(result);
            }
            
            Console.WriteLine("Split names successfully!");
        }
    }
}