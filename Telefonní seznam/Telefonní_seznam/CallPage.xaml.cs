using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Telefonní_seznam
{
    public partial class CallPage : ContentPage
    {
        public CallPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// funkce která je zavolána stisknutím tačítka Kontakty a vratí na hlavní stránku
        /// </summary>
        public void Open_MainPage(Object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }

        /// <summary>
        /// funkce pro volání vybraného čísla
        /// </summary>
        public void Call(Object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("tel:" + Number.Text));
        }
    }
}
