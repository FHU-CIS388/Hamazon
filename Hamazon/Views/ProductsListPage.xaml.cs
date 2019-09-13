using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Hamazon
{
    public partial class ProductsListPage : ContentPage
    {
        public ObservableCollection<Product> Products { get; set; }

        public ProductsListPage()
        {
            InitializeComponent();

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
        }
    }
}
