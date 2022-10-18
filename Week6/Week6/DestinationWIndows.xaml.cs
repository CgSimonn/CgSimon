using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

namespace Week6
{
    /// <summary>
    /// Interaction logic for DestinationWIndows.xaml
    /// </summary>
    public partial class DestinationWIndows : Window
    {
        public delegate void AvatarChangeHandler(string newImage);
        public event AvatarChangeHandler AvatarChanged;

        public delegate void CreditChange(int  newvalue); // 
        public event CreditChange Handler; // (mang?) con tro ham`

        public Student ReturnsData { get; set; } // Cach 2 

        public DestinationWIndows(Student _sv)
        {
            InitializeComponent();
            ReturnsData = (Student)_sv.Clone(); // Cach 2
        }

        private void okButton_click(object sender, RoutedEventArgs e)
        {
            // Global.Info.Name = sourceTextBox.Text; Cach 1 
            //ReturnsData.Name = sourceTextBox.Text; // khong can thiet vi DataContext = ReturnsData; 
            DialogResult = true; // cua so se bi dong
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //try to load all the available images
            string exeFolder = AppDomain.CurrentDomain.BaseDirectory;
            string imagesFolder = $"{exeFolder}Images";
            //get the images
            DirectoryInfo info = new DirectoryInfo(imagesFolder);
            var files = info.GetFiles("*.jpg");

            // in ra so luong anh? trong debug va k in ra man` hinh cuoi cung
            Debug.WriteLine($"Found {files.Length} images");
            foreach (var file in files)
            {
                Debug.WriteLine(file.Name);
            }

            //bien doi string => co thuoc tinh Avatar
            var previews = from f in files
                           select new
                           {
                               Avatar = $"Images/{f.Name}"
                           };
            previewListView.ItemsSource = previews;

            DataContext = ReturnsData; // Binding 2 chieu` 
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int newValue = (int) CreditSlider.Value;
            Handler?.Invoke(newValue);
        }
        private void PreviewListView_SelectionChanged(object sender, SelectionChangedEventArgs e) // thay doi lua chon 
        {
            dynamic info = previewListView.SelectedItem;

            ReturnsData.Avatar = info.Avatar; // cap nhat avatar
            AvatarChanged?.Invoke(info.Avatar);
        }
    }
}
