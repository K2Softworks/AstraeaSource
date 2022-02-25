
namespace Astraea
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LaucherHeader = new System.Windows.Forms.Label();
            this.EmailValidator = new Siticone.Desktop.UI.Winforms.SiticoneEmailValidatingTool();
            this.PasswordValidator = new Siticone.Desktop.UI.Winforms.SiticonePasswordValidationTool();
            this.Close = new Siticone.Desktop.UI.WinForms.SiticoneTileButton();
            this.Minimize = new Siticone.Desktop.UI.WinForms.SiticoneTileButton();
            this.LoginUIDragControl = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.UsernamePicture = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.UsernameBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.PasswordBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.passwordPicture = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.AccountSetupDirector = new System.Windows.Forms.Label();
            this.SignIn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            ((System.ComponentModel.ISupportInitialize)(this.UsernamePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // LaucherHeader
            // 
            this.LaucherHeader.AutoSize = true;
            this.LaucherHeader.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaucherHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.LaucherHeader.Location = new System.Drawing.Point(100, 0);
            this.LaucherHeader.Name = "LaucherHeader";
            this.LaucherHeader.Size = new System.Drawing.Size(103, 29);
            this.LaucherHeader.TabIndex = 3;
            this.LaucherHeader.Text = "Astraea";
            this.LaucherHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmailValidator
            // 
            this.EmailValidator.EmailError = System.Drawing.Color.Red;
            this.EmailValidator.EmailNoError = System.Drawing.Color.White;
            // 
            // PasswordValidator
            // 
            this.PasswordValidator.AllowWhitespace = false;
            this.PasswordValidator.PasswordErrorColor = System.Drawing.Color.Red;
            this.PasswordValidator.PasswordMaximumLength = ((long)(22));
            this.PasswordValidator.PasswordStrength = Siticone.Desktop.UI.Winforms.Strength.Strongest;
            this.PasswordValidator.PasswordValidColor = System.Drawing.Color.LimeGreen;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.BorderRadius = 5;
            this.Close.CheckedState.Parent = this.Close;
            this.Close.CustomImages.Parent = this.Close;
            this.Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Close.DisabledState.Parent = this.Close;
            this.Close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Close.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.HoverState.Parent = this.Close;
            this.Close.Location = new System.Drawing.Point(255, 2);
            this.Close.Name = "Close";
            this.Close.ShadowDecoration.Parent = this.Close;
            this.Close.Size = new System.Drawing.Size(29, 27);
            this.Close.TabIndex = 6;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.BorderRadius = 5;
            this.Minimize.CheckedState.Parent = this.Minimize;
            this.Minimize.CustomImages.Parent = this.Minimize;
            this.Minimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Minimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Minimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Minimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Minimize.DisabledState.Parent = this.Minimize;
            this.Minimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Minimize.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.HoverState.Parent = this.Minimize;
            this.Minimize.Location = new System.Drawing.Point(223, 2);
            this.Minimize.Name = "Minimize";
            this.Minimize.ShadowDecoration.Parent = this.Minimize;
            this.Minimize.Size = new System.Drawing.Size(29, 27);
            this.Minimize.TabIndex = 7;
            this.Minimize.Text = "_";
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // LoginUIDragControl
            // 
            this.LoginUIDragControl.TargetControl = this;
            // 
            // UsernamePicture
            // 
            this.UsernamePicture.Image = ((System.Drawing.Image)(resources.GetObject("UsernamePicture.Image")));
            this.UsernamePicture.ImageRotate = 0F;
            this.UsernamePicture.Location = new System.Drawing.Point(17, 71);
            this.UsernamePicture.Name = "UsernamePicture";
            this.UsernamePicture.ShadowDecoration.Parent = this.UsernamePicture;
            this.UsernamePicture.Size = new System.Drawing.Size(33, 31);
            this.UsernamePicture.TabIndex = 8;
            this.UsernamePicture.TabStop = false;
            // 
            // UsernameBox
            // 
            this.UsernameBox.BorderColor = System.Drawing.Color.Transparent;
            this.UsernameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameBox.DefaultText = "";
            this.UsernameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsernameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsernameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameBox.DisabledState.Parent = this.UsernameBox;
            this.UsernameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.UsernameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameBox.FocusedState.Parent = this.UsernameBox;
            this.UsernameBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UsernameBox.ForeColor = System.Drawing.Color.White;
            this.UsernameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameBox.HoverState.Parent = this.UsernameBox;
            this.UsernameBox.Location = new System.Drawing.Point(56, 74);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.PasswordChar = '\0';
            this.UsernameBox.PlaceholderText = "";
            this.UsernameBox.SelectedText = "";
            this.UsernameBox.ShadowDecoration.Parent = this.UsernameBox;
            this.UsernameBox.Size = new System.Drawing.Size(201, 28);
            this.UsernameBox.TabIndex = 9;
            // 
            // PasswordBox
            // 
            this.PasswordBox.BorderColor = System.Drawing.Color.Transparent;
            this.PasswordBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordBox.DefaultText = "";
            this.PasswordBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordBox.DisabledState.Parent = this.PasswordBox;
            this.PasswordBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.PasswordBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordBox.FocusedState.Parent = this.PasswordBox;
            this.PasswordBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PasswordBox.ForeColor = System.Drawing.Color.White;
            this.PasswordBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordBox.HoverState.Parent = this.PasswordBox;
            this.PasswordBox.Location = new System.Drawing.Point(56, 138);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '\0';
            this.PasswordBox.PlaceholderText = "";
            this.PasswordBox.SelectedText = "";
            this.PasswordBox.ShadowDecoration.Parent = this.PasswordBox;
            this.PasswordBox.Size = new System.Drawing.Size(201, 28);
            this.PasswordBox.TabIndex = 11;
            // 
            // passwordPicture
            // 
            this.passwordPicture.Image = ((System.Drawing.Image)(resources.GetObject("passwordPicture.Image")));
            this.passwordPicture.ImageRotate = 0F;
            this.passwordPicture.Location = new System.Drawing.Point(17, 135);
            this.passwordPicture.Name = "passwordPicture";
            this.passwordPicture.ShadowDecoration.Parent = this.passwordPicture;
            this.passwordPicture.Size = new System.Drawing.Size(33, 31);
            this.passwordPicture.TabIndex = 10;
            this.passwordPicture.TabStop = false;
            // 
            // AccountSetupDirector
            // 
            this.AccountSetupDirector.AutoSize = true;
            this.AccountSetupDirector.Font = new System.Drawing.Font("Arial", 10F);
            this.AccountSetupDirector.ForeColor = System.Drawing.Color.LightGreen;
            this.AccountSetupDirector.Location = new System.Drawing.Point(76, 227);
            this.AccountSetupDirector.Name = "AccountSetupDirector";
            this.AccountSetupDirector.Size = new System.Drawing.Size(151, 32);
            this.AccountSetupDirector.TabIndex = 12;
            this.AccountSetupDirector.Text = "Don\'t Have a Account?\r\n        Create One!";
            // 
            // SignIn
            // 
            this.SignIn.BorderRadius = 1;
            this.SignIn.BorderThickness = 1;
            this.SignIn.CheckedState.Parent = this.SignIn;
            this.SignIn.CustomImages.Parent = this.SignIn;
            this.SignIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SignIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SignIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SignIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SignIn.DisabledState.Parent = this.SignIn;
            this.SignIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.SignIn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn.ForeColor = System.Drawing.Color.White;
            this.SignIn.HoverState.Parent = this.SignIn;
            this.SignIn.Location = new System.Drawing.Point(72, 183);
            this.SignIn.Name = "SignIn";
            this.SignIn.ShadowDecoration.Parent = this.SignIn;
            this.SignIn.Size = new System.Drawing.Size(158, 30);
            this.SignIn.TabIndex = 14;
            this.SignIn.Text = "Sign In";
            this.SignIn.TextOffset = new System.Drawing.Point(1, -1);
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(286, 273);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.AccountSetupDirector);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.passwordPicture);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.UsernamePicture);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.LaucherHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Welcome To Astraea                    Create One";
            ((System.ComponentModel.ISupportInitialize)(this.UsernamePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LaucherHeader;
        private Siticone.Desktop.UI.Winforms.SiticoneEmailValidatingTool EmailValidator;
        private Siticone.Desktop.UI.Winforms.SiticonePasswordValidationTool PasswordValidator;
        private Siticone.Desktop.UI.WinForms.SiticoneTileButton Close;
        private Siticone.Desktop.UI.WinForms.SiticoneTileButton Minimize;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl LoginUIDragControl;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox PasswordBox;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox passwordPicture;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox UsernameBox;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox UsernamePicture;
        private System.Windows.Forms.Label AccountSetupDirector;
        private Siticone.Desktop.UI.WinForms.SiticoneButton SignIn;
    }
}