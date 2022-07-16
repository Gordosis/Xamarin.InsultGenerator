using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trash.Views
{
    public partial class SingleInsultView : ContentPage
    {
        public SingleInsultView()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            NameEntry.Text = "";
            SwearDisplay.Text = "";
        }

        public static string[] swearWord1 = new string[] { " Cunt"," Fuck"," Motherfucking"," Bastard"," Beaver"," Bellend",
                                " Clunge"," Cock", " Dick"," Dickhead"," Fanny"," Flaps"," Gash"," Knob"," Minge"," Prick"," Punani",
                                " Pussy", " Snatch"," Twat","n Arsehole"," Balls"," Bitch"," Bollocks"," Bullshit"," Shit"," Tits",
                                " Arse", " Bloody"," Bugger"," Cow"," Crap"," Damn"," Git"," Minger"," Bum", "n Ethan", " Twit",
                                " Donkey", " Dog", " Knob", " Bottom-Feeding", " Weatherboarded", " Pin Dicked", " MILF", " Lopsided"};
        public static string[] swearWord2 = new string[] { "Face", "Fart", "Head", "Waffle", "Pancake", "Bandit", "Licker",
                                "Sucker", "Bucket" , "Twinkler", "Sprinkle", "Delinquent", "Toucher", "Feeler", "Master", "Slave",
                                "Jockey", "Stingray", "Shit Shack", "Pin Dick", "MILF"};
        Random rnd = new Random();

        public string GetInsult(string insult)
        {
            string firstName = NameEntry.Text;

            if (firstName == "Gordo" | firstName == "gordo")
                return "Hello Gordo, you are a fucking legend!";
            else if (firstName == "Dylan" | firstName == "dylan" | firstName == "Ethan" | firstName == "ethan" | firstName == "Jamie" | firstName == "jamie")
                return String.Format("Hello {0}, you are a Bottom Feeding Stingray", firstName);
            else if (firstName == "Lorenzo" | firstName == "lorenzo")
                return String.Format("Hello {0}, you are a Malnourished Stingray", firstName);
            else if (string.IsNullOrWhiteSpace(firstName))
                return "Enter your name dipshit...";
            else
                return String.Format("Hello {0}, you are a{1} {2}", firstName, swearWord1[rnd.Next(swearWord1.Length)], swearWord2[rnd.Next(swearWord2.Length)]);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string insult = "";
            SwearDisplay.Text = GetInsult(insult);
        }
    }
}