using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    class Student:INotifyPropertyChanged
    {
        //IDictionary,fullname,currentcredits,maxcredits
        public string ID { get; set;}
        public string Fullname { get; set; }
        public int CurrentCredits { get; set; }
        public int MaxCredits { get; set; }
        public string Program { get; set; }
        //public string Avatar { get; set; }



        private string _avatar;
        public string Avatar
        {
            get => _avatar; set
            {
                _avatar = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Avatar")); // hoac cai thu vien FODY voi visual 2019 tro len 
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public override string ToString()
        {
            return $"{ID} - {Fullname}";
        }
    }

    
}
