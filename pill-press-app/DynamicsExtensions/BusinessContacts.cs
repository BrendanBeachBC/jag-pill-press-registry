﻿
using Gov.Jag.PillPressRegistry.Interfaces.Models;
using Gov.Jag.PillPressRegistry.Public.Utils;
using Gov.Jag.PillPressRegistry.Public.ViewModels;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gov.Jag.PillPressRegistry.Interfaces
{
    public static class BusinessContactExtensions
    {

        /// <summary>
        /// Get a Account by their Guid
        /// </summary>
        /// <param name="system"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static void CreateBusinessContactLink(this IDynamicsClient system, ILogger _logger, string contactId, string accountId, string jobtitle, int? contactType)
        {

            MicrosoftDynamicsCRMbcgovBusinesscontact result = system.GetBusinessContactLink(contactId, accountId);

            if (result == null)
            {
                // create it.
                try
                {
                    result = new MicrosoftDynamicsCRMbcgovBusinesscontact()
                    {
                        BcgovJobtitle = jobtitle,
                        BcgovContacttype = contactType,
                        ContactODataBind = system.GetEntityURI("contacts", contactId),
                        AccountODataBind = system.GetEntityURI("accounts", accountId),
                    };
                    system.Businesscontacts.Create(result);
                }
                catch (OdataerrorException odee)
                {
                    _logger.LogError(LoggingEvents.Error, "Error while creating a business contact.");
                    _logger.LogError("Request:");
                    _logger.LogError(odee.Request.Content);
                    _logger.LogError("Response:");
                    _logger.LogError(odee.Response.Content);
                }
            }
        }

        public static MicrosoftDynamicsCRMbcgovBusinesscontact GetBusinessContactLink(this IDynamicsClient system, string contactId, string accountId)
        {
            MicrosoftDynamicsCRMbcgovBusinesscontact result = null;

            try
            {
                var businessContact = system.Businesscontacts.Get(filter: $"_bcgov_contact_value eq '{contactId}' and _bcgov_businessprofile_value eq '{accountId}'");
                result = businessContact.Value.FirstOrDefault();
            }
            catch (Exception)
            {
                result = null;
            }

            return result;
        }


        /// <summary>
        /// Delete any business contact links if they exist.
        /// </summary>
        /// <param name="system"></param>
        /// <param name="_logger"></param>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public static bool DeleteNonBceidBusinessContactLinkForAccount(this IDynamicsClient system, ILogger _logger, string accountId)
        {
            bool result = true;

            try
            {
                var businessContacts = system.Businesscontacts.Get(filter: $"_bcgov_businessprofile_value eq '{accountId}'");
                if (businessContacts.Value != null)
                {
                    foreach (MicrosoftDynamicsCRMbcgovBusinesscontact businessContact in businessContacts.Value)
                    {
                        if (businessContact.BcgovContacttype != (int?)ContactTypeEnum.BCeID)
                        {
                            try
                            {
                                system.Businesscontacts.Delete(businessContact.BcgovBusinesscontactid);
                            }
                            catch (OdataerrorException odee)
                            {
                                _logger.LogError(LoggingEvents.Error, "Error while deleting a business contact.");
                                _logger.LogError("Request:");
                                _logger.LogError(odee.Request.Content);
                                _logger.LogError("Response:");
                                _logger.LogError(odee.Response.Content);
                                result = false;
                            }
                        }
                    }
                }
                
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }

    }
}
