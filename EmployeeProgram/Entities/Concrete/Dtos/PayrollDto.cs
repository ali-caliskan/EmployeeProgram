﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Dtos
{
	public  class PayrollDto
	{
		public int Id { get; set; }
		public int EmployeeId { get; set; }
		public string Name { get; set; }
		public string IdentityNumber {  get; set; }
		public int Mounth { get; set; }
		public int Year { get; set; }
		public int ServiceDay { get; set; }
		public decimal GrossPay { get; set; }
		public decimal InsuarencePremiumEmployeeShare { get; set; }
		public decimal IncomeTaxAssessment { get; set; }
		public decimal CumulaticeIncomeTaxAssessment { get; set; }
		public decimal NetPay { get; set; }
	}
}
