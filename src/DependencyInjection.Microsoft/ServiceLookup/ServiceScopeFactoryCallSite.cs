// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Microsoft.Extensions.DependencyInjection;

namespace Dazinator.Extensions.DependencyInjection.Microsoft.ServiceLookup
{
    internal class ServiceScopeFactoryCallSite : ServiceCallSite
    {
        public ServiceScopeFactoryCallSite() : base(ResultCache.None)
        {
        }

        public override Type ServiceType { get; } = typeof(IServiceScopeFactory);
        public override Type ImplementationType { get; } = typeof(ServiceProviderEngine);
        public override CallSiteKind Kind { get; } = CallSiteKind.ServiceScopeFactory;
    }
}
