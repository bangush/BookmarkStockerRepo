using System.Windows.Forms;

namespace BookmarksStocker.Source.Util
{
    internal class MessageUtil
    {
        public static void Message(string strMessage)
        {
            MessageBox.Show(strMessage, "Message");
        }

        public static DialogResult Confirm(string strMessage)
        {
            DialogResult dr = MessageBox.Show(strMessage, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return dr;
        }

        public static void Error(string errText)
        {
            MessageBox.Show(errText, "Error!..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        public static void Warn(string warningText)
        {
            MessageBox.Show(warningText, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
    }
}