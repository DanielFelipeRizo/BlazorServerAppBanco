using AutoMapper;
using BlazorServerAppBanco.Models;
using BlazorServerAppBanco.ModelsDTO.Users;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerAppBanco.Services
{
    public class TagUserService : ITagUserService
    {
        private readonly TransactionalBankContext _transactionalBankContext;
        private readonly IMapper _mapper;

        public TagUserService(TransactionalBankContext transactionalBankContext, IMapper mapper)
        {
            _transactionalBankContext = transactionalBankContext;
            _mapper = mapper;
        }

        public async Task<List<UserTagDTO>> GetAll()
        {
            
            List<UserTag> secGroups = await _transactionalBankContext.UserTags.ToListAsync();
            return _mapper.Map<List<UserTagDTO>>(secGroups);
        }

        public async Task<UserTagDTO> GetById(int id)
        {
            try
            {
                UserTag? userTag = await _transactionalBankContext.UserTags.FirstOrDefaultAsync(t => t.UserTagId == id);
                return _mapper.Map<UserTagDTO>(userTag);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
        }

        public async Task<int> Add(UserTagDTO userTagDTO)
        {
            try
            {
                UserTag userTag = _mapper.Map<UserTag>(userTagDTO);
                userTag.CreatedDate = DateTime.Now;
                await _transactionalBankContext.AddAsync(userTag);
                return await _transactionalBankContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
        }

        public async Task Update(UserTagDTO userTagDTO)
        {
            UserTag? currentUserTag = await _transactionalBankContext.UserTags.FirstOrDefaultAsync(t => t.UserTagId == userTagDTO.UserTagId);

            if (currentUserTag != null)
            {
                currentUserTag.UserTagsName = userTagDTO.UserTagsName;
                currentUserTag.UserTagsDescription = userTagDTO.UserTagsDescription;
                currentUserTag.UserTagsStatus = userTagDTO.UserTagsStatus;
                currentUserTag.UpdateDate = DateTime.Now;
                
                await _transactionalBankContext.SaveChangesAsync();
            }
            else
            {
                throw new Exception("tag no valido");
            }
        }

        public async Task Delete(UserTagDTO userTagDTO)
        {
            UserTag? currentUserTag = await _transactionalBankContext.UserTags.FirstOrDefaultAsync(t => t.UserTagId == userTagDTO.UserTagId);
            if (currentUserTag != null)
            {
                _transactionalBankContext.Remove(currentUserTag);
                await _transactionalBankContext.SaveChangesAsync();
            }
            else
            {
                throw new Exception($"el grupo {userTagDTO.UserTagsName} no existe");
            }
        }

    }

    public interface ITagUserService
    {
        Task<List<UserTagDTO>> GetAll();
        Task<UserTagDTO> GetById(int id);
        Task<int> Add(UserTagDTO UserTagDTO);
        Task Update(UserTagDTO UserTagDTO);
        Task Delete(UserTagDTO UserTagDTO);
    }
}
