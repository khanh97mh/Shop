using System;
namespace TeduShop.Model.Abstract {
    public interface IAuditable {
        DateTime? CreateDate { get; set; }
        string CreateBy { get; set; }
        DateTime? UpdatedDate { get; set; }
        string UpdatedBy { get; set; }
    }
}
