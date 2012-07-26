using System;
using System.Collections.Generic;

namespace TowerOfHanoi
{
    [Serializable]
    public class Tower : LinkedList<string>
    {
        private readonly string _name;

        public Tower() : this("Tower 1")
        {
        }

        public Tower(string name)
        {
            _name = name;
        }
        
        public void AddDisk(string value)
        {
            string next = TopDisk();

            if (next != null && String.CompareOrdinal(value, TopDisk()) > 0)
            {
                throw new InvalidOperationException("Only smaller disks can be added to the tower.");
            }

            var node = new LinkedListNode<string>(value);
            AddLast(node);
        }

        public string TopDisk()
        {
            return Last == null ? null : Last.Value;
        }

        public string RemoveDisk()
        {
            LinkedListNode<string> node = Last;
            RemoveLast();
            return node.Value;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}