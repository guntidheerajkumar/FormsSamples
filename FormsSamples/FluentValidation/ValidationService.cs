//
// ValidationService.cs
//
// Author: Dheeraj Kumar Gunti <guntidheerajkumar@gmail.com>
//
// Copyright (c) 2017 (c) Dheeraj Kumar Gunti
//
using System;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Results;
using Xamarin.Forms;

namespace FormsSamples
{
	public class ValidationService : IValidationService
	{
		public async Task<ValidationResult> Validate<T>(T objectToValidate)
		{
			var validator = DependencyService.Get<IValidator<T>>();

			if (objectToValidate == null || validator == null) {
				return new ValidationResult();
			}

			var validationResult = await validator.ValidateAsync(objectToValidate);

			return validationResult;
		}
	}
}
