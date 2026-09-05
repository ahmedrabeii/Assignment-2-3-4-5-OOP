using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Assignments_OOP
{
    public abstract partial class Shipment
    {
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;

        // ==========================================
        // STATIC FIELD
        // ==========================================

        public static int TotalShipmentsCreated;

        // ==========================================
        // STATIC CONSTRUCTOR
        // ==========================================

        static Shipment()
        {
            TotalShipmentsCreated = 0;

            Console.WriteLine("Shipment System Initialized");
        }

        // ==========================================
        // PROPERTIES
        // ==========================================

        public string TrackingCode
        {
            get
            {
                return trackingCode;
            }

            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    trackingCode = value;
                }
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    description = value;
                }
            }
        }

        public decimal Weight
        {
            get
            {
                return weight;
            }

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
            get
            {
                return deliveryFee;
            }

            private set
            {
                if (value >= 0)
                {
                    deliveryFee = value;
                }
            }
        }

        public DeliveryAddress Destination { get; set; }

        // ==========================================
        // ABSTRACT MEMBERS
        // ==========================================

        public abstract decimal EstimatedCost
        {
            get;
        }

        public abstract void PrintShipment();

        // ==========================================
        // CONSTRUCTOR
        // ==========================================

        public Shipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;

            TotalShipmentsCreated++;
        }

        // ==========================================
        // UPDATE DELIVERY FEE
        // ==========================================

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee >= 0)
            {
                DeliveryFee = newFee;
            }
        }

        // ==========================================
        // UPDATE WEIGHT
        // ==========================================

        public void UpdateWeight(decimal newWeight)
        {
            if (newWeight > 0)
            {
                Weight = newWeight;
            }
        }

        // ==========================================
        // OVERLOADED UPDATE WEIGHT
        // ==========================================

        public void UpdateWeight(
            decimal newWeight,
            decimal extraPackingWeight)
        {
            if (newWeight > 0 && extraPackingWeight >= 0)
            {
                Weight = newWeight + extraPackingWeight;
            }
        }

        // ==========================================
        // COPY SHIPMENT
        // ==========================================

        public Shipment CopyShipment()
        {
            return DeepCopy();
        }

        // ==========================================
        // SHALLOW COPY
        // ==========================================

        public Shipment ShallowCopy()
        {
            return (Shipment)this.MemberwiseClone();
        }

        // ==========================================
        // DEEP COPY
        // ==========================================

        public Shipment DeepCopy()
        {
            DeliveryAddress newAddress =
                new DeliveryAddress(
                    Destination.city,
                    Destination.street,
                    Destination.buildingNumber
                );

            Shipment copy;

            if (this is StandardShipment)
            {
                copy = new StandardShipment(
                    TrackingCode,
                    Description,
                    Weight,
                    DeliveryFee,
                    newAddress
                );
            }
            else if (this is ExpressShipment express)
            {
                copy = new ExpressShipment(
                    TrackingCode,
                    Description,
                    Weight,
                    DeliveryFee,
                    newAddress,
                    express.ExtraFee
                );
            }
            else if (this is InternationalShipment international)
            {
                copy = new InternationalShipment(
                    TrackingCode,
                    Description,
                    Weight,
                    DeliveryFee,
                    newAddress,
                    international.DestinationCountry,
                    international.CustomsFee
                );
            }
            else
            {
                throw new InvalidOperationException(
                    "Unknown shipment type."
                );
            }

            return copy;
        }

        // ==========================================
        // STATIC METHOD
        // ==========================================

        public static int GetTotalShipmentsCreated()
        {
            return TotalShipmentsCreated;
        }
    }
}