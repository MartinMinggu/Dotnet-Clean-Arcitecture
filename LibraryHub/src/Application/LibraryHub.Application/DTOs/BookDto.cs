using System;

public class BorrowRequestDto {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int AvailableCopies { get; set; }
    public bool IsAvailable => AvailableCopies > 0;
}
