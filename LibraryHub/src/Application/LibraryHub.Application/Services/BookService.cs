using LibraryHub.Application.Interfaces;
using LibraryHub.Application.DTOs;
using LibraryHub.Domain.Entities;
using LibraryHub.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryHub.Application.Services {
    public class BookService : IBookService {
        private readonly IBookRepository _bookRepository;

        // DI (Dependency Injection) Constructor
        public BookService(IBookRepository bookRepository) {
            _bookRepository = bookRepository;
        }

        public async Task<IEnumerable<BookDto>> GetAllBooksAsync() {
            var books = await _bookRepository.GetAllAsync();

            // Mapping dari Entity ke DTO (bisa pakai AutoMapper nanti)
            return books.Select(b => new BookDto {
                Id = b.Id,
                Title = b.Title,
                Author = b.Author,
                AvailableCopies = b.AvailableCopies
            });
        }

        public async Task<bool> BorrowBookAsync(BorrowRequestDto request) {
            var book = await _bookRepository.GetByIdAsync(request.BookId);
            if (book == null || book.AvailableCopies <= 0)
                return false;

            // Logika Bisnis: Kurangi stok buku
            book.AvailableCopies -= 1;
            await _bookRepository.UpdateAsync(book);

            // TODO: Tambahkan insert ke tabel BorrowTransaction

            return true;
        }
    }
}