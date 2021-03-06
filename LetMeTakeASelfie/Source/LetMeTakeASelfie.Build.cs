// Copyright 1998-2015 Epic Games, Inc. All Rights Reserved.

using System.IO;

namespace UnrealBuildTool.Rules
{
	public class LetMeTakeASelfie : ModuleRules
	{
        public LetMeTakeASelfie(TargetInfo Target)
        {
			PublicDependencyModuleNames.AddRange(
				new string[]
				{
					"Core",
					"CoreUObject",
                    "Engine",
                    "UnrealTournament",
					"InputCore",
					"SlateCore",
					"RenderCore",
					"RHI"
				}
				);

            var LIBPath = Path.Combine("..", "..", "UnrealTournament", "Plugins", "UTLetMeTakeASelfie", "LetMeTakeASelfie", "Source", "lib");

            var GDLibPath = Path.Combine(LIBPath, "libgd.lib");
            var VPXLibPath = Path.Combine(LIBPath, "vpxmd.lib");
            var CurlLibPath = Path.Combine(LIBPath, "libcurl.lib");
            //var VPXLibPath = Path.Combine(LIBPath, "vpxmdd.lib");

			// Lib file
            PublicLibraryPaths.Add(LIBPath);
            PublicAdditionalLibraries.Add(GDLibPath);
            PublicAdditionalLibraries.Add(VPXLibPath);
            PublicAdditionalLibraries.Add(CurlLibPath);
            Definitions.Add("BGDWIN32");
            //Definitions.Add("NONDLL");
		}
	}
}