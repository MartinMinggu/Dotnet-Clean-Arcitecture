using System;
namespace LibraryHub.Domain.Entities;
public class Member
{
    public int Id { get; set; }
    public string FullName { get; set; } = string
        .Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public DateTime RegisteredDate { get; set; } = DateTime.Now;
    public bool IsActive { get; set; }
}