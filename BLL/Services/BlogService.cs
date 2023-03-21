using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.IServices;
using DAL.IUnitOfWork1;
using Entities;

namespace BLL.Services
{
    public class BlogService : IBlogService
    {
        public readonly IUnitOfWork _unitOfWork;
        public BlogService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task Add(Blog blog)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(int Id)
        {
            await _unitOfWork._commentRepository.Delete(Id);
            await _unitOfWork.Commit();
        }

        public async Task<List<Blog>> Get()
        {
            return await _unitOfWork._blogRepository.GetBlogs();
        }

        public async Task<Blog> Get(int Id)
        {
            return await _unitOfWork._blogRepository.GetById(Id);
        }

        public  List<Blog> GetBlogsByWriter(int Id)
        {
            return  _unitOfWork._blogRepository.GetBLogsByWriter(Id);
        }

        public void Update(Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}
