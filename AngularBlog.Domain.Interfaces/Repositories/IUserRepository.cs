﻿using AngularBlog.Domain.Models;

namespace AngularBlog.Domain.Interfaces.Repositories
{
    public interface IUserRepository : IBaseRepository<int, User>
    {
        
    }
}