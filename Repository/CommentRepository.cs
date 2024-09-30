using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly ApplicationDBContext _context;
        public CommentRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        async Task<List<Comment>> ICommentRepository.GettAllAsync()
        {
            return await _context.Comments.ToListAsync();
        }

        async Task<Comment> ICommentRepository.GetByIdAsync(int id)
        {
            return await _context.Comments.FindAsync(id);
        }

        async Task<Comment> ICommentRepository.CreateAsync(Comment commentModel)
        {
            await _context.Comments.AddAsync(commentModel);
            await _context.SaveChangesAsync();
            return commentModel;
        }
    }
}