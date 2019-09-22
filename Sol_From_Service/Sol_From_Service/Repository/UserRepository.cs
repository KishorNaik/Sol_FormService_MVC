using System;
using System.Threading.Tasks;
using Sol_From_Service.Core.Repository;

namespace Sol_From_Service.Repository
{
    public class UserRepository : IUserRepository
    {
        async Task<dynamic> IUserRepository.AddUserAsync()
        {
            return await Task.Run(()=>{

                return true;
            });
        }
    }
}
