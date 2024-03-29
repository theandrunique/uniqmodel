﻿using System;

namespace UniqModel
{
    [AttributeUsage(AttributeTargets.Property)]
    public class PrimaryKeyAttribute : FieldAttribute
    {
        public PrimaryKeyAttribute() { }
        public PrimaryKeyAttribute(string columnName) : base(columnName) { }
    }
}
