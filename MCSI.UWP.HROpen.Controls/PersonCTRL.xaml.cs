﻿using System;
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
using MCSI.UWP.HROpen.Common.Models;
using MCSI.UWP.HROpen.Controls.ViewModels;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace MCSI.UWP.HROpen.Controls
{
    public sealed partial class PersonCTRL : UserControl
    {
        public PersonCTRL(PersonType person)
        {
            this.InitializeComponent();
            DataContext = new PersonViewModel(person);
        }

        public void  Initialize(PersonType person) {
            DataContext = new PersonViewModel(person);
        }
    }
}
