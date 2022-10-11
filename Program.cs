using System.Collections;
using System;

namespace telefonrehberiuygulamasi
{

    class Program
    {

        static void Main(string[] args)
        {
            bool anaEkran = true;

            while (anaEkran)
            {
                Program.programStart();

            }
        }

        public static void programStart()
        {
            Console.WriteLine("\nLütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("******************************************");
            Console.WriteLine("1- Yeni Numara Kaydetmek");
            Console.WriteLine("2- Rehberdeki Kişileri Listelemek");
            Console.WriteLine("3- Varolan Numarayı Silmek");
            Console.WriteLine("4- Varolan Numarayı Güncellemek");
            Console.WriteLine("5- Rehberde Arama Yapmak");







            int enteredValue = Convert.ToInt16(Console.ReadLine());

            if (enteredValue == 1)
            {
                AddNewNumber.addNumber();
            }
            if (enteredValue == 2)
            {
                ListContacts.listContacts();
            }
            if (enteredValue == 3)
            {
                DeleteNumber.deleteNumber();
            }
            if(enteredValue == 4){
                UpdateNumber.updateNumber();
            }
            if(enteredValue == 5){
                Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
                Console.WriteLine("**************************************");
                Console.WriteLine("İsim veya soyisime göre arama yapmak için : (1)");
                Console.WriteLine("Telefon numarasına göre arama yapmak için : (2)");
                int enteredSearchValue = Convert.ToInt32(Console.ReadLine());

                SearchingDirectory.searchDirectory(enteredSearchValue); 


            }
        }



    }
}

