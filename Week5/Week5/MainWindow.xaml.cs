using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Week5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Student _sv1 = null;
        Student _sv2 = null;
        BindingList<Student> _list;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _sv1 = new Student()
            {
                ID = "2159001",
                Fullname = "Nguyen Van A",
                CurrentCredits = 30,
                MaxCredits = 150,
                Avatar = "Images/Student1.png",
                Program = "ITEC"

            };
            _sv2 = new Student()
            {
                ID = "2159002",
                Fullname = "Nguyen Van B",
                CurrentCredits = 50,
                MaxCredits = 150,
                Avatar = "Images/Student2.jpg",
                Program = "ITEC"
            };

            student1StackPanel.DataContext = _sv1;
            student2StackPanel.DataContext = _sv2;

            _list = new BindingList<Student>();
            _list.Add(_sv1);
            _list.Add(_sv2);
            
            studentListComboBox.ItemsSource = _list; //multiple items
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            _list.Add(new Student()
            {
                ID = "2159003",
                Fullname = "Nguyen Van C",
                Program = "ITEC",
                Avatar = "Images/Student4.jpg"
            });
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var index = studentListComboBox.SelectedIndex; // selectedINdex 
            _list.RemoveAt(index);
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            //_sv1.ID = "1959019";
            //_sv1.Fullname = "Aatrox";
            //_sv1.Program = "Mastery 7";
            //_sv1.CurrentCredits = 100;
            //_sv1.Avatar = "Images/Student3.jpg";

            var index = studentListComboBox.SelectedIndex;
            _list[index].Avatar = "Images/Student4.jpg";
        }
    }
}
