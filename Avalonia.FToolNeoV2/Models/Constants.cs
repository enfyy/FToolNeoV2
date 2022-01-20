﻿using System;

namespace Avalonia.FToolNeoV2.Models;

public class Constants
{
    /// <summary>
    /// Message that is sent to the process that represents a key being pressed down.
    /// </summary>
    public const UInt32 WM_KEYDOWN = 0x0100;

    /// <summary>
    /// Name of the file 
    /// </summary>
    public const string PERSISTENT_FILE_NAME = "ftool-settings.json";

    /// <summary>
    /// Name of the assembly. used to load resources.
    /// </summary>
    public const string ASSEMBLY_NAME = "Avalonia.FToolNeoV2";
    
    /// <summary>
    /// Default volume of audio playback.
    /// </summary>
    public const float AUDIO_VOLUME = 0.4f;

    /// <summary>
    /// Github link to the source code.
    /// </summary>
    public const string GITHUB_LINK = "https://github.com/enfyy/FToolNeoV2";

    /// <summary>
    /// Kofi link.
    /// </summary>
    public const string KOFI_LINK = "https://ko-fi.com/enfyr";
}