namespace Assignments_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 : Theoretical Questions
            #region Question 1
            //a:
            //class    -    struct
            //refrence type - value type
            //store data in heap - store data in stack
            //6 access modifier - 3 access modifier
            //supports 4 principles of OOP -  supports 1

            //b:Because the class supports 4 principles of OOP
            #endregion

            #region Question 2
            //a:Shipment
            //b:ExpressShipment
            //c:TrackingCode
            //d:is a mechanism that allows one class to inherit the properties and behaviors of another class.
            #endregion

            #endregion


            #region Part 02 : Practical
 
                // 1. Create DeliveryCenter
                DeliveryCenter center = new DeliveryCenter();

                // 2. Read center name
                Console.Write("Enter Center Name: ");
                center.CenterName = Console.ReadLine();

                // =========================
                // Standard Shipment
                // =========================

                Console.WriteLine("\n--- Standard Shipment ---");

                Console.Write("Tracking Code: ");
                string trackingCode1 = Console.ReadLine();

                Console.Write("Description: ");
                string description1 = Console.ReadLine();

                Console.Write("Weight: ");
                double weight1 = double.Parse(Console.ReadLine());

                Console.Write("Delivery Fee: ");
                decimal deliveryFee1 = decimal.Parse(Console.ReadLine());

                Console.Write("City: ");
                string city1 = Console.ReadLine();

                Console.Write("Street: ");
                string street1 = Console.ReadLine();

                Console.Write("Building Number: ");
                int buildingNumber1 = int.Parse(Console.ReadLine());

                DeliveryAddress address1 =
                    new DeliveryAddress(city1, street1, buildingNumber1);

                StandardShipment standardShipment =
                    new StandardShipment(
                        trackingCode1,
                        description1,
                        weight1,
                        deliveryFee1,
                        address1
                    );


                // =========================
                // Express Shipment
                // =========================

                Console.WriteLine("\n--- Express Shipment ---");

                Console.Write("Tracking Code: ");
                string trackingCode2 = Console.ReadLine();

                Console.Write("Description: ");
                string description2 = Console.ReadLine();

                Console.Write("Weight: ");
                double weight2 = double.Parse(Console.ReadLine());

                Console.Write("Delivery Fee: ");
                decimal deliveryFee2 = decimal.Parse(Console.ReadLine());

                Console.Write("City: ");
                string city2 = Console.ReadLine();

                Console.Write("Street: ");
                string street2 = Console.ReadLine();

                Console.Write("Building Number: ");
                int buildingNumber2 = int.Parse(Console.ReadLine());

                Console.Write("Extra Fee: ");
                decimal extraFee = decimal.Parse(Console.ReadLine());

                DeliveryAddress address2 =
                    new DeliveryAddress(city2, street2, buildingNumber2);

                ExpressShipment expressShipment =
                    new ExpressShipment(
                        trackingCode2,
                        description2,
                        weight2,
                        deliveryFee2,
                        address2,
                        extraFee
                    );


                // =========================
                // International Shipment
                // =========================

                Console.WriteLine("\n--- International Shipment ---");

                Console.Write("Tracking Code: ");
                string trackingCode3 = Console.ReadLine();

                Console.Write("Description: ");
                string description3 = Console.ReadLine();

                Console.Write("Weight: ");
                double weight3 = double.Parse(Console.ReadLine());

                Console.Write("Delivery Fee: ");
                decimal deliveryFee3 = decimal.Parse(Console.ReadLine());

                Console.Write("City: ");
                string city3 = Console.ReadLine();

                Console.Write("Street: ");
                string street3 = Console.ReadLine();

                Console.Write("Building Number: ");
                int buildingNumber3 = int.Parse(Console.ReadLine());

                Console.Write("Destination Country: ");
                string destinationCountry = Console.ReadLine();

                Console.Write("Customs Fee: ");
                decimal customsFee = decimal.Parse(Console.ReadLine());

                DeliveryAddress address3 =
                    new DeliveryAddress(city3, street3, buildingNumber3);

                InternationalShipment internationalShipment =
                    new InternationalShipment(
                        trackingCode3,
                        description3,
                        weight3,
                        deliveryFee3,
                        address3,
                        destinationCountry,
                        customsFee
                    );


                // 7. Add shipments to DeliveryCenter
                center.AddShipment(standardShipment);
                center.AddShipment(expressShipment);
                center.AddShipment(internationalShipment);


                // 8. Print all shipments
                Console.WriteLine("\n==============================");
                Console.WriteLine("All Shipments");
                Console.WriteLine("==============================");

                center.PrintAllShipments();


                // 9. Search using tracking code indexer
                Console.Write("\nEnter Tracking Code to Search: ");
                string searchCode = Console.ReadLine();

                Shipment searchedShipment = center[searchCode];

                if (searchedShipment != null)
                {
                    Console.WriteLine("\nShipment Found:");
                    searchedShipment.PrintShipment();
                }
                else
                {
                    Console.WriteLine("\nShipment Not Found.");
                }


                // 10. Remove shipment using tracking code
                Console.Write("\nEnter Tracking Code to Remove: ");
                string removeCode = Console.ReadLine();

                bool removed = center.RemoveShipment(removeCode);

                if (removed)
                {
                    Console.WriteLine("Shipment Removed Successfully.");
                }
                else
                {
                    Console.WriteLine("Shipment Not Found.");
                }


                // 11. Print remaining shipments
                Console.WriteLine("\n==============================");
                Console.WriteLine("Remaining Shipments");
                Console.WriteLine("==============================");

                center.PrintAllShipments();
            }
        }
    }
            #endregion

