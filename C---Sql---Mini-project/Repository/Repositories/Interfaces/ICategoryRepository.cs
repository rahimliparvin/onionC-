﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Interfaces
{
    public interface ICategoryRepository : IBaseRepository<Category>
    {
        Task<IEnumerable<Category>> SearchAsync(string searchText);
        Task<IEnumerable<Category>> GetAllWithProducts();
        Task<IEnumerable<Category>> SortWithCreatedDateAsync();
	}

}
