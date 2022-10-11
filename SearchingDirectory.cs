using System;

namespace telefonrehberiuygulamasi
{
    class SearchingDirectory : Variables
    {
        public static void searchDirectory(int enteredValue)
        {
            bool isFounded;
            if (enteredValue == 1)
            {
                isFounded = false;
                Console.Write("İsim veya soyisim giriniz :");
                string value = Console.ReadLine();
                Console.WriteLine("Arama Sonuçlarınız : ");
                foreach (var item in phoneList)
                {
                    if (item.Name == value || item.Surname == value)
                    {
                        Console.WriteLine("İsim : " + item.Name);
                        Console.WriteLine("Soyisim : " + item.Surname);
                        Console.WriteLine("Telefon Numarası : " + item.PhoneNumber);
                        Console.WriteLine("-");
                        isFounded = true;

                    }

                }
                if (isFounded == false)
                {
                    Console.WriteLine("Aradığınız kişi bulunamadı.");
                }
            }
            else if (enteredValue == 2)
            {
                isFounded = false;
                Console.Write("Telefon numarasını giriniz : ");
                decimal enteredPhone = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Arama Sonuçlarınız : ");
                foreach (var item in phoneList)
                {
                    if (item.PhoneNumber == enteredPhone)
                    {
                        Console.WriteLine("İsim : " + item.Name);
                        Console.WriteLine("Soyisim : " + item.Surname);
                        Console.WriteLine("Telefon Numarası : " + item.PhoneNumber);
                        Console.WriteLine("-");
                        isFounded = true;
                    }

                }
                if (isFounded == false)
                {
                    Console.WriteLine("Aradığınız kişi bulunamadı.");
                }

            }
            else
            {
                Console.WriteLine("Yanlış değer girdiniz. Başlangıç menüsüne yönlendiriliyorsunuz...");
                Program.programStart();

            }
        }

    }

}