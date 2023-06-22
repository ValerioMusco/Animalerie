using Animalerie.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animalerie.Models {
    public class Animals {

        public string Name { get; set; }
        public double Weight { get; set; }
        public Sex Sex { get; set; }
        public int Age { get; set; }
        public double _humanAge;
        public DateTime EntryDate { get; set; }

        public virtual double HumanAge {
            get {

                return _humanAge;
            }
            set {

                _humanAge = value * 3;
            }
        }

        public Animals( string name, double weight, Sex sex, int age, DateTime entryDate ) {
            Name = name;
            Weight = weight;
            Sex = sex;
            Age = age;
            HumanAge = age;
            EntryDate = entryDate;
        }

        public virtual bool IsAlive(Animals a) {

            return true;
        }

        public virtual void Speak() {

            Console.WriteLine("The animal speaks");
        }
    }
}
