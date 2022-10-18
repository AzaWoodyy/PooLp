using System;

public class Pays {
    public string Name { get; set; }
    public int Id { get; set; }

    public Pays(int id, string name) {
        this.Name = name;
        this.Id = id;
    }
}

public class Program
{
    static void Main(string[] args) {
        Console.WriteLine("Hello World!");
        Pays p1 = new Pays(1, "France");
        Pays p2 = new Pays(2, "USA");
        p2.Name = "Espagne";
        Console.WriteLine(p1.Name + " > " + p2.Name);
    }
}