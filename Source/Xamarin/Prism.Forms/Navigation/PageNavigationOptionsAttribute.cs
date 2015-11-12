﻿using System;

namespace Prism.Navigation
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class PageNavigationOptionsAttribute : Attribute
    {
        public bool Animated { get; set; } = true;

        public bool UseModalNavigation { get; set; } = true;

        public PageNavigationOptionsAttribute()
        {
            
        }
    }
}
