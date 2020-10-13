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



        public Form1()
        {
            InitializeComponent();
        }

        private void button_richTextBox1_Clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        protected override void OnLoad(EventArgs e)
        {

            base.OnLoad(e);
        }

        protected override void OnClosed(EventArgs e)
        {

            base.OnClosed(e);
        }




        private void button_SharedArray_Read_Click(object sender, EventArgs e)
        {
            var ptr = new SharedArray<int>("MySharedArray");
            richTextBox1.AppendText(String.Format("SharedMemory.SharedArray(Read): {0}\n", ptr[0]));
        }


        private void button_BufferReadWrite_Read_Click(object sender, EventArgs e)
        {
            var buffer = new BufferReadWrite("MySharedBuffer");
            int readData;
            buffer.Read(out readData);

            richTextBox1.AppendText(String.Format("SharedMemory.BufferReadWrite(Read): {0}\n", readData));
        }
    }
}
