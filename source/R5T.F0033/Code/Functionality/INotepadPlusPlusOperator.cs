using System;
using System.Collections.Generic;
using System.Linq;

using R5T.T0132;
using R5T.T0179.Extensions;
using R5T.T0180;
using R5T.T0181;


namespace R5T.F0033
{
	/// <summary>
	/// Operator for the Notepad++ program.
	/// </summary>
	/// <remarks>
	/// Prior work in R5T.D0105.
	/// </remarks>
	[FunctionalityMarker]
	public partial interface INotepadPlusPlusOperator : IFunctionalityMarker,
        Platform.INotepadPlusPlusOperator
	{
		public void Open(IFilePath filePath)
		{
			this.Open(filePath.Value);
		}

        public void Open(IEnumerable<IFilePath> filePaths)
        {
			var values = filePaths.Enumerate_Values();

			this.Open(values);
        }

        public void Open(params IFilePath[] filePaths)
        {
            this.Open(filePaths.AsEnumerable());
        }

        public void WriteLinesAndOpen(
            ITextFilePath textFilePath,
            IEnumerable<string> lines)
        {
            this.WriteLinesAndOpen(
                textFilePath.Value,
                lines);
        }
    }
}