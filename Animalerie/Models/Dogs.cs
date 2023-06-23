using Animalerie.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Animalerie.Models
{
    public class Dogs : Animals {

        public double _deathProbability = 1;
        public override double DeathProbability {
            get { return _deathProbability; } 
            set { _deathProbability = value; }
        }
        public Color Collar { get; set; }
        public bool IsDressed { get; set; }
        public Race Race { get; set; }

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

        public override void Speak() {
            Console.WriteLine("Woof");
        }

        public static Dogs AddDogInfo() {

            string name;
            double weight;
            Sex sex;
            int age;
            Color collar;
            bool isDressed;
            Race race;
            int choice;

            ConsoleKey key;

            Console.WriteLine( "Entrez le nom du chien : " );
            name = Console.ReadLine() ?? "";

            Console.WriteLine( "Entrez le poids du chien : " );
            while( !double.TryParse( Console.ReadLine(), out weight ) );

            Console.WriteLine( "Entrez le sexe du chien : (0 : Male | 1 : Femelle | 2 : Hermaphrodite)" );
            while( !int.TryParse( Console.ReadLine(), out choice ) );
            sex = (Sex)choice;

            Console.WriteLine( "Entrez l'age du chien : " );
            while( !int.TryParse( Console.ReadLine(), out age ) );

            Console.WriteLine( "Entrez la couleur du collier du chien : " );
            foreach( var value in Enum.GetValues( typeof(Color) ) )
                Console.Write( $" {(int)value}, {value} | " );
            while( !int.TryParse( Console.ReadLine(), out choice ) );
            collar = (Color)choice;

            Console.WriteLine( "Le chien est-il dressé ? (Y/N)" );
            do {
                key = Console.ReadKey( true ).Key;
            } while(key != ConsoleKey.Y && key != ConsoleKey.N);
            isDressed = ( key == ConsoleKey.Y );

            Console.WriteLine( "Entrez la race du chien" );
            foreach( var value in Enum.GetValues( typeof( Race ) ) )
                Console.Write( $" {(int)value}, {value} | " );
            while( !int.TryParse( Console.ReadLine(), out choice ) );
            race = (Race)choice;

            return new Dogs(name, weight, sex, age, DateTime.Now, collar, isDressed, race);
        }

        public override string ToString() {

            string dressed = IsDressed ? "Est dressé" : "N'est pas dressé";
            return $"{Name}, {Weight}Kg, {Sex}, {Age}an(s), {HumanAge} an(s), {EntryDate}, {Collar}, {dressed}, {Race}";
        }
    }
}
