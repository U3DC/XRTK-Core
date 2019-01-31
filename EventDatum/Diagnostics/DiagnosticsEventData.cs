﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using UnityEngine.EventSystems;
using XRTK.Interfaces.Diagnostics;

namespace XRTK.EventDatum.Diagnostics
{
    public class DiagnosticsEventData : GenericBaseEventData
    {
        public bool Visible { get; private set; }

        public bool ShowCpu { get; private set; }

        public bool ShowFps { get; private set; }

        public bool ShowMemory { get; private set; }

        public DiagnosticsEventData(EventSystem eventSystem) : base(eventSystem) { }

        public void Initialize(
            IMixedRealityDiagnosticsSystem diagnosticsSystem,
            bool visible,
            bool showCpu,
            bool showFps,
            bool showMemory)
        {
            BaseInitialize(diagnosticsSystem);
            Visible = visible;
            ShowCpu = showCpu;
            ShowFps = showFps;
            ShowMemory = showMemory;
        }
    }
}
