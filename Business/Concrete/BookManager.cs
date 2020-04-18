using Business.Abstract;
using DateAccess.Abstract;
using DateAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class BookManager : IBookService
    {
        private IBookDal _bookDal;
        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }
        public void Add(Book book)
        {
            if (_bookDal.Get(b=>b.Name==book.Name && b.AuthorId==book.AuthorId)==null)
            {
                _bookDal.Add(book);
                return;
            }
            throw new Exception("Bu kitap zaten ekli");
        }

        public void Delete(Book book)
        {
            _bookDal.Delete(book);
        }

        public List<Book> GetAll()
        {
            return _bookDal.GetList().ToList();

        }

        public Book GetById(int id)
        {
            return _bookDal.Get(b => b.Id == id);
        }

        public List<Book> GetByAuthorId(int id)
        {
            return _bookDal.GetList(b => b.AuthorId == id).ToList();
        }

        public void Update(Book book)
        {
            _bookDal.Update(book);
        }
    }
}
