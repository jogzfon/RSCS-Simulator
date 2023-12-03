using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RSCSS
{
    public class CPU
    {
        public System.Windows.Forms.Label Status_txt { get; set; }
        public System.Windows.Forms.Label Rtl_txt { get; set; }
        public System.Windows.Forms.Label Datamove_txt { get; set; }
        public System.Windows.Forms.Label Ar_txt { get; set; }
        public System.Windows.Forms.Label Pc_txt { get; set; }
        public System.Windows.Forms.Label Dr_txt { get; set; }
        public System.Windows.Forms.Label Tr_txt { get; set; }
        public System.Windows.Forms.Label Ir_txt { get; set; }
        public System.Windows.Forms.Label R_txt { get; set; }
        public System.Windows.Forms.Label Ac_txt { get; set; }
        public System.Windows.Forms.Label Z_txt { get; set; }


        public long IOint = 0;
        public string IO = "00000000";
        private int ar = 0x00000000;
        private int pc = 0x00000000;
        private int dr = 0x00000000;
        private int tr = 0x00000000;
        private int ir = 0x00000000;
        private int r = 0x00000000;
        private int ac = 0x00000000;
        private int z = 0;

        public int Z
        {
            get { return z; }
            set { z = value; }
        }
        public CPU(System.Windows.Forms.Label status_txt, System.Windows.Forms.Label rtl_txt, System.Windows.Forms.Label datamove_txt, System.Windows.Forms.Label ar_txt, System.Windows.Forms.Label pc_txt, System.Windows.Forms.Label dr_txt, System.Windows.Forms.Label tr_txt, System.Windows.Forms.Label ir_txt, System.Windows.Forms.Label r_txt, System.Windows.Forms.Label ac_txt, System.Windows.Forms.Label z_txt)
        {
            Status_txt = status_txt;
            Rtl_txt = rtl_txt;
            Datamove_txt = datamove_txt;
            Ar_txt = ar_txt;
            Pc_txt = pc_txt;
            Dr_txt = dr_txt;
            Tr_txt = tr_txt;
            Ir_txt = ir_txt;
            R_txt = r_txt;
            Ac_txt = ac_txt;
            Z_txt = z_txt;
        }

        public string SpaceInserter(int reg, string regname)
        {
            string binaryString;
            if (regname == "ar" || regname == "pc")
            {
                // Convert the integer to a binary string with spaces every 4 digits
                binaryString = Convert.ToString(reg, 2).PadLeft(16, '0');
            }
            else if (regname == "z")
            {
                // Convert the integer to a binary string with spaces every 4 digits
                binaryString = Convert.ToString(reg);
            }
            else
            {
                // Convert the integer to a binary string with spaces every 4 digits
                binaryString = Convert.ToString(reg, 2).PadLeft(8, '0');
            }

            // Insert spaces after every 4 digits
            int groupSize = 4;
            for (int i = groupSize; i < binaryString.Length; i += (groupSize + 1))
            {
                binaryString = binaryString.Insert(i, " ");
            }
            return binaryString;
        }

        public void Fetches(int num)
        {
            switch (num)
            {
                case 0:
                    Status_txt.Text = "Running";
                    Rtl_txt.Text = "Fetch 1";
                    Datamove_txt.Text = "AR <- PC";
                    Ar_txt.Text = SpaceInserter(ar, "ar");
                    Pc_txt.Text = SpaceInserter(pc, "pc");
                    Dr_txt.Text = SpaceInserter(dr, "dr");
                    Tr_txt.Text = SpaceInserter(tr, "tr");
                    Ir_txt.Text = SpaceInserter(ir, "ir");
                    R_txt.Text = SpaceInserter(r, "r");
                    Ac_txt.Text = SpaceInserter(ac, "ac");
                    Z_txt.Text = SpaceInserter(z, "z");
                    break;
                case 1:
                    //Addition
                    pc += 1;
                    dr += 1;

                    Rtl_txt.Text = "Fetch 2";
                    Datamove_txt.Text = "DR <- M, PC <- PC+1";
                    Ar_txt.Text = SpaceInserter(ar, "ar");
                    Pc_txt.Text = SpaceInserter(pc, "pc");
                    Dr_txt.Text = SpaceInserter(dr, "dr");
                    Tr_txt.Text = SpaceInserter(tr, "tr");
                    Ir_txt.Text = SpaceInserter(ir, "ir");
                    R_txt.Text = SpaceInserter(r, "r");
                    Ac_txt.Text = SpaceInserter(ac, "ac");
                    Z_txt.Text = SpaceInserter(z, "z");
                    break;
                case 2:
                    Rtl_txt.Text = "Fetch 3";
                    Datamove_txt.Text = "IR <- DR, AR <- PC";
                    Ar_txt.Text = SpaceInserter(ar + 1, "ar");
                    Pc_txt.Text = SpaceInserter(pc , "pc");
                    Dr_txt.Text = SpaceInserter(dr , "dr");
                    Tr_txt.Text = SpaceInserter(tr, "tr");
                    Ir_txt.Text = SpaceInserter(ir + 1, "ir");
                    R_txt.Text = SpaceInserter(r, "r");
                    Ac_txt.Text = SpaceInserter(ac, "ac");
                    Z_txt.Text = SpaceInserter(z, "z");
                    break;
                case 3:
                    //ControlSpace();
                    break;
                default:
                    return;
            }
        }
        /*//Reads Instructions and Loops through it individually
        public void ControlSpace(int[])
        {
            //Move Through Instructions in
            for (int i = 0; i < microcode.Length; i++)
            {
                ExecuteInstruction(microcode[i]);
            }
        }*/
        //NO Operand Instructions
        public void NOP() {
            Rtl_txt.Text = "NOP";
            Datamove_txt.Text = "No Operation";
        }
        public void MVAC() {
            r = ac;
            Rtl_txt.Text = "MVAC";
            Datamove_txt.Text = "R <- AC";
            R_txt.Text = SpaceInserter(r, "r");
        }
        public void MOVR() {
            ac = r;
            Rtl_txt.Text = "MOVR";
            Datamove_txt.Text = "AC <- R";
            Ac_txt.Text = SpaceInserter(ac, "ac");
        }

        //ALU
        public void ADD() {
            ac = ac + r;

            // Set z based on the result
            z = (ac == 0) ? 1 : 0;

            Rtl_txt.Text = "ADD";
            Datamove_txt.Text = "AC <- AC + R";
            Ac_txt.Text = SpaceInserter(ac, "ac");
            Z_txt.Text = SpaceInserter(z, "z");
        }
        public void SUB() {
            ac = ac - r;

            // Set z based on the result
            z = (ac == 0) ? 1 : 0;

            Rtl_txt.Text = "SUB";
            Datamove_txt.Text = "AC <- AC - R";
            Ac_txt.Text = SpaceInserter(ac, "ac");
            Z_txt.Text = SpaceInserter(z, "z");
        }
        public void INAC() {
            ac = ac + 1;

            // Set z based on the result
            z = (ac == 0) ? 1 : 0;

            Rtl_txt.Text = "INAC";
            Datamove_txt.Text = "AC <- AC + 1";
            Ac_txt.Text = SpaceInserter(ac, "ac");
            Z_txt.Text = SpaceInserter(z, "z");
        }
        public void CLAC() {
            ac = 0;
            z = 1;

            Rtl_txt.Text = "CLAC";
            Datamove_txt.Text = "AC <- 0, Z <- 1";
            Ac_txt.Text = SpaceInserter(ac, "ac");
            Z_txt.Text = SpaceInserter(z, "z");
        }
        public void AND() {
            // Perform bitwise AND on ac and r
            ac = ac & r;

            // Set z based on the result
            z = (ac == 0) ? 1 : 0;

            // Update UI and status
            Rtl_txt.Text = "AND";
            Datamove_txt.Text = "AC <- AC & r";
            Ac_txt.Text = SpaceInserter(ac, "ac");
            Z_txt.Text = SpaceInserter(z, "z");
        }
        public void OR() {
            ac = ac | 1;
            z = (ac == 0) ? 1 : 0;

            Rtl_txt.Text = "OR";
            Datamove_txt.Text = "AC <- AC | r";
            Ac_txt.Text = SpaceInserter(ac, "ac");
            Z_txt.Text = SpaceInserter(z, "z");
        }   
        public void XOR() {
            // Perform bitwise XOR on ac and 1
            ac = ac ^ 1;

            // Set z based on the result
            z = (ac == 0) ? 1 : 0;

            // Update UI and status
            Rtl_txt.Text = "XOR";
            Datamove_txt.Text = "AC <- AC ^ r";
            Ac_txt.Text = SpaceInserter(ac, "ac");
            Z_txt.Text = SpaceInserter(z, "z");
        }
        public void NOT() {
            // Perform bitwise NOT on ac
            ac = ~ac;

            // Set z based on the result
            z = (ac == 0) ? 1 : 0;

            // Update UI and status
            Rtl_txt.Text = "NOT";
            Datamove_txt.Text = "AC <- ~AC";
            Ac_txt.Text = SpaceInserter(ac, "ac");
            Z_txt.Text = SpaceInserter(z, "z");
        }
        //public void END() { }

        //One Operand Instructions
        public void LDAC() { }
        public void STAC() { }
        public void JUMP() { }
        public void JMPZ() { }
        public void JPNZ() { }
    }

}
