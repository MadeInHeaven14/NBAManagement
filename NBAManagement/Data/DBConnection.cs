using NBAManagement.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAManagement.Data
{
    public class DBConnection
    {
        public static BasketballSystemEntities connection = new BasketballSystemEntities();
    }
}
