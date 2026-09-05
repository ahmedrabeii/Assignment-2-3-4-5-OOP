namespace Assignments_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions
            #region Questions01
            //a:Abstraction is the process of hiding unnecessary implementation details and showing only the essential features of an object.

            //b:Abstraction is one of the four pillars of OOP because it reduces complexity by hiding implementation details and exposing only the essential functionality. This makes programs easier to understand, use, and maintain.
            #endregion

            #region Questions02
            //a:
            //An abstract class is a base class that cannot be instantiated directly and can contain both abstract methods and implemented methods.
            //An interface defines a contract that a class must follow.A class can implement multiple interfaces, while it can inherit from only one abstract class.

            //b:I would choose an interface when I want to define a common contract or behavior that can be implemented by different and unrelated classes. Interfaces are also useful when a class needs to implement multiple behaviors.

            //c:No, a class cannot inherit from multiple abstract classes because C# supports single class inheritance.  Yes, a class can implement multiple interfaces.

            #endregion
            #endregion

            #region Part 02 — Practical

                Console.WriteLine("==========================================");
                Console.WriteLine("       Smart Delivery Management System");
                Console.WriteLine("==========================================");

                // ==========================================
                // DELIVERY CENTER
                // ==========================================

                Console.Write("Enter Delivery Center Name: ");
                string centerName = Console.ReadLine();

                DeliveryCenter center = new DeliveryCenter();
                center.CenterName = centerName;

                // ==========================================
                // DRIVER
                // ==========================================

                Console.WriteLine();
                Console.WriteLine("========== Driver Information ==========");

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

                center.Driver = driver;

                // ==========================================
                // STANDARD SHIPMENT
                // ==========================================

                Console.WriteLine();
                Console.WriteLine("========== Standard Shipment ==========");

                Console.Write("Tracking Code: ");
                string standardTracking = Console.ReadLine();

                Console.Write("Description: ");
                string standardDescription = Console.ReadLine();

                Console.Write("Weight: ");
                decimal standardWeight = decimal.Parse(Console.ReadLine());

                Console.Write("Delivery Fee: ");
                decimal standardFee = decimal.Parse(Console.ReadLine());

                Console.Write("City: ");
                string standardCity = Console.ReadLine();

                Console.Write("Street: ");
                string standardStreet = Console.ReadLine();

                Console.Write("Building Number: ");
                int standardBuilding = int.Parse(Console.ReadLine());

                DeliveryAddress standardAddress =
                    new DeliveryAddress(
                        standardCity,
                        standardStreet,
                        standardBuilding
                    );

                StandardShipment standardShipment =
                    new StandardShipment(
                        standardTracking,
                        standardDescription,
                        standardWeight,
                        standardFee,
                        standardAddress
                    );

                // ==========================================
                // EXPRESS SHIPMENT
                // ==========================================

                Console.WriteLine();
                Console.WriteLine("========== Express Shipment ==========");

                Console.Write("Tracking Code: ");
                string expressTracking = Console.ReadLine();

                Console.Write("Description: ");
                string expressDescription = Console.ReadLine();

                Console.Write("Weight: ");
                decimal expressWeight = decimal.Parse(Console.ReadLine());

                Console.Write("Delivery Fee: ");
                decimal expressFee = decimal.Parse(Console.ReadLine());

                Console.Write("Extra Fee: ");
                decimal extraFee = decimal.Parse(Console.ReadLine());

                Console.Write("City: ");
                string expressCity = Console.ReadLine();

                Console.Write("Street: ");
                string expressStreet = Console.ReadLine();

                Console.Write("Building Number: ");
                int expressBuilding = int.Parse(Console.ReadLine());

                DeliveryAddress expressAddress =
                    new DeliveryAddress(
                        expressCity,
                        expressStreet,
                        expressBuilding
                    );

                ExpressShipment expressShipment =
                    new ExpressShipment(
                        expressTracking,
                        expressDescription,
                        expressWeight,
                        expressFee,
                        expressAddress,
                        extraFee
                    );

                // ==========================================
                // INTERNATIONAL SHIPMENT
                // ==========================================

                Console.WriteLine();
                Console.WriteLine("========== International Shipment ==========");

                Console.Write("Tracking Code: ");
                string internationalTracking = Console.ReadLine();

                Console.Write("Description: ");
                string internationalDescription = Console.ReadLine();

                Console.Write("Weight: ");
                decimal internationalWeight = decimal.Parse(Console.ReadLine());

                Console.Write("Delivery Fee: ");
                decimal internationalFee = decimal.Parse(Console.ReadLine());

                Console.Write("Destination Country: ");
                string destinationCountry = Console.ReadLine();

                Console.Write("Customs Fee: ");
                decimal customsFee = decimal.Parse(Console.ReadLine());

                Console.Write("City: ");
                string internationalCity = Console.ReadLine();

                Console.Write("Street: ");
                string internationalStreet = Console.ReadLine();

                Console.Write("Building Number: ");
                int internationalBuilding = int.Parse(Console.ReadLine());

                DeliveryAddress internationalAddress =
                    new DeliveryAddress(
                        internationalCity,
                        internationalStreet,
                        internationalBuilding
                    );

                InternationalShipment internationalShipment =
                    new InternationalShipment(
                        internationalTracking,
                        internationalDescription,
                        internationalWeight,
                        internationalFee,
                        internationalAddress,
                        destinationCountry,
                        customsFee
                    );

                // ==========================================
                // ADD SHIPMENTS TO DELIVERY CENTER
                // ==========================================

                center.AddShipment(standardShipment);
                center.AddShipment(expressShipment);
                center.AddShipment(internationalShipment);

                // ==========================================
                // PRINT CENTER
                // ==========================================

                Console.WriteLine();
                Console.WriteLine("==========================================");
                Console.WriteLine("Delivery Center");
                Console.WriteLine("==========================================");

                Console.WriteLine("Center Name: " + center.CenterName);

                Console.WriteLine(
                    "Driver: " +
                    center.Driver.FullName +
                    " | Phone: " +
                    center.Driver.PhoneNumber
                );

                Console.WriteLine();

                // ==========================================
                // PRINT ALL SHIPMENTS
                // ==========================================

                Console.WriteLine("========== Shipment Details ==========");

                center.PrintAllShipments();

                // ==========================================
                // TRACKING STATUS
                // ==========================================

                Console.WriteLine();
                Console.WriteLine("==========================================");
                Console.WriteLine("Tracking Status");
                Console.WriteLine("==========================================");

                center.PrintTrackingStatuses();

                // ==========================================
                // INSURANCE
                // ==========================================

                Console.WriteLine();
                Console.WriteLine("==========================================");
                Console.WriteLine("Insurance");
                Console.WriteLine("==========================================");

                DeliveryReport.PrintInsurance(standardShipment);
                DeliveryReport.PrintInsurance(expressShipment);
                DeliveryReport.PrintInsurance(internationalShipment);

                // ==========================================
                // ITrackable ARRAY
                // ==========================================

                Console.WriteLine();
                Console.WriteLine("==========================================");
                Console.WriteLine("ITrackable[] Polymorphism");
                Console.WriteLine("==========================================");

                ITrackable[] trackableShipments =
                {
                standardShipment,
                expressShipment,
                internationalShipment
            };

                for (int i = 0; i < trackableShipments.Length; i++)
                {
                    Console.WriteLine(
                        trackableShipments[i].GetTrackingStatus()
                    );
                }

                // ==========================================
                // IInsurable ARRAY
                // ==========================================

                Console.WriteLine();
                Console.WriteLine("==========================================");
                Console.WriteLine("IInsurable[] Polymorphism");
                Console.WriteLine("==========================================");

                IInsurable[] insurableShipments =
                {
                standardShipment,
                expressShipment,
                internationalShipment
            };

                for (int i = 0; i < insurableShipments.Length; i++)
                {
                    Console.WriteLine(
                        "Insurance Cost: " +
                        insurableShipments[i].CalculateInsurance() +
                        " EGP"
                    );
                }

                // ==========================================
                // DELIVERY REPORT - ITrackable
                // ==========================================

                Console.WriteLine();
                Console.WriteLine("==========================================");
                Console.WriteLine("Delivery Report");
                Console.WriteLine("==========================================");

                DeliveryReport.PrintShipment(standardShipment);
                DeliveryReport.PrintShipment(expressShipment);
                DeliveryReport.PrintShipment(internationalShipment);

                // ==========================================
                // FINISHED
                // ==========================================

                Console.WriteLine();
                Console.WriteLine("==========================================");
                Console.WriteLine(
                    "Interface Polymorphism Demonstrated Successfully."
                );
                Console.WriteLine("==========================================");

                Console.ReadKey();
            }
        }
    }
            #endregion

