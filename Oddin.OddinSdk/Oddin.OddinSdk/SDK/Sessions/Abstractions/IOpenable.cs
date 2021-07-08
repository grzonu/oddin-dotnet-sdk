﻿namespace Oddin.OddinSdk.SDK.Sessions.Abstractions
{
    internal interface IOpenable
    {
        /// <summary>
        /// Opens the instance
        /// </summary>
        void Open();

        /// <summary>
        /// Closes the the instance
        /// </summary>
        void Close();
    }
}
