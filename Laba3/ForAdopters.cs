using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Laba3
{
    internal class ForAdopters
    {
        public int AdopterId;
        public int DogId;

        public string Surname { get; private set;}
        public string Name { get; private set; }
        public string MiddleName { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public string AddressAdopter { get; private set; }
        public DateTime AdoptionDate { get; private set; }
        public string NameDog { get; private set; }
        public string Breed { get; private set; }
        public int Age { get; private set; }
        public string Gender { get; private set; }
        public string Size { get; private set; }
        public DateTime ArrivalDate { get; private set; }
        public string IsAdopted { get; private set; }
        public ForAdopters(Adopters adopter) 
        {
            AdopterId = adopter.AdopterID;
            Surname = adopter.SurnameAdopter;
            Name = adopter.NameAdopter;
            MiddleName = adopter.MiddlenameAdopter;
            Email = adopter.Email;
            Phone = adopter.Phone;
            AddressAdopter = adopter.AddressAdopter;
            AdoptionDate = (DateTime)adopter.AdoptionDate;

            if (adopter.ID_Dog != null)
            {
                DogId = adopter.Dogs.Dog_ID;
                NameDog = adopter.Dogs.NameDog;
                Breed = adopter.Dogs.Breed;
                Age = (int)adopter.Dogs.Age;
                Gender = adopter.Dogs.Gender;
                Size = adopter.Dogs.Size;
                ArrivalDate = (DateTime)adopter.Dogs.ArrivalDate;
                IsAdopted = adopter.Dogs.IsAdopted;
            }

        }
    }
}
