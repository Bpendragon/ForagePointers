namespace ForagePointers
{
    internal class ModConfig
    {
        public int ScaleEveryNLevels { get; set; } = 2;
        public int ScalingRadius { get; set; } = 1;
        public int MinimumViewDistance { get; set; } = 3;
        public bool AlwaysShow { get; set; } = false;
        public bool BlinkPointers { get; set; } = true;
        public int NumFramesArrowsOn { get; set; } = 50;
        public int NumFramesArrowsOff { get; set; } = 20;
        public bool ShowArtifactSpots { get; set; } = true;
        public bool ShowSeedSpots { get; set; } = true;
    }
}
