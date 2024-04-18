using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Generators
{
    public class LootingOrderUniqueIdentiferGenerator
    {
        public static string GenerateLootingOrderUniqueIdentifer(int sellerId,int sellerAddressId)
        {
            var currentTime = DateTime.UtcNow;
            var randomPart = new Random().Next(1000, 9999);
            return $"{sellerId}-{sellerAddressId}-{currentTime:yyyyMMddHHmmss}{randomPart}";
        }
    }
}
