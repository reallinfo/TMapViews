﻿using System;
using System.Runtime.Serialization;

namespace TMapViews.Droid.Views
{
    [Serializable]
    internal class OverlayAdapterException : System.Exception
    {
        private Java.Lang.Object overlay;

        public OverlayAdapterException()
        {
        }

        public OverlayAdapterException(Java.Lang.Object overlay)
        {
            this.overlay = overlay;
        }

        public OverlayAdapterException(string message) : base(message)
        {
        }

        public OverlayAdapterException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected OverlayAdapterException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}