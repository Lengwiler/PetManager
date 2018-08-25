using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManager {
    public class Pet {
        public string Name { get; set; }
        public string Breed { get; set; }
        public DateTime Birthday { get; set; }
        public int Age
        {
            get { return (DateTime.Now - Birthday).Days / 365; }
        }

        public Pet()
        {
            Birthday = new DateTime(2010, 10, 10);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Breed.GetHashCode() + Birthday.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Pet))
            {
                return object.Equals(obj, this);
            }
            var pet = (Pet)obj;
            return string.Equals(this.Name, pet.Name) && Birthday.Equals(pet.Birthday) &&
                   string.Equals(this.Breed, pet.Breed);
        }
    }
}
