

using System.Runtime.CompilerServices;
using System.Xml.Linq;
//create IFeedable and IMovable interfaces
interface IFeedable
{
    void Eat();
    
}

interface IMovable
{
    void Move();
    
}
//create animal class
public class Animal
    //create constructor
{
    public Animal(string name,string type, int age, float weight, string gender, string lifeExpectancy, string food, float height)
    {
        Name = name;
        Type = type;
        Age = age;
        Weight = weight;
        Gender = gender;
        LifeExpectancy = lifeExpectancy;
        Food = food;
        Height = height;
    }
    //createe your properties
    public string? Name { get; set; }
    public string? Type {  get; set; }
    public int Age { get; set; }
    public float Weight { get; set; }
    public string? Gender { get; set; }
    public float Height { get; set; }
    public string? LifeExpectancy { get; set; }
    public string? Food { get; set; }

//create your methods
    public virtual void Eat() 
    {
        Console.WriteLine($"{Name} is eating .");
    }

    public virtual void Sleep(string Name)
    {
        Console.WriteLine($"{Name} is sleeping.");
    }

    public virtual void Speak(string Name)
    {
        Console.WriteLine($"{Name} makes a generic animal sound.");
    }

    public virtual void Move(string Name)
    {
        Console.WriteLine($"{Name} moves in a typical animal way.");
    }





}
// Concrete class for Lion
public class Lion :Animal, IFeedable, IMovable
{
    public Lion(string Name, string Type, int Age, float Weight, string Gender, float Height, string LifeExpectancy, string Food)
       : base(Name, Type, Age, Weight, Gender, LifeExpectancy, Food, Height) { }
    public override void Eat()
    {
        Console.WriteLine($"{Name} the lion is eating meat.");
    }

    public  void Sleep()
    {
        Console.WriteLine($"{Name}the lion is sleeping in the shade.");
    }
    public void Feed()
    {
        Console.WriteLine($"Feeding meat to {Name} the lion.");
    }

    public  void Move()
    {
        Console.WriteLine($"{Name} the lion is walking majestically.");
    }
}

// Concrete class for Elephant
public class Elephant : Animal,IFeedable, IMovable
    {

    public Elephant(string Name, string Type, int Age, float Weight, string Gender, float Height, string LifeExpectancy, string Food)
       :base(Name,Type,Age, Weight, Gender, LifeExpectancy, Food,Height) { }
    public void Eat()
    {
        Console.WriteLine($"{Name} the Elephant is eating leaves.");
    }

    public void Sleep()
    {
        Console.WriteLine($"{Name} the Elephant is sleeping in the shade.");
    }
    public void Feed()
    {
        Console.WriteLine($"Feeding leaves to the {Name} Elephant.");
    }

    public void Move()
    {
        Console.WriteLine($"{Name} the Elephants is walking slowly.");
    }
}

// Concrete class for Rhino
public class Rhino : Animal,IFeedable, IMovable
    {
    public Rhino(string Name, string Type, int Age, float Weight, string Gender, float Height, string LifeExpectancy, string Food)
       : base(Name, Type, Age, Weight, Gender, LifeExpectancy, Food, Height) { }
    public void Eat()
    {
        Console.WriteLine($"{Name} the Rhino is eating grass.");
    }

    public void Sleep()
    {
        Console.WriteLine($"{Name}Rhino is sleeping in the shade.");
    }
    public void Feed()
    {
        Console.WriteLine($"Feeding grass to the {Name} Rhino.");
    }

    public void Move()
    {
        Console.WriteLine($"{Name}Rhino is running.");
    }
}

// Concrete class for Leopard
public class Leopard : Animal, IFeedable, IMovable
{
    public Leopard(string Name, string Type, int Age, float Weight, string Gender, float Height, string LifeExpectancy, string Food)
       : base(Name, Type, Age, Weight, Gender, LifeExpectancy, Food, Height) { }
    public void Eat()
    {
        Console.WriteLine($"{Name} Leopard is eating meat.");
    }

    public void Sleep()
    {
        Console.WriteLine($"{Name}Leopard is sleeping.");
    }
    public void Feed()
    {
        Console.WriteLine($"feeding meat to the {Name} leopard.");
    }

    public void Move()
    {
        Console.WriteLine($"{Name} the Lion is running.");
    }
    public class Buffalo : Animal, IFeedable, IMovable
    {
        public Buffalo(string Name, string Type, int Age, float Weight, string Gender, float Height, string LifeExpectancy, string Food)
       : base(Name, Type, Age, Weight, Gender, LifeExpectancy, Food, Height) { }
        public void Eat()
        {
            Console.WriteLine($"{Name} the Buffalo is eating grass.");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} the Buffalo is sleeping in the shade.");
        }
        public void Feed()
        {
            Console.WriteLine($"feeding meat to the{Name} Buffalo.");
        }

        public void Move()
        {
            Console.WriteLine($"{Name}the Buffalo is running.");
        }
        class Program()
        {
            public static void Main(string[] args)
            {
                List<Animal> zooAnimals = new List<Animal>();
                Lion lion1 = new("simba","lion", 25, 50, "M", 34, "10-14years", "Carnivore");
                Leopard leopard2 = new("shadow", "leopard", 60, 60, "M", 50, "10-14years", "Carnivore");
                Buffalo buffalo3 = new("buck", "buffalo", 15, 80, "M", 50, "10-14years", "Herbivore");
                Elephant elephant4 = new("dumbo", "elephant", 40, 36, "M", 50, "10-20years", "Herbivore");
                Rhino rhino5 = new("tank", "rhino", 40, 50, "M", 56, "10-14years", "Herbivore");

                zooAnimals.Add(lion1);
                zooAnimals.Add(leopard2);
                zooAnimals.Add(buffalo3);
                zooAnimals.Add(elephant4);
                zooAnimals.Add(rhino5);
                //output

                bool exit = false;
                while (!exit)
                {
                    Console.WriteLine("The Big Five Zoo");
                    Console.WriteLine("1. Display all animals");
                    Console.WriteLine("2. Add an animal");
                    Console.WriteLine("3. Make animals move");
                    Console.WriteLine("4. Feed animals");
                    Console.WriteLine("5. Exit");
                    Console.Write("Enter your choice: ");

                    string input = Console.ReadLine();
                    switch (input)
                    {
                        case "1":
                            AddAnimal(zooAnimals);
                            break;
                        case "2":
                            Eat(zooAnimals);
                            break;
                        case "3":
                            MoveAnimals(zooAnimals);
                            break;
                        case "4":
                            DisplayAnimals(zooAnimals);
                            break;
                        case "5":
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                Main(args);
            }


            private static void Eat(List<Animal> zooAnimals)
            {
                Console.WriteLine("Which animal do you want to feed:");
                string user2 = Console.ReadLine();
                for (int i = 0; i < zooAnimals.Count; i++)
                {
                    if (zooAnimals[i].Type == user2)
                    {
                        zooAnimals[i].Eat();
                    }
                }
            }

        }

            private static void DisplayAnimals(List<Animal> zooAnimals)
            {
                Console.WriteLine("The Big Five");
                Console.WriteLine("1.Lion");
                Console.WriteLine("2.Leopard");
                Console.WriteLine("3.Elephant");
                Console.WriteLine("4.Buffalo");
                Console.WriteLine("5.Rhino");
            }

            private static void MoveAnimals(List<Animal> zooAnimals)
            {
                Console.WriteLine("Which animal would you like to remove: ");
                string? user = Console.ReadLine();

                for(int i = 0; i < zooAnimals.Count; i++)
                {
                    if (zooAnimals[i].Type == user)
                    {
                        zooAnimals[i].Move(user);
                    }
                }
            }

            static void AddAnimal(List<Animal> animals)

            {

                



                Console.Write("Enter animal type(Lion/Leopard/Rhino,Buffalo,Elephant): ");
                string type = Console.ReadLine();
                Console.Write("Enter animal name: ");
                string name = Console.ReadLine();
                Console.Write("Enter animal age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter animal weight(kg):");
                float weight = Convert.ToInt32(Console.ReadLine());
                Console.Write("Animal Gender(M/F):");
                string gender = Console.ReadLine();
                Console.Write("Enter height of animal:");
                float height = Convert.ToInt32(Console.ReadLine());
                Console.Write("Life Expectancy of animal:");
                string life = Console.ReadLine();
                Console.Write("Type of feed(Carnivore,Herbivore,Omnivore): ");
                string food = Console.ReadLine();

         
                if (type == "lion")
                {
                    Lion lion = new Lion(name,type, age,weight, gender, height, life, food);
                    animals.Add(lion);
                }
                else if (type == "rhino")
                {
                    Rhino rhino = new Rhino(name, type, age, weight, gender, height, life, food);
                    animals.Add(rhino);
                }
                else if (type == "leopard")
                {
                    Leopard leopard = new Leopard(name, type, age, weight, gender, height, life, food);
                    animals.Add(leopard);
                }else if(type == "elephant")
                {
                    Elephant elephant = new Elephant(name, type, age, weight, gender, height, life, food);
                    animals.Add(elephant);
                }
                else if (type == "buffalo")
                {
                    Buffalo buffalo = new Buffalo(name, type, age, weight, gender, height, life, food);
                    animals.Add(buffalo);
                }
                else
                {
                    Console.WriteLine("Invalid");
                }






            }
        }
    }


 