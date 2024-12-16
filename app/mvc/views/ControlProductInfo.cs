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

    private void mButton1_Click(object sender, EventArgs e) {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Title = "Select a File";
        openFileDialog.Filter = "All Files (*.*)|*.*|Text Files (*.txt)|*.txt|Image Files (*.jpg;*.png)|*.jpg;*.png";
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        if (openFileDialog.ShowDialog() == DialogResult.OK) {
            string selectedFilePath = openFileDialog.FileName;
            TbImage.Text = selectedFilePath;
        }
    }
}
