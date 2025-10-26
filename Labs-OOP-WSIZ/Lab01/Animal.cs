using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class Animal
    {
        public string Name 
        {
            get => _name;
            set {
                _name = value;
            }
        }

        private static int AnimalsCount = 0;

        private string _name;
        private string _species;
        private int _lagsCount;

        public Animal()
        {
            _name = "Poli";
            _species = "Cat";
            _lagsCount = 4;
            AnimalsCount++;
        }

        public Animal(Animal animal)
        {
            _name = animal._name;
            _species = animal._species;
            _lagsCount = animal._lagsCount;
            AnimalsCount++;
        }

        public Animal(string name, string species, int legsCount)
        {
            _name = name;
            _species = species;
            _lagsCount = legsCount;
            AnimalsCount++;
        }

        public static int GetAnimalsCount() => AnimalsCount;

        public string GetSpecies() => _species;
        public int GetLagsCount() => _lagsCount;

        public void Speak()
        {
            string sound = string.Empty;
            switch (_species)
            {
                case "Dog":
                    sound = "Woof!";
                    break;
                case "Cat":
                    sound = "Meow!";
                    break;
                case "Cow":
                    sound = "Moo!";
                    break;
                default:
                    sound = string.Empty;
                    break;
            }
            Console.WriteLine(sound);
        }
    }
}
