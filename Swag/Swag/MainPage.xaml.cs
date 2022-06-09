using Swag.orderitems;
using Swag.swg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Swag
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new Swg1();

        }

        private async void SaveButton_Clicked(object sender, EventArgs e)
        {
            OrderDatabase database = OrderDatabase.Database;

            Swg1 item = BindingContext as Swg1;

            await database.SaveSwagItemAsync(item);

        }
    }
}
