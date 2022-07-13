namespace HelloWorld
{
    public class AnimalOutput
    {
        static public void StartQuestions()
        {
            Console.WriteLine("What Is Your Name?");
            string name = Console.ReadLine();


            Console.WriteLine("Select a Greeting");
            Console.WriteLine("1 - Southern 2 - Spanish 3 - Zombie");
            string greeting = Console.ReadLine();
            while (greeting != "1" || greeting != "2" || greeting != "3")
            {

                if (greeting == "1")
                {
                    Console.WriteLine($"Howdy, {name}\n");
                    break;
                }
                else if (greeting == "2")
                {
                    Console.WriteLine($"Hola, {name}\n");
                    break;
                }
                else if (greeting == "3")
                {
                    Console.WriteLine("Braaaaaiiinnnssss!\n");
                    break;
                }
                else if (string.IsNullOrEmpty(greeting))
                {
                    Console.WriteLine("Please Select A Correct Option");
                    greeting = Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Please Select A Correct Option");
                    greeting = Console.ReadLine();
                }
            }

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan", "Pug" };
            Random rnd = new Random();
            string randomAnimal = animals[rnd.Next(animals.Length - 1)];

            Console.WriteLine("What Is Your Favorite Color?");
            string favColor = Console.ReadLine();

            Console.WriteLine($"Would You Like A {favColor} {randomAnimal}");

            Console.ReadKey();
        }

    }
}
