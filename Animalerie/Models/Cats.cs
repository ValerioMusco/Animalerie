using Animalerie.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animalerie.Models {
    public class Cats : Animals {

        public string Nature { get; set; }
        public bool IsClawsCut { get; set; }
        public bool IsLongHair { get; set; }
        public double DeathProbability = 0.5;

        public Cats( string name, double weight, Sex sex, int age, DateTime entryDate, string nature, bool claw, bool hair ) 
                                                                               : base( name, weight, sex, age, entryDate ) {

            Nature = nature;
            IsClawsCut = claw;
            IsLongHair = hair;
        }


        public override double HumanAge {
            get => base.HumanAge;
            set => base.HumanAge = (value * 4) + 14;
        }
        public override bool IsAlive( Animals a ) {

            Random r = new();

            return ( r.Next( 0, (int)( 100 / DeathProbability ) ) % r.Next( 0, (int)( 100 / DeathProbability ) ) == 0 );
            ;
        }

        public override void Speak() {

            Console.WriteLine("Miaow");
        }
    }
}
