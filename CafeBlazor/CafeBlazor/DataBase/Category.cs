using System;
using System.Collections.Generic;

namespace CafeBlazor.DataBase;

public partial class Category
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<Meal> Meals { get; set; } = new List<Meal>();
}
