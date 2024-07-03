using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiayinYanping_InClass4
{
    // Define the Dog class which implements the Animal interface
    public class Dog : Animal
    {
        // Property to store the dog's name
        public string Name { get;  set; }

        // Constructor to initialize the dog's name
        public Dog(string name)
        {
            Name = name;
        }

        // Implement the Speak method to play the dog barking sound
        public void Speak()
        {
            new CommonConfig().getFilesPath("dog_bark.wav");
        }

        // Override the ToString method to return the dog's name with a dog emoji
        public override string ToString()
        {
            int dogEmoji = 0x1F415;
            return $"{Name} {char.ConvertFromUtf32(dogEmoji)}";
        }
    }
}
