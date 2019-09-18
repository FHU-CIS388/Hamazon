using Hamazon.ViewModels;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Hamazon
{
    public partial class ProfliePage : ContentPage
    {
        public ProfliePage()
        {
            InitializeComponent();
            BindingContext = new ProfileViewModel();
        }

        /*private void NameEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            nameLabel.Text = nameEntry.Text;
        }*/
    }
}
