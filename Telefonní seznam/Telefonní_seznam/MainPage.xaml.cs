using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Telefonní_seznam
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            List<Contact> contacts = CreateContacts();
            ContactsListView.ItemsSource = contacts;
        }

        private List<Contact> CreateContacts()
        {
            List<Contact> contacts = new List<Contact>();
            int pocet_osob = 8;
            for (int i = 0; i < pocet_osob; i++)
            {
                contacts.Add(new Contact("Vítek", "Horejš" + i, i + 605886200, "blank-profile-picture-973460_960_720.png"));
            }
            return contacts;
        }

        public void Open_CallPage(Object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new CallPage());
        }

        private void GetContact(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushModalAsync(new DetailPage(e.Item as Contact));
        }
    }
}
