using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Civil.Data.EF
{
   public class CivilRepository
    {
       
       Civil.Data.EF.Entities.Employees emp=new Entities.Employees();
       cividatanewEntities context = new cividatanewEntities();

       //public List<Civil.Data.EF.Entities.Employees> GetAllEmployees()
       //{
       //    using (context = new cividatanewEntities())
       //    {

       //    }
       //}


       public Civil.Data.EF.Entities.Employees DisplayNewAndEditMember(int employeeid, Civil.Data.EF.Entities.Employees displayEmployee)
       {
           if (employeeid == 0)
           {
               int maxMemberId = (from s in context.employees select s.employeeid).Max();
              
           }

           else
           {
               var editEmployee = (from s in context.employees where s.employeeid == employeeid select s).First();
               displayEmployee.employeeid = editEmployee.employeeid;
               displayEmployee.firstname = editEmployee.firstname;
               displayEmployee.middlename = editEmployee.middlename;
               displayEmployee.lastname = editEmployee.lastname;
               displayEmployee.address = editEmployee.address;
               displayEmployee.joindate = editEmployee.joindate;
               displayEmployee.middlename = editEmployee.middlename;             
              
               
           }

           return displayEmployee;
       }

       public void RegistorEmployee(Civil.Data.EF.Entities.Employees newEditEmployee)
       {
           var editRecord = (from s in context.employees where s.employeeid == newEditEmployee.employeeid select s).FirstOrDefault();

           if (editRecord == null)
           {

               var newEmployee = context.employees.CreateObject();

               newEmployee.employeeid = newEditEmployee.employeeid;
               newEmployee.firstname = newEditEmployee.firstname;
               newEmployee.middlename = newEditEmployee.middlename;
               newEmployee.lastname = newEditEmployee.lastname;
               newEmployee.address = newEditEmployee.address;
               newEmployee.joindate = newEditEmployee.joindate;


           }
           else
           {
               editRecord.employeeid = newEditEmployee.employeeid;
               editRecord.firstname = newEditEmployee.firstname;
               editRecord.middlename = newEditEmployee.middlename;
               editRecord.lastname = newEditEmployee.lastname;
               editRecord.address = newEditEmployee.address;
               editRecord.joindate = newEditEmployee.joindate;
               context.SaveChanges();
           }

       }

       public void DeleteEmployee()
       {

       }

    }
}
