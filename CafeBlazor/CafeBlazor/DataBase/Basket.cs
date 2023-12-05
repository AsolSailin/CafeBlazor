using System;
using System.Collections.Generic;

namespace CafeBlazor.DataBase;

public partial class Basket
{
    public int Id { get; set; }

    public int Count { get; set; }

    public int MealId { get; set; }

    public int UserId { get; set; }

    public virtual Meal Meal { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
