// Unity C# reference source
// Copyright (c) Unity Technologies. For terms of use, see
// https://unity3d.com/legal/licenses/Unity_Reference_Only_License

using System;
using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    public partial class PlayerSettings : UnityEngine.Object
    {
        [NativeHeader("Runtime/Misc/PlayerSettings.h")]
        [StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)]
        public class macOS
        {
            public static string buildNumber
            {
                get { return PlayerSettings.GetBuildNumber(BuildTargetGroup.Standalone); }
                set { PlayerSettings.SetBuildNumber(BuildTargetGroup.Standalone, value); }
            }

            [NativeProperty("MacAppStoreCategory")]
            extern internal static string applicationCategoryType  { get; set; }

            // these two are internal because we are not yet sure if we want to have them back in general PlayerSettings
            // as we have several platforms that might want to use it
            [NativeProperty("CameraUsageDescription")]
            internal extern static string cameraUsageDescription { get; set; }

            [NativeProperty("MicrophoneUsageDescription")]
            internal extern static string microphoneUsageDescription { get; set; }
        }
    }
}
