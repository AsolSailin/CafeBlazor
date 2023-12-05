using System;
using System.Collections.Generic;

namespace CafeBlazor.DataBase;

public partial class MealOrder
{
    public int Id { get; set; }

    public int Count { get; set; }

    public int MealId { get; set; }

    public int OrderId { get; set; }

    public virtual Meal Meal { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;
}
