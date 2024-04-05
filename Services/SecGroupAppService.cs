using Microsoft.EntityFrameworkCore;
using BlazorServerAppBanco.Models;
using AutoMapper;
using BlazorServerAppBanco.ModelsDTO.Users;
using BlazorServerAppBanco.Pages.SecUser;

namespace BlazorServerAppBanco.Services
{
    public class SecGroupAppService : ISecGroupAppService
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
        public async Task Update(SecGroupAppDTO secGroupAppDTO)
        {
            SecGroupsApp? currentSecGroupsApp = await _transactionalBankContext.SecGroupsApps.Where(ga => ga.GroupId == secGroupAppDTO.GroupId).FirstOrDefaultAsync(ga => ga.AppName == secGroupAppDTO.AppName);
            if (currentSecGroupsApp != null)
            {
                currentSecGroupsApp.AppName = secGroupAppDTO.AppName;
                currentSecGroupsApp.PrivAccess = secGroupAppDTO.PrivAccess;
                currentSecGroupsApp.PrivInsert = secGroupAppDTO.PrivInsert;
                currentSecGroupsApp.PrivUpdate = secGroupAppDTO.PrivUpdate;
                currentSecGroupsApp.PrivDelete = secGroupAppDTO.PrivDelete;
                currentSecGroupsApp.PrivExport = secGroupAppDTO.PrivExport;
                currentSecGroupsApp.Module = secGroupAppDTO.Module;
                currentSecGroupsApp.Submodule = secGroupAppDTO.Submodule;

                _mapper.Map(secGroupAppDTO, currentSecGroupsApp);
                await _transactionalBankContext.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Usuario no valido");
            }
        }
    }
    public interface ISecGroupAppService
    {
        Task<List<SecGroupAppDTO>> GetAll();
        Task Update(SecGroupAppDTO secGroupAppDTO);
    }
}