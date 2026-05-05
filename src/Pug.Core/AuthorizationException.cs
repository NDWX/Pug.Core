using System;

namespace Pug;

public class AuthorizationException : SecurityException
{
	public AuthorizationException()
	{
	}

	public AuthorizationException(string message)
		: base(message)
	{
	}

	public AuthorizationException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}