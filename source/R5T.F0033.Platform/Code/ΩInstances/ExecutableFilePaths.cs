using System;


namespace R5T.F0033.Platform
{
    public class ExecutableFilePaths : IExecutableFilePaths
    {
        #region Infrastructure

        public static IExecutableFilePaths Instance { get; } = new ExecutableFilePaths();


        private ExecutableFilePaths()
        {
        }

        #endregion
    }
}
