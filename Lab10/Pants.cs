using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10
{
    class Pants
    {
        int waistSize;
        string type;
        string color;

        public Pants(int waistSize, string type, string color)
        {
            this.WaistSize = waistSize;
            this.Type = type;
            this.Color = color;
        }

        public int WaistSize { get => waistSize; set => waistSize = value; }
        public string Type { get => type; set => type = value; }
        public string Color { get => color; set => color = value; }
        public override string ToString()
        {
            return "Waist Size: " + WaistSize + " Type: " + Type + " Coler: " + Color;
        }
    }
}
