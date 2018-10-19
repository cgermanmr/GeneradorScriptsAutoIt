using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AutoIt;
using Gma.UserActivityMonitor;
using System.Diagnostics;
using System.Net;


namespace GeneradorScriptsAutoIt
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void InfoButton_Click(object sender, EventArgs e)
        {
            AutoItX.Run(Application.StartupPath + "\\Au3Info.exe", "", AutoItX.SW_NORMAL);
        }

        private void InfoPunteroCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (InfoPunteroCheckBox.Checked)
            {
                HookManager.MouseMove += HookManager_MouseMove;
                HookManager.MouseClick += HookManager_MouseClick;
            }
            else
            {
                HookManager.MouseMove -= HookManager_MouseMove;
            }

           
        }

        #region Event handlers

        private void HookManager_MouseMove(object sender, MouseEventArgs e)
        {
            ValorTextBox.Text = string.Format("{0},{1}", e.X, e.Y);
        }

        private void HookManager_MouseClick(object sender, MouseEventArgs e)
        {
            HookManager.MouseMove -= HookManager_MouseMove;
            InfoPunteroCheckBox.Checked = false;
        }

        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            ComandoComboBox.Items.AddRange(ComandoBuilder.ObtenerComandos().ToArray());
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            Comando nuevoComando = (Comando)((Comando)ComandoComboBox.SelectedItem).Clone();
            nuevoComando.Valor = ValorTextBox.Text;
            nuevoComando.Objetivo = ObjetivoTextBox.Text;
            nuevoComando.Descripcion = DescripcionTextBox.Text;

            ScriptTextBox.AppendText(nuevoComando.Escribir() + "\n");

        }

        private void VerificarButton_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.File.WriteAllText(Application.StartupPath + "\\easyscript.au3", ScriptTextBox.Text);
                PathLabel.Text = "Path: "+ Application.StartupPath + "\\easyscript.au3";

                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.CreateNoWindow = true;
                startInfo.RedirectStandardOutput = true;
                startInfo.UseShellExecute = false;
                startInfo.Arguments = "easyscript.au3";
                startInfo.FileName = Application.StartupPath + "\\au3check.exe";

                Process p = new Process();
                p.StartInfo = startInfo;
                p.Start();
                p.WaitForExit();

                MessageBox.Show(p.StandardOutput.ReadToEnd());

            }
            catch (Exception ex)
            {
                //throw;
                MessageBox.Show("Fallo verificación, error: " + ex.Message);
            }



        }

        private void ProbarButton_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.File.WriteAllText(Application.StartupPath + "\\easyscript.au3", ScriptTextBox.Text);

                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.CreateNoWindow = true;
                startInfo.RedirectStandardOutput = true;
                startInfo.UseShellExecute = false;
                startInfo.Arguments = "/ErrorStdOut easyscript.au3";
                startInfo.FileName = Application.StartupPath + "\\autoit3.exe";

                Process p = new Process();
                p.StartInfo = startInfo;
                p.Start();
              
            }
            catch (Exception ex)
            {
                //throw;
                MessageBox.Show("Fallo la prueba, error: " + ex.Message);
            }
        }


        private void CrearButton_Click(object sender, EventArgs e)
        {
            AutoItX.Run(Application.StartupPath + "\\Aut2Exe.exe", "", AutoItX.SW_NORMAL);
        }

        private void AyudaButton_Click(object sender, EventArgs e)
        {

            AutoItX.Run(Application.StartupPath + "\\AutoIt3Help.exe", "", AutoItX.SW_NORMAL);
        }
    }
}


