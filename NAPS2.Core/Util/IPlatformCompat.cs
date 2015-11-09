﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NAPS2.Util
{
    public interface IPlatformCompat
    {
        bool UseToolStripRenderHack { get; }
        bool AllowEmail { get; }
        bool UseWebClientAsync { get; }
        bool UseEmptyStringInListViewItems { get; }
        bool UseStandardTextAlign { get; }
    }
}
