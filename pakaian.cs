using System;

namespace tugasoop_onlineshop
{
    internal class pakaian : produk
    {
        
        public pakaian(string nama, int harga, string ukuran, string warna) : base(nama, harga)
        {
            this.ukuran = ukuran;
            this.warna = warna;
        }

        public string ukuran { get; set; }
        public string warna { get; set; }

        // overriding method displayInfo
        public override void displayInfo()
        {
            Console.WriteLine($"Nama Produk: {nama}, Harga: {harga}, Ukuran: {ukuran}");
        }
    }
}
