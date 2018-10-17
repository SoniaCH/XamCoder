using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamCoder
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Menu : ContentPage
	{
        private double _raduis;
        public double Raduis
        {
            get { return _raduis; }
            set { _raduis = value;OnPropertyChanged(); }
        }
        private double _raduisTwo;
        public double RaduisTwo
        {
            get { return _raduisTwo; }
            set { _raduisTwo = value; OnPropertyChanged(); }
        }
        private double _smallRaduis;
        public double SmallRaduis
        {
            get { return _smallRaduis; }
            set { _smallRaduis = value; OnPropertyChanged(); }
        }
        private double _halfRaduis;
        public double HalfRaduis
        {
            get { return _halfRaduis; }
            set { _halfRaduis = value; OnPropertyChanged(); }
        }
        private Thickness _padding;
        public Thickness Padding
        {
            get { return _padding; }
            set { _padding = value; OnPropertyChanged(); }
        }

        public Menu ()
		{
			InitializeComponent ();
            BindingContext = this;
            SmallRaduis = App.ScreenWidth / 10;
            Raduis = App.ScreenWidth - App.ScreenWidth / 5;
            RaduisTwo = Raduis + App.ScreenWidth / 5;
            HalfRaduis = RaduisTwo / 2;
            Padding = new Thickness(-(RaduisTwo / 2),SmallRaduis,0,0);
            box1.WidthRequest = HalfRaduis+ SmallRaduis;
            box2.WidthRequest = HalfRaduis + 2.35 * SmallRaduis;
            box3.WidthRequest = HalfRaduis + 3.35 * SmallRaduis;
            box5.WidthRequest = App.ScreenWidth - SmallRaduis-2;
            box7.WidthRequest = HalfRaduis + 3.35 * SmallRaduis; 
            box8.WidthRequest = HalfRaduis + 2.35 * SmallRaduis; 
            box9.WidthRequest = HalfRaduis + SmallRaduis; 
        }
	}
}