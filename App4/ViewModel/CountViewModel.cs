using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App4.ViewModel
{
    class CountViewModel : BaseModel
    {
        int contador;
        string countConverted;
        ICommand buttonClickCommand;
        ICommand resetClickCommand;

        public CountViewModel()
        {
            contador = 0;
        }

        public int Contador
        {
            get => contador;
            set
            {
                if (value == contador) return;
                contador = value;
                CountConverted = $"Has dado click {Contador} veces";
                RaisePropertyChanged(nameof(Contador));
                RaisePropertyChanged(nameof(ResetClickAction));
            }
        }

        public string CountConverted
        {
            get => countConverted;
            set {
                if (string.Equals(countConverted, value)) return;
                countConverted = value;
                RaisePropertyChanged(nameof(CountConverted));
            }
        }

    public ICommand ButtonClickCommand
        {
            get
            {
                if (buttonClickCommand == null)
                    buttonClickCommand = new Command(ButtonClickAction);
                return buttonClickCommand;
            }
        }

        public void ButtonClickAction() {
            Contador++;
        }

        public ICommand ResetClickCommand
        {
            get {
                if (resetClickCommand == null)
                    resetClickCommand = new Command(ResetClickAction);
                return resetClickCommand;
            }
        }

        public void ResetClickAction()
        {
            Contador = 0;
            CountConverted = "Ha reiniciado el contador";
           

        }




    }

}
