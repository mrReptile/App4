using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace App4.ViewModel
{
    class BaseModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        //public void RaisePropertyChanged({CallerMemberName} string )
       public void RaisePropertyChanged(string cambio)
       {
         PropertyChanged.Invoke(this, new PropertyChangedEventArgs(cambio));
       }
    }
}
