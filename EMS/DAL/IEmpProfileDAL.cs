using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
namespace DAL
{
    public  interface IEmpProfileDAL<EmpProfile>
    {
        bool SaveEmployee(EmpProfile empProfile);

        bool DeleteEmployee(int code);

        bool UpdateEmployee(EmpProfile empProfile);
    }
}
