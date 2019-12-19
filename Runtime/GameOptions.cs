using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameOptionsUtility
{
    public static class GameOptions
    {
        public class Preferences
        {
            public const string prefix = "GameOptions.";
        }

        public static GraphicOptions graphics;

        [RuntimeInitializeOnLoadMethod]
        static void InitializeGameOptions()
        {
            graphics = GraphicOptions.Load();
            graphics.Apply();
        }
    }
}

