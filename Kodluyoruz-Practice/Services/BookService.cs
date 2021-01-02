using Kodluyoruz_Practice.Context;
using Kodluyoruz_Practice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kodluyoruz_Practice.Services
{
    public class BookService
    {
        private readonly BookContext _bookContext;
        #region BookContext'i BookService'ye Inject etme 
        public BookService(BookContext bookContext)
        {
            _bookContext = bookContext;
        }
        #endregion

        #region Tüm kitapları Getiren Metot
        public List<BookEntity> GetBooks()
        {

            return _bookContext.Books;
        }
        #endregion

        #region Id'ye göre kirapları yakalyıp getirme
        public BookEntity Get(int id)
        {
            return _bookContext.Books.FirstOrDefault(x => x.Id == id);
        }
        #endregion

        #region Düzenlenmiş entity'i yakalyıp silme ve yeni entity'i ekleme
        public void Edit(BookEntity bookEntity)
        {
            var currentEntity = _bookContext.Books.FirstOrDefault(x => x.Id == bookEntity.Id);
            _bookContext.Books.Remove(currentEntity);
            _bookContext.Books.Add(bookEntity);
        }
        #endregion

        #region Id'ye göre kitapları silme
        public void Delete(int id)
        {
            var entity = _bookContext.Books.FirstOrDefault(x => x.Id == id);
            _bookContext.Books.Remove(entity);
        }
        #endregion
        public void Add(BookEntity entity)
        {
            _bookContext.Books.Add(entity);
        }
    }
}
