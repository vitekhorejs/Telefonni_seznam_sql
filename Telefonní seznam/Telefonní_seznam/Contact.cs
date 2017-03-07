using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefonní_seznam
{
    public class Contact
    {
        public Contact(string firstname, string surname, int number, string image)
        {
            _firstname = firstname;
            _surname = surname;
            _number = number;
            _image = image;
        }

        public string GetName => Firstname + " " + Surname;
        public int GetNumber => Number;
        public string GetImage => Image;

        private string _firstname;
        private string _surname;
        private int _number;
        private string _image;

        public string Firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }
        
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
     
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }
        
        public string Image
        {
            get { return _image; }
            set { _image = value; }
        }
    }
}
