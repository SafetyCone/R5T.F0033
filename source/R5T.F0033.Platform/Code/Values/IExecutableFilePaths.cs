using System;

using R5T.T0131;


namespace R5T.F0033.Platform
{
    [ValuesMarker]
    public partial interface IExecutableFilePaths : IValuesMarker
    {
        /// <summary>
        /// Chooses 64-bit as the default.
        /// <inheritdoc cref="NotepadPlusPlus_Win64" path="descendant::value"/>
        /// </summary>
        public string NotepadPlusPlus => this.NotepadPlusPlus_Win64;

        /// <summary>
        /// <para><value>C:\Program Files (x86)\Notepad++\notepad++.exe</value></para>
        /// </summary>
        public string NotepadPlusPlus_Win32 => @"C:\Program Files (x86)\Notepad++\notepad++.exe";

        /// <summary>
        /// <para><value>C:\Program Files\Notepad++\notepad++.exe</value></para>
        /// </summary>
        public string NotepadPlusPlus_Win64 => @"C:\Program Files\Notepad++\notepad++.exe";
    }
}
