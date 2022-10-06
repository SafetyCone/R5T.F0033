using System;

using R5T.T0131;


namespace R5T.F0033
{
	[ValuesMarker]
	public partial interface IExecutableFilePaths : IValuesMarker
	{
		public string NotepadPlusPlus => @"C:\Program Files (x86)\Notepad++\notepad++.exe";
	}
}