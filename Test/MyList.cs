﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp
{
    public class MyList
    {
        private const int InitialCapacity = 2;

        private int[] items;

        public MyList()
        {
            items = new int[InitialCapacity];
        }

        public int Count { get; private set; }

        public int this[int index]
        {
            get
            {
                if (index >= this.Count)
                    throw new ArgumentOutOfRangeException();

                return items[index];
            }
            set
            {
                if (index >= this.Count)
                    throw new ArgumentOutOfRangeException();

                items[index] = value;
            }
        }

        //Public methods:
        public void Add(int item)
        {
            if (this.Count == this.items.Length)
            {
                //We need recizing:
                this.Resize();
            }

            this.items[this.Count] = item;
            this.Count++;
        }

        public int RemoveAt(int index)
        {
            if (!IsIndexValid(index))
            {
                throw new ArgumentOutOfRangeException();
            }

            int removedItem = this.items[index];
            this.items[index] = (int)default;

            this.Shift(index);
            this.Count--;

            if (this.Count <= this.items.Length / 4)
            {
                this.Shrink(index);
            }

            return removedItem;
        }

        public void InsertAt(int index, int value)
        {
            if (!IsIndexValid(index))
            {
                throw new ArgumentOutOfRangeException();
            }

            if (this.Count == this.items.Length)
            {
                this.Resize();
            }

            this.Count++;
            this.ShiftRight(index);
            this.items[index] = value;
        }

        


        //Private methods:
        private void Resize()
        {
            var copy = new int[items.Length * 2];

            for (int i = 0; i < items.Length; i++)
            {
                copy[i] = items[i];
            }

            this.items = copy;
        }

        private bool IsIndexValid(int index)
        {
            if (index < 0 || index >= this.items.Length)
            {
                return false;
            }

            return true;
        }

        private void Shift(int index)
        {
            for (int i = index; i < this.Count - 1; i++)
            {
                this.items[i] = this.items[i + 1];
            }
        }

        private void Shrink(int index)
        {
            var copy = new int[items.Length / 2];

            for (int i = 0; i < this.Count; i++)
            {
                copy[i] = items[i];
            }

            this.items = copy;
        }

        private void ShiftRight(int index)
        {
            for (int i = this.Count - 1; i > index; i--)
            {
                this.items[i] = this.items[i - 1];
            }
        }
    }
}