using System;

public class Pays {
    public string Name { get; set; }

    public Pays(string name) {
        this.Name = name;
    }
}

public class Program
{
    static void Main(string[] args) {
        Console.WriteLine("Hello World!");
        Pays p1 = new Pays("France");
        Pays p2 = new Pays("USA");
        p2.Name = "Espagne";
        Console.WriteLine(p1.Name + " > " + p2.Name);
    }
}