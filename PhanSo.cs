using System;

namespace Buoi2
{
    public class PhanSo
    {
        public int TuSo { get; set; }
        public int MauSo { get; set; }

        public PhanSo() 
        {
            TuSo = 0;
            MauSo = 1;
        }

        public PhanSo(int soNguyen) 
        {
            TuSo = soNguyen;
            MauSo = 1;
        }

        public PhanSo(int tuSoArg, int mauSoArg) 
        {
            TuSo = tuSoArg;
            MauSo = mauSoArg;
        }

        public static PhanSo operator + (PhanSo a, PhanSo b) 
        {
            int tuMoi = a.TuSo * b.MauSo + a.MauSo * b.TuSo;
            int mauMoi = a.MauSo * b.MauSo;
            return new PhanSo(tuMoi, mauMoi);
        }

        public static PhanSo operator - (PhanSo a, PhanSo b) 
        {
            int tuMoi = a.TuSo * b.MauSo - a.MauSo * b.TuSo;
            int mauMoi = a.MauSo * b.MauSo;
            return new PhanSo(tuMoi, mauMoi);
        }

        // So sanh lon hon a / b va c / d => a / b - c / d > 0
        public static bool operator > (PhanSo a, PhanSo b) {
            PhanSo kq = a - b;
            return kq.TuSo > 0;
        }

        // So sanh nho hon a / b va c / d => a / b - c / d < 0
        public static bool operator < (PhanSo a, PhanSo b) {
            PhanSo kq = a - b;
            return kq.TuSo < 0;
        }

        // So sanh lon hon hoac bang a / b va c / d => a / b - c / d >= 0 <=> (a*d - b*c)/(b*d) >= 0
        public static bool operator >= (PhanSo a, PhanSo b) {
            return !(a < b);
        }

        // So sanh nho hon hoac bang a / b va c / d => a / b - c / d <= 0 <=> (a*d - b*c)/(b*d) <= 0
        public static bool operator <= (PhanSo a, PhanSo b) {
            return !(a > b);
        }

        public static bool operator == (PhanSo a, PhanSo b) {
            PhanSo kq = a - b;
            return kq.TuSo == 0;
        }



        // So sanh khac a / b va c / d => a / b - c / d != 0
        public static bool operator != (PhanSo a, PhanSo b) {
            return !(a == b);
        }

        public void prettyPrint() 
        {
            Console.WriteLine($"Gia tri la: {TuSo} / {MauSo}");
        }
    }
}