namespace ShoeCollectionCS
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
            this.mainMenuBox = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.createCollectionButton = new System.Windows.Forms.Button();
            this.importCollectionButton = new System.Windows.Forms.Button();
            this.addShoePanel = new System.Windows.Forms.Panel();
            this.addedShoeLabel = new System.Windows.Forms.Label();
            this.finishAddShoeButton = new System.Windows.Forms.Button();
            this.addingShoesLabel = new System.Windows.Forms.Label();
            this.addShoeButton = new System.Windows.Forms.Button();
            this.addColorTextbox = new System.Windows.Forms.TextBox();
            this.addBrandTextbox = new System.Windows.Forms.TextBox();
            this.addModelTextbox = new System.Windows.Forms.TextBox();
            this.addColorLabel = new System.Windows.Forms.Label();
            this.addModelLabel = new System.Windows.Forms.Label();
            this.addBrandLabel = new System.Windows.Forms.Label();
            this.editMenuPanel = new System.Windows.Forms.Panel();
            this.currentListView = new System.Windows.Forms.ListView();
            this.numColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.brandColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modelColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colorColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.optionsLabel = new System.Windows.Forms.Label();
            this.currentCollectionLabel = new System.Windows.Forms.Label();
            this.addToCurrentButton = new System.Windows.Forms.Button();
            this.exitEditMenuButton = new System.Windows.Forms.Button();
            this.toMainMenu = new System.Windows.Forms.Button();
            this.removeFromCurrentButton = new System.Windows.Forms.Button();
            this.removeShoePanel = new System.Windows.Forms.Panel();
            this.removedLabel = new System.Windows.Forms.Label();
            this.removedShoeLabel = new System.Windows.Forms.Label();
            this.shoeToRemoveTextBox = new System.Windows.Forms.TextBox();
            this.currentListViewLabel = new System.Windows.Forms.Label();
            this.removeShoeInstructions = new System.Windows.Forms.Label();
            this.finishRemoveShoeButton = new System.Windows.Forms.Button();
            this.removeShoeButton = new System.Windows.Forms.Button();
            this.mainMenuBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.addShoePanel.SuspendLayout();
            this.editMenuPanel.SuspendLayout();
            this.removeShoePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuBox
            // 
            this.mainMenuBox.Controls.Add(this.splitContainer1);
            this.mainMenuBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuBox.Location = new System.Drawing.Point(303, 172);
            this.mainMenuBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainMenuBox.Name = "mainMenuBox";
            this.mainMenuBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainMenuBox.Size = new System.Drawing.Size(563, 324);
            this.mainMenuBox.TabIndex = 0;
            this.mainMenuBox.TabStop = false;
            this.mainMenuBox.Text = "Main Menu";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(4, 31);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.createCollectionButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.importCollectionButton);
            this.splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Size = new System.Drawing.Size(550, 262);
            this.splitContainer1.SplitterDistance = 268;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // createCollectionButton
            // 
            this.createCollectionButton.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCollectionButton.Location = new System.Drawing.Point(0, -4);
            this.createCollectionButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.createCollectionButton.Name = "createCollectionButton";
            this.createCollectionButton.Size = new System.Drawing.Size(264, 287);
            this.createCollectionButton.TabIndex = 0;
            this.createCollectionButton.Text = "Create a new collection";
            this.createCollectionButton.UseVisualStyleBackColor = true;
            this.createCollectionButton.Click += new System.EventHandler(this.createCollectionButton_Click);
            // 
            // importCollectionButton
            // 
            this.importCollectionButton.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importCollectionButton.Location = new System.Drawing.Point(1, 0);
            this.importCollectionButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.importCollectionButton.Name = "importCollectionButton";
            this.importCollectionButton.Size = new System.Drawing.Size(269, 286);
            this.importCollectionButton.TabIndex = 1;
            this.importCollectionButton.Text = "Import a saved collection";
            this.importCollectionButton.UseVisualStyleBackColor = true;
            // 
            // addShoePanel
            // 
            this.addShoePanel.Controls.Add(this.addedShoeLabel);
            this.addShoePanel.Controls.Add(this.finishAddShoeButton);
            this.addShoePanel.Controls.Add(this.addingShoesLabel);
            this.addShoePanel.Controls.Add(this.addShoeButton);
            this.addShoePanel.Controls.Add(this.addColorTextbox);
            this.addShoePanel.Controls.Add(this.addBrandTextbox);
            this.addShoePanel.Controls.Add(this.addModelTextbox);
            this.addShoePanel.Controls.Add(this.addColorLabel);
            this.addShoePanel.Controls.Add(this.addModelLabel);
            this.addShoePanel.Controls.Add(this.addBrandLabel);
            this.addShoePanel.Location = new System.Drawing.Point(200, 68);
            this.addShoePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addShoePanel.Name = "addShoePanel";
            this.addShoePanel.Size = new System.Drawing.Size(813, 589);
            this.addShoePanel.TabIndex = 1;
            this.addShoePanel.Visible = false;
            // 
            // addedShoeLabel
            // 
            this.addedShoeLabel.AutoSize = true;
            this.addedShoeLabel.Location = new System.Drawing.Point(320, 377);
            this.addedShoeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addedShoeLabel.Name = "addedShoeLabel";
            this.addedShoeLabel.Size = new System.Drawing.Size(0, 20);
            this.addedShoeLabel.TabIndex = 8;
            // 
            // finishAddShoeButton
            // 
            this.finishAddShoeButton.Location = new System.Drawing.Point(446, 454);
            this.finishAddShoeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.finishAddShoeButton.Name = "finishAddShoeButton";
            this.finishAddShoeButton.Size = new System.Drawing.Size(171, 52);
            this.finishAddShoeButton.TabIndex = 4;
            this.finishAddShoeButton.Text = "Finish";
            this.finishAddShoeButton.UseVisualStyleBackColor = true;
            this.finishAddShoeButton.Click += new System.EventHandler(this.finishAddShoeButton_Click);
            // 
            // addingShoesLabel
            // 
            this.addingShoesLabel.AutoSize = true;
            this.addingShoesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addingShoesLabel.Location = new System.Drawing.Point(288, 97);
            this.addingShoesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addingShoesLabel.Name = "addingShoesLabel";
            this.addingShoesLabel.Size = new System.Drawing.Size(188, 29);
            this.addingShoesLabel.TabIndex = 7;
            this.addingShoesLabel.Text = "Adding Shoes ...";
            // 
            // addShoeButton
            // 
            this.addShoeButton.Location = new System.Drawing.Point(165, 454);
            this.addShoeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addShoeButton.Name = "addShoeButton";
            this.addShoeButton.Size = new System.Drawing.Size(170, 52);
            this.addShoeButton.TabIndex = 3;
            this.addShoeButton.Text = "Add Shoe";
            this.addShoeButton.UseVisualStyleBackColor = true;
            this.addShoeButton.Click += new System.EventHandler(this.addShoeButton_Click);
            // 
            // addColorTextbox
            // 
            this.addColorTextbox.Location = new System.Drawing.Point(393, 312);
            this.addColorTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addColorTextbox.Name = "addColorTextbox";
            this.addColorTextbox.Size = new System.Drawing.Size(222, 26);
            this.addColorTextbox.TabIndex = 2;
            // 
            // addBrandTextbox
            // 
            this.addBrandTextbox.Location = new System.Drawing.Point(393, 168);
            this.addBrandTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addBrandTextbox.Name = "addBrandTextbox";
            this.addBrandTextbox.Size = new System.Drawing.Size(222, 26);
            this.addBrandTextbox.TabIndex = 0;
            // 
            // addModelTextbox
            // 
            this.addModelTextbox.Location = new System.Drawing.Point(393, 237);
            this.addModelTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addModelTextbox.Name = "addModelTextbox";
            this.addModelTextbox.Size = new System.Drawing.Size(222, 26);
            this.addModelTextbox.TabIndex = 1;
            // 
            // addColorLabel
            // 
            this.addColorLabel.AutoSize = true;
            this.addColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addColorLabel.Location = new System.Drawing.Point(159, 309);
            this.addColorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addColorLabel.Name = "addColorLabel";
            this.addColorLabel.Size = new System.Drawing.Size(120, 29);
            this.addColorLabel.TabIndex = 2;
            this.addColorLabel.Text = "Colorway:";
            // 
            // addModelLabel
            // 
            this.addModelLabel.AutoSize = true;
            this.addModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addModelLabel.Location = new System.Drawing.Point(159, 234);
            this.addModelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addModelLabel.Name = "addModelLabel";
            this.addModelLabel.Size = new System.Drawing.Size(87, 29);
            this.addModelLabel.TabIndex = 1;
            this.addModelLabel.Text = "Model:";
            // 
            // addBrandLabel
            // 
            this.addBrandLabel.AutoSize = true;
            this.addBrandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBrandLabel.Location = new System.Drawing.Point(159, 168);
            this.addBrandLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addBrandLabel.Name = "addBrandLabel";
            this.addBrandLabel.Size = new System.Drawing.Size(83, 29);
            this.addBrandLabel.TabIndex = 0;
            this.addBrandLabel.Text = "Brand:";
            this.addBrandLabel.Click += new System.EventHandler(this.addBrandLabel_Click);
            // 
            // editMenuPanel
            // 
            this.editMenuPanel.Controls.Add(this.currentListView);
            this.editMenuPanel.Controls.Add(this.optionsLabel);
            this.editMenuPanel.Controls.Add(this.currentCollectionLabel);
            this.editMenuPanel.Controls.Add(this.addToCurrentButton);
            this.editMenuPanel.Controls.Add(this.exitEditMenuButton);
            this.editMenuPanel.Controls.Add(this.toMainMenu);
            this.editMenuPanel.Controls.Add(this.removeFromCurrentButton);
            this.editMenuPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.editMenuPanel.Location = new System.Drawing.Point(200, 68);
            this.editMenuPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editMenuPanel.Name = "editMenuPanel";
            this.editMenuPanel.Size = new System.Drawing.Size(813, 589);
            this.editMenuPanel.TabIndex = 8;
            this.editMenuPanel.TabStop = true;
            this.editMenuPanel.Visible = false;
            // 
            // currentListView
            // 
            this.currentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.numColumnHeader,
            this.brandColumnHeader,
            this.modelColumnHeader,
            this.colorColumnHeader});
            this.currentListView.FullRowSelect = true;
            this.currentListView.GridLines = true;
            this.currentListView.HideSelection = false;
            this.currentListView.Location = new System.Drawing.Point(270, 83);
            this.currentListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.currentListView.Name = "currentListView";
            this.currentListView.Size = new System.Drawing.Size(541, 504);
            this.currentListView.TabIndex = 4;
            this.currentListView.TabStop = false;
            this.currentListView.UseCompatibleStateImageBehavior = false;
            this.currentListView.View = System.Windows.Forms.View.Details;
            // 
            // numColumnHeader
            // 
            this.numColumnHeader.Text = "";
            this.numColumnHeader.Width = 25;
            // 
            // brandColumnHeader
            // 
            this.brandColumnHeader.Text = "Brand";
            this.brandColumnHeader.Width = 86;
            // 
            // modelColumnHeader
            // 
            this.modelColumnHeader.Text = "Model";
            this.modelColumnHeader.Width = 140;
            // 
            // colorColumnHeader
            // 
            this.colorColumnHeader.Text = "Color";
            this.colorColumnHeader.Width = 114;
            // 
            // optionsLabel
            // 
            this.optionsLabel.AutoSize = true;
            this.optionsLabel.Location = new System.Drawing.Point(108, 80);
            this.optionsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(64, 20);
            this.optionsLabel.TabIndex = 6;
            this.optionsLabel.Text = "Options";
            // 
            // currentCollectionLabel
            // 
            this.currentCollectionLabel.AutoSize = true;
            this.currentCollectionLabel.Location = new System.Drawing.Point(518, 54);
            this.currentCollectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentCollectionLabel.Name = "currentCollectionLabel";
            this.currentCollectionLabel.Size = new System.Drawing.Size(135, 20);
            this.currentCollectionLabel.TabIndex = 5;
            this.currentCollectionLabel.Text = "Current Collection";
            // 
            // addToCurrentButton
            // 
            this.addToCurrentButton.Location = new System.Drawing.Point(80, 135);
            this.addToCurrentButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addToCurrentButton.Name = "addToCurrentButton";
            this.addToCurrentButton.Size = new System.Drawing.Size(128, 52);
            this.addToCurrentButton.TabIndex = 1;
            this.addToCurrentButton.Text = "Add Shoe";
            this.addToCurrentButton.UseVisualStyleBackColor = true;
            this.addToCurrentButton.Click += new System.EventHandler(this.addToCurrentButton_Click);
            // 
            // exitEditMenuButton
            // 
            this.exitEditMenuButton.Location = new System.Drawing.Point(80, 460);
            this.exitEditMenuButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitEditMenuButton.Name = "exitEditMenuButton";
            this.exitEditMenuButton.Size = new System.Drawing.Size(128, 52);
            this.exitEditMenuButton.TabIndex = 4;
            this.exitEditMenuButton.Text = "Exit";
            this.exitEditMenuButton.UseVisualStyleBackColor = true;
            this.exitEditMenuButton.Click += new System.EventHandler(this.exitEditMenuButton_Click);
            // 
            // toMainMenu
            // 
            this.toMainMenu.Location = new System.Drawing.Point(80, 345);
            this.toMainMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toMainMenu.Name = "toMainMenu";
            this.toMainMenu.Size = new System.Drawing.Size(128, 52);
            this.toMainMenu.TabIndex = 3;
            this.toMainMenu.Text = "Main Menu";
            this.toMainMenu.UseVisualStyleBackColor = true;
            this.toMainMenu.Click += new System.EventHandler(this.toMainMenu_Click);
            // 
            // removeFromCurrentButton
            // 
            this.removeFromCurrentButton.Location = new System.Drawing.Point(80, 234);
            this.removeFromCurrentButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.removeFromCurrentButton.Name = "removeFromCurrentButton";
            this.removeFromCurrentButton.Size = new System.Drawing.Size(128, 52);
            this.removeFromCurrentButton.TabIndex = 2;
            this.removeFromCurrentButton.Text = "Remove Shoe";
            this.removeFromCurrentButton.UseVisualStyleBackColor = true;
            this.removeFromCurrentButton.Click += new System.EventHandler(this.removeFromCurrentButton_Click);
            // 
            // removeShoePanel
            // 
            this.removeShoePanel.Controls.Add(this.removedLabel);
            this.removeShoePanel.Controls.Add(this.removedShoeLabel);
            this.removeShoePanel.Controls.Add(this.shoeToRemoveTextBox);
            this.removeShoePanel.Controls.Add(this.currentListViewLabel);
            this.removeShoePanel.Controls.Add(this.removeShoeInstructions);
            this.removeShoePanel.Controls.Add(this.finishRemoveShoeButton);
            this.removeShoePanel.Controls.Add(this.removeShoeButton);
            this.removeShoePanel.Location = new System.Drawing.Point(200, 68);
            this.removeShoePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.removeShoePanel.Name = "removeShoePanel";
            this.removeShoePanel.Size = new System.Drawing.Size(813, 589);
            this.removeShoePanel.TabIndex = 7;
            this.removeShoePanel.Visible = false;
            // 
            // removedLabel
            // 
            this.removedLabel.AutoSize = true;
            this.removedLabel.Location = new System.Drawing.Point(84, 291);
            this.removedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.removedLabel.Name = "removedLabel";
            this.removedLabel.Size = new System.Drawing.Size(81, 20);
            this.removedLabel.TabIndex = 11;
            this.removedLabel.Text = "Removed:";
            // 
            // removedShoeLabel
            // 
            this.removedShoeLabel.AutoSize = true;
            this.removedShoeLabel.Location = new System.Drawing.Point(44, 323);
            this.removedShoeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.removedShoeLabel.Name = "removedShoeLabel";
            this.removedShoeLabel.Size = new System.Drawing.Size(0, 20);
            this.removedShoeLabel.TabIndex = 10;
            // 
            // shoeToRemoveTextBox
            // 
            this.shoeToRemoveTextBox.Location = new System.Drawing.Point(48, 237);
            this.shoeToRemoveTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shoeToRemoveTextBox.Name = "shoeToRemoveTextBox";
            this.shoeToRemoveTextBox.Size = new System.Drawing.Size(157, 26);
            this.shoeToRemoveTextBox.TabIndex = 0;
            // 
            // currentListViewLabel
            // 
            this.currentListViewLabel.AutoSize = true;
            this.currentListViewLabel.Location = new System.Drawing.Point(482, 54);
            this.currentListViewLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentListViewLabel.Name = "currentListViewLabel";
            this.currentListViewLabel.Size = new System.Drawing.Size(135, 20);
            this.currentListViewLabel.TabIndex = 9;
            this.currentListViewLabel.Text = "Current Collection";
            // 
            // removeShoeInstructions
            // 
            this.removeShoeInstructions.AutoSize = true;
            this.removeShoeInstructions.Location = new System.Drawing.Point(22, 158);
            this.removeShoeInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.removeShoeInstructions.Name = "removeShoeInstructions";
            this.removeShoeInstructions.Size = new System.Drawing.Size(221, 40);
            this.removeShoeInstructions.TabIndex = 8;
            this.removeShoeInstructions.Text = "Enter the number of the shoe \r\nyou want to remove";
            this.removeShoeInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // finishRemoveShoeButton
            // 
            this.finishRemoveShoeButton.Location = new System.Drawing.Point(48, 488);
            this.finishRemoveShoeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.finishRemoveShoeButton.Name = "finishRemoveShoeButton";
            this.finishRemoveShoeButton.Size = new System.Drawing.Size(159, 45);
            this.finishRemoveShoeButton.TabIndex = 2;
            this.finishRemoveShoeButton.Text = "Finish";
            this.finishRemoveShoeButton.UseVisualStyleBackColor = true;
            this.finishRemoveShoeButton.Click += new System.EventHandler(this.finishRemoveShoeButton_Click);
            // 
            // removeShoeButton
            // 
            this.removeShoeButton.Location = new System.Drawing.Point(48, 406);
            this.removeShoeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.removeShoeButton.Name = "removeShoeButton";
            this.removeShoeButton.Size = new System.Drawing.Size(159, 45);
            this.removeShoeButton.TabIndex = 1;
            this.removeShoeButton.Text = "Remove Shoe";
            this.removeShoeButton.UseVisualStyleBackColor = true;
            this.removeShoeButton.Click += new System.EventHandler(this.removeShoeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.mainMenuBox);
            this.Controls.Add(this.editMenuPanel);
            this.Controls.Add(this.addShoePanel);
            this.Controls.Add(this.removeShoePanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Shoe Collection";
            this.mainMenuBox.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.addShoePanel.ResumeLayout(false);
            this.addShoePanel.PerformLayout();
            this.editMenuPanel.ResumeLayout(false);
            this.editMenuPanel.PerformLayout();
            this.removeShoePanel.ResumeLayout(false);
            this.removeShoePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mainMenuBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button createCollectionButton;
        private System.Windows.Forms.Button importCollectionButton;
        private System.Windows.Forms.Panel addShoePanel;
        private System.Windows.Forms.TextBox addColorTextbox;
        private System.Windows.Forms.TextBox addBrandTextbox;
        private System.Windows.Forms.TextBox addModelTextbox;
        private System.Windows.Forms.Label addColorLabel;
        private System.Windows.Forms.Label addModelLabel;
        private System.Windows.Forms.Label addBrandLabel;
        private System.Windows.Forms.Label addingShoesLabel;
        private System.Windows.Forms.Button addShoeButton;
        private System.Windows.Forms.Button finishAddShoeButton;
        private System.Windows.Forms.Panel editMenuPanel;
        private System.Windows.Forms.Label currentCollectionLabel;
        private System.Windows.Forms.ListView currentListView;
        private System.Windows.Forms.ColumnHeader brandColumnHeader;
        private System.Windows.Forms.ColumnHeader modelColumnHeader;
        private System.Windows.Forms.ColumnHeader colorColumnHeader;
        private System.Windows.Forms.Button addToCurrentButton;
        private System.Windows.Forms.Button exitEditMenuButton;
        private System.Windows.Forms.Button toMainMenu;
        private System.Windows.Forms.Button removeFromCurrentButton;
        private System.Windows.Forms.Label optionsLabel;
        private System.Windows.Forms.Label addedShoeLabel;
        private System.Windows.Forms.ColumnHeader numColumnHeader;
        private System.Windows.Forms.Panel removeShoePanel;
        private System.Windows.Forms.TextBox shoeToRemoveTextBox;
        private System.Windows.Forms.Label currentListViewLabel;
        private System.Windows.Forms.Label removeShoeInstructions;
        private System.Windows.Forms.Button finishRemoveShoeButton;
        private System.Windows.Forms.Button removeShoeButton;
        private System.Windows.Forms.Label removedShoeLabel;
        private System.Windows.Forms.Label removedLabel;
    }
}

