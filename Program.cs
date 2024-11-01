using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            List<Artifact> artifacts = new List<Artifact> { };

            Console.WriteLine("Enter number of artifacts to add: ");
            int maxArt = int.Parse(Console.ReadLine());
            for (int i = 0; i < maxArt; i++)
            {
                Console.WriteLine("Artifact:");
                inventory.AddItem(new Artifact(Console.ReadLine(), 1, float.Parse(Console.ReadLine())));
            }
            
            Console.WriteLine("Enter number of consumables to add: ");
            int maxCon = int.Parse(Console.ReadLine());
            for (int i = 0; i < maxCon; i++)
            {
                Console.WriteLine("Consumable:");
                inventory.AddItem(new Consumable(Console.ReadLine(), 1, float.Parse(Console.ReadLine())));
            }

            inventory.DisplayItems();
            //Console.WriteLine("Gadget:");
            //inventory.AddItem(new Gadget(Console.ReadLine(), 1, float.Parse(Console.ReadLine())));
            //Console.WriteLine("Document: ");
            //inventory.AddItem(new Document(Console.ReadLine(), 1, float.Parse(Console.ReadLine())));



























            //inventory.AddItem(artifact, Inventory.Category.Artifact);
            //inventory.AddItem(consumable, Inventory.Category.Consumable);
            //inventory.AddItem(gadget, Inventory.Category.Gadget);
            //inventory.AddItem(document, Inventory.Category.Document);
            //inventory.DisplayItems(Inventory.Category.Artifact);
            //inventory.RemoveItem(Inventory.Category.Consumable, 020);
            //inventory.DisplayItems(Inventory.Category.Consumable);
            //inventory.CalculateTotal(Inventory.Category.Artifact, 78);

            Console.ReadLine();
        }
    }

}
