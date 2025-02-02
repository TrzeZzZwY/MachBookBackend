﻿namespace BookService.Domain.Models;

public class Author
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Country { get; set; }

    public int YearOfBirth { get; set; }

    public bool IsDeleted { get; set; } 

    public List<Book> AuthorBooks { get; set; }
}
