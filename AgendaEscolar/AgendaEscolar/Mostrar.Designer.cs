namespace AgendaEscolar
{
    partial class Mostrar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonTodoslosAlumnos = new System.Windows.Forms.Button();
            this.buttonCarrera = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonNumDecontrol = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CarreracomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(658, 163);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonTodoslosAlumnos
            // 
            this.buttonTodoslosAlumnos.Location = new System.Drawing.Point(639, 70);
            this.buttonTodoslosAlumnos.Name = "buttonTodoslosAlumnos";
            this.buttonTodoslosAlumnos.Size = new System.Drawing.Size(158, 75);
            this.buttonTodoslosAlumnos.TabIndex = 1;
            this.buttonTodoslosAlumnos.Text = "Mostrar todos los Alumnos";
            this.buttonTodoslosAlumnos.UseVisualStyleBackColor = true;
            this.buttonTodoslosAlumnos.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCarrera
            // 
            this.buttonCarrera.Location = new System.Drawing.Point(374, 71);
            this.buttonCarrera.Name = "buttonCarrera";
            this.buttonCarrera.Size = new System.Drawing.Size(177, 28);
            this.buttonCarrera.TabIndex = 2;
            this.buttonCarrera.Text = "Mostrar X Carrera";
            this.buttonCarrera.UseVisualStyleBackColor = true;
            this.buttonCarrera.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(225, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonNumDecontrol
            // 
            this.buttonNumDecontrol.Location = new System.Drawing.Point(374, 14);
            this.buttonNumDecontrol.Name = "buttonNumDecontrol";
            this.buttonNumDecontrol.Size = new System.Drawing.Size(177, 27);
            this.buttonNumDecontrol.TabIndex = 6;
            this.buttonNumDecontrol.Text = "Mostrar X Num.control";
            this.buttonNumDecontrol.UseVisualStyleBackColor = true;
            this.buttonNumDecontrol.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Num_Control";
            // 
            // CarreracomboBox
            // 
            this.CarreracomboBox.FormattingEnabled = true;
            this.CarreracomboBox.Location = new System.Drawing.Point(225, 75);
            this.CarreracomboBox.Name = "CarreracomboBox";
            this.CarreracomboBox.Size = new System.Drawing.Size(121, 24);
            this.CarreracomboBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Selecione la carrera";
            // 
            // Mostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 360);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CarreracomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonNumDecontrol);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCarrera);
            this.Controls.Add(this.buttonTodoslosAlumnos);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Mostrar";
            this.Text = "Mostrar";
            this.Load += new System.EventHandler(this.Mostrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonTodoslosAlumnos;
        private System.Windows.Forms.Button buttonCarrera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonNumDecontrol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CarreracomboBox;
        private System.Windows.Forms.Label label4;
    }
}