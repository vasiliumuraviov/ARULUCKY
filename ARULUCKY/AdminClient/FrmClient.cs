using Shared;
using Shared.Extensions;

namespace AdminClient
{
    public partial class FrmClient : Form
    {
        #region Fields GETters:

        private string? CardName => textCardName.Text;
        private string? CardDesc => textCardDescription.Text;
        private MemoryStream? FileStream;

        #endregion

        private bool RequiredFieldsFilled => !string.IsNullOrEmpty(CardName) && !string.IsNullOrEmpty(CardDesc) && !FileStream.IsNull() && FileStream?.Length != 0;

        public FrmClient()
        {
            InitializeComponent();
        }

        private void OnLoadFileClick(object sender, EventArgs e)
        {
            using OpenFileDialog dialog = new();
            dialog.Filter = ConfigurationWrap.ALLOWED_EXTENSIONS_FILE_FIlTER;
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            string filePath = dialog.FileName;
            FileStream = new MemoryStream(File.ReadAllBytes(filePath));
        }

        private void OnAddCardToPull(object sender, EventArgs e)
        {
            if (!RequiredFieldsFilled)
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }

            //
        }
    }
}