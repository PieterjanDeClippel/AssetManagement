using System.ComponentModel.DataAnnotations;

namespace AssetManagment.Data.Entities
{
    public class DeviceAssignment
    {
        [Key]
        public int DeviceAssignmentId { get; set; }

        public int DeviceId { get; set; }

        public int ContactId { get; set; }
    }
}
