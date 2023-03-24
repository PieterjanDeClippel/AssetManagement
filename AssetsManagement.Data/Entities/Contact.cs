using System.ComponentModel.DataAnnotations;

namespace AssetManagment.Data.Entities
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }       

        public string FullName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
