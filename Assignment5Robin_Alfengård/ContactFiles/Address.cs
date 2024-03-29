﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5Robin_Alfengård.ContactFiles
{
    public class Address
    {
        private string street;
        private string city;
        private string zipCode;
        private Country country;


        public Address(string street, Country country, string zipCode, string city)
        {
            this.street = street;
            this.city = city;
            this.zipCode = zipCode;
            this.country = country;
        }

        public Address(string street, string city, Country country)
            : this(street, country, "", city) { }

        public Address(string city, Country country)
            : this("", country, "", city) { }




        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }
        public Country Countries
        {
            get { return country; }
            set { country = value; }
        }
    }
}
