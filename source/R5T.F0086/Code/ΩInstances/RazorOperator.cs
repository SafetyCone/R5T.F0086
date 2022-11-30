using System;


namespace R5T.F0086
{
	public class RazorOperator : IRazorOperator
	{
		#region Infrastructure

	    public static IRazorOperator Instance { get; } = new RazorOperator();

	    private RazorOperator()
	    {
        }

	    #endregion
	}
}