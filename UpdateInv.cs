// See https://aka.ms/new-console-template for more information
//using inventory;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using static Inventory;
using static Item;

public class Inventory
{
    Item Item { get; set; }
    public const int MaxCatItems = 50;
    private Dictionary<int, List<Item>> items; //declaring and creating dictionary
    public List<Item> subitems = new List<Item>();
    public Inventory() {}


    public bool AddItem(Item newItem)
    {
        if (subitems.Count >= MaxCatItems)
        {
            Console.WriteLine($"category is full.");
            return false;
        }

        subitems.Add(newItem);
       
        return true;
    }




    // Type itemType = newItem.GetType();
    //items[].Add(newItem);

    public bool RemoveItem(Item item)
    {
        //Type itemType = typeof(T);
        //var itemList = items;
        var itemToRemove = subitems.Find(List => item.ID == 0 );
       
        if (itemToRemove != null)
        {
            subitems.Remove(itemToRemove);
            Console.WriteLine($"Item {itemToRemove.Name} removed from {subitems} category.");
            return true;
        }

        Console.WriteLine($"ID {subitems[index: item.ID]} not found in {subitems}.");
        return false;
    }


    public void DisplayItems()
    {
        //Type itemType = typeof(T);
        //Console.WriteLine($"{Item.Name}s:");
        foreach (var item in subitems)
        {
            item.DisplayInfo();
        }
    }

    

}

//public class Invoice {

//    public List<Item> Items { get; set; } = new List<Item>();
//    public float TotalPrice { get; set; }

//    public void AddToInvoice(Item item)
//    {
//        Items.Add(item);
//        TotalPrice += float.Parse(item.Price);
//    }

//    public void DisplayInvoice(Item item)
//    {
//        Console.WriteLine("Total price: ");
//        foreach (var item in Items)
//        {
//            Items.DisplayInfo();
//        }
//        Console.WriteLine($"\n{TotalPrice}");
//    }
//    public void CalculateTotal<T>() where T : Item
//        {
//            Type itemType = typeof(T);

//            for (int i = 0; i < MaxCatItems; i++)
//            {
//                string price = (items[(int)category, i].Price).ToString();
//                TotalPrice = float.Parse(price);

//                TotalPrice++;
//            }

//        }


//}




































//public enum Category //new data type for categories, lets us use Category.Arifact
//{
//    Artifact,
//    Consumable,
//    Gadget,
//    Document
//}

//public bool AddItem(Item newItem, Category category)
//{
//    for (int i = 0; i < MaxCatItems; i++)
//    {
//        if (items[(int)category, i] == null)
//        {
//            items[(int)category, i] = newItem;
//            return true;
//        }
//    }
//    Console.WriteLine($"{category} category is full.");
//    return false;
//}


//public bool RemoveItem(Category category, int id)
//{
//    for (int i = 0; i < MaxCatItems; i++)
//    {
//        if (items[(int)category, i] != null && items[(int)category, i].ID == id)
//        {
//            Console.WriteLine($"Item {items[(int)category, i].Name} removed from {category} category.");
//            items[(int)category, i] = null;
//            return true;

//        }
//        Console.WriteLine($"ID {id} not found in {category}.");

//    }
//    return false;
//}


//public void DisplayItems(Category category)
//{
//    Console.WriteLine($"{category}s:");
//    for (int i = 0; i < MaxCatItems; i++)
//    {
//        if (items[(int)category, i] == null)
//        {
//            return;
//        }
//        items[(int)category, i].DisplayInfo();

//    }
//}
