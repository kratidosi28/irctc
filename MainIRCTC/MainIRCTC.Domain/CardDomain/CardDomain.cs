/*using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using MainIRCTC.UnitOfWork.Main;
using MainIRCTC.Models.Main;
using System.Data.SqlClient;

namespace MainIRCTC.Domain.CardModule
{
    public class CardDomain : ICardDomain
    {
        public CardDomain(ICardUow uow) {
            this.Uow = uow;
        }

        public Task<object> GetAsync(Card parameters)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetBy(Card parameters)
        {
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(Card entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(Card entity)
        {
            try
            {
                var spParameters = new SqlParameter[5];
                spParameters[0] = new SqlParameter() { ParameterName = "CardExMonth", Value = entity.CardExpiryMonth };
                spParameters[1] = new SqlParameter() { ParameterName = "CardExYear", Value = entity.CardExpiryYear };
                spParameters[2] = new SqlParameter() { ParameterName = "CardCvv", Value = entity.CardCvv};
                spParameters[3] = new SqlParameter() { ParameterName = "CardNumber", Value = entity.CardNumber};
                spParameters[4] = new SqlParameter() { ParameterName = "UserId", Value = entity.UserId };
                await DbContextManager.StoreProc<StoreProcResult>("[dbo].spPayment", spParameters);
            }
            catch (Exception e)
            {

            }
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(Card entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(Card entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(Card parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(Card parameters)
        {
            throw new NotImplementedException();
        }

        public ICardUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface ICardDomain : ICoreDomain<Card, Card> { }
}
*/

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using MainIRCTC.UnitOfWork.Main;
using MainIRCTC.Models.Main;
using Microsoft.Data.SqlClient;
using RxWeb.Core.Data;
using MainIRCTC.BoundedContext.SqlContext;
using MainIRCTC.Models.ViewModels;

namespace MainIRCTC.Domain.CardModule
{
    public class CardDomain : ICardDomain
    {
        public CardDomain(ICardUow uow, IDbContextManager<MainSqlDbContext> dbContextManager)
        {
            this.Uow = uow;
            DbContextManager = dbContextManager;
        }

        public Task<object> GetAsync(Card parameters)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetBy(Card parameters)
        {
            throw new NotImplementedException();
        }


        public HashSet<string> AddValidation(Card entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(Card entity)
        {

            try
            {
                var spParameters = new SqlParameter[5];
                spParameters[0] = new SqlParameter() { ParameterName = "CardExMonth", Value = entity.CardExpiryMonth };
                spParameters[1] = new SqlParameter() { ParameterName = "CardExYear", Value = entity.CardExpiryYear };
                spParameters[2] = new SqlParameter() { ParameterName = "CardCvv", Value = entity.CardCvv };
                spParameters[3] = new SqlParameter() { ParameterName = "CardNumber", Value = entity.CardNumber };
                spParameters[4] = new SqlParameter() { ParameterName = "UserId", Value = entity.UserId };
                await DbContextManager.StoreProc<StoreProcResult>("[dbo].spPayment", spParameters);

            }
            catch (Exception e)
            {
                DbContextManager.RollbackTransaction();
            }
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(Card entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(Card entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(Card parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(Card parameters)
        {
            throw new NotImplementedException();
        }

        public ICardUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
        private IDbContextManager<MainSqlDbContext> DbContextManager { get; set; }
    }

    public interface ICardDomain : ICoreDomain<Card, Card> { }
}
