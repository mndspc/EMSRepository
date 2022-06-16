using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Models;
namespace BLL
{
    public class DeptMasterBLL
    {
        DeptMasterDAL DeptMasterDAL = new DeptMasterDAL();

        public bool AddDept(DeptMaster deptMaster)
        {
            //Your business logic goes here
           int newDeptCode= DeptMasterDAL.GetMaxDeptCode();
            newDeptCode++;
            deptMaster.DeptCode = newDeptCode;
           return DeptMasterDAL.SaveDept(deptMaster);
        }

        public bool RemoveDept(int code)
        {
            return DeptMasterDAL.DeleteDept(code);
        }

        public bool EditDept(DeptMaster deptMaster)
        {
            return DeptMasterDAL.UpdateDept(deptMaster);
        } 

        public DeptMaster GetDeptByCode(int code)
        {
            return DeptMasterDAL.GetDept(code);
        }

        public List<DeptMaster> GetAllDept()
        {
            return DeptMasterDAL.GetDeptMasters();
        }
    }
}
