//
// EmployeeValidator.cs
//
// Author: Dheeraj Kumar Gunti <guntidheerajkumar@gmail.com>
//
// Copyright (c) 2017 (c) Dheeraj Kumar Gunti
//
using System;
using FluentValidation;

namespace FormsSamples
{
	public class EmployeeValidator : AbstractValidator<Employee>, IValidator<Employee>
	{
		public EmployeeValidator()
		{
			RuleFor(emp => emp.FirstName)
				.NotEmpty()
				.WithMessage("First Name is Requried");


			RuleFor(emp => emp.MiddleName)
				.NotEmpty()
				.WithMessage("Middle Name is Required");
			
			RuleFor(emp => emp.LastName)
				.NotEmpty()
				.WithMessage("Last Name is Required");
		}
	}
}
