using Terraria.ModLoader;

namespace ChromaKeyWallMod
{
    class ChromaKeyWallMod : Mod
	{
        internal static Mod Instance;
        internal static ClientConfiguration ClientConfig;
        public ChromaKeyWallMod()
        {
            Instance = this;
        }
        public override void Unload()
        {
            Instance = null;
            ClientConfig = null;
        }
    }
}