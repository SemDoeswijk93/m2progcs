namespace functions;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
        // het variable die we hebben gemaakt is "program"
        // "Program" de return type is "new"

    }

//hier komt je function
internal void Run()
{
 Console.WriteLine("Dit is nu de start van mijn programma.");
}

internal void Vraag1()
{
 Console.WriteLine("How long do you think you'd survive a zombie apocalypse?");
 string antwoord = Console.ReadLine();

 Console.WriteLine(antwoord); 

}
}