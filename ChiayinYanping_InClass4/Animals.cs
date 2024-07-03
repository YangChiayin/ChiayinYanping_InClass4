using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiayinYanping_InClass4
{
    internal class Animals
    {
        // Define the Animal interface with a Name property and a Speak method
        public interface Animal
        {
            string Name { get; }
            void Speak();
        }
    }
}
