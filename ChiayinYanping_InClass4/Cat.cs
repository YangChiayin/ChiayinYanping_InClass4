using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiayinYanping_InClass4
{
    // Define the Cat class which implements the Animal interface
    internal class Cat : Animals
    {
        // Property to store the cat's name
        public string Name { get; private set; }

        public Cat(string name)
        {
            Name = name;
        }

        // Implement the Speak method to play the cat meowing sound
        public void Speak()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = @"C:\Users\Chiayin\source\repos\ChiayinYanping_InClass4\SoundFiles\cat_meow.wav";
            player.Play();
        }

        // Override the ToString method to return the cat's name with a cat emoji
        public override string ToString()
        {
            int catEmoji = 0x1F408;
            return $"{Name} {char.ConvertFromUtf32(catEmoji)}";
        }
    }
}
