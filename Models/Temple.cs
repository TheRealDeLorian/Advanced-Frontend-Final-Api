using System;
using System.Collections.Generic;

namespace Advanced_Frontend_Final_Api.Models;

public partial class Temple
{
    public int Id { get; set; }

    public string? Templename { get; set; }

    public string? Lat { get; set; }

    public string? Long { get; set; }

    public string? Mailaddress { get; set; }

    public string? Photourl { get; set; }

    public virtual ICollection<Visit> Visits { get; set; } = new List<Visit>();
}
