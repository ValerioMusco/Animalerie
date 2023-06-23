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
        private double _humanAge;
        public DateTime EntryDate { get; set; }
        public virtual double DeathProbability { get; set; } 

        public virtual double HumanAge {
            get {

                return _humanAge;
            }
            set {

                _humanAge = value;
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

        public static bool IsAlive(double deathProbability) {

            Random r = new();

            return ( r.Next( 0, (int)( 100 / deathProbability ) ) % (int)( 100 / deathProbability ) == 0 );
        }

        public virtual void Speak() {

            Console.WriteLine("The animal speaks");
        }

    }
}
