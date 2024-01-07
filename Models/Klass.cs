using System;
using System.Collections.Generic;

namespace SkolaProjekt.Models;

public partial class Klass
{
    public int KlassId { get; set; }

    public string? Klassnamn { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
