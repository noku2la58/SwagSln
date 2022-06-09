using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Swag.swg;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Swag
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderPage : ContentPage
    {
        public OrderPage()
        {
            InitializeComponent();
        }
        //async void orderitems(object sender, EventArgs e)
        //{
        //await Navigation.PushAsync(new OrderPage()
        //    {
        //    BindingContext = new Swg1()

        //});

        async void orderitems(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrderPage()
            {
                BindingContext = new Swg1()
            });
        }


        private async void Button(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}