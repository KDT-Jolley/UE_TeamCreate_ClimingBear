using UnrealBuildTool;

public class Climbing_BearClientTarget : TargetRules
{
	public Climbing_BearClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Climbing_Bear");
	}
}
