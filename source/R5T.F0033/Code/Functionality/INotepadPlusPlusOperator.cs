using System;

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
		public void Open(string filePath)
        {
			var enquotedFilePath = F0000.Instances.StringOperator.EnsureEnquoted(filePath);

			F0000.Instances.CommandLineOperator.Run_Synchronous(
				Instances.ExecutableFilePaths.NotepadPlusPlus,
				enquotedFilePath);
        }
	}
}