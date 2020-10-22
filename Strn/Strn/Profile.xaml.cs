using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Strn
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Profile : ContentPage
    {
        public Profile()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            List<Details> ListViewDetails = new List<Details>()
            {
                new Details(){Picture = "LogoBlack.png", Heading = "Name", Body = "Ulelu Israel"},
                new Details(){Picture = "LogoBlack.png", Heading = "Email", Body = "UleluIsrael@gmail.com"},
                new Details(){Picture = "LogoBlack.png", Heading = "Mobile", Body = "+2345677890"},
            };
            DetailsList.ItemsSource = ListViewDetails;
        }

        public void ImageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }

    public class Details
    {
        public string Picture { get; set; }
        public string Heading { get; set; }
        public string Body { get; set; }
    }
}