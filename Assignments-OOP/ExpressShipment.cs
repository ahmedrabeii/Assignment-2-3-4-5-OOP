using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_OOP
{
    public class ExpressShipment : Shipment
    {
        public decimal ExtraFee { get; set; }
        public ExpressShipment(
            string trackingCode,
            string description,
            double weight,
            decimal deliveryFee,
            DeliveryAddress destination,
            decimal extraFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {

            if (extraFee >= 0)
            {
                ExtraFee = extraFee;
            }
        }

        public override decimal EstimatedCost
        { 
            get
            {
                return DeliveryFee + ((decimal)Weight * 5) + ExtraFee;
            }
        }
    }
    }

