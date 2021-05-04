﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zell.UiPathAutomation.Other.Models
{
    public class TokenResponse
    {
        public string access_token { get; set; }
        public string id_token { get; set; }
        public string scope { get; set; }
        public int expires_in { get; set; }
        public string token_type { get; set; }
    }
}
