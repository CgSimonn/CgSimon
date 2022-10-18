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
using System.Globalization;

namespace Week4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        Student _sv = new Student
        {
            ID = "1959019",
            Fullname = "Lê Trần Hiếu Nhăn",
            Birth = 2003,
            Credits = 30,
            AvatarPath = "Images/ava.jpg",
            TotalCredits = 150
        };

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            this.DataContext = _sv;
        }

        private void Button_Click(object sender, RoutedEventArgs e) // calculate Age
        {
            int age = DateTime.Now.Year - _sv.Birth;
            MessageBox.Show($"Ban {age} tuoi");
        }
    }
}
