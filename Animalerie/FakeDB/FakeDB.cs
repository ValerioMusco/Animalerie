using Animalerie.Enumeration;
using Animalerie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animalerie.FakeDB {
    public static class FakeDB {

        public static List<Animals>FakeList = new(){

            new Dogs("Max", 10.5, Sex.male, 3, DateTime.Now, Color.Red, true, Race.Labrador),
            new Birds("Bluejay", 0.2, Sex.femelle, 2, DateTime.Now, Color.Blue, true),
            new Cats("Whiskers", 4.5, Sex.male, 2, DateTime.Now, "Playful", true, false),
            new Dogs("Lucy", 7.8, Sex.male, 4, DateTime.Now, Color.Red, false, Race.Belgian_Malinois),
            new Dogs("Cooper", 9.6, Sex.hermaphrodite, 6, DateTime.Now, Color.Blue, true, Race.Beagle),
            new Cats("Mittens", 3.8, Sex.femelle, 3, DateTime.Now, "Cuddly", true, true),
            new Cats("Shadow", 5.2, Sex.male, 1, DateTime.Now, "Independent", false, true),
            new Birds("Parrot", 0.3, Sex.femelle, 2, DateTime.Now, Color.Green, true),
            new Cats("Luna", 3.6, Sex.femelle, 2, DateTime.Now, "Curious", true, true),
            new Cats("Lucy", 3.9, Sex.femelle, 2, DateTime.Now, "Lazy", false, true),
            new Birds("Cardinal", 0.15, Sex.male, 1, DateTime.Now, Color.Red, false),
            new Birds("Finch", 0.08, Sex.male, 1, DateTime.Now, Color.Blue, false),
            new Cats("Oliver", 4.1, Sex.male, 3, DateTime.Now, "Friendly", true, false),
            new Birds("Peacock", 0.5, Sex.femelle, 2, DateTime.Now, Color.Blue, true),
            new Cats("Simba", 4.7, Sex.male, 1, DateTime.Now, "Adventurous", true, false),
            new Cats("Misty", 3.3, Sex.femelle, 2, DateTime.Now, "Sweet", true, true),
            new Cats("Leo", 4.8, Sex.male, 3, DateTime.Now, "Brave", false, true),
            new Cats("Coco", 3.5, Sex.femelle, 2, DateTime.Now, "Mischievous", true, true),
            new Cats("Oscar", 4.3, Sex.male, 1, DateTime.Now, "Playful", true, false),
            new Cats("Ginger", 3.7, Sex.femelle, 2, DateTime.Now, "Energetic", false, true),
            new Dogs("Charlie", 12.1, Sex.male, 2, DateTime.Now, Color.Green, true, Race.Yorkshire),
            new Cats("Max", 4.6, Sex.male, 3, DateTime.Now, "Affectionate", true, false),
            new Birds("Robin", 0.1, Sex.male, 1, DateTime.Now, Color.Red, false),
            new Birds("Canary", 0.12, Sex.femelle, 2, DateTime.Now, Color.Yellow, false),
            new Birds("Dove", 0.25, Sex.male, 1, DateTime.Now, Color.White, true),
            new Dogs("Bella", 8.2, Sex.femelle, 5, DateTime.Now, Color.Blue, false, Race.German_Sheperd),
            new Birds("Sparrow", 0.09, Sex.male, 1, DateTime.Now, Color.Brown, false)
        };
    }
}
