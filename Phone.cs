using System;

namespace telefonrehberiuygulamasi
{
    class Phone
    {
        private decimal phoneNumber;
        private string name;
        private string surname;
        
        public decimal PhoneNumber { get => phoneNumber; set => PhoneNumber = value; }
        public string Name { get=> name; set=> Name = value; }
        public string Surname { get=> surname; set=> Surname = value; }
        public Phone(decimal phoneNumber, string name, string surname){
            this.name = name;
            this.surname = surname;
            this.phoneNumber = phoneNumber;
        }
        

        
    }
}