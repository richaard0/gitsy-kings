
namespace ListeEpicerie
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
            this.showList = new System.Windows.Forms.ListView();
            this.qteHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = new System.Windows.Forms.Label();
            this.groceryCombo = new System.Windows.Forms.ComboBox();
            this.articleCombo = new System.Windows.Forms.ComboBox();
            this.deptCombo = new System.Windows.Forms.ComboBox();
            this.groceryLabel = new System.Windows.Forms.Label();
            this.deptLabel = new System.Windows.Forms.Label();
            this.articleLabel = new System.Windows.Forms.Label();
            this.qtyLabel = new System.Windows.Forms.Label();
            this.qtyTextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.delListButton = new System.Windows.Forms.Button();
            this.articleAddButton = new System.Windows.Forms.Button();
            this.emailButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.éditionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // showList
            // 
            this.showList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.qteHeader,
            this.descHeader,
            this.priceHeader});
            this.showList.HideSelection = false;
            this.showList.Location = new System.Drawing.Point(32, 138);
            this.showList.Name = "showList";
            this.showList.Size = new System.Drawing.Size(359, 330);
            this.showList.TabIndex = 0;
            this.showList.UseCompatibleStateImageBehavior = false;
            this.showList.View = System.Windows.Forms.View.Details;
            this.showList.VirtualListSize = 10;
            // 
            // qteHeader
            // 
            this.qteHeader.Text = "Qte";
            this.qteHeader.Width = 40;
            // 
            // descHeader
            // 
            this.descHeader.Text = "Description";
            this.descHeader.Width = 260;
            // 
            // priceHeader
            // 
            this.priceHeader.Text = "Prix";
            this.priceHeader.Width = 55;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(215, 35);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(474, 73);
            this.title.TabIndex = 2;
            this.title.Text = "Liste d\'épicerie";
            // 
            // groceryCombo
            // 
            this.groceryCombo.FormattingEnabled = true;
            this.groceryCombo.Location = new System.Drawing.Point(624, 138);
            this.groceryCombo.Name = "groceryCombo";
            this.groceryCombo.Size = new System.Drawing.Size(216, 21);
            this.groceryCombo.TabIndex = 3;
            // 
            // articleCombo
            // 
            this.articleCombo.FormattingEnabled = true;
            this.articleCombo.Location = new System.Drawing.Point(624, 219);
            this.articleCombo.Name = "articleCombo";
            this.articleCombo.Size = new System.Drawing.Size(216, 21);
            this.articleCombo.TabIndex = 4;
            // 
            // deptCombo
            // 
            this.deptCombo.FormattingEnabled = true;
            this.deptCombo.Location = new System.Drawing.Point(624, 178);
            this.deptCombo.Name = "deptCombo";
            this.deptCombo.Size = new System.Drawing.Size(216, 21);
            this.deptCombo.TabIndex = 5;
            // 
            // groceryLabel
            // 
            this.groceryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groceryLabel.AutoSize = true;
            this.groceryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groceryLabel.Location = new System.Drawing.Point(489, 139);
            this.groceryLabel.Name = "groceryLabel";
            this.groceryLabel.Size = new System.Drawing.Size(121, 20);
            this.groceryLabel.TabIndex = 6;
            this.groceryLabel.Text = "Choisr épicerie :";
            this.groceryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // deptLabel
            // 
            this.deptLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deptLabel.AutoSize = true;
            this.deptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptLabel.Location = new System.Drawing.Point(453, 179);
            this.deptLabel.Name = "deptLabel";
            this.deptLabel.Size = new System.Drawing.Size(157, 20);
            this.deptLabel.TabIndex = 7;
            this.deptLabel.Text = "Choisr département :";
            this.deptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // articleLabel
            // 
            this.articleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.articleLabel.AutoSize = true;
            this.articleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articleLabel.Location = new System.Drawing.Point(502, 220);
            this.articleLabel.Name = "articleLabel";
            this.articleLabel.Size = new System.Drawing.Size(108, 20);
            this.articleLabel.TabIndex = 8;
            this.articleLabel.Text = "Choisr article :";
            this.articleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // qtyLabel
            // 
            this.qtyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.qtyLabel.AutoSize = true;
            this.qtyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyLabel.Location = new System.Drawing.Point(532, 261);
            this.qtyLabel.Name = "qtyLabel";
            this.qtyLabel.Size = new System.Drawing.Size(78, 20);
            this.qtyLabel.TabIndex = 9;
            this.qtyLabel.Text = "Quantité :";
            this.qtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // qtyTextbox
            // 
            this.qtyTextbox.Location = new System.Drawing.Point(624, 261);
            this.qtyTextbox.Name = "qtyTextbox";
            this.qtyTextbox.Size = new System.Drawing.Size(100, 20);
            this.qtyTextbox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(32, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(357, 52);
            this.button1.TabIndex = 11;
            this.button1.Text = "Supprimer le(s) article(s) sélectionné(s)";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // delListButton
            // 
            this.delListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delListButton.Location = new System.Drawing.Point(32, 564);
            this.delListButton.Name = "delListButton";
            this.delListButton.Size = new System.Drawing.Size(354, 46);
            this.delListButton.TabIndex = 12;
            this.delListButton.Text = "Supprimer la liste";
            this.delListButton.UseVisualStyleBackColor = true;
            // 
            // articleAddButton
            // 
            this.articleAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articleAddButton.Location = new System.Drawing.Point(632, 310);
            this.articleAddButton.Name = "articleAddButton";
            this.articleAddButton.Size = new System.Drawing.Size(208, 48);
            this.articleAddButton.TabIndex = 13;
            this.articleAddButton.Text = "Ajouter article à la liste";
            this.articleAddButton.UseVisualStyleBackColor = true;
            this.articleAddButton.Click += new System.EventHandler(this.articleAddButton_Click);
            // 
            // emailButton
            // 
            this.emailButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailButton.Location = new System.Drawing.Point(459, 545);
            this.emailButton.Name = "emailButton";
            this.emailButton.Size = new System.Drawing.Size(137, 65);
            this.emailButton.TabIndex = 14;
            this.emailButton.Text = "Courriel";
            this.emailButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(616, 545);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(137, 65);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Sauvegarder";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // printButton
            // 
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(770, 545);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(137, 65);
            this.printButton.TabIndex = 16;
            this.printButton.Text = "Imprimer";
            this.printButton.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.éditionToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // éditionToolStripMenuItem
            // 
            this.éditionToolStripMenuItem.Name = "éditionToolStripMenuItem";
            this.éditionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.éditionToolStripMenuItem.Text = "Édition";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(919, 632);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.emailButton);
            this.Controls.Add(this.articleAddButton);
            this.Controls.Add(this.delListButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.qtyTextbox);
            this.Controls.Add(this.qtyLabel);
            this.Controls.Add(this.articleLabel);
            this.Controls.Add(this.deptLabel);
            this.Controls.Add(this.groceryLabel);
            this.Controls.Add(this.deptCombo);
            this.Controls.Add(this.articleCombo);
            this.Controls.Add(this.groceryCombo);
            this.Controls.Add(this.title);
            this.Controls.Add(this.showList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Liste d\'épicerie v 0.01";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView showList;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ComboBox groceryCombo;
        private System.Windows.Forms.ComboBox articleCombo;
        private System.Windows.Forms.ComboBox deptCombo;
        private System.Windows.Forms.Label groceryLabel;
        private System.Windows.Forms.Label deptLabel;
        private System.Windows.Forms.Label articleLabel;
        private System.Windows.Forms.Label qtyLabel;
        private System.Windows.Forms.TextBox qtyTextbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button delListButton;
        private System.Windows.Forms.Button articleAddButton;
        private System.Windows.Forms.Button emailButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem éditionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader qteHeader;
        private System.Windows.Forms.ColumnHeader descHeader;
        private System.Windows.Forms.ColumnHeader priceHeader;
    }
}

