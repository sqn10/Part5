namespace Part5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
        }
        public static void Task1()
        {
            string magicWord;

            Console.WriteLine("What is the magic word?");
            magicWord = Console.ReadLine();
            if (magicWord.ToLower() == "please");
                Console.WriteLine("Thank you!");
        }
        public static void Task2()
        {
            int age;

            Console.WriteLine("How old are you?");

            if (Int32.TryParse(Console.ReadLine(), out age))
            {
                if (age < 16)
                    Console.WriteLine("You can't drive.");
                if (age < 18)
                    Console.WriteLine("You can't vote.");
                if (age < 25)
                    Console.WriteLine("You can't rent a car.");
                else
                    Console.WriteLine("You can do anything that's legal.");
            }
            else
            {
                Console.WriteLine("Please enter a valid age.");
            }
        }
        public static void Task3()
        {
            double waterTemp;

            Console.WriteLine("Enter the freezing temp. of water in degrees celsius.");

            if (Double.TryParse(Console.ReadLine(), out waterTemp))
            {
                if (waterTemp == 0)
                    Console.WriteLine("Yes, that is CORRECT!!!! YOU ARE RIGHT!!!!! WOO HOO!!!!! YAY!!!!!");
                else
                    Console.WriteLine("Please enter the right answer.");
            }
        }
    }
}
