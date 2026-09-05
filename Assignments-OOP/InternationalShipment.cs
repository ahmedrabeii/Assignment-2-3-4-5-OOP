using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_OOP
{
    internal class InternationalShipment : Shipment

    {
        public string DestinationCountry { get; set; }
        public decimal CustomsFee { get; set; }
        public InternationalShipment(
          string trackingCode,
          string description,
          double weight,
          decimal deliveryFee,
          DeliveryAddress destination,
          string DestinationCountry,
          decimal CustomsFee)
           : base(trackingCode, description, weight, deliveryFee, destination)
        {

            if (!string.IsNullOrWhiteSpace(DestinationCountry))
            {
                this.DestinationCountry = DestinationCountry;
            }
            if (CustomsFee >= 0)
            {
                this.CustomsFee = CustomsFee;
            }
        }


        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + ((decimal)Weight * 5)+CustomsFee;
            }    
        }
    }
}
