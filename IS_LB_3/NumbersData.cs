using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_LB_3
{
    class NumbersData
    {
        //матрицы для обучения (эталонные цифры)
        static char[] num0 = "01110100011000110001100011000101110".ToCharArray();
        static char[] num1 = "00100011000010000100001000010001110".ToCharArray();
        static char[] num2 = "01110100010000100010011001000011111".ToCharArray();
        static char[] num3 = "01110100010000100110000011000101110".ToCharArray();
        static char[] num4 = "00110010101001010010111110001000010".ToCharArray();
        static char[] num5 = "11111100001111000001000011000101110".ToCharArray();
        static char[] num6 = "01110100011000011110100011000101110".ToCharArray();
        static char[] num7 = "11111000010001000100010000100001000".ToCharArray();
        static char[] num8 = "01110100011000101110100011000101110".ToCharArray();
        static char[] num9 = "01110100011000101111000011000101110".ToCharArray();

        public char[][] nums = { num0, num1, num2, num3, num4, num5, num6, num7, num8, num9 };

        //Матрицы для теста
        static char[] def00 = "01110100011000100000100011000101110".ToCharArray();
        static char[] def01 = "01110100010000000000000001000101110".ToCharArray();
        static char[] def02 = "01010100011000110001100011000101010".ToCharArray();
        static char[][] def0 = { def00, def01, def02 };

        static char[] def10 = "00100001000010000100001000010001110".ToCharArray();
        static char[] def11 = "00100011000010000100001000010000100".ToCharArray();
        static char[] def12 = "00000011000010000100001000010001110".ToCharArray();
        static char[][] def1 = { def10, def11, def12 };

        static char[] def20 = "01110000000000100010011001000011111".ToCharArray();
        static char[] def21 = "01110100010000100010000001000011111".ToCharArray();
        static char[] def22 = "01110100010000100010011001000011100".ToCharArray();
        static char[][] def2 = { def20, def21, def22 };

        static char[] def30 = "01110100010000100000000011000101110".ToCharArray();
        static char[] def31 = "01110000010000100110000010000101110".ToCharArray();
        static char[] def32 = "01110100000000000110000001000001110".ToCharArray();
        static char[][] def3 = { def30, def31, def32 };

        static char[] def40 = "00110010101001010010111000001000010".ToCharArray();
        static char[] def41 = "00010000101001010010111110001000010".ToCharArray();
        static char[] def42 = "00110010101001010010100110001000000".ToCharArray();
        static char[][] def4 = { def40, def41, def42 };

        static char[] def50 = "11111100001111000000000000000001110".ToCharArray();
        static char[] def51 = "11100100001111000001000010000100110".ToCharArray();
        static char[] def52 = "11101100001111000001000001000100010".ToCharArray();
        static char[][] def5 = { def50, def51, def52 };

        static char[] def60 = "01110000001000011110100011000101110".ToCharArray();
        static char[] def61 = "01010100011000011010100011000101010".ToCharArray();
        static char[] def62 = "01110100001000011110100001000001110".ToCharArray();
        static char[][] def6 = { def60, def61, def62 };

        static char[] def70 = "10011000010001000100010000100001000".ToCharArray();
        static char[] def71 = "11111000010000000000010000100001000".ToCharArray();
        static char[] def72 = "11111000010001000100000000000001000".ToCharArray();
        static char[][] def7 = { def70, def71, def72 };

        static char[] def80 = "01010100011000101010100011000101010".ToCharArray();
        static char[] def81 = "01110100011000101110100001000001100".ToCharArray();
        static char[] def82 = "01110000001000101110100010000001110".ToCharArray();
        static char[][] def8 = { def80, def81, def82 };

        static char[] def90 = "01010100011000101011000011000101010".ToCharArray();
        static char[] def91 = "01110000010000101111000010000101110".ToCharArray();
        static char[] def92 = "01110100011000101111000010000001110".ToCharArray();
        static char[][] def9 = { def90, def91, def92 };

        public char[][][] def = { def0, def1, def2, def3, def4, def5, def6, def7, def8, def9 };
    }
}
