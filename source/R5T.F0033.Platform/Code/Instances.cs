using System;


namespace R5T.F0033.Platform
{
    public static class Instances
    {
        public static L0066.ICommandLineOperator CommandLineOperator => L0066.CommandLineOperator.Instance;
        public static IExecutableFilePaths ExecutableFilePaths => Platform.ExecutableFilePaths.Instance;
        public static L0066.IFileOperator FileOperator => L0066.FileOperator.Instance;
        public static L0066.IFileSystemOperator FileSystemOperator => L0066.FileSystemOperator.Instance;
        public static L0066.IStringOperator StringOperator => L0066.StringOperator.Instance;
    }
}