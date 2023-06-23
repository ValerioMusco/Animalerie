using Animalerie.FakeDB;
using Animalerie.Models;
using System.Text;

List<Animals> animals = FakeDB.FakeList;
bool quit = false;
int choice;

do {

    choice = Menu();

    switch( choice ) {

        case 0:
            Add(animals);
            break;
        case 1:
            GetAll(animals);
            break;
        case 2:
            GetTypeAnimals(animals);
            break;
        case 3:
            IsDead(animals);
            break;
        default: 
            quit = true;
            break;
    }

} while( !quit );


#region Method

int Menu() {

    ConsoleKey key;
    int pos = 0;

    do {

        Console.Clear();
        PrintMenu( pos );
        key = Console.ReadKey( true ).Key;
      
        switch( key ) {

            case ConsoleKey.DownArrow:
                pos = (pos == 4) ? 0 : pos + 1;
                break;
            case ConsoleKey.UpArrow:
                pos = ( pos == 0 ) ? 4 : pos - 1;
                break;
        }
    } while( key != ConsoleKey.Enter );

    return pos;
}

void Add(List<Animals> animals) {

    ConsoleKey key;
    int pos = 0;

    do {

        Console.Clear();
        PrintAddAnimals( pos );
        key = Console.ReadKey( true ).Key;

        switch( key ) {

            case ConsoleKey.DownArrow:
                pos = (pos == 2) ? 0 : pos + 1;
                break;
            case ConsoleKey.UpArrow:
                pos = (pos == 0) ? 2 : pos - 1;
                break;
            case ConsoleKey.Escape:
                pos = -1;
                key = ConsoleKey.Enter;
                break;
        }

    } while( key != ConsoleKey.Enter );

    AddAnimal( animals, pos );
}

void AddAnimal( List<Animals> animals, int pos ) {

    switch( pos ) {

        case -1: // Escape
            return;
        case 0: // Chien
            animals.Add( Dogs.AddDogInfo() );
            break;
        case 1: // Chat
            animals.Add( Cats.AddCatInfo() );
            break;
        case 2: //Oiseaux
            animals.Add( Birds.AddBirdInfo() );
            break;
    }
}

void GetAll(List<Animals> animals) {

    Console.Clear();

    foreach(Animals animal in animals) {

        Console.WriteLine(animal);
        Console.WriteLine( "\\*--------------------------------------------------------------------------------------------------*/" );
    }

    Console.ReadKey();
}

void GetTypeAnimals(List<Animals> animals) {

    int dogs = 0;
    int cats = 0;
    int birds = 0;

    Console.Clear();

    foreach (Animals animal in animals) {

        switch( animal ) {

            case Dogs:
                dogs++;
                break;
            case Cats:
                cats++;
                break;
            case Birds:
                birds++;
                break;
        }
    }

    Console.WriteLine($"{dogs} chien, {cats} chat, {birds} oiseaux");
    Console.ReadKey();
}

void IsDead(List<Animals> animals) {

    List<Animals>deadAnimals = new();

    foreach(Animals animal in animals) {

        if(Animals.IsAlive(animal.DeathProbability)) {

            Console.WriteLine( $"{animal.Name} is dead" );
            deadAnimals.Add( animal );
        }
    }

    if( deadAnimals.Count == 0 )
        Console.WriteLine("Personne n'est mort ce soir");
    else
        foreach (Animals animal in deadAnimals)
            animals.Remove( animal );

    Console.ReadKey();
}

#endregion

#region Interface

void PrintMenu( int pos ) {

    StringBuilder sb = new();

    sb.AppendLine( "Que voulez vous faire ? :" );
    switch( pos ) {

        case 0:
            sb.AppendLine( "> | Ajout d'un animal" );
            sb.AppendLine( "  | Lister tout les animaux" );
            sb.AppendLine( "  | Lister le nombre de type d'animaux" );
            sb.AppendLine( "  | Verification des morts" );
            sb.AppendLine( "  | Quitter" );
            break;
        case 1:
            sb.AppendLine( "  | Ajout d'un animal" );
            sb.AppendLine( "> | Lister tout les animaux" );
            sb.AppendLine( "  | Lister le nombre de type d'animaux" );
            sb.AppendLine( "  | Verification des morts" );
            sb.AppendLine( "  | Quitter" );
            break;
        case 2:
            sb.AppendLine( "  | Ajout d'un animal" );
            sb.AppendLine( "  | Lister tout les animaux" );
            sb.AppendLine( "> | Lister le nombre de type d'animaux" );
            sb.AppendLine( "  | Verification des morts" );
            sb.AppendLine( "  | Quitter" );
            break;
        case 3: 
            sb.AppendLine( "  | Ajout d'un animal" );
            sb.AppendLine( "  | Lister tout les animaux" );
            sb.AppendLine( "  | Lister le nombre de type d'animaux" );
            sb.AppendLine( "> | Verification des morts" );
            sb.AppendLine( "  | Quitter" );
            break;
        case 4:
            sb.AppendLine( "  | Ajout d'un animal" );
            sb.AppendLine( "  | Lister tout les animaux" );
            sb.AppendLine( "  | Lister le nombre de type d'animaux" );
            sb.AppendLine( "  | Verification des morts" );
            sb.AppendLine( "> | Quitter" );
            break;
    }

    Console.WriteLine(sb);
}
void PrintAddAnimals( int pos ) {

    StringBuilder sb = new();

    sb.AppendLine( "Quel type d'animal ajouter ? : (Escape pour revenir en arrière)" );
    switch( pos ) {

        case 0: // Chien
            sb.AppendLine( "> | Chien" );
            sb.AppendLine( "  | Chat" );
            sb.AppendLine( "  | Oiseaux" );
            break;
        case 1: // Chat
            sb.AppendLine( "  | Chien" );
            sb.AppendLine( "> | Chat" );
            sb.AppendLine( "  | Oiseaux" );
            break;
        case 2: // Oiseaux
            sb.AppendLine( "  | Chien" );
            sb.AppendLine( "  | Chat" );
            sb.AppendLine( "> | Oiseaux" );
            break;
    }

    Console.WriteLine( sb );
}

#endregion