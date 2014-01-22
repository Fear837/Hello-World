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
            }

            Console.WriteLine("Optionen:");

            foreach (Option item in scene.getOptions())
            {
                Console.WriteLine(item.getTitle());
            }

            Console.ReadLine();
        }
    }
}
