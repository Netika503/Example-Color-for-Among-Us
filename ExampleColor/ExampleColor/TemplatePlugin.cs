//hi there!, i made a example for you on how to make a new color in reactor version of BepInEx
using BepInEx;
using BepInEx.IL2CPP;
using HarmonyLib;
using UnityEngine;
using Reactor;

namespace ExampleColor
{
    [BepInPlugin(Id)]
    [BepInProcess("Among Us.exe")]
    [BepInDependency(ReactorPlugin.Id)]
    public class ExampleColor : BasePlugin
    {
        public const string Id = "gg.Example.colors";
        public Harmony Harmony { get; } = new Harmony(Id);

		//this is where we start the adding colors
		//there will be a new color called "fortgreen"
        public override void Load()
        {
		    //this are the short names
			string[] shortColorNames =
			{
			//we need to add the vanilla colors so that the new color won't replace it
			"RED",
			"DBLUE",
			"GRN",
			"PINK",
			"ORNG",
			"YLOW",
			"BLAK",
			"WHTE",
			"PURP",
			"BRWN",
			"CYAN",
			"LIME",
			//at the buttom of this text is the fortgreen
			"FRTE",

			};
			//this are the long names
            string[] colorNames =
            {
			"Red",
			"Dark Blue",
			"Green",
			"Pink",
			"Orange",
			"Yellow",
			"Black",
			"White",
			"Purple",
			"Brown",
			"Cyan",
			"Lime",
			//at the buttom of this text is the fortgreen (with full name)
			"Fortegreen"

		};
            Color32[] playerColors =
            {
				//this one are the colors
			new Color32(240, 19, 19, byte.MaxValue),
			new Color32(19, 46, 210, byte.MaxValue),
			new Color32(0, 92, 23, byte.MaxValue),
			new Color32(238, 84, 187, byte.MaxValue),
			new Color32(250, 167, 0, byte.MaxValue),
			new Color32(246, 246, 87, byte.MaxValue),
			new Color32(63, 71, 78, byte.MaxValue),
			new Color32(215, 225, 241, byte.MaxValue),
			new Color32(107, 47, 188, byte.MaxValue),
			new Color32(77, 50, 21, byte.MaxValue),
			new Color32(56, 254, 220, byte.MaxValue),
			new Color32(80, 240, 57, byte.MaxValue),
			//at the buttom of this text is the number color of the fortgreen
			new Color32(29, 152, 83, byte.MaxValue),

			//this are the one who add the shadow detail, if you remove them all (except the one thats in very buttom)
			//the shadow detail will desappear
			};
            Color32[] shadowColors =
            {
			new Color32(122, 8, 56, byte.MaxValue),
			new Color32(9, 21, 142, byte.MaxValue),
			new Color32(0, 56, 14, byte.MaxValue),
			new Color32(172, 43, 174, byte.MaxValue),
			new Color32(180, 62, 21, byte.MaxValue),
			new Color32(195, 136, 34, byte.MaxValue),
			new Color32(30, 31, 38, byte.MaxValue),
			new Color32(132, 149, 192, byte.MaxValue),
			new Color32(59, 23, 124, byte.MaxValue),
			new Color32(56, 37, 16, byte.MaxValue),
			new Color32(36, 168, 190, byte.MaxValue),
			new Color32(21, 168, 66, byte.MaxValue),
			new Color32(18, 63, 27, byte.MaxValue),
			};
			//this one is the one who loads the colors
            Palette.ShortColorNames = shortColorNames;
            Palette.PlayerColors = playerColors;
            Palette.ShadowColors = shadowColors;
            MedScanMinigame.ColorNames = colorNames;
            Telemetry.ColorNames = colorNames;

			//a default code
            RegisterInIl2CppAttribute.Register();
            Harmony.PatchAll();
        }
    }
}