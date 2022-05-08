namespace MeasuringUnitsConverter
{
    partial class SimpleUnitsConverter
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
            this.combo_input = new System.Windows.Forms.ComboBox();
            this.combo_output = new System.Windows.Forms.ComboBox();
            this.lbl_from = new System.Windows.Forms.Label();
            this.lbl_To = new System.Windows.Forms.Label();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.btn_convert = new System.Windows.Forms.Button();
            this.lbl_Convert = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // combo_input
            // 
            this.combo_input.BackColor = System.Drawing.SystemColors.Info;
            this.combo_input.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.combo_input.FormattingEnabled = true;
            this.combo_input.Items.AddRange(new object[] {
            "Kilogram",
            "Gram",
            "Centimeter",
            "Meter"});
            this.combo_input.Location = new System.Drawing.Point(77, 12);
            this.combo_input.Name = "combo_input";
            this.combo_input.Size = new System.Drawing.Size(121, 23);
            this.combo_input.TabIndex = 0;
            this.combo_input.SelectedIndexChanged += new System.EventHandler(this.combo_input_SelectedIndexChanged);
            // 
            // combo_output
            // 
            this.combo_output.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.combo_output.FormattingEnabled = true;
            this.combo_output.Items.AddRange(new object[] {
            "Kilogram",
            "Gram",
            "Meter",
            "Centimeter"});
            this.combo_output.Location = new System.Drawing.Point(77, 60);
            this.combo_output.Name = "combo_output";
            this.combo_output.Size = new System.Drawing.Size(121, 23);
            this.combo_output.TabIndex = 1;
            // 
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_from.Location = new System.Drawing.Point(12, 15);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(46, 20);
            this.lbl_from.TabIndex = 2;
            this.lbl_from.Text = "From:";
            // 
            // lbl_To
            // 
            this.lbl_To.AutoSize = true;
            this.lbl_To.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_To.Location = new System.Drawing.Point(12, 59);
            this.lbl_To.Name = "lbl_To";
            this.lbl_To.Size = new System.Drawing.Size(28, 20);
            this.lbl_To.TabIndex = 3;
            this.lbl_To.Text = "To:";
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(204, 12);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(70, 23);
            this.txt_input.TabIndex = 5;
            this.txt_input.Text = "0";
            this.txt_input.TextChanged += new System.EventHandler(this.txt_input_TextChanged);
            // 
            // btn_convert
            // 
            this.btn_convert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_convert.Location = new System.Drawing.Point(101, 120);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(97, 29);
            this.btn_convert.TabIndex = 7;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // lbl_Convert
            // 
            this.lbl_Convert.AutoSize = true;
            this.lbl_Convert.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Convert.Location = new System.Drawing.Point(103, 150);
            this.lbl_Convert.Name = "lbl_Convert";
            this.lbl_Convert.Size = new System.Drawing.Size(0, 25);
            this.lbl_Convert.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(204, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_output
            // 
            this.txt_output.Location = new System.Drawing.Point(204, 60);
            this.txt_output.MaxLength = 3000;
            this.txt_output.Name = "txt_output";
            this.txt_output.ReadOnly = true;
            this.txt_output.Size = new System.Drawing.Size(70, 23);
            this.txt_output.TabIndex = 10;
            // 
            // SimpleUnitsConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(286, 207);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_Convert);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.lbl_To);
            this.Controls.Add(this.lbl_from);
            this.Controls.Add(this.combo_output);
            this.Controls.Add(this.combo_input);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "SimpleUnitsConverter";
            this.Text = "SimpleUnitsConverter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox combo_input;
        private ComboBox combo_output;
        private Label lbl_from;
        private Label lbl_To;
        private TextBox txt_input;
        private Button btn_convert;
        private Label lbl_Convert;
        private Button button1;
        private TextBox txt_output;
    }
}