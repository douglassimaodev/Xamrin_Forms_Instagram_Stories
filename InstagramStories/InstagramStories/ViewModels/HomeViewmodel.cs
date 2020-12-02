using InstagramStories.Models;
using InstagramStories.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace InstagramStories.ViewModels
{
    class HomeViewmodel
    {
        private INavigation navigation;
        public List<UserStories> Stories { get; set; }

        public ICommand UserSelectedCommand { get; set; }

        public HomeViewmodel(INavigation navigation)
        {
            this.navigation = navigation;
            Stories = new List<UserStories>()
            {
                new UserStories()
                {
                    UserId = "1",
                    UserProfile = "Tom",
                    Stories = new ObservableCollection<Story>()
                    {
                        new Story(){StorySource = "https://nikhileshwar96.github.io/Showcase/sunflower.jpg", Index = 0},
                        new Story(){StorySource = "http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ForBiggerEscapes.mp4", Index = 1},
                        new Story(){StorySource = "https://nikhileshwar96.github.io/Showcase/sunflower.jpg", Index = 2},
                        new Story(){StorySource = "http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ForBiggerEscapes.mp4", Index = 3},
                        new Story(){StorySource = "https://nikhileshwar96.github.io/Showcase/sunflower.jpg", Index = 4},
                        new Story(){StorySource = "http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ForBiggerEscapes.mp4", Index = 5},
                    },
                    CurrentStories = new ObservableCollection<Story>()
                    {
                        new Story(){StorySource = "https://nikhileshwar96.github.io/Showcase/sunflower.jpg"},
                    }
                },

                new UserStories()
                {
                    UserId = "2",
                    UserProfile = "Ben",
                    Stories = new ObservableCollection<Story>()
                    {
                        new Story(){StorySource = "http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ForBiggerEscapes.mp4"},
                    },
                    CurrentStories = new ObservableCollection<Story>()
                    {
                        new Story(){StorySource = "https://nikhileshwar96.github.io/Showcase/sunflower.jpg"},
                    }
                },

                new UserStories()
                {
                    UserId = "3",
                    UserProfile = "Ronald",
                    Stories = new ObservableCollection<Story>()
                    {
                        new Story(){StorySource = "https://nikhileshwar96.github.io/Showcase/sunflower.jpg"},
                    },
                },

                new UserStories()
                {
                    UserId = "4",
                    UserProfile = "Joe",
                    Stories = new ObservableCollection<Story>()
                    {
                        new Story(){StorySource = "http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ForBiggerEscapes.mp4"},
                    },
                   },
                new UserStories()
                {
                    UserId = "4",
                    UserProfile = "Someone",
                    Stories = new ObservableCollection<Story>()
                    {
                        new Story(){StorySource = "https://nikhileshwar96.github.io/Showcase/sunflower.jpg"},
                    },
                   },
                new UserStories()
                {
                    UserId = "4",
                    UserProfile = "User user",
                    Stories = new ObservableCollection<Story>()
                    {
                        new Story(){StorySource = "http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ForBiggerEscapes.mp4"},
                    },
                   },
                new UserStories()
                {
                    UserId = "4",
                    UserProfile = "Christopher",
                    Stories = new ObservableCollection<Story>()
                    {
                        new Story(){StorySource = "https://nikhileshwar96.github.io/Showcase/sunflower.jpg"},
                    },
                   },
                new UserStories()
                {
                    UserId = "4",
                    UserProfile = "Jhon",
                    Stories = new ObservableCollection<Story>()
                    {
                        new Story(){StorySource = "http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ForBiggerEscapes.mp4"},
                    },
                   },
            };

            UserSelectedCommand = new Command<UserStories>(NavigateToStories);
        }

        private void NavigateToStories(UserStories selectedUser)
        {
            this.navigation.PushModalAsync(new StoriesPage(selectedUser,this.Stories));
        }
    }
}
