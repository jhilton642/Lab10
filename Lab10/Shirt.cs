using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10
{
    class Shirt
    {
        string size;
        string color;
        string type;

        public Shirt(string size, string color, string type)
        {
            this.Size = size;
            this.Color = color;
            this.Type = type;
        }

        public string Size { get => size; set => size = value; }
        public string Color { get => color; set => color = value; }
        public string Type { get => type; set => type = value; }
        public override string ToString()
        {
            return "Size: " + Size + " Coler: " + Color + " Type: " + Type;
        }
    }
}
