using RESR_API_TEMPLATE.Models;

namespace RESR_API_TEMPLATE.Services
{
    public interface ILibraryService
    {
        // Author Services
        Task<List<Author>> GetAuthorsAsync(); 
        Task<Author> GetAuthorAsync(Guid id, bool includeBooks = false);
        Task<Author> AddAuthorAsync(Author author); 
        Task<Author> UpdateAuthorAsync(Author author); 
        Task<(bool, string)> DeleteAuthorAsync(Author author); 

        // Book Services
        Task<List<Book>> GetBooksAsync(); 
        Task<Book> GetBookAsync(Guid id); // Get Single Book
        Task<Book> AddBookAsync(Book book); // POST New Book
        Task<Book> UpdateBookAsync(Book book); // PUT Book
        Task<(bool, string)> DeleteBookAsync(Book book); // DELETE Book
    }
}
