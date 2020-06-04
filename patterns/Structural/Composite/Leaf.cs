using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Structural.Composite
{
   public class Leaf : Component
    {
        public override string Operation()
        {
            return "Leaf";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }
}
