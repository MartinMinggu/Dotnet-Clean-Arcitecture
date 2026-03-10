using LibraryHub.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryHub.Application.Interfaces {
    public interface IBookRepository {
        Task<IEnumerable<Book>> GetAllAsync();
        Task<Book?> GetByIdAsync(int id);
        Task AddAsync(Book book);
        Task UpdateAsync(Book book);
        Task DeleteAsync(int id);
    }
}