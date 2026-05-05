using System;

namespace Pug
{
    public class Chain<T>
    {
        public class Link
        {
            public Link(T item)
            {
                Item = item;
            }
            
            [Obsolete("Use Link(T item) for start of chain, or use Link.Add(T item) for adding to chain")]
            public Link(T item, Link previous)
            {
                Item = item;
                Previous = previous;
            }

            public Link Previous { get; }

            [Obsolete("Use Item instead")]
            public T Content => Item;

            public T Item { get; }
            
            public Link Add(T item)
            {
                if( Next is not null )
                    throw new InvalidOperationException("Link already has a next link");
                
#pragma warning disable CS0618 // Type or member is obsolete : will become internal constructor in future versions
                Next = new Link( item, this );
#pragma warning restore CS0618 // Type or member is obsolete
                
                return Next;
            }
            
            public Link Next { get; private set; }
        }
    }
}
