using System;
using System.Collections.Generic;

namespace KFC.Models;

public partial class Order
{
    public int IdOrder { get; set; }

    public string Place { get; set; } = null!;

    public double Price { get; set; }

    public DateTime DateAndTime { get; set; }

    public int IdStatus { get; set; }

    public int IdPayment { get; set; }

    public int CountClient { get; set; }

    public virtual Payment IdPaymentNavigation { get; set; } = null!;

    public virtual SatatusesOrder IdStatusNavigation { get; set; } = null!;

    public virtual ICollection<OrderDish> OrderDishes { get; set; } = new List<OrderDish>();

    public virtual ICollection<UsersOrder> UsersOrders { get; set; } = new List<UsersOrder>();
}
