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

        [Required(ErrorMessage = "Name is required.")]
        public string Name
        {
            get { return _name; }
            set
            {
                ValidateProperty(value, "Name");
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        [Required(ErrorMessage = "Age is required.")]
        [Range(3, 100)]
        public int Age
        {
            get { return _age; }
            set
            {
                ValidateProperty(value, "Age");
                _age = value;
                OnPropertyChanged(nameof(Age));
            }
        }

        public Monster(string name, int age)
        {
            Name = name;
            Age = age;
        }

        protected void ValidateProperty<T>(T value, string name)
        {
            Validator.ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = name });
        }
    }
}
