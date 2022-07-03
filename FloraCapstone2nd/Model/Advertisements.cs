using System.ComponentModel.DataAnnotations;

namespace FloraCapstone2nd.Model
{
    public class Advertisements
    {
        [Key]
        public int AdsId { get; set; }
        public string ShopName { get; set; }
        public string Description { get; set; }
        public int ClicksNum { get; set; }

    }
}
