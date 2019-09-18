using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Hamazon.ViewModels
{
    class HomeViewModel : INotifyPropertyChanged
    {
        
        public List<Product> FeaturedProducts { get; set; }

        public string SecondSectionTitle { get; set; }
        public List<Product> SecondSectionProducts { get; set; }

        public List<Product> BabyProducts { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;


    }
}
