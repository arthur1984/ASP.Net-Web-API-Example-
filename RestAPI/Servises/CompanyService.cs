using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestAPI.Models;

namespace RestAPI.Servises
{
    public class CompanyService
    {
        public static bool Create(Company company)
        {
            bool result = false;
            try
            {
                //Call create company method
                result = true;
            }
            catch
            {

            }
            return result;
        }
    }
}