namespace Study_Buddy
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studySessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSavedSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_NewSession = new System.Windows.Forms.Button();
            this.btn_EditDB = new System.Windows.Forms.Button();
            this.btn_LoadSavedSession = new System.Windows.Forms.Button();
            this.btn_ContinueLastSession = new System.Windows.Forms.Button();
            this.btn_CreateNewDB = new System.Windows.Forms.Button();
            this.UseStudyBuddy = new System.Windows.Forms.GroupBox();
            this.ManageDB = new System.Windows.Forms.GroupBox();
            this.btn_DeleteDB = new System.Windows.Forms.Button();
            this.databaseManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editExistingDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_ExportDB = new System.Windows.Forms.Button();
            this.btn_ImportDB = new System.Windows.Forms.Button();
            this.continueLastSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.UseStudyBuddy.SuspendLayout();
            this.ManageDB.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studySessionToolStripMenuItem,
            this.databaseManagementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studySessionToolStripMenuItem
            // 
            this.studySessionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSessionToolStripMenuItem,
            this.continueLastSessionToolStripMenuItem,
            this.openSavedSessionToolStripMenuItem});
            this.studySessionToolStripMenuItem.Name = "studySessionToolStripMenuItem";
            this.studySessionToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.studySessionToolStripMenuItem.Text = "Study Buddy";
            // 
            // newSessionToolStripMenuItem
            // 
            this.newSessionToolStripMenuItem.Name = "newSessionToolStripMenuItem";
            this.newSessionToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.newSessionToolStripMenuItem.Text = "New Session";
            // 
            // openSavedSessionToolStripMenuItem
            // 
            this.openSavedSessionToolStripMenuItem.Name = "openSavedSessionToolStripMenuItem";
            this.openSavedSessionToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.openSavedSessionToolStripMenuItem.Text = "Open Saved Session";
            // 
            // btn_NewSession
            // 
            this.btn_NewSession.Location = new System.Drawing.Point(54, 27);
            this.btn_NewSession.Name = "btn_NewSession";
            this.btn_NewSession.Size = new System.Drawing.Size(126, 56);
            this.btn_NewSession.TabIndex = 1;
            this.btn_NewSession.Text = "Start New Session";
            this.btn_NewSession.UseVisualStyleBackColor = true;
            // 
            // btn_EditDB
            // 
            this.btn_EditDB.Location = new System.Drawing.Point(54, 89);
            this.btn_EditDB.Name = "btn_EditDB";
            this.btn_EditDB.Size = new System.Drawing.Size(126, 56);
            this.btn_EditDB.TabIndex = 2;
            this.btn_EditDB.Text = "Edit Existing Database";
            this.btn_EditDB.UseVisualStyleBackColor = true;
            // 
            // btn_LoadSavedSession
            // 
            this.btn_LoadSavedSession.Location = new System.Drawing.Point(54, 151);
            this.btn_LoadSavedSession.Name = "btn_LoadSavedSession";
            this.btn_LoadSavedSession.Size = new System.Drawing.Size(126, 56);
            this.btn_LoadSavedSession.TabIndex = 2;
            this.btn_LoadSavedSession.Text = "Continue Saved Session";
            this.btn_LoadSavedSession.UseVisualStyleBackColor = true;
            // 
            // btn_ContinueLastSession
            // 
            this.btn_ContinueLastSession.Location = new System.Drawing.Point(54, 89);
            this.btn_ContinueLastSession.Name = "btn_ContinueLastSession";
            this.btn_ContinueLastSession.Size = new System.Drawing.Size(126, 56);
            this.btn_ContinueLastSession.TabIndex = 2;
            this.btn_ContinueLastSession.Text = "Continue Last Session";
            this.btn_ContinueLastSession.UseVisualStyleBackColor = true;
            // 
            // btn_CreateNewDB
            // 
            this.btn_CreateNewDB.Location = new System.Drawing.Point(54, 27);
            this.btn_CreateNewDB.Name = "btn_CreateNewDB";
            this.btn_CreateNewDB.Size = new System.Drawing.Size(126, 56);
            this.btn_CreateNewDB.TabIndex = 3;
            this.btn_CreateNewDB.Text = "Create New Database";
            this.btn_CreateNewDB.UseVisualStyleBackColor = true;
            // 
            // UseStudyBuddy
            // 
            this.UseStudyBuddy.Controls.Add(this.btn_ContinueLastSession);
            this.UseStudyBuddy.Controls.Add(this.btn_LoadSavedSession);
            this.UseStudyBuddy.Controls.Add(this.btn_NewSession);
            this.UseStudyBuddy.Location = new System.Drawing.Point(40, 61);
            this.UseStudyBuddy.Name = "UseStudyBuddy";
            this.UseStudyBuddy.Size = new System.Drawing.Size(250, 234);
            this.UseStudyBuddy.TabIndex = 4;
            this.UseStudyBuddy.TabStop = false;
            this.UseStudyBuddy.Text = "Start Session";
            // 
            // ManageDB
            // 
            this.ManageDB.Controls.Add(this.btn_ImportDB);
            this.ManageDB.Controls.Add(this.btn_ExportDB);
            this.ManageDB.Controls.Add(this.btn_DeleteDB);
            this.ManageDB.Controls.Add(this.btn_CreateNewDB);
            this.ManageDB.Controls.Add(this.btn_EditDB);
            this.ManageDB.Location = new System.Drawing.Point(366, 61);
            this.ManageDB.Name = "ManageDB";
            this.ManageDB.Size = new System.Drawing.Size(250, 358);
            this.ManageDB.TabIndex = 5;
            this.ManageDB.TabStop = false;
            this.ManageDB.Text = "Manage Databases";
            // 
            // btn_DeleteDB
            // 
            this.btn_DeleteDB.Location = new System.Drawing.Point(54, 151);
            this.btn_DeleteDB.Name = "btn_DeleteDB";
            this.btn_DeleteDB.Size = new System.Drawing.Size(126, 56);
            this.btn_DeleteDB.TabIndex = 4;
            this.btn_DeleteDB.Text = "Delete Database";
            this.btn_DeleteDB.UseVisualStyleBackColor = true;
            // 
            // databaseManagementToolStripMenuItem
            // 
            this.databaseManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewDatabaseToolStripMenuItem,
            this.editExistingDatabaseToolStripMenuItem,
            this.deleteDatabaseToolStripMenuItem,
            this.exportDatabaseToolStripMenuItem});
            this.databaseManagementToolStripMenuItem.Name = "databaseManagementToolStripMenuItem";
            this.databaseManagementToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.databaseManagementToolStripMenuItem.Text = "Database Management";
            // 
            // createNewDatabaseToolStripMenuItem
            // 
            this.createNewDatabaseToolStripMenuItem.Name = "createNewDatabaseToolStripMenuItem";
            this.createNewDatabaseToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.createNewDatabaseToolStripMenuItem.Text = "Create New Database";
            // 
            // editExistingDatabaseToolStripMenuItem
            // 
            this.editExistingDatabaseToolStripMenuItem.Name = "editExistingDatabaseToolStripMenuItem";
            this.editExistingDatabaseToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.editExistingDatabaseToolStripMenuItem.Text = "Edit Existing Database";
            // 
            // deleteDatabaseToolStripMenuItem
            // 
            this.deleteDatabaseToolStripMenuItem.Name = "deleteDatabaseToolStripMenuItem";
            this.deleteDatabaseToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.deleteDatabaseToolStripMenuItem.Text = "Delete Database";
            // 
            // exportDatabaseToolStripMenuItem
            // 
            this.exportDatabaseToolStripMenuItem.Name = "exportDatabaseToolStripMenuItem";
            this.exportDatabaseToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.exportDatabaseToolStripMenuItem.Text = "Export Database";
            // 
            // btn_ExportDB
            // 
            this.btn_ExportDB.Location = new System.Drawing.Point(54, 213);
            this.btn_ExportDB.Name = "btn_ExportDB";
            this.btn_ExportDB.Size = new System.Drawing.Size(126, 56);
            this.btn_ExportDB.TabIndex = 5;
            this.btn_ExportDB.Text = "Export Database";
            this.btn_ExportDB.UseVisualStyleBackColor = true;
            // 
            // btn_ImportDB
            // 
            this.btn_ImportDB.Location = new System.Drawing.Point(54, 275);
            this.btn_ImportDB.Name = "btn_ImportDB";
            this.btn_ImportDB.Size = new System.Drawing.Size(126, 56);
            this.btn_ImportDB.TabIndex = 6;
            this.btn_ImportDB.Text = "Import Database";
            this.btn_ImportDB.UseVisualStyleBackColor = true;
            // 
            // continueLastSessionToolStripMenuItem
            // 
            this.continueLastSessionToolStripMenuItem.Name = "continueLastSessionToolStripMenuItem";
            this.continueLastSessionToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.continueLastSessionToolStripMenuItem.Text = "Continue Last Session";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 513);
            this.Controls.Add(this.ManageDB);
            this.Controls.Add(this.UseStudyBuddy);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.UseStudyBuddy.ResumeLayout(false);
            this.ManageDB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studySessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSavedSessionToolStripMenuItem;
        private System.Windows.Forms.Button btn_NewSession;
        private System.Windows.Forms.Button btn_EditDB;
        private System.Windows.Forms.Button btn_LoadSavedSession;
        private System.Windows.Forms.Button btn_ContinueLastSession;
        private System.Windows.Forms.Button btn_CreateNewDB;
        private System.Windows.Forms.GroupBox UseStudyBuddy;
        private System.Windows.Forms.GroupBox ManageDB;
        private System.Windows.Forms.Button btn_DeleteDB;
        private System.Windows.Forms.ToolStripMenuItem databaseManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editExistingDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportDatabaseToolStripMenuItem;
        private System.Windows.Forms.Button btn_ImportDB;
        private System.Windows.Forms.Button btn_ExportDB;
        private System.Windows.Forms.ToolStripMenuItem continueLastSessionToolStripMenuItem;
    }
}

