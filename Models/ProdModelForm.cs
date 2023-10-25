using System.ComponentModel.DataAnnotations;

namespace AmazingShop.Models
{
    public class ProdModelForm
    {
        [Required]
        public string Name { set; get; }
        [Required]
        public string Price { set; get; }
        [Required]
        public string Description { set; get; }
        [Required]
        public string LinkImg { set; get; }
        [Required]
        public string FullDescriptionUrl { set; get; }
		[Required]
		public string CategoryProduct { set; get; }
	}
}
