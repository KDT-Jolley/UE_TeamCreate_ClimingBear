using UnrealBuildTool;

public class Climbing_BearEditorTarget : TargetRules
{
	public Climbing_BearEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Climbing_Bear");
	}
}
