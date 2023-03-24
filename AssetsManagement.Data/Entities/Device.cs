using System.ComponentModel.DataAnnotations;

namespace AssetManagment.Data.Entities
{
    public class Device
    {
        [Key]
        public int DeviceId { get; set; }

        public int DeviceCategoryId { get; set; }

        public int? DeviceLocationId { get; set; }

        public string Description { get; set; }

        public string SerialNumber { get; set; }
        
        public virtual DeviceCategory DeviceCategory { get; set; }

        public virtual DeviceLocation DeviceLocation { get; set; }      

    }
}
