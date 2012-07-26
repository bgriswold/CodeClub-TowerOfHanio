using System;
using System.Collections;

namespace TowerOfHanoi
{
    public class Towers : IEnumerable
    {
        private readonly Tower[] _towers = { new Tower("Tower 1"), new Tower("Tower 2"), new Tower("Tower 3") };
       
        public int Count
        {
            get { return _towers.Length; }
        }

        public Tower Tower1
        {
            get { return _towers[0]; }
        }

        public Tower Tower2
        {
            get { return _towers[1]; }
        }
        
        public Tower Tower3
        {
            get { return _towers[2]; }
        }

        public void Clear()
        {
            _towers[0].Clear();
            _towers[1].Clear();
            _towers[2].Clear();
        }

        public TowersEnumerator GetEnumerator()
        {
            return new TowersEnumerator(this);
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public class TowersEnumerator : IEnumerator, IDisposable
        {
            int _index;
            Towers _towers;

            public TowersEnumerator(Towers towers)
            {
                _towers = towers;
                _index = -1;
            }

            public void Reset()
            {
                _index = -1;
            }

            public bool MoveNext()
            {
                _index++;
                return (_index < _towers._towers.GetLength(0));
            }

            public Tower Current
            {
                get
                {
                    return (_towers._towers[_index]);
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return (Current);
                }
            }

            public void Dispose()
            {
                _towers = null;
            }
        }
    }
}