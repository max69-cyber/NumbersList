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
using System.Windows.Navigation;

namespace NumbersList
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int element = 0;

        private void AddElement(object sender, RoutedEventArgs e)
        {
            numbersList.Items.Add(element);
            element++;
        }

        private void DeleteElement(object sender, RoutedEventArgs e)
        {
            numbersList.Items.Remove(numbersList.SelectedItem);
        }

        private void ClearList(object sender, RoutedEventArgs e)
        {
            numbersList.Items.Clear();
            element = 0;
        }
    }
}
