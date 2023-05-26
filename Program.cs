using System;

class Zadanie4
{
    static void Main(string[] args)
    {
        TekstLiteracki tekstLiteracki = new TekstLiteracki();
        tekstLiteracki.GetOpis();

        Epika epika = new Epika();
        epika.GetOpis();

        Opowiadanie opowiadanie = new Opowiadanie();
        opowiadanie.GetOpis();

        Liryka liryka = new Liryka();
        liryka.GetOpis();

        Fraszka fraszka = new Fraszka();
        fraszka.GetOpis();

        Dramat dramat = new Dramat();
        dramat.GetOpis();

        Komedia komedia = new Komedia();
        komedia.GetOpis();
    }
}

public class TekstLiteracki
{
    public virtual void GetOpis()
    {
        Console.WriteLine("Jest to tekst literacki.");
    }
}

public class Epika : TekstLiteracki
{
    public override void GetOpis()
    {
        Console.WriteLine("Ten utwór literacki jest epiką.");
    }
}

public class Liryka : TekstLiteracki
{
    public override void GetOpis()
    {
        Console.WriteLine("Ten utwór literacki jest liryką.");
    }
}

public class Dramat : TekstLiteracki
{
    public override void GetOpis()
    {
        Console.WriteLine("Ten utwór literacki jest dramatem.");
    }
}

public class Opowiadanie : Epika
{
    public override void GetOpis()
    {
        Console.WriteLine("Ten utwór epicki jest opowiadaniem.");
    }
}

public class Fraszka : Liryka
{
    public override void GetOpis()
    {
        Console.WriteLine("Ten utwór liryczny jest fraszką. ");
    }
}

public class Komedia : Dramat
{
    public override void GetOpis()
    {
        Console.WriteLine("Ten utwór dramatyczny jest komedią.");
    }
}
