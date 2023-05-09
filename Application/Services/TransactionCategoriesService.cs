using AutoMapper;
using Contracts.Repositories;
using Contracts.Services;
using Contracts.Services.DTO.TransactionCategories;
using Domains;

namespace Application.Services
{
    public class TransactionCategoriesService : ITransactionCategoriesService
    {
        private readonly ITransactionCategoriesRepository _repository;
        private readonly IMapper _mapper;

        public TransactionCategoriesService(ITransactionCategoriesRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<TransactionCategoriesResponseDto> AddTransactionCategory(TransactionCategoriesDto model)
        {
            var response = await _repository.AddAsync(_mapper.Map<TransactionCategories>(model));
            return _mapper.Map<TransactionCategoriesResponseDto>(response);
        }

        public async Task<List<TransactionCategoriesResponseDto>> GetAllTransactionCategories()
        {
            var response = await _repository.GetAllAsync();
            return _mapper.Map<List<TransactionCategoriesResponseDto>>(response);
        }

        public async Task<TransactionCategoriesResponseDto> GetById(int id)
        {
            var response = await _repository.GetByIdAsync(id);
            return _mapper.Map<TransactionCategoriesResponseDto>(response);
        }

        public async Task<List<TransactionCategoriesResponseDto>> SearchTransactionCategories(string text)
        {
            var response = await _repository.GetByPartOfNameAsync(text);
            return _mapper.Map<List<TransactionCategoriesResponseDto>>(response);
        }

        public async Task<TransactionCategoriesResponseDto> UpdateTransactionCategory(TransactionCategoriesDto model)
        {
            var _model = await _repository.GetByIdAsync(model.Id);
            if (_model is null) return null;
            SetDtoToModel(model, _model);
            var response = await _repository.UpdateAsync(_model);
            return _mapper.Map<TransactionCategoriesResponseDto>(response);
        }

        private static void SetDtoToModel(TransactionCategoriesDto model, TransactionCategories? _model)
        {
            _model.Id = model.Id;
            _model.TransactionType = model.TransactionType;
            _model.Name = model.Name;
            _model.Description = model.Description;
            _model.ModifyDate = DateTime.Now;
        }
    }
}
