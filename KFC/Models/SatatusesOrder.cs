using System;
using System.Collections.Generic;

namespace KFC.Models;

public partial class SatatusesOrder
{
    public int IdStatus { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
