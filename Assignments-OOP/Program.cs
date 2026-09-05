namespace Assignments_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions
            #region Questions 01 Object Copying
            //a:When one object variable is assigned to another, both variables refer to the same object in memory.

            //b:No. Assigning one object variable to another does not create a new object. It copies the reference, so both variables refer to the same object.

            //c:
            //Copying a reference means that two variables refer to the same object.
            //Copying an object means creating a separate object with copied data, so the two objects are independent.

            #endregion

            #region Questions 02 Shallow Copy vs Deep Copy
            //a:A Shallow Copy creates a new object and copies the values of its members. For reference-type members, it copies the references, not the referenced objects.

            //b:A Deep Copy creates a new object and also creates independent copies of the referenced objects, so the copied object does not share reference-type members with the original.

            //c:In a Shallow Copy, reference-type members are copied as references, so the original and copied objects share the same referenced objects.

            //d:In a Deep Copy, reference-type members are also copied into new independent objects, so the original and copied objects do not share them.

            //e:Deep Copy would be safer when copying an object that contains reference-type members and the copied object needs to be modified independently without affecting the original object.

            #endregion

            #region Questions 03 Static Members
            //a:
            //A static field belongs to the class itself and is shared by all objects of the class.
            //An instance field belongs to each object, so every object has its own copy.

            //b:
            //A static method belongs to the class rather than a specific object.
            //A static method cannot directly access instance members because instance members belong to a specific object.

            //c:A static constructor is used to initialize static members of a class. It is executed automatically once, before the class is first used.

            //d:A static class is a class that cannot be instantiated and is used to contain static members.
            //No, you cannot create an object from a static class.

            #endregion

            #region Questions 04 Extension Methods
            //a:An Extension Method allows you to add a new method to an existing type without modifying the original type or creating a derived class.

            //b:The this keyword must be used with the first parameter of an extension method.

            //c:An extension method must be declared as a static method inside a static class.

            //d:No, an extension method cannot directly access private members of the class it extends because it is not a member of that class.

            #endregion

            #region Questions 05 Partial Classes and Partial Methods
            //a:A Partial Class allows a class to be divided into multiple files. At compile time, all parts are combined into one class.

            //b:A developer may split a class into multiple files to organize the code, improve readability, and make a large class easier to maintain.

            //c:A Partial Method is a method declared in one part of a partial class and optionally implemented in another part of the same class.

            //d:If a partial method has no implementation, the compiler removes the method declaration and any calls to it from the compiled code, provided the partial method follows the rules that allow it to be unimplemented.
            #endregion
            #endregion

            #region Part 02 — Practical
   
                // ==========================================
                // SYSTEM TITLE
                // ==========================================

                DeliveryUtilities.PrintSystemTitle();

                // ==========================================
                // DELIVERY CENTER
                // ==========================================

                Console.WriteLine();
                Console.WriteLine("========== Delivery Center ==========");

                Console.Write("Enter Center Name: ");
                string centerName = Console.ReadLine();

                DeliveryCenter center =
                    new DeliveryCenter();

                center.CenterName = centerName;

                // ==========================================
                // DRIVER
                // ==========================================

                Console.WriteLine();
                Console.WriteLine("========== Driver Information ==========");

                Console.Write("Enter Driver ID: ");
                int driverId =
                    int.Parse(Console.ReadLine());

                Console.Write("Enter Driver Name: ");
                string driverName =
                    Console.ReadLine();

                Console.Write("Enter Driver Phone: ");
                string driverPhone =
                    Console.ReadLine();

                Driver driver =
                    new Driver(
                        driverId,
                        driverName,
                        driverPhone
                    );

                center.Driver = driver;

                // ==========================================
                // STANDARD SHIPMENT
                // ==========================================

                Console.WriteLine();
                Console.WriteLine(
                    "========== Standard Shipment =========="
                );

                Console.Write("Tracking Code: ");
                string standardTracking =
                    Console.ReadLine();

                Console.Write("Description: ");
                string standardDescription =
                    Console.ReadLine();

                Console.Write("Weight: ");
                decimal standardWeight =
                    decimal.Parse(Console.ReadLine());

                Console.Write("Delivery Fee: ");
                decimal standardFee =
                    decimal.Parse(Console.ReadLine());

                Console.Write("City: ");
                string standardCity =
                    Console.ReadLine();

                Console.Write("Street: ");
                string standardStreet =
                    Console.ReadLine();

                Console.Write("Building Number: ");
                int standardBuilding =
                    int.Parse(Console.ReadLine());

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
                Console.WriteLine(
                    "========== Express Shipment =========="
                );

                Console.Write("Tracking Code: ");
                string expressTracking =
                    Console.ReadLine();

                Console.Write("Description: ");
                string expressDescription =
                    Console.ReadLine();

                Console.Write("Weight: ");
                decimal expressWeight =
                    decimal.Parse(Console.ReadLine());

                Console.Write("Delivery Fee: ");
                decimal expressFee =
                    decimal.Parse(Console.ReadLine());

                Console.Write("Extra Fee: ");
                decimal extraFee =
                    decimal.Parse(Console.ReadLine());

                Console.Write("City: ");
                string expressCity =
                    Console.ReadLine();

                Console.Write("Street: ");
                string expressStreet =
                    Console.ReadLine();

                Console.Write("Building Number: ");
                int expressBuilding =
                    int.Parse(Console.ReadLine());

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
                Console.WriteLine(
                    "========== International Shipment =========="
                );

                Console.Write("Tracking Code: ");
                string internationalTracking =
                    Console.ReadLine();

                Console.Write("Description: ");
                string internationalDescription =
                    Console.ReadLine();

                Console.Write("Weight: ");
                decimal internationalWeight =
                    decimal.Parse(Console.ReadLine());

                Console.Write("Delivery Fee: ");
                decimal internationalFee =
                    decimal.Parse(Console.ReadLine());

                Console.Write("Destination Country: ");
                string destinationCountry =
                    Console.ReadLine();

                Console.Write("Customs Fee: ");
                decimal customsFee =
                    decimal.Parse(Console.ReadLine());

                Console.Write("City: ");
                string internationalCity =
                    Console.ReadLine();

                Console.Write("Street: ");
                string internationalStreet =
                    Console.ReadLine();

                Console.Write("Building Number: ");
                int internationalBuilding =
                    int.Parse(Console.ReadLine());

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
                // ADD SHIPMENTS
                // ==========================================

                center.AddShipment(standardShipment);
                center.AddShipment(expressShipment);
                center.AddShipment(internationalShipment);

                // ==========================================
                // TRACKING STATUS INPUT
                // ==========================================

                Console.WriteLine();
                Console.WriteLine(
                    "========== Tracking Status =========="
                );

                Console.Write(
                    "Enter Standard Status: "
                );

                standardShipment.UpdateTrackingStatus(
                    Console.ReadLine()
                );

                Console.Write(
                    "Enter Express Status: "
                );

                expressShipment.UpdateTrackingStatus(
                    Console.ReadLine()
                );

                Console.Write(
                    "Enter International Status: "
                );

                internationalShipment.UpdateTrackingStatus(
                    Console.ReadLine()
                );

                // ==========================================
                // PRINT SHIPMENTS
                // ==========================================

                Console.WriteLine();
                DeliveryUtilities.PrintSeparator();

                Console.WriteLine("Delivery Center");

                DeliveryUtilities.PrintSeparator();

                Console.WriteLine(
                    "Center Name: " +
                    center.CenterName
                );

                Console.WriteLine(
                    "Driver: " +
                    center.Driver.FullName
                );

                Console.WriteLine(
                    "Phone: " +
                    center.Driver.PhoneNumber
                );

                Console.WriteLine();

                center.PrintAllShipments();

                // ==========================================
                // OBJECT COPYING
                // ==========================================

                DeliveryUtilities.PrintSeparator();

                Console.WriteLine("Object Copying");

                DeliveryUtilities.PrintSeparator();

                Shipment shipment1 =
                    standardShipment;

                Shipment shipment2 =
                    shipment1;

                Console.WriteLine(
                    "Original Shipment : " +
                    shipment1.TrackingCode
                );

                Console.WriteLine(
                    "Assigned Shipment : " +
                    shipment2.TrackingCode
                );

                Console.WriteLine(
                    "Same Object : " +
                    Object.ReferenceEquals(
                        shipment1,
                        shipment2
                    )
                );

                // ==========================================
                // COPYSHIPMENT
                // ==========================================

                Console.WriteLine();
                Console.WriteLine(
                    "CopyShipment()"
                );

                Shipment copiedShipment =
                    shipment1.CopyShipment();

                Console.WriteLine(
                    "Original Shipment : " +
                    shipment1.TrackingCode
                );

                Console.WriteLine(
                    "Copied Shipment   : " +
                    copiedShipment.TrackingCode
                );

                Console.WriteLine(
                    "Same Object : " +
                    Object.ReferenceEquals(
                        shipment1,
                        copiedShipment
                    )
                );

                // ==========================================
                // SHALLOW COPY
                // ==========================================

                DeliveryUtilities.PrintSeparator();

                Console.WriteLine("Shallow Copy");

                DeliveryUtilities.PrintSeparator();

                Shipment shallowCopy =
                    shipment1.ShallowCopy();

                Console.WriteLine(
                    "Original Shipment Address : " +
                    shipment1.Destination.city
                );

                Console.WriteLine(
                    "Copied Shipment Address   : " +
                    shallowCopy.Destination.city
                );

                Console.WriteLine(
                    "Same Shipment Object : " +
                    Object.ReferenceEquals(
                        shipment1,
                        shallowCopy
                    )
                );

                Console.WriteLine(
                    "Same DeliveryAddress Object : " +
                    Object.ReferenceEquals(
                        shipment1.Destination,
                        shallowCopy.Destination
                    )
                );

                Console.WriteLine();
                Console.WriteLine(
                    "Changing copied shipment address..."
                );

                shallowCopy.Destination.city =
                    "Giza";

                Console.WriteLine(
                    "Original Shipment Address : " +
                    shipment1.Destination.city
                );

                Console.WriteLine(
                    "Copied Shipment Address   : " +
                    shallowCopy.Destination.city
                );

                // ==========================================
                // DEEP COPY
                // ==========================================

                DeliveryUtilities.PrintSeparator();

                Console.WriteLine("Deep Copy");

                DeliveryUtilities.PrintSeparator();

                // Restore original address
                shipment1.Destination =
                    new DeliveryAddress(
                        standardCity,
                        standardStreet,
                        standardBuilding
                    );

                Shipment deepCopy =
                    shipment1.DeepCopy();

                Console.WriteLine(
                    "Original Shipment Address : " +
                    shipment1.Destination.city
                );

                Console.WriteLine(
                    "Copied Shipment Address   : " +
                    deepCopy.Destination.city
                );

                Console.WriteLine(
                    "Same Shipment Object : " +
                    Object.ReferenceEquals(
                        shipment1,
                        deepCopy
                    )
                );

                Console.WriteLine(
                    "Same DeliveryAddress Object : " +
                    Object.ReferenceEquals(
                        shipment1.Destination,
                        deepCopy.Destination
                    )
                );

                Console.WriteLine();
                Console.WriteLine(
                    "Changing copied shipment address..."
                );

                deepCopy.Destination.city =
                    "Alexandria";

                Console.WriteLine(
                    "Original Shipment Address : " +
                    shipment1.Destination.city
                );

                Console.WriteLine(
                    "Copied Shipment Address   : " +
                    deepCopy.Destination.city
                );

                // ==========================================
                // EXTENSION METHODS
                // ==========================================

                DeliveryUtilities.PrintSeparator();

                Console.WriteLine("Extension Methods");

                DeliveryUtilities.PrintSeparator();

                Console.WriteLine(
                    standardShipment.GetSummary()
                );

                Console.WriteLine(
                    expressShipment.GetSummary()
                );

                Console.WriteLine(
                    internationalShipment.GetSummary()
                );

                Console.WriteLine();

                Console.WriteLine(
                    standardShipment.TrackingCode +
                    " Is Delivered : " +
                    standardShipment.IsDelivered()
                );

                Console.WriteLine(
                    internationalShipment.TrackingCode +
                    " Is Delivered : " +
                    internationalShipment.IsDelivered()
                );

                // ==========================================
                // TRACKING STATUS
                // ==========================================

                DeliveryUtilities.PrintSeparator();

                Console.WriteLine("Tracking Status");

                DeliveryUtilities.PrintSeparator();

                center.PrintTrackingStatuses();

                // ==========================================
                // INSURANCE
                // ==========================================

                DeliveryUtilities.PrintSeparator();

                Console.WriteLine("Insurance");

                DeliveryUtilities.PrintSeparator();

                DeliveryReport.PrintInsurance(
                    standardShipment
                );

                DeliveryReport.PrintInsurance(
                    expressShipment
                );

                DeliveryReport.PrintInsurance(
                    internationalShipment
                );

                // ==========================================
                // ITrackable ARRAY
                // ==========================================

                DeliveryUtilities.PrintSeparator();

                Console.WriteLine(
                    "ITrackable[] Polymorphism"
                );

                DeliveryUtilities.PrintSeparator();

                ITrackable[] trackableShipments =
                {
                standardShipment,
                expressShipment,
                internationalShipment
            };

                for (int i = 0;
                     i < trackableShipments.Length;
                     i++)
                {
                    Console.WriteLine(
                        trackableShipments[i]
                            .GetTrackingStatus()
                    );
                }

                // ==========================================
                // IInsurable ARRAY
                // ==========================================

                DeliveryUtilities.PrintSeparator();

                Console.WriteLine(
                    "IInsurable[] Polymorphism"
                );

                DeliveryUtilities.PrintSeparator();

                IInsurable[] insurableShipments =
                {
                standardShipment,
                expressShipment,
                internationalShipment
            };

                for (int i = 0;
                     i < insurableShipments.Length;
                     i++)
                {
                    Console.WriteLine(
                        "Insurance Cost: " +
                        insurableShipments[i]
                            .CalculateInsurance() +
                        " EGP"
                    );
                }

                // ==========================================
                // STATIC COUNTER
                // ==========================================

                DeliveryUtilities.PrintSeparator();

                Console.WriteLine(
                    "Static Shipment Counter"
                );

                DeliveryUtilities.PrintSeparator();

                Console.WriteLine(
                    "Total Shipments Created : " +
                    Shipment.GetTotalShipmentsCreated()
                );

                // ==========================================
                // PARTIAL METHOD
                // ==========================================

                DeliveryUtilities.PrintSeparator();

                Console.WriteLine("Partial Method");

                DeliveryUtilities.PrintSeparator();

                Console.Write(
                    "Enter new International Tracking Status: "
                );

                internationalShipment.UpdateTrackingStatus(
                    Console.ReadLine()
                );

                // ==========================================
                // FINISHED
                // ==========================================

                DeliveryUtilities.PrintSeparator();

                Console.WriteLine(
                    "Assignment Completed"
                );

                DeliveryUtilities.PrintSeparator();

                Console.ReadKey();
            }
        }
    }
            #endregion

