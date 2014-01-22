using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Option
    {
        private String Title;

        private Scene Destination;

        public Option(String Title, Scene Destination) // Todo: Add Item-requirement
        {
            this.Title = Title;
            this.Destination = Destination;
        }

        public String getTitle()
        { return Title; }

        public Scene getScene()
        { return Destination; }

        public void setScene(Scene scene)
        { Destination = scene; }
    }
}
