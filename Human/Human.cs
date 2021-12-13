using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondModule.Human
{
    public abstract class Human
    {
        public Human(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}
