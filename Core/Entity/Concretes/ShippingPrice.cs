using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity.Concretes
{
    public class ShippingPrice : Entity
    {
        public int PackageId { get; set; }
        public double BasePrice { get; set; }
        public double WeightFactor { get; set; }
        public double VolumeFactor { get; set; }
        public double DistanceFactor { get; set; }
        public double UrgencyFactor { get; set; }

    }
}
