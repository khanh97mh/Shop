using System;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Abstract {

    public abstract class Auditable : IAuditable {
        public DateTime? CreateDate { get; set; }

        [MaxLength(256)]
        public string CreateBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [MaxLength(256)]
        public string UpdatedBy { get; set; }
    }
}