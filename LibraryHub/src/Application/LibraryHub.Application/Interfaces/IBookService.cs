using LibraryHub.Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryHub.Application.Interfaces {
    public interface IBookService {
        Task<IEnumerable<BookDto>> GetAllBooksAsync();
        Task<bool> BorrowBookAsync(BorrowRequestDto request);
    }
}