﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvGenerator.Models
{
    public class PersonalInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int  Age { get; set; }
        public string  Email { get; set; }
        public string Profile { get; set; }
        public string Role { get; set; }
        public string Phone { get; set; }
        public string FullName 
        {
            get
            { 
                return FirstName + " " + LastName; 
            } 
        }
    }
}
