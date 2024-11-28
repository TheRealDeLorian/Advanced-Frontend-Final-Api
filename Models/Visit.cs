using System;
using System.Collections.Generic;

namespace Advanced_Frontend_Final_Api.Models;

public partial class Visit
{
    public int Id { get; set; }

    public DateTime? Visittime { get; set; }

    public string? Note { get; set; }

    public int? Templeid { get; set; }

    public virtual Temple? Temple { get; set; }
}
