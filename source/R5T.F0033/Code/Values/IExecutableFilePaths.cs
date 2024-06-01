using System;

using R5T.T0131;
using R5T.T0181;
using R5T.T0181.Extensions;


namespace R5T.F0033
{
	[ValuesMarker]
	public partial interface IExecutableFilePaths : IValuesMarker
	{
        public IExecutableFilePath NotepadPlusPlus => Instances.NotepadPlusPlusOperator.Get_NotepadPlusPlusExecutableFilePath()
			.ToExecutableFilePath();
    }
}