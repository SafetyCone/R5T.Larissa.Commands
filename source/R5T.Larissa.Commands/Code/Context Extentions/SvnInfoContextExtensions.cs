using System;

using R5T.Heraklion;
using R5T.Heraklion.Extensions;


namespace R5T.Larissa.Commands
{
    public static class SvnInfoContextExtensions
    {
        public static ICommandBuilderContext<SvnInfoContext> SetPath(this ICommandBuilderContext<SvnInfoContext> infoContext, string path)
        {
            infoContext.AppendPath(path);

            return infoContext;
        }

        public static ICommandBuilderContext<SvnInfoContext> SetNameValue(this ICommandBuilderContext<SvnInfoContext> infoContext, string name, string value)
        {
            infoContext.AppendNameValuePair(name, value);

            return infoContext;
        }

        public static ICommandBuilderContext<SvnInfoContext> SetShowItemUrl(this ICommandBuilderContext<SvnInfoContext> infoContext)
        {
            infoContext.SetNameValue("--show-item", "url");

            return infoContext;
        }
    }
}
