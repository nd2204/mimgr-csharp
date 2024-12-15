﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.mvc.views;
public partial class FormDashboard : Form {
    private Panel contentPanel = new Panel { Dock = DockStyle.Fill, AutoScroll = true }; 
    public FormDashboard() {
        InitializeComponent();

        this.Controls.Add(contentPanel);
    }
}
