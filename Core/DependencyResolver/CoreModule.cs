﻿using Core.CrossCuttingConcerns;
using Core.CrossCuttingConcerns.Microsoft;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Core.DependencyResolver.ServiceCollectionExtensions;

namespace Core.DependencyResolver
{
    public static class ServiceCollectionExtensions
    {

        public class CoreModule : ICoreModule
        {
            public void Load(IServiceCollection serviceCollection)
            {
                serviceCollection.AddMemoryCache();
                serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
                serviceCollection.AddSingleton<ICacheManager, MemoryCacheManager>();
            }
        }

    }
}
