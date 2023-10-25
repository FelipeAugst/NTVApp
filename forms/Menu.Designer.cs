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
            menuStrip1 = new MenuStrip();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            listarToolStripMenuItem1 = new ToolStripMenuItem();
            buscarToolStripMenuItem = new ToolStripMenuItem();
            deletarToolStripMenuItem = new ToolStripMenuItem();
            planosToolStripMenuItem = new ToolStripMenuItem();
            incluirToolStripMenuItem = new ToolStripMenuItem();
            excluirToolStripMenuItem = new ToolStripMenuItem();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, planosToolStripMenuItem, configuraçõesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem, editarToolStripMenuItem, listarToolStripMenuItem1, buscarToolStripMenuItem, deletarToolStripMenuItem });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(61, 20);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new Size(111, 22);
            novoToolStripMenuItem.Text = "Novo";
            novoToolStripMenuItem.Click += novoToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(111, 22);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // listarToolStripMenuItem1
            // 
            listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            listarToolStripMenuItem1.Size = new Size(111, 22);
            listarToolStripMenuItem1.Text = "Listar";
            // 
            // buscarToolStripMenuItem
            // 
            buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            buscarToolStripMenuItem.Size = new Size(111, 22);
            buscarToolStripMenuItem.Text = "Buscar";
            // 
            // deletarToolStripMenuItem
            // 
            deletarToolStripMenuItem.Name = "deletarToolStripMenuItem";
            deletarToolStripMenuItem.Size = new Size(111, 22);
            deletarToolStripMenuItem.Text = "Deletar";
            // 
            // planosToolStripMenuItem
            // 
            planosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { incluirToolStripMenuItem, excluirToolStripMenuItem });
            planosToolStripMenuItem.Name = "planosToolStripMenuItem";
            planosToolStripMenuItem.Size = new Size(54, 20);
            planosToolStripMenuItem.Text = "Planos";
            // 
            // incluirToolStripMenuItem
            // 
            incluirToolStripMenuItem.Name = "incluirToolStripMenuItem";
            incluirToolStripMenuItem.Size = new Size(109, 22);
            incluirToolStripMenuItem.Text = "Incluir";
            // 
            // excluirToolStripMenuItem
            // 
            excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            excluirToolStripMenuItem.Size = new Size(109, 22);
            excluirToolStripMenuItem.Text = "Excluir";
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(96, 20);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            configuraçõesToolStripMenuItem.Click += configuraçõesToolStripMenuItem_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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