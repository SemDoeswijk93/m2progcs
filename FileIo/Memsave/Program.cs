namespace Memsave;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string newString = "Please Enter";
        string SaveFile = "Save.txt";

        while (true)
        {
            Console.WriteLine("Hello, World!");
            string[] welkom = File.ReadAllLines("welkomstate.txt");
            foreach (string line in welkom)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine(newString);
            Console.ReadLine();
            bool bestaatfile = File.Exists(SaveFile);
            if (bestaatfile == true)
            {
                string[] lines = File.ReadAllText(SaveFile);
                foreach (string line in lines)
                {
                    File.WriteAllText(SaveFile, lines);
                }
            }
        }
    }
}
