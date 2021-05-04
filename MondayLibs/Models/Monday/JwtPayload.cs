using System;
using System.Collections.Generic;
using System.Text;

namespace MondayLibs.Models.Monday
{
    public class JwtPayload
    {
        public int accountId { get; set; }
        public int userId { get; set; }
        public int boardId { get; set; }
        public string backToUrl { get; set; }
        public int recipeId { get; set; }
        public int integrationId { get; set; }
        public string aud { get; set; }
        public int exp { get; set; }
        public int iat { get; set; }
        public string shortLivedToken { get; set; }
    }
}
