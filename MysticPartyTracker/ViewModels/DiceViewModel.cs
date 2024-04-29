using CommunityToolkit.Mvvm.ComponentModel;
using MysticPartyTracker.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace MysticPartyTracker.ViewModels
{
    public class DiceViewModel : ObservableObject
    {
        private ObservableCollection<int> _rolls = new ObservableCollection<int>();
        public ObservableCollection<int> Rolls
        {
            get { return _rolls; }
            set { _rolls = value; OnPropertyChanged(nameof(Rolls)) }
        }
        private int _total;
        public int Total { get; set; }

        public ICommand RollCommand { get; }

        public DiceViewModel()
        {
            RollCommand = new Command(Roll);
        }

        private void Roll()
        {
            int numberSides = 0;
            int quantity = 0;

            Dice dice = new Dice(numberSides);

            Rolls.Clear();
            Total = 0;

            for (int i = 0; i < quantity; i++)
            {
                int roll = dice.Roll();
                Rolls.Add(roll);
                Total += roll;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}