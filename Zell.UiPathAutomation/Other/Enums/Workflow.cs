using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection;
using System.Text;

namespace Zell.UiPathAutomation.Other.Enums
{
    public static class Workflow
    {
        public enum Application
        {
            SAP, WEB_CRM
        }

        public enum SAP_Interaction
        {
            BAPI, GUI
        }
    }
}
