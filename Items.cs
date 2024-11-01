using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace inventory
//{
public abstract class Item
{
    public string Name { get; private set; }
    public int ID { get; private set; }
    public string Price { get; private set; }
    = string.Empty;
    public Item(string name, int id, float price)
    {
        Name = name;
        ID = id;
        Price = price.ToString();
    }
    public abstract void DisplayInfo();
   


}

public class Artifact : Item
{
    public Artifact(string name, int id, float price) : base(name, id, price) { } //constructors
    public override void DisplayInfo()
    {
        Console.WriteLine($"Artifact: {Name}, ID {ID}, Price: {Price}"); 
    }
}

public class Consumable : Item
{
    public Consumable(string name, int id, float price) : base(name, id, price) { }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Consumable: {Name}, ID {ID}, Price: {Price}");
    }
}
public class Gadget : Item
{
    public Gadget(string name, int id, float price) : base(name, id, price) { }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Gadget: {Name}, ID {ID}, Price: {Price}");
    }
}

public class Document : Item
{
    public Document(string name, int id, float price) : base(name, id, price) { }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Document: {Name}, ID {ID}, \n {Price}");
    }
}


//}