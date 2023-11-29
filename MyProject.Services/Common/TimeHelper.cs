using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Common
{
    public static class TimeHelper
    {
        public static DateTime GetTime()
        {
            return DateTime.UtcNow.AddHours(5);
        }
    }
}
