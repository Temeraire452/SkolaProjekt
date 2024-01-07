using System;
using System.Collections.Generic;

namespace SkolaProjekt.Models;

public partial class Kur
{
    public int KursId { get; set; }

    public string? Kursnamn { get; set; }

    public bool? Aktiv { get; set; }

    public virtual ICollection<Betyg> Betygs { get; set; } = new List<Betyg>();
}
