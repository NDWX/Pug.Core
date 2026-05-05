using System;

namespace Pug
{
	public interface IRange<T> : IReadOnlyRange<T>
		where T : struct, IComparable<T>
	{
		public new T? Start
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			set;
#endif
		}
	
		public new T? End
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