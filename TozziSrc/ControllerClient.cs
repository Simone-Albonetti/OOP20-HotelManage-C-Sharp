using System;
using System.Collections.Generic;
using System.Text;

namespace TozziSrc
{
    public class ControllerClient
    {
        List<Client> list = new List<Client>();

        public List<Client> GetAllClient() => list;

        public void InsertClient(string n, string s, string i)
        {
            list.Add(new Client(n, s, i));
        }

        public Client GetClient(string id)
        {
            foreach (Client i in list)
            {
                if (i.Id.Equals(id))
                {
                    return i;
                }
            }
            return null;
        }

        public bool SearchClient(string id)
        {
            if (GetClient(id) != null)
            {
                return true;
            }
            return false;
        }

        public bool DeleteClient(string id)
        {
            var i = GetClient(id);
            if (i != null)
            {
                list.Remove(i);
                return true;
            }
            return false;
        }


    }
}
