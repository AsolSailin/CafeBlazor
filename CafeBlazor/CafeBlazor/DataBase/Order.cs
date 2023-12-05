using System;
using System.Collections.Generic;

namespace CafeBlazor.DataBase;

public partial class Order
{
    public int Id { get; set; }

    public DateTime ReadyTime { get; set; }

    public int PurchaseAmount { get; set; }

    public int StatusId { get; set; }

    public int UserId { get; set; }

    public virtual ICollection<MealOrder> MealOrders { get; set; } = new List<MealOrder>();

    public virtual OrderStatus Status { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
