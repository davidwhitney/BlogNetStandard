﻿using System;

namespace BlogNetStandard.DataModel
{
    public class ContentBucketId
    {
        public string Id { get; set; }

        public ContentBucketId(string id = null)
        {
            Id = id ?? Guid.NewGuid().ToString();
        }

        public static ContentBucketId Of(string id) => new ContentBucketId(id);
        public static explicit operator ContentBucketId(string stringId) => new ContentBucketId(stringId);
        public static explicit operator string(ContentBucketId id) => id.Id;
    }
}