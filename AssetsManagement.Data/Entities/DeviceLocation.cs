using System.ComponentModel.DataAnnotations;

namespace AssetManagment.Data.Entities
{
    public class DeviceLocation
    {
        [Key]
        public int DeviceLocationId { get; set; }

        public string DeviceLocationName { get; set; }

        public virtual ICollection<Device> Devices { get; } = new List<Device>();
    }
}
