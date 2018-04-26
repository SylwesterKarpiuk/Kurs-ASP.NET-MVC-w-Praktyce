﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpodIglyMVC.Infrastructure
{
    public interface ICacheProvider
    {
        object Get(string key);
        void Set(string Key, object Data, int cacheTime);
        bool IsSet(string key);
        void Invalidate(string key);
    }
}