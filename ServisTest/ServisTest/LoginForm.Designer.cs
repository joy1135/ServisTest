
namespace ServisTest
{
    partial class LoginForm
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
            this.exit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logPass = new System.Windows.Forms.TextBox();
            this.logEmail = new System.Windows.Forms.TextBox();
            this.logStud = new System.Windows.Forms.RadioButton();
            this.logTeach = new System.Windows.Forms.RadioButton();
            this.logRegit = new System.Windows.Forms.Label();
            this.logButtom = new System.Windows.Forms.Button();
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
            this.exit.TabIndex = 4;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(182, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 57);
            this.label1.TabIndex = 5;
            this.label1.Text = "ВХОД";
            // 
            // logPass
            // 
            this.logPass.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.logPass.Location = new System.Drawing.Point(66, 249);
            this.logPass.Multiline = true;
            this.logPass.Name = "logPass";
            this.logPass.Size = new System.Drawing.Size(381, 39);
            this.logPass.TabIndex = 7;
            this.logPass.Enter += new System.EventHandler(this.logPass_Enter);
            this.logPass.Leave += new System.EventHandler(this.logPass_Leave);
            // 
            // logEmail
            // 
            this.logEmail.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.logEmail.Location = new System.Drawing.Point(66, 187);
            this.logEmail.Multiline = true;
            this.logEmail.Name = "logEmail";
            this.logEmail.Size = new System.Drawing.Size(381, 39);
            this.logEmail.TabIndex = 6;
            this.logEmail.Tag = "";
            this.logEmail.Enter += new System.EventHandler(this.logEmail_Enter);
            this.logEmail.Leave += new System.EventHandler(this.logEmail_Leave);
            // 
            // logStud
            // 
            this.logStud.AutoSize = true;
            this.logStud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logStud.ForeColor = System.Drawing.Color.White;
            this.logStud.Location = new System.Drawing.Point(261, 329);
            this.logStud.Name = "logStud";
            this.logStud.Size = new System.Drawing.Size(97, 28);
            this.logStud.TabIndex = 13;
            this.logStud.Text = "Ученик ";
            this.logStud.UseVisualStyleBackColor = true;
            // 
            // logTeach
            // 
            this.logTeach.AutoSize = true;
            this.logTeach.Checked = true;
            this.logTeach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logTeach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logTeach.ForeColor = System.Drawing.Color.White;
            this.logTeach.Location = new System.Drawing.Point(147, 329);
            this.logTeach.Name = "logTeach";
            this.logTeach.Size = new System.Drawing.Size(108, 28);
            this.logTeach.TabIndex = 12;
            this.logTeach.TabStop = true;
            this.logTeach.Text = "Учитель ";
            this.logTeach.UseMnemonic = false;
            this.logTeach.UseVisualStyleBackColor = true;
            // 
            // logRegit
            // 
            this.logRegit.AutoSize = true;
            this.logRegit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logRegit.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logRegit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(120)))));
            this.logRegit.Location = new System.Drawing.Point(188, 590);
            this.logRegit.Name = "logRegit";
            this.logRegit.Size = new System.Drawing.Size(140, 22);
            this.logRegit.TabIndex = 14;
            this.logRegit.Text = "НЕТ АККАУНТА?";
            this.logRegit.Click += new System.EventHandler(this.logRegit_Click);
            // 
            // logButtom
            // 
            this.logButtom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.logButtom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logButtom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logButtom.Font = new System.Drawing.Font("Lucida Sans", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logButtom.Location = new System.Drawing.Point(165, 406);
            this.logButtom.Name = "logButtom";
            this.logButtom.Size = new System.Drawing.Size(180, 60);
            this.logButtom.TabIndex = 15;
            this.logButtom.Text = "ВХОД";
            this.logButtom.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(88)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(512, 634);
            this.Controls.Add(this.logButtom);
            this.Controls.Add(this.logRegit);
            this.Controls.Add(this.logStud);
            this.Controls.Add(this.logTeach);
            this.Controls.Add(this.logPass);
            this.Controls.Add(this.logEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox logPass;
        private System.Windows.Forms.TextBox logEmail;
        private System.Windows.Forms.RadioButton logStud;
        private System.Windows.Forms.RadioButton logTeach;
        private System.Windows.Forms.Label logRegit;
        private System.Windows.Forms.Button logButtom;
    }
}