using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DigitalStickyNote
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class StickyNote : Window
    {
        public StickyNote()
        {
            InitializeComponent();
        }

        private void WindowIsDragged(object sender, MouseButtonEventArgs e)
        {
            // https://stackoverflow.com/a/36631416
            DragMove();
        }

        private void PinButtonClick(object sender, RoutedEventArgs e)
        {
            Topmost = !Topmost;
            if (!Topmost)
            {
                ((Button)sender).Effect = new DropShadowEffect()
                {
                    Opacity = 0.5f,
                    ShadowDepth = 3
                };

            }
            else
            {
                ((Button)sender).Effect = null;
            }
        }

        private void CloseButtonClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ScaleTextInRichtext(object sender, MouseWheelEventArgs e)
        {
            RichTextBox box = (RichTextBox)sender;
            if (box.IsFocused)
            {
                if (Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl))
                {

                    box.FontSize += e.Delta * 0.01f;

                    if (box.FontSize < 12)
                    {
                        box.FontSize = 12;
                    }
                    else if (box.FontSize > 36)
                    {
                        box.FontSize = 36;
                    }
                }
            }
        }

        private void SettingsButtonClick(object sender, RoutedEventArgs e)
        {
            Settings s = new Settings();
            s.Topmost = true;
            s.Title = $"{Title.Text} - Settings";
            s.Show();
        }

        private void NewNoteButtonClick(object sender, RoutedEventArgs e)
        {
            // https://stackoverflow.com/a/2734831
            // https://stackoverflow.com/a/3244693
            StickyNote note = new StickyNote();
            note.Show();

            Point thisNote = PointToScreen(new Point(Left, Top));

            Point newNote = new Point(thisNote.X + 50, thisNote.Y + 50);

            newNote = PointFromScreen(newNote);

            note.Left = newNote.X;
            note.Top = newNote.Y;

        }
    }
}
