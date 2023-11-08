namespace PublishingHouse
{
    partial class MainMenu
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
            this.publicationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publishingHouseDataSet = new PublishingHouse.publishingHouseDataSet();
            this.ToolBox = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addData = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searhcButton = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.AddDdata = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publicationsTableAdapter = new PublishingHouse.publishingHouseDataSetTableAdapters.PublicationsTableAdapter();
            this.tableAdapterManager = new PublishingHouse.publishingHouseDataSetTableAdapters.TableAdapterManager();
            this.publicationsDataGridView = new System.Windows.Forms.DataGridView();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreashButton = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.pictureExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.publicationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishingHouseDataSet)).BeginInit();
            this.ToolBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searhcButton)).BeginInit();
            this.AddDdata.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.publicationsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreashButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).BeginInit();
            this.SuspendLayout();
            // 
            // publicationsBindingSource
            // 
            this.publicationsBindingSource.DataMember = "Publications";
            this.publicationsBindingSource.DataSource = this.publishingHouseDataSet;
            // 
            // publishingHouseDataSet
            // 
            this.publishingHouseDataSet.DataSetName = "publishingHouseDataSet";
            this.publishingHouseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ToolBox
            // 
            this.ToolBox.Controls.Add(this.button4);
            this.ToolBox.Controls.Add(this.button2);
            this.ToolBox.Controls.Add(this.addData);
            this.ToolBox.Controls.Add(this.button3);
            this.ToolBox.Location = new System.Drawing.Point(42, 405);
            this.ToolBox.Name = "ToolBox";
            this.ToolBox.Size = new System.Drawing.Size(156, 233);
            this.ToolBox.TabIndex = 1;
            this.ToolBox.TabStop = false;
            this.ToolBox.Text = "Меню инструментов";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(29, 174);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 41);
            this.button4.TabIndex = 5;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // addData
            // 
            this.addData.Location = new System.Drawing.Point(29, 19);
            this.addData.Name = "addData";
            this.addData.Size = new System.Drawing.Size(90, 41);
            this.addData.TabIndex = 2;
            this.addData.Text = "Добавить";
            this.addData.UseVisualStyleBackColor = true;
            this.addData.Click += new System.EventHandler(this.addData_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(29, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 41);
            this.button3.TabIndex = 4;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(710, 1);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(149, 20);
            this.searchBox.TabIndex = 2;
            // 
            // searhcButton
            // 
            this.searhcButton.Location = new System.Drawing.Point(676, 1);
            this.searhcButton.Name = "searhcButton";
            this.searhcButton.Size = new System.Drawing.Size(28, 20);
            this.searhcButton.TabIndex = 4;
            this.searhcButton.TabStop = false;
            this.searhcButton.Click += new System.EventHandler(this.searhcButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(121, 98);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(121, 63);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(121, 136);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 8;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(121, 205);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 14;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(121, 171);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(276, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(276, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(276, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(276, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "label11";
            // 
            // AddDdata
            // 
            this.AddDdata.Controls.Add(this.textBox10);
            this.AddDdata.Controls.Add(this.textBox9);
            this.AddDdata.Controls.Add(this.textBox8);
            this.AddDdata.Controls.Add(this.textBox7);
            this.AddDdata.Controls.Add(this.textBox6);
            this.AddDdata.Controls.Add(this.textBox2);
            this.AddDdata.Controls.Add(this.label11);
            this.AddDdata.Controls.Add(this.textBox3);
            this.AddDdata.Controls.Add(this.label10);
            this.AddDdata.Controls.Add(this.textBox4);
            this.AddDdata.Controls.Add(this.label9);
            this.AddDdata.Controls.Add(this.textBox5);
            this.AddDdata.Controls.Add(this.label8);
            this.AddDdata.Controls.Add(this.textBox11);
            this.AddDdata.Controls.Add(this.label7);
            this.AddDdata.Controls.Add(this.textBox12);
            this.AddDdata.Controls.Add(this.label6);
            this.AddDdata.Controls.Add(this.label5);
            this.AddDdata.Controls.Add(this.label4);
            this.AddDdata.Controls.Add(this.label3);
            this.AddDdata.Controls.Add(this.label2);
            this.AddDdata.Controls.Add(this.label1);
            this.AddDdata.Location = new System.Drawing.Point(266, 405);
            this.AddDdata.Name = "AddDdata";
            this.AddDdata.Size = new System.Drawing.Size(518, 233);
            this.AddDdata.TabIndex = 32;
            this.AddDdata.TabStop = false;
            this.AddDdata.Text = "Данные:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(992, 24);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.запросыToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(992, 24);
            this.menuStrip2.TabIndex = 34;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // publicationsTableAdapter
            // 
            this.publicationsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PublicationsTableAdapter = this.publicationsTableAdapter;
            this.tableAdapterManager.ReviewerTableAdapter = null;
            this.tableAdapterManager.ReviewTableAdapter = null;
            this.tableAdapterManager.SoAuthorTableAdapter = null;
            this.tableAdapterManager.TypePublicationTableAdapter = null;
            this.tableAdapterManager.UDKPublicationsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PublishingHouse.publishingHouseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // publicationsDataGridView
            // 
            this.publicationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.publicationsDataGridView.Location = new System.Drawing.Point(0, 23);
            this.publicationsDataGridView.Name = "publicationsDataGridView";
            this.publicationsDataGridView.Size = new System.Drawing.Size(992, 376);
            this.publicationsDataGridView.TabIndex = 34;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(353, 27);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 32;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(353, 63);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 33;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(353, 104);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 34;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(353, 146);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 35;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(353, 185);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 36;
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.запросыToolStripMenuItem.Text = "Запросы";
            // 
            // refreashButton
            // 
            this.refreashButton.Location = new System.Drawing.Point(642, 1);
            this.refreashButton.Name = "refreashButton";
            this.refreashButton.Size = new System.Drawing.Size(28, 20);
            this.refreashButton.TabIndex = 35;
            this.refreashButton.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(911, 1);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(62, 20);
            this.ExitButton.TabIndex = 36;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // pictureExit
            // 
            this.pictureExit.Location = new System.Drawing.Point(877, 1);
            this.pictureExit.Name = "pictureExit";
            this.pictureExit.Size = new System.Drawing.Size(28, 20);
            this.pictureExit.TabIndex = 37;
            this.pictureExit.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 658);
            this.Controls.Add(this.pictureExit);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.refreashButton);
            this.Controls.Add(this.publicationsDataGridView);
            this.Controls.Add(this.AddDdata);
            this.Controls.Add(this.searhcButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.ToolBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.publicationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishingHouseDataSet)).EndInit();
            this.ToolBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searhcButton)).EndInit();
            this.AddDdata.ResumeLayout(false);
            this.AddDdata.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.publicationsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreashButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox ToolBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addData;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.PictureBox searhcButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox AddDdata;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private publishingHouseDataSet publishingHouseDataSet;
        private System.Windows.Forms.BindingSource publicationsBindingSource;
        private publishingHouseDataSetTableAdapters.PublicationsTableAdapter publicationsTableAdapter;
        private publishingHouseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView publicationsDataGridView;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.PictureBox refreashButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox pictureExit;
    }
}