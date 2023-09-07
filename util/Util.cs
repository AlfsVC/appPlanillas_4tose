using System;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;

namespace appPlanillas_4tose.util
{
    internal class Util
    {
        internal bool LetterSpaceBack(object sender,KeyPressEventArgs e) 
        {
            string txt = ((TextBox)sender).Text;
            char tecla = e.KeyChar;
            bool isLetter = char.IsLetter(tecla);
            bool isWhiteSpace = char.IsWhiteSpace(tecla);
            bool isBackPace=tecla == (char)Keys.Back;
            if ( !isLetter &&
                 !isWhiteSpace &&
                 !isBackPace || 
                 (isBackPace && txt == "")||
                 (isWhiteSpace && txt.EndsWith(" ")))
                  return true;
            return false;
        }
    }
}
