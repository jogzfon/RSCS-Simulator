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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RSCSS
{
    public partial class Form1 : Form
    {
        public Assembler assembler = new Assembler();
        public CPU cpu;
        public Box box = new Box();
        public Memory memory = new Memory();

        //Memory
        private bool isHex = false;
        //Breakpoints
        private List<string> breakpointList;

        public Form1()
        {
            InitializeComponent();
            breakpointList = new List<string>();
            cpu = new CPU(status_txt, rtl_txt, datamove_txt, ar_txt, pc_txt, dr_txt, tr_txt, ir_txt, r_txt, ac_txt, z_txt);
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
            if(errors.Length <= 0)
            {
                MessageBox.Show("Assembly Successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Memory and I/O
        private void btn_memoryView(object sender, EventArgs e)
        {
            textBox2.Text = "";
            memory.UpdateMemoryTextBox(textBox2, isHex);
        }

        private void ClearMemoryAndIO(object sender, EventArgs e)
        {
            memory.Clear();
            textBox2.Clear();
            memory.UpdateMemoryTextBox(textBox2, isHex);
        }
        private void binaryMemory(object sender, EventArgs e)
        {
            isHex = false;
            textBox2.Text = "";
            memory.UpdateMemoryTextBox(textBox2, isHex);
        }

        private void hexMemory(object sender, EventArgs e)
        {
            isHex = true;
            textBox2.Text = "";
            memory.UpdateMemoryTextBox(textBox2, isHex);
        }

        //BreakPoints Start
        public bool hasBreakpoint(string address)
        {

            if (breakpointList.Count <=0)
            {
                return (false);
            }
            else
            {
                return breakpointList.Contains(address);
            }

        }
        public void removeAllBreakpoints()
        {
            breakpointList.Clear();
        }

        private void Delete_Breakpoint(object sender, EventArgs e)
        {
            if(breakBox.SelectedItem != null)
            {
                breakpointList.Remove(breakBox.SelectedItem.ToString());
                breakBox.Items.Remove(breakBox.SelectedItem.ToString());
            }
        }

        private void Add_Breakpoint(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(breakLine.Text))
            {
                breakpointList.Add(breakLine.Text);
                breakBox.Items.Add(breakLine.Text);
                breakLine.Clear();
                
            }
            else
            {
                MessageBox.Show("Please enter a valid breakpoint.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //RSCPU Visualization Steps
        private void Start_RSCPU(object sender, EventArgs e)
        {
            cpu.Fetches(0);
        }

        int count = 1;
        private void Next_RSCPU(object sender, EventArgs e)
        {
            if(count > 2)
            {
                count = 0;
            }
            cpu.Fetches(count);
            count++;
        }

    }
}