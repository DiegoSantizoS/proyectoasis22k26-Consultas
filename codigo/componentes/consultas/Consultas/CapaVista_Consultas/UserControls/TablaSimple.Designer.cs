namespace CapaVista_Consultas
{
    partial class TablaSimple
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
<<<<<<< Updated upstream
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasDgvEmpleados = new System.Windows.Forms.DataGridView();
            this.IdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultasDgvEmpleados)).BeginInit();
=======
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ConsultasTlpSimples = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasDgvSimples = new System.Windows.Forms.DataGridView();
            this.ConsultasTlpPaginacion = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasBtnAnterior = new System.Windows.Forms.Button();
            this.ConsultasBtnSiguiente = new System.Windows.Forms.Button();
            this.ConsultasFlpPaginas = new System.Windows.Forms.FlowLayoutPanel();
            this.ConsultasTlpSimples.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultasDgvSimples)).BeginInit();
            this.ConsultasTlpPaginacion.SuspendLayout();
>>>>>>> Stashed changes
            this.SuspendLayout();
            // 
            // ConsultasTlpSimples
            // 
<<<<<<< Updated upstream
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ConsultasDgvEmpleados, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(830, 479);
            this.tableLayoutPanel1.TabIndex = 0;
=======
            this.ConsultasTlpSimples.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasTlpSimples.ColumnCount = 1;
            this.ConsultasTlpSimples.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpSimples.Controls.Add(this.ConsultasTlpPaginacion, 0, 1);
            this.ConsultasTlpSimples.Controls.Add(this.ConsultasDgvSimples, 0, 0);
            this.ConsultasTlpSimples.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasTlpSimples.Location = new System.Drawing.Point(0, 0);
            this.ConsultasTlpSimples.Name = "ConsultasTlpSimples";
            this.ConsultasTlpSimples.RowCount = 2;
            this.ConsultasTlpSimples.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.34238F));
            this.ConsultasTlpSimples.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.65762F));
            this.ConsultasTlpSimples.Size = new System.Drawing.Size(849, 479);
            this.ConsultasTlpSimples.TabIndex = 0;
>>>>>>> Stashed changes
            // 
            // ConsultasDgvEmpleados
            // 
<<<<<<< Updated upstream
            this.ConsultasDgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ConsultasDgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultasDgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEmpleado,
            this.Nombre,
            this.Apellido,
            this.Cargo,
            this.Salario});
            this.ConsultasDgvEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasDgvEmpleados.Location = new System.Drawing.Point(3, 3);
            this.ConsultasDgvEmpleados.Name = "ConsultasDgvEmpleados";
            this.ConsultasDgvEmpleados.RowHeadersWidth = 51;
            this.ConsultasDgvEmpleados.RowTemplate.Height = 24;
            this.ConsultasDgvEmpleados.Size = new System.Drawing.Size(824, 473);
            this.ConsultasDgvEmpleados.TabIndex = 0;
            // 
            // IdEmpleado
            // 
            this.IdEmpleado.HeaderText = "IdEmpleado";
            this.IdEmpleado.MinimumWidth = 6;
            this.IdEmpleado.Name = "IdEmpleado";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.MinimumWidth = 6;
            this.Cargo.Name = "Cargo";
            // 
            // Salario
            // 
            this.Salario.HeaderText = "Salario";
            this.Salario.MinimumWidth = 6;
            this.Salario.Name = "Salario";
=======
            this.ConsultasDgvSimples.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ConsultasDgvSimples.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(128)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ConsultasDgvSimples.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ConsultasDgvSimples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultasDgvSimples.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasDgvSimples.Location = new System.Drawing.Point(3, 3);
            this.ConsultasDgvSimples.Name = "ConsultasDgvSimples";
            this.ConsultasDgvSimples.RowHeadersWidth = 51;
            this.ConsultasDgvSimples.RowTemplate.Height = 24;
            this.ConsultasDgvSimples.Size = new System.Drawing.Size(843, 398);
            this.ConsultasDgvSimples.TabIndex = 0;
