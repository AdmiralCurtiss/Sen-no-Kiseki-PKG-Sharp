namespace PKGLib.Definitions.Native
{
    public enum CompressionType
    {
        /// <summary>
        /// No compression; do not include 12 byte header.
        /// </summary>
        NoCompression = 0,

        /// <summary>
        /// Standard Sen no Kiseki/Phyre runtime encoding compression.
        /// </summary>
        CompressionRLE = 1,

        /// <summary>
        /// Not supported.
        /// Used in the PS3 version of Sen II to store scripts and text.
        /// </summary>
        CompressionUnknown = 2,

        /// <summary>
        /// Standard Sen no Kiseki/Phyre runtime encoding compression with extra 4 bytes (checksum?) in front of it.
        /// </summary>
        CompressionRLE2 = 3,
    }
}
