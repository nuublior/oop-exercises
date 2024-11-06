using System.Collections.Generic;

namespace _27._2_AmountsCollections
{
    public interface INondestructiveSet<T>
    {
        INondestructiveSet<T> Intersection(INondestructiveSet<T> otherSet);
        INondestructiveSet<T> Union(INondestructiveSet<T> otherSet);
        INondestructiveSet<T> Difference(INondestructiveSet<T> otherSet);
        
        bool IsDisjoint(INondestructiveSet<T> otherSet);
        bool Contains(T item);
        
        bool IsSubset(INondestructiveSet<T> otherSet);


    }
}