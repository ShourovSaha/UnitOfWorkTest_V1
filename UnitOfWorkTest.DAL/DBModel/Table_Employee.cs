//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnitOfWorkTest.DAL.DBModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table_Employee
    {
        public int eId { get; set; }
        public string eName { get; set; }
        public Nullable<int> eDepartmentId { get; set; }
        public double eSalary { get; set; }
        public string JoinedDate { get; set; }
    
        public virtual Table_Department Table_Department { get; set; }
    }
}
