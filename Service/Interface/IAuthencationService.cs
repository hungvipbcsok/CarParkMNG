using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interface
{
    public interface IAuthencationService
    {
        string Authenticate(string username, string password);
    }
}

