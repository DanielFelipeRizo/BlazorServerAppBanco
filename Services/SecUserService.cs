using Microsoft.EntityFrameworkCore;
using BlazorServerAppBanco.Models;
using AutoMapper;
using BlazorServerAppBanco.ModelsDTO.Users;

namespace BlazorServerAppBanco.Services
{
    public class SecUserService : ISecUserService
    {
        public readonly TransactionalBankContext _transactionalBankContext;
        private readonly IMapper _mapper;

        public SecUserService(TransactionalBankContext context, IMapper mapper)
        {
            _transactionalBankContext = context;
            _mapper = mapper;
        }

        public async Task<List<SecUserDTO>> GetAll()
        {
            List<SecUser> secUsers = await _transactionalBankContext.SecUsers.ToListAsync();
            //Console.WriteLine(secUsers);
            return _mapper.Map<List<SecUserDTO>>(secUsers);
            //return await _transactionalBankContext.SecUsers.ToListAsync();
        }

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

        public async Task<int> Add(SecUserDTO secUserDTO)
        {
            try
            {
                SecUser secUser = _mapper.Map<SecUser>(secUserDTO);
                secUser.UsrActive = "Y";
                secUser.UsrDateCreationKey = DateTime.Now;
                secUser.UsrDateExpKey = DateTime.Now.AddMonths(3);
                await _transactionalBankContext.AddAsync(secUser);
                //INSERT INTO sec_users_groups(login, secUserDTO.userRole)VALUES('". {login}."','". {Tusuario}. "')
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

    public interface ISecUserService
    {
        Task<List<SecUserDTO>> GetAll();
        Task<SecUserDTO?> GetById(string id);
        Task<int> Add(SecUserDTO secUserDTO);
        Task Update(SecUserDTO secUserDTO);
        Task Delete(string id);
    }
}
