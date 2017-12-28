using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Controls.ViewModels
{
    public abstract class ViewModelBase:INotifyPropertyChanged

    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }

        //provides a way for external parent to indicate the need for
        //refreshing the internal state of the ViewModel.
        public virtual void Pulse() { }

        public virtual void Initiate(object item) { }
        
    }


}
