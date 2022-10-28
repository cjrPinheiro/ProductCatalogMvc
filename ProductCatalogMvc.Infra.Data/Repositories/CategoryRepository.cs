using Microsoft.EntityFrameworkCore;
using ProductCatalogMvc.Domain.Entities;
using ProductCatalogMvc.Domain.Interfaces;
using ProductCatalogMvc.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogMvc.Infra.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public CategoryRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<string>> GetActivetedInjectable(string isActive)
        {
            var res = new List<string>();
            using (var command = _dbContext.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = $"SELECT * From Categories WHERE Active = {isActive}";

            
                _dbContext.Database.OpenConnection();
                using (var result = command.ExecuteReader())
                {
                    while (result.Read())
                    {
                        var rsp = "";
                        for (int i = 0; i < result.FieldCount; i++)
                        {
                            rsp += $"{result[i]};";

                        }
                        rsp = rsp[..^1];
                        res.Add(rsp);
                    }
                }
            }
            return res;
        }
        public async Task<List<string>> GetActivatedUninjectable(string isActive)
        {
            var res = new List<string>();
            using (var command = _dbContext.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = $"SELECT * From Categories WHERE Active = @isActive";

                var parameter = command.CreateParameter();
                parameter.ParameterName = "@isActive";
                parameter.DbType = System.Data.DbType.Byte;
                parameter.Value = isActive;
                command.Parameters.Add(parameter);

                _dbContext.Database.OpenConnection();
                using (var result = command.ExecuteReader())
                {
                    while (result.Read())
                    {
                        var rsp = "";
                        for (int i = 0; i < result.FieldCount; i++)
                        {
                            rsp += $"{result[i]};";

                        }
                        rsp = rsp[..^1];
                        res.Add(rsp);
                    }
                }
            }
            return res;
        }


        public async Task<Category> CreateAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Category> RemoveAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public async Task<Category> UpdateAsync(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
