using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSApps
{
    internal class AppInfoForm : Form
    {
        public AppInfoForm()
        {
            InitializeComponent();
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        public void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.pictureBoxAppIcon = new System.Windows.Forms.PictureBox();
            this.labelAppNameTitle = new System.Windows.Forms.Label();
            this.labelAppNameValue = new System.Windows.Forms.Label();
            this.labelAppDisplayNameValue = new System.Windows.Forms.Label();
            this.labelAppDisplayNameTitle = new System.Windows.Forms.Label();
            this.labelAppAuthorValue = new System.Windows.Forms.Label();
            this.labelAppAuthorTitle = new System.Windows.Forms.Label();
            this.labelAppDescriptionValue = new System.Windows.Forms.Label();
            this.labelAppDescriptionTitle = new System.Windows.Forms.Label();
            this.labelAppMainTypeValue = new System.Windows.Forms.Label();
            this.labelAppMainTypeTitle = new System.Windows.Forms.Label();
            this.labelExeFileValue = new System.Windows.Forms.Label();
            this.labelExeFileTitle = new System.Windows.Forms.Label();
            this.labelAppManifestValue = new System.Windows.Forms.Label();
            this.labelAppManifestTitle = new System.Windows.Forms.Label();
            this.labelAppTypeValue = new System.Windows.Forms.Label();
            this.labelAppTypeTitle = new System.Windows.Forms.Label();
            this.labelAppIconPathValue = new System.Windows.Forms.Label();
            this.labelAppIconPathTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAppIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 20F, System.Drawing.FontStyle.Bold);
            this.Title.Location = new System.Drawing.Point(32, 32);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(221, 36);
            this.Title.TabIndex = 0;
            this.Title.Text = "AppName\'s infos";
            // 
            // pictureBoxAppIcon
            // 
            this.pictureBoxAppIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxAppIcon.Location = new System.Drawing.Point(684, 32);
            this.pictureBoxAppIcon.Name = "pictureBoxAppIcon";
            this.pictureBoxAppIcon.Size = new System.Drawing.Size(96, 96);
            this.pictureBoxAppIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBoxAppIcon.TabIndex = 1;
            this.pictureBoxAppIcon.TabStop = false;
            // 
            // labelAppNameTitle
            // 
            this.labelAppNameTitle.AutoSize = true;
            this.labelAppNameTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F);
            this.labelAppNameTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.labelAppNameTitle.Location = new System.Drawing.Point(34, 83);
            this.labelAppNameTitle.Name = "labelAppNameTitle";
            this.labelAppNameTitle.Size = new System.Drawing.Size(115, 19);
            this.labelAppNameTitle.TabIndex = 2;
            this.labelAppNameTitle.Text = "Application name";
            // 
            // labelAppNameValue
            // 
            this.labelAppNameValue.AutoSize = true;
            this.labelAppNameValue.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F);
            this.labelAppNameValue.ForeColor = System.Drawing.Color.Gray;
            this.labelAppNameValue.Location = new System.Drawing.Point(238, 83);
            this.labelAppNameValue.Name = "labelAppNameValue";
            this.labelAppNameValue.Size = new System.Drawing.Size(34, 19);
            this.labelAppNameValue.TabIndex = 3;
            this.labelAppNameValue.Text = "App";
            // 
            // labelAppDisplayNameValue
            // 
            this.labelAppDisplayNameValue.AutoSize = true;
            this.labelAppDisplayNameValue.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F);
            this.labelAppDisplayNameValue.ForeColor = System.Drawing.Color.Gray;
            this.labelAppDisplayNameValue.Location = new System.Drawing.Point(238, 109);
            this.labelAppDisplayNameValue.Name = "labelAppDisplayNameValue";
            this.labelAppDisplayNameValue.Size = new System.Drawing.Size(78, 19);
            this.labelAppDisplayNameValue.TabIndex = 5;
            this.labelAppDisplayNameValue.Text = "Application";
            // 
            // labelAppDisplayNameTitle
            // 
            this.labelAppDisplayNameTitle.AutoSize = true;
            this.labelAppDisplayNameTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F);
            this.labelAppDisplayNameTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.labelAppDisplayNameTitle.Location = new System.Drawing.Point(34, 109);
            this.labelAppDisplayNameTitle.Name = "labelAppDisplayNameTitle";
            this.labelAppDisplayNameTitle.Size = new System.Drawing.Size(160, 19);
            this.labelAppDisplayNameTitle.TabIndex = 4;
            this.labelAppDisplayNameTitle.Text = "Application display name";
            // 
            // labelAppAuthorValue
            // 
            this.labelAppAuthorValue.AutoSize = true;
            this.labelAppAuthorValue.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F);
            this.labelAppAuthorValue.ForeColor = System.Drawing.Color.Gray;
            this.labelAppAuthorValue.Location = new System.Drawing.Point(238, 162);
            this.labelAppAuthorValue.Name = "labelAppAuthorValue";
            this.labelAppAuthorValue.Size = new System.Drawing.Size(152, 19);
            this.labelAppAuthorValue.TabIndex = 9;
            this.labelAppAuthorValue.Text = "RaphMar2022 (Trusted)";
            this.labelAppAuthorValue.HelpRequested += LabelAppAuthorValue_HelpRequested;
            // 
            // labelAppAuthorTitle
            // 
            this.labelAppAuthorTitle.AutoSize = true;
            this.labelAppAuthorTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F);
            this.labelAppAuthorTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.labelAppAuthorTitle.Location = new System.Drawing.Point(34, 162);
            this.labelAppAuthorTitle.Name = "labelAppAuthorTitle";
            this.labelAppAuthorTitle.Size = new System.Drawing.Size(122, 19);
            this.labelAppAuthorTitle.TabIndex = 8;
            this.labelAppAuthorTitle.Text = "Application author";
            // 
            // labelAppDescriptionValue
            // 
            this.labelAppDescriptionValue.AutoSize = true;
            this.labelAppDescriptionValue.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F);
            this.labelAppDescriptionValue.ForeColor = System.Drawing.Color.Gray;
            this.labelAppDescriptionValue.Location = new System.Drawing.Point(238, 136);
            this.labelAppDescriptionValue.Name = "labelAppDescriptionValue";
            this.labelAppDescriptionValue.Size = new System.Drawing.Size(189, 19);
            this.labelAppDescriptionValue.TabIndex = 7;
            this.labelAppDescriptionValue.Text = "An app. Lorem ipsum dolor elt";
            // 
            // labelAppDescriptionTitle
            // 
            this.labelAppDescriptionTitle.AutoSize = true;
            this.labelAppDescriptionTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F);
            this.labelAppDescriptionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.labelAppDescriptionTitle.Location = new System.Drawing.Point(34, 136);
            this.labelAppDescriptionTitle.Name = "labelAppDescriptionTitle";
            this.labelAppDescriptionTitle.Size = new System.Drawing.Size(149, 19);
            this.labelAppDescriptionTitle.TabIndex = 6;
            this.labelAppDescriptionTitle.Text = "Application description";
            // 
            // labelAppMainTypeValue
            // 
            this.labelAppMainTypeValue.AutoSize = true;
            this.labelAppMainTypeValue.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F);
            this.labelAppMainTypeValue.ForeColor = System.Drawing.Color.Gray;
            this.labelAppMainTypeValue.Location = new System.Drawing.Point(238, 268);
            this.labelAppMainTypeValue.Name = "labelAppMainTypeValue";
            this.labelAppMainTypeValue.Size = new System.Drawing.Size(90, 19);
            this.labelAppMainTypeValue.TabIndex = 17;
            this.labelAppMainTypeValue.Text = "App.Program";
            // 
            // labelAppMainTypeTitle
            // 
            this.labelAppMainTypeTitle.AutoSize = true;
            this.labelAppMainTypeTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F);
            this.labelAppMainTypeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.labelAppMainTypeTitle.Location = new System.Drawing.Point(34, 268);
            this.labelAppMainTypeTitle.Name = "labelAppMainTypeTitle";
            this.labelAppMainTypeTitle.Size = new System.Drawing.Size(141, 19);
            this.labelAppMainTypeTitle.TabIndex = 16;
            this.labelAppMainTypeTitle.Text = "Application main type";
            // 
            // labelExeFileValue
            // 
            this.labelExeFileValue.AutoSize = true;
            this.labelExeFileValue.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F);
            this.labelExeFileValue.ForeColor = System.Drawing.Color.Gray;
            this.labelExeFileValue.Location = new System.Drawing.Point(238, 242);
            this.labelExeFileValue.Name = "labelExeFileValue";
            this.labelExeFileValue.Size = new System.Drawing.Size(189, 19);
            this.labelExeFileValue.TabIndex = 15;
            this.labelExeFileValue.Text = "An app. Lorem ipsum dolor elt";
            // 
            // labelExeFileTitle
            // 
            this.labelExeFileTitle.AutoSize = true;
            this.labelExeFileTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F);
            this.labelExeFileTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.labelExeFileTitle.Location = new System.Drawing.Point(34, 242);
            this.labelExeFileTitle.Name = "labelExeFileTitle";
            this.labelExeFileTitle.Size = new System.Drawing.Size(94, 19);
            this.labelExeFileTitle.TabIndex = 14;
            this.labelExeFileTitle.Text = "Executable file";
            // 
            // labelAppManifestValue
            // 
            this.labelAppManifestValue.AutoSize = true;
            this.labelAppManifestValue.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F);
            this.labelAppManifestValue.ForeColor = System.Drawing.Color.Gray;
            this.labelAppManifestValue.Location = new System.Drawing.Point(238, 215);
            this.labelAppManifestValue.Name = "labelAppManifestValue";
            this.labelAppManifestValue.Size = new System.Drawing.Size(78, 19);
            this.labelAppManifestValue.TabIndex = 13;
            this.labelAppManifestValue.Text = "Application";
            // 
            // labelAppManifestTitle
            // 
            this.labelAppManifestTitle.AutoSize = true;
            this.labelAppManifestTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F);
            this.labelAppManifestTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.labelAppManifestTitle.Location = new System.Drawing.Point(34, 215);
            this.labelAppManifestTitle.Name = "labelAppManifestTitle";
            this.labelAppManifestTitle.Size = new System.Drawing.Size(164, 19);
            this.labelAppManifestTitle.TabIndex = 12;
            this.labelAppManifestTitle.Text = "Application manifest path";
            // 
            // labelAppTypeValue
            // 
            this.labelAppTypeValue.AutoSize = true;
            this.labelAppTypeValue.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F);
            this.labelAppTypeValue.ForeColor = System.Drawing.Color.Gray;
            this.labelAppTypeValue.Location = new System.Drawing.Point(238, 189);
            this.labelAppTypeValue.Name = "labelAppTypeValue";
            this.labelAppTypeValue.Size = new System.Drawing.Size(97, 19);
            this.labelAppTypeValue.TabIndex = 11;
            this.labelAppTypeValue.Text = ".NET Assembly";
            // 
            // labelAppTypeTitle
            // 
            this.labelAppTypeTitle.AutoSize = true;
            this.labelAppTypeTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F);
            this.labelAppTypeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.labelAppTypeTitle.Location = new System.Drawing.Point(34, 189);
            this.labelAppTypeTitle.Name = "labelAppTypeTitle";
            this.labelAppTypeTitle.Size = new System.Drawing.Size(108, 19);
            this.labelAppTypeTitle.TabIndex = 10;
            this.labelAppTypeTitle.Text = "Application type";
            // 
            // labelAppIconPathValue
            // 
            this.labelAppIconPathValue.AutoSize = true;
            this.labelAppIconPathValue.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F);
            this.labelAppIconPathValue.ForeColor = System.Drawing.Color.Gray;
            this.labelAppIconPathValue.Location = new System.Drawing.Point(238, 295);
            this.labelAppIconPathValue.Name = "labelAppIconPathValue";
            this.labelAppIconPathValue.Size = new System.Drawing.Size(108, 19);
            this.labelAppIconPathValue.TabIndex = 19;
            this.labelAppIconPathValue.Text = "C:\\Icon\\icon.ico";
            // 
            // labelAppIconPathTitle
            // 
            this.labelAppIconPathTitle.AutoSize = true;
            this.labelAppIconPathTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F);
            this.labelAppIconPathTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.labelAppIconPathTitle.Location = new System.Drawing.Point(34, 295);
            this.labelAppIconPathTitle.Name = "labelAppIconPathTitle";
            this.labelAppIconPathTitle.Size = new System.Drawing.Size(138, 19);
            this.labelAppIconPathTitle.TabIndex = 18;
            this.labelAppIconPathTitle.Text = "Application icon path";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(812, 507);
            this.Controls.Add(this.labelAppIconPathValue);
            this.Controls.Add(this.labelAppIconPathTitle);
            this.Controls.Add(this.labelAppMainTypeValue);
            this.Controls.Add(this.labelAppMainTypeTitle);
            this.Controls.Add(this.labelExeFileValue);
            this.Controls.Add(this.labelExeFileTitle);
            this.Controls.Add(this.labelAppManifestValue);
            this.Controls.Add(this.labelAppManifestTitle);
            this.Controls.Add(this.labelAppTypeValue);
            this.Controls.Add(this.labelAppTypeTitle);
            this.Controls.Add(this.labelAppAuthorValue);
            this.Controls.Add(this.labelAppAuthorTitle);
            this.Controls.Add(this.labelAppDescriptionValue);
            this.Controls.Add(this.labelAppDescriptionTitle);
            this.Controls.Add(this.labelAppDisplayNameValue);
            this.Controls.Add(this.labelAppDisplayNameTitle);
            this.Controls.Add(this.labelAppNameValue);
            this.Controls.Add(this.labelAppNameTitle);
            this.Controls.Add(this.pictureBoxAppIcon);
            this.Controls.Add(this.Title);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.HelpButton = true;
            this.Name = "Form1";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAppIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void LabelAppAuthorValue_HelpRequested(object? sender, HelpEventArgs hlpevent)
        {
            if (((Label)sender).Text.EndsWith("(Trusted)"))
            {
                MessageBox.Show(this, "It means than the author don't add viruses in his applications. So don't need to show a security warning for his applications.", "What 'Trusted' means?");
            }
        }

        #endregion

        public System.Windows.Forms.Label Title;
        public System.Windows.Forms.PictureBox pictureBoxAppIcon;
        public System.Windows.Forms.Label labelAppNameTitle;
        public System.Windows.Forms.Label labelAppNameValue;
        public System.Windows.Forms.Label labelAppDisplayNameValue;
        public System.Windows.Forms.Label labelAppDisplayNameTitle;
        public System.Windows.Forms.Label labelAppAuthorValue;
        public System.Windows.Forms.Label labelAppAuthorTitle;
        public System.Windows.Forms.Label labelAppDescriptionValue;
        public System.Windows.Forms.Label labelAppDescriptionTitle;
        public System.Windows.Forms.Label labelAppMainTypeValue;
        public System.Windows.Forms.Label labelAppMainTypeTitle;
        public System.Windows.Forms.Label labelExeFileValue;
        public System.Windows.Forms.Label labelExeFileTitle;
        public System.Windows.Forms.Label labelAppManifestValue;
        public System.Windows.Forms.Label labelAppManifestTitle;
        public System.Windows.Forms.Label labelAppTypeValue;
        public System.Windows.Forms.Label labelAppTypeTitle;
        public System.Windows.Forms.Label labelAppIconPathValue;
        public System.Windows.Forms.Label labelAppIconPathTitle;
    }
}
