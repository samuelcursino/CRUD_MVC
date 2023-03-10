
namespace CRUD_MVC_SamuelCursino_MateuSilva.UI
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tsmCadastrarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmListarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPrincipal,
            this.tsmAjuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmPrincipal
            // 
            this.tsmPrincipal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadastrarUsuario,
            this.tsmListarUsuario});
            this.tsmPrincipal.Name = "tsmPrincipal";
            this.tsmPrincipal.Size = new System.Drawing.Size(65, 20);
            this.tsmPrincipal.Text = "Principal";
            // 
            // tsmAjuda
            // 
            this.tsmAjuda.Name = "tsmAjuda";
            this.tsmAjuda.Size = new System.Drawing.Size(50, 20);
            this.tsmAjuda.Text = "Ajuda";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CRUD_MVC_SamuelCursino_MateuSilva.Properties.Resources.pexels_carlos_oliva_3586966;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(984, 617);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tsmCadastrarUsuario
            // 
            this.tsmCadastrarUsuario.Name = "tsmCadastrarUsuario";
            this.tsmCadastrarUsuario.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.tsmCadastrarUsuario.Size = new System.Drawing.Size(209, 22);
            this.tsmCadastrarUsuario.Text = "Cadastrar Usuário";
            // 
            // tsmListarUsuario
            // 
            this.tsmListarUsuario.Name = "tsmListarUsuario";
            this.tsmListarUsuario.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.tsmListarUsuario.Size = new System.Drawing.Size(209, 22);
            this.tsmListarUsuario.Text = "Listar Usuário";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmAjuda;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastrarUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmListarUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}