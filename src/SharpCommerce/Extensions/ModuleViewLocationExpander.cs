﻿using Microsoft.AspNetCore.Mvc.Razor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SharpCommerce.Extensions
{
    public class ModuleViewLocationExpander : IViewLocationExpander
    {
        private const string _moduleKey = "module";

        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            if (context.Values.ContainsKey(_moduleKey))
            {
                var module = context.Values[_moduleKey];
                if (!string.IsNullOrWhiteSpace(module))
                {
                    var moduleViewLocations = new string[]
                    {
                    "/Modules/SharpCommerce.Modules." + module + "/Views/{1}/{0}.cshtml",
                    "/Modules/SharpCommerce.Modules." + module + "/Views/Shared/{0}.cshtml",
                    };

                    viewLocations = moduleViewLocations.Concat(viewLocations);
                }
            }
            return viewLocations;
        }

        public void PopulateValues(ViewLocationExpanderContext context)
        {
            var controller = context.ActionContext.ActionDescriptor.DisplayName;
            var moduleName = controller.Split('.')[2];
            if (moduleName != "SharpCommerce")
                context.Values[_moduleKey] = moduleName;
        }
    }
}
