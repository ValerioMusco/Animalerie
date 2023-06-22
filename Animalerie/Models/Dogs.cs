using Animalerie.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animalerie.Models
{
    public class Dogs : Animals {

        public Color Collar { get; set; }
        public bool IsDressed { get; set; }
        public Race Race { get; set; }
        public double DeathProbability = 1;

        public Dogs( string name, double weight, Sex sex, int age, DateTime entryDate, Color collar, bool isDressed, Race race ) 
                                                                                     : base(name, weight, sex, age, entryDate) {
            Collar = collar;
            IsDressed = isDressed;
            Race = race;
        }

        public override double HumanAge { 
            get => base.HumanAge; 
            set => base.HumanAge = value * 7; 
        }

        public override bool IsAlive( Animals a ) {

            Random r = new();

            return ( r.Next( 0, (int)( 100 / DeathProbability ) ) % r.Next( 0, (int)(100 / DeathProbability) ) == 0);
            ;
        }

        public override void Speak() {
            Console.WriteLine("Woof");
        }
    }
}
