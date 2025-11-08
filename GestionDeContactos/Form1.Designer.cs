namespace GestionDeContactos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewContactos = new DataGridView();
            btnCrear = new Button();
            AgregarContacto = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbxNombre = new TextBox();
            tbxEmail = new TextBox();
            mtbxTelefono = new MaskedTextBox();
            btnModificar = new Button();
            tbxId = new TextBox();
            labelID = new Label();
            btnEliminar = new Button();
            btnCancelar = new Button();
            label4 = new Label();
            tbxBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewContactos).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewContactos
            // 
            dataGridViewContactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewContactos.Location = new Point(71, 51);
            dataGridViewContactos.Name = "dataGridViewContactos";
            dataGridViewContactos.RowHeadersWidth = 51;
            dataGridViewContactos.Size = new Size(622, 188);
            dataGridViewContactos.TabIndex = 0;
            dataGridViewContactos.CellClick += dataGridViewContactos_CellClick;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(399, 394);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(94, 29);
            btnCrear.TabIndex = 1;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // AgregarContacto
            // 
            AgregarContacto.AutoSize = true;
            AgregarContacto.Location = new Point(71, 246);
            AgregarContacto.Name = "AgregarContacto";
            AgregarContacto.Size = new Size(127, 20);
            AgregarContacto.TabIndex = 2;
            AgregarContacto.Text = "Agregar Contacto";
            // 
            // label1
            // 
            label1.Location = new Point(411, 283);
            label1.Name = "label1";
            label1.Size = new Size(79, 27);
            label1.TabIndex = 3;
            label1.Text = "Telefono";
            // 
            // label2
            // 
            label2.Location = new Point(71, 283);
            label2.Name = "label2";
            label2.Size = new Size(79, 27);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.Location = new Point(71, 339);
            label3.Name = "label3";
            label3.Size = new Size(79, 27);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // tbxNombre
            // 
            tbxNombre.Location = new Point(156, 283);
            tbxNombre.MaxLength = 100;
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(249, 27);
            tbxNombre.TabIndex = 6;
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(156, 339);
            tbxEmail.MaxLength = 150;
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(249, 27);
            tbxEmail.TabIndex = 7;
            // 
            // mtbxTelefono
            // 
            mtbxTelefono.Location = new Point(485, 283);
            mtbxTelefono.Mask = "(999)000-0000";
            mtbxTelefono.Name = "mtbxTelefono";
            mtbxTelefono.Size = new Size(208, 27);
            mtbxTelefono.TabIndex = 8;
            mtbxTelefono.MaskInputRejected += mtbxTelefono_MaskInputRejected;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(599, 394);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // tbxId
            // 
            tbxId.Location = new Point(521, 339);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(172, 27);
            tbxId.TabIndex = 11;
            // 
            // labelID
            // 
            labelID.Location = new Point(411, 339);
            labelID.Name = "labelID";
            labelID.Size = new Size(114, 27);
            labelID.TabIndex = 10;
            labelID.Text = "ID del contacto";
            labelID.Click += labelID_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(499, 394);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(485, 429);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(126, 29);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Limpiar campos";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label4
            // 
            label4.Location = new Point(71, 21);
            label4.Name = "label4";
            label4.Size = new Size(79, 27);
            label4.TabIndex = 14;
            label4.Text = "Buscar";
            // 
            // tbxBuscar
            // 
            tbxBuscar.Location = new Point(122, 18);
            tbxBuscar.MaxLength = 100;
            tbxBuscar.Name = "tbxBuscar";
            tbxBuscar.Size = new Size(249, 27);
            tbxBuscar.TabIndex = 15;
            tbxBuscar.TextChanged += tbxBuscar_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 504);
            Controls.Add(tbxBuscar);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(tbxId);
            Controls.Add(labelID);
            Controls.Add(btnModificar);
            Controls.Add(mtbxTelefono);
            Controls.Add(tbxEmail);
            Controls.Add(tbxNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AgregarContacto);
            Controls.Add(btnCrear);
            Controls.Add(dataGridViewContactos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewContactos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridViewContactos;
        private Button btnCrear;
        private Label AgregarContacto;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbxNombre;
        private TextBox tbxEmail;
        private MaskedTextBox mtbxTelefono;
        private Button btnModificar;
        private TextBox tbxId;
        private Label labelID;
        private Button btnEliminar;
        private Button btnCancelar;
        private Label label4;
        private TextBox tbxBuscar;
    }
}
