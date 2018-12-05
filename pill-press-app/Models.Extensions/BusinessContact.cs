﻿using Gov.Jag.PillPressRegistry.Interfaces.Models;
using Gov.Jag.PillPressRegistry.Public.ViewModels;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gov.Jag.PillPressRegistry.Public.Models
{
    /// <summary>
    /// ViewModel transforms.
    /// </summary>
    public static class BusinessContactExtensions
    {
        /// <summary>
        /// Convert a given BusinessContact to a ViewModel
        /// </summary>        
        public static ViewModels.BusinessContact ToViewModel(this MicrosoftDynamicsCRMbcgovBusinesscontact businessContact)
        {
            ViewModels.BusinessContact result = null;
            if (businessContact != null)
            {
                result = new ViewModels.BusinessContact();
                if (businessContact.BcgovBusinesscontactid != null)
                {
                    result.id = businessContact.BcgovBusinesscontactid;
                }
                result.jobtitle = businessContact.BcgovJobtitle;

                if (businessContact.BcgovContacttype != null)
                {
                    result.contacttype = (ContactTypeCodes) businessContact.BcgovContacttype;
                }                

            }
            return result;
        }

        public static void CopyValues(this MicrosoftDynamicsCRMbcgovBusinesscontact to, ViewModels.BusinessContact from)
        {
            to.BcgovJobtitle = from.jobtitle;
            to.BcgovContacttype = (int?) from.contacttype;
                        
        }

    }
}
