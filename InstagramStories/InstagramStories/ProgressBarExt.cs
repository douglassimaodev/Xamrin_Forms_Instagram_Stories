using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace InstagramStories
{
    class ProgressBarExt : ProgressBar
    {
        public static readonly BindableProperty MinimumProgressProperty =
            BindableProperty.Create(nameof(MinimumProgress), typeof(int), typeof(ProgressBarExt), 0, propertyChanged: ProgressChanged);

        public int MinimumProgress
        {
            set { SetValue(MinimumProgressProperty, value); }
            get { return (int)GetValue(MinimumProgressProperty); }
        }

        public static readonly BindableProperty ActualProgressProperty =
            BindableProperty.Create(nameof(ActualProgress), typeof(double), typeof(ProgressBarExt), 0d, propertyChanged: ProgressChanged);

        public double ActualProgress
        {
            set { SetValue(ActualProgressProperty, value); }
            get { return (double)GetValue(ActualProgressProperty); }
        }

        private static void ProgressChanged(object bindable, object newValue, object oldValue) {
            var progress = (bindable as ProgressBarExt);
            progress.Progress = progress.ActualProgress - progress.MinimumProgress;
        }
    }
}