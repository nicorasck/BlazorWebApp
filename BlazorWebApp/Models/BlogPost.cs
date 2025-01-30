using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

using BlazorWebApp.Models;

public class BlogPost
{
    public int Id { get; set; }                     // Primary Key
    public required string Title { get; set; }
    public required string Content { get; set; }
    public DateTime Created { get; set; }
    public int AuthorID { get; set;}                // Foreign Key => references to the entity of User
    public User Author { get; set; }                // Each post belongs to a User - Navigation Property
}