using System;
using System.Runtime.Serialization;

namespace Pug
{
	[DataContract]
	public record Range<T> : IRange<T>
		where T : struct, IComparable<T>
	{
		public Range()
		{
		}
		
		public Range(T? start, T? end)
		{
			Start = start;
			End = end;
		}

		[DataMember]
		public T? Start
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			set;
#endif
		}

		[DataMember]
		public T? End
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			set;
#endif
		}
	}
}
