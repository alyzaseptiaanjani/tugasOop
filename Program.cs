namespace tugasoop_onlineshop
{
    class program
    {
       static void Main(string[] args)
        {
            keranjangbelanja kerkun = new keranjangbelanja();

            produk p1 = new pakaian("rok", 70000, "m", "pink");
            produk p2 = new aksesoris("cincin", 50000, "emas");

            // menambahkan produk ke keranjang belanja
            Console.WriteLine("===== SELAMAT BERBELANJA =====");
            Console.WriteLine("Menambahkan produk ke keranjang belanja");
            kerkun.tambahProduk(p1);
            kerkun.tambahProduk(p2);
            kerkun.tambahProduk("topi", 40000);

            // menampilkan isi keranjang belanja
            kerkun.tampilkanKeranjang();


        }


    }
}
