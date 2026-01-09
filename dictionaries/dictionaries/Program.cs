namespace dictionaries;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> Personeelopnummer = new Dictionary<int, string>();
        Personeelopnummer.Add(9327, "Jan");
        Personeelopnummer.Add(456, "Jesse");

        string jan = Personeelopnummer[9327];
        Console.WriteLine(jan);
    }
}
