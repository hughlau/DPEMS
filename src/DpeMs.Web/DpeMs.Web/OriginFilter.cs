using Fluid;
using Fluid.Values;
using OrchardCore.Liquid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;


namespace DpeMs.Web
{
    public class OriginFilter : ILiquidFilter
    {
        public Task<FluidValue> ProcessAsync(FluidValue input, FilterArguments arguments, TemplateContext ctx)
        {
            var text = input.ToStringValue();

            return Task.FromResult<FluidValue>(new StringValue(text));
        }
    }
}
