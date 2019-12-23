using System;

using R5T.Heraklion;
using R5T.Heraklion.Extensions;


namespace R5T.Larissa.Commands
{
    public static class SvnUpdateContextExtensions
    {
        public static ICommandBuilderContext<SvnUpdateContext> SetPath(this ICommandBuilderContext<SvnUpdateContext> updateContext, string path)
        {
            updateContext.AppendPath(path);

            return updateContext;
        }
    }
}
