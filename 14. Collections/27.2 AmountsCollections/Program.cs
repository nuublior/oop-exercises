using System;
using System.Collections.Generic;

namespace _27._2_AmountsCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var setA = new NondestructiveHashSet<int> { 1, 2 };
            var setB = new NondestructiveHashSet<int> { 1, 2, 3, 4 };
            var setC = new NondestructiveHashSet<int> { 2, 3 };

            Console.WriteLine("Is set A a subset of set B? " + setA.IsSubset(setB)); // Expected: true
            Console.WriteLine("Is set A a subset of set C? " + setA.IsSubset(setC)); // Expected: false
        }

    }
}