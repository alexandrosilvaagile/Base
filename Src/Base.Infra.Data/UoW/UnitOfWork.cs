using Base.Domain.Interfaces;
using Base.Infra.Data.Contexts;
using System.Threading.Tasks;
using FluentValidation.Results;

namespace Base.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context _context;
        private readonly INotificationContext _notification;

        public UnitOfWork(Context context, INotificationContext notification)
        {
            _context = context;
            _notification = notification;
        }

        public Task BeginTransactionAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task CommitTransactionAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task RollbackTransactionAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> SaveChangesAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}
