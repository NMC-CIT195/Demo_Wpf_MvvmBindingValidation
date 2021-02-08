using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Wpf_MvvmBindingValidation
{
    public class MonsterViewModel : ObservableObject
    {
        private Monster _monster;

        public Monster Monster
        {
            get { return _monster; }
            set
            {
                _monster = value;
                OnPropertyChanged(nameof(Monster));
            }
        }

        public MonsterViewModel()
        {
            Monster = new Monster("Bonzo", 34);
        }
    }
}
