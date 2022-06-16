using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
namespace DAL
{
    public  interface IDeptMasterDAL<DeptMaster>
    {
        bool SaveDept(DeptMaster deptMaster);

        bool DeleteDept(int code);

        bool UpdateDept(DeptMaster deptMaster);

        DeptMaster GetDept(int code);

        List<DeptMaster> GetDeptMasters();

        int GetMaxDeptCode();
    }
}
