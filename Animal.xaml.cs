using System;
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
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.Collections;

namespace Homework_19
{
    /// <summary>
    /// Логика взаимодействия для dd.xaml
    /// </summary>
    public partial class Animal : Window 
    {
        ObservableCollection<IFauna> list2 = new ObservableCollection<IFauna>();
        public Animal()
        {
            InitializeComponent();
            ListFauna.ItemsSource = list2;
            list2.Add(FaunaFactory.GetFauna("Птицы", "Дятловые", "Дятел красноголовый", "3"));
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddAnimal add = new AddAnimal(this);
            add.ShowDialog();
        }
        public void AddFauna(IFauna fauna)
        {
            list2.Add(fauna);
        }
        
        private void saveAnimal_Click(object sender, RoutedEventArgs e)
        {
            saveAnimal save = new saveAnimal();
            save.ShowDialog();
        }
        public ObservableCollection<IFauna> Fauna()
        {
            return list2;
        }
    }
}
