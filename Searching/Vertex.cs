using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    public class Vertex
    {
        public String name;
        public int state;
        public int parent;

        public Vertex(String name) 
        { 
            this.name = name;
        }
    }
}
