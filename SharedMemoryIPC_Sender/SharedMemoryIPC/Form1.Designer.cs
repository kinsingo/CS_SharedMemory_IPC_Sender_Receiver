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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_SharedArray = new System.Windows.Forms.TextBox();
            this.button_SharedArray_Write = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_SharedBuffer = new System.Windows.Forms.TextBox();
            this.button_BufferReadWrite_Write = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_SharedArray);
            this.groupBox1.Controls.Add(this.button_SharedArray_Write);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 50);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SharedArray";
            // 
            // textBox_SharedArray
            // 
            this.textBox_SharedArray.Location = new System.Drawing.Point(57, 19);
            this.textBox_SharedArray.Name = "textBox_SharedArray";
            this.textBox_SharedArray.Size = new System.Drawing.Size(100, 20);
            this.textBox_SharedArray.TabIndex = 2;
            // 
            // button_SharedArray_Write
            // 
            this.button_SharedArray_Write.Location = new System.Drawing.Point(6, 19);
            this.button_SharedArray_Write.Name = "button_SharedArray_Write";
            this.button_SharedArray_Write.Size = new System.Drawing.Size(45, 20);
            this.button_SharedArray_Write.TabIndex = 1;
            this.button_SharedArray_Write.Text = "Write";
            this.button_SharedArray_Write.UseVisualStyleBackColor = true;
            this.button_SharedArray_Write.Click += new System.EventHandler(this.button_SharedArray_Write_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_SharedBuffer);
            this.groupBox2.Controls.Add(this.button_BufferReadWrite_Write);
            this.groupBox2.Location = new System.Drawing.Point(10, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 48);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BufferReadWrite";
            // 
            // textBox_SharedBuffer
            // 
            this.textBox_SharedBuffer.Location = new System.Drawing.Point(57, 19);
            this.textBox_SharedBuffer.Name = "textBox_SharedBuffer";
            this.textBox_SharedBuffer.Size = new System.Drawing.Size(100, 20);
            this.textBox_SharedBuffer.TabIndex = 2;
            // 
            // button_BufferReadWrite_Write
            // 
            this.button_BufferReadWrite_Write.Location = new System.Drawing.Point(6, 19);
            this.button_BufferReadWrite_Write.Name = "button_BufferReadWrite_Write";
            this.button_BufferReadWrite_Write.Size = new System.Drawing.Size(45, 20);
            this.button_BufferReadWrite_Write.TabIndex = 1;
            this.button_BufferReadWrite_Write.Text = "Wrtie";
            this.button_BufferReadWrite_Write.UseVisualStyleBackColor = true;
            this.button_BufferReadWrite_Write.Click += new System.EventHandler(this.button_BufferReadWrite_Write_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 121);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "SharedMemory IPC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_SharedArray;
        private System.Windows.Forms.Button button_SharedArray_Write;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_SharedBuffer;
        private System.Windows.Forms.Button button_BufferReadWrite_Write;
    }
}

