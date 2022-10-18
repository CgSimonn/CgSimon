using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    public class Student : INotifyPropertyChanged, ICloneable
    {
        public string ID { get; set; }

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }
        private int _credits;
        public int Credits
        {
            get => _credits;
            set
            {
                _credits = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Credits"));
            }
        }
        private string _avatar;
        public string Avatar
        {
            get => _avatar;
            set
            {
                _avatar = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Avatar"));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public object Clone()
        {
            //Student sv = new Student();
            //sv.ID = this.ID;
            //sv.Name = this.Name;
            //sv.Credits = this.Credits;
            //sv.Avatar = this.Avatar;
            //return sv;  thay the o dong` duoi 

            return MemberwiseClone();
        }
    }
}
