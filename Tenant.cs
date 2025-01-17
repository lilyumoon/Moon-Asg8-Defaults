using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moon_Asg8_Defaults
{
    public class Tenant : ITenant
    {

        /// <summary>
        /// ID is set when Tenant is added to the database
        /// </summary>
        public int ID { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdated { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public Tenant()
        {
            City = Properties.Settings.Default.DefaultCity;
            State = Properties.Settings.Default.DefaultState;
            Zip = Properties.Settings.Default.DefaultZip;
        }

        public override string ToString()
        {
            return $"{LastName}, {FirstName}";
        }

    }
}
