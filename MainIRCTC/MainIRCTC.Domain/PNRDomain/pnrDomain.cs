using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using MainIRCTC.UnitOfWork.Main;
using MainIRCTC.Models.Main;

namespace MainIRCTC.Domain.PNRModule
{
    public class pnrDomain : IpnrDomain
    {
        public pnrDomain(IPNRUow uow) {
            this.Uow = uow;
        }

        public Task<object> GetAsync(vPNR parameters)
        {
          throw new NotImplementedException();
         
        }

        public async Task<object> GetBy(vPNR parameters)
        {
            var check = await Uow.Repository<vPNR>().FindByAsync(t => t.UserId == parameters.UserId);
            return check;
         /*  if(check != null)
            {
                return "hello";
            }
            else
            {
                return "invalid";
            }*/
        }
        

        public HashSet<string> AddValidation(vPNR entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(vPNR entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(vPNR entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(vPNR entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(vPNR parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(vPNR parameters)
        {
            throw new NotImplementedException();
        }

        public IPNRUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IpnrDomain : ICoreDomain<vPNR, vPNR> { }
}
