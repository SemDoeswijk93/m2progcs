namespace RijSchool;

class RijSchool
{
}

class Auto
{
    internal bool automaat;
    internal string merk;
    internal string Kenteken;
    internal int KilometerStand;

}

class Dag
{
    internal DateTime datum;
    internal LesUur[] lesuren;
}

class LesUur
{
    internal int tijd;
    internal Student student;
    internal RijLeraar rijLeraar;
    internal Auto auto;
}

class LesPakket
{
    internal int urenGekocht;
    internal int urenVerbruikt;
    internal int examenPogingen;
    internal bool Automaat;


}

class Program
{
}
class RijLeraar
{
    internal string naam;
    internal int leeftijd;
    internal bool zzp;
}
class RijTest
{
    internal bool gehaald;
    internal DateTime afnameDatum;
}
class Student
{
    internal string naam;
    internal int leeftijd;
    internal LesPakket lesPakket;
    internal RijLeraar rijLeraar;
    internal TheorieTest theorieTest;
    internal RijTest rijTest;
}

class TheorieTest
{
    internal int aantalFouten;
    internal bool gehaald;
    internal DateTime afnameDatum;

}

// Hier is de run command en de informatie van de rijschool.
class Informatie
{

    static void Main(string[] args)
    {
        Auto auto1 = new Auto()
        {
            merk = "BMW",
            Kenteken = "163-DOE-93",
            KilometerStand = 25000,
            automaat = true
        };

        Auto auto2 = new Auto()
        {
            merk = "Volvo",
            Kenteken = "123-ABC-45",
            KilometerStand = 15000,
            automaat = false
        };

        RijLeraar Rijleraar = new RijLeraar()
        {
            naam = "Joost Marijnissen",
            leeftijd = 32,
            zzp = false
        };

        LesUur lesUur1 = new LesUur()
        {
            auto = auto1,
            rijLeraar = Rijleraar,
            tijd = 1320
        };
        LesUur lesUur2 = new LesUur()
        {
            auto = auto2,
            rijLeraar = Rijleraar,
            tijd = 1515
        };

        LesPakket lesPakket = new LesPakket()
        {
            urenGekocht = 40,
            urenVerbruikt = 13,
            examenPogingen = 1,
            Automaat = true
        };
        TheorieTest theorieTest = new TheorieTest()
        {
            aantalFouten = 14,
            gehaald = false,
            afnameDatum = new DateTime(2025, 12, 26)
        };

        RijTest rijTest = new RijTest()
        {
            gehaald = false,
            afnameDatum = new DateTime(2026, 1, 31)
        };

        Student student = new Student()
        {
            naam = "Sem Doeswijk",
            leeftijd = 18,
            lesPakket = lesPakket,
            rijLeraar = Rijleraar,
            theorieTest = theorieTest,
            rijTest = rijTest
        };

        Dag dag = new Dag()
        {
            datum = new DateTime(2026, 2, 27),
            lesuren = new LesUur[] { lesUur1, lesUur2 }
        };
    }
}