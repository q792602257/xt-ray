﻿/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/. */

using System.Windows;
using System.Windows.Media;

namespace Xtv.Windows
{
    public class TraceViewModel
    {
        public string Call { get; } = "file_get_contents";
        public bool HasParameters { get; } = true;
        public string Parameters { get; } = "'my_awesome_file','wtf_param_is_this'";
        public string FileInfo { get; } = "/home/www/myapp/wwwroot/index.php @ L37";
        public Brush BackColor { get; } = Brushes.Beige;
        public bool IsExpandable { get; } = true;
        public bool IsExpanded { get; set; } = true;
        public Visibility Expanded { get; } = Visibility.Visible;
        public Visibility ProfileInfoVisibility { get; } = Visibility.Visible;
        public string TimingInfo { get; } = "0.34ms / 13.66ms";
        public double TotalTimingPercent { get; } = 65f;
        public double ParentTimingPercent { get; } = 25f;
    }
}
