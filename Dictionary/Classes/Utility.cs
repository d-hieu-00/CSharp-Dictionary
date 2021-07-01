using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary.Classes
{
    static class Utility
    {
        #region Rounded Control
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public static void RoundedControl(Control control)
        {
            control.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, Config.DefaultRounded, Config.DefaultRounded));
        }
        public static void RoundedControl(Control control, int r)
        {
            control.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, r, r));
        }
        public static void RoundedControl(Control control, int x, int y, int rw, int rh)
        {
            control.Region = Region.FromHrgn(CreateRoundRectRgn(x, y, control.Width, control.Height, rw, rh));
        }
        #endregion
        /** add to form to make shadow
         * 
         * 
        #region make shadow from
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= 0x00020000;
                return cp;
            }
        }
        #endregion
        */
        #region List, Dictionary
        public static IList<T> CloneList<T>(this IList<T> listToClone) where T : ICloneable
        {
            return listToClone.Select(item => (T)item.Clone()).ToList();
        }
        public static Dictionary<TKey, TValue> CloneDictionaryCloningValues<TKey, TValue>
            (Dictionary<TKey, TValue> original) where TValue : ICloneable
        {
            Dictionary<TKey, TValue> ret = new Dictionary<TKey, TValue>(original.Count, original.Comparer);
            foreach (KeyValuePair<TKey, TValue> entry in original)
            {
                ret.Add(entry.Key, (TValue)entry.Value.Clone());
            }
            return ret;
        }
        public static Dictionary<int, List<string>> CloneDictionaryCloningValues
            (Dictionary<int, List<string>> original)
        {
            Dictionary<int, List<string>> ret = new Dictionary<int, List<string>>(original.Count, original.Comparer);
            foreach (KeyValuePair<int, List<string>> entry in original)
            {
                ret.Add(entry.Key, (List<string>)CloneList(entry.Value));
            }
            return null;
        }
        #endregion
        #region Audio
        public static string GetAudioByWord(string w)
        {
            return null;
        }
        #endregion
    }
}
