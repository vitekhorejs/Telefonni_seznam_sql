using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Telefonní_seznam
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage()
        {
            InitializeComponent();
        }

        public DetailPage(Contact contact)
        {
            InitializeComponent();
            Name.Text = contact.GetName;
            Number.Text = contact.GetNumber.ToString();
            Image.Source = contact.GetImage;
        }

        public void Back(Object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }

        public void Call(Object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("tel:" + Number.Text));
        }
    }
}
