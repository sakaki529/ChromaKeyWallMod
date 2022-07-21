using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace ChromaKeyWallMod
{
    [Label("Config")]
    public class ClientConfiguration : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;
        public override void OnLoaded() => ChromaKeyWallMod.ClientConfig = this;
        [Label("Toggle wall lighting")]
        [DefaultValue(true)]
        public bool WallLighting { get; set; }
        
        [Label("Light intensity")]
        [Range(0f, 10.0f)]
        [DefaultValue(1.0f)]
        public float IntensityFloat { get; set; }
    }
}
