using System;

using R5T.Heraklion;
using R5T.Heraklion.Extensions;


namespace R5T.Larissa.Commands
{
    public static class SvnContextExtensions
    {
        public static ICommandBuilderContext<SvnAddContext> Add(this ICommandBuilderContext<SvnContext> svnContext)
        {
            var svnAddContext = svnContext
                .Append("add")
                .ChangeContext<SvnAddContext>()
                ;

            return svnAddContext;
        }

        public static ICommandBuilderContext<SvnAddContext> Add(this ICommandBuilderContext<SvnContext> svnContext, string path)
        {
            var svnAddContext = svnContext
                .Add()
                .SetPath(path)
                ;

            return svnAddContext;
        }

        public static ICommandBuilderContext<SvnCheckoutContext> Checkout(this ICommandBuilderContext<SvnContext> svnContext)
        {
            var svnCheckoutContext = svnContext
                .Append("checkout")
                .ChangeContext<SvnCheckoutContext>()
                ;

            return svnCheckoutContext;
        }

        public static ICommandBuilderContext<SvnCheckoutContext> Checkout(this ICommandBuilderContext<SvnContext> svnContext, string repositoryUrl, string localDirectoryPath)
        {
            var svnCheckoutContext = svnContext
                .Checkout()
                .SetRepositoryUrl(repositoryUrl)
                .SetLocalDirectoryPath(localDirectoryPath)
                ;

            return svnCheckoutContext;
        }

        public static ICommandBuilderContext<SvnCommitContext> Commit(this ICommandBuilderContext<SvnContext> svnContext, string path)
        {
            var svnCommitContext = svnContext
                .Append("commit")
                .AppendQuotedValue(path)
                .ChangeContext<SvnCommitContext>()
                ;

            return svnCommitContext;
        }

        public static ICommandBuilderContext<SvnCommitContext> Commit(this ICommandBuilderContext<SvnContext> svnContext, string path, string message)
        {
            var svnCommitContext = svnContext
                .Commit(path)
                .SetMessage(message)
                ;

            return svnCommitContext;
        }

        public static ICommandBuilderContext<SvnInfoContext> Info(this ICommandBuilderContext<SvnContext> context)
        {
            var infoContext = context
                .Append("info")
                .ChangeContext<SvnInfoContext>()
                ;

            return infoContext;
        }

        public static ICommandBuilderContext<SvnInfoContext> Info(this ICommandBuilderContext<SvnContext> context, string path)
        {
            var infoContext = context
                .Info()
                .SetPath(path)
                ;

            return infoContext;
        }

        public static ICommandBuilderContext<TSvnContext> Quiet<TSvnContext>(this ICommandBuilderContext<TSvnContext> svnContext, bool quiet = false)
            where TSvnContext: SvnContext
        {
            if(quiet)
            {
                svnContext.Append("--quiet");
            }

            return svnContext;
        }

        public static ICommandBuilderContext<SvnUpdateContext> Update(this ICommandBuilderContext<SvnContext> svnContext)
        {
            var updateContext = svnContext
                .Append("update")
                .ChangeContext<SvnUpdateContext>()
                ;

            return updateContext;
        }

        public static ICommandBuilderContext<SvnUpdateContext> Update(this ICommandBuilderContext<SvnContext> svnContex, string path)
        {
            var updateContext = svnContex
                .Update()
                .SetPath(path)
                ;

            return updateContext;
        }

        public static ICommandBuilderContext<SvnContext> Version(this ICommandBuilderContext<SvnContext> svnContext, bool quiet = false)
        {
            svnContext
                .Append("--version")
                .Quiet(quiet)
                ;

            return svnContext;
        }
    }
}