>>>>>>> Stashed changes
            // 
            // ConsultasTlpPaginacion
            // 
            this.ConsultasTlpPaginacion.ColumnCount = 3;
            this.ConsultasTlpPaginacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.81741F));
            this.ConsultasTlpPaginacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.40977F));
            this.ConsultasTlpPaginacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.87898F));
            this.ConsultasTlpPaginacion.Controls.Add(this.ConsultasBtnAnterior, 0, 0);
            this.ConsultasTlpPaginacion.Controls.Add(this.ConsultasBtnSiguiente, 2, 0);
            this.ConsultasTlpPaginacion.Controls.Add(this.ConsultasFlpPaginas, 1, 0);
            this.ConsultasTlpPaginacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasTlpPaginacion.Location = new System.Drawing.Point(3, 407);
            this.ConsultasTlpPaginacion.Name = "ConsultasTlpPaginacion";
            this.ConsultasTlpPaginacion.RowCount = 1;
            this.ConsultasTlpPaginacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpPaginacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.ConsultasTlpPaginacion.Size = new System.Drawing.Size(843, 69);
            this.ConsultasTlpPaginacion.TabIndex = 3;
            // 
            // ConsultasBtnAnterior
            // 
            this.ConsultasBtnAnterior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasBtnAnterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(87)))), ((int)(((byte)(63)))));
            this.ConsultasBtnAnterior.Location = new System.Drawing.Point(3, 3);
            this.ConsultasBtnAnterior.Name = "ConsultasBtnAnterior";
            this.ConsultasBtnAnterior.Size = new System.Drawing.Size(127, 63);
            this.ConsultasBtnAnterior.TabIndex = 0;
            this.ConsultasBtnAnterior.Text = "Atras";
            this.ConsultasBtnAnterior.UseVisualStyleBackColor = true;
            // 
            // ConsultasBtnSiguiente
            // 
            this.ConsultasBtnSiguiente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasBtnSiguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(87)))), ((int)(((byte)(63)))));
            this.ConsultasBtnSiguiente.Location = new System.Drawing.Point(703, 3);
            this.ConsultasBtnSiguiente.Name = "ConsultasBtnSiguiente";
            this.ConsultasBtnSiguiente.Size = new System.Drawing.Size(137, 63);
            this.ConsultasBtnSiguiente.TabIndex = 1;
            this.ConsultasBtnSiguiente.Text = "Adelante";
            this.ConsultasBtnSiguiente.UseVisualStyleBackColor = true;
            // 
            // ConsultasFlpPaginas
            // 
            this.ConsultasFlpPaginas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasFlpPaginas.Location = new System.Drawing.Point(136, 3);
            this.ConsultasFlpPaginas.Name = "ConsultasFlpPaginas";
            this.ConsultasFlpPaginas.Size = new System.Drawing.Size(561, 63);
            this.ConsultasFlpPaginas.TabIndex = 2;
            // 
            // TablaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.ConsultasTlpSimples);
            this.Name = "TablaSimple";
<<<<<<< Updated upstream
            this.Size = new System.Drawing.Size(830, 479);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultasDgvEmpleados)).EndInit();
=======
            this.Size = new System.Drawing.Size(849, 479);
            this.ConsultasTlpSimples.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultasDgvSimples)).EndInit();
            this.ConsultasTlpPaginacion.ResumeLayout(false);
>>>>>>> Stashed changes
            this.ResumeLayout(false);

        }

        #endregion

<<<<<<< Updated upstream
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView ConsultasDgvEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
=======
        private System.Windows.Forms.TableLayoutPanel ConsultasTlpSimples;
        private System.Windows.Forms.DataGridView ConsultasDgvSimples;
        private System.Windows.Forms.TableLayoutPanel ConsultasTlpPaginacion;
        private System.Windows.Forms.Button ConsultasBtnAnterior;
        private System.Windows.Forms.Button ConsultasBtnSiguiente;
        private System.Windows.Forms.FlowLayoutPanel ConsultasFlpPaginas;
>>>>>>> Stashed changes
    }
}
