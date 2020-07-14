﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cache
{
    /// <summary>
    /// Contains the key/value pair of the item that expired and has been removed from the dictionary.
    /// </summary>
    /// <typeparam name="K"></typeparam>
    /// <typeparam name="T"></typeparam>
    public class CacheItemRemovedEventArgs<K, T> : EventArgs
    {
        public K Key { get; set; }
        public T Value { get; set; }
    }
}
