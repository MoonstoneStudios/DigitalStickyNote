using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DigitalStickyNote
{
    /// <summary>
    /// The settings class holds all data regarding settings.
    /// </summary>
    public class Settings
    {

        /// <summary>
        /// The color of the sticky note.
        /// </summary>
        public SolidColorBrush StickyColor { get; set; }
        
        /// <summary>
        /// The font family.
        /// </summary>
        public FontFamily FontFamily { get; set; }

        /// <summary>
        /// The weight of the font.
        /// </summary>
        public string FontWeight { get; set; }

        /// <summary>
        /// If the settings are global.
        /// </summary>
        public readonly bool IsGlobalSettings;

        /// <summary>
        /// This is a setting for global only. This will set whether new notes start pinned or not.  
        /// </summary>
        public bool ShouldNotesStartPinned { get; set; } = true;

        /// <summary>
        /// This is a setting for global only. This will set whether the application starts up when the computer starts.
        /// </summary>
        public bool ShouldNotesStartWithComputer { get; set; } = true;

        /// <summary>
        /// This is a setting for global only. This will set whether the application starts up in the system tray.
        /// </summary>
        public bool ShouldNotesStartInTray { get; set; } = true;

        /// <summary>
        /// This is a setting for global only. If this is true the notes will save when the user types. If false, it will save when the note closes.
        /// </summary>
        public bool ShouldNotesAutoSave { get; set; } = true;

        /// <summary>
        /// If the notes should have spellcheck enabled.
        /// </summary>
        public bool SpellCheck { get; set; } = true;

    }
}
