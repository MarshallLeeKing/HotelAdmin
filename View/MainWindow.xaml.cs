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
using System.Windows.Shapes;

using HotelAdmin.Model;
using System.Diagnostics;

namespace HotelAdmin
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private HotelDb _dbSet; 
        
        public MainWindow() : this(new HotelDb()) { }

        public MainWindow(HotelDb dbSet) {
            InitializeComponent();

            _dbSet = dbSet;
        }

        // загрузка окна
        private void Window_Loaded(object sender, RoutedEventArgs e) {
            // привязка колекции к DataGrid

            // new List

            DgMain.ItemsSource = _dbSet.;

            Trace.WriteLine("Hello!");

        } // Window_Loaded
    }
}
