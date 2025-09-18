using System;

namespace tugasoop_onlineshop
{
    internal class aksesoris : produk
    {
        public string jenis { get; set; }
        public aksesoris(string nama, int harga, string jenis) : base(nama, harga)
        {
            this.jenis = jenis;
        }
        public string Jenis => jenis;
        public void displayInfo()
        {
            Console.WriteLine($"Nama Produk: {nama}, Harga: {harga}, Jenis: {jenis}");
        }
    }
    
}
