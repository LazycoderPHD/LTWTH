using System;

namespace Buoi2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap tu so cua a: ");
            int tuSoCuA = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Nhap mau so cua a: ");
            int mauSoCuA = Convert.ToInt32(Console.ReadLine());
            PhanSo phanSoA = new PhanSo(tuSoCuA, mauSoCuA);

            Console.Write("Nhap tu so cua b: ");
            int tuSoCuB = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Nhap mau so cua b: ");
            int mauSoCuB = Convert.ToInt32(Console.ReadLine());
            PhanSo phanSoB = new PhanSo(tuSoCuB, mauSoCuB);

            PhanSo kq = phanSoA - phanSoB;

            kq.prettyPrint();

            if (phanSoA > phanSoB) {
                Console.WriteLine("Phan so A lon hon phan so b");
            }

            if (phanSoA < phanSoB) {
                Console.WriteLine("Phan so A nho hon phan so b");
            }
        }
    }
}