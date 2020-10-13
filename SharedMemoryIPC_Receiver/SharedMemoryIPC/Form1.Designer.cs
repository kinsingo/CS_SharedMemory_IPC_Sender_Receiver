namespace SharedMemoryIPC
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_SharedArray_Read = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_BufferReadWrite_Read = new System.Windows.Forms.Button();
            this.button_richTextBox1_Clear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(179, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(531, 197);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_SharedArray_Read);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 75);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SharedArray";
            // 
            // button_SharedArray_Read
            // 
            this.button_SharedArray_Read.Location = new System.Drawing.Point(6, 45);
            this.button_SharedArray_Read.Name = "button_SharedArray_Read";
            this.button_SharedArray_Read.Size = new System.Drawing.Size(151, 20);
            this.button_SharedArray_Read.TabIndex = 3;
            this.button_SharedArray_Read.Text = "Read";
            this.button_SharedArray_Read.UseVisualStyleBackColor = true;
            this.button_SharedArray_Read.Click += new System.EventHandler(this.button_SharedArray_Read_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_BufferReadWrite_Read);
            this.groupBox2.Location = new System.Drawing.Point(10, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 75);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BufferReadWrite";
            // 
            // button_BufferReadWrite_Read
            // 
            this.button_BufferReadWrite_Read.Location = new System.Drawing.Point(6, 45);
            this.button_BufferReadWrite_Read.Name = "button_BufferReadWrite_Read";
            this.button_BufferReadWrite_Read.Size = new System.Drawing.Size(151, 20);
            this.button_BufferReadWrite_Read.TabIndex = 3;
            this.button_BufferReadWrite_Read.Text = "Read";
            this.button_BufferReadWrite_Read.UseVisualStyleBackColor = true;
            this.button_BufferReadWrite_Read.Click += new System.EventHandler(this.button_BufferReadWrite_Read_Click);
            // 
            // button_richTextBox1_Clear
            // 
            this.button_richTextBox1_Clear.Location = new System.Drawing.Point(10, 174);
            this.button_richTextBox1_Clear.Name = "button_richTextBox1_Clear";
            this.button_richTextBox1_Clear.Size = new System.Drawing.Size(163, 35);
            this.button_richTextBox1_Clear.TabIndex = 8;
            this.button_richTextBox1_Clear.Text = "Clear";
            this.button_richTextBox1_Clear.UseVisualStyleBackColor = true;
            this.button_richTextBox1_Clear.Click += new System.EventHandler(this.button_richTextBox1_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 214);
            this.Controls.Add(this.button_richTextBox1_Clear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "SharedMemory IPC";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_SharedArray_Read;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_BufferReadWrite_Read;
        private System.Windows.Forms.Button button_richTextBox1_Clear;
    }
}

