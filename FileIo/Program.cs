using System.Text;

namespace FileIo;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Environment.CurrentDirectory);
        string[] lines = File.ReadAllLines("quiz.txt");
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

        string[] lines2 = File.ReadAllLines("nos.txt");
        foreach (string line in lines2)
        {
            Console.WriteLine(line);
        }
    }
}
