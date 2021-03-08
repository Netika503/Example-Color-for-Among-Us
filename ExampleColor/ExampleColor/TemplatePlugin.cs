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
                "BLUE",
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
                "LPUR"
            };
            string[] colorNames =
            {
                "Red",
                "Blue",
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
                "Light Purple"
            };
            Color32[] playerColors =
            {
                new Color32(198, 17, 17, byte.MaxValue),
                new Color32(19, 46, 210, byte.MaxValue),
                new Color32(17, 128, 45, byte.MaxValue),
                new Color32(238, 84, 187, byte.MaxValue),
                new Color32(240, 125, 13, byte.MaxValue),
                new Color32(246, 246, 87, byte.MaxValue),
                new Color32(63, 71, 78, byte.MaxValue),
                new Color32(215, 225, 241, byte.MaxValue),
                new Color32(107, 47, 188, byte.MaxValue),
                new Color32(113, 73, 30, byte.MaxValue),
                new Color32(56, byte.MaxValue, 221, byte.MaxValue),
                new Color32(80, 240, 57, byte.MaxValue),
                new Color32(146, 109, 209, byte.MaxValue),
            };
            Color32[] shadowColors =
            {
                new Color32(122, 8, 56, byte.MaxValue),
                new Color32(9, 21, 142, byte.MaxValue),
                new Color32(10, 77, 46, byte.MaxValue),
                new Color32(172, 43, 174, byte.MaxValue),
                new Color32(180, 62, 21, byte.MaxValue),
                new Color32(195, 136, 34, byte.MaxValue),
                new Color32(30, 31, 38, byte.MaxValue),
                new Color32(132, 149, 192, byte.MaxValue),
                new Color32(59, 23, 124, byte.MaxValue),
                new Color32(94, 38, 21, byte.MaxValue),
                new Color32(36, 169, 191, byte.MaxValue),
                new Color32(21, 168, 66, byte.MaxValue),
                new Color32(114, 85, 163, byte.MaxValue),
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