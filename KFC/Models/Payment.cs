using System;
using System.Collections.Generic;

namespace KFC.Models;

public partial class Payment
{
    public int IdPayment { get; set; }

    public string Status { get; set; } = null!;

    public string Type { get; set; } = null!;

    public DateTime DateAndTime { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
