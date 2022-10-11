using System;

namespace telefonrehberiuygulamasi
{
    class ListContacts : Variables
    {
        public static void listContacts()
        {
            Console.WriteLine("Rehberinizdeki kişiler listeleniyor...");
            foreach (var item in phoneList)
            {
                Console.WriteLine("İsim : " + item.Name + "\t Soyisim : " + item.Surname + "\t Telefon Numarası : " + item.PhoneNumber);
            }
        }



    }


}