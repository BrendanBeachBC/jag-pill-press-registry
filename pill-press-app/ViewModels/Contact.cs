﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gov.Jag.PillPressRegistry.Public.ViewModels
{

    public enum ContactTypeEnum
    {        
        Primary = 931490000,
        Additional = 931490001,        
        BCeID = 931490002        
    }

    public class Contact
    {
        public string id { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string title { get; set; }

        public string phoneNumber { get; set; }

        public string phoneNumberAlt { get; set; }

        public string email { get; set; }

    }
}
