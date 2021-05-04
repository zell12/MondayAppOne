using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Zell.UiPathAutomation.Other.Models
{
    public interface ITokenCustom
    {
        Task<TokenResponse> GetAccessToken(TokenRequest tokenRequest, Dictionary<string, List<string>> headers);
    }
}
