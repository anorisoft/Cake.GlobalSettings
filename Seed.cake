///////////////////////////////////////////////////////////////////////////////
// GLOBAL SEED
///////////////////////////////////////////////////////////////////////////////
// Author: Martin Egli
// Description: The file makes it possible to centrally control the cake process of all repositories.


//#load nuget:?package=Anori.Cake.Recipe&version=0.1.24
#load ./Tools/GlobalSettings/Addins.cake

Environment.SetVariableNames();

BuildParameters.SetParameters(
	context: Context,
	 shouldRunGitVersion: false,
	buildSystem: BuildSystem,
	title: "Seeder"
);

//BuildParameters.PrintParameters(Context);

ToolSettings.SetToolSettings(context: Context);

Build.Run();