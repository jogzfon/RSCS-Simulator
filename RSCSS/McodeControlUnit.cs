using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSCSS
{
    public class McodeControlUnit
    {
        private const int COND_MASK = 0x60000000;
        private const int BT_MASK = 0x10000000;
        private const int OPER_MASK = 0x0fffffc0;
        private const int ARPC_MASK = 0x08000000;
        private const int ARIN_MASK = 0x04000000;
        private const int ARDT_MASK = 0x02000000;
        private const int PCIN_MASK = 0x01000000;
        private const int PCDT_MASK = 0x00800000;
        private const int DRM_MASK = 0x00400000;
        private const int DRAC_MASK = 0x00200000;
        private const int IRDR_MASK = 0x00100000;
        private const int RAC_MASK = 0x00080000;
        private const int ZALU_MASK = 0x00040000;
        private const int TRDR_MASK = 0x00020000;
        private const int ACDR_MASK = 0x00010000;
        private const int ACR_MASK = 0x00008000;
        private const int PLUS_MASK = 0x00004000;
        private const int MINU_MASK = 0x00002000;
        private const int ACIN_MASK = 0x00001000;
        private const int ACZO_MASK = 0x00000800;
        private const int AND_MASK = 0x00000400;
        private const int OR_MASK = 0x00000200;
        private const int XOR_MASK = 0x00000100;
        private const int NOT_MASK = 0x00000080;
        private const int MDR_MASK = 0x00000040;
        private const int ADDR_MASK = 0x0000003f;

        private const int COND_1 = 0x00000000;
        private const int COND_Z = 0x20000000;
        private const int COND_NOT_Z = 0x40000000;
        private const int COND_X = 0x60000000;

        private const int BT_JUMP = 0x00000000;
        private const int BT_MAP = 0x10000000;

        private const int OPER_ARPC = 0x08000000;
        private const int OPER_ARIN = 0x04000000;
        private const int OPER_ARDT = 0x02000000;
        private const int OPER_PCIN = 0x01000000;
        private const int OPER_PCDT = 0x00800000;
        private const int OPER_DRM = 0x00400000;
        private const int OPER_DRAC = 0x00200000;
        private const int OPER_IRDR = 0x00100000;
        private const int OPER_RAC = 0x00080000;
        private const int OPER_ZALU = 0x00040000;
        private const int OPER_TRDR = 0x00020000;
        private const int OPER_ACDR = 0x00010000;
        private const int OPER_ACR = 0x00008000;
        private const int OPER_PLUS = 0x00004000;
        private const int OPER_MINU = 0x00002000;
        private const int OPER_ACIN = 0x00001000;
        private const int OPER_ACZO = 0x00000800;
        private const int OPER_AND = 0x00000400;
        private const int OPER_OR = 0x00000200;
        private const int OPER_XOR = 0x00000100;
        private const int OPER_NOT = 0x00000080;
        private const int OPER_MDR = 0x00000040;

        private const int ADDR_X = 0x0000003f;

        private int[] microcode =
        {
            COND_1 | BT_JUMP | 0x01,                                        // NOP1
            COND_1 | BT_JUMP | OPER_ARPC | 0x02,                            // FETCH1
            COND_1 | BT_JUMP | OPER_PCIN | OPER_DRM | 0x03,                 // FETCH2
            COND_X | BT_MAP | OPER_ARPC | OPER_IRDR | ADDR_X,               // FETCH3
            COND_1 | BT_JUMP | OPER_ARIN | OPER_PCIN | OPER_DRM | 0x05,     // LDAC1
            COND_1 | BT_JUMP | OPER_PCIN | OPER_DRM | OPER_TRDR | 0x06,     // LDAC2
            COND_1 | BT_JUMP | OPER_ARDT | 0x07,                            // LDAC3
            COND_1 | BT_JUMP | OPER_DRM | 0x21,                             // LDAC4
            COND_1 | BT_JUMP | OPER_ARIN | OPER_PCIN | OPER_DRM | 0x09,     // STAC1
            COND_1 | BT_JUMP | OPER_PCIN | OPER_DRM | OPER_TRDR | 0x0a,     // STAC2
            COND_1 | BT_JUMP | OPER_ARDT | 0x0b,                            // STAC3
            COND_1 | BT_JUMP | OPER_DRAC | 0x22,                            // STAC4
            COND_1 | BT_JUMP | OPER_RAC | 0x01,                             // MVAC1
            -1,
            -1,
            -1,
            COND_1 | BT_JUMP | OPER_ACR | 0x01,                             // MOVR1
            -1,
            -1,
            -1,
            COND_1 | BT_JUMP | OPER_ARIN | OPER_DRM | 0x15,                 // JUMP1
            COND_1 | BT_JUMP | OPER_DRM | OPER_TRDR | 0x16,                 // JUMP2
            COND_1 | BT_JUMP | OPER_PCDT | 0x01,                            // JUMP3
            -1,
            COND_NOT_Z | BT_JUMP | 0x29,                                    // JMPZ1
            COND_1 | BT_JUMP | OPER_ARIN | OPER_DRM | 0x1a,                 // JMPZY1
            COND_1 | BT_JUMP | OPER_DRM | OPER_TRDR | 0x1b,                 // JMPZY2
            COND_1 | BT_JUMP | OPER_PCDT | 0x01,                            // JMPZY3
            COND_Z | BT_JUMP | 0x2d,                                        // JPNZ1
            COND_1 | BT_JUMP | OPER_ARIN | OPER_DRM | 0x1e,                 // JPNZY1
            COND_1 | BT_JUMP | OPER_DRM | OPER_TRDR | 0x1f,                 // JPNZY2
            COND_1 | BT_JUMP | OPER_PCDT | 0x01,                            // JPNZY3
            COND_1 | BT_JUMP | OPER_ZALU | OPER_PLUS | 0x01,                // ADD1
            COND_1 | BT_JUMP | OPER_ACDR | 0x01,                            // LDAC5
            COND_1 | BT_JUMP | OPER_MDR | 0x01,                             // STAC5
            -1,
            COND_1 | BT_JUMP | OPER_ZALU | OPER_MINU | 0x01,                // SUB1
            -1,
            -1,
            -1,
            COND_1 | BT_JUMP | OPER_ZALU | OPER_ACIN | 0x01,                // INAC1
            COND_1 | BT_JUMP | OPER_PCIN | 0x2a,                            // JMPZN1
            COND_1 | BT_JUMP | OPER_PCIN | 0x01,                            // JMPZN2
            -1,
            COND_1 | BT_JUMP | OPER_ZALU | OPER_ACZO | 0x01,                // CLAC1
            COND_1 | BT_JUMP | OPER_PCIN | 0x2e,                            // JPNZN1
            COND_1 | BT_JUMP | OPER_PCIN | 0x01,                            // JPNZN2
            -1,
            COND_1 | BT_JUMP | OPER_ZALU | OPER_AND | 0x01,                 // AND1
            -1,
            -1,
            -1,
            COND_1 | BT_JUMP | OPER_ZALU | OPER_OR | 0x01,                  // OR1
            -1,
            -1,
            -1,
            COND_1 | BT_JUMP | OPER_ZALU | OPER_XOR | 0x01,                 // XOR1
            -1,
            -1,
            -1,
            COND_1 | BT_JUMP | OPER_ZALU | OPER_NOT | 0x01,                 // NOT1
            -1,
            -1
        };

    }
}
