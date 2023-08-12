namespace AdminClient
{
    partial class FrmClient
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAddCard = new Button();
            boxAddCard = new GroupBox();
            labelFileName = new Label();
            labelFileNamePrefix = new Label();
            labelCardFile = new Label();
            buttonLoadFile = new Button();
            labelCardDescription = new Label();
            textCardDescription = new TextBox();
            labelCardName = new Label();
            textCardName = new TextBox();
            fileLoader = new OpenFileDialog();
            boxAddCard.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAddCard
            // 
            buttonAddCard.Location = new Point(217, 245);
            buttonAddCard.Name = "buttonAddCard";
            buttonAddCard.Size = new Size(342, 23);
            buttonAddCard.TabIndex = 0;
            buttonAddCard.Text = "Добавить в пул";
            buttonAddCard.UseVisualStyleBackColor = true;
            buttonAddCard.Click += OnAddCardToPull;
            // 
            // boxAddCard
            // 
            boxAddCard.Controls.Add(labelFileName);
            boxAddCard.Controls.Add(buttonAddCard);
            boxAddCard.Controls.Add(labelFileNamePrefix);
            boxAddCard.Controls.Add(labelCardFile);
            boxAddCard.Controls.Add(buttonLoadFile);
            boxAddCard.Controls.Add(labelCardDescription);
            boxAddCard.Controls.Add(textCardDescription);
            boxAddCard.Controls.Add(labelCardName);
            boxAddCard.Controls.Add(textCardName);
            boxAddCard.Location = new Point(12, 12);
            boxAddCard.Name = "boxAddCard";
            boxAddCard.Size = new Size(776, 288);
            boxAddCard.TabIndex = 1;
            boxAddCard.TabStop = false;
            boxAddCard.Text = "Добавить карту";
            // 
            // labelFileName
            // 
            labelFileName.AutoSize = true;
            labelFileName.Location = new Point(452, 197);
            labelFileName.Name = "labelFileName";
            labelFileName.Size = new Size(16, 15);
            labelFileName.TabIndex = 7;
            labelFileName.Text = "...";
            // 
            // labelFileNamePrefix
            // 
            labelFileNamePrefix.AutoSize = true;
            labelFileNamePrefix.Location = new Point(334, 197);
            labelFileNamePrefix.Name = "labelFileNamePrefix";
            labelFileNamePrefix.Size = new Size(100, 15);
            labelFileNamePrefix.TabIndex = 6;
            labelFileNamePrefix.Text = "Название файла:";
            // 
            // labelCardFile
            // 
            labelCardFile.AutoSize = true;
            labelCardFile.Location = new Point(15, 197);
            labelCardFile.Name = "labelCardFile";
            labelCardFile.Size = new Size(75, 15);
            labelCardFile.TabIndex = 5;
            labelCardFile.Text = "Файл карты:";
            // 
            // buttonLoadFile
            // 
            buttonLoadFile.Location = new Point(102, 193);
            buttonLoadFile.Name = "buttonLoadFile";
            buttonLoadFile.Size = new Size(206, 23);
            buttonLoadFile.TabIndex = 4;
            buttonLoadFile.Text = "Загрузить";
            buttonLoadFile.UseVisualStyleBackColor = true;
            buttonLoadFile.Click += OnLoadFileClick;
            // 
            // labelCardDescription
            // 
            labelCardDescription.AutoSize = true;
            labelCardDescription.Location = new Point(15, 114);
            labelCardDescription.Name = "labelCardDescription";
            labelCardDescription.Size = new Size(65, 15);
            labelCardDescription.TabIndex = 3;
            labelCardDescription.Text = "Описание:";
            // 
            // textCardDescription
            // 
            textCardDescription.Location = new Point(102, 73);
            textCardDescription.Multiline = true;
            textCardDescription.Name = "textCardDescription";
            textCardDescription.Size = new Size(654, 103);
            textCardDescription.TabIndex = 2;
            // 
            // labelCardName
            // 
            labelCardName.AutoSize = true;
            labelCardName.Location = new Point(15, 37);
            labelCardName.Name = "labelCardName";
            labelCardName.Size = new Size(62, 15);
            labelCardName.TabIndex = 1;
            labelCardName.Text = "Название:";
            // 
            // textCardName
            // 
            textCardName.Location = new Point(102, 34);
            textCardName.Name = "textCardName";
            textCardName.Size = new Size(654, 23);
            textCardName.TabIndex = 0;
            // 
            // fileLoader
            // 
            fileLoader.Filter = "Image Files (*.png;*.gif)|*.png;*.gif|Video Files (*.mp4)|*.mp4|All Files (*.*)|*.*";
            // 
            // FrmClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 322);
            Controls.Add(boxAddCard);
            Name = "FrmClient";
            Text = "Клиент";
            boxAddCard.ResumeLayout(false);
            boxAddCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAddCard;
        private GroupBox boxAddCard;
        private Label labelCardDescription;
        private TextBox textCardDescription;
        private Label labelCardName;
        private TextBox textCardName;
        private Button buttonLoadFile;
        private Label labelCardFile;
        private Label labelFileName;
        private Label labelFileNamePrefix;
        private OpenFileDialog fileLoader;
    }
}