using System;
using Pug.Lang;

namespace Pug.Lang
{
	public class UnexpectedError : Exception
	{
		public UnexpectedError( string message ) : base( message )
		{

		}
	}
}