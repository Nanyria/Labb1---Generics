using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1____Generics
{
    internal class Box : IEquatable<Box>
    {
        public int Height {  get; set; }
        public int Width { get; set; }
        public int Length { get; set; }


        public Box(int height, int width, int length)
        {
            Height = height;
            Width = width;
            Length = length;
        }

        public bool Equals(Box? other)
        {
            if (new BoxSameDimentions().Equals(this, other))
            {
                return true;
            }
            else 
            {
                return false; 
            }
        }
    }
}
