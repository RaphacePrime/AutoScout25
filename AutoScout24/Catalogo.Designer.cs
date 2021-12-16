
namespace AutoScout24
{
    partial class Catalogo
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
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label modelloLabel;
            System.Windows.Forms.Label tipologiaLabel;
            System.Windows.Forms.Label urlLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalogo));
            this.mazzoLuzziDataSet = new AutoScout24.MazzoLuzziDataSet();
            this.prodottiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodottiTableAdapter = new AutoScout24.MazzoLuzziDataSetTableAdapters.ProdottiTableAdapter();
            this.tableAdapterManager = new AutoScout24.MazzoLuzziDataSetTableAdapters.TableAdapterManager();
            this.prodottiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.modelloTextBox = new System.Windows.Forms.TextBox();
            this.tipologiaTextBox = new System.Windows.Forms.TextBox();
            this.fu_aggiungicarrello = new System.Windows.Forms.Button();
            this.fu_labelutente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fu_saldo = new System.Windows.Forms.Label();
            this.fu_indice = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.codiceprodottoTextBox = new System.Windows.Forms.TextBox();
            this.acquista = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.eliminazionedacarrello = new System.Windows.Forms.Button();
            this.totalecosto = new System.Windows.Forms.Label();
            this.prezzoTextBox = new System.Windows.Forms.TextBox();
            this.utentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utentiTableAdapter = new AutoScout24.MazzoLuzziDataSetTableAdapters.UtentiTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.carrello = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            modelloLabel = new System.Windows.Forms.Label();
            tipologiaLabel = new System.Windows.Forms.Label();
            urlLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mazzoLuzziDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodottiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodottiBindingNavigator)).BeginInit();
            this.prodottiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utentiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Location = new System.Drawing.Point(145, 71);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(39, 13);
            marcaLabel.TabIndex = 1;
            marcaLabel.Text = "marca:";
            // 
            // modelloLabel
            // 
            modelloLabel.AutoSize = true;
            modelloLabel.Location = new System.Drawing.Point(308, 71);
            modelloLabel.Name = "modelloLabel";
            modelloLabel.Size = new System.Drawing.Size(46, 13);
            modelloLabel.TabIndex = 3;
            modelloLabel.Text = "modello:";
            // 
            // tipologiaLabel
            // 
            tipologiaLabel.AutoSize = true;
            tipologiaLabel.Location = new System.Drawing.Point(491, 71);
            tipologiaLabel.Name = "tipologiaLabel";
            tipologiaLabel.Size = new System.Drawing.Size(49, 13);
            tipologiaLabel.TabIndex = 5;
            tipologiaLabel.Text = "tipologia:";
            // 
            // urlLabel
            // 
            urlLabel.AutoSize = true;
            urlLabel.Location = new System.Drawing.Point(8, 422);
            urlLabel.Name = "urlLabel";
            urlLabel.Size = new System.Drawing.Size(21, 13);
            urlLabel.TabIndex = 13;
            urlLabel.Text = "url:";
            // 
            // mazzoLuzziDataSet
            // 
            this.mazzoLuzziDataSet.DataSetName = "MazzoLuzziDataSet";
            this.mazzoLuzziDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prodottiBindingSource
            // 
            this.prodottiBindingSource.DataMember = "Prodotti";
            this.prodottiBindingSource.DataSource = this.mazzoLuzziDataSet;
            // 
            // prodottiTableAdapter
            // 
            this.prodottiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProdottiTableAdapter = this.prodottiTableAdapter;
            this.tableAdapterManager.UpdateOrder = AutoScout24.MazzoLuzziDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtentiTableAdapter = null;
            // 
            // prodottiBindingNavigator
            // 
            this.prodottiBindingNavigator.AddNewItem = null;
            this.prodottiBindingNavigator.BindingSource = this.prodottiBindingSource;
            this.prodottiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.prodottiBindingNavigator.DeleteItem = null;
            this.prodottiBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.prodottiBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.prodottiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorSeparator2});
            this.prodottiBindingNavigator.Location = new System.Drawing.Point(299, 322);
            this.prodottiBindingNavigator.MoveFirstItem = null;
            this.prodottiBindingNavigator.MoveLastItem = null;
            this.prodottiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.prodottiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.prodottiBindingNavigator.Name = "prodottiBindingNavigator";
            this.prodottiBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.prodottiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.prodottiBindingNavigator.Size = new System.Drawing.Size(173, 31);
            this.prodottiBindingNavigator.TabIndex = 0;
            this.prodottiBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorCountItem.Text = "di {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Numero totale di elementi";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Sposta indietro";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posizione";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posizione corrente";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Sposta avanti";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prodottiBindingSource, "marca", true));
            this.marcaTextBox.Location = new System.Drawing.Point(190, 68);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(100, 20);
            this.marcaTextBox.TabIndex = 2;
            // 
            // modelloTextBox
            // 
            this.modelloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prodottiBindingSource, "modello", true));
            this.modelloTextBox.Location = new System.Drawing.Point(360, 68);
            this.modelloTextBox.Name = "modelloTextBox";
            this.modelloTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelloTextBox.TabIndex = 4;
            // 
            // tipologiaTextBox
            // 
            this.tipologiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prodottiBindingSource, "tipologia", true));
            this.tipologiaTextBox.Location = new System.Drawing.Point(546, 68);
            this.tipologiaTextBox.Name = "tipologiaTextBox";
            this.tipologiaTextBox.Size = new System.Drawing.Size(100, 20);
            this.tipologiaTextBox.TabIndex = 6;
            // 
            // fu_aggiungicarrello
            // 
            this.fu_aggiungicarrello.Location = new System.Drawing.Point(275, 365);
            this.fu_aggiungicarrello.Name = "fu_aggiungicarrello";
            this.fu_aggiungicarrello.Size = new System.Drawing.Size(228, 37);
            this.fu_aggiungicarrello.TabIndex = 8;
            this.fu_aggiungicarrello.Text = "AGGIUNGI AL CARRELLO";
            this.fu_aggiungicarrello.UseVisualStyleBackColor = true;
            this.fu_aggiungicarrello.Click += new System.EventHandler(this.fu_aggiungicarrello_Click);
            // 
            // fu_labelutente
            // 
            this.fu_labelutente.AutoSize = true;
            this.fu_labelutente.Location = new System.Drawing.Point(12, 9);
            this.fu_labelutente.Name = "fu_labelutente";
            this.fu_labelutente.Size = new System.Drawing.Size(39, 13);
            this.fu_labelutente.TabIndex = 9;
            this.fu_labelutente.Text = "Utente";
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(625, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "saldo:";
            // 
            // fu_saldo
            // 
            this.fu_saldo.AutoSize = true;
            this.fu_saldo.Location = new System.Drawing.Point(677, 9);
            this.fu_saldo.Name = "fu_saldo";
            this.fu_saldo.Size = new System.Drawing.Size(28, 13);
            this.fu_saldo.TabIndex = 11;
            this.fu_saldo.Text = "0,00";
            // 
            // fu_indice
            // 
            this.fu_indice.AutoSize = true;
            this.fu_indice.Location = new System.Drawing.Point(42, 233);
            this.fu_indice.Name = "fu_indice";
            this.fu_indice.Size = new System.Drawing.Size(13, 13);
            this.fu_indice.TabIndex = 12;
            this.fu_indice.Text = "0";
            // 
            // urlTextBox
            // 
            this.urlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prodottiBindingSource, "url", true));
            this.urlTextBox.Location = new System.Drawing.Point(35, 419);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(711, 20);
            this.urlTextBox.TabIndex = 14;
            // 
            // codiceprodottoTextBox
            // 
            this.codiceprodottoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prodottiBindingSource, "codiceprodotto", true));
            this.codiceprodottoTextBox.Location = new System.Drawing.Point(15, 248);
            this.codiceprodottoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.codiceprodottoTextBox.Name = "codiceprodottoTextBox";
            this.codiceprodottoTextBox.Size = new System.Drawing.Size(68, 20);
            this.codiceprodottoTextBox.TabIndex = 16;
            this.codiceprodottoTextBox.TextChanged += new System.EventHandler(this.codiceprodottoTextBox_TextChanged);
            // 
            // acquista
            // 
            this.acquista.Location = new System.Drawing.Point(1449, 344);
            this.acquista.Name = "acquista";
            this.acquista.Size = new System.Drawing.Size(228, 37);
            this.acquista.TabIndex = 19;
            this.acquista.Text = "EFFETTUA PAGAMENTO";
            this.acquista.UseVisualStyleBackColor = true;
            this.acquista.Click += new System.EventHandler(this.acquista_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(1410, 77);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(302, 139);
            this.checkedListBox1.TabIndex = 20;
            // 
            // eliminazionedacarrello
            // 
            this.eliminazionedacarrello.Location = new System.Drawing.Point(1449, 222);
            this.eliminazionedacarrello.Name = "eliminazionedacarrello";
            this.eliminazionedacarrello.Size = new System.Drawing.Size(228, 19);
            this.eliminazionedacarrello.TabIndex = 21;
            this.eliminazionedacarrello.Text = "Elimina elementi selezionati";
            this.eliminazionedacarrello.UseVisualStyleBackColor = true;
            this.eliminazionedacarrello.Click += new System.EventHandler(this.eliminazionedacarrello_Click);
            // 
            // totalecosto
            // 
            this.totalecosto.AutoSize = true;
            this.totalecosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalecosto.Location = new System.Drawing.Point(1545, 310);
            this.totalecosto.Name = "totalecosto";
            this.totalecosto.Size = new System.Drawing.Size(54, 26);
            this.totalecosto.TabIndex = 22;
            this.totalecosto.Text = "0,00";
            // 
            // prezzoTextBox
            // 
            this.prezzoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prodottiBindingSource, "prezzo", true));
            this.prezzoTextBox.Location = new System.Drawing.Point(546, 311);
            this.prezzoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.prezzoTextBox.Name = "prezzoTextBox";
            this.prezzoTextBox.Size = new System.Drawing.Size(93, 20);
            this.prezzoTextBox.TabIndex = 23;
            // 
            // utentiBindingSource
            // 
            this.utentiBindingSource.DataMember = "Utenti";
            this.utentiBindingSource.DataSource = this.mazzoLuzziDataSet;
            // 
            // utentiTableAdapter
            // 
            this.utentiTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1397, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "0,00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1345, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "saldo:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(148, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(498, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // carrello
            // 
            this.carrello.BackColor = System.Drawing.Color.Transparent;
            this.carrello.BackgroundImage = global::AutoScout24.Properties.Resources.carrello;
            this.carrello.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carrello.ForeColor = System.Drawing.Color.Transparent;
            this.carrello.Location = new System.Drawing.Point(680, 203);
            this.carrello.Margin = new System.Windows.Forms.Padding(2);
            this.carrello.Name = "carrello";
            this.carrello.Size = new System.Drawing.Size(61, 57);
            this.carrello.TabIndex = 17;
            this.carrello.UseVisualStyleBackColor = false;
            this.carrello.Click += new System.EventHandler(this.carrello_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(304, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 37);
            this.label4.TabIndex = 26;
            this.label4.Text = "Catalogo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1493, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 37);
            this.label5.TabIndex = 27;
            this.label5.Text = "Carrello";
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1739, 459);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prezzoTextBox);
            this.Controls.Add(this.totalecosto);
            this.Controls.Add(this.eliminazionedacarrello);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.acquista);
            this.Controls.Add(this.codiceprodottoTextBox);
            this.Controls.Add(urlLabel);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.fu_indice);
            this.Controls.Add(this.fu_saldo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fu_labelutente);
            this.Controls.Add(this.fu_aggiungicarrello);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(tipologiaLabel);
            this.Controls.Add(this.tipologiaTextBox);
            this.Controls.Add(modelloLabel);
            this.Controls.Add(this.modelloTextBox);
            this.Controls.Add(marcaLabel);
            this.Controls.Add(this.marcaTextBox);
            this.Controls.Add(this.prodottiBindingNavigator);
            this.Controls.Add(this.carrello);
            this.Name = "Catalogo";
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.Catalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mazzoLuzziDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodottiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodottiBindingNavigator)).EndInit();
            this.prodottiBindingNavigator.ResumeLayout(false);
            this.prodottiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utentiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MazzoLuzziDataSet mazzoLuzziDataSet;
        private System.Windows.Forms.BindingSource prodottiBindingSource;
        private MazzoLuzziDataSetTableAdapters.ProdottiTableAdapter prodottiTableAdapter;
        private MazzoLuzziDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator prodottiBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.TextBox modelloTextBox;
        private System.Windows.Forms.TextBox tipologiaTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button fu_aggiungicarrello;
        private System.Windows.Forms.Label fu_labelutente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fu_saldo;
        private System.Windows.Forms.Label fu_indice;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.TextBox codiceprodottoTextBox;
        private System.Windows.Forms.Button carrello;
        private System.Windows.Forms.Button acquista;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button eliminazionedacarrello;
        private System.Windows.Forms.Label totalecosto;
        private System.Windows.Forms.TextBox prezzoTextBox;
        private System.Windows.Forms.BindingSource utentiBindingSource;
        private MazzoLuzziDataSetTableAdapters.UtentiTableAdapter utentiTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}