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

namespace Homework_19
{
    /// <summary>
    /// Логика взаимодействия для dd.xaml
    /// </summary>
    public partial class dd : Window
    {
        RepositoryAnimal fauna = new RepositoryAnimal();
        public dd()
        {
            InitializeComponent();
            List<IFauna> list = fauna.PrintRepository();
            view.ItemsSource = list;
        }
    }
}
