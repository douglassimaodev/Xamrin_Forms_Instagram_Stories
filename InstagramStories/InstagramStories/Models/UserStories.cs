using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace InstagramStories.Models
{
    public class UserStories
    {
        public string UserId { get; set; }

        public string UserProfile { get; set; }

        public ObservableCollection<Story> Stories { get; set; }

        public ObservableCollection<Story> CurrentStories { get; set; } = new ObservableCollection<Story>();

        public int CurrentIndex { get; set; } = 0;
    }
}
