
namespace ServisTest
{
    partial class TeachForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.exit = new System.Windows.Forms.Label();
            this.nameteach = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.poisk = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.res_buttom = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dg_result = new System.Windows.Forms.DataGridView();
            this.test_dt = new System.Windows.Forms.Button();
            this.newtest_bt = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_result)).BeginInit();
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
            this.exit.TabIndex = 5;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // nameteach
            // 
            this.nameteach.AutoSize = true;
            this.nameteach.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameteach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameteach.Location = new System.Drawing.Point(12, 57);
            this.nameteach.Name = "nameteach";
            this.nameteach.Size = new System.Drawing.Size(61, 25);
            this.nameteach.TabIndex = 6;
            this.nameteach.Text = "ФИО";
            this.nameteach.Leave += new System.EventHandler(this.nameteach_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "ПОИСК ТЕСТА ";
            // 
            // poisk
            // 
            this.poisk.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poisk.Location = new System.Drawing.Point(23, 249);
            this.poisk.Multiline = true;
            this.poisk.Name = "poisk";
            this.poisk.Size = new System.Drawing.Size(288, 31);
            this.poisk.TabIndex = 8;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Lucida Sans", 18F);
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(37, 307);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(79, 27);
            this.name.TabIndex = 9;
            this.name.Text = "name";
            this.name.Visible = false;
            // 
            // res_buttom
            // 
            this.res_buttom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.res_buttom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.res_buttom.Font = new System.Drawing.Font("Lucida Sans", 17.25F);
            this.res_buttom.Location = new System.Drawing.Point(328, 303);
            this.res_buttom.Name = "res_buttom";
            this.res_buttom.Size = new System.Drawing.Size(149, 36);
            this.res_buttom.TabIndex = 10;
            this.res_buttom.Text = "РЕЗУЛЬТАТЫ";
            this.res_buttom.UseVisualStyleBackColor = false;
            this.res_buttom.Visible = false;
            this.res_buttom.Click += new System.EventHandler(this.res_buttom_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Lucida Sans", 17.25F);
            this.button2.Location = new System.Drawing.Point(328, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 36);
            this.button2.TabIndex = 11;
            this.button2.Text = "ПОИСК";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dg_result
            // 
            this.dg_result.AllowUserToAddRows = false;
            this.dg_result.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_result.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_result.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_result.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_result.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.dg_result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dg_result.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_result.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_result.DefaultCellStyle = dataGridViewCellStyle3;
            this.dg_result.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.dg_result.Location = new System.Drawing.Point(12, 364);
            this.dg_result.Name = "dg_result";
            this.dg_result.RowHeadersVisible = false;
            this.dg_result.Size = new System.Drawing.Size(488, 218);
            this.dg_result.TabIndex = 12;
            this.dg_result.Visible = false;
            // 
            // test_dt
            // 
            this.test_dt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.test_dt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.test_dt.Font = new System.Drawing.Font("Lucida Sans", 17.25F);
            this.test_dt.Location = new System.Drawing.Point(176, 103);
            this.test_dt.Name = "test_dt";
            this.test_dt.Size = new System.Drawing.Size(133, 67);
            this.test_dt.TabIndex = 13;
            this.test_dt.Text = "ПОКАЗАТЬ ВСЕ ТЕСТЫ";
            this.test_dt.UseVisualStyleBackColor = false;
            this.test_dt.Click += new System.EventHandler(this.test_dt_Click);
            // 
            // newtest_bt
            // 
            this.newtest_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.newtest_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newtest_bt.Font = new System.Drawing.Font("Lucida Sans", 17.25F);
            this.newtest_bt.Location = new System.Drawing.Point(21, 103);
            this.newtest_bt.Name = "newtest_bt";
            this.newtest_bt.Size = new System.Drawing.Size(133, 67);
            this.newtest_bt.TabIndex = 14;
            this.newtest_bt.Text = "ДОБАВИТЬ ТЕСТ ";
            this.newtest_bt.UseVisualStyleBackColor = false;
            this.newtest_bt.Click += new System.EventHandler(this.newtest_bt_Click);
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
            this.back.TabIndex = 15;
            this.back.Text = "<";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // TeachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(88)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(512, 634);
            this.Controls.Add(this.back);
            this.Controls.Add(this.newtest_bt);
            this.Controls.Add(this.test_dt);
            this.Controls.Add(this.dg_result);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.res_buttom);
            this.Controls.Add(this.name);
            this.Controls.Add(this.poisk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameteach);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeachForm";
            this.Text = "TeachForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TeachForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TeachForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dg_result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label nameteach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox poisk;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button res_buttom;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dg_result;
        private System.Windows.Forms.Button test_dt;
        private System.Windows.Forms.Button newtest_bt;
        private System.Windows.Forms.Label back;
    }
}