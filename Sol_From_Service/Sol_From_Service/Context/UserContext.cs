using System;
using System.Threading.Tasks;
using Sol_From_Service.Core.Context;
using Sol_From_Service.Core.Repository;

namespace Sol_From_Service.Context
{
    public class UserContext : IUserContext
    {

        private readonly IUserRepository _userRepository;

        public UserContext(IUserRepository _userRepository){
            this._userRepository=_userRepository;
        }

        async Task<dynamic> IUserContext.AddUserAsync()
        {
            return await _userRepository.AddUserAsync();
        }
    }
}
