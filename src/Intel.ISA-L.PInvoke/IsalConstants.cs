namespace ISA_L.PInvoke
{
    public static class IsalConstants
    {
        public const string NATIVE_DLL_NAME = "isa-l";
        public const string WindowsDLLPath = @"runtimes\win-x{0}\native";

        /* Inflate Implementation Specific Defines */
        public const int ISAL_DECODE_LONG_BITS = 12;
        public const int ISAL_DECODE_SHORT_BITS = 10;

        /* Deflate Compression Standard Defines */
        public const int ISAL_DEF_HIST_SIZE = 32 * 1024;
        public const int ISAL_DEF_MAX_HDR_SIZE = 328;

        public const int ISAL_DEF_LIT_SYMBOLS = 257;
        public const int ISAL_DEF_LEN_SYMBOLS = 29;
        public const int ISAL_DEF_DIST_SYMBOLS = 30;
        public const int ISAL_DEF_LIT_LEN_SYMBOLS = IsalConstants.ISAL_DEF_LIT_SYMBOLS + IsalConstants.ISAL_DEF_LEN_SYMBOLS;

        public const int ISAL_LOOK_AHEAD = (258 + 31) & ~31;

        /* Inflate structures */
        public const int ISAL_L_REM = 21 - IsalConstants.ISAL_DECODE_LONG_BITS;
        public const int ISAL_S_REM = 15 - IsalConstants.ISAL_DECODE_SHORT_BITS;

        public const int ISAL_L_DUP = (1 << IsalConstants.ISAL_L_REM) - (IsalConstants.ISAL_L_REM + 1);
        public const int ISAL_S_DUP = (1 << IsalConstants.ISAL_S_REM) - (IsalConstants.ISAL_S_REM + 1);

        public const int ISAL_L_UNUSED = (1 << IsalConstants.ISAL_L_REM) - (1 << (IsalConstants.ISAL_L_REM / 2)) - (1 << ((IsalConstants.ISAL_L_REM + 1) / 2)) + 1;
        public const int ISAL_S_UNUSED = (1 << IsalConstants.ISAL_S_REM) - (1 << ((IsalConstants.ISAL_S_REM) / 2)) - (1 << ((IsalConstants.ISAL_S_REM + 1) / 2)) + 1;

        public const int ISAL_L_SIZE = IsalConstants.ISAL_DEF_LIT_LEN_SYMBOLS + IsalConstants.ISAL_L_DUP + IsalConstants.ISAL_L_UNUSED;
        public const int ISAL_S_SIZE = IsalConstants.ISAL_DEF_DIST_SYMBOLS + IsalConstants.ISAL_S_DUP + IsalConstants.ISAL_S_UNUSED;

        public const int ISAL_HUFF_CODE_LARGE_LONG_ALIGNED = IsalConstants.ISAL_L_SIZE + (-IsalConstants.ISAL_L_SIZE & 0xf);
        public const int ISAL_HUFF_CODE_SMALL_LONG_ALIGNED = IsalConstants.ISAL_S_SIZE + (-IsalConstants.ISAL_S_SIZE & 0xf);
    }
}