// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections;
using System.Security.Principal;
using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.SystemWebAdapters;

namespace System.Web
{
    [SuppressMessage("Design", "CA1065:Do not raise exceptions in unexpected locations", Justification = Constants.ApiFromAspNet)]
    public class HttpContextBase : IServiceProvider
    {
        protected HttpContextBase()
        {
        }

        public virtual HttpRequestBase Request => throw new NotImplementedException();

        public virtual HttpResponseBase Response => throw new NotImplementedException();

        public virtual IDictionary Items => throw new NotImplementedException();

        public virtual DateTime Timestamp => throw new NotImplementedException();

        public virtual IPrincipal User
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public virtual bool IsDebuggingEnabled => throw new NotImplementedException();

        public virtual HttpServerUtilityBase Server => throw new NotImplementedException();

        public virtual HttpSessionStateBase? Session => throw new NotImplementedException();

        public virtual object? GetService(Type serviceType) => throw new NotImplementedException();

        [return: NotNullIfNotNull("context")]
        public static implicit operator HttpContextBase?(HttpContextCore? context) => context?.GetAdapterBase();

        public virtual System.Web.Caching.Cache Cache => throw new NotImplementedException();
    }
}
