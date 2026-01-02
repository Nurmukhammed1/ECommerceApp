using System.ComponentModel.DataAnnotations;

namespace ECommerceApp.DTOs.CustomerDTOs;

public class CustomerUpdateDTO
{
    [Required(ErrorMessage = "CustomerId is required.")]
    public int CustomerId {get;set;}

    [Required(ErrorMessage = "First Name is required.")]
    [MaxLength(50, ErrorMessage = "First Name cannot exceed 50.")]
    public string FirstName {get;set;}

    [Required(ErrorMessage = "Last Name is required.")]
    [MaxLength(50, ErrorMessage = "Last Name cannot exceed 50.")]
    public string LastName {get;set;}

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid Email Address.")]
    public string Email {get;set;}

    [Required(ErrorMessage = "Phone Number is required.")]
    [Phone(ErrorMessage = "Invalid Phone Number.")]
    public string PhoneNumber {get;set;}

    [Required(ErrorMessage = "Date Of Birth is required.")]
    public DateTime DateOfBirth {get;set;}
}