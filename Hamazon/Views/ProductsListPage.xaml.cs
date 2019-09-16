using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Hamazon
{
    public partial class ProductsListPage : ContentPage
    {
        public ObservableCollection<Product> Products { get; set; }
        public ObservableCollection<CarouselItem> CarouselItems { get; set; }

        public ProductsListPage()
        {
            InitializeComponent();

            BindingContext = this;

            Products = new ObservableCollection<Product>();

            Products.Add(new Product());
            Products.Add(new Product() { Name="Bacon", Price=100.00M});
            Products.Add(new Product());
            Products.Add(new Product());
            Products.Add(new Product());
            Products.Add(new Product());
            Products.Add(new Product());
            Products.Add(new Product());

            ProductsListView.ItemsSource = Products;

            CarouselItems = new ObservableCollection<CarouselItem>();
            CarouselItems.Add( new CarouselItem() {Image="ham2.jpg", Heading="HAM", Caption="It's super tasty!", Message="Get your Ham on." } );
            CarouselItems.Add(new CarouselItem() { Image = "ham3.jpg", Heading = "PORK", Caption = "It's crazy good!", Message = "Get your pork on." });
            CarouselItems.Add(new CarouselItem() { Image = "ham4.jpg", Heading = "BACON", Caption = "It's like heaven if heaven were a fried food!", Message = "Get your BACON on." });


            SpecialsCarouselView.ItemsSource = CarouselItems;

        }
    }
}
