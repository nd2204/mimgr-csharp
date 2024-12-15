namespace app.mvc.views;

partial class FormMain {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
        ((System.ComponentModel.ISupportInitialize)this.fileSystemWatcher1).BeginInit();
        this.SuspendLayout();
        // 
        // fileSystemWatcher1
        // 
        this.fileSystemWatcher1.EnableRaisingEvents = true;
        this.fileSystemWatcher1.SynchronizingObject = this;
        // 
        // FormMain
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1264, 761);
        this.Name = "FormMain";
        this.Text = "Mimgr";
        this.Load += this.FormMain_Load;
        ((System.ComponentModel.ISupportInitialize)this.fileSystemWatcher1).EndInit();
        this.ResumeLayout(false);
    }

    #endregion
    private System.IO.FileSystemWatcher fileSystemWatcher1;
}