using System.ComponentModel;
using System.Windows.Input;
using Avalonia.Input;
using System;
using Motor;

namespace RuethsResa
{
 
    
        public class RelayCommand : ICommand
        {
            private readonly Action<object?> _execute;
            public RelayCommand(Action<object?> execute) => _execute = execute;
            public event EventHandler? CanExecuteChanged;
            public bool CanExecute(object? parameter) => true;
            public void Execute(object? parameter) => _execute(parameter);
        }
        public class MainViewModel : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;

            private int _lblHitPoints;
            public int lblHitPoints
            {
                get => _lblHitPoints;
                set
                {
                    _lblHitPoints = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(lblHitPoints)));
                }
            }

            private int _lblXP;
            public int lblXP
            {
                get => _lblXP;
                set
                {
                    _lblXP = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(lblXP)));
                }
            }
            private int _lblGold;
            public int lblGold
            {
                get => _lblGold;
                set
                {
                    _lblGold = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(lblGold)));
                }
            }
            
            private int _lblLevel;
            public int lblLevel
            {
                get => _lblLevel;
                set
                {
                    _lblLevel = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(lblLevel)));
                }
            }
            
            public ICommand TestCommand { get; }

            public MainViewModel()
            {
                TestCommand = new RelayCommand(_ => lblGold = 123);
            }
        
        
        }
}