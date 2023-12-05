﻿using System;
using System.Collections.Generic;

namespace CafeBlazor.DataBase;

public partial class OrderStatus
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
