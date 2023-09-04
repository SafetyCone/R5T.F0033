using System;


namespace R5T.F0033
{
    public class NotepadPlusPlusOperator : INotepadPlusPlusOperator
    {
        #region Infrastructure

        public static INotepadPlusPlusOperator Instance { get; } = new NotepadPlusPlusOperator();

        private NotepadPlusPlusOperator()
        {
        }

        #endregion
    }
}