﻿/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/. */

using System.Windows;

namespace XtRay.Windows
{
    public partial class ParamsDialog : Window
    {
        public ParamsDialog(string[] parameters)
        {
            InitializeComponent();
            ParamTextBox.Text = string.Join("\r\n", parameters);
        }
    }
}
