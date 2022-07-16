using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trash.Models;
using Trash.ViewModels;
using Trash.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trash.Views
{
    public partial class ItemsPage : ContentPage
    {
        MultiInsultViewModel _viewModel;

        public ItemsPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new MultiInsultViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            SwearDisplay.Text = "";
            NumberEntry.Text = "";
            _viewModel.OnAppearing();
        }
        public static string[] swearWord1 { get => Views.SingleInsultView.swearWord1; set => Views.SingleInsultView.swearWord1 = value; }
        public static string[] swearWord2 { get => Views.SingleInsultView.swearWord2; set => Views.SingleInsultView.swearWord2 = value; }
        Random rnd = new Random();

        public string GetNumInsult()
        {
            string finalSwear = "";
            string swearNum = (NumberEntry.Text);
            StringBuilder stringBuilder = new StringBuilder();
            int i = 1;

            if (swearNum == "69")
            {
                return "69... hah! nice!!!";
            }
            else if (string.IsNullOrWhiteSpace(NumberEntry.Text))
            {
                return "Enter a number dipshit...";
            }
            else
            {
                try
                {
                    int swearNum2 = Convert.ToInt32(NumberEntry.Text);
                    while (i <= swearNum2)
                    {
                        i++;
                        finalSwear = String.Format("{0}{1}You are a{2} {3}", finalSwear, Environment.NewLine, swearWord1[rnd.Next(swearWord1.Length)], swearWord2[rnd.Next(swearWord2.Length)]);
                    }
                    return finalSwear;
                }
                catch (FormatException)
                {
                    string catch1 = "Enter a number, you twit!";
                    return catch1;
                }
            }
        }

        private void SwearButton_Clicked(object sender, EventArgs e)
        {
            SwearDisplay.Text = GetNumInsult();
        }
    }
}