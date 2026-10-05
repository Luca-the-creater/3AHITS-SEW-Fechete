// ------------------------------
// Uebung_2_1
// ------------------------------

namespace Uebung_2_1;

class Program
{
    static void Main(string[] args)
    {

        Schulklasse klasse1 = new Schulklasse();
        Schulklasse klasse2 = new Schulklasse(30, "Müller");

        klasse1.Dazu();
        klasse1.Raus(3);

        klasse1.KlassenwechselNach(klasse2);

        Console.WriteLine(klasse1.ToString());
        Console.WriteLine(klasse2.ToString());
    }
}
class Schulklasse
{
    public int AnzahlSchueler;
    public string Klassenvorstand;

public Schulklasse(int schueler, string lehrer)
{
    AnzahlSchueler = schueler;
    Klassenvorstand = lehrer;
}

public Schulklasse() : this(22, "Strasser")
    {
    }

public void Dazu()
{
    AnzahlSchueler++;
}

public void Raus(int anzahl)
    {
        AnzahlSchueler -= anzahl;
    }

public void KlassenwechselNach(Schulklasse andereKlasse)
    {
        AnzahlSchueler--;
        andereKlasse.AnzahlSchueler++;
    }

public override string ToString()
    {
        return $"Klassenvorstand: {Klassenvorstand}, Schüler: {AnzahlSchueler}";
    }

}





