using System.ComponentModel.DataAnnotations;

public class Registration
{
    public int EventId { get; set; }

    [Required(ErrorMessage = "Name is required.")]
    [StringLength(50, ErrorMessage = "Name can't exceed 50 characters.")]
    public string UserName { get; set; }

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid email address.")]
    public string UserEmail { get; set; }
}