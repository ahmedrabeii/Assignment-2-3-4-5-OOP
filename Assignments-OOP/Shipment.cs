using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        // Composition
        public DeliveryAddress Destination { get; set; }

        // Virtual property
        public virtual decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + ((decimal)Weight * 5);
            }
        }

        // Constructor
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

        // Full Constructor
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

        // Update Delivery Fee
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee >= 0)
            {
                DeliveryFee = newFee;
            }
        }

        // Method Overloading - Version 1
        public void UpdateWeight(double newWeight)
        {
            if (newWeight > 0)
            {
                Weight = newWeight;
            }
        }

        // Method Overloading - Version 2
        public void UpdateWeight(double newWeight, double extraPackingWeight)
        {
            if (newWeight > 0 && extraPackingWeight >= 0)
            {
                Weight = newWeight + extraPackingWeight;
            }
        }

        // Virtual Method
        public virtual void PrintShipment()
        {
            Console.WriteLine("Tracking Code : " + TrackingCode);
            Console.WriteLine("Description   : " + Description);
            Console.WriteLine("Weight        : " + Weight + " KG");
            Console.WriteLine("Delivery Fee  : " + DeliveryFee + " EGP");
            Console.WriteLine("Destination   : " + Destination.GetFullAddress());
            Console.WriteLine("Estimated Cost: " + EstimatedCost + " EGP");
        }
    }
}