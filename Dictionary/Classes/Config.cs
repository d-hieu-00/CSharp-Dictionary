using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Classes
{
    class Config
    {
        public static int DefaultRounded = 4;
        public static int DefaultShowSearch = 25;
        public static bool PlaySoundGame = true;
        public static string DirConfig = "./Config/";
        public static string NameFileConfig = "config.con";
        public static string NameApp = "Nhóm 17";
        public static string Loading = "Đang tải dữ liệu";
        public static Font defFont = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        public static Font boldFont = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        public static Color colorVoc = Color.Black;
        public static Color colorPro = Color.Firebrick;
        public static Color colorTyp = Color.SeaGreen;
        public static Color colorMea = Color.Black;
        public static Color colorSub = Color.DarkCyan;
        public static Color colorExm = Color.DimGray;
    }
}
