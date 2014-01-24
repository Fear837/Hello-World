using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace Projekt
{
    class Scene
    {
        private String Text;
        private List<Option> Options;
        public Inventory inventory { get; set; }
        public String SceneName { get; set; }
        public Int32 SceneID { get; set; }

        public Scene(String SceneName, Int32 SceneID, String Text, List<Option> Options, Inventory inventory)
        {
            this.Text = Text;
            this.Options = Options;
            this.inventory = inventory;
            this.SceneName = SceneName;
            this.SceneID = SceneID;
        }

        public String getText()
        { return Text; }

        public Option getOptionAtIndex(Int32 Index)
        { return Options.ElementAt(Index); }

        public List<Option> getOptions()
        { return Options; }
    }
}
