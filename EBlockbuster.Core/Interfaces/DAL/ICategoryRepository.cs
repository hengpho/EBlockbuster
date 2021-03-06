using EBlockbuster.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBlockbuster.Core.Interfaces
{
    public interface ICategoryRepository
    {
        Response<Category> Insert(Category category);

        Response Update(Category category);

        Response Delete(int categoryId);

        Response<Category> Get(int categoryId);
    }
}
