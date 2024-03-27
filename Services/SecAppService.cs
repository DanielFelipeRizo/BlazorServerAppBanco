using Microsoft.EntityFrameworkCore;
using BlazorServerAppBanco.Models;
using AutoMapper;
using BlazorServerAppBanco.ModelsDTO.Users;

namespace BlazorServerAppBanco.Services
{
    public class SecAppService : ISecAppService
    {
        public readonly TransactionalBankContext _transactionalBankContext;
        private readonly IMapper _mapper;

        public SecAppService(TransactionalBankContext context, IMapper mapper)
        {
            _transactionalBankContext = context;
            _mapper = mapper;
        }

        public async Task<List<SecAppDTO>> GetAll()
        {
            List<SecApp> secApps = await _transactionalBankContext.SecApps.ToListAsync();
            return _mapper.Map<List<SecAppDTO>>(secApps);
            //return secApps;
        }

        //public async Task<List<SecApp>> GetAll()
        //{
        //    List<SecApp> secApps = await _transactionalBankContext.SecApps.ToListAsync();
        //    return secApps;
        //}

        public async Task<SecUserDTO?> GetById(string id)
        {
            try
            {
                SecUser? secUser = await _transactionalBankContext.SecUsers.FirstOrDefaultAsync(u => u.Login == id);
                return _mapper.Map<SecUserDTO>(secUser);
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
                SecUser secUser = _mapper.Map<SecUser>(secUserDTO);
                await _transactionalBankContext.AddAsync(secUser);
                return await _transactionalBankContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
        }

        public async Task Update(SecUserDTO secUserDTO)
        {
            SecUser? currentUser = await _transactionalBankContext.SecUsers.FirstOrDefaultAsync(u => u.Login == secUserDTO.Login);
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

                _mapper.Map(secUserDTO, currentUser);
                await _transactionalBankContext.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Usuario no valido");
            }
        }
        public async Task Delete(string id)
        {
            SecUser? currentUser = await _transactionalBankContext.SecUsers.FirstOrDefaultAsync(u => u.Login == id);
            if (currentUser != null)
            {
                _transactionalBankContext.Remove(currentUser);
                await _transactionalBankContext.SaveChangesAsync();
            }
            else
            {
                throw new Exception($"el usuario {currentUser.Name} no existe");
            }
        }
    }

    public interface ISecAppService
    {
        //Task<List<SecApp>> GetAll();
        Task<List<SecAppDTO>> GetAll();
        //Task<List<Device>> GetAll1();
        //Task<SecUserDTO?> GetById(string id);
        //Task<int> Save(SecUserDTO secUserDTO);
        //Task Update(SecUserDTO secUserDTO);
        //Task Delete(string id);
    }
}
