using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace PairProgramming.Models;

public class Person
{
    public int Id { get; set; }
    [Required]
    [StringLength(20)]
    public string FirstName { get; set; }
    
    [StringLength(20)]
    public string LastName { get; set; }
    
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    public DateTime Birthday { get; set; }
}