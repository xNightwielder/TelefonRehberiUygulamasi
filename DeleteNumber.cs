using System;

namespace telefonrehberiuygulamasi
{
    class DeleteNumber : Variables
    {

        public static void deleteNumber()
        {
            bool isFounded = false;
            Console.Write("Silmek istediğiniz kişinin adı veya soyadını giriniz : ");
            string information = Console.ReadLine();

            foreach (var item in phoneList)
            {
                if (item.Name == information || item.Surname == information)
                {
                    Console.WriteLine(information + " kişisi rehberden silinmek üzere, onaylıyor musunuz?(evet/hayır");
                    string confirmation = Console.ReadLine();
                    if (confirmation == "evet")
                    {
                        Variables.phoneList.Remove(item);
                        isFounded = true;
                        Console.WriteLine("Kişi başarıyla silindi.");
                        break;
                    }
                    else if (confirmation == "hayır")
                    {
                        returnToStartMenu();
                        break;
                    }
                }

            }

            if (isFounded == false)
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                int enteredValue = Convert.ToInt32(Console.ReadLine());

                if (enteredValue == 1)
                {
                    returnToStartMenu();
                }
                if (enteredValue == 2)
                {
                    deleteNumber();
                }
            }
        }
    }


}
