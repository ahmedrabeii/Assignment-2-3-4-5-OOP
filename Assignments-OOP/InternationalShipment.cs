using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_OOP
{
    public class InternationalShipment : Shipment, ITrackable, IInsurable
    {
        public string DestinationCountry { get; set; }

        public decimal CustomsFee { get; set; }

        public InternationalShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination,
            string destinationCountry,
            decimal customsFee)
            : base(
                trackingCode,
                description,
                weight,
                deliveryFee,
                destination)
        {
            DestinationCountry = destinationCountry;

            if (customsFee >= 0)
            {
                CustomsFee = customsFee;
            }
        }

        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5) + CustomsFee;
            }
        }

        public override void PrintShipment()
        {
            Console.WriteLine("International Shipment");
            Console.WriteLine("Tracking Code      : " + TrackingCode);
            Console.WriteLine("Description        : " + Description);
            Console.WriteLine("Weight             : " + Weight + " KG");
            Console.WriteLine("Delivery Fee       : " + DeliveryFee + " EGP");
            Console.WriteLine("Destination        : " + Destination.GetFullAddress());
            Console.WriteLine("Destination Country: " + DestinationCountry);
            Console.WriteLine("Customs Fee        : " + CustomsFee + " EGP");
            Console.WriteLine("Estimated Cost     : " + EstimatedCost + " EGP");
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} has been Delivered.";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.12m;
        }
    }
}
