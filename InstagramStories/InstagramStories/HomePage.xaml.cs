using InstagramStories.Models;
using InstagramStories.Pages;
using InstagramStories.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace InstagramStories
{
    public partial class MainPage : ContentPage
    {
        HomeViewmodel homeViewmodel;
        public MainPage()
        {
            InitializeComponent();
            homeViewmodel = new HomeViewmodel(this.Navigation);
            this.BindingContext = homeViewmodel;
        }
    }
}
