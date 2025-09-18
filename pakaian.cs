using System;

namespace tugasoop_onlineshop
{
    internal class pakaian : produk
    {
        public string ukuran { get; set; }
        public pakaian(string nama, int harga, string ukuran) : base(nama, harga)
        {
            this.ukuran = ukuran;
        }
        public string Ukuran => ukuran;
        public void displayInfo()
        {
            Console.WriteLine($"Nama Produk: {nama}, Harga: {harga}, Ukuran: {ukuran}");
        }
    }
 

    }
