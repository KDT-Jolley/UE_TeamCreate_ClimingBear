using UnrealBuildTool;

public class Climbing_BearTarget : TargetRules
{
	public Climbing_BearTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Climbing_Bear");
	}
}
