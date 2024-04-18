using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Generators
{
    public class WaybillNumberGenerator
    {
        public static string GenerateWaybillNumber()
        {
            var timestamp = DateTime.UtcNow.Ticks;
            var randomNumber = new Random().Next(1000, 9999);
            return $"WB-{timestamp}-{randomNumber}";
        }
    }
}
