﻿using System;
using BlogNetStandard.BackingStores;
using BlogNetStandard.BackingStores.InMemory;

namespace BlogNetStandard
{
    public class ContentConfiguration
    {
        public Type BackingStoreSessionType { get; set; }
        public Type BackingStoreSearchProvider { get; set; }
        
        public static ContentConfiguration MemoryStore()
        {
            return new ContentConfiguration
            {
                BackingStoreSessionType = typeof(InMemoryBackingStore),
                BackingStoreSearchProvider = typeof(NullSearchProvider)
            };
        }
    }
}
