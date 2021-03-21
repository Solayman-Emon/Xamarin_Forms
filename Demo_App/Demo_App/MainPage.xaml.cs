using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demo_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            coverImage.Source = ImageSource.FromResource("Demo_App.images.brain.png");
            projectImage.Source = ImageSource.FromResource("Demo_App.images.img.png");
        }
    }
}
