namespace WindowsFormsApplication1
{
    partial class GameForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.formGame = new System.Windows.Forms.Panel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.ChatRichText = new System.Windows.Forms.RichTextBox();
            this.sendMsgTextBox = new System.Windows.Forms.TextBox();
            this.playersRichTextBox = new System.Windows.Forms.RichTextBox();
            this.disconnectBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // formGame
            // 
            this.formGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formGame.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.formGame.Location = new System.Drawing.Point(23, 37);
            this.formGame.Name = "formGame";
            this.formGame.Size = new System.Drawing.Size(700, 500);
            this.formGame.TabIndex = 0;
            this.formGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PlaceGame_Paint);
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timeLabel.Font = new System.Drawing.Font("Footlight MT Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.Black;
            this.timeLabel.Location = new System.Drawing.Point(345, 12);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(72, 25);
            this.timeLabel.TabIndex = 11;
            this.timeLabel.Text = "1:00";
            // 
            // ChatRichText
            // 
            this.ChatRichText.Enabled = false;
            this.ChatRichText.Location = new System.Drawing.Point(734, 226);
            this.ChatRichText.Name = "ChatRichText";
            this.ChatRichText.ReadOnly = true;
            this.ChatRichText.Size = new System.Drawing.Size(237, 285);
            this.ChatRichText.TabIndex = 1;
            this.ChatRichText.Text = "";
            // 
            // sendMsgTextBox
            // 
            this.sendMsgTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendMsgTextBox.Location = new System.Drawing.Point(734, 517);
            this.sendMsgTextBox.Name = "sendMsgTextBox";
            this.sendMsgTextBox.Size = new System.Drawing.Size(237, 20);
            this.sendMsgTextBox.TabIndex = 6;
            this.sendMsgTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sendMsgTextBox_KeyPress);
            // 
            // playersRichTextBox
            // 
            this.playersRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playersRichTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.playersRichTextBox.Enabled = false;
            this.playersRichTextBox.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playersRichTextBox.Location = new System.Drawing.Point(734, 37);
            this.playersRichTextBox.Name = "playersRichTextBox";
            this.playersRichTextBox.ReadOnly = true;
            this.playersRichTextBox.Size = new System.Drawing.Size(237, 149);
            this.playersRichTextBox.TabIndex = 12;
            this.playersRichTextBox.Text = "";
            this.playersRichTextBox.WordWrap = false;
            // 
            // disconnectBtn
            // 
            this.disconnectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.disconnectBtn.BackColor = System.Drawing.Color.IndianRed;
            this.disconnectBtn.Font = new System.Drawing.Font("Footlight MT Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnectBtn.Location = new System.Drawing.Point(827, 195);
            this.disconnectBtn.Name = "disconnectBtn";
            this.disconnectBtn.Size = new System.Drawing.Size(144, 28);
            this.disconnectBtn.TabIndex = 13;
            this.disconnectBtn.Text = "DISCONNECT";
            this.disconnectBtn.UseVisualStyleBackColor = false;
            this.disconnectBtn.Click += new System.EventHandler(this.disconnectBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(731, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "CHAT";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(731, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "PLAYERS";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 547);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.disconnectBtn);
            this.Controls.Add(this.playersRichTextBox);
            this.Controls.Add(this.sendMsgTextBox);
            this.Controls.Add(this.ChatRichText);
            this.Controls.Add(this.formGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "GameForm";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel formGame;
        private System.Windows.Forms.RichTextBox ChatRichText;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.TextBox sendMsgTextBox;
        private System.Windows.Forms.RichTextBox playersRichTextBox;
        private System.Windows.Forms.Button disconnectBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerGame;
    }
}

