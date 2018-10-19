namespace GeneradorScriptsAutoIt
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.InfoButton = new System.Windows.Forms.Button();
            this.InfoPunteroCheckBox = new System.Windows.Forms.CheckBox();
            this.ScriptTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PathLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ProbarButton = new System.Windows.Forms.Button();
            this.VerificarButton = new System.Windows.Forms.Button();
            this.CrearButton = new System.Windows.Forms.Button();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.ComandoComboBox = new System.Windows.Forms.ComboBox();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.ValorTextBox = new System.Windows.Forms.TextBox();
            this.ObjetivoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AyudaButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfoButton
            // 
            this.InfoButton.Image = ((System.Drawing.Image)(resources.GetObject("InfoButton.Image")));
            this.InfoButton.Location = new System.Drawing.Point(484, 57);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(31, 24);
            this.InfoButton.TabIndex = 0;
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // InfoPunteroCheckBox
            // 
            this.InfoPunteroCheckBox.AutoSize = true;
            this.InfoPunteroCheckBox.Location = new System.Drawing.Point(397, 88);
            this.InfoPunteroCheckBox.Name = "InfoPunteroCheckBox";
            this.InfoPunteroCheckBox.Size = new System.Drawing.Size(118, 17);
            this.InfoPunteroCheckBox.TabIndex = 2;
            this.InfoPunteroCheckBox.Text = "Capturar (X,Y) Click";
            this.InfoPunteroCheckBox.UseVisualStyleBackColor = true;
            this.InfoPunteroCheckBox.CheckedChanged += new System.EventHandler(this.InfoPunteroCheckBox_CheckedChanged);
            // 
            // ScriptTextBox
            // 
            this.ScriptTextBox.Location = new System.Drawing.Point(16, 19);
            this.ScriptTextBox.Multiline = true;
            this.ScriptTextBox.Name = "ScriptTextBox";
            this.ScriptTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ScriptTextBox.Size = new System.Drawing.Size(544, 188);
            this.ScriptTextBox.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PathLabel);
            this.groupBox2.Controls.Add(this.ScriptTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 229);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generación Script";
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(16, 210);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(57, 13);
            this.PathLabel.TabIndex = 5;
            this.PathLabel.Text = "Path script";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AyudaButton);
            this.groupBox3.Controls.Add(this.ProbarButton);
            this.groupBox3.Controls.Add(this.VerificarButton);
            this.groupBox3.Controls.Add(this.CrearButton);
            this.groupBox3.Controls.Add(this.AgregarButton);
            this.groupBox3.Controls.Add(this.InfoButton);
            this.groupBox3.Controls.Add(this.ComandoComboBox);
            this.groupBox3.Controls.Add(this.InfoPunteroCheckBox);
            this.groupBox3.Controls.Add(this.DescripcionTextBox);
            this.groupBox3.Controls.Add(this.ValorTextBox);
            this.groupBox3.Controls.Add(this.ObjetivoTextBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 264);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(576, 170);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Crear Comando";
            // 
            // ProbarButton
            // 
            this.ProbarButton.Location = new System.Drawing.Point(257, 139);
            this.ProbarButton.Name = "ProbarButton";
            this.ProbarButton.Size = new System.Drawing.Size(75, 23);
            this.ProbarButton.TabIndex = 6;
            this.ProbarButton.Text = "Probar";
            this.ProbarButton.UseVisualStyleBackColor = true;
            this.ProbarButton.Click += new System.EventHandler(this.ProbarButton_Click);
            // 
            // VerificarButton
            // 
            this.VerificarButton.Location = new System.Drawing.Point(167, 139);
            this.VerificarButton.Name = "VerificarButton";
            this.VerificarButton.Size = new System.Drawing.Size(75, 23);
            this.VerificarButton.TabIndex = 5;
            this.VerificarButton.Text = "Verificar";
            this.VerificarButton.UseVisualStyleBackColor = true;
            this.VerificarButton.Click += new System.EventHandler(this.VerificarButton_Click);
            // 
            // CrearButton
            // 
            this.CrearButton.Location = new System.Drawing.Point(347, 139);
            this.CrearButton.Name = "CrearButton";
            this.CrearButton.Size = new System.Drawing.Size(75, 23);
            this.CrearButton.TabIndex = 4;
            this.CrearButton.Text = "Crear .exe";
            this.CrearButton.UseVisualStyleBackColor = true;
            this.CrearButton.Click += new System.EventHandler(this.CrearButton_Click);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(77, 139);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarButton.TabIndex = 3;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // ComandoComboBox
            // 
            this.ComandoComboBox.FormattingEnabled = true;
            this.ComandoComboBox.Location = new System.Drawing.Point(77, 30);
            this.ComandoComboBox.Name = "ComandoComboBox";
            this.ComandoComboBox.Size = new System.Drawing.Size(438, 21);
            this.ComandoComboBox.TabIndex = 2;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(77, 112);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(438, 20);
            this.DescripcionTextBox.TabIndex = 1;
            // 
            // ValorTextBox
            // 
            this.ValorTextBox.Location = new System.Drawing.Point(78, 85);
            this.ValorTextBox.Name = "ValorTextBox";
            this.ValorTextBox.Size = new System.Drawing.Size(313, 20);
            this.ValorTextBox.TabIndex = 1;
            // 
            // ObjetivoTextBox
            // 
            this.ObjetivoTextBox.Location = new System.Drawing.Point(78, 58);
            this.ObjetivoTextBox.Name = "ObjetivoTextBox";
            this.ObjetivoTextBox.Size = new System.Drawing.Size(400, 20);
            this.ObjetivoTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Objetivo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Valor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comando";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descripción";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.herramientasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(601, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // AyudaButton
            // 
            this.AyudaButton.Location = new System.Drawing.Point(437, 139);
            this.AyudaButton.Name = "AyudaButton";
            this.AyudaButton.Size = new System.Drawing.Size(78, 23);
            this.AyudaButton.TabIndex = 7;
            this.AyudaButton.Text = "Ayuda AutoIt";
            this.AyudaButton.UseVisualStyleBackColor = true;
            this.AyudaButton.Click += new System.EventHandler(this.AyudaButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 446);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Easy Automation - Generador de Código AutoIt";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.CheckBox InfoPunteroCheckBox;
        private System.Windows.Forms.TextBox ScriptTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox ComandoComboBox;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.TextBox ValorTextBox;
        private System.Windows.Forms.TextBox ObjetivoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button CrearButton;
        private System.Windows.Forms.Button ProbarButton;
        private System.Windows.Forms.Button VerificarButton;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Button AyudaButton;
    }
}