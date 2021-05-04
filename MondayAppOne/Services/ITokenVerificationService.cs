using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MondayAppOne.Services
{
    public interface ITokenVerificationService
    {
        string Verify(string token, string secret);
    }
}
