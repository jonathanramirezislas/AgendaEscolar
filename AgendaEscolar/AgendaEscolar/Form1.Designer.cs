namespace AgendaEscolar
{
    partial class agendaForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agendaForm));
            this.NoControllabel = new System.Windows.Forms.Label();
            this.NoControltextBox = new System.Windows.Forms.TextBox();
            this.Nombrelabel = new System.Windows.Forms.Label();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.DomiciliotextBox = new System.Windows.Forms.TextBox();
            this.Domiciliolabel = new System.Windows.Forms.Label();
            this.FechaNaclabel = new System.Windows.Forms.Label();
            this.FechaNacdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Carreralabel = new System.Windows.Forms.Label();
            this.CarreracomboBox = new System.Windows.Forms.ComboBox();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.eliminarbutton = new System.Windows.Forms.Button();
            this.buttonizq = new System.Windows.Forms.Button();
            this.buttonDer = new System.Windows.Forms.Button();
            this.buttonMostrarTablas = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NoControllabel
            // 
            this.NoControllabel.AutoSize = true;
            this.NoControllabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.NoControllabel.Location = new System.Drawing.Point(12, 28);
            this.NoControllabel.Name = "NoControllabel";
            this.NoControllabel.Size = new System.Drawing.Size(116, 25);
            this.NoControllabel.TabIndex = 0;
            this.NoControllabel.Text = "No. Control:";
            // 
            // NoControltextBox
            // 
            this.NoControltextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NoControltextBox.Location = new System.Drawing.Point(163, 22);
            this.NoControltextBox.Name = "NoControltextBox";
            this.NoControltextBox.Size = new System.Drawing.Size(121, 30);
            this.NoControltextBox.TabIndex = 1;
            this.NoControltextBox.TextChanged += new System.EventHandler(this.NoControltextBox_TextChanged);
            // 
            // Nombrelabel
            // 
            this.Nombrelabel.AutoSize = true;
            this.Nombrelabel.Location = new System.Drawing.Point(12, 60);
            this.Nombrelabel.Name = "Nombrelabel";
            this.Nombrelabel.Size = new System.Drawing.Size(176, 25);
            this.Nombrelabel.TabIndex = 2;
            this.Nombrelabel.Text = "Nombre Completo:";
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(163, 54);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(298, 30);
            this.NombretextBox.TabIndex = 3;
            // 
            // DomiciliotextBox
            // 
            this.DomiciliotextBox.Location = new System.Drawing.Point(163, 87);
            this.DomiciliotextBox.Name = "DomiciliotextBox";
            this.DomiciliotextBox.Size = new System.Drawing.Size(298, 30);
            this.DomiciliotextBox.TabIndex = 4;
            // 
            // Domiciliolabel
            // 
            this.Domiciliolabel.AutoSize = true;
            this.Domiciliolabel.Location = new System.Drawing.Point(12, 93);
            this.Domiciliolabel.Name = "Domiciliolabel";
            this.Domiciliolabel.Size = new System.Drawing.Size(96, 25);
            this.Domiciliolabel.TabIndex = 5;
            this.Domiciliolabel.Text = "Domicilio:";
            // 
            // FechaNaclabel
            // 
            this.FechaNaclabel.AutoSize = true;
            this.FechaNaclabel.Location = new System.Drawing.Point(12, 125);
            this.FechaNaclabel.Name = "FechaNaclabel";
            this.FechaNaclabel.Size = new System.Drawing.Size(175, 25);
            this.FechaNaclabel.TabIndex = 6;
            this.FechaNaclabel.Text = "Fecha Nacimiento:";
            // 
            // FechaNacdateTimePicker
            // 
            this.FechaNacdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaNacdateTimePicker.Location = new System.Drawing.Point(193, 120);
            this.FechaNacdateTimePicker.Name = "FechaNacdateTimePicker";
            this.FechaNacdateTimePicker.Size = new System.Drawing.Size(156, 30);
            this.FechaNacdateTimePicker.TabIndex = 7;
            this.FechaNacdateTimePicker.ValueChanged += new System.EventHandler(this.FechaNacdateTimePicker_ValueChanged);
            // 
            // Carreralabel
            // 
            this.Carreralabel.AutoSize = true;
            this.Carreralabel.Location = new System.Drawing.Point(12, 160);
            this.Carreralabel.Name = "Carreralabel";
            this.Carreralabel.Size = new System.Drawing.Size(84, 25);
            this.Carreralabel.TabIndex = 8;
            this.Carreralabel.Text = "Carrera:";
            // 
            // CarreracomboBox
            // 
            this.CarreracomboBox.FormattingEnabled = true;
            this.CarreracomboBox.Location = new System.Drawing.Point(163, 152);
            this.CarreracomboBox.Name = "CarreracomboBox";
            this.CarreracomboBox.Size = new System.Drawing.Size(298, 33);
            this.CarreracomboBox.TabIndex = 9;
            this.CarreracomboBox.SelectedIndexChanged += new System.EventHandler(this.CarreracomboBox_SelectedIndexChanged);
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Location = new System.Drawing.Point(583, 215);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(110, 35);
            this.Agregarbutton.TabIndex = 10;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.Guardarbutton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Guardarbutton.Location = new System.Drawing.Point(699, 152);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(159, 161);
            this.Guardarbutton.TabIndex = 11;
            this.Guardarbutton.Text = "Ejecutar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // eliminarbutton
            // 
            this.eliminarbutton.Location = new System.Drawing.Point(583, 160);
            this.eliminarbutton.Name = "eliminarbutton";
            this.eliminarbutton.Size = new System.Drawing.Size(110, 35);
            this.eliminarbutton.TabIndex = 12;
            this.eliminarbutton.Text = "Eliminar";
            this.eliminarbutton.UseVisualStyleBackColor = true;
            this.eliminarbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonizq
            // 
            this.buttonizq.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.buttonizq.Location = new System.Drawing.Point(211, 203);
            this.buttonizq.Name = "buttonizq";
            this.buttonizq.Size = new System.Drawing.Size(62, 42);
            this.buttonizq.TabIndex = 13;
            this.buttonizq.Text = "←";
            this.buttonizq.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonizq.UseVisualStyleBackColor = true;
            this.buttonizq.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonDer
            // 
            this.buttonDer.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.buttonDer.Location = new System.Drawing.Point(279, 203);
            this.buttonDer.Name = "buttonDer";
            this.buttonDer.Size = new System.Drawing.Size(61, 42);
            this.buttonDer.TabIndex = 14;
            this.buttonDer.Text = "\t→";
            this.buttonDer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDer.UseVisualStyleBackColor = true;
            this.buttonDer.Click += new System.EventHandler(this.buttonDer_Click);
            // 
            // buttonMostrarTablas
            // 
            this.buttonMostrarTablas.Location = new System.Drawing.Point(196, 263);
            this.buttonMostrarTablas.Name = "buttonMostrarTablas";
            this.buttonMostrarTablas.Size = new System.Drawing.Size(164, 47);
            this.buttonMostrarTablas.TabIndex = 15;
            this.buttonMostrarTablas.Text = "Mostar Tablas";
            this.buttonMostrarTablas.UseVisualStyleBackColor = true;
            this.buttonMostrarTablas.Click += new System.EventHandler(this.buttonMostrarTablas_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(583, 269);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(110, 35);
            this.buttonActualizar.TabIndex = 16;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // agendaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(893, 513);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonMostrarTablas);
            this.Controls.Add(this.buttonDer);
            this.Controls.Add(this.buttonizq);
            this.Controls.Add(this.eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(this.CarreracomboBox);
            this.Controls.Add(this.Carreralabel);
            this.Controls.Add(this.FechaNacdateTimePicker);
            this.Controls.Add(this.FechaNaclabel);
            this.Controls.Add(this.Domiciliolabel);
            this.Controls.Add(this.DomiciliotextBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.Nombrelabel);
            this.Controls.Add(this.NoControltextBox);
            this.Controls.Add(this.NoControllabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "agendaForm";
            this.Text = "AGENDA ESCOLAR  JONAS";
            this.TransparencyKey = System.Drawing.Color.OldLace;
            this.Load += new System.EventHandler(this.agendaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NoControllabel;
        private System.Windows.Forms.TextBox NoControltextBox;
        private System.Windows.Forms.Label Nombrelabel;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox DomiciliotextBox;
        private System.Windows.Forms.Label Domiciliolabel;
        private System.Windows.Forms.Label FechaNaclabel;
        private System.Windows.Forms.DateTimePicker FechaNacdateTimePicker;
        private System.Windows.Forms.Label Carreralabel;
        private System.Windows.Forms.ComboBox CarreracomboBox;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button eliminarbutton;
        private System.Windows.Forms.Button buttonizq;
        private System.Windows.Forms.Button buttonDer;
        private System.Windows.Forms.Button buttonMostrarTablas;
        private System.Windows.Forms.Button buttonActualizar;
    }
}

