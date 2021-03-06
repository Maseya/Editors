﻿// <copyright file="AboutDialog.cs" company="Public Domain">
//     Copyright (c) 2019 Nelson Garcia. All rights reserved. Licensed under
//     GNU Affero General Public License. See LICENSE in project root for full
//     license information, or visit https://www.gnu.org/licenses/#AGPL
// </copyright>

namespace Maseya.MushROMs
{
    using System.Windows.Forms;

    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();
        }

        private void AboutDialog_KeyDown(object sender, KeyEventArgs e)
        {
            // We don't have a `Cancel` button so we need to manually implement
            // this closing logic.
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
