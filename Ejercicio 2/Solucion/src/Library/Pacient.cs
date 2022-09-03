using System;
using System.Text;

namespace Library
{
    public class Patient
    {
        public string Name;
        public string Age;
        public string PhoneNumber;
        public string Id;

        public Patient(string name, string age, string phonenumber, string id)
        {
            this.Name = name;
            this.Age = age;
            this.PhoneNumber = phonenumber;
            this.Id = id;
        }

        public bool verifyData()
        {
            if (string.IsNullOrEmpty(this.Name) || (string.IsNullOrEmpty(this.Age)) || (string.IsNullOrEmpty(this.PhoneNumber)) || (string.IsNullOrEmpty(this.Id)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
