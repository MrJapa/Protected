class Klasse1
{
    protected int A;
    protected int B;
}
class Klasse2 : Klasse1
{
    static void Main()
    {
        //Her kan klasse 2 godt tilgå de protectede ints fra Klasse 1, da klasse 2 er derived fra direkte fra klasse 1.
        var c = new Klasse2();
        c.A = 1;
        c.B = 2;
        Console.WriteLine($"Int A: {c.A} Int B: {c.B}");
    }
}

/* Her kan klasse 3 ikke tilgå de protectede ints fra Klasse 1, da den ikke er derived.
class Klasse3
{
    static void Test()
    {
        var d = new Klasse3();
        d.A = 1;
        d.B = 2;
        Console.WriteLine($"Int A: {d.A} Int B: {d.B}");
    }
}
*/