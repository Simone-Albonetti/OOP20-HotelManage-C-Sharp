using System;

namespace TozziSrc
{
    public class Client
    {
        private string name;
        private string surname;
        private string id;

        public Client(String i)
        {
            String[] parts = i.Split(".");
            this.name = parts[0];
            this.surname = parts[1];
            this.id = parts[2];
        }

        public Client(string n, string s, string i)
        {
            this.name = n;
            this.surname = s;
            this.id = i;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Surname
        {
            get { return this.Surname; }
            set { this.Surname = value; }
        }

        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
    }
}
