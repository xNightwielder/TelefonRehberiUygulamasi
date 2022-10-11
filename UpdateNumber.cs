using System;

namespace telefonrehberiuygulamasi
{
    class UpdateNumber : Variables
    {
        public static void updateNumber(){
            bool isFounded = false;
            Console.Write("Güncelleme yapmak istediğiniz kişinin adı veya soyadını giriniz : ");
            string information = Console.ReadLine();

            foreach (var item in phoneList)
            {
                if (item.Name == information || item.Surname == information)
                {
                    Console.WriteLine("***************** Bilgi Güncelleme Ekranı *****************");
                    Console.Write("\n İsim Giriniz : ");
                    string isim = Console.ReadLine();
                    Console.Write("\n Soyisim Giriniz : ");
                    string soyisim = Console.ReadLine();
                    Console.Write("\n Telefon Numarası Giriniz : ");
                    string telefon = Console.ReadLine();
                    decimal result;
                    bool isNumber = decimal.TryParse(telefon, out result);

                    
                    
                    if((!string.IsNullOrEmpty(isim) || !string.IsNullOrEmpty(soyisim) || !string.IsNullOrEmpty(telefon.ToString())) && isNumber == false)
                    {
                        Console.WriteLine("Boş değer veya telefona yanlış veri girdiniz, kişi güncellenemedi.");
                        Program.programStart();
                    }
                    else
                    {
                    Phone updatedPhone = new Phone(result,isim,soyisim);
                    phoneList.Remove(item);
                    phoneList.Add(updatedPhone);


                    isFounded = true;
                    
                    }
                    break;
                }


            }

            if(isFounded == true){
                Console.WriteLine("Bilgiler başarıyla güncellendi.");
            }

            if(isFounded == false){
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Güncelleme işlemini sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                int enteredValue = Convert.ToInt32(Console.ReadLine());

                if (enteredValue == 1)
                {
                    returnToStartMenu();
                }
                if (enteredValue == 2)
                {
                    updateNumber();
                }
            }
        }
    }
}
