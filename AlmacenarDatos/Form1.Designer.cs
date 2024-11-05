namespace AlmacenarDatos
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
            lstEmpleados = new ListBox();
            lstEvaluacion = new ListBox();
            listViewEmpleado = new ListView();
            listViewEvalua = new ListView();
            SuspendLayout();
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.ItemHeight = 25;
            lstEmpleados.Location = new Point(35, 38);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(382, 229);
            lstEmpleados.TabIndex = 0;
            // 
            // lstEvaluacion
            // 
            lstEvaluacion.FormattingEnabled = true;
            lstEvaluacion.ItemHeight = 25;
            lstEvaluacion.Location = new Point(496, 38);
            lstEvaluacion.Name = "lstEvaluacion";
            lstEvaluacion.Size = new Size(433, 229);
            lstEvaluacion.TabIndex = 1;
            // 
            // listViewEmpleado
            // 
            listViewEmpleado.Location = new Point(36, 294);
            listViewEmpleado.Name = "listViewEmpleado";
            listViewEmpleado.Size = new Size(381, 146);
            listViewEmpleado.TabIndex = 2;
            listViewEmpleado.UseCompatibleStateImageBehavior = false;
            // 
            // listViewEvalua
            // 
            listViewEvalua.Location = new Point(499, 292);
            listViewEvalua.Name = "listViewEvalua";
            listViewEvalua.Size = new Size(430, 146);
            listViewEvalua.TabIndex = 3;
            listViewEvalua.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 547);
            Controls.Add(listViewEvalua);
            Controls.Add(listViewEmpleado);
            Controls.Add(lstEvaluacion);
            Controls.Add(lstEmpleados);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstEmpleados;
        private ListBox lstEvaluacion;
        private ListView listViewEmpleado;
        private ListView listViewEvalua;
    }
}
