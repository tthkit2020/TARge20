using System;

namespace CatsAndDogsOop
{
    class Program
    {

        class Pet
        {
            public string name;
            public string color;
            public int levelOfHapiness;

            public void PrintPetInfo()
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Color: {color}");
                Console.WriteLine($"Level Of Hapinnes: {levelOfHapiness}");
            }

        }

        class Dog: Pet
        {
            public Dog(string _name, string _color)
            {
                name = _name;
                color = _color;
                levelOfHapiness = 0;
            }

            public void WaveTail()
            {
                levelOfHapiness += 1;
            }

            public bool Bark()
            {
                Console.WriteLine("Woof-woof!");
                return true;
            }
        }

        class Cat: Pet
        {
            public Cat(string _name, string _color)
            {
                name = _name;
                color = _color;
                levelOfHapiness = 10;
            }

            public void HearTheDog()
            {
                levelOfHapiness = 0;
            }

            public void Hiss()
            {
                Console.WriteLine("Hssssss");
            }
        }


        static void Main(string[] args)
        {
            Dog Rex = new Dog("Rex", "black and white");
            Rex.PrintPetInfo();
            Cat Garfield = new Cat("Garfield", "ginger");
            Garfield.PrintPetInfo();
            
            for(int i = 0; i < 10; i++)
            {
                Rex.WaveTail();
            }

            if (Rex.Bark())
            {
                Garfield.HearTheDog();
            }

            if (Garfield.levelOfHapiness == 0)
            {
                Garfield.Hiss();
            }

        }
    }
}
