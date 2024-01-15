using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGitHub
{
    internal class Company
    {
        public string companyName;
        public int founded;
        public string location;
        public bool corporation;

        public Company(
            string compName,
            int yearFounded,
            string compLocation,
            bool compCorporation
            )
        {
            companyName = compName;
            founded = yearFounded;
            location = compLocation;
            corporation = compCorporation;
        }    

        public void DisplayCompanyInfo()
        {
            Console.WriteLine($"Name:{companyName}\nLocated in:{location}\nFounded: {founded}\nIs corporation: {corporation}");
        }

    }
}