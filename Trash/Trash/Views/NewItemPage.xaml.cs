using System;
using System.Collections.Generic;
using System.ComponentModel;
using Trash.Models;
using Trash.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trash.Views
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