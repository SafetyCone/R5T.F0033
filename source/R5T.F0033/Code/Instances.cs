using System;


namespace R5T.F0033
{
    public static class Instances
    {
        public static IExecutableFilePaths ExecutableFilePaths { get; } = F0033.ExecutableFilePaths.Instance;
        public static L0053.IFileOperator FileOperator { get; } = L0053.FileOperator.Instance;
        public static INotepadPlusPlusOperator NotepadPlusPlusOperator { get; } = F0033.NotepadPlusPlusOperator.Instance;
    }
}