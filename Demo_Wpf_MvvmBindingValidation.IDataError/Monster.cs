using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Demo_Wpf_MvvmBindingValidation
{
    public class Monster : ObservableObject, IDataErrorInfo
    {
        private string _name;
        private int _age;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                OnPropertyChanged(nameof(Age));
            }
        }
        public Monster(string name, int age)
        {
            Name = name;
            Age = age;
        }

        //
        // IDataErrorInfo implementation
        //
        public string Error => null;

        public string this[string name]
        {
            get
            {
                switch (name)
                {
                    case nameof(Name):
                        if (string.IsNullOrWhiteSpace(Name))
                            return "Name cannot be empty.";
                        break;

                    case nameof(Age):
                        if (IsInComplexRange(Age))
                            return "Age must be between 21 and 100.";
                        break;
                }

                return null;
            }
        }

        private bool IsInComplexRange(int age)
        {
            return (age < 21 || age > 100);
        }

    }
}
