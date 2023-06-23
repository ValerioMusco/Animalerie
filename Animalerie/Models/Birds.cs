using Animalerie.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Animalerie.Models {
    public class Birds : Animals {


        public Color Color { get; set; }
        public bool IsBig { get; set; }
        public double _deathProbability = 3;
        public override double DeathProbability {
            get { return _deathProbability; }
            set { _deathProbability = value; }
        }

        public Birds( string name, double weight, Sex sex, int age, DateTime entryDate, Color color, bool big ) 
                                                                              : base( name, weight, sex, age, entryDate ) {
            Color = color;
            IsBig = big;
        }

        public override double HumanAge { 
            get => base.HumanAge; 
            set => base.HumanAge = value * 5; 
        }

        public override void Speak() {
            Console.WriteLine("Piou piou");
        }

        public static Animals AddBirdInfo() {

            string name;
            double weight;
            Sex sex;
            int age;
            Color color;
            bool size;

            int choice;

            ConsoleKey key;

            Console.WriteLine( "Entrez le nom de l'oiseau : " );
            name = Console.ReadLine() ?? "";

            Console.WriteLine( "Entrez le poids de l'oiseau : " );
            while( !double.TryParse( Console.ReadLine(), out weight ) );

            Console.WriteLine( "Entrez le sexe de l'oiseau : (0 : Male | 1 : Femelle | 2 : Hermaphrodite)" );
            while( !int.TryParse( Console.ReadLine(), out choice ) );
            sex = (Sex)choice;

            Console.WriteLine( "Entrez l'age de l'oiseau : " );
            while( !int.TryParse( Console.ReadLine(), out age ) );

            Console.WriteLine( "Entrez la couleur de l'oiseau : " );
            foreach( var value in Enum.GetValues( typeof( Color ) ) )
                Console.Write( $" {(int)value}, {value} | " );
            while( !int.TryParse( Console.ReadLine(), out choice ) );
            color = (Color)choice;

            Console.WriteLine( "L'oiseau à t'il besoin d'une grande cage ? (Y/N)" );
            do {
                key = Console.ReadKey( true ).Key;
            } while( key != ConsoleKey.Y && key != ConsoleKey.N );
            size = ( key == ConsoleKey.Y );

            return new Birds( name, weight, sex, age, DateTime.Now, color, size );
        }

        public override string ToString() {

            string big = IsBig ? "À besoin d'une volière" : "À besoin d'une petite cage";
            return $"{Name}, {Weight}Kg, {Sex}, {Age}an(s), {EntryDate}, {Color}, {big}";
        }
    }
}
