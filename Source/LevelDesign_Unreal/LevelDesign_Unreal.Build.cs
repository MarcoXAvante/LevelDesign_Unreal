// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class LevelDesign_Unreal : ModuleRules
{
	public LevelDesign_Unreal(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"LevelDesign_Unreal",
			"LevelDesign_Unreal/Variant_Horror",
			"LevelDesign_Unreal/Variant_Horror/UI",
			"LevelDesign_Unreal/Variant_Shooter",
			"LevelDesign_Unreal/Variant_Shooter/AI",
			"LevelDesign_Unreal/Variant_Shooter/UI",
			"LevelDesign_Unreal/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
