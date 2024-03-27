using Microsoft.EntityFrameworkCore;
using BlazorServerAppBanco.Models;
using BlazorServerAppBanco.ModelsDTO;
using AutoMapper;

namespace BlazorServerAppBanco.Services
{
    public class SecUserService : ISecUserService
    {
        private readonly TransactionalBankContext transactionalBankContext;
        private readonly IMapper mapper;

        public SecUserService(TransactionalBankContext context, IMapper mapper)
        {
            this.transactionalBankContext = context;
            this.mapper = mapper;
        }

        public async Task<List<SecUserDTO>> GetAll()
        {
            List<SecUser> secUsers = await transactionalBankContext.SecUsers.ToListAsync();
            return mapper.Map<List<SecUserDTO>>(secUsers);
            //return await transactionalBankContext.SecUsers.ToListAsync();
        }

        public async Task<SecUserDTO?> GetById(string id)
        {
            try
            {
                SecUser? secUser = await transactionalBankContext.SecUsers.FirstOrDefaultAsync(u => u.Login == id);
                return mapper.Map<SecUserDTO>(secUser);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
        }

        public async Task<int> Save(SecUserDTO secUserDTO)
        {
            try
            {
                SecUser secUser = mapper.Map<SecUser>(secUserDTO);
                await transactionalBankContext.AddAsync(secUser);
                return await transactionalBankContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
        }

        public async Task Update(SecUserDTO secUserDTO)
        {
            SecUser? currentUser = await transactionalBankContext.SecUsers.FirstOrDefaultAsync(u => u.Login == secUserDTO.Login);
            if (currentUser != null)
            {
                currentUser.Login = secUserDTO.Login;
                currentUser.Pswd = secUserDTO.Pswd;
                currentUser.Name = secUserDTO.Name;
                currentUser.Email = secUserDTO.Email;
                currentUser.UsrActive = secUserDTO.UsrActive;
                currentUser.ActivationCode = secUserDTO.ActivationCode;
                currentUser.PrivAdmin = secUserDTO.PrivAdmin;
                currentUser.UsrDateExpKey = secUserDTO.UsrDateExpKey;
                currentUser.UsrDateCreationKey = secUserDTO.UsrDateCreationKey;
                currentUser.UsrAttempts = secUserDTO.UsrAttempts;
                currentUser.RegisteredUser = secUserDTO.RegisteredUser;
                currentUser.EntryDate = secUserDTO.EntryDate;
                currentUser.UserUltHigh = secUserDTO.UserUltHigh;
                currentUser.DateTimeUltActive = secUserDTO.DateTimeUltActive;
                currentUser.AuthenticationCode = secUserDTO.AuthenticationCode;
                currentUser.ValidityCode = secUserDTO.ValidityCode;
                currentUser.AuthAttempts = secUserDTO.AuthAttempts;
                currentUser.TagUser = secUserDTO.TagUser;

                mapper.Map(secUserDTO, currentUser);
                await transactionalBankContext.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Usuario no valido");
            }
        }
        public async Task Delete(string id)
        {
            SecUser? currentUser = await transactionalBankContext.SecUsers.FirstOrDefaultAsync(u => u.Login == id);
            if (currentUser != null)
            {
                transactionalBankContext.Remove(currentUser);
                await transactionalBankContext.SaveChangesAsync();
            }
            else
            {
                throw new Exception($"el usuario {currentUser.Name} no existe");
            }
        }
    }

    public interface ISecUserService
    {
        Task<List<SecUserDTO>> GetAll();
        Task<SecUserDTO?> GetById(string id);
        Task<int> Save(SecUserDTO secUserDTO);
        Task Update(SecUserDTO secUserDTO);
        Task Delete(string id);
    }
}
