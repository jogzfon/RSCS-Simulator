namespace RSCSS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InstructionCode = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ir_txt = new System.Windows.Forms.Label();
            this.r_txt = new System.Windows.Forms.Label();
            this.z_txt = new System.Windows.Forms.Label();
            this.ac_txt = new System.Windows.Forms.Label();
            this.tr_txt = new System.Windows.Forms.Label();
            this.dr_txt = new System.Windows.Forms.Label();
            this.pc_txt = new System.Windows.Forms.Label();
            this.ar_txt = new System.Windows.Forms.Label();
            this.status_txt = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.memory_txt = new System.Windows.Forms.Label();
            this.memLocation = new System.Windows.Forms.TextBox();
            this.btn_memory = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.breakLine = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.breakBox = new System.Windows.Forms.ListBox();
            this.binaryBtn = new System.Windows.Forms.Button();
            this.hexBtn = new System.Windows.Forms.Button();
            this.rtl_txt = new System.Windows.Forms.Label();
            this.starter = new System.Windows.Forms.Button();
            this.next_instruction = new System.Windows.Forms.Button();
            this.datamove_txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InstructionCode
            // 
            this.InstructionCode.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.InstructionCode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionCode.ForeColor = System.Drawing.SystemColors.Window;
            this.InstructionCode.Location = new System.Drawing.Point(49, 183);
            this.InstructionCode.Multiline = true;
            this.InstructionCode.Name = "InstructionCode";
            this.InstructionCode.Size = new System.Drawing.Size(350, 397);
            this.InstructionCode.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(408, 178);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(600, 402);
            this.textBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(114, 599);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "ASSEMBLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Assembler);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "AR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(412, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "PC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(413, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "TR:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(413, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "DR:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(738, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Z:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(738, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "AC:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(737, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "R:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(737, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "IR:";
            // 
            // ir_txt
            // 
            this.ir_txt.AutoSize = true;
            this.ir_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ir_txt.Location = new System.Drawing.Point(779, 19);
            this.ir_txt.Name = "ir_txt";
            this.ir_txt.Size = new System.Drawing.Size(105, 25);
            this.ir_txt.TabIndex = 11;
            this.ir_txt.Text = "0000 0000";
            // 
            // r_txt
            // 
            this.r_txt.AutoSize = true;
            this.r_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_txt.Location = new System.Drawing.Point(779, 44);
            this.r_txt.Name = "r_txt";
            this.r_txt.Size = new System.Drawing.Size(105, 25);
            this.r_txt.TabIndex = 12;
            this.r_txt.Text = "0000 0000";
            // 
            // z_txt
            // 
            this.z_txt.AutoSize = true;
            this.z_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z_txt.Location = new System.Drawing.Point(779, 94);
            this.z_txt.Name = "z_txt";
            this.z_txt.Size = new System.Drawing.Size(105, 25);
            this.z_txt.TabIndex = 14;
            this.z_txt.Text = "0000 0000";
            // 
            // ac_txt
            // 
            this.ac_txt.AutoSize = true;
            this.ac_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ac_txt.Location = new System.Drawing.Point(779, 69);
            this.ac_txt.Name = "ac_txt";
            this.ac_txt.Size = new System.Drawing.Size(105, 25);
            this.ac_txt.TabIndex = 13;
            this.ac_txt.Text = "0000 0000";
            // 
            // tr_txt
            // 
            this.tr_txt.AutoSize = true;
            this.tr_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tr_txt.Location = new System.Drawing.Point(453, 94);
            this.tr_txt.Name = "tr_txt";
            this.tr_txt.Size = new System.Drawing.Size(105, 25);
            this.tr_txt.TabIndex = 18;
            this.tr_txt.Text = "0000 0000";
            // 
            // dr_txt
            // 
            this.dr_txt.AutoSize = true;
            this.dr_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dr_txt.Location = new System.Drawing.Point(453, 69);
            this.dr_txt.Name = "dr_txt";
            this.dr_txt.Size = new System.Drawing.Size(105, 25);
            this.dr_txt.TabIndex = 17;
            this.dr_txt.Text = "0000 0000";
            // 
            // pc_txt
            // 
            this.pc_txt.AutoSize = true;
            this.pc_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pc_txt.Location = new System.Drawing.Point(453, 44);
            this.pc_txt.Name = "pc_txt";
            this.pc_txt.Size = new System.Drawing.Size(203, 25);
            this.pc_txt.TabIndex = 16;
            this.pc_txt.Text = "0000 0000 0000 0000";
            // 
            // ar_txt
            // 
            this.ar_txt.AutoSize = true;
            this.ar_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ar_txt.Location = new System.Drawing.Point(453, 19);
            this.ar_txt.Name = "ar_txt";
            this.ar_txt.Size = new System.Drawing.Size(203, 25);
            this.ar_txt.TabIndex = 15;
            this.ar_txt.Text = "0000 0000 0000 0000";
            // 
            // status_txt
            // 
            this.status_txt.AutoSize = true;
            this.status_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_txt.Location = new System.Drawing.Point(241, 19);
            this.status_txt.Name = "status_txt";
            this.status_txt.Size = new System.Drawing.Size(86, 25);
            this.status_txt.TabIndex = 20;
            this.status_txt.Text = "Stopped";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(44, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(191, 25);
            this.label18.TabIndex = 19;
            this.label18.Text = "Current CPU Status:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(44, 44);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(219, 25);
            this.label20.TabIndex = 21;
            this.label20.Text = "Current RTL Statement:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(44, 94);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(238, 25);
            this.label19.TabIndex = 22;
            this.label19.Text = "Current Memory Location:";
            // 
            // memory_txt
            // 
            this.memory_txt.AutoSize = true;
            this.memory_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memory_txt.Location = new System.Drawing.Point(288, 94);
            this.memory_txt.Name = "memory_txt";
            this.memory_txt.Size = new System.Drawing.Size(23, 25);
            this.memory_txt.TabIndex = 23;
            this.memory_txt.Text = "0";
            // 
            // memLocation
            // 
            this.memLocation.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.memLocation.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memLocation.ForeColor = System.Drawing.SystemColors.Window;
            this.memLocation.Location = new System.Drawing.Point(49, 140);
            this.memLocation.Multiline = true;
            this.memLocation.Name = "memLocation";
            this.memLocation.Size = new System.Drawing.Size(350, 37);
            this.memLocation.TabIndex = 24;
            this.memLocation.Text = "0";
            this.memLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_memory
            // 
            this.btn_memory.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_memory.Font = new System.Drawing.Font("Stencil", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_memory.Location = new System.Drawing.Point(408, 599);
            this.btn_memory.Name = "btn_memory";
            this.btn_memory.Size = new System.Drawing.Size(105, 50);
            this.btn_memory.TabIndex = 25;
            this.btn_memory.Text = "MemoryView AND I/O";
            this.btn_memory.UseVisualStyleBackColor = false;
            this.btn_memory.Click += new System.EventHandler(this.btn_memoryView);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Font = new System.Drawing.Font("Stencil", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(523, 599);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 50);
            this.button2.TabIndex = 26;
            this.button2.Text = "Clear Memory And I/O";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ClearMemoryAndIO);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(1046, 85);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(121, 25);
            this.label22.TabIndex = 27;
            this.label22.Text = "Breakpoints:";
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteBtn.Font = new System.Drawing.Font("Stencil", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(1278, 150);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(113, 50);
            this.deleteBtn.TabIndex = 28;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.Delete_Breakpoint);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addBtn.Font = new System.Drawing.Font("Stencil", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(1278, 206);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(113, 50);
            this.addBtn.TabIndex = 29;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.Add_Breakpoint);
            // 
            // breakLine
            // 
            this.breakLine.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.breakLine.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakLine.ForeColor = System.Drawing.SystemColors.Window;
            this.breakLine.Location = new System.Drawing.Point(1178, 284);
            this.breakLine.Multiline = true;
            this.breakLine.Name = "breakLine";
            this.breakLine.Size = new System.Drawing.Size(213, 37);
            this.breakLine.TabIndex = 30;
            this.breakLine.Text = "0";
            this.breakLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(1012, 287);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(155, 25);
            this.label23.TabIndex = 31;
            this.label23.Text = "Address or Line:";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1217, 130);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(22, 148);
            this.vScrollBar1.TabIndex = 33;
            // 
            // breakBox
            // 
            this.breakBox.FormattingEnabled = true;
            this.breakBox.ItemHeight = 16;
            this.breakBox.Location = new System.Drawing.Point(1037, 130);
            this.breakBox.Name = "breakBox";
            this.breakBox.Size = new System.Drawing.Size(202, 148);
            this.breakBox.TabIndex = 34;
            // 
            // binaryBtn
            // 
            this.binaryBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.binaryBtn.Font = new System.Drawing.Font("Stencil", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryBtn.Location = new System.Drawing.Point(771, 178);
            this.binaryBtn.Name = "binaryBtn";
            this.binaryBtn.Size = new System.Drawing.Size(113, 33);
            this.binaryBtn.TabIndex = 35;
            this.binaryBtn.Text = "Binary";
            this.binaryBtn.UseVisualStyleBackColor = false;
            this.binaryBtn.Click += new System.EventHandler(this.binaryMemory);
            // 
            // hexBtn
            // 
            this.hexBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.hexBtn.Font = new System.Drawing.Font("Stencil", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexBtn.Location = new System.Drawing.Point(890, 178);
            this.hexBtn.Name = "hexBtn";
            this.hexBtn.Size = new System.Drawing.Size(113, 33);
            this.hexBtn.TabIndex = 36;
            this.hexBtn.Text = "Hex";
            this.hexBtn.UseVisualStyleBackColor = false;
            this.hexBtn.Click += new System.EventHandler(this.hexMemory);
            // 
            // rtl_txt
            // 
            this.rtl_txt.AutoSize = true;
            this.rtl_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtl_txt.Location = new System.Drawing.Point(266, 44);
            this.rtl_txt.Name = "rtl_txt";
            this.rtl_txt.Size = new System.Drawing.Size(61, 25);
            this.rtl_txt.TabIndex = 37;
            this.rtl_txt.Text = "Fetch";
            // 
            // starter
            // 
            this.starter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.starter.Font = new System.Drawing.Font("Stencil", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starter.Location = new System.Drawing.Point(771, 599);
            this.starter.Name = "starter";
            this.starter.Size = new System.Drawing.Size(113, 50);
            this.starter.TabIndex = 38;
            this.starter.Text = "Start";
            this.starter.UseVisualStyleBackColor = false;
            this.starter.Click += new System.EventHandler(this.Start_RSCPU);
            // 
            // next_instruction
            // 
            this.next_instruction.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.next_instruction.Font = new System.Drawing.Font("Stencil", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_instruction.Location = new System.Drawing.Point(890, 599);
            this.next_instruction.Name = "next_instruction";
            this.next_instruction.Size = new System.Drawing.Size(113, 50);
            this.next_instruction.TabIndex = 39;
            this.next_instruction.Text = "Next";
            this.next_instruction.UseVisualStyleBackColor = false;
            this.next_instruction.Click += new System.EventHandler(this.Next_RSCPU);
            // 
            // datamove_txt
            // 
            this.datamove_txt.AutoSize = true;
            this.datamove_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datamove_txt.Location = new System.Drawing.Point(81, 69);
            this.datamove_txt.Name = "datamove_txt";
            this.datamove_txt.Size = new System.Drawing.Size(61, 25);
            this.datamove_txt.TabIndex = 40;
            this.datamove_txt.Text = "Fetch";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 673);
            this.Controls.Add(this.datamove_txt);
            this.Controls.Add(this.next_instruction);
            this.Controls.Add(this.starter);
            this.Controls.Add(this.rtl_txt);
            this.Controls.Add(this.hexBtn);
            this.Controls.Add(this.binaryBtn);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.breakLine);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_memory);
            this.Controls.Add(this.memLocation);
            this.Controls.Add(this.memory_txt);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.status_txt);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tr_txt);
            this.Controls.Add(this.dr_txt);
            this.Controls.Add(this.pc_txt);
            this.Controls.Add(this.ar_txt);
            this.Controls.Add(this.z_txt);
            this.Controls.Add(this.ac_txt);
            this.Controls.Add(this.r_txt);
            this.Controls.Add(this.ir_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.InstructionCode);
            this.Controls.Add(this.breakBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InstructionCode;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ir_txt;
        private System.Windows.Forms.Label r_txt;
        private System.Windows.Forms.Label z_txt;
        private System.Windows.Forms.Label ac_txt;
        private System.Windows.Forms.Label tr_txt;
        private System.Windows.Forms.Label dr_txt;
        private System.Windows.Forms.Label pc_txt;
        private System.Windows.Forms.Label ar_txt;
        private System.Windows.Forms.Label status_txt;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label memory_txt;
        private System.Windows.Forms.TextBox memLocation;
        private System.Windows.Forms.Button btn_memory;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox breakLine;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.ListBox breakBox;
        private System.Windows.Forms.Button binaryBtn;
        private System.Windows.Forms.Button hexBtn;
        private System.Windows.Forms.Label rtl_txt;
        private System.Windows.Forms.Button starter;
        private System.Windows.Forms.Button next_instruction;
        private System.Windows.Forms.Label datamove_txt;
    }
}

