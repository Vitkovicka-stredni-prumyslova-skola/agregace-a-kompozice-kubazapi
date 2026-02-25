namespace AgregaceAKompozice
{
public class Trida
{
    public string Nazev { get; }
    public List<Student> Studenti { get; } = new();

    // KOMPOZICE: třídní kniha vzniká spolu s třídou
    public TridniKniha TridniKniha { get; }

    public Trida(string nazev)
    {
        if(string.IsNullOrWhiteSpace(nazev))
                throw new ArgumentException("Název třídy nesmí být prázdné.", nameof(nazev));

        Nazev = nazev.Trim();

        TridniKniha = new TridniKniha();
    }

    // AGREGACE: student existuje i bez třídy
    public void PridejStudenta(Student s)
    {
        if(s == null) throw new ArgumentNullException(nameof(s));

        if(Studenti.Contains(s))
            throw new InvalidOperationException("Student již je ve třídě zapsán.");

        Studenti.Add(s);
    }

    public void OdeberStudenta(Student s)
    {
        if(s == null) throw new ArgumentNullException(nameof(s));

        if(!Studenti.Contains(s))
            throw new InvalidOperationException("Student není ve třídě zapsán.");

        Studenti.Remove(s);
    }

    public void VypisStudenty()
    {
        Console.WriteLine($"Třída: {Nazev}");
        Console.WriteLine("Seznam studentů:");

        if(Studenti.Count == 0)
        {
            Console.WriteLine("Žádní studenti.");
            return;
        }

        int index = 1;
        foreach(var student in Studenti)
        {
            Console.WriteLine($"{index++}. {student}");
        }
    }
}
}