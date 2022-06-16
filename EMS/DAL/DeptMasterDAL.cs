using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
namespace DAL
{
    public class DeptMasterDAL : IDeptMasterDAL<DeptMaster>
    {

        public bool SaveDept(DeptMaster deptMaster)
        {
            try
            {
                using (EmsDbEntities dbContext = new EmsDbEntities())
                {
                    dbContext.DeptMasters.Add(deptMaster);
                    dbContext.SaveChanges();
                    return true;
                }
            }catch(Exception ex)
            {
                return false;
            }
        }
        public bool DeleteDept(int code)
        {
            try
            {
                using (EmsDbEntities dbContext = new EmsDbEntities())
                {
                    var deptToDelete = dbContext.DeptMasters.Where(dept => dept.DeptCode == code).FirstOrDefault();
                    dbContext.DeptMasters.Remove(deptToDelete);
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool UpdateDept(DeptMaster deptMaster)
        {
            try
            {
                using (EmsDbEntities dbContext = new EmsDbEntities())
                {
                    var existingDept = dbContext.DeptMasters.Where(dept => dept.DeptCode == deptMaster.DeptCode).FirstOrDefault();
                    existingDept.DeptCode = deptMaster.DeptCode;
                    existingDept.DeptName = deptMaster.DeptName;
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public DeptMaster GetDept(int code)
        {
            try
            {
                using (EmsDbEntities dbContext = new EmsDbEntities())
                {
                    var deptByCode = dbContext.DeptMasters.Where(dept => dept.DeptCode == code).FirstOrDefault();
                    return deptByCode;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<DeptMaster> GetDeptMasters()
        {
            try
            {
                using (EmsDbEntities dbContext = new EmsDbEntities())
                {
                    var allDept = dbContext.DeptMasters.ToList();
                    return allDept;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int GetMaxDeptCode()
        {
            try
            {
                using (EmsDbEntities dbContext = new EmsDbEntities())
                {
                    var maxDeptCode = dbContext.DeptMasters.Max(dept => dept.DeptCode);
                    return maxDeptCode;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
