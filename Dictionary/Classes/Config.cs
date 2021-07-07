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
        // ready only
        public static readonly string ApiAudio = "https://api.dictionaryapi.dev/api/v2/entries/en_US/";
        public static readonly string ApiTrans = "https://google-translate1.p.rapidapi.com/language/translate/v2";
        public static readonly string LinkGetKeyApiTrans = "https://rapidapi.com/googlecloud/api/google-translate1/";
        public static readonly string KeyApiTrans = "f97eb4090emsha33d76a8f7380dap14accfjsn0c443d295fc7";
        public static readonly string BackgroundMp3 = "./Data/background.mp3";
        public static readonly string DirDataTopic = "./Data/Topics/";
        public static readonly string DirConfig = "./Config/";
        public static readonly string NameFileResult = "result.con";
        public static readonly string NameFileConfig = "config.con";

        // can edit by settings
        public static int DefaultRounded = 4;
        public static int DefaultShowSearch = 25;
        public static bool PlaySoundGame = true;
        public static bool PlaySoundGameBackground = true;
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
