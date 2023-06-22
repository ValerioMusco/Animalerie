using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animalerie.Models {
    public class Birds : Animals {


        public Color Color { get; set; }
        public bool IsBig { get; set; }
        public double DeathProbability = 3;

        public Birds( string name, double weight, Enumeration.Sex sex, int age, DateTime entryDate, Color color, bool big ) 
                                                                              : base( name, weight, sex, age, entryDate ) {
            Color = color;
            IsBig = big;
        }

        public override double HumanAge { 
            get => base.HumanAge; 
            set => base.HumanAge = value * 5; 
        }

        public override bool IsAlive( Animals a ) {

            Random r = new();

            return ( r.Next( 0, (int)( 100 / DeathProbability ) ) % r.Next( 0, (int)( 100 / DeathProbability ) ) == 0 );
            ;
        }

        public override void Speak() {
            Console.WriteLine("Piou piou");
        }
    }
}
