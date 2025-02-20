﻿namespace WebAPP_Template.Backend.Application.Models.Responses
{
	/// <summary>
	/// Represents an error response.
	/// </summary>
	public class ErrorResponse
	{
		public bool Success { get; set; } = false;
		public object? Errors { get; set; }
	}
}
