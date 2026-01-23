namespace Memsave;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string newString = "Please Enter";

        while (true)
        {
            bool bestaatfile = File.Exists("welkomstate.txt");
            if (bestaatfile == true)
            {
                string[] lines = File.ReadAllText("welkomstate.txt");
                foreach (string line in lines)
                {
                    File.WriteAllText("welkomstate.txt", lines);
                }
            }
            Console.WriteLine("Hello, World!");
            string[] welkom = File.ReadAllLines("welkomstate.txt");
            foreach (string line in welkom)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine(newString);
            Console.ReadLine();
        }
    }
}
