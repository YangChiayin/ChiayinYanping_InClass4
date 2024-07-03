/* 
 * Name of Project: ChiayinYanping_InClass4
 * Purpose: Understaing the concept of "programming to the interface"
 * Revision History: 
 * - Chiayin Yang & Yanping Guo, July 2 2024, Create basic design and functions.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static ChiayinYanping_InClass4.Animals;

namespace ChiayinYanping_InClass4
{
    public partial class MainForm : Form
    {
        // Constructor to initialize the form
        public MainForm()
        {
            InitializeComponent();
        }

        // Load animal objects into the ListBox when MainForm is loaded
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Add Dog and Cat objects to the ListBox
            listBoxAnimals.Items.Add(new Dog("Sparky"));
            listBoxAnimals.Items.Add(new Cat("Garfield"));
            listBoxAnimals.Items.Add(new Dog("Rex"));
        }

        // Event handler for the Speak button click event
        private void btnSpeak_Click(object sender, EventArgs e)
        {
            // Get the selected animal from the ListBox and call its Speak method
            Animal selectedAnimal = listBoxAnimals.SelectedItem as Animal;
            selectedAnimal?.Speak();
        }
    }
}
