using System;
using System.Collections.Generic;
using System.Text;

namespace PetShopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Petshop petshop = new Petshop();

            petshop.AddPet(new Cat("cat_name_1", "cat_breed_1"));
            petshop.AddPet(new Cat("cat_name_3", "cat_breed_2"));
            petshop.AddPet(new Cat("cat_name_4", "cat_breed_3"));
            petshop.AddPet(new Dog("dog_name_1", "dog_breed_1"));
            petshop.AddPet(new Dog("dog_name_2", "dog_breed_2"));
            petshop.AddPet(new Dog("dog_name_3", "dog_breed_3"));

            petshop.IntroduceAll();
			
			Console.ReadLine();
        }
    }
	
	//Contain different pets
    class Petshop
    {
        List<Animal> pets = new List<Animal>();

        public void AddPet(Animal animal)
        {
            pets.Add(animal);
        }

        public void IntroduceAll()
        {
            foreach (Animal item in pets)
                item.Introduce();
        }
    }

	//It includes the basic functionality for the animal
    abstract class Animal
    {
        private string Name;
        private string Breed;

        protected Animal(string name, string breed)
        {
            Name = name;
            Breed = breed;
        }

        protected abstract string GetAnimalType();

        public void Introduce()
        {
            Console.WriteLine("I'm {0} of {1}. I'm a {2}.", Name, Breed, GetAnimalType());
        }
    }

    class Cat : Animal
    {
        public Cat(string name, string breed)
            : base(name, breed)
        { }

        protected override string GetAnimalType()
        {
            return "cat";
        }
    }

    class Dog : Animal
    {
        public Dog(string name, string breed)
            : base(name, breed)
        { }

        protected override string GetAnimalType()
        {
            return "dog";
        }
    }
}
