using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TipCalculator.Models
{
    public class TipModel : INotifyPropertyChanged
    {
        private decimal _total;
        private int _tip;
        private int _peopleCount;
        private decimal _totalTip;
        private decimal _totalWithTip;
        private decimal _tipPerPerson;
        private decimal _totalPerPerson;
        
        public decimal Total
        {
            get => _total;
            set
            {
                _total = value;
                OnPropertyChanged();
            }
        }

        public int Tip
        {
            get => _tip;
            set
            {
                _tip = value;
                OnPropertyChanged();
            }
        }

        public int PeopleCount
        {
            get => _peopleCount;
            set
            {
                _peopleCount = value;
                OnPropertyChanged();
            }
        }

        public decimal TotalTip
        {
            get => _totalTip;
            set
            {
                _totalTip = value;
                OnPropertyChanged();
            }
        }

        public decimal TotalWithTip
        {
            get => _totalWithTip;
            set
            {
                _totalWithTip = value;
                OnPropertyChanged();
            }
        }

        public decimal TipPerPerson
        {
            get => _tipPerPerson;
            set
            {
                _tipPerPerson = value;
                OnPropertyChanged();
            }
        }

        public decimal TotalPerPerson
        {
            get => _totalPerPerson;
            set
            {
                _totalPerPerson = value;
                OnPropertyChanged();
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}