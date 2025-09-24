using System;


namespace tugasoop_onlineshop
{
    internal class produk
    {
       
        public produk(string nama, int harga)
        {
            this.nama = nama;
            this.harga = harga;
        }
        public string nama { get; set; }
        public int harga { get; set; }

        public virtual void displayInfo()
        {
            Console.WriteLine($"Nama Produk: {nama}, Harga: {harga}");
        }


    }
}
