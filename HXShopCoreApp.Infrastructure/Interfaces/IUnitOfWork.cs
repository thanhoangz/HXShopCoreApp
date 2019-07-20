using System;

namespace HXShopCoreApp.Infrastructure.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        /// <summary>
        /// Call SaveChanges from DbContext
        /// </summary>
        void Commit();
    }
}
