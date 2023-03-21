using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BLL.IServices
{
    public interface IBlogService
    {
        Task Add(Blog blog);
        void Update(Blog blog);
        Task Delete(int Id);
        Task<List<Blog>> Get();
        Task<Blog>Get(int Id);
        List<Blog> GetBlogsByWriter(int Id);
    }
}
