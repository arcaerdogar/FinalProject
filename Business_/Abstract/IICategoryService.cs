using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_.Abstract
{
    public interface IICategoryService
    {
        List<Category> GetAll();
        Category GetById(int id);

    }
}
