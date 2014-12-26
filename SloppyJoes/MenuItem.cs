using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SloppyJoes
{
    class MenuItem
    {
        public string Meat { get; private set; }
        public string Condiment { get; private set; }
        public string Bread { get; private set; }

        public MenuItem(string meat, string condiment, string bread)
        {
            this.Meat = meat;
            this.Condiment = condiment;
            this.Bread = bread;
        }

        public override string ToString()
        {
            return this.Meat + " with " + this.Condiment + " on " + this.Bread;
        }
    }
}
