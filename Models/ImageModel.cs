using System.ComponentModel.DataAnnotations.Schema;

namespace zacars.Models
{
    public class ImageModel
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public int VehicleId { get; set; }

        [NotMapped]
        public byte[] ImageArray { get; set; }
    }
}
