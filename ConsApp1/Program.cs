using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Animal dog = new Animal();
        Animal cat = new Animal();
        Animal fox = new Animal();
        cat.age = 13;
        cat.height = 20.3f;
        cat.weight = 13.2f;
        cat.species = "Angor";
        byte age = (byte)(cat.age + 1);
        string catInf = string.Format("species: {0}\nage: {1}\nheight: {2}\nweight: {3}\n",cat.species, cat.age, cat.height, cat.weight);
        Console.WriteLine(catInf);
        Console.ReadKey();
    }
}

class Animal
{
    public byte age;
    public float height, weight;
    public string species;
}