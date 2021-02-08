using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Demo_Wpf_MvvmBindingValidation
{
    public class Monster : ObservableObject
    {
        private string _name;
        private int _age;

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty.");

                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Age must be a positive number.");
                }
                else if (value > 120)
                {
                    throw new ArgumentException("Age must be between 1 and 120.");
                }

                _age = value;
                OnPropertyChanged(nameof(Age));
            }
        }

        public Monster()
        {

        }

        public Monster(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
