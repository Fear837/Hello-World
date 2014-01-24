using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Hallo Welt Programm!";

            Console.WriteLine("Hallo Welt!");
            Console.ReadLine();

            start();
        }

        static private void start()
        {
            Console.WriteLine("");

            Screen screen = new Screen(getScene());
            screen.show(true);
        }

        static Scene getScene()
        {
            String text = "Das ist ein standard Text, der nur für Testzwecke geeignet ist!";
            text += "Dieser Text sollte außerdem ziemlich lang sein, damit die Zeilenabschnitte getestet werden!";

            List<Option> options = new List<Option>();

            options.Add( new Option("Option A", null) );
            options.Add( new Option("Option B", null) );
            options.Add( new Option("Option C", null) );

            Inventory inventory = new Inventory(10);
            inventory.addItem(new Item("Item1", "Typ1", "Extra1"));
            inventory.addItem(new Item("Item2", "Typ2", "Extra2"));

            Scene scene = new Scene("SceneName", 1, text, options, inventory);

            return scene;
        }
    }
}
