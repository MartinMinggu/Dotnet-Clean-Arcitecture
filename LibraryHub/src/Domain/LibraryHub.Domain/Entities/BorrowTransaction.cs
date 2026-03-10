using System;
using LibraryHub.Domain.Entities;
using LibraryHub.Domain.Enums;

namespace LibraryHub.Domain.Entities;
public class BorrowTransaction
{
    public int Id { get; set; }
    public int BookId { get; set; }
    public Book? Book { get; set; }

    public int MemberId { get; set; }
    public Member? member { get; set; }


    public DateTime BorrowDate { get; set; }
    public DateTime DueDate { get; set; }
    public BorrowStatus BorrowStatus { get; set; } = BorrowStatus.Pending;
    public decimal FineAmount { get; set; } = 0m;
}