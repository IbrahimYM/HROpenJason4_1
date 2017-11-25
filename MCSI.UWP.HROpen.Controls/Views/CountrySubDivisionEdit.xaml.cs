using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MCSI.UWP.HROpen.Controls.ViewModels;
using MCSI.UWP.HROpen.Common.Models;

// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MCSI.UWP.HROpen.Controls.Views
{
    public sealed partial class CountrySubDivisionEditDialog : ContentDialog
    {
        public CountrySubDivisionEditDialog(AddressComponentType subDivision)
        {
            this.InitializeComponent();
            DataContext = new CountrySubDivisionEditViewModel( subDivision);
        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {

            CountrySubDivisionEditViewModel vm = (this.DataContext as CountrySubDivisionEditViewModel);
            if (string.IsNullOrEmpty(vm.Type)) {
                args.Cancel = true;
                vm.ErrorMsg = "Type is required (eg: County,State,Region)";

            } else if(string.IsNullOrEmpty(vm.Value))
            {
                args.Cancel = true;
                vm.ErrorMsg = "Value  is required ";

            }

           

        }

        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {

        }
    }
}
