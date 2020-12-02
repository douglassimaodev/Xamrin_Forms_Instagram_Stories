using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InstagramStories
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnimatedSwipeUp : Grid
    {
        Animation jiggle;

        public AnimatedSwipeUp()
        {
            InitializeComponent();

            jiggle = new Animation((v) =>
            {
                if (v < 50) 
                this.TranslationY = -v;
                else
                    this.TranslationY = -100 + v;
            }, 0, 100);

            jiggle.Commit(this, "jiggle", length: 1000, repeat: ()=>true);
        }
    }
}