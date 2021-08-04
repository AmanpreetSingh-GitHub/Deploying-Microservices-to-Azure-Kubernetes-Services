using System;

namespace Coral.Employee.Domain
{
    public class EmployeeCompositeInfo
    {
        public string EmployeeId { get; set; }
        public string EmployeeNumber { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ContactNumber { get; set; }
        public string OfficeEmail { get; set; }
        public string Address { get; set; }
        public string FatherName { get; set; }
        public string SpouseName { get; set; }
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public int MaritalStatusId { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
