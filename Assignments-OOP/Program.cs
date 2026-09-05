namespace Assignments_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions
            #region Question 1
            //a:
            //Method Overloading: It occurs when multiple methods have the same name but different parameters in the same class.
            //Method Overriding: It occurs when a derived class provides a new implementation for a method inherited from the base class.
            //b:
            //Static Binding: The method call is resolved at compile time. It is commonly associated with method overloading.
            //Dynamic Binding: The method call is resolved at runtime.It is commonly associated with method overriding and virtual methods.


            #endregion

            #region Question 2
            //a:The sealed keyword applied to a class prevents other classes from inheriting from it.

            //b:
            //A sealed class prevents other classes from inheriting from it.
            //A sealed method prevents further derived classes from overriding that method.

            //c:No, a sealed method cannot be overridden because the `sealed` keyword prevents further overriding of that method in derived classes.
            #endregion
            #endregion

            #region Part 02 — Practical

 
                // ==========================================
                // Delivery Center
                // ==========================================

                Console.WriteLine("==========================================");
                Console.WriteLine("        Delivery Center");
                Console.WriteLine("==========================================");

                Console.Write("Enter Center Name: ");
                string centerName = Console.ReadLine();

                // ==========================================
                // Driver
                // ==========================================

                Console.WriteLine("\n--- Driver Information ---");

                Console.Write("Enter Driver ID: ");
                int driverId = int.Parse(Console.ReadLine());

                Console.Write("Enter Driver Full Name: ");
                string driverName = Console.ReadLine();

                Console.Write("Enter Driver Phone Number: ");
                string driverPhone = Console.ReadLine();

                Driver driver = new Driver(
                    driverId,
                    driverName,
                    driverPhone
                );

                // ==========================================
                // Create Delivery Center
                // ==========================================

                DeliveryCenter center = new DeliveryCenter();

                center.CenterName = centerName;
                center.Driver = driver;

                // ==========================================
                // Standard Shipment
                // ==========================================

                Console.WriteLine("\n==========================================");
                Console.WriteLine("       Standard Shipment");
                Console.WriteLine("==========================================");

                Console.Write("Enter Tracking Code: ");
                string trackingCode1 = Console.ReadLine();

                Console.Write("Enter Description: ");
                string description1 = Console.ReadLine();

                Console.Write("Enter Weight: ");
                double weight1 = double.Parse(Console.ReadLine());

                Console.Write("Enter Delivery Fee: ");
                decimal deliveryFee1 = decimal.Parse(Console.ReadLine());

                Console.Write("Enter City: ");
                string city1 = Console.ReadLine();

                Console.Write("Enter Street: ");
                string street1 = Console.ReadLine();

                Console.Write("Enter Building Number: ");
                int buildingNumber1 = int.Parse(Console.ReadLine());

                DeliveryAddress address1 =
                    new DeliveryAddress(
                        city1,
                        street1,
                        buildingNumber1
                    );

                StandardShipment standardShipment =
                    new StandardShipment(
                        trackingCode1,
                        description1,
                        weight1,
                        deliveryFee1,
                        address1
                    );

                // ==========================================
                // Express Shipment
                // ==========================================

                Console.WriteLine("\n==========================================");
                Console.WriteLine("        Express Shipment");
                Console.WriteLine("==========================================");

                Console.Write("Enter Tracking Code: ");
                string trackingCode2 = Console.ReadLine();

                Console.Write("Enter Description: ");
                string description2 = Console.ReadLine();

                Console.Write("Enter Weight: ");
                double weight2 = double.Parse(Console.ReadLine());

                Console.Write("Enter Delivery Fee: ");
                decimal deliveryFee2 = decimal.Parse(Console.ReadLine());

                Console.Write("Enter City: ");
                string city2 = Console.ReadLine();

                Console.Write("Enter Street: ");
                string street2 = Console.ReadLine();

                Console.Write("Enter Building Number: ");
                int buildingNumber2 = int.Parse(Console.ReadLine());

                Console.Write("Enter Extra Fee: ");
                decimal extraFee = decimal.Parse(Console.ReadLine());

                DeliveryAddress address2 =
                    new DeliveryAddress(
                        city2,
                        street2,
                        buildingNumber2
                    );

                ExpressShipment expressShipment =
                    new ExpressShipment(
                        trackingCode2,
                        description2,
                        weight2,
                        deliveryFee2,
                        address2,
                        extraFee
                    );

                // ==========================================
                // International Shipment
                // ==========================================

                Console.WriteLine("\n==========================================");
                Console.WriteLine("     International Shipment");
                Console.WriteLine("==========================================");

                Console.Write("Enter Tracking Code: ");
                string trackingCode3 = Console.ReadLine();

                Console.Write("Enter Description: ");
                string description3 = Console.ReadLine();

                Console.Write("Enter Weight: ");
                double weight3 = double.Parse(Console.ReadLine());

                Console.Write("Enter Delivery Fee: ");
                decimal deliveryFee3 = decimal.Parse(Console.ReadLine());

                Console.Write("Enter City: ");
                string city3 = Console.ReadLine();

                Console.Write("Enter Street: ");
                string street3 = Console.ReadLine();

                Console.Write("Enter Building Number: ");
                int buildingNumber3 = int.Parse(Console.ReadLine());

                Console.Write("Enter Destination Country: ");
                string destinationCountry = Console.ReadLine();

                Console.Write("Enter Customs Fee: ");
                decimal customsFee = decimal.Parse(Console.ReadLine());

                DeliveryAddress address3 =
                    new DeliveryAddress(
                        city3,
                        street3,
                        buildingNumber3
                    );

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

                // ==========================================
                // Add Shipments
                // ==========================================

                center.AddShipment(standardShipment);
                center.AddShipment(expressShipment);
                center.AddShipment(internationalShipment);

                // ==========================================
                // Print Center Information
                // ==========================================

                Console.WriteLine("\n==========================================");
                Console.WriteLine("Delivery Center");
                Console.WriteLine("==========================================");

                Console.WriteLine("Center Name : " + center.CenterName);
                Console.WriteLine("Driver      : " + center.Driver.FullName);

                // ==========================================
                // Print All Shipments
                // ==========================================

                Console.WriteLine("\n==========================================");
                Console.WriteLine("All Shipments");
                Console.WriteLine("==========================================");

                center.PrintAllShipments();

                // ==========================================
                // Delivery Helper
                // ==========================================

                Console.WriteLine("\n==========================================");
                Console.WriteLine("Printing Using DeliveryHelper...");
                Console.WriteLine("==========================================");

                DeliveryHelper.PrintShipmentDetails(standardShipment);

                Console.WriteLine("------------------------------------------");

                DeliveryHelper.PrintShipmentDetails(expressShipment);

                Console.WriteLine("------------------------------------------");

                DeliveryHelper.PrintShipmentDetails(internationalShipment);

                // ==========================================
                // Update Weight
                // ==========================================

                Console.WriteLine("\n==========================================");
                Console.WriteLine("Updating Weight");
                Console.WriteLine("==========================================");

                Console.WriteLine("Original Weight : " + standardShipment.Weight + " KG");

                Console.Write("Enter New Weight: ");
                double newWeight = double.Parse(Console.ReadLine());

                // Overloading Version 1
                standardShipment.UpdateWeight(newWeight);

                Console.WriteLine(
                    "Updated Weight : " +
                    standardShipment.Weight +
                    " KG"
                );

                Console.Write("Enter Extra Packing Weight: ");
                double packingWeight = double.Parse(Console.ReadLine());

                // Overloading Version 2
                standardShipment.UpdateWeight(
                    standardShipment.Weight,
                    packingWeight
                );

                Console.WriteLine(
                    "Updated Weight After Packing : " +
                    standardShipment.Weight +
                    " KG"
                );

                // ==========================================
                // Shipment Array - Polymorphism
                // ==========================================

                Console.WriteLine("\n==========================================");
                Console.WriteLine("Printing Using Shipment[]");
                Console.WriteLine("==========================================");

                Shipment[] shipments =
                {
                standardShipment,
                expressShipment,
                internationalShipment
            };

                foreach (Shipment shipment in shipments)
                {
                    shipment.PrintShipment();

                    Console.WriteLine("------------------------------------------");
                }

                // ==========================================
                // Sealed Class Demonstration
                // ==========================================

                Console.WriteLine("\n==========================================");
                Console.WriteLine("Sealed Class Demonstration");
                Console.WriteLine("==========================================");

                Console.WriteLine(
                    "CompletedShipment is sealed, so no class can inherit from it."
                );

                // Example:
                // class AnotherShipment : CompletedShipment
                // {
                // }
                //
                // This will cause a compilation error
                // because CompletedShipment is sealed.

                // ==========================================
                // Sealed Method Demonstration
                // ==========================================

                Console.WriteLine("\n==========================================");
                Console.WriteLine("Sealed Method Demonstration");
                Console.WriteLine("==========================================");

                Console.WriteLine(
                    "PriorityInternationalShipment seals GenerateCustomsReport()."
                );

                Console.WriteLine(
                    "Any further derived class cannot override that method."
                );

                // ==========================================
                // End
                // ==========================================

                Console.WriteLine("\n==========================================");
                Console.WriteLine("Program Finished");
                Console.WriteLine("==========================================");

                Console.ReadKey();
            }
        }
    }
            #endregion

