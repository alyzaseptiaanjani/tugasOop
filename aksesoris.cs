using System;

namespace tugasoop_onlineshop
{
    internal class aksesoris : produk
    {
        
        public aksesoris(string nama, int harga, string jenis) : base(nama, harga)
        {
            this.jenis = jenis;
        }
        public string jenis { get; set; }


        // overriding method displayInfo
        public override void displayInfo()
        {
            Console.WriteLine($"Nama Produk: {nama}, Harga: {harga}, Jenis: {jenis}");
        }
    }
    
}
