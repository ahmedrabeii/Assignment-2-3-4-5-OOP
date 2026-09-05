using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_OOP
{
    public class ExpressShipment :
        Shipment,
        ITrackable,
        IInsurable
    {
        public decimal ExtraFee { get; set; }

        public ExpressShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination,
            decimal extraFee)
            : base(
                trackingCode,
                description,
                weight,
                deliveryFee,
                destination)
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
                return DeliveryFee +
                       (Weight * 5) +
                       ExtraFee;
            }
        }

        public override void PrintShipment()
        {
            Console.WriteLine("Express Shipment");
            Console.WriteLine("Tracking Code : " + TrackingCode);
            Console.WriteLine("Description   : " + Description);
            Console.WriteLine("Weight        : " + Weight + " KG");
            Console.WriteLine("Delivery Fee  : " + DeliveryFee + " EGP");
            Console.WriteLine("Extra Fee     : " + ExtraFee + " EGP");
            Console.WriteLine(
                "Destination   : " +
                Destination.GetFullAddress()
            );
            Console.WriteLine(
                "Estimated Cost: " +
                EstimatedCost +
                " EGP"
            );
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is {CurrentTrackingStatus}.";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08m;
        }
    }
}
