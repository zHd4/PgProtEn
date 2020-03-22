namespace PgProtEn
{
    partial class CryptForm
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
            this.components = new System.ComponentModel.Container();
            this.INPUT_FIELD = new System.Windows.Forms.RichTextBox();
            this.EXIT_BUTTON = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PROCESS_OPERATION_BUTTON = new System.Windows.Forms.Button();
            this.SETTINGS_BUTTON = new System.Windows.Forms.Button();
            this.DECRYPT_SWITCH = new System.Windows.Forms.RadioButton();
            this.OUTPUT_FIELD = new System.Windows.Forms.RichTextBox();
            this.ENCRYPT_SWITCH = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorAnimation = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // INPUT_FIELD
            // 
            this.INPUT_FIELD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.INPUT_FIELD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.INPUT_FIELD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.INPUT_FIELD.ForeColor = System.Drawing.Color.DarkGray;
            this.INPUT_FIELD.Location = new System.Drawing.Point(4, 5);
            this.INPUT_FIELD.Name = "INPUT_FIELD";
            this.INPUT_FIELD.Size = new System.Drawing.Size(311, 353);
            this.INPUT_FIELD.TabIndex = 0;
            this.INPUT_FIELD.Text = "Type your message here";
            this.INPUT_FIELD.Enter += new System.EventHandler(this.INPUT_FIELD_Enter);
            this.INPUT_FIELD.Leave += new System.EventHandler(this.INPUT_FIELD_Leave);
            // 
            // EXIT_BUTTON
            // 
            this.EXIT_BUTTON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.EXIT_BUTTON.FlatAppearance.BorderSize = 0;
            this.EXIT_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EXIT_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EXIT_BUTTON.ForeColor = System.Drawing.Color.Red;
            this.EXIT_BUTTON.Location = new System.Drawing.Point(608, 0);
            this.EXIT_BUTTON.Name = "EXIT_BUTTON";
            this.EXIT_BUTTON.Size = new System.Drawing.Size(30, 30);
            this.EXIT_BUTTON.TabIndex = 3;
            this.EXIT_BUTTON.Text = "×";
            this.EXIT_BUTTON.UseVisualStyleBackColor = false;
            this.EXIT_BUTTON.Click += new System.EventHandler(this.EXIT_BUTTON_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.PROCESS_OPERATION_BUTTON);
            this.panel1.Controls.Add(this.SETTINGS_BUTTON);
            this.panel1.Controls.Add(this.DECRYPT_SWITCH);
            this.panel1.Controls.Add(this.OUTPUT_FIELD);
            this.panel1.Controls.Add(this.INPUT_FIELD);
            this.panel1.Controls.Add(this.ENCRYPT_SWITCH);
            this.panel1.Location = new System.Drawing.Point(2, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 434);
            this.panel1.TabIndex = 4;
            // 
            // PROCESS_OPERATION_BUTTON
            // 
            this.PROCESS_OPERATION_BUTTON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(90)))), ((int)(((byte)(162)))));
            this.PROCESS_OPERATION_BUTTON.FlatAppearance.BorderSize = 0;
            this.PROCESS_OPERATION_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PROCESS_OPERATION_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.PROCESS_OPERATION_BUTTON.Location = new System.Drawing.Point(4, 394);
            this.PROCESS_OPERATION_BUTTON.Name = "PROCESS_OPERATION_BUTTON";
            this.PROCESS_OPERATION_BUTTON.Size = new System.Drawing.Size(311, 35);
            this.PROCESS_OPERATION_BUTTON.TabIndex = 9;
            this.PROCESS_OPERATION_BUTTON.Text = "Encrypt";
            this.PROCESS_OPERATION_BUTTON.UseVisualStyleBackColor = false;
            this.PROCESS_OPERATION_BUTTON.Click += new System.EventHandler(this.PROCESS_OPERATION_BUTTON_Click);
            // 
            // SETTINGS_BUTTON
            // 
            this.SETTINGS_BUTTON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(90)))), ((int)(((byte)(162)))));
            this.SETTINGS_BUTTON.FlatAppearance.BorderSize = 0;
            this.SETTINGS_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SETTINGS_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.SETTINGS_BUTTON.Location = new System.Drawing.Point(321, 394);
            this.SETTINGS_BUTTON.Name = "SETTINGS_BUTTON";
            this.SETTINGS_BUTTON.Size = new System.Drawing.Size(310, 35);
            this.SETTINGS_BUTTON.TabIndex = 6;
            this.SETTINGS_BUTTON.Text = "Settings";
            this.SETTINGS_BUTTON.UseVisualStyleBackColor = false;
            this.SETTINGS_BUTTON.Click += new System.EventHandler(this.SETTINGS_BUTTON_Click);
            // 
            // DECRYPT_SWITCH
            // 
            this.DECRYPT_SWITCH.AutoSize = true;
            this.DECRYPT_SWITCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.DECRYPT_SWITCH.Location = new System.Drawing.Point(93, 364);
            this.DECRYPT_SWITCH.Name = "DECRYPT_SWITCH";
            this.DECRYPT_SWITCH.Size = new System.Drawing.Size(77, 22);
            this.DECRYPT_SWITCH.TabIndex = 5;
            this.DECRYPT_SWITCH.Text = "Decrypt";
            this.DECRYPT_SWITCH.UseVisualStyleBackColor = true;
            // 
            // OUTPUT_FIELD
            // 
            this.OUTPUT_FIELD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.OUTPUT_FIELD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OUTPUT_FIELD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.OUTPUT_FIELD.ForeColor = System.Drawing.Color.DarkGray;
            this.OUTPUT_FIELD.Location = new System.Drawing.Point(319, 5);
            this.OUTPUT_FIELD.Name = "OUTPUT_FIELD";
            this.OUTPUT_FIELD.ReadOnly = true;
            this.OUTPUT_FIELD.Size = new System.Drawing.Size(311, 353);
            this.OUTPUT_FIELD.TabIndex = 3;
            this.OUTPUT_FIELD.Text = "Encrypted message";
            this.OUTPUT_FIELD.Enter += new System.EventHandler(this.OUTPUT_FIELD_Enter);
            this.OUTPUT_FIELD.Leave += new System.EventHandler(this.OUTPUT_FIELD_Leave);
            // 
            // ENCRYPT_SWITCH
            // 
            this.ENCRYPT_SWITCH.AutoSize = true;
            this.ENCRYPT_SWITCH.Checked = true;
            this.ENCRYPT_SWITCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ENCRYPT_SWITCH.Location = new System.Drawing.Point(11, 364);
            this.ENCRYPT_SWITCH.Name = "ENCRYPT_SWITCH";
            this.ENCRYPT_SWITCH.Size = new System.Drawing.Size(76, 22);
            this.ENCRYPT_SWITCH.TabIndex = 4;
            this.ENCRYPT_SWITCH.TabStop = true;
            this.ENCRYPT_SWITCH.Text = "Encrypt";
            this.ENCRYPT_SWITCH.UseVisualStyleBackColor = true;
            this.ENCRYPT_SWITCH.CheckedChanged += new System.EventHandler(this.ENCRYPT_SWITCH_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "PGPROT";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(90)))), ((int)(((byte)(162)))));
            this.label2.Location = new System.Drawing.Point(92, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "EN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            // 
            // errorAnimation
            // 
            this.errorAnimation.Interval = 1000;
            this.errorAnimation.Tick += new System.EventHandler(this.errorAnimation_Tick);
            // 
            // CryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(638, 470);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EXIT_BUTTON);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "CryptForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PGPROTEN";
            this.Load += new System.EventHandler(this.CryptForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CryptForm_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox INPUT_FIELD;
        private System.Windows.Forms.Button EXIT_BUTTON;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton DECRYPT_SWITCH;
        private System.Windows.Forms.RadioButton ENCRYPT_SWITCH;
        private System.Windows.Forms.RichTextBox OUTPUT_FIELD;
        private System.Windows.Forms.Button SETTINGS_BUTTON;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PROCESS_OPERATION_BUTTON;
        private System.Windows.Forms.Timer errorAnimation;
    }
}

