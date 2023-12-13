
namespace ServisTest
{
    partial class StudForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.exit = new System.Windows.Forms.Label();
            this.namestud = new System.Windows.Forms.Label();
            this.dg_tests = new System.Windows.Forms.DataGridView();
            this.back = new System.Windows.Forms.Label();
            this.compl_buttom = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_tests)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("OCR A Extended", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Red;
            this.exit.Location = new System.Drawing.Point(473, -5);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(46, 45);
            this.exit.TabIndex = 6;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // namestud
            // 
            this.namestud.AutoSize = true;
            this.namestud.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namestud.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.namestud.Location = new System.Drawing.Point(12, 49);
            this.namestud.Name = "namestud";
            this.namestud.Size = new System.Drawing.Size(61, 25);
            this.namestud.TabIndex = 7;
            this.namestud.Text = "ФИО";
            // 
            // dg_tests
            // 
            this.dg_tests.AllowUserToAddRows = false;
            this.dg_tests.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_tests.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dg_tests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_tests.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_tests.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.dg_tests.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dg_tests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_tests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dg_tests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_tests.DefaultCellStyle = dataGridViewCellStyle6;
            this.dg_tests.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.dg_tests.Location = new System.Drawing.Point(12, 118);
            this.dg_tests.Name = "dg_tests";
            this.dg_tests.RowHeadersVisible = false;
            this.dg_tests.Size = new System.Drawing.Size(488, 405);
            this.dg_tests.TabIndex = 13;
            this.dg_tests.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_tests_CellMouseDoubleClick);
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Font = new System.Drawing.Font("OCR A Extended", 32.25F);
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(4, -5);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(46, 45);
            this.back.TabIndex = 14;
            this.back.Text = "<";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // compl_buttom
            // 
            this.compl_buttom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.compl_buttom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.compl_buttom.Font = new System.Drawing.Font("Lucida Sans", 17.25F);
            this.compl_buttom.Location = new System.Drawing.Point(329, 558);
            this.compl_buttom.Name = "compl_buttom";
            this.compl_buttom.Size = new System.Drawing.Size(149, 36);
            this.compl_buttom.TabIndex = 16;
            this.compl_buttom.Text = "ПРОЙТИ";
            this.compl_buttom.UseVisualStyleBackColor = false;
            this.compl_buttom.Visible = false;
            this.compl_buttom.Click += new System.EventHandler(this.compl_buttom_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Lucida Sans", 18F);
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(38, 562);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(79, 27);
            this.name.TabIndex = 15;
            this.name.Text = "name";
            this.name.Visible = false;
            // 
            // StudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(88)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(512, 634);
            this.Controls.Add(this.compl_buttom);
            this.Controls.Add(this.name);
            this.Controls.Add(this.back);
            this.Controls.Add(this.dg_tests);
            this.Controls.Add(this.namestud);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudForm";
            this.Text = "StudForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StudForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StudForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dg_tests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label namestud;
        private System.Windows.Forms.DataGridView dg_tests;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.Button compl_buttom;
        private System.Windows.Forms.Label name;
    }
}