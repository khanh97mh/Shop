using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models {
    public class Footer {

        [Table("Footers")]
        public class Footerss {

            [Key]
            public string ID { get; set; }

            [Required]
            public string Content { get; set; }
        }
    }
}