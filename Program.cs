namespace je_ne_sais_pas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Hello guys.");
            Console.WriteLine("I'm very confused.");
            Console.WriteLine();
            Console.Write("Will you help me? ");
            string input = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Great!");
            Console.WriteLine("To be honest, I don't know what you said.");
            Console.WriteLine("But you said " + input);
            Console.WriteLine();
            Console.WriteLine("Ok so first question.");
            Console.Write("How old are you? ");
            while (!Int32.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input.");
                Console.Write("How old are you?");
            }
            if (age < 13)
            {
                Console.WriteLine();
                Console.WriteLine("You are way too young to help me.");
                Console.WriteLine("Don't take this the wrong way.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Okay great! You're old enough.");
                Console.WriteLine("Okay so firstly, I really need help with coding.");
                Console.Write("Can you do that for me? ");
                string input2 = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Great!");
                Console.WriteLine("So, how do I write a line for a Console Application?");
                Console.Write("Type here: ");
                string coding = Console.ReadLine();
                while (coding != "Console.WriteLine")
                {
                    Console.WriteLine();
                    Console.WriteLine("Wrong. Try again!");
                    Console.WriteLine("So how do I write a line for a Console Application?");
                    Console.WriteLine("Type here: ");
                }
                Console.WriteLine();
                Console.WriteLine("Good job! You're learning fast!");
                Console.WriteLine("That's really all I needed. See you later, friend");
                Console.WriteLine("Press ENTER to leave");
                Console.ReadLine();
            }

        }
    }
}
