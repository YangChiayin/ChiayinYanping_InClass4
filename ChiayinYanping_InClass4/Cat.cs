using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiayinYanping_InClass4
{
    // Define the Cat class which implements the Animal interface
    public class Cat : Animal
    {
        // Property to store the cat's name
        public string Name { get;  set; }

        public Cat(string name)
        {
            Name = name;
        }

        // Implement the Speak method to play the cat meowing sound
        public void Speak()
        {
            new CommonConfig().getFilesPath("cat_meow.wav");
        }

        // Override the ToString method to return the cat's name with a cat emoji
        public override string ToString()
        {
            int catEmoji = 0x1F408;
            return $"{Name} {char.ConvertFromUtf32(catEmoji)}";
        }

       
    }
}
