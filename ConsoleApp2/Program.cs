using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;


namespace ConsoleApp2
{
    internal class Program
    {

        
        static void Main(string[] args)
        {


            string[] alfabe = { "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "İ", "I", "J", "K", "L", "M", "N", "O", "Ö",
             "P", "R", "S", "Ş", "T", "U","Ü", "V", "Y", "Z", " "};
            int sirano = 0;
            string cmetin=null;
            StreamReader oku;
            oku = File.OpenText(@"C:\tdk.txt");
            string yazi;
            string gecicimetin = "";
            int tdksayac = 0;
            int[] ofsetdizi = new int[28];
            Console.WriteLine("Şifreli Metni giriniz");
            string metin = Console.ReadLine();
            metin = metin.ToUpper();
            string[] metindizi = new string[metin.Length]; 
            int[] siradizi = new int[metin.Length]; 

            for (int i = 0; i < metin.Length; i++)
            {
                metindizi[i] = metin[i].ToString(); 
            }

            for (int i = 0; i < metindizi.Length; i++)
            {
                siradizi[i] = Array.IndexOf(alfabe, metindizi[i]);
            }
            for (int f = 0; f >= 29; f++)
            {

            
                for (int j = 0; j >= metindizi.Length; j++)
                {
                    gecicimetin = gecicimetin + alfabe[siradizi [j]];
                    if (siradizi[j]==29)
                    {

                        Console.WriteLine("BOŞLUK VAR TDK SORGULA");
                        while ((yazi = oku.ReadLine()) != null)
                        {
                            
                            if (yazi == cmetin)
                            {
                                tdksayac++;
                              
                                break;


                            }

                        }
                        gecicimetin = "";
                    }
                    

                }
                    ofsetdizi[f] = tdksayac;
                    if (siradizi[f] == 28)
                    {
                        siradizi[f] = 0;
                    }

                    else
                    {
                        siradizi[f]++;
                    }


            }
            Console.ReadKey();

            




        }
    }
}


