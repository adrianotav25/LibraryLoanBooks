namespace LibraryLoanBooks
{
    partial class frmPrincipal
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
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabPagePrincipal = new System.Windows.Forms.TabPage();
            this.tabPageAuthor = new System.Windows.Forms.TabPage();
            this.groupBoxSearchAuthor = new System.Windows.Forms.GroupBox();
            this.btnSearcj = new System.Windows.Forms.Button();
            this.cmbAuthorNationalitySearch = new System.Windows.Forms.ComboBox();
            this.txtAuthorNameSearch = new System.Windows.Forms.TextBox();
            this.lblAuthorNationalitySearch = new System.Windows.Forms.Label();
            this.lblAuthorNameSearch = new System.Windows.Forms.Label();
            this.tabPagePublisher = new System.Windows.Forms.TabPage();
            this.tabPageTheme = new System.Windows.Forms.TabPage();
            this.tabPageBook = new System.Windows.Forms.TabPage();
            this.tabPageClients = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pnlAuthor = new System.Windows.Forms.Panel();
            this.dataGridViewAuthor = new System.Windows.Forms.DataGridView();
            this.btnNewAuthor = new System.Windows.Forms.Button();
            this.btnDeleteAuthor = new System.Windows.Forms.Button();
            this.btnEditAutor = new System.Windows.Forms.Button();
            this.btnSearchAuthor = new System.Windows.Forms.Button();
            this.groupBoxSearchPublisher = new System.Windows.Forms.GroupBox();
            this.lblPublisherNameSearch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPublisherNameSearch = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnPublisherSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPrincipal.SuspendLayout();
            this.tabPageAuthor.SuspendLayout();
            this.groupBoxSearchAuthor.SuspendLayout();
            this.tabPagePublisher.SuspendLayout();
            this.pnlAuthor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthor)).BeginInit();
            this.groupBoxSearchPublisher.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabPagePrincipal);
            this.tabPrincipal.Controls.Add(this.tabPageAuthor);
            this.tabPrincipal.Controls.Add(this.tabPagePublisher);
            this.tabPrincipal.Controls.Add(this.tabPageTheme);
            this.tabPrincipal.Controls.Add(this.tabPageBook);
            this.tabPrincipal.Controls.Add(this.tabPageClients);
            this.tabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(1214, 711);
            this.tabPrincipal.TabIndex = 0;
            this.tabPrincipal.SelectedIndexChanged += new System.EventHandler(this.tabPrincipal_SelectedIndexChanged);
            // 
            // tabPagePrincipal
            // 
            this.tabPagePrincipal.Location = new System.Drawing.Point(4, 24);
            this.tabPagePrincipal.Name = "tabPagePrincipal";
            this.tabPagePrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrincipal.Size = new System.Drawing.Size(1206, 683);
            this.tabPagePrincipal.TabIndex = 0;
            this.tabPagePrincipal.Text = "Principal";
            this.tabPagePrincipal.UseVisualStyleBackColor = true;
            // 
            // tabPageAuthor
            // 
            this.tabPageAuthor.Controls.Add(this.pnlAuthor);
            this.tabPageAuthor.Controls.Add(this.groupBoxSearchAuthor);
            this.tabPageAuthor.Location = new System.Drawing.Point(4, 24);
            this.tabPageAuthor.Name = "tabPageAuthor";
            this.tabPageAuthor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAuthor.Size = new System.Drawing.Size(1206, 683);
            this.tabPageAuthor.TabIndex = 1;
            this.tabPageAuthor.Text = "Autores";
            this.tabPageAuthor.UseVisualStyleBackColor = true;
            // 
            // groupBoxSearchAuthor
            // 
            this.groupBoxSearchAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearchAuthor.Controls.Add(this.btnSearcj);
            this.groupBoxSearchAuthor.Controls.Add(this.cmbAuthorNationalitySearch);
            this.groupBoxSearchAuthor.Controls.Add(this.txtAuthorNameSearch);
            this.groupBoxSearchAuthor.Controls.Add(this.lblAuthorNationalitySearch);
            this.groupBoxSearchAuthor.Controls.Add(this.lblAuthorNameSearch);
            this.groupBoxSearchAuthor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxSearchAuthor.Location = new System.Drawing.Point(8, 6);
            this.groupBoxSearchAuthor.Name = "groupBoxSearchAuthor";
            this.groupBoxSearchAuthor.Size = new System.Drawing.Size(1190, 133);
            this.groupBoxSearchAuthor.TabIndex = 5;
            this.groupBoxSearchAuthor.TabStop = false;
            this.groupBoxSearchAuthor.Text = "Consulta";
            // 
            // btnSearcj
            // 
            this.btnSearcj.Location = new System.Drawing.Point(377, 59);
            this.btnSearcj.Name = "btnSearcj";
            this.btnSearcj.Size = new System.Drawing.Size(75, 27);
            this.btnSearcj.TabIndex = 9;
            this.btnSearcj.Text = "Buscar";
            this.btnSearcj.UseVisualStyleBackColor = true;
            // 
            // cmbAuthorNationalitySearch
            // 
            this.cmbAuthorNationalitySearch.FormattingEnabled = true;
            this.cmbAuthorNationalitySearch.Location = new System.Drawing.Point(196, 59);
            this.cmbAuthorNationalitySearch.Name = "cmbAuthorNationalitySearch";
            this.cmbAuthorNationalitySearch.Size = new System.Drawing.Size(175, 29);
            this.cmbAuthorNationalitySearch.TabIndex = 8;
            // 
            // txtAuthorNameSearch
            // 
            this.txtAuthorNameSearch.Location = new System.Drawing.Point(6, 59);
            this.txtAuthorNameSearch.Name = "txtAuthorNameSearch";
            this.txtAuthorNameSearch.Size = new System.Drawing.Size(175, 29);
            this.txtAuthorNameSearch.TabIndex = 7;
            // 
            // lblAuthorNationalitySearch
            // 
            this.lblAuthorNationalitySearch.AutoSize = true;
            this.lblAuthorNationalitySearch.Location = new System.Drawing.Point(196, 35);
            this.lblAuthorNationalitySearch.Name = "lblAuthorNationalitySearch";
            this.lblAuthorNationalitySearch.Size = new System.Drawing.Size(122, 21);
            this.lblAuthorNationalitySearch.TabIndex = 6;
            this.lblAuthorNationalitySearch.Text = "Nacionalidade";
            // 
            // lblAuthorNameSearch
            // 
            this.lblAuthorNameSearch.AutoSize = true;
            this.lblAuthorNameSearch.Location = new System.Drawing.Point(6, 35);
            this.lblAuthorNameSearch.Name = "lblAuthorNameSearch";
            this.lblAuthorNameSearch.Size = new System.Drawing.Size(128, 21);
            this.lblAuthorNameSearch.TabIndex = 5;
            this.lblAuthorNameSearch.Text = "Nome do Autor";
            // 
            // tabPagePublisher
            // 
            this.tabPagePublisher.Controls.Add(this.panel1);
            this.tabPagePublisher.Controls.Add(this.groupBoxSearchPublisher);
            this.tabPagePublisher.Location = new System.Drawing.Point(4, 24);
            this.tabPagePublisher.Name = "tabPagePublisher";
            this.tabPagePublisher.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePublisher.Size = new System.Drawing.Size(1206, 683);
            this.tabPagePublisher.TabIndex = 2;
            this.tabPagePublisher.Text = "Editoras";
            this.tabPagePublisher.UseVisualStyleBackColor = true;
            // 
            // tabPageTheme
            // 
            this.tabPageTheme.Location = new System.Drawing.Point(4, 24);
            this.tabPageTheme.Name = "tabPageTheme";
            this.tabPageTheme.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTheme.Size = new System.Drawing.Size(1206, 683);
            this.tabPageTheme.TabIndex = 3;
            this.tabPageTheme.Text = "Temas";
            this.tabPageTheme.UseVisualStyleBackColor = true;
            // 
            // tabPageBook
            // 
            this.tabPageBook.Location = new System.Drawing.Point(4, 24);
            this.tabPageBook.Name = "tabPageBook";
            this.tabPageBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBook.Size = new System.Drawing.Size(1206, 683);
            this.tabPageBook.TabIndex = 4;
            this.tabPageBook.Text = "Livros";
            this.tabPageBook.UseVisualStyleBackColor = true;
            // 
            // tabPageClients
            // 
            this.tabPageClients.Location = new System.Drawing.Point(4, 24);
            this.tabPageClients.Name = "tabPageClients";
            this.tabPageClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClients.Size = new System.Drawing.Size(1206, 683);
            this.tabPageClients.TabIndex = 5;
            this.tabPageClients.Text = "Clientes";
            this.tabPageClients.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 689);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1214, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pnlAuthor
            // 
            this.pnlAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAuthor.BackColor = System.Drawing.Color.Silver;
            this.pnlAuthor.Controls.Add(this.btnSearchAuthor);
            this.pnlAuthor.Controls.Add(this.btnEditAutor);
            this.pnlAuthor.Controls.Add(this.btnDeleteAuthor);
            this.pnlAuthor.Controls.Add(this.btnNewAuthor);
            this.pnlAuthor.Controls.Add(this.dataGridViewAuthor);
            this.pnlAuthor.Location = new System.Drawing.Point(8, 145);
            this.pnlAuthor.Name = "pnlAuthor";
            this.pnlAuthor.Size = new System.Drawing.Size(1190, 517);
            this.pnlAuthor.TabIndex = 6;
            // 
            // dataGridViewAuthor
            // 
            this.dataGridViewAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAuthor.Location = new System.Drawing.Point(6, 167);
            this.dataGridViewAuthor.Name = "dataGridViewAuthor";
            this.dataGridViewAuthor.RowTemplate.Height = 25;
            this.dataGridViewAuthor.Size = new System.Drawing.Size(1181, 347);
            this.dataGridViewAuthor.TabIndex = 0;
            // 
            // btnNewAuthor
            // 
            this.btnNewAuthor.BackColor = System.Drawing.Color.Transparent;
            this.btnNewAuthor.BackgroundImage = global::LibraryLoanBooks.Properties.Resources.Add;
            this.btnNewAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewAuthor.Location = new System.Drawing.Point(43, 49);
            this.btnNewAuthor.Name = "btnNewAuthor";
            this.btnNewAuthor.Size = new System.Drawing.Size(50, 50);
            this.btnNewAuthor.TabIndex = 1;
            this.btnNewAuthor.UseVisualStyleBackColor = false;
            // 
            // btnDeleteAuthor
            // 
            this.btnDeleteAuthor.BackgroundImage = global::LibraryLoanBooks.Properties.Resources.Delete;
            this.btnDeleteAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteAuthor.Location = new System.Drawing.Point(99, 49);
            this.btnDeleteAuthor.Name = "btnDeleteAuthor";
            this.btnDeleteAuthor.Size = new System.Drawing.Size(50, 50);
            this.btnDeleteAuthor.TabIndex = 2;
            this.btnDeleteAuthor.UseVisualStyleBackColor = true;
            // 
            // btnEditAutor
            // 
            this.btnEditAutor.BackgroundImage = global::LibraryLoanBooks.Properties.Resources.Edit;
            this.btnEditAutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditAutor.Location = new System.Drawing.Point(155, 49);
            this.btnEditAutor.Name = "btnEditAutor";
            this.btnEditAutor.Size = new System.Drawing.Size(50, 50);
            this.btnEditAutor.TabIndex = 3;
            this.btnEditAutor.UseVisualStyleBackColor = true;
            // 
            // btnSearchAuthor
            // 
            this.btnSearchAuthor.BackgroundImage = global::LibraryLoanBooks.Properties.Resources.Search;
            this.btnSearchAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchAuthor.Location = new System.Drawing.Point(211, 49);
            this.btnSearchAuthor.Name = "btnSearchAuthor";
            this.btnSearchAuthor.Size = new System.Drawing.Size(50, 50);
            this.btnSearchAuthor.TabIndex = 4;
            this.btnSearchAuthor.UseVisualStyleBackColor = true;
            // 
            // groupBoxSearchPublisher
            // 
            this.groupBoxSearchPublisher.Controls.Add(this.btnPublisherSearch);
            this.groupBoxSearchPublisher.Controls.Add(this.comboBox1);
            this.groupBoxSearchPublisher.Controls.Add(this.txtPublisherNameSearch);
            this.groupBoxSearchPublisher.Controls.Add(this.label1);
            this.groupBoxSearchPublisher.Controls.Add(this.lblPublisherNameSearch);
            this.groupBoxSearchPublisher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxSearchPublisher.Location = new System.Drawing.Point(8, 6);
            this.groupBoxSearchPublisher.Name = "groupBoxSearchPublisher";
            this.groupBoxSearchPublisher.Size = new System.Drawing.Size(1190, 133);
            this.groupBoxSearchPublisher.TabIndex = 0;
            this.groupBoxSearchPublisher.TabStop = false;
            this.groupBoxSearchPublisher.Text = "Consulta ";
            // 
            // lblPublisherNameSearch
            // 
            this.lblPublisherNameSearch.AutoSize = true;
            this.lblPublisherNameSearch.Location = new System.Drawing.Point(6, 35);
            this.lblPublisherNameSearch.Name = "lblPublisherNameSearch";
            this.lblPublisherNameSearch.Size = new System.Drawing.Size(139, 21);
            this.lblPublisherNameSearch.TabIndex = 0;
            this.lblPublisherNameSearch.Text = "Nome da Editora";
            this.lblPublisherNameSearch.Click += new System.EventHandler(this.lblPublisherNameSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // txtPublisherNameSearch
            // 
            this.txtPublisherNameSearch.Location = new System.Drawing.Point(6, 59);
            this.txtPublisherNameSearch.Name = "txtPublisherNameSearch";
            this.txtPublisherNameSearch.Size = new System.Drawing.Size(175, 29);
            this.txtPublisherNameSearch.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(196, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 29);
            this.comboBox1.TabIndex = 3;
            // 
            // btnPublisherSearch
            // 
            this.btnPublisherSearch.Location = new System.Drawing.Point(377, 59);
            this.btnPublisherSearch.Name = "btnPublisherSearch";
            this.btnPublisherSearch.Size = new System.Drawing.Size(75, 27);
            this.btnPublisherSearch.TabIndex = 4;
            this.btnPublisherSearch.Text = "Buscar";
            this.btnPublisherSearch.UseVisualStyleBackColor = true;
            this.btnPublisherSearch.Click += new System.EventHandler(this.btnPublisherSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(8, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1190, 517);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1181, 347);
            this.dataGridView1.TabIndex = 0;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 711);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabPrincipal);
            this.Name = "frmPrincipal";
            this.Text = "Biblioteca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabPrincipal.ResumeLayout(false);
            this.tabPageAuthor.ResumeLayout(false);
            this.groupBoxSearchAuthor.ResumeLayout(false);
            this.groupBoxSearchAuthor.PerformLayout();
            this.tabPagePublisher.ResumeLayout(false);
            this.pnlAuthor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthor)).EndInit();
            this.groupBoxSearchPublisher.ResumeLayout(false);
            this.groupBoxSearchPublisher.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabPrincipal;
        private TabPage tabPagePrincipal;
        private TabPage tabPageAuthor;
        private TabPage tabPagePublisher;
        private TabPage tabPageTheme;
        private TabPage tabPageBook;
        private TabPage tabPageClients;
        private StatusStrip statusStrip1;
        private GroupBox groupBoxSearchAuthor;
        private Button btnSearcj;
        private ComboBox cmbAuthorNationalitySearch;
        private TextBox txtAuthorNameSearch;
        private Label lblAuthorNationalitySearch;
        private Label lblAuthorNameSearch;
        private Panel pnlAuthor;
        private Button btnSearchAuthor;
        private Button btnEditAutor;
        private Button btnDeleteAuthor;
        private Button btnNewAuthor;
        private DataGridView dataGridViewAuthor;
        private GroupBox groupBoxSearchPublisher;
        private ComboBox comboBox1;
        private TextBox txtPublisherNameSearch;
        private Label label1;
        private Label lblPublisherNameSearch;
        private Button btnPublisherSearch;
        private Panel panel1;
        private DataGridView dataGridView1;
    }
}