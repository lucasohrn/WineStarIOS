using System;
using System.Collections.Generic;
using System.ComponentModel;
using WineStarIOS.Models;
using WineStarIOS.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WineStarIOS.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}