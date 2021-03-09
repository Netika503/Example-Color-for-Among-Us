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
        public const string ModVersion = "1.0.3";
        public Harmony Harmony { get; } = new Harmony(Id);

        public override void Load()
        {

			string[] shortColorNames =
			{
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
			"FRTE",

			};
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
			"Fortegreen"

		};
            Color32[] playerColors =
            {
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
			new Color32(29, 152, 83, byte.MaxValue),
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
            Palette.ShortColorNames = shortColorNames;
            Palette.PlayerColors = playerColors;
            Palette.ShadowColors = shadowColors;
            MedScanMinigame.ColorNames = colorNames;
            Telemetry.ColorNames = colorNames;

            RegisterInIl2CppAttribute.Register();
            Harmony.PatchAll();
        }
    }
}