﻿using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Extensions
{
    public static class ServiceCollectionExtensions
    {

        public static IServiceCollection AddDependencyResolvers(this IServiceCollection services, ICoreModule[] coreModule)
        {

            foreach (var module in coreModule)
            {
                module.Load(services);
            }
            return ServiceTool.Create(services);

        }

    }
}
