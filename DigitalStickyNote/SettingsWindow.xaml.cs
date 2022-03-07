using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DigitalStickyNote
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        /// <summary>
        /// The global settings.
        /// </summary>
        private Settings globalSettings;

        public SettingsWindow()
        {
            InitializeComponent();

            // load fonts.
            int i = 0;
            bool foundSegoe = false;
            foreach (var font in Fonts.SystemFontFamilies)
            {
                if (font.Source.StartsWith("Segoe UI") && !foundSegoe)
                {
                    FontCombo.SelectedIndex = i;
                    foundSegoe = true;
                }
                i++;
                FontCombo.Items.Add(new TextBlock()
                {
                    Text = font.Source,
                    FontFamily = font
                });
            }



        }
    }
}
