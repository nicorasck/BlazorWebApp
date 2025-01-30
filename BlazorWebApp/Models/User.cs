using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BlazorWebApp.Models;

public class User
{
    public int Id { get; set; }                     // Primary Key
    public required string UserName { get; set; }
    public required string Email { get; set; }
    public List<BlogPost> blogPosts { get; set; }   // One-to-Many => a User can have multiple BlogPosts - Navigation Property
}