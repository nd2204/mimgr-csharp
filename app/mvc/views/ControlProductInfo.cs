using app.components;
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
public partial class ControlProductInfo : UserControl {
    public TextBox TbName => tbName.TextBox; 
    public TextBox TbDescription => tbDescription.TextBox; 
    public TextBox TbImage => tbImage.TextBox; 
    public TextBox TbPrice => tbPrice.TextBox; 
    public TextBox TbStock => tbStock.TextBox;

    public MButton BtnCancel => btnCancel;
    public MButton BtnSubmit => btnSubmit;

    public ControlProductInfo() {
        InitializeComponent();
    }

    public void ClearInput() {
        TbName.Text = "";
        TbDescription.Text = "";
        TbImage.Text = "";
        TbPrice.Text = "";
        TbStock.Text = "";
    }
}
