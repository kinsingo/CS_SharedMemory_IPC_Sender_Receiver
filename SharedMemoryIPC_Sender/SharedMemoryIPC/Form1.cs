using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharedMemory;

namespace SharedMemoryIPC
{
    public partial class Form1 : Form
    {
        SharedArray<int> sharedArray;
        BufferReadWrite sharedBuffer;
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            sharedArray = new SharedArray<int>(name: "MySharedArray", length : 100);
            sharedBuffer = new BufferReadWrite(name: "MySharedBuffer", bufferSize: sizeof(int) * 100);
            base.OnLoad(e);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
        }


        private void button_SharedArray_Write_Click(object sender, EventArgs e)
        {
            sharedArray[0] = Convert.ToInt32(textBox_SharedArray.Text);            
        }


        private void button_BufferReadWrite_Write_Click(object sender, EventArgs e)
        {
            int data = Convert.ToInt32(textBox_SharedBuffer.Text);
            sharedBuffer.Write<int>(ref data);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
