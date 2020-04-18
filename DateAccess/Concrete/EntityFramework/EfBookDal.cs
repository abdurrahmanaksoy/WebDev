using Core.DateAccess.EntityFramework;
using DateAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DateAccess.Concrete.EntityFramework
{
    public class EfBookDal : EfEntityRepositoryBase<Book,BookStoreContext>,IBookDal
    {
        
    }
}
