using CarouselViewDemos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselViewDemos.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PeekInsetsPage : ContentPage
    {
        public PeekInsetsPage()
        {
            InitializeComponent();
            BindingContext = new MonkeysViewModel();
        }
    }
}