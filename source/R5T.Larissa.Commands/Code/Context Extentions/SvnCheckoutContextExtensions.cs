using System;

using R5T.Heraklion;
using R5T.Heraklion.Extensions;


namespace R5T.Larissa.Commands
{
    public static class SvnCheckoutContextExtensions
    {
        public static ICommandBuilderContext<SvnCheckoutContext> SetRepositoryUrl(this ICommandBuilderContext<SvnCheckoutContext> svnCheckoutContext, string repositoryUrl)
        {
            svnCheckoutContext.Append(repositoryUrl);

            return svnCheckoutContext;
        }

        public static ICommandBuilderContext<SvnCheckoutContext> SetLocalDirectoryPath(this ICommandBuilderContext<SvnCheckoutContext> svnCheckoutContext, string localDirectoryPath)
        {
            svnCheckoutContext.AppendPath(localDirectoryPath);

            return svnCheckoutContext;
        }
    }
}
