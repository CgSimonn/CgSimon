using System;
using System.IO;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string[] englishVocab;
        static string[] fruit;
        static List<Entry> entryList;
        class Entry
        {
            public string Left { get; set; }
            public string Right { get; set; }
            public override string ToString()
            {
                return $"{Left} - {Right}";
            }
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void changeButton_Click(object sender, RoutedEventArgs e)
        { 
            Random rng = new Random();
            int k = rng.Next(entryList.Count());

            EnglishVocab.Content = englishVocab[k];
            var newFruitImage = new BitmapImage(new Uri(fruit[k], UriKind.Relative));
            Fruit.Source = newFruitImage;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) // chay truoc luc build 
        {
            string filename = "Data.txt";
            entryList = new List<Entry>();
            if (File.Exists(filename))
            {
                string[] lines = File.ReadAllLines(filename);
                foreach (var line in lines)
                {
                    string[] tokens = line.Split(
                        new String[] { " - " },
                        StringSplitOptions.None
                    );

                    string left = tokens[0];
                    string right = tokens[1];

                    Entry entry = new Entry()
                    {
                        Left = left,
                        Right = right
                    };
                    entryList.Add(entry);
                }
            }
            else
            {
                EnglishVocab.Content = "File not found";
            }

            englishVocab = new string[entryList.Count()];
            fruit = new string[entryList.Count()];

            for (int i = 0; i < entryList.Count(); i++)
            {
                englishVocab[i] = entryList[i].Left;
                fruit[i] = "Fruit/" + entryList[i].Right;
            }
        }
    }
}
