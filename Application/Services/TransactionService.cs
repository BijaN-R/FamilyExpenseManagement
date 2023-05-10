using AutoMapper;
using Contracts.Repositories;
using Contracts.Services;
using Contracts.Services.DTO.Transaction;
using Domains;

namespace Application.Services
{
    public class TransactionService : ITransactionsService
    {
        private readonly ITransactionsRepository _repository;
        private readonly IMapper _mapper;

        public TransactionService(ITransactionsRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<TransactionResponseDto> AddAsync(TransactionDto transaction)
        {
            var response = await _repository.AddAsync(_mapper.Map<Transactions>(transaction));
            return _mapper.Map<TransactionResponseDto>(response);
        }

        public async Task<TransactionResponseDto> Delete(Guid id)
        {
            var model = await _repository.GetByIdAsync(id);
            return _mapper.Map<TransactionResponseDto>(await _repository.Delete(model));
        }

        public async Task<List<TransactionResponseDto>> GetAllExpenseTransactions()
        {
            return _mapper.Map<List<TransactionResponseDto>>(await _repository.GetAllExpenseTransactions());
        }

        public async Task<List<TransactionResponseDto>> GetAllIncomeTransactions()
        {
            return _mapper.Map<List<TransactionResponseDto>>(await _repository.GetAllIncomeTransactions());
        }

        public async Task<List<TransactionResponseDto>> GetAllTransactions()
        {
            return _mapper.Map<List<TransactionResponseDto>>(await _repository.GetAllTransactions());
        }

        public async Task<TransactionResponseDto> GetById(Guid id)
        {
            var response = await _repository.GetByIdAsync(id);
            return _mapper.Map<TransactionResponseDto>(response);
        }

        public async Task<TransactionResponseDto> UpdateAsync(TransactionUpdateDto transaction)
        {
            var model = await _repository.GetByIdAsync(transaction.Id);
            _mapper.Map(transaction, model);
            model.ModifyDate = DateTime.Now;
            var result = await _repository.UpdateAsync(model);
            return _mapper.Map<TransactionResponseDto>(result);
        }
    }
}
