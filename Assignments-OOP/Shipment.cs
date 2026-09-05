using System;

namespace Assignments_OOP
{
    public class Shipment
    {
        private string trackingCode;
        private string description;
        private double weight;
        private decimal deliveryFee;

        public string TrackingCode
        {
            get { return trackingCode; }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    description = value;
                }
            }
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }
        }

        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            private set
            {
                if (value >= 0)
                {
                    deliveryFee = value;
                }
            }
        }

        public DeliveryAddress Destination { get; set; }

        public virtual decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + ((decimal)Weight * 5);
            }
        }

        public Shipment(string trackingCode)
        {
            this.trackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = new DeliveryAddress(
                "Unknown",
                "Unknown",
                0
            );
        }

        public Shipment(
            string trackingCode,
            string description,
            double weight,
            decimal deliveryFee,
            DeliveryAddress destination)
        {
            this.trackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee >= 0)
            {
                DeliveryFee = newFee;
            }
        }

        public void PrintShipment()
        {
            Console.WriteLine("Tracking Code: " + TrackingCode);
            Console.WriteLine("Description: " + Description);
            Console.WriteLine("Weight: " + Weight);
            Console.WriteLine("Delivery Fee: " + DeliveryFee);
            Console.WriteLine("Destination: " + Destination.GetFullAddress());
            Console.WriteLine("Estimated Cost: " + EstimatedCost);
            
        }
    }
}