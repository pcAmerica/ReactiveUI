﻿using System;
using System.Collections.Specialized;

#if UIKIT || PORTABLE || WINRT || ANDROID

namespace ReactiveUI
{
    public class PropertyChangingEventArgs : EventArgs
    {
        public PropertyChangingEventArgs(string PropertyName)
        {
            this.PropertyName = PropertyName;
        }

        public string PropertyName { get; protected set; }
    }

    public delegate void PropertyChangingEventHandler(
    	Object sender,
    	PropertyChangingEventArgs e
    );

    public interface INotifyPropertyChanging {
        event PropertyChangingEventHandler PropertyChanging;
    }
}

#endif

namespace ReactiveUI
{    
    public interface INotifyCollectionChanging {
        event NotifyCollectionChangedEventHandler CollectionChanging;
    }
}

#if PORTABLE || WINRT
namespace ReactiveUI
{
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public sealed class LocalizableAttribute : Attribute
    {
        // This is a positional argument
        public LocalizableAttribute(bool isLocalizable)
        {
        }
    }
}
#endif

// vim: tw=120 ts=4 sw=4 et :
