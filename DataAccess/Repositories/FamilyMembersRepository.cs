using Contracts.Repositories;
using Domains;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class FamilyMembersRepository : IFamilyMembersRepository
    {
        private readonly ExpenseManagerDbContext _context;

        public FamilyMembersRepository(ExpenseManagerDbContext context)
        {
            _context = context;
        }

        public async Task<FamilyMembers> GetByIdAsync(int id)
        {
            return await _context.FamilyMembers.FindAsync(id);
        }
        

        public async Task<FamilyMembers> GetByUsernameAndPassword(string username, string passwrod)
        {
            return await _context.FamilyMembers.FirstOrDefaultAsync(x=>x.UserName == username && x.Password == passwrod);
        }

        public async Task<List<FamilyMembers>> GetAllAsync()
        {
            return await _context.FamilyMembers.ToListAsync();
        }

        public async Task<int> AddAsync(FamilyMembers entity)
        {
            await _context.FamilyMembers.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity.Id;
        }

        public async Task<FamilyMembers> UpdateAsync(FamilyMembers entity)
        {
            _context.FamilyMembers.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(FamilyMembers entity)
        {
            _context.FamilyMembers.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
