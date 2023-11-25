using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RSCSS
{
    public class CPU
    {
        public static Box theBox;

        string currentRTL;
        string realRTL;

        public static int CU_HARDWIRED = 0;
        public static int CU_MICROCODED = 1;

        bool blank = false;
        bool some = false;

        public int registerAR;
        public int registerPC;
        public short registerDR;
        public short registerTR;
        public short registerIR;
        public short registerR;
        public short registerAC;
        public byte flagZ;

        public int simulationStartNumber;

        public CU controlUnit;
        public McodeControlUnit mcu;

        public ALU aluBox;

        private int controlUnitType = CU_HARDWIRED;
        private Thread runner = null;

        private bool cycleBreakNow = false;
        private bool instructionBreakNow = false;
        private bool canCycleBreak = false;
        private bool canInstructionBreak = false;
        private bool hasStarted = false;

        private int counter1 = 0;
        private int counter2 = 0;
        private int tempcounter = 0;

        private int memoryAddress;

        private bool stallAnimationCounter;
        private bool atBeginBreak;
        private bool atCycleBegin;

        private bool skipAnimation;

        private bool jumpDecisionMade;
        private bool jumpDecisionClockDisabled;

        private bool irChanged;

        private Breakpoints bp;
        public Memory memoryBox;

        int m = 0;
        int n = 0;
        int o = 0;

        int m2 = 0;
        int n2 = 0;
        int o2 = 0;

        int m3 = 0;
        int n3 = 0;
        int o3 = 0;

        int m4 = 0;
        int n4 = 0;
        int o4 = 0;

        int m5 = 0;
        int n5 = 0;
        int o5 = 0;

        int m6 = 0;
        int n6 = 0;
        int o6 = 0;

        int m7 = 0;
        int n7 = 0;
        int o7 = 0;

        int m8 = 0;
        int n8 = 0;
        int o8 = 0;

        int m9 = 0;
        int n9 = 0;
        int o9 = 0;

        int m10 = 0;
        int n10 = 0;
        int o10 = 0;

        int m11 = 0;
        int n11 = 0;
        int o11 = 0;

        int m12 = 0;
        int n12 = 0;
        int o12 = 0;

        int m13 = 0;
        int n13 = 0;
        int o13 = 0;

        int m14 = 0;
        int n14 = 0;
        int o14 = 0;

        int m15 = 0;
        int n15 = 0;
        int o15 = 0;

        int m16 = 0;
        int n16 = 0;
        int o16 = 0;

        int m17 = 0;
        int n17 = 0;
        int o17 = 0;

        int m18 = 0;
        int n18 = 0;
        int o18 = 0;

        int m19 = 0;
        int n19 = 0;
        int o19 = 0;

        int m20 = 0;
        int n20 = 0;
        int o20 = 0;

        int m21 = 0;
        int n21 = 0;
        int o21 = 0;

        int m23 = 0;
        int n23 = 0;
        int o23 = 0;

        int m24 = 0;
        int n24 = 0;
        int o24 = 0;


        int dot1 = 0;
        int dot2 = 0;
        int dot3 = 0;
        int dot4 = 0;
        int dot5 = 0;
        int dot6 = 0;



        public void clear()
        {
            dot1 = 0;
            dot2 = 0;
            dot3 = 0;
            dot4 = 0;
            dot5 = 0;
            dot6 = 0;

            m = 0;
            n = 0;
            o = 0;

            m2 = 0;
            n2 = 0;
            o2 = 0;

            m3 = 0;
            n3 = 0;
            o3 = 0;

            m4 = 0;
            n4 = 0;
            o4 = 0;

            m5 = 0;
            n5 = 0;
            o5 = 0;

            m6 = 0;
            n6 = 0;
            o6 = 0;

            m7 = 0;
            n7 = 0;
            o7 = 0;

            m8 = 0;
            n8 = 0;
            o8 = 0;

            m9 = 0;
            n9 = 0;
            o9 = 0;

            m10 = 0;
            n10 = 0;
            o10 = 0;

            m11 = 0;
            n11 = 0;
            o11 = 0;

            m12 = 0;
            n12 = 0;
            o12 = 0;

            m13 = 0;
            n13 = 0;
            o13 = 0;

            m14 = 0;
            n14 = 0;
            o14 = 0;

            m15 = 0;
            n15 = 0;
            o15 = 0;

            m16 = 0;
            n16 = 0;
            o16 = 0;

            m17 = 0;
            n17 = 0;
            o17 = 0;

            m18 = 0;
            n18 = 0;
            o18 = 0;

            m19 = 0;
            n19 = 0;
            o19 = 0;

            m20 = 0;
            n20 = 0;
            o20 = 0;

            m21 = 0;
            n21 = 0;
            o21 = 0;

            m23 = 0;
            n23 = 0;
            o23 = 0;

            m24 = 0;
            n24 = 0;
            o24 = 0;

            currentRTL = "";
            realRTL = "";
        }
        public void setControlUnitType(int cu)
        {
            controlUnitType = cu;
        }

        public int getControlUnitType()
        {
            return (controlUnitType);
        }

        public Memory GetMemory()
        {
            return (memoryBox);
        }

    }

}
