using Microsoft.EntityFrameworkCore;
using BlazorServerAppBanco.Models;
using AutoMapper;
using BlazorServerAppBanco.ModelsDTO.Users;


namespace BlazorServerAppBanco.Services
{
    public class SecGroupAppService
    {
        public readonly TransactionalBankContext _transactionalBankContext;
        private readonly IMapper _mapper;

        public SecGroupAppService(TransactionalBankContext transactionalBankContext, IMapper mapper)
        {
            _transactionalBankContext = transactionalBankContext;
            _mapper = mapper;
        }
        public async Task<List<SecGroupAppDTO>> GetAll()
        {
            try
            {
                List<SecGroupsApp> groupApps = await _transactionalBankContext.SecGroupsApps.ToListAsync();
                return _mapper.Map<List<SecGroupAppDTO>>(groupApps);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
        }
    }
}
