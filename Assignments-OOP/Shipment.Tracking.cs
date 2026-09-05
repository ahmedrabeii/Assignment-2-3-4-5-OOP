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
        private string trackingStatus = "Ready";

        public string CurrentTrackingStatus
        {
            get
            {
                return trackingStatus;
            }
        }

        public string GetTrackingStatusForExtension()
        {
            return trackingStatus;
        }

        public void UpdateTrackingStatus(string newStatus)
        {
            if (!string.IsNullOrWhiteSpace(newStatus))
            {
                trackingStatus = newStatus;

                OnTrackingStatusChanged(newStatus);
            }
        }

        partial void OnTrackingStatusChanged(
            string newStatus);

        partial void OnTrackingStatusChanged(
            string newStatus)
        {
            Console.WriteLine(
                "Tracking status changed to: " +
                newStatus
            );
        }
    }
}
