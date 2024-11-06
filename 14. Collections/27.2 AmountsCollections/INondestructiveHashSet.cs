using System;
using System.Collections.Generic;

namespace _27._2_AmountsCollections
{
    public class NondestructiveHashSet<T> : HashSet<T>, INondestructiveSet<T>
    {
        // Constructor to initialize an empty set
        public NondestructiveHashSet() : base() { }

        // Constructor to initialize a set from an existing collection
        public NondestructiveHashSet(IEnumerable<T> collection) : base(collection) { }

        // Method to find the intersection between sets
        public INondestructiveSet<T> Intersection(INondestructiveSet<T> otherSet)
        {
            var result = new NondestructiveHashSet<T>(this);
            result.IntersectWith((HashSet<T>)otherSet);
            return result;
        }

        // Method to find the union between sets
        public INondestructiveSet<T> Union(INondestructiveSet<T> otherSet)
        {
            var result = new NondestructiveHashSet<T>(this);
            result.UnionWith((HashSet<T>)otherSet);
            return result;
        }

        // Method to find the difference between sets
        public INondestructiveSet<T> Difference(INondestructiveSet<T> otherSet)
        {
            var result = new NondestructiveHashSet<T>(this);
            result.ExceptWith((HashSet<T>)otherSet);
            return result;
        }
        
        // Method to check for any overlap between two sets.
        public bool IsDisjoint(INondestructiveSet<T> otherSet)
        {
            foreach (var item in this)
            {
                if (otherSet.Contains(item))
                {
                    return false; // Found a common element, so they are not disjoint
                }
            }
            return true; // No common elements, so they are disjoint
        }
        
        // Method which checks if the current set is a subset of another set.
        
        public bool IsSubset(INondestructiveSet<T> otherSet)
        {
            foreach (var item in this)
            {
                if (!otherSet.Contains(item))
                {
                    return false; // Found an item in this set that is not in otherSet
                }
            }
            return true; // All items are in otherSet, so this set is a subset
        }


        // Override ToString method for custom output
        public override string ToString()
        {
            return "{" + string.Join(", ", this) + "}";
        }
    }
}