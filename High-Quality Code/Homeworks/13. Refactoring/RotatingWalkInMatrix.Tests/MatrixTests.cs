﻿namespace RotatingWalkInMatrix.Tests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class MatrixTests
    {
        private readonly object[] testMatrices =
        {
            new object[] 
            {
                1,
                new[,]
                {
                    { 1 },
                }
            },

            new object[] 
            {
                2,
                new[,]
                {
                    { 1, 4 },
                    { 3, 2 }
                }
            },

            new object[] 
            {
                4,
                new[,]
                {
                    { 1, 10, 11, 12 },
                    { 9, 2, 15, 13 },
                    { 8, 16, 3, 14 },
                    { 7, 6, 5, 4 }
                }
            },

            new object[] 
            {
                6,
                new[,]
                {
                    { 1, 16, 17, 18, 19, 20 },
                    { 15, 2, 27, 28, 29, 21 },
                    { 14, 31, 3, 26, 30, 22 },
                    { 13, 36, 32, 4, 25, 23 },
                    { 12, 35, 34, 33, 5, 24 },
                    { 11, 10, 9, 8, 7, 6 }
                }
            },

            new object[] 
            {
                10,
                new[,]
                {
                    { 1, 28, 29, 30, 31, 32, 33, 34, 35, 36 },
                    { 27, 2, 51, 52, 53, 54, 55, 56, 57, 37 },
                    { 26, 73, 3, 50, 66, 67, 68, 69, 58, 38 },
                    { 25, 90, 74, 4, 49, 65, 72, 70, 59, 39 },
                    { 24, 89, 91, 75, 5, 48, 64, 71, 60, 40 },
                    { 23, 88, 99, 92, 76, 6, 47, 63, 61, 41 },
                    { 22, 87, 98, 100, 93, 77, 7, 46, 62, 42 },
                    { 21, 86, 97, 96, 95, 94, 78, 8, 45, 43 },
                    { 20, 85, 84, 83, 82, 81, 80, 79, 9, 44 },
                    { 19, 18, 17, 16, 15, 14, 13, 12, 11, 10 }
                }
            },

            new object[] 
            {
                21,
                new[,]
                {
                    { 1, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80 },
                    { 60, 2, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 81 },
                    { 59, 271, 3, 116, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176, 177, 178, 179, 135, 82 },
                    { 58, 321, 272, 4, 115, 164, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 180, 136, 83 },
                    { 57, 320, 322, 273, 5, 114, 163, 203, 234, 235, 236, 237, 238, 239, 240, 241, 242, 216, 181, 137, 84 },
                    { 56, 319, 363, 323, 274, 6, 113, 162, 202, 233, 255, 256, 257, 258, 259, 260, 243, 217, 182, 138, 85 },
                    { 55, 318, 362, 364, 324, 275, 7, 112, 161, 201, 232, 254, 267, 268, 269, 261, 244, 218, 183, 139, 86 },
                    { 54, 317, 361, 396, 365, 325, 276, 8, 111, 160, 200, 231, 253, 266, 270, 262, 245, 219, 184, 140, 87 },
                    { 53, 316, 360, 395, 397, 366, 326, 277, 9, 110, 159, 199, 230, 252, 265, 263, 246, 220, 185, 141, 88 },
                    { 52, 315, 359, 394, 420, 398, 367, 327, 278, 10, 109, 158, 198, 229, 251, 264, 247, 221, 186, 142, 89 },
                    { 51, 314, 358, 393, 419, 421, 399, 368, 328, 279, 11, 108, 157, 197, 228, 250, 248, 222, 187, 143, 90 },
                    { 50, 313, 357, 392, 418, 435, 422, 400, 369, 329, 280, 12, 107, 156, 196, 227, 249, 223, 188, 144, 91 },
                    { 49, 312, 356, 391, 417, 434, 436, 423, 401, 370, 330, 281, 13, 106, 155, 195, 226, 224, 189, 145, 92 },
                    { 48, 311, 355, 390, 416, 433, 441, 437, 424, 402, 371, 331, 282, 14, 105, 154, 194, 225, 190, 146, 93 },
                    { 47, 310, 354, 389, 415, 432, 440, 439, 438, 425, 403, 372, 332, 283, 15, 104, 153, 193, 191, 147, 94 },
                    { 46, 309, 353, 388, 414, 431, 430, 429, 428, 427, 426, 404, 373, 333, 284, 16, 103, 152, 192, 148, 95 },
                    { 45, 308, 352, 387, 413, 412, 411, 410, 409, 408, 407, 406, 405, 374, 334, 285, 17, 102, 151, 149, 96 },
                    { 44, 307, 351, 386, 385, 384, 383, 382, 381, 380, 379, 378, 377, 376, 375, 335, 286, 18, 101, 150, 97 },
                    { 43, 306, 350, 349, 348, 347, 346, 345, 344, 343, 342, 341, 340, 339, 338, 337, 336, 287, 19, 100, 98 },
                    { 42, 305, 304, 303, 302, 301, 300, 299, 298, 297, 296, 295, 294, 293, 292, 291, 290, 289, 288, 20, 99 },
                    { 41, 40, 39, 38, 37, 36, 35, 34, 33, 32, 31, 30, 29, 28, 27, 26, 25, 24, 23, 22, 21 }
                }
            }
        };

        private readonly string drawnTestMatrix =
                     "   1  40  41  42  43  44  45  46  47  48  49  50  51  52" + Environment.NewLine +
                     "  39   2  75  76  77  78  79  80  81  82  83  84  85  53" + Environment.NewLine +
                     "  38 131   3  74 102 103 104 105 106 107 108 109  86  54" + Environment.NewLine +
                     "  37 160 132   4  73 101 120 121 122 123 124 110  87  55" + Environment.NewLine +
                     "  36 159 161 133   5  72 100 119 129 130 125 111  88  56" + Environment.NewLine +
                     "  35 158 181 162 134   6  71  99 118 128 126 112  89  57" + Environment.NewLine +
                     "  34 157 180 182 163 135   7  70  98 117 127 113  90  58" + Environment.NewLine +
                     "  33 156 179 193 183 164 136   8  69  97 116 114  91  59" + Environment.NewLine +
                     "  32 155 178 192 194 184 165 137   9  68  96 115  92  60" + Environment.NewLine +
                     "  31 154 177 191 196 195 185 166 138  10  67  95  93  61" + Environment.NewLine +
                     "  30 153 176 190 189 188 187 186 167 139  11  66  94  62" + Environment.NewLine +
                     "  29 152 175 174 173 172 171 170 169 168 140  12  65  63" + Environment.NewLine +
                     "  28 151 150 149 148 147 146 145 144 143 142 141  13  64" + Environment.NewLine +
                     "  27  26  25  24  23  22  21  20  19  18  17  16  15  14" + Environment.NewLine;

        [Test, TestCaseSource("testMatrices")]
        public void MatrixShouldBeGeneratedCorrectly(int length, int[,] testMatrix)
        {
            Matrix originalMatrix = new Matrix(length);
            Assert.That(originalMatrix.Body, Is.EqualTo(testMatrix));
        }

        [Test]
        public void MatrixShouldBeDrawnCorrectly()
        {
            Matrix originalMatrix = new Matrix(14);
            string drawnOriginalMatrix = originalMatrix.Draw().ToString();
            Assert.AreEqual(drawnOriginalMatrix, this.drawnTestMatrix);
        }
    }
}