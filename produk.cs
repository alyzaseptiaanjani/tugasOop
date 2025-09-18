using System;


namespace tugasoop_onlineshop
{
    internal class produk
    {
        public string nama { get; set; }
        public int harga { get; set; }
        public produk(string nama, int harga)
        {
            this.nama = nama;
            this.harga = harga;
        }
        public string Nama => nama;
        public double Harga => harga;

        public void displayInfo()
        {
            Console.WriteLine($"Nama Produk: {nama}, Harga: {harga}");
        }


    }
}
