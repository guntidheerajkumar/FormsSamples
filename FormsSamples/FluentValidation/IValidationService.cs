//
// IValidationService.cs
//
// Author: Dheeraj Kumar Gunti <guntidheerajkumar@gmail.com>
//
// Copyright (c) 2017 (c) Dheeraj Kumar Gunti
//
using System;
using System.Threading.Tasks;
using FluentValidation.Results;

namespace FormsSamples
{
	public interface IValidationService
	{
		Task<ValidationResult> Validate<T>(T objectToValidate);
	}
}
