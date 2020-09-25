using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10
{
    class Shoe
    {
        int size;
        string color;
        string brand;

        public Shoe(int size, string color, string brand)
        {
            this.Size = size;
            this.Color = color;
            this.Brand = brand;
        }

        public int Size { get => size; set => size = value; }
        public string Color { get => color; set => color = value; }
        public string Brand { get => brand; set => brand = value; }
        public override string ToString()
        {
            return "Size: " + Size + " Color: " + Color + " Brand: " + Brand;
        }
    }
}
