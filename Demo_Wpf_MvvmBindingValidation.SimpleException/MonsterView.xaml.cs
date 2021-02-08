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

namespace Demo_Wpf_MvvmBindingValidation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {


            InitializeComponent();

            TextBox_MonsterName.Text = "";
            
            TextBox_MonsterName.SelectAll();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            TextBox_MonsterName.SelectAll();
        }
    }
}
