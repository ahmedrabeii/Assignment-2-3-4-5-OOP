using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_OOP
{
    public static class ShipmentExtensions
    {
        public static string GetSummary(
            this Shipment shipment)
        {
            string shipmentType =
                shipment.GetType().Name
                        .Replace("Shipment", "");

            string trackingStatus =
                shipment.GetTrackingStatusForExtension();

            return
                $"{shipment.TrackingCode} | " +
                $"{shipmentType} | " +
                $"{shipment.Weight} KG | " +
                $"{trackingStatus}";
        }

        public static bool IsDelivered(
            this Shipment shipment)
        {
            return shipment
                .GetTrackingStatusForExtension()
                .Equals(
                    "Delivered",
                    System.StringComparison.OrdinalIgnoreCase
                );
        }
    }
}
