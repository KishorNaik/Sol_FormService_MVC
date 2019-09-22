using System;
using System.Threading.Tasks;

namespace Sol_From_Service.Core.Context
{
    public interface IUserContext
    {
        Task<dynamic> AddUserAsync();
    }
}
