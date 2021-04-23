namespace base64Decoding
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbOrigin = new System.Windows.Forms.RichTextBox();
            this.rtbDecode = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dungeonToggleButton1 = new ReaLTaiizor.Controls.DungeonToggleButton();
            this.SuspendLayout();
            // 
            // rtbOrigin
            // 
            this.rtbOrigin.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOrigin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rtbOrigin.Location = new System.Drawing.Point(12, 12);
            this.rtbOrigin.Name = "rtbOrigin";
            this.rtbOrigin.Size = new System.Drawing.Size(537, 141);
            this.rtbOrigin.TabIndex = 0;
            this.rtbOrigin.Text = "";
            // 
            // rtbDecode
            // 
            this.rtbDecode.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDecode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rtbDecode.Location = new System.Drawing.Point(12, 188);
            this.rtbDecode.Name = "rtbDecode";
            this.rtbDecode.Size = new System.Drawing.Size(537, 141);
            this.rtbDecode.TabIndex = 0;
            this.rtbDecode.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Decode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(478, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Encode";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dungeonToggleButton1
            // 
            this.dungeonToggleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dungeonToggleButton1.Location = new System.Drawing.Point(234, 159);
            this.dungeonToggleButton1.Name = "dungeonToggleButton1";
            this.dungeonToggleButton1.Size = new System.Drawing.Size(79, 27);
            this.dungeonToggleButton1.TabIndex = 2;
            this.dungeonToggleButton1.Toggled = false;
            this.dungeonToggleButton1.ToggledBackColorA = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.dungeonToggleButton1.ToggledBackColorB = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(237)))));
            this.dungeonToggleButton1.ToggledBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(89)))), ((int)(((byte)(55)))));
            this.dungeonToggleButton1.ToggledBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(89)))), ((int)(((byte)(55)))));
            this.dungeonToggleButton1.ToggledBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.dungeonToggleButton1.ToggledBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.dungeonToggleButton1.ToggledColorA = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(58)))));
            this.dungeonToggleButton1.ToggledColorB = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(113)))), ((int)(((byte)(63)))));
            this.dungeonToggleButton1.ToggledColorC = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.dungeonToggleButton1.ToggledColorD = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.dungeonToggleButton1.ToggledIOColorA = System.Drawing.Color.WhiteSmoke;
            this.dungeonToggleButton1.ToggledIOColorB = System.Drawing.Color.DimGray;
            this.dungeonToggleButton1.ToggledOnOffColorA = System.Drawing.Color.WhiteSmoke;
            this.dungeonToggleButton1.ToggledOnOffColorB = System.Drawing.Color.DimGray;
            this.dungeonToggleButton1.ToggledYesNoColorA = System.Drawing.Color.WhiteSmoke;
            this.dungeonToggleButton1.ToggledYesNoColorB = System.Drawing.Color.DimGray;
            this.dungeonToggleButton1.Type = ReaLTaiizor.Controls.DungeonToggleButton._Type.OnOff;
            this.dungeonToggleButton1.ToggledChanged += new ReaLTaiizor.Controls.DungeonToggleButton.ToggledChangedEventHandler(this.dungeonToggleButton1_ToggledChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(565, 356);
            this.Controls.Add(this.dungeonToggleButton1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtbDecode);
            this.Controls.Add(this.rtbOrigin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(126, 50);
            this.Name = "Form1";
            this.Text = "formTheme1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbOrigin;
        private System.Windows.Forms.RichTextBox rtbDecode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private ReaLTaiizor.Controls.DungeonToggleButton dungeonToggleButton1;
    }
}

