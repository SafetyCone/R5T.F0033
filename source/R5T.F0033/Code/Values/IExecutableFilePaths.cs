using System;

using R5T.T0131;
using R5T.T0181;
using R5T.T0181.Extensions;


namespace R5T.F0033
{
	[ValuesMarker]
	public partial interface IExecutableFilePaths : IValuesMarker
	{
		private static Platform.IExecutableFilePaths Platform => F0033.Platform.ExecutableFilePaths.Instance;


		public IExecutableFilePath NotepadPlusPlus => Platform.NotepadPlusPlus.ToExecutableFilePath();
	}
}