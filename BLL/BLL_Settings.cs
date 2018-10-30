using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Settings
    {
        private string GetString(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}
