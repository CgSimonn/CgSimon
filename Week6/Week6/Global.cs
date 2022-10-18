using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    class Global :INotifyPropertyChanged 
    {
        public static Student Info;

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
