using System;
using System.Collections.Generic;

namespace SkolaProjekt.Models;

public partial class Personal
{
    public int PersonalId { get; set; }

    public string? Namn { get; set; }

    public string? Personnummer { get; set; }

    public string? Befattning { get; set; }

    public DateTime? Anställningsdatum { get; set; }

    public string? Avdelning { get; set; }

    public decimal? Lön { get; set; }

    public virtual ICollection<Betyg> Betygs { get; set; } = new List<Betyg>();
}
