namespace OutilRessources
{
    partial class DashboardForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.FileRessources = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selectFile = new System.Windows.Forms.Button();
            this.validImport = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileModele = new System.Windows.Forms.SaveFileDialog();
            this.NameFile = new System.Windows.Forms.Label();
            this.dataGridViewExcel = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // FileRessources
            // 
            this.FileRessources.FileName = "FileRessources";
            this.FileRessources.ReadOnlyChecked = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(760, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenue sur l\'outil d\'import de ressources.\r\nMerci de séléctionner votre fichie" +
    "r et de cliquer sur le bouton importer.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(24, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(760, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "ATTENTION : Seuls les fichiers Excel (.xlsx ou .xls) sont acceptés";
            // 
            // selectFile
            // 
            this.selectFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectFile.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFile.Location = new System.Drawing.Point(29, 112);
            this.selectFile.Name = "selectFile";
            this.selectFile.Size = new System.Drawing.Size(1172, 53);
            this.selectFile.TabIndex = 3;
            this.selectFile.Text = "Sélectionner votre fichier d\'import";
            this.selectFile.UseVisualStyleBackColor = true;
            this.selectFile.Click += new System.EventHandler(this.selectFile_Click);
            // 
            // validImport
            // 
            this.validImport.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.validImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.validImport.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validImport.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.validImport.Location = new System.Drawing.Point(29, 666);
            this.validImport.Margin = new System.Windows.Forms.Padding(0);
            this.validImport.Name = "validImport";
            this.validImport.Size = new System.Drawing.Size(1172, 51);
            this.validImport.TabIndex = 4;
            this.validImport.TabStop = false;
            this.validImport.Text = "Importer";
            this.validImport.UseVisualStyleBackColor = false;
            this.validImport.Click += new System.EventHandler(this.validImport_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1231, 33);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadTemplateToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(60, 29);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // downloadTemplateToolStripMenuItem
            // 
            this.downloadTemplateToolStripMenuItem.Name = "downloadTemplateToolStripMenuItem";
            this.downloadTemplateToolStripMenuItem.Size = new System.Drawing.Size(418, 30);
            this.downloadTemplateToolStripMenuItem.Text = "Télécharger le fichier de modèle d\'import";
            this.downloadTemplateToolStripMenuItem.Click += new System.EventHandler(this.downloadTemplateToolStripMenuItem_Click);
            // 
            // saveFileModele
            // 
            this.saveFileModele.FileName = "ModeleRessources";
            // 
            // NameFile
            // 
            this.NameFile.AutoSize = true;
            this.NameFile.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameFile.Location = new System.Drawing.Point(25, 219);
            this.NameFile.Name = "NameFile";
            this.NameFile.Size = new System.Drawing.Size(0, 23);
            this.NameFile.TabIndex = 7;
            // 
            // dataGridViewExcel
            // 
            this.dataGridViewExcel.AllowUserToAddRows = false;
            this.dataGridViewExcel.AllowUserToDeleteRows = false;
            this.dataGridViewExcel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewExcel.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewExcel.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExcel.EnableHeadersVisualStyles = false;
            this.dataGridViewExcel.Location = new System.Drawing.Point(29, 262);
            this.dataGridViewExcel.MultiSelect = false;
            this.dataGridViewExcel.Name = "dataGridViewExcel";
            this.dataGridViewExcel.ReadOnly = true;
            this.dataGridViewExcel.RowTemplate.Height = 28;
            this.dataGridViewExcel.RowTemplate.ReadOnly = true;
            this.dataGridViewExcel.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewExcel.ShowCellErrors = false;
            this.dataGridViewExcel.ShowCellToolTips = false;
            this.dataGridViewExcel.ShowEditingIcon = false;
            this.dataGridViewExcel.ShowRowErrors = false;
            this.dataGridViewExcel.Size = new System.Drawing.Size(1172, 383);
            this.dataGridViewExcel.TabIndex = 8;
            this.dataGridViewExcel.TabStop = false;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 742);
            this.Controls.Add(this.dataGridViewExcel);
            this.Controls.Add(this.NameFile);
            this.Controls.Add(this.validImport);
            this.Controls.Add(this.selectFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashboardForm";
            this.Text = "Outil d\'import de ressources";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog FileRessources;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button selectFile;
        private System.Windows.Forms.Button validImport;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadTemplateToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileModele;
        private System.Windows.Forms.Label NameFile;
        private System.Windows.Forms.DataGridView dataGridViewExcel;
    }
}

