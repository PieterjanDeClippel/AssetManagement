using System.ComponentModel.DataAnnotations;

namespace AssetManagment.Data.Entities
{
    public class DeviceCategory
    {
        [Key]
        public int DeviceCategoryId { get; set; }

        public string DeviceCategoryName { get; set; }

        public virtual ICollection<Device> Devices { get; } = new List<Device>();

    }
}
