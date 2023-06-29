using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

using R5T.F0000;
using R5T.T0132;


namespace R5T.F0033
{
	/// <summary>
	/// Operator for the Notepad++ program.
	/// </summary>
	/// <remarks>
	/// Prior work in R5T.D0105.
	/// </remarks>
	[FunctionalityMarker]
	public partial interface INotepadPlusPlusOperator : IFunctionalityMarker
	{
		public void Open()
		{
            CommandLineOperator.Instance.Run_Synchronous_NoWait(
                Instances.ExecutableFilePaths.NotepadPlusPlus);
        }

		public void Open(string filePath)
        {
			var enquotedFilePath = StringOperator.Instance.EnsureEnquoted(filePath);

			CommandLineOperator.Instance.Run_Synchronous_NoWait(
				Instances.ExecutableFilePaths.NotepadPlusPlus,
				enquotedFilePath);
        }

        public void Open_WithDelay(
            int delay_milliseconds,
            IEnumerable<string> filePaths)
        {
            foreach (var filePath in filePaths)
            {
                this.Open(filePath);

                Thread.Sleep(delay_milliseconds);
            }
        }

        public void Open_WithDelay(
            int delay_milliseconds,
            params string[] filePaths)
        {
            this.Open_WithDelay(
                delay_milliseconds,
                filePaths.AsEnumerable());
        }

        public void Open(IEnumerable<string> filePaths)
		{
            foreach (var filePath in filePaths)
            {
				this.Open(filePath);
            }
		}

		public void Open(params string[] filePaths)
        {
			this.Open(filePaths.AsEnumerable());
        }

        public void WriteLinesAndOpen(
            string textFilePath,
            IEnumerable<string> lines)
        {
            FileOperator.Instance.WriteLines_Synchronous(
                textFilePath,
                lines);

            this.Open(textFilePath);
        }

        public void WriteTextAndOpen(
			string textFilePath,
			string text)
		{
			FileOperator.Instance.WriteText_Synchronous(
				textFilePath,
				text);

			this.Open(textFilePath);
		}
	}
}