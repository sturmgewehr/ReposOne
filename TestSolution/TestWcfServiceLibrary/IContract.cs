using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TestWcfServiceLibrary
{
    [ServiceContract]
    public interface IContract
    {
        [OperationContract]
        void AddUser(UserDTO userDTO);
        [OperationContract]
        IEnumerable<UserDTO> GetUsers();
    }

    
}
