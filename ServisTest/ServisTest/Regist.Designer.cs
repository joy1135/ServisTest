
namespace ServisTest
{
    partial class Regist
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.regName = new System.Windows.Forms.TextBox();
            this.regSurname = new System.Windows.Forms.TextBox();
            this.regPatronymic = new System.Windows.Forms.TextBox();
            this.regEmail = new System.Windows.Forms.TextBox();
            this.regPass = new System.Windows.Forms.TextBox();
            this.regRepPass = new System.Windows.Forms.TextBox();
            this.regTeach = new System.Windows.Forms.RadioButton();
            this.regStud = new System.Windows.Forms.RadioButton();
            this.regButtom = new System.Windows.Forms.Button();
            this.regLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "РЕГИСТРАЦИЯ";
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
            this.exit.TabIndex = 3;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // regName
            // 
            this.regName.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.regName.Location = new System.Drawing.Point(71, 110);
            this.regName.Multiline = true;
            this.regName.Name = "regName";
            this.regName.Size = new System.Drawing.Size(381, 39);
            this.regName.TabIndex = 4;
            this.regName.Tag = "";
            this.regName.Enter += new System.EventHandler(this.regName_Enter);
            this.regName.Leave += new System.EventHandler(this.regName_Leave);
            // 
            // regSurname
            // 
            this.regSurname.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.regSurname.Location = new System.Drawing.Point(71, 172);
            this.regSurname.Multiline = true;
            this.regSurname.Name = "regSurname";
            this.regSurname.Size = new System.Drawing.Size(381, 39);
            this.regSurname.TabIndex = 5;
            this.regSurname.Enter += new System.EventHandler(this.regSurname_Enter);
            this.regSurname.Leave += new System.EventHandler(this.regSurname_Leave);
            // 
            // regPatronymic
            // 
            this.regPatronymic.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regPatronymic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.regPatronymic.Location = new System.Drawing.Point(71, 236);
            this.regPatronymic.Multiline = true;
            this.regPatronymic.Name = "regPatronymic";
            this.regPatronymic.Size = new System.Drawing.Size(381, 39);
            this.regPatronymic.TabIndex = 6;
            this.regPatronymic.Enter += new System.EventHandler(this.regPatronymic_Enter);
            this.regPatronymic.Leave += new System.EventHandler(this.regPatronymic_Leave);
            // 
            // regEmail
            // 
            this.regEmail.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.regEmail.Location = new System.Drawing.Point(71, 299);
            this.regEmail.Multiline = true;
            this.regEmail.Name = "regEmail";
            this.regEmail.Size = new System.Drawing.Size(381, 39);
            this.regEmail.TabIndex = 7;
            this.regEmail.Enter += new System.EventHandler(this.regEmail_Enter);
            this.regEmail.Leave += new System.EventHandler(this.regEmail_Leave);
            // 
            // regPass
            // 
            this.regPass.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.regPass.Location = new System.Drawing.Point(71, 359);
            this.regPass.Multiline = true;
            this.regPass.Name = "regPass";
            this.regPass.Size = new System.Drawing.Size(381, 39);
            this.regPass.TabIndex = 8;
            this.regPass.UseSystemPasswordChar = true;
            this.regPass.Enter += new System.EventHandler(this.regPass_Enter);
            this.regPass.Leave += new System.EventHandler(this.regPass_Leave);
            // 
            // regRepPass
            // 
            this.regRepPass.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regRepPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.regRepPass.Location = new System.Drawing.Point(71, 419);
            this.regRepPass.Multiline = true;
            this.regRepPass.Name = "regRepPass";
            this.regRepPass.Size = new System.Drawing.Size(381, 39);
            this.regRepPass.TabIndex = 9;
            this.regRepPass.Enter += new System.EventHandler(this.regRepPass_Enter);
            this.regRepPass.Leave += new System.EventHandler(this.regRepPass_Leave);
            // 
            // regTeach
            // 
            this.regTeach.AutoSize = true;
            this.regTeach.Checked = true;
            this.regTeach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regTeach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regTeach.ForeColor = System.Drawing.Color.White;
            this.regTeach.Location = new System.Drawing.Point(155, 473);
            this.regTeach.Name = "regTeach";
            this.regTeach.Size = new System.Drawing.Size(108, 28);
            this.regTeach.TabIndex = 10;
            this.regTeach.TabStop = true;
            this.regTeach.Text = "Учитель ";
            this.regTeach.UseMnemonic = false;
            this.regTeach.UseVisualStyleBackColor = true;
            // 
            // regStud
            // 
            this.regStud.AutoSize = true;
            this.regStud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regStud.ForeColor = System.Drawing.Color.White;
            this.regStud.Location = new System.Drawing.Point(269, 473);
            this.regStud.Name = "regStud";
            this.regStud.Size = new System.Drawing.Size(97, 28);
            this.regStud.TabIndex = 11;
            this.regStud.Text = "Ученик ";
            this.regStud.UseVisualStyleBackColor = true;
            // 
            // regButtom
            // 
            this.regButtom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.regButtom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regButtom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.regButtom.Font = new System.Drawing.Font("Lucida Sans", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regButtom.Location = new System.Drawing.Point(167, 522);
            this.regButtom.Name = "regButtom";
            this.regButtom.Size = new System.Drawing.Size(180, 60);
            this.regButtom.TabIndex = 12;
            this.regButtom.Text = "РЕГИСТРАЦИЯ";
            this.regButtom.UseVisualStyleBackColor = false;
            this.regButtom.Click += new System.EventHandler(this.regButtom_Click);
            // 
            // regLogin
            // 
            this.regLogin.AutoSize = true;
            this.regLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regLogin.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(120)))));
            this.regLogin.Location = new System.Drawing.Point(169, 603);
            this.regLogin.Name = "regLogin";
            this.regLogin.Size = new System.Drawing.Size(178, 22);
            this.regLogin.TabIndex = 13;
            this.regLogin.Text = "УЖЕ ЕСТЬ АККАУНТ?";
            this.regLogin.Click += new System.EventHandler(this.label2_Click);
            // 
            // Regist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(88)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(512, 634);
            this.Controls.Add(this.regLogin);
            this.Controls.Add(this.regButtom);
            this.Controls.Add(this.regStud);
            this.Controls.Add(this.regTeach);
            this.Controls.Add(this.regRepPass);
            this.Controls.Add(this.regPass);
            this.Controls.Add(this.regEmail);
            this.Controls.Add(this.regPatronymic);
            this.Controls.Add(this.regSurname);
            this.Controls.Add(this.regName);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Regist";
            this.Text = "ServisTest";
            this.Load += new System.EventHandler(this.Regist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.TextBox regName;
        private System.Windows.Forms.TextBox regSurname;
        private System.Windows.Forms.TextBox regPatronymic;
        private System.Windows.Forms.TextBox regEmail;
        private System.Windows.Forms.TextBox regPass;
        private System.Windows.Forms.TextBox regRepPass;
        private System.Windows.Forms.Button regButtom;
        private System.Windows.Forms.Label regLogin;
        private System.Windows.Forms.RadioButton regTeach;
        private System.Windows.Forms.RadioButton regStud;
    }
}

