namespace Buoi2
{
    class Bai2
    {
        static bool Contains8Char(string pass)
        {
            if(pass.Length < 8)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static bool ContainsUpperCase(string pass)
        {
            for(int i = 0; i < pass.Length; i++)
            {
                if(pass[i] >= 'A' && pass[i] <= 'Z')
                {
                    return true;
                }
            }
            return false;
        }
        static bool ContainsLowerCase(string pass)
        {
            for(int i = 0; i < pass.Length; i++)
            {
                if(pass[i] >= 'a' && pass[i] <= 'z')
                {
                    return true;
                }
            }
            return false;
        }
        static bool ContainsNumberCase(string pass)
        {
            for(int i = 0; i < pass.Length; i++)
            {
                if(pass[i] >= '0' && pass[i] <= '9')
                {
                    return true;
                }
            }
            return false;
        }

        public static void Run2()
        {
            Console.Write("Nhap duong dan: ");
            string path = Console.ReadLine()!;
            string pathInp = path + "\\Password.txt";
            string pathOut = path + "\\PasswordValidation.txt";

            if (File.Exists(pathInp))
            {
                string result = "";
                using (StreamReader sr = new StreamReader(pathInp))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (Contains8Char(line) && ContainsLowerCase(line) && ContainsUpperCase(line) && ContainsNumberCase(line))
                        {
                            result = result + $"{line} : Yes\n";
                        }
                        else
                        {
                            result = result + $"{line} : No\n";
                        }
                    }
                }

                // Ghi kết quả ra file PasswordValidation.txt
                using (StreamWriter sw = new StreamWriter(pathOut))
                {
                    sw.Write(result);
                }

                Console.WriteLine("Da xu ly xong va ghi ket qua vao file!");
            }
            else
            {
                Console.WriteLine("Khong tim thay file Password.txt trong duong dan nay!");
            }

        }
    }
}