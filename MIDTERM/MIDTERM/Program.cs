using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MIDTERM
{
    [Flags] enum GroceryStorage
    {
        Shelves = 0,
        Darkness = 1,
        Light = 4,
        Freezer = 8,
        Refrigerator = 16
    }
    interface ISaleable
    {
        void OfferSale(decimal markup);
        void Restock(int quantity);
        void Sell(int quantity);
    }
    abstract class BaseItem : ISaleable
    {
        private static long ITEM_ID = 1000000;
        public string ItemId { get; }
        public string Name { get; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }
        public BaseItem(string name, int quantity, decimal price)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            string id = Convert.ToString(ITEM_ID);
            ItemId = id;
            ITEM_ID++;
        }
        public abstract void OfferSale(decimal markup);
        public void Restock(int quantity)
        {
            Quantity += quantity;
        }
        public void Sell(int quantity)
        {
            Quantity -= quantity;
        }
    }
    class Item : BaseItem
    {
        public GroceryStorage Storage;
        public decimal Markup;
        public decimal Price { get { decimal price = Price * (1 + Markup); return price; } }
        public Item(string name, int quantity, decimal price, GroceryStorage storage, decimal markup = 0.015m) : base(name, quantity, price)
        {
            Storage = storage;
            Markup = markup;
        }
        public override void OfferSale(decimal markup) 
        {
            Markup -= markup;
        }
        public override string ToString()
        {
            return $"{ItemId}  -----  {Name} - {Quantity} - {Price:c2} - {Storage}";
        }

    }
    static class GroceryStore
    {
        private static List<Item> items;
        static GroceryStore()
        {
          items =  CreateItems();
        }
        private static List<Item> CreateItems()
        {
            return new List<Item> {
                    new Item("Ochra", 50, 1.29m, GroceryStorage.Refrigerator),
                    new Item("Bell Pepper", 50, 1.97m, GroceryStorage.Refrigerator| GroceryStorage.Shelves),
                    new Item("Cauliflower", 50, 1.29m, GroceryStorage.Shelves),
                    new Item("Carrot", 50, 0.59m, GroceryStorage.Shelves | GroceryStorage.Darkness),
                    new Item("Khale", 50, 1.67m, GroceryStorage.Darkness),
                    new Item("Celery", 50, 2.97m, GroceryStorage.Light),
                    new Item("Beets", 50, 0.97m, GroceryStorage.Shelves),
                    new Item("Nectarines", 50, 1.19m, GroceryStorage.Refrigerator| GroceryStorage.Shelves),
                    new Item("Banana", 125, 0.69m, GroceryStorage.Refrigerator| GroceryStorage.Shelves),
                    new Item("Chicken", 50, 0.89m, GroceryStorage.Shelves | GroceryStorage.Refrigerator),
                    new Item("Tuna", 50, 3.27m, GroceryStorage.Shelves),
                    new Item("Salmon", 50, 1.27m, GroceryStorage.Shelves),
                    new Item("Ice Cream", 50, 5.99m, GroceryStorage.Freezer | GroceryStorage.Light),
                    new Item("Lean Cuisine", 150, 3.99m, GroceryStorage.Freezer, 0.05m),

            };

        }
        private static Item GetItem(string name)
        {
            Item x = null;
            foreach (Item a in items)
            {
                if (name == a.Name)
                {
                    x = a;
                }
                x = a;
            }
            return x;
        }
        public static void Purchase(string name, int quantity)
        {
            GetItem(name);
            GetItem(name).Sell(quantity);
        }
        public static void OfferSale(string name, int quantity)
        {
            GetItem(name);
            GetItem(name).OfferSale(quantity);
        }
        public static void OfferSales(GroceryStorage storage, decimal length)
        {
            foreach (Item a in items)
            {
                if (a.Storage == storage)
                {
                    a.OfferSale(length);
                }
            }
        }
        public static void Show()
        {
            foreach(Item a in items)
            {
                Console.WriteLine($"{a.ItemId}  -----  {a.Name} - {a.Quantity} - {a.Price:c2} - {a.Storage}");
            }
          
        }
        public static void Save(string filename)
        {
            string JavaSerialised = JavaScriptSerializer.Serialize(filename);
            File.WriteAllText(fileName, JavaSerialised);
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //creating an item
            Item grocery = new Item("apple", 50, 1.29m, GroceryStorage.Refrigerator |
            GroceryStorage.Shelves);
            Console.WriteLine(grocery);
            //display all the items in the store
            Console.WriteLine("\nOriginal inventory of items");
            GroceryStore.Show();
            //purchasing a few items
            string item = "Banana";
            int quantity = 10;
            Console.WriteLine($"Purchasing {quantity} inits of {item}");
            GroceryStore.Purchase(item, quantity);
            item = "Tuna";
            quantity = 20;
            Console.WriteLine($"Purchasing {quantity} inits of {item}");
            GroceryStore.Purchase(item, quantity);
            Console.WriteLine("\nAfter purchasing some items");
            GroceryStore.Show();
            decimal markup = 0.15m;
            GroceryStorage storage = GroceryStorage.Freezer;
            //offer sale on freezer items
            Console.WriteLine($"Offering sale of {markup}% on all {storage} items");
            GroceryStore.OfferSales(storage, markup);
            item = "Banana";
            //offer sale on item banana
            Console.WriteLine($"Offering sale of {markup}% on {item}");
            GroceryStore.OfferSale(item, (int)markup);
            Console.WriteLine("\nAfter sale implemented");
            GroceryStore.Show();
            string file = "items.json";
            //saving inventory to json file
            Console.WriteLine($"\nSaving inventory to {file}");
            GroceryStore.Save(file);
        }
    }
}

