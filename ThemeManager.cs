using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moon.Utility
{
    public static class ThemeManager
    {
        /*
         * 
         * Primary: Use for main background container; Foundational.
         * 
         * Secondary: Use for layered surfaces or smaller containers that need separation from the primary background; Sidebars or modals.
         * 
         * Tertiary: Use for borders, small separators, or hover states for subtle differentiation
         * 
         * AccentPrimary: Use sparingly for elements requiring interaction; Buttons and active states.
         * 
         * AccentSecondary: Use for secondary highlights, buttons requiring extra attention, or small indicators 
         * 
         */
        public enum Style
        {
            Default,
            Primary,
            Secondary,
            Tertiary,
            AccentPrimary,
            AccentSecondary
        }

        private static readonly Dictionary<Style, (Color backColor, Color foreColor, Font font)> themes =
        new Dictionary<Style, (Color, Color, Font)>
        {
            { Style.Default, (Control.DefaultBackColor, Control.DefaultForeColor, Control.DefaultFont) },
            { Style.Primary, (ColorTranslator.FromHtml("#1C1C1C"), ColorTranslator.FromHtml("#000000"), new Font("Arial", 12)) },
            { Style.Secondary, (ColorTranslator.FromHtml("#333333"), ColorTranslator.FromHtml("#F5F5F5"), new Font("Arial", 12)) },
            { Style.Tertiary, (ColorTranslator.FromHtml("#4F4F4F"), ColorTranslator.FromHtml("#D6D6D6"), new Font("Arial", 12)) },
            { Style.AccentPrimary, (ColorTranslator.FromHtml("#00BCD4"), ColorTranslator.FromHtml("#1C1C1C"), new Font("Arial", 12)) },
            { Style.AccentSecondary, (ColorTranslator.FromHtml("#FF4081"), ColorTranslator.FromHtml("#FFFFFF"), new Font("Arial", 12)) },
        };

        public static void ApplyStyle(Control control, Style style)
        {
            if (themes.TryGetValue(style, out var props))
            {
                control.BackColor = props.backColor;
                control.ForeColor = props.foreColor;
                control.Font = props.font;
            }
        }

        public static void ApplyStyle(IEnumerable<Control> controls, Style style)
        {
            foreach (Control control in controls)
            {
                ApplyStyle(control, style);
            }
        }
    }
}
