namespace DSSEscoring.Catalogos
{
    partial class Proyectos
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
            groupBox1 = new GroupBox();
            btnNuevo = new Button();
            btnEditar = new Button();
            btnConsultar = new Button();
            btnEliminar = new Button();
            btnCancelar = new Button();
            btnGuardar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtbxId = new TextBox();
            txtbxNombre = new TextBox();
            txtbxObjetivo = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonShadow;
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(btnConsultar);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnNuevo);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(799, 53);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.DodgerBlue;
            btnNuevo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.ForeColor = SystemColors.Control;
            btnNuevo.Location = new Point(4, 3);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(101, 43);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += button1_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.DodgerBlue;
            btnEditar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = SystemColors.Control;
            btnEditar.Location = new Point(101, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(101, 43);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.DarkOrchid;
            btnConsultar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultar.ForeColor = SystemColors.Control;
            btnConsultar.Location = new Point(289, 3);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(101, 43);
            btnConsultar.TabIndex = 3;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += button3_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.Control;
            btnEliminar.Location = new Point(191, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(101, 43);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += button4_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Goldenrod;
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(128, 64, 0);
            btnCancelar.Location = new Point(692, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(101, 43);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.OliveDrab;
            btnGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.Control;
            btnGuardar.Location = new Point(595, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(101, 43);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 79);
            label1.Name = "label1";
            label1.Size = new Size(43, 37);
            label1.TabIndex = 1;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 171);
            label2.Name = "label2";
            label2.Size = new Size(123, 37);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(39, 260);
            label3.Name = "label3";
            label3.Size = new Size(128, 37);
            label3.TabIndex = 3;
            label3.Text = "Objetivo";
            // 
            // txtbxId
            // 
            txtbxId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxId.Location = new Point(39, 119);
            txtbxId.Name = "txtbxId";
            txtbxId.Size = new Size(163, 29);
            txtbxId.TabIndex = 4;
            // 
            // txtbxNombre
            // 
            txtbxNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxNombre.Location = new Point(39, 211);
            txtbxNombre.Name = "txtbxNombre";
            txtbxNombre.Size = new Size(532, 29);
            txtbxNombre.TabIndex = 5;
            // 
            // txtbxObjetivo
            // 
            txtbxObjetivo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxObjetivo.Location = new Point(39, 300);
            txtbxObjetivo.Multiline = true;
            txtbxObjetivo.Name = "txtbxObjetivo";
            txtbxObjetivo.Size = new Size(532, 144);
            txtbxObjetivo.TabIndex = 6;
            // 
            // Proyectos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 479);
            Controls.Add(txtbxObjetivo);
            Controls.Add(txtbxNombre);
            Controls.Add(txtbxId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Proyectos";
            Text = "Proyectos";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnNuevo;
        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnConsultar;
        private Button btnEliminar;
        private Button btnEditar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtbxId;
        private TextBox txtbxNombre;
        private TextBox txtbxObjetivo;
    }
}