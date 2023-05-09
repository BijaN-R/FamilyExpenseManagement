using Domains;

namespace DataAccess.Repositories.Contracts
{
    public interface IFamilyMembersRepository
    {
        Task<FamilyMembers> GetByIdAsync(Guid id);
        Task<FamilyMembers> GetByUsernameAndPassword(string username, string passwrod);
        Task<List<FamilyMembers>> GetAllAsync();
        Task<int> AddAsync(FamilyMembers entity);
        Task<FamilyMembers> UpdateAsync(FamilyMembers entity);
        Task DeleteAsync(FamilyMembers entity);
    }
}
