using System;

using R5T.Heraklion;
using R5T.Heraklion.Extensions;


namespace R5T.Larissa.Commands
{
    public static class SvnAddContextExtensions
    {
        public static ICommandBuilderContext<SvnAddContext> SetPath(this ICommandBuilderContext<SvnAddContext> svnAddContext, string path)
        {
            svnAddContext.AppendPath(path);

            return svnAddContext;
        }
    }
}
