using System;

using R5T.Heraklion;
using R5T.Heraklion.Extensions;


namespace R5T.Larissa.Commands
{
    public static class SvnCommitContextExtensions
    {
        public static ICommandBuilderContext<SvnCommitContext> SetDepth(this ICommandBuilderContext<SvnCommitContext> svnCommitContext, string depth)
        {
            svnCommitContext.AppendNameQuotedValuePair("--depth", depth);

            return svnCommitContext;
        }

        public static ICommandBuilderContext<SvnCommitContext> SetDepthEmpty(this ICommandBuilderContext<SvnCommitContext> svnCommitContext)
        {
            svnCommitContext.SetDepth("empty");

            return svnCommitContext;
        }

        public static ICommandBuilderContext<SvnCommitContext> SetMessage(this ICommandBuilderContext<SvnCommitContext> svnCommitContext, string message)
        {
            svnCommitContext.AppendNameQuotedValuePair("--message", message);

            return svnCommitContext;
        }
    }
}


