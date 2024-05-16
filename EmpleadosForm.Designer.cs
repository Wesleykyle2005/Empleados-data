namespace Examen1m1_Empleados
{
    partial class EmpleadosForm
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
            dgvDatos = new DataGridView();
            AddButton = new Button();
            SerializeButton = new Button();
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtArea = new TextBox();
            txtApellido = new TextBox();
            numSalario = new NumericUpDown();
            btnCalcular = new Button();
            txtResult = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSalario).BeginInit();
            SuspendLayout();
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Dock = DockStyle.Bottom;
            dgvDatos.Location = new Point(0, 161);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(484, 200);
            dgvDatos.TabIndex = 0;
            // 
            // AddButton
            // 
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Location = new Point(50, 105);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 50);
            AddButton.TabIndex = 1;
            AddButton.Text = "Agregar";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // SerializeButton
            // 
            SerializeButton.FlatStyle = FlatStyle.Flat;
            SerializeButton.Location = new Point(220, 105);
            SerializeButton.Name = "SerializeButton";
            SerializeButton.Size = new Size(75, 50);
            SerializeButton.TabIndex = 2;
            SerializeButton.Text = "Serializar";
            SerializeButton.UseVisualStyleBackColor = true;
            SerializeButton.Click += SerializeButton_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(139, 26);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 34);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 5;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 79);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 6;
            label2.Text = "Salario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(261, 79);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 10;
            label3.Text = "Area:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(261, 34);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 9;
            label4.Text = "Apellido:";
            // 
            // txtArea
            // 
            txtArea.Location = new Point(350, 71);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(100, 23);
            txtArea.TabIndex = 8;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(350, 26);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 7;
            // 
            // numSalario
            // 
            numSalario.DecimalPlaces = 2;
            numSalario.Location = new Point(139, 71);
            numSalario.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numSalario.Name = "numSalario";
            numSalario.Size = new Size(100, 23);
            numSalario.TabIndex = 11;
            // 
            // btnCalcular
            // 
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Location = new Point(350, 105);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(100, 27);
            btnCalcular.TabIndex = 12;
            btnCalcular.Text = "Calcular pagos";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(350, 132);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(100, 23);
            txtResult.TabIndex = 13;
            // 
            // EmpleadosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(484, 361);
            Controls.Add(txtResult);
            Controls.Add(btnCalcular);
            Controls.Add(numSalario);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtArea);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(SerializeButton);
            Controls.Add(AddButton);
            Controls.Add(dgvDatos);
            Name = "EmpleadosForm";
            Text = "EmpleadosForm";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSalario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDatos;
        private Button AddButton;
        private Button SerializeButton;
        private TextBox txtNombre;
        private TextBox txtSalario;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtArea;
        private TextBox txtApellido;
        private NumericUpDown numSalario;
        private Button btnCalcular;
        private TextBox txtResult;
    }
}