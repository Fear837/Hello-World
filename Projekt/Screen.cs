using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Screen
    {
        Scene scene;

        public Screen(Scene scene) // Todo: Add Inventory
        {
            this.scene = scene;
        }

        public void show(Boolean ClearOld)
        {
            if (ClearOld) { Console.Clear(); }

            Console.WriteLine("Text:");

            int lastZeilenSprung = 0;
            for (int i = 0; i < scene.getText().Length; i++)
            {
                String s = scene.getText().Substring(i, 1);

                Console.Write(s);
                if (i == lastZeilenSprung + 75 || s == "." || s == "!" || i == scene.getText().Length )
                { Console.WriteLine(""); lastZeilenSprung = i; }
                System.Threading.Thread.Sleep(10);
            }

            Console.WriteLine("");
            Console.WriteLine("Optionen:");

            foreach (Option item in scene.getOptions())
            {
                Console.WriteLine(item.getTitle());
                System.Threading.Thread.Sleep(10);
            }

            Console.WriteLine("");
            Console.WriteLine("Inventar:");

            foreach (Item item in scene.inventory.Items)
            {
                Console.WriteLine("> " + item.Itemname + " | " + item.Itemtype + " | " + item.Extra + " | (" + item.getItemid() + ")");
                System.Threading.Thread.Sleep(10);
            }

            Console.ReadLine();
        }
    }
}
