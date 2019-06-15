﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Linear.LinkedList.Model
{
    public class Item<T> 
    {
        /// <summary>
        /// Data that stores in cell of linked list
        /// </summary>
        private T data = default(T);

        /// <summary>
        /// Next cell of list
        /// </summary>
        public Item<T> Next { get; set; }

        public T Data
        {
            get { return data; }
            set
            {
                if (value != null)
                    data = value;
                else
                    throw new ArgumentNullException(nameof(value));
            }
        }

        public Item(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }

    
    }
}
