using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_OOP
{
    public class PriorityInternationalShipment : InternationalShipment
    {
        public PriorityInternationalShipment(
            string trackingCode,
            string description,
            double weight,
            decimal deliveryFee,
            DeliveryAddress destination,
            string destinationCountry,
            decimal customsFee)
            : base(
                trackingCode,
                description,
                weight,
                deliveryFee,
                destination,
                destinationCountry,
                customsFee)
        {
        }

        public sealed override void GenerateCustomsReport()
        {
            Console.WriteLine("Priority Customs Report");
            Console.WriteLine("Tracking Code      : " + TrackingCode);
            Console.WriteLine("Destination Country: " + DestinationCountry);
            Console.WriteLine("Customs Fee        : " + CustomsFee + " EGP");
            Console.WriteLine("Priority Status    : HIGH PRIORITY");
        }
    }
}