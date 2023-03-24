using AssetManagment.Data.Entities;

namespace AssetManagment.Data
{
    public static class AssetInitializer
    {
        public static void Initialize(AssetsContext context)
        {
            if (context.Devices.Any())
            {
                return;   // DB has been seeded
            }

            var contact = new Contact[]
            {
                new Contact{FullName = "John Smith",FirstName="John", LastName="Smith"},
                new Contact{FullName = "Jane Doe",FirstName="Jane", LastName="Doe"}
            };

            var location = new DeviceLocation[]
            {
                new DeviceLocation{DeviceLocationName="Auction"},
                new DeviceLocation{DeviceLocationName="Closet"},
                new DeviceLocation{DeviceLocationName="Conference"},
                new DeviceLocation{DeviceLocationName="Flex Cube"},
                new DeviceLocation{DeviceLocationName="Flex Office"},
                new DeviceLocation{DeviceLocationName="Huddle"},
                new DeviceLocation{DeviceLocationName="Recycle"},
                new DeviceLocation{DeviceLocationName="Repair"},
                new DeviceLocation{DeviceLocationName="User"}
            };

            context.DeviceLocations.AddRange(location);
            context.SaveChanges();

            var category = new DeviceCategory[]
            {
                new DeviceCategory{DeviceCategoryName="Cable"},
                new DeviceCategory{DeviceCategoryName="Docking Station"},
                new DeviceCategory{DeviceCategoryName="Headset"},
                new DeviceCategory{DeviceCategoryName="Keyboard Mouse"},
                new DeviceCategory{DeviceCategoryName="Laptop"},
                new DeviceCategory{DeviceCategoryName="Monitor"},
                new DeviceCategory{DeviceCategoryName="Power Cord"},
                new DeviceCategory{DeviceCategoryName="Printer"},
                new DeviceCategory{DeviceCategoryName="Video Conf Equip"},
                new DeviceCategory{DeviceCategoryName="Wall Display"},
                new DeviceCategory{DeviceCategoryName="Monitor 2"}
            };

            context.DeviceCategories.AddRange(category);
            context.SaveChanges();


            context.Contacts.AddRange(contact);
            context.SaveChanges();

            var devices = new Device[]
            {
                new Device{DeviceCategoryId=5,DeviceLocationId=9,Description="Surface Laptop",SerialNumber="123456789"},
                new Device{DeviceCategoryId=6,DeviceLocationId=9,Description="View Sonic Monitor",SerialNumber="VS123456789"},
                new Device{DeviceCategoryId=11,DeviceLocationId=9,Description="View Sonic Monitor",SerialNumber="VS987654321"},
                new Device{DeviceCategoryId=2,DeviceLocationId=9,Description="SURFACE DOCK 2",SerialNumber="SD987654321"},
                new Device{DeviceCategoryId=5,DeviceLocationId=9,Description="Surface Laptop",SerialNumber="999888777"},
                new Device{DeviceCategoryId=6,DeviceLocationId=9,Description="View Sonic Monitor",SerialNumber="VS999888777"},
                new Device{DeviceCategoryId=11,DeviceLocationId=9,Description="View Sonic Monitor",SerialNumber="VS98798766"},
                new Device{DeviceCategoryId=2,DeviceLocationId=9,Description="SURFACE DOCK 2",SerialNumber="SD999888777"}
            };
            
            context.Devices.AddRange(devices);
            context.SaveChanges();

            
           

            var assignment = new DeviceAssignment[]
            {
                new DeviceAssignment{DeviceId=1,ContactId=1},
                new DeviceAssignment{DeviceId=2,ContactId=1},
                new DeviceAssignment{DeviceId=3,ContactId=1},
                new DeviceAssignment{DeviceId=4,ContactId=1},
                new DeviceAssignment{DeviceId=5,ContactId=2},
                new DeviceAssignment{DeviceId=6,ContactId=2},
                new DeviceAssignment{DeviceId=7,ContactId=2},
                new DeviceAssignment{DeviceId=8,ContactId=2}
            };

            context.DeviceAssignments.AddRange(assignment);
            context.SaveChanges();
        }
    }
}
