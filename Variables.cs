using System.Collections;
using System;

namespace telefonrehberiuygulamasi
{

    class Variables
    {
        public static void returnToStartMenu(){
            Console.WriteLine("Başlangıç menüsüne yönlendiriliyorsunuz...");
            Program.programStart();
        }
        public static List<Phone> phoneList = new List<Phone>();

        
        

    }


}