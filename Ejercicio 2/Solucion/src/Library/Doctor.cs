using System;
using System.Text;

namespace Library
{
    public class Doctor
    {
        public string Name;
        public string Specialty;

        public Doctor(string name, string specialty)
        {
            this.Name = name;
            this.Specialty = specialty;
        }

        public bool verifyData()
        {
            if (string.IsNullOrEmpty(this.Name) || (string.IsNullOrEmpty(this.Specialty)))
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
