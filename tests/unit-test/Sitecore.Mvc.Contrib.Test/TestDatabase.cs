using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.Mvc.Contrib.Test
{
    public static class TestDatabaseFactory
    {
        public static Database Create()
        {
            return (Database)System.Runtime.Serialization.FormatterServices.GetUninitializedObject(typeof(Database));
        }
    }
}
