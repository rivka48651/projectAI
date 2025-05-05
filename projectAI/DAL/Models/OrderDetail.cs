using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dal.Models;

public partial class OrderDetail
{
    [Key]
    public int OrderCode { get; set; }

    public int? CategoryCode { get; set; }

    public int? UsageDays { get; set; }
}
