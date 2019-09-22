using System.Threading.Tasks;
using System;

namespace Sol_From_Service.Core.Repository
{
    public interface IUserRepository
    {
        Task<dynamic> AddUserAsync();
    }
}
