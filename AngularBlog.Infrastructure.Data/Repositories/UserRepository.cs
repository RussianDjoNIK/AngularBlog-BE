﻿using System.Collections.Generic;
using System.Threading.Tasks;
using AngularBlog.Domain.Interfaces.Repositories;
using AngularBlog.Domain.Models;
using AngularBlog.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace AngularBlog.Infrastructure.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly PostDbContext dbContext;

        public UserRepository(PostDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await dbContext.Users.ToArrayAsync();
        }

        public async Task<User> GetAsync(int id)
        {
            return await dbContext.Users.FirstOrDefaultAsync(u => u.Id == id);
        }

        public Task<bool> CreateAsync(User entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpdateAsync(User entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> SaveAsync()
        {
            throw new System.NotImplementedException();
        }

        public async Task<User> GetFilteredAsync(string email)
        {
            return await dbContext.Users.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<User> GetByCredentialsAsync(string email, string password)
        {
            return await dbContext.Users.FirstOrDefaultAsync(u => u.Email == email && u.Password == password);
        }
    }
}