using System;
using System.Collections.Generic;

namespace Advanced_Frontend_Final_Api.Models;

public partial class Person
{
    public int Id { get; set; }

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public string? Email { get; set; }

    public string? Pfpurl { get; set; }
}
