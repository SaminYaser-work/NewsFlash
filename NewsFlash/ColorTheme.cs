using System.Drawing;

namespace NewsFlash
{
    public class ColorTheme
    {
        private static bool isLight = false;

        // Dark theme colors
        private static Color dHard = Color.FromArgb(32, 34, 37);
        private static Color dMedium = Color.FromArgb(47, 49, 54);
        private static Color dSoft = Color.FromArgb(54, 57, 63);
        private static Color dHighlight = Color.FromArgb(57, 60, 67);
        private static Color dInactive = Color.FromArgb(142, 146, 151);
        private static Color dDivider = Color.FromArgb(66, 69, 74);
        private static Color dText = Color.White;

        // Light theme colors
        private static Color lHard = Color.FromArgb(227, 229, 232);
        private static Color lMedium = Color.FromArgb(242, 243, 245);
        private static Color lSoft = Color.White;
        private static Color lHighlight = Color.FromArgb(212, 215, 220);
        private static Color lInactive = Color.FromArgb(106, 116, 128);
        private static Color lDivider = Color.FromArgb(235, 235, 236);
        private static Color lText = Color.Black;

        // Universal
        private static Color accent = Color.FromArgb(59, 165, 93);
        //private static Color button = Color.FromArgb(88, 101, 242);
        private static Color button = Color.FromArgb(114, 137, 218);

        // Logo
        private static Image dLogo = Properties.Resources.newsflash_logo_dark_removebg_preview;
        private static Image lLogo = Properties.Resources.newsflash_logo_light_removebg_preview;

        // Accessors
        public static Color Hard
        {
            get => isLight ? lHard : dHard;
        }
        public static Color Medium
        {
            get => isLight ? lMedium : dMedium;
        }
        public static Color Soft
        {
            get => isLight ? lSoft : dSoft;
        }
        public static Color Highlight
        {
            get => isLight ? lHighlight : dHighlight;
        }
        public static Color Inactive
        {
            get => isLight ? lInactive : dInactive;
        }
        public static Color Divider
        {
            get => isLight ? lDivider : dDivider;
        }
        public static Color Text
        {
            get => isLight ? lText : dText;
        }
        public static Color Accent { get => accent; }
        public static Color Button { get => button; }
        public static Image Logo { get => isLight ? lLogo : dLogo; }

        public enum Theme
        {
            Light,
            Dark
        }

        // Change theme method
        public static void ChangeTheme(Theme theme)
        {
            if (theme == Theme.Light) isLight = true;
            else isLight = false;
        }
    }
}
