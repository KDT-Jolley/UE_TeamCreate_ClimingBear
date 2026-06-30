using UnrealBuildTool;

public class Climbing_BearServerTarget : TargetRules
{
	public Climbing_BearServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Climbing_Bear");
	}
}
