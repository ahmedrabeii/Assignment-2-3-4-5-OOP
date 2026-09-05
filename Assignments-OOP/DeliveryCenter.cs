using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_OOP
{
    public class DeliveryCenter
    {
        public string CenterName { get; set; }

        public Driver Driver { get; set; }

        private Shipment[] shipments;

        public DeliveryCenter()
        {
            shipments = new Shipment[20];
        }

        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < 20)
                {
                    return shipments[index];
                }

                return null;
            }

            set
            {
                if (index >= 0 && index < 20)
                {
                    shipments[index] = value;
                }
            }
        }

        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < 20; i++)
                {
                    if (shipments[i] != null &&
                        shipments[i].TrackingCode ==
                        trackingCode)
                    {
                        return shipments[i];
                    }
                }

                return null;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < 20; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }

            return false;
        }

        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < 20; i++)
            {
                if (shipments[i] != null &&
                    shipments[i].TrackingCode ==
                    trackingCode)
                {
                    shipments[i] = null;
                    return true;
                }
            }

            return false;
        }

        public void PrintAllShipments()
        {
            for (int i = 0; i < 20; i++)
            {
                if (shipments[i] != null)
                {
                    shipments[i].PrintShipment();

                    Console.WriteLine(
                        "------------------------------------------"
                    );
                }
            }
        }

        public void PrintTrackingStatuses()
        {
            for (int i = 0; i < 20; i++)
            {
                if (shipments[i] != null)
                {
                    ITrackable shipment =
                        shipments[i] as ITrackable;

                    if (shipment != null)
                    {
                        Console.WriteLine(
                            shipment.GetTrackingStatus()
                        );
                    }
                }
            }
        }
    }
}
