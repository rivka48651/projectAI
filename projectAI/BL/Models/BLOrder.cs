using BL.Models;
using Dal.Models;

namespace BL.Models;

public partial class BLOrder
{
    public int IdOrder { get; set; }

    public int IdCustomer { get; set; }
    public List<BLOrderDetail> OrderDetailList { get; set; } = new List<BLOrderDetail>();

    public DateTime DateOrder { get; set; }

    public eStatus Status { get; set; }

    public decimal TotalAmount { get; set; }

    public virtual BLCustomer IdOrderNavigation { get; set; } = null!;

}
