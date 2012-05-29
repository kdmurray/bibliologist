using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bibliologist
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
            PopulateDropdowns();
        }

        void PopulateDropdowns()
        {
            if (Global.Formats.Count > 0)
            {
                VolumeFormat.Items.AddRange(ListboxItem.ToArray(Global.Formats));
            }

            if (Global.Genres.Count > 0)
            {
                Genres.Items.AddRange(ListboxItem.ToArray(Global.Genres));
            }

            if (Global.Locations.Count > 0)
            {
                VolumeLocation.Items.AddRange(ListboxItem.ToArray(Global.Locations));
            }

            if (Global.Statuses.Count > 0)
            {
                VolumeStatus.Items.AddRange(ListboxItem.ToArray(Global.Statuses));
            }
        }
    }
}
