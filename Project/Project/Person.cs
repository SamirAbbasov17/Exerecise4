using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Person
    {
        public Person()
        {
            
        }
        public string Name { get; set; } = null!;
        public string SurName { get; set; } = null!;
        public virtual int Age { get; set; } 
    }
}
