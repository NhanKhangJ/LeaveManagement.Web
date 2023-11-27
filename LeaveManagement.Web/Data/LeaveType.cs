using System;
namespace LeaveManagement.Web.Data
{
	public class LeaveType: BaseEntity 
 	{
        public string? Name { get; set; }

		public DateTime DefaultDays { get; set; }
    }
}

