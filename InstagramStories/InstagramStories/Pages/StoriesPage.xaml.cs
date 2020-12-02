using InstagramStories.Models;
using InstagramStories.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InstagramStories.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StoriesPage : ContentPage
    {
        public StoriesPage(UserStories currentUser, List<UserStories> stories)
        {
            this.BindingContext = new StoriesViewmodel(currentUser, stories);
            InitializeComponent();
        }
    }
}