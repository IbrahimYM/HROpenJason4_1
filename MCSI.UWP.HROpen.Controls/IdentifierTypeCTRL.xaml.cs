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

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace MCSI.UWP.HROpen.Controls
{
    public sealed partial class IdentifierTypeCTRL : UserControl
    {
        public IdentifierTypeCTRL(IdentifierType identifier)
        {
            this.InitializeComponent();
            this.DataContext = new IdentifierTypeViewModel(identifier);
        }
    }
}
