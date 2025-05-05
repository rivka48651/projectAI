using BL.Models;
using System;
using System.Collections.Generic;

namespace BL.Models;

public partial class BLCustomer
{
    public int CustomerId { get; set; }

    public string CustomerNumber { get; set; } = null!;

    public string CustomerName { get; set; } = null!;

    public string? Phone { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public eGender Gender { get; set; }

    public int? AgeGroup { get; set; }

    public byte[]? ProfilePicture { get; set; }

    public virtual eAgeGroup AgeGroupNavigation { get; set; }

    public virtual BLOrder? Order { get; set; }
}
