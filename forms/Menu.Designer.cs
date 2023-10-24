namespace NTVApp.Forms
{
    partial class Menu
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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            listarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            deletarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            planosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            incluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { clientesToolStripMenuItem, planosToolStripMenuItem, configuraçõesToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { novoToolStripMenuItem, editarToolStripMenuItem, listarToolStripMenuItem1, buscarToolStripMenuItem, deletarToolStripMenuItem });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            novoToolStripMenuItem.Text = "Novo";
            novoToolStripMenuItem.Click += this.novoToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // listarToolStripMenuItem1
            // 
            listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            listarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            listarToolStripMenuItem1.Text = "Listar";
            // 
            // buscarToolStripMenuItem
            // 
            buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            buscarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            buscarToolStripMenuItem.Text = "Buscar";
            // 
            // deletarToolStripMenuItem
            // 
            deletarToolStripMenuItem.Name = "deletarToolStripMenuItem";
            deletarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            deletarToolStripMenuItem.Text = "Deletar";
            // 
            // planosToolStripMenuItem
            // 
            planosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { incluirToolStripMenuItem, excluirToolStripMenuItem });
            planosToolStripMenuItem.Name = "planosToolStripMenuItem";
            planosToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            planosToolStripMenuItem.Text = "Planos";
            // 
            // incluirToolStripMenuItem
            // 
            incluirToolStripMenuItem.Name = "incluirToolStripMenuItem";
            incluirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            incluirToolStripMenuItem.Text = "Incluir";
            // 
            // excluirToolStripMenuItem
            // 
            excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            excluirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            excluirToolStripMenuItem.Text = "Excluir";
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // Menu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Name = "Menu";
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem planosToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem1;
        private ToolStripMenuItem buscarToolStripMenuItem;
        private ToolStripMenuItem deletarToolStripMenuItem;
        private ToolStripMenuItem incluirToolStripMenuItem;
        private ToolStripMenuItem excluirToolStripMenuItem;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
    }
}