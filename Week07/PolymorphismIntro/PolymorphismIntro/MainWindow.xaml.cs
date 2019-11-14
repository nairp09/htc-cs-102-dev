﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PolymorphismIntro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Animal> Animals;
        public MainWindow()
        {
            InitializeComponent();
            Animals = new ObservableCollection<Animal>();
            // Define a new List of dogs
            List<Animal> animals = new List<Animal>();

            // Instantiate some dog objects
            Dog dog1 = new dog("Muppet", 20, "Rolf");
            Dog dog2 = new Dog("Golden Retriever", 30, "Air Bud");
            Duck duck1 = new Duck(9, "Donald");
            Frog frog1 = new Frog(4, "Kermit", false);

            // Add the dogs to the list
            Animals.Add(dog1);
            Animals.Add(dog2);
            Animals.Add(duck1);
            Animals.Add(frog1);




            lvAnimals.ItemsSource = Animals;

        }

        private void Bark_Button_Click(object sender, RoutedEventArgs e)
        {
            Dog dog = new Dog();
            dog.Bark();
        }

        private void Quack_Button_Click(object sender, RoutedEventArgs e)
        {
            Duck duck = new Duck();
            duck.Quack();
        }

        private void Ribbit_Button_Click(object sender, RoutedEventArgs e)
        {
            Frog frog = new Frog();
            frog.Ribbit();
        }

        private void SayName_Button_Click(object sender, RoutedEventArgs e)
        {   

           
            
        }

        private void lvAnimals_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Loop through the list and call a method on the objects
            foreach (Animal a in Animals)
            {
                a.SayName();
            }
        }

        private void lvAnimals_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {


            Animal selectedAnimal = lvAnimals.SelectedItem as Animal;
            if (selectedAnimal != null)
            {
                selectedAnimal.Speak();
            }






        }
    }
}
