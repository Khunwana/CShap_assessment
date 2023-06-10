using System;
using System.ComponentModel.DataAnnotations;

// Id, string accName,string accType,string name,string status,
// decimal accBalance, DateTimeOffset CreatedAt
namespace Assessment.Models
{
  public class Account
  {
    [Key]
    public Guid Id { get;set;}
    [Required]
    public string AccName { get;set;}
    [Required]
    public string AccType{ get;set;}
    [Required]
    [DisplayFormat(DataFormatString ="{0:C}")]
    public string AccBalance { get;set;}
    [Required]
    public string Name {get;set;}
    [Required]
    public string Status {get;set;}

    
  }
}