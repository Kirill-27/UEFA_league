namespace UEFA_league
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uEFA_leagueDataSet = new UEFA_league.UEFA_leagueDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stadiumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playersTableAdapter = new UEFA_league.UEFA_leagueDataSetTableAdapters.playersTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distributionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stadiumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.judgesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lable_table_name = new System.Windows.Forms.Label();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamsTableAdapter = new UEFA_league.UEFA_leagueDataSetTableAdapters.teamsTableAdapter();
            this.matchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matchesTableAdapter = new UEFA_league.UEFA_leagueDataSetTableAdapters.matchesTableAdapter();
            this.judgesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.judgesTableAdapter = new UEFA_league.UEFA_leagueDataSetTableAdapters.judgesTableAdapter();
            this.stadiumsTableAdapter = new UEFA_league.UEFA_leagueDataSetTableAdapters.stadiumsTableAdapter();
            this.queryEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarypermonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uEFA_leagueDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stadiumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.judgesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.uEFA_leagueDataSet;
            this.bindingSource1.Position = 0;
            // 
            // uEFA_leagueDataSet
            // 
            this.uEFA_leagueDataSet.DataSetName = "UEFA_leagueDataSet";
            this.uEFA_leagueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playeridDataGridViewTextBoxColumn,
            this.playernameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.nationalityDataGridViewTextBoxColumn,
            this.teamDataGridViewTextBoxColumn,
            this.salarypermonthDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.playersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(709, 253);
            this.dataGridView1.TabIndex = 0;
            // 
            // stadiumsBindingSource
            // 
            this.stadiumsBindingSource.DataMember = "stadiums";
            this.stadiumsBindingSource.DataSource = this.bindingSource1;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "players";
            this.playersBindingSource.DataSource = this.bindingSource1;
            // 
            // playersTableAdapter
            // 
            this.playersTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.playersBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(27, 329);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(263, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.editFormToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(771, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.distributionToolStripMenuItem,
            this.queryEditToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // distributionToolStripMenuItem
            // 
            this.distributionToolStripMenuItem.Name = "distributionToolStripMenuItem";
            this.distributionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.distributionToolStripMenuItem.Text = "Distribution";
            this.distributionToolStripMenuItem.Click += new System.EventHandler(this.distributionToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playersToolStripMenuItem,
            this.teamsToolStripMenuItem,
            this.stadiumsToolStripMenuItem,
            this.matchesToolStripMenuItem,
            this.judgesToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // playersToolStripMenuItem
            // 
            this.playersToolStripMenuItem.Name = "playersToolStripMenuItem";
            this.playersToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.playersToolStripMenuItem.Text = "Players";
            this.playersToolStripMenuItem.Click += new System.EventHandler(this.playersToolStripMenuItem_Click);
            // 
            // teamsToolStripMenuItem
            // 
            this.teamsToolStripMenuItem.Name = "teamsToolStripMenuItem";
            this.teamsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.teamsToolStripMenuItem.Text = "Teams";
            this.teamsToolStripMenuItem.Click += new System.EventHandler(this.teamsToolStripMenuItem_Click);
            // 
            // stadiumsToolStripMenuItem
            // 
            this.stadiumsToolStripMenuItem.Name = "stadiumsToolStripMenuItem";
            this.stadiumsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.stadiumsToolStripMenuItem.Text = "Stadiums";
            this.stadiumsToolStripMenuItem.Click += new System.EventHandler(this.stadiumsToolStripMenuItem_Click);
            // 
            // matchesToolStripMenuItem
            // 
            this.matchesToolStripMenuItem.Name = "matchesToolStripMenuItem";
            this.matchesToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.matchesToolStripMenuItem.Text = "Matches";
            this.matchesToolStripMenuItem.Click += new System.EventHandler(this.matchesToolStripMenuItem_Click);
            // 
            // judgesToolStripMenuItem
            // 
            this.judgesToolStripMenuItem.Name = "judgesToolStripMenuItem";
            this.judgesToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.judgesToolStripMenuItem.Text = "Judges";
            this.judgesToolStripMenuItem.Click += new System.EventHandler(this.judgesToolStripMenuItem_Click);
            // 
            // lable_table_name
            // 
            this.lable_table_name.AutoSize = true;
            this.lable_table_name.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_table_name.Location = new System.Drawing.Point(23, 46);
            this.lable_table_name.Name = "lable_table_name";
            this.lable_table_name.Size = new System.Drawing.Size(73, 24);
            this.lable_table_name.TabIndex = 3;
            this.lable_table_name.Text = "Players";
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataMember = "teams";
            this.teamsBindingSource.DataSource = this.bindingSource1;
            // 
            // teamsTableAdapter
            // 
            this.teamsTableAdapter.ClearBeforeFill = true;
            // 
            // matchesBindingSource
            // 
            this.matchesBindingSource.DataMember = "matches";
            this.matchesBindingSource.DataSource = this.bindingSource1;
            // 
            // matchesTableAdapter
            // 
            this.matchesTableAdapter.ClearBeforeFill = true;
            // 
            // judgesBindingSource
            // 
            this.judgesBindingSource.DataMember = "judges";
            this.judgesBindingSource.DataSource = this.bindingSource1;
            // 
            // judgesTableAdapter
            // 
            this.judgesTableAdapter.ClearBeforeFill = true;
            // 
            // stadiumsTableAdapter
            // 
            this.stadiumsTableAdapter.ClearBeforeFill = true;
            // 
            // queryEditToolStripMenuItem
            // 
            this.queryEditToolStripMenuItem.Name = "queryEditToolStripMenuItem";
            this.queryEditToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.queryEditToolStripMenuItem.Text = "Query Edit";
            this.queryEditToolStripMenuItem.Click += new System.EventHandler(this.queryEditToolStripMenuItem_Click);
            // 
            // playeridDataGridViewTextBoxColumn
            // 
            this.playeridDataGridViewTextBoxColumn.DataPropertyName = "player_id";
            this.playeridDataGridViewTextBoxColumn.HeaderText = "player_id";
            this.playeridDataGridViewTextBoxColumn.Name = "playeridDataGridViewTextBoxColumn";
            // 
            // playernameDataGridViewTextBoxColumn
            // 
            this.playernameDataGridViewTextBoxColumn.DataPropertyName = "player_name";
            this.playernameDataGridViewTextBoxColumn.HeaderText = "player_name";
            this.playernameDataGridViewTextBoxColumn.Name = "playernameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // nationalityDataGridViewTextBoxColumn
            // 
            this.nationalityDataGridViewTextBoxColumn.DataPropertyName = "nationality";
            this.nationalityDataGridViewTextBoxColumn.HeaderText = "nationality";
            this.nationalityDataGridViewTextBoxColumn.Name = "nationalityDataGridViewTextBoxColumn";
            // 
            // teamDataGridViewTextBoxColumn
            // 
            this.teamDataGridViewTextBoxColumn.DataPropertyName = "team";
            this.teamDataGridViewTextBoxColumn.HeaderText = "team";
            this.teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            // 
            // salarypermonthDataGridViewTextBoxColumn
            // 
            this.salarypermonthDataGridViewTextBoxColumn.DataPropertyName = "salary_per_month";
            this.salarypermonthDataGridViewTextBoxColumn.HeaderText = "salary_per_month";
            this.salarypermonthDataGridViewTextBoxColumn.Name = "salarypermonthDataGridViewTextBoxColumn";
            // 
            // editFormToolStripMenuItem
            // 
            this.editFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.editFormToolStripMenuItem.Name = "editFormToolStripMenuItem";
            this.editFormToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.editFormToolStripMenuItem.Text = "Edit form";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(771, 365);
            this.Controls.Add(this.lable_table_name);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Main form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uEFA_leagueDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stadiumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.judgesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private UEFA_leagueDataSet uEFA_leagueDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private UEFA_leagueDataSetTableAdapters.playersTableAdapter playersTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stadiumsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem judgesToolStripMenuItem;
        private System.Windows.Forms.Label lable_table_name;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private UEFA_leagueDataSetTableAdapters.teamsTableAdapter teamsTableAdapter;
        private System.Windows.Forms.BindingSource matchesBindingSource;
        private UEFA_leagueDataSetTableAdapters.matchesTableAdapter matchesTableAdapter;
        private System.Windows.Forms.BindingSource judgesBindingSource;
        private UEFA_leagueDataSetTableAdapters.judgesTableAdapter judgesTableAdapter;
        private System.Windows.Forms.BindingSource stadiumsBindingSource;
        private UEFA_leagueDataSetTableAdapters.stadiumsTableAdapter stadiumsTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem distributionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryEditToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn playeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarypermonthDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem editFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
    }
}

