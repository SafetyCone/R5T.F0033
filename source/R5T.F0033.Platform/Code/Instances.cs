using System;


namespace R5T.F0033.Platform
{
    public static class Instances
    {
        public static L0053.ICommandLineOperator CommandLineOperator => L0053.CommandLineOperator.Instance;
        public static IExecutableFilePaths ExecutableFilePaths => Platform.ExecutableFilePaths.Instance;
        public static L0053.IFileOperator FileOperator => L0053.FileOperator.Instance;
        public static L0053.IStringOperator StringOperator => L0053.StringOperator.Instance;
    }
}