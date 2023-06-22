using Animalerie.Models;
using System.Net.Quic;
using System.Text;

List<Animals> animals = new();
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


/** ----------------- METHODE ----------------- **/

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
    throw new NotImplementedException();
}

void GetAll(List<Animals> animals) {
    throw new NotImplementedException();
}
void GetTypeAnimals(List<Animals> animals) {
    throw new NotImplementedException();
}
void IsDead(List<Animals> animals) {
    throw new NotImplementedException();
}

/** ------------------- INTERFACE ---------------------- **/
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