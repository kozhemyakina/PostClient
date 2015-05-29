using System.Windows.Forms;
using PostClient.UI;

namespace PostClient.TrayPlugin
{
    internal class TrayPlugin : IPlugin
    {
        public void Dispose()
        {
            MessageBox.Show("TrayPlugin unloaded");
        }
        private void InitializeComponents()
        {
            
        }
        public void DoActions(Form form)
        {
            MessageBox.Show("Tray plugin loaded");
        }
    }
}