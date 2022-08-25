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
using HotelAdmin.ViewModel;
using System.Diagnostics;

namespace HotelAdmin
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private HotelDbController _dbSet; 
        
        public MainWindow() : this(new HotelDbController()) { }

        public MainWindow(HotelDbController dbSet) {
            InitializeComponent();

            _dbSet = dbSet;
        }

        // загрузка окна
        private void Window_Loaded(object sender, RoutedEventArgs e) {
            // привязка колекции к DataGrid
            DgMain.ItemsSource = _dbSet.GetTablePeoples();

            Trace.WriteLine("Hello!");

        } // Window_Loaded
    }
}
