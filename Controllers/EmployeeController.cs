using FirstAPI_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;



namespace FirstAPI_Project.Controllers
{
    public class EmployeeController : ApiController
    {
        public IEnumerable<EMPLOYEE> Get()
        {
            using (OrganizationModel db= new OrganizationModel())
            {
                return db.EMPLOYEES.ToList();
            }
        }

       /* public EMPLOYEE Get(int id)
        {
            using (OrganizationModel db = new OrganizationModel())
            {
                return db.EMPLOYEES.Where(x=>x.ID==id).FirstOrDefault();
            }
        }*/
    }

}
