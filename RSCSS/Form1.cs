using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSCSS
{
    public partial class Form1 : Form
    {
        public Assembler assembler = new Assembler();
        public CPU cpu = new CPU();
        public Box box = new Box();
        public Memory memory = new Memory();

        public Form1()
        {
            InitializeComponent();
        }
        private void Assembler(object sender, EventArgs e)
        {
            textBox2.Text = "";
            string text = InstructionCode.Text;
            int location = int.Parse(memLocation.Text);
            AssemblyResults results = assembler.Assemble(text,location,box,cpu,memory);
            AssemblyError[] errors = results.GetErrors();
            int i = 0;
            while(i < errors.Length)
            {
                textBox2.Text += errors[i].GetString() + Environment.NewLine;
                i++;
            }
        }

        private void btn_memoryView(object sender, EventArgs e)
        {
            textBox2.Text = "";
            memory.UpdateMemoryTextBox(textBox2);
        }
    }
}