﻿using System;
using System.Collections.Generic;

namespace DZApp;

public partial class Author
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public virtual ICollection<Book> Books { get; } = new List<Book>();

    public override string ToString()
    {
        return $"{FirstName} {LastName}";

    }
}
