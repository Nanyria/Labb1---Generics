using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1____Generics
{
    internal class BoxSameDimentions : EqualityComparer<Box>
    {
        public override bool Equals(Box B1, Box B2)
        {
            if (B1.Width == B2.Width && B1.Height == B2.Height && B1.Length == B1.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode(Box b)
        {
            return b.GetHashCode();
        }
    }
}
