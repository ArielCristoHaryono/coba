using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nama = 1;
          
            {
                string Nama = Console.ReadLine();
                Console.Write("Alamat :");
                string Rumah = Console.ReadLine();

                //
                //    Console.WriteLine("==> cari nama: ")
                //       Int cariNama = ConvertToInt32(Console.ReadLine());

            while (mintaAgain != "y" && mintaAgain != "n")
            {
                Console.Write("Coba lagi? (y/n) ");
                mintaAgain = Console.ReadLine();
            }
                if (mintaAgain == "y")
                {
                    Console.Write("==> cari nama: ");
                    cariNama = Convert.ToInt32(Console.ReadLine());
                    mintaAgain = "";
                }
                else if (mintaAgain == "n")
                {
                    statusProgram = 1;
                }
            }
                

                //if (namaKe = namaKe++) // namanya sudah ada 
                //{
                //    Console.WriteLine("Nama sudah ada");
                //}

                //Console.WriteLine("==> cari nama: ");
                //    if () // nama yang dicari tidak ada 
                //{
                //    Console.WriteLine("Nama tidak ditemukan");
                //}
                //Console.WriteLine("cari lagi? (y/n)")
                //    string cari = Console.ReadLine();
                //if (y) // ulangi                console.writeline("==> cari nama: ")
                //    if () // nama yang dicari tidak ada 
                //{
                //    console.writeline("nama tidak ditemukan");
                //}
                //console.writeline("cari lagi? (y/n)")
                //    string cari = console.readline();
                //if (y) // ulangi
                //if (key == n) // stop
                //{
                //    break;
                //}

            }
        }
    }
