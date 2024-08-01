namespace Telvistaprueba
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.listProductos = new System.Windows.Forms.ListView();
            this.IDProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDProveedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CantidadProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FechaAlta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ModeloProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MarcaProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listprovedor = new System.Windows.Forms.ListView();
            this.lblprovedores = new System.Windows.Forms.Label();
            this.listtipoproducto = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.tbproducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbcantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbalta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbmodelo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbmarca = new System.Windows.Forms.TextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(701, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listProductos
            // 
            this.listProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDProducto,
            this.Nombre,
            this.IDProveedor,
            this.IDTipo,
            this.CantidadProducto,
            this.FechaAlta,
            this.ModeloProducto,
            this.MarcaProducto});
            this.listProductos.HideSelection = false;
            this.listProductos.Location = new System.Drawing.Point(12, 247);
            this.listProductos.Name = "listProductos";
            this.listProductos.Size = new System.Drawing.Size(807, 295);
            this.listProductos.TabIndex = 3;
            this.listProductos.UseCompatibleStateImageBehavior = false;
            this.listProductos.View = System.Windows.Forms.View.Details;
            // 
            // IDProducto
            // 
            this.IDProducto.Text = "IDProducto";
            this.IDProducto.Width = 100;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 100;
            // 
            // IDProveedor
            // 
            this.IDProveedor.Text = "IDProveedor";
            this.IDProveedor.Width = 100;
            // 
            // IDTipo
            // 
            this.IDTipo.Text = "IDTipo";
            this.IDTipo.Width = 100;
            // 
            // CantidadProducto
            // 
            this.CantidadProducto.Text = "Cantidad";
            this.CantidadProducto.Width = 100;
            // 
            // FechaAlta
            // 
            this.FechaAlta.Text = "FechaAlta";
            this.FechaAlta.Width = 100;
            // 
            // ModeloProducto
            // 
            this.ModeloProducto.Text = "Modelo";
            this.ModeloProducto.Width = 100;
            // 
            // MarcaProducto
            // 
            this.MarcaProducto.Text = "Marca";
            this.MarcaProducto.Width = 100;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(508, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Eliminar Producto";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(728, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Agregar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listprovedor
            // 
            this.listprovedor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listprovedor.HideSelection = false;
            this.listprovedor.Location = new System.Drawing.Point(416, 44);
            this.listprovedor.Name = "listprovedor";
            this.listprovedor.Size = new System.Drawing.Size(306, 97);
            this.listprovedor.TabIndex = 6;
            this.listprovedor.UseCompatibleStateImageBehavior = false;
            this.listprovedor.View = System.Windows.Forms.View.Details;
            this.listprovedor.SelectedIndexChanged += new System.EventHandler(this.listprovedor_SelectedIndexChanged);
            // 
            // lblprovedores
            // 
            this.lblprovedores.AutoSize = true;
            this.lblprovedores.Location = new System.Drawing.Point(413, 28);
            this.lblprovedores.Name = "lblprovedores";
            this.lblprovedores.Size = new System.Drawing.Size(61, 13);
            this.lblprovedores.TabIndex = 7;
            this.lblprovedores.Text = "Provedores";
            // 
            // listtipoproducto
            // 
            this.listtipoproducto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.listtipoproducto.HideSelection = false;
            this.listtipoproducto.Location = new System.Drawing.Point(230, 44);
            this.listtipoproducto.Name = "listtipoproducto";
            this.listtipoproducto.Size = new System.Drawing.Size(134, 97);
            this.listtipoproducto.TabIndex = 8;
            this.listtipoproducto.UseCompatibleStateImageBehavior = false;
            this.listtipoproducto.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "TipoProducto";
            // 
            // tbproducto
            // 
            this.tbproducto.Location = new System.Drawing.Point(61, 21);
            this.tbproducto.Name = "tbproducto";
            this.tbproducto.Size = new System.Drawing.Size(100, 20);
            this.tbproducto.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cantidad Producto";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbcantidad
            // 
            this.tbcantidad.Location = new System.Drawing.Point(61, 70);
            this.tbcantidad.Name = "tbcantidad";
            this.tbcantidad.Size = new System.Drawing.Size(100, 20);
            this.tbcantidad.TabIndex = 12;
            this.tbcantidad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Fecha Alta";
            // 
            // tbalta
            // 
            this.tbalta.Location = new System.Drawing.Point(61, 121);
            this.tbalta.Name = "tbalta";
            this.tbalta.Size = new System.Drawing.Size(100, 20);
            this.tbalta.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Modelo";
            // 
            // tbmodelo
            // 
            this.tbmodelo.Location = new System.Drawing.Point(61, 169);
            this.tbmodelo.Name = "tbmodelo";
            this.tbmodelo.Size = new System.Drawing.Size(100, 20);
            this.tbmodelo.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Marca";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tbmarca
            // 
            this.tbmarca.Location = new System.Drawing.Point(60, 208);
            this.tbmarca.Name = "tbmarca";
            this.tbmarca.Size = new System.Drawing.Size(100, 20);
            this.tbmarca.TabIndex = 18;
            this.tbmarca.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "RFC";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "id";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nombre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 575);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbmarca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbmodelo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbalta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbcantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbproducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listtipoproducto);
            this.Controls.Add(this.lblprovedores);
            this.Controls.Add(this.listprovedor);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listProductos);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listProductos;
        private System.Windows.Forms.ColumnHeader IDProducto;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader IDProveedor;
        private System.Windows.Forms.ColumnHeader IDTipo;
        private System.Windows.Forms.ColumnHeader CantidadProducto;
        private System.Windows.Forms.ColumnHeader FechaAlta;
        private System.Windows.Forms.ColumnHeader ModeloProducto;
        private System.Windows.Forms.ColumnHeader MarcaProducto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listprovedor;
        private System.Windows.Forms.Label lblprovedores;
        private System.Windows.Forms.ListView listtipoproducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbproducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbcantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbalta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbmodelo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbmarca;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

