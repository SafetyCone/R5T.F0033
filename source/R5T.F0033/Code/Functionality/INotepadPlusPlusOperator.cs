using System;

using R5T.T0132;
using R5T.T0180;


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
	}
}