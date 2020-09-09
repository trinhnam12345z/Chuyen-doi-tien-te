using System;

namespace Chuyen_doi_tien_te
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("CT CHUYỂN ĐỔI TIỀN TỆ USD -> VNĐ");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Nhập tỉ giá tiền (Ví dụ 23000 Vnđ/USD):");
            int tigia = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập USD :");
            int usd = int.Parse(Console.ReadLine());
            doitien(tigia, usd);
        }
        static int doitien(int tigia, int usd)
        {
            int vnd = tigia * usd;
            Console.WriteLine("USD => VNĐ là : {0} Vnđ", vnd);
            return vnd;
        }
    }
}
