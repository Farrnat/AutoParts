using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoParts
{
    internal class Interior
    {
        public int id { get; set; }
        public string mark, type, coast;

        public string Mark
        {
            get { return mark; }
            set { mark = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Coast
        {
            get { return coast; }
            set { coast = value; }
        }

        public Interior() { }

        public Interior(string mark, string type, string coast)
        {
            this.Mark = mark;
            this.Type = type;
            this.Coast = coast;
        }
    }
}
