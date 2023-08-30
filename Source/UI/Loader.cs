using System;
using System.Threading.Tasks;
using VisualTexture_v2.Source.Components;
using VisualTexture_v2.Source.Classes;

namespace VisualTexture_v2.Source.UI
{
    public partial class Loader : VSWindow
    {
        public Loader()
        {
            InitializeComponent();
        }

        private async void Loader_Load(object sender, System.EventArgs e)
        {

            await Updater.FetchUpdates();

            await Task.Delay(3000);

            Invoke(new Action(() =>
            {
                MainForm form = new MainForm();
                form.Show();
                Close();
            }));
        }
    }
}
