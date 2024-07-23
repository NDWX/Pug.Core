using System;
using System.Runtime.Serialization;

namespace Pug.Lang
{
	[Obsolete("Use Exception instead")]
	public record ErrorBase
	{
		public string Message { get; set; }

		protected ErrorBase( string message = "" )
		{
			Message = message;
		}
	}
}