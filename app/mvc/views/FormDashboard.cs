﻿using app.globals;
using System;
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
    public FormDashboard() {
        InitializeComponent();
    }

    private void btnLogout_Click(object sender, EventArgs e) {
        SessionManager.Instance.ClearSession();
        Console.WriteLine("User logged out, session cleared.");
        FormManager.Instance.LoadForm(FormManager.Instance.Login);
    }
}
