namespace COCOMO
{
    partial class Inicio
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
            this.components = new System.ComponentModel.Container();
            this.labelpuntosfusion = new System.Windows.Forms.Label();
            this.textBoxPF = new System.Windows.Forms.TextBox();
            this.labelLenguajeP = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonGuardarInicio = new System.Windows.Forms.Button();
            this.comboBoxLenguajes = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelpuntosfusion
            // 
            this.labelpuntosfusion.AutoSize = true;
            this.labelpuntosfusion.Location = new System.Drawing.Point(33, 94);
            this.labelpuntosfusion.Name = "labelpuntosfusion";
            this.labelpuntosfusion.Size = new System.Drawing.Size(125, 15);
            this.labelpuntosfusion.TabIndex = 0;
            this.labelpuntosfusion.Text = "Puntos de Fusion (PF):";
            // 
            // textBoxPF
            // 
            this.textBoxPF.Location = new System.Drawing.Point(197, 94);
            this.textBoxPF.Name = "textBoxPF";
            this.textBoxPF.Size = new System.Drawing.Size(159, 23);
            this.textBoxPF.TabIndex = 1;
            // 
            // labelLenguajeP
            // 
            this.labelLenguajeP.AutoSize = true;
            this.labelLenguajeP.Location = new System.Drawing.Point(33, 127);
            this.labelLenguajeP.Name = "labelLenguajeP";
            this.labelLenguajeP.Size = new System.Drawing.Size(142, 30);
            this.labelLenguajeP.TabIndex = 2;
            this.labelLenguajeP.Text = "Selecciona el lenguaje de \r\nprogramacion:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonGuardarInicio
            // 
            this.buttonGuardarInicio.Location = new System.Drawing.Point(163, 218);
            this.buttonGuardarInicio.Name = "buttonGuardarInicio";
            this.buttonGuardarInicio.Size = new System.Drawing.Size(88, 34);
            this.buttonGuardarInicio.TabIndex = 3;
            this.buttonGuardarInicio.Text = "Siguiente";
            this.buttonGuardarInicio.UseVisualStyleBackColor = true;
            this.buttonGuardarInicio.Click += new System.EventHandler(this.buttonGuardarInicio_Click);
            // 
            // comboBoxLenguajes
            // 
            this.comboBoxLenguajes.FormattingEnabled = true;
            this.comboBoxLenguajes.Items.AddRange(new object[] {
            "Ensamblador",
            "C",
            "COBOL",
            "Pascal",
            "Prolog/LISP",
            "C++",
            "Visual Basic",
            "SQL"});
            this.comboBoxLenguajes.Location = new System.Drawing.Point(197, 134);
            this.comboBoxLenguajes.Name = "comboBoxLenguajes";
            this.comboBoxLenguajes.Size = new System.Drawing.Size(159, 23);
            this.comboBoxLenguajes.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(884, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bienvenido a COCOMO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Selecciona los parametros que necesitas:\r\n";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 287);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBoxLenguajes);
            this.Controls.Add(this.buttonGuardarInicio);
            this.Controls.Add(this.labelLenguajeP);
            this.Controls.Add(this.textBoxPF);
            this.Controls.Add(this.labelpuntosfusion);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelpuntosfusion;
        private TextBox textBoxPF;
        private Label labelLenguajeP;
        private ContextMenuStrip contextMenuStrip1;
        private Button buttonGuardarInicio;
        private ComboBox comboBoxLenguajes;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
    }
}