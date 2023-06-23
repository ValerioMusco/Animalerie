using Animalerie.Enumeration;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Animalerie.Models {
    public class Cats : Animals {

        public double _deathProbability = 0.5;
        public override double DeathProbability {
            get { return _deathProbability; }
            set { _deathProbability = value; }
        }
        public string Nature { get; set; }
        public bool IsClawsCut { get; set; }
        public bool IsLongHair { get; set; }

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

        public override void Speak() {

            Console.WriteLine("Miaow");
        }

        public static Animals AddCatInfo() {

            string name;
            double weight;
            Sex sex;
            int age;
            string nature;
            bool claw;
            bool hair;

            int choice;

            ConsoleKey key;

            Console.WriteLine( "Entrez le nom du chat : " );
            name = Console.ReadLine() ?? "";

            Console.WriteLine( "Entrez le poids du chat : " );
            while( !double.TryParse( Console.ReadLine(), out weight ) );

            Console.WriteLine( "Entrez le sexe du chat : (0 : Male | 1 : Femelle | 2 : Hermaphrodite)" );
            while( !int.TryParse( Console.ReadLine(), out choice ) );
            sex = (Sex)choice;

            Console.WriteLine( "Entrez l'age du chat : " );
            while( !int.TryParse( Console.ReadLine(), out age ) );

            Console.WriteLine( " Entrez la nature du chat : " );
            nature = Console.ReadLine() ?? "";

            Console.WriteLine( "Le chat à t'il ses griffes coupées ? (Y/N)" );
            do {
                key = Console.ReadKey( true ).Key;
            } while( key != ConsoleKey.Y && key != ConsoleKey.N );
            claw = ( key == ConsoleKey.Y );

            Console.WriteLine( "Le chat à t'il des long poil? (Y/N)" );
            do {
                key = Console.ReadKey( true ).Key;
            } while( key != ConsoleKey.Y && key != ConsoleKey.N );
            hair = ( key == ConsoleKey.Y );

            return new Cats( name, weight, sex, age, DateTime.Now, nature, claw, hair);
        }

        public override string ToString() {

            string claw = IsClawsCut ? "À les griffes coupées" : "N'as pas les griffes coupées";
            string hair = IsLongHair ? "Poil long" : "Poil court";
            return $"{Name}, {Weight}Kg, {Sex}, {Age}an(s), {EntryDate}, {Nature}, {claw}, {hair}";
        }
    }
}
