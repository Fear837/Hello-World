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

            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════");
            Console.WriteLine("║                                    TEXT");
            Console.Write("║ ");
            int lastZeilenSprung = 0;
            for (int i = 0; i < scene.getText().Length; i++)
            {
                String s = scene.getText().Substring(i, 1);

                Console.Write(s);
                if (i == lastZeilenSprung + 75 || s == "." || s == "!")
                { if (i != scene.getText().Length - 1) { Console.WriteLine("*"); Console.Write("║ "); lastZeilenSprung = i; } }
                System.Threading.Thread.Sleep(10);
            }

            Console.WriteLine("");
            Console.WriteLine("║");
            Console.WriteLine("╠═════════════════════════════════════════════════════════════════════════════");
            Console.WriteLine("║                                  INVENTAR                 ('inventar <id>')");

            foreach (var item in scene.inventory.Items)
            {
                Console.WriteLine("╠═══► [" + scene.inventory.Items.IndexOf(item) + "] " + item.Itemname + " | " + item.Extra);
                System.Threading.Thread.Sleep(10);
            }

            Console.WriteLine("║");
            Console.WriteLine("╠═════════════════════════════════════════════════════════════════════════════");
            Console.WriteLine("║                                  OPTIONEN                  ('option <id>')");

            foreach (Option item in scene.getOptions())
            {
                Console.WriteLine("║    " + scene.getOptions().IndexOf(item) + ": " + item.getTitle());
                System.Threading.Thread.Sleep(10);
            }

            Console.WriteLine("▼");
            Console.Write("Eingabe: ");

            readInput();
        }

        public void reShow()
        {
            Console.Clear();

            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════");
            Console.WriteLine("║                                    TEXT");
            Console.Write("║ ");
            int lastZeilenSprung = 0;
            for (int i = 0; i < scene.getText().Length; i++)
            {
                String s = scene.getText().Substring(i, 1);

                Console.Write(s);
                if (i == lastZeilenSprung + 75 || s == "." || s == "!")
                { if (i != scene.getText().Length - 1) { Console.WriteLine("*"); Console.Write("║ "); lastZeilenSprung = i; } }
            }

            Console.WriteLine("");
            Console.WriteLine("║");
            Console.WriteLine("╠═════════════════════════════════════════════════════════════════════════════");
            Console.WriteLine("║                                  INVENTAR                 ('inventar <id>')");

            foreach (var item in scene.inventory.Items)
            {
                Console.WriteLine("╠═══► [" + scene.inventory.Items.IndexOf(item) + "] " + item.Itemname + " | " + item.Extra);
            }

            Console.WriteLine("║");
            Console.WriteLine("╠═════════════════════════════════════════════════════════════════════════════");
            Console.WriteLine("║                                  OPTIONEN                  ('option <id>')");

            foreach (Option item in scene.getOptions())
            {
                Console.WriteLine("║    " + scene.getOptions().IndexOf(item) + ": " + item.getTitle());
            }

            Console.WriteLine("▼");
            Console.Write("Eingabe: ");

            readInput();
        }

        private void readInput()
        {
            String Input = Console.ReadLine();
            if (Input == "exit")
            { }
            else { reShow(); }
            
        }

        public void debugShow(Boolean ClearOld)
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
