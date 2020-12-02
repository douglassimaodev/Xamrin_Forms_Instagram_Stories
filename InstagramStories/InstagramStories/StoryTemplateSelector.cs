using InstagramStories.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace InstagramStories
{
    class StoryTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ImageTemplate { get; set; }
        public DataTemplate VideoTemplate { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if(item != null)
            {
                var story = item as Story;
                if (story.StorySource.Contains("mp4"))
                    return VideoTemplate;
                return ImageTemplate;
            }
            return ImageTemplate;
        }
    }
}
