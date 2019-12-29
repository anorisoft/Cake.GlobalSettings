///////////////////////////////////////////////////////////////////////////////
// GLOBAL ADDINS
///////////////////////////////////////////////////////////////////////////////
// Author: Martin Egli
// Description: The file makes it possible to centrally control the cake process of all repositories.

#load nuget:?package=Anori.Cake.Recipe&version=1.2.10

public static class GlobalSettings
{
    public static string Version { get; private set; } = "1.2.10";

    public static void PrintParameters(ICakeContext context)
    {
        	
		if (context == null)
        {
            throw new ArgumentNullException("context");
        }
        context.Information("Printing Global Settings...");
        context.Information("Version: {0}", Version);
	}

}
