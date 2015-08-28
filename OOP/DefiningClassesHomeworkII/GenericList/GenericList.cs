using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class GenericList<T>
        where T : IComparable
    {
        private T[] list;
        private int count;

        public GenericList(int capacity)
        {
            list = new T[capacity];
            this.count = 0;
        }

        public int Count
        {
            get
            {
                return count;
            }

        }

        public T this[int index]
        {
            get
            {
                this.ValidateIndex(index);
                return this.list[index];
            }
            set
            {
                this.ValidateIndex(index);
                this.list[index] = value;
            }
        }

        public void Add(T item)
        {
            int newCount = this.count + 1;
            this.EnsureCapacity(newCount);
            this.list[newCount - 1] = item;
            this.count = newCount;
        }

        //inserting element at given position
        public void AddAt(T item, int index)
        {
            this.ValidateIndex(index);
            int newCount = this.count + 1;
            this.EnsureCapacity(newCount);
            this.count = newCount;

            for (int i = count - 1; i >= index + 1; i--)
            {
                this.list[i] = this.list[i - 1];
            }

            this.list[index] = item;
        }

        //removing element by index
        public void RemoveAt(int index)
        {
            this.ValidateIndex(index);

            for (int i = index; i < this.list.Length - 1; i++)
            {
                this.list[i] = this.list[i + 1];
            }

            this.count--;
        }

        //finding element by its value 
        public int IndexOf(T item)
        {
            int reslut = -1;

            for (int i = 0; i < this.list.Length; i++)
            {
                if (this.list[i].CompareTo(item) == 0)
                {
                    reslut = i;
                    break;
                }
            }

            return reslut;
        }

        public T Max()
        {
            T result = default(T);

            if (this.Count > 0)
            {
                result = this.list[0];

                for (int i = 1; i < this.Count; i++)
                {
                    if (this.list[i].CompareTo(result) > 0)
                    {
                        result = this.list[i];
                    }
                }
            }

            return result;
        }

        public T Min()
        {
            T result = default(T);

            if (this.Count > 0)
            {
                result = this.list[0];

                for (int i = 1; i < this.Count; i++)
                {
                    if (this.list[i].CompareTo(result) < 0)
                    {
                        result = this.list[i];
                    }
                }
            }

            return result;
        }

        public void Clear()
        {
            for (int i = 0; i < list.Length; i++)
            {
                this.list[i] = default(T);
            }

            this.count = 0;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < this.Count; i++)
            {
                sb.Append(list[i]);
                if (i < this.Count - 1)
                {
                    sb.Append('\r');
                    sb.Append('\n');
                }
            }

            string result = sb.ToString();

            return result;
        }

        private void EnsureCapacity(int capacity)
        {
            if (capacity <= list.Length)
            {
                return;
            }

            int newCapacity = list.Length * 2;
            this.EncreaseCapacity(newCapacity);
        }

        private void EncreaseCapacity(int capacity)
        {
            Array.Resize(ref this.list, capacity);
        }

        private void ValidateIndex(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException(
                        String.Format("Index {0} is invalid!", index));
            }
        }
    }
}
