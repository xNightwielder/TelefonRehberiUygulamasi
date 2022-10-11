using System;

namespace telefonrehberiuygulamasi
{
    class AddNewNumber : Variables
    {
        public static void addNumber()
        {
            bool kaydedildiMi = false;
            Console.Write("\n Lütfen isim giriniz : ");
            string isim = Console.ReadLine();
            Console.Write("\n Lütfen soyisim giriniz : ");
            string soyisim = Console.ReadLine();
            Console.Write("\n Lütfen telefon numarası giriniz : ");
            string telefon = Console.ReadLine();
            decimal result;
            bool isNumber = decimal.TryParse(telefon, out result);


            if ((!string.IsNullOrEmpty(isim) || !string.IsNullOrEmpty(soyisim) || !string.IsNullOrEmpty(telefon.ToString())) && isNumber == false)
            {
                Console.WriteLine("Boş değer veya telefona yanlış veri girdiniz, kişi güncellenemedi.");
                Program.programStart();
            }
            else
            {

                Phone phone = new Phone(result, isim, soyisim);

                phoneList.Add(phone);
                kaydedildiMi = true;

                if (kaydedildiMi == true)
                {
                    Console.WriteLine("\n\n\n Telefon numarası başarıyla kaydedildi.");
                }
            }

        }
    }
}