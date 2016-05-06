using PhotoGallery.Entities;
using System.Collections.Generic;

namespace PhotoGallery.Infrastructure.Repositories.Abstract
{
    public interface IUserRepository : IEntityBaseRepository<User>
    {
        User GetSingleByUsername(string username);

        IEnumerable<Role> GetUserRoles(string username);
    }
}
