﻿using System;
using System.Collections.Generic;
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
using System.Collections.ObjectModel;

namespace Homework_19
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //RepositoryAnimal fauna = new RepositoryAnimal();
        public MainWindow()
        {
            InitializeComponent();
            Animal animal = new Animal();
            animal.ShowDialog();
        }

        //private void Cancel_Click(object sender, RoutedEventArgs e)
        //{
        //    Close();
        //}
        //public void Massiv(string[]mas)
        //{
        //    fauna.Add(FaunaFactory.GetFauna($"{mas[0]}", $"{mas[1]}", $"{mas[2]}", $"{mas[3]}"));
        //    List<IFauna> list = fauna.PrintRepository();
        //    ListFauna.ItemsSource = list; 
        //}
        //private void Add_Click(object sender, RoutedEventArgs e)
        //{
        //    //AddAnimal add = new AddAnimal();
        //    //add.ShowDialog();
        //}

        //private void saveAnimal_Click(object sender, RoutedEventArgs e)
        //{
        //    saveAnimal save = new saveAnimal();
        //    save.ShowDialog();
        //}
    }
}
