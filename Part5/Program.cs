namespace Part5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = 20;
            int cats = 30;
            int dogs = 15;
            Console.WriteLine("People: " + people + " Dogs: " + dogs + " Cats: " + cats);
            if (people > cats)
            {
                Console.WriteLine("Too many cats! The world is doomed!");
            }
            if (people > cats)
            {
                Console.WriteLine("Not many cats! The world is saved!");
            }
            if (people < dogs)
            {
                Console.WriteLine("The world is drooled on!");
            }
            if (people > dogs)
            {
                Console.WriteLine("The world is dry!");
            }
            Console.WriteLine("Press ENTER to continue. ");
            Console.ReadLine();
            Console.Clear();
            dogs += 5; // Add 5 to dogs. What does dogs equal now?
            Console.WriteLine("People: " + people + " Dogs: " + dogs + " Cats: " + cats);
            if (people >= dogs)
            {
                Console.WriteLine("People are greater than or equal to dogs.");
            }
            if (people <= dogs)
            {
                Console.WriteLine("People are less than or equal to dogs.");
            }
            if (people == dogs)
            {
                Console.WriteLine("People are dogs.");
            }
            // 1. runs -- or doesn't run -- certain blocks of code based on what a previous condition is.
            // 2. so you can put what you want to happen when the condition is true and the code runs. (more than one line of code).

            string dinosaur;
            Console.WriteLine("What famous dinosaur has three large horns?");
            dinosaur = Console.ReadLine();
            if (dinosaur.ToLower() == "triceratops")
                Console.WriteLine("You are correct!");
        }
    }
}
