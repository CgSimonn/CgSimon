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
//Cach 1: dung` bien Global
//Cach 2 : dung` public property 
namespace Week6
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
        Student _sv = new Student()
        {
            ID = "001",
            Name = "Nguyen Van A",
            Credits = 80,
            Avatar = "Images/Student3.jpg",
        };
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = _sv;
        }
        int _oldSlideValue = 0;
        string _oldImage = "";
        Student _old = new Student();
        private void sentButtonClick(object sender, RoutedEventArgs e)
        {
            _old = (Student)_sv.Clone();

            //Luu du lieu hien tai vao bien toan cuc
            //Global.Info = (Student)_sv.Clone(); cach 1 

            //Tao man hinh dich 

            var screen = new DestinationWIndows(_sv); // Cach 2
            _oldSlideValue = _sv.Credits;// luu gia tri goc
            _oldImage = _sv.Avatar;
            screen.Handler += Screen_Handler;
            screen.AvatarChanged += avatar_screen_hanlder;
            if(screen.ShowDialog().Value ==true)
            {
                //Title = "Co du lieu moi";
                //_sv.Name = Global.Info.Name;
                _sv = screen.ReturnsData;
                DataContext = _sv;
                Title = _sv.Avatar;
            }
            else
            {
                //_sv.Credits = _oldSlideValue;
                //_sv.Avatar = _oldImage;
                _sv = _old;
                DataContext = _sv;
            }
        }
        private void Screen_Handler(int newValue)
        {
            _sv.Credits = newValue; // Preview
        }
        private void avatar_screen_hanlder(string newAvatar)
        {
            _sv.Avatar = newAvatar;
        }
    }
    
}
