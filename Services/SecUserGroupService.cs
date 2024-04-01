using AutoMapper;
using BlazorServerAppBanco.Models;
using BlazorServerAppBanco.ModelsDTO.Users;
using Microsoft.EntityFrameworkCore;


namespace BlazorServerAppBanco.Services
{
    public class SecUserGroupService : ISecUserGroupService
    {
        private readonly TransactionalBankContext _transactionalBankContext;
        private readonly IMapper _mapper;

        public SecUserGroupService(TransactionalBankContext transactionalBankContext, IMapper mapper)
        {
            _transactionalBankContext = transactionalBankContext;
            _mapper = mapper;
        }

        public async Task<List<SecGroupDTO>> GetAll()
        {
            List<SecGroup> secGroups = await _transactionalBankContext.SecGroups.ToListAsync();
            return _mapper.Map<List<SecGroupDTO>>(secGroups);
        }

        public async Task<SecGroupDTO> GetById(int id)
        {
            try
            {
                SecGroup? secGroup = await _transactionalBankContext.SecGroups.FirstOrDefaultAsync(g => g.GroupId ==id);
                return _mapper.Map<SecGroupDTO>(secGroup);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
        }

        public async Task<int> Add(SecGroupDTO secGroupDTO)
        {
            try
            {
                SecGroup secGroup = _mapper.Map<SecGroup>(secGroupDTO);
                await _transactionalBankContext.AddAsync(secGroup);
                return await _transactionalBankContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
        }

        public async Task Update(SecGroupDTO secGroupDTO)
        {
            SecGroupDTO currentSecGroup = await GetById(secGroupDTO.GroupId);
            if(currentSecGroup != null)
            {
                currentSecGroup.Description = secGroupDTO.Description;

                _mapper.Map(secGroupDTO, currentSecGroup);
                await _transactionalBankContext.SaveChangesAsync();
            }
            else
            {
                throw new Exception("grupo no valido");
            }
        }

        public async Task Delete(SecGroupDTO secGroupDTO)
        {
            SecGroupDTO currentSecGroup = await GetById(secGroupDTO.GroupId);
            if(currentSecGroup != null)
            {
                _transactionalBankContext.Remove(secGroupDTO);
                await _transactionalBankContext.SaveChangesAsync();
            }
            else
            {
                throw new Exception($"el grupo {currentSecGroup.Description} no existe");
            }
        }
    }

    public interface ISecUserGroupService
    {
        Task<List<SecGroupDTO>> GetAll();
        Task<SecGroupDTO> GetById(int id);
        Task<int> Add(SecGroupDTO secGroupDTO);
        Task Update(SecGroupDTO secGroupDTO);
        Task Delete(SecGroupDTO secGroupDTO);
    }
}
