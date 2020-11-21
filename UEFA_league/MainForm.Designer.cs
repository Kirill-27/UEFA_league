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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stadiumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distributionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stadiumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.judgesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byTeamAndNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bySurnameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lable_table_name = new System.Windows.Forms.Label();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.judgesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.filter_st1 = new System.Windows.Forms.TextBox();
            this.filter_fn1 = new System.Windows.Forms.TextBox();
            this.filter1_button = new System.Windows.Forms.Button();
            this.filter2_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.search1_but = new System.Windows.Forms.Button();
            this.search2_but = new System.Windows.Forms.Button();
            this.search3_but = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uEFA_leagueDataSet = new UEFA_league.UEFA_leagueDataSet();
            this.playeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarypermonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playersTableAdapter = new UEFA_league.UEFA_leagueDataSetTableAdapters.playersTableAdapter();
            this.teamsTableAdapter = new UEFA_league.UEFA_leagueDataSetTableAdapters.teamsTableAdapter();
            this.matchesTableAdapter = new UEFA_league.UEFA_leagueDataSetTableAdapters.matchesTableAdapter();
            this.judgesTableAdapter = new UEFA_league.UEFA_leagueDataSetTableAdapters.judgesTableAdapter();
            this.stadiumsTableAdapter = new UEFA_league.UEFA_leagueDataSetTableAdapters.stadiumsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stadiumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.judgesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uEFA_leagueDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(688, 253);
            this.dataGridView1.TabIndex = 0;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "players";
            this.playersBindingSource.DataSource = this.bindingSource1;
            // 
            // stadiumsBindingSource
            // 
            this.stadiumsBindingSource.DataMember = "stadiums";
            this.stadiumsBindingSource.DataSource = this.bindingSource1;
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
            this.bindingNavigator1.Location = new System.Drawing.Point(12, 338);
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
            this.editFormToolStripMenuItem,
            this.sortToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            this.distributionToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.distributionToolStripMenuItem.Text = "Distribution";
            this.distributionToolStripMenuItem.Click += new System.EventHandler(this.distributionToolStripMenuItem_Click);
            // 
            // queryEditToolStripMenuItem
            // 
            this.queryEditToolStripMenuItem.Name = "queryEditToolStripMenuItem";
            this.queryEditToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.queryEditToolStripMenuItem.Text = "Query Edit";
            this.queryEditToolStripMenuItem.Click += new System.EventHandler(this.queryEditToolStripMenuItem_Click);
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
            // editFormToolStripMenuItem
            // 
            this.editFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.editFormToolStripMenuItem.Name = "editFormToolStripMenuItem";
            this.editFormToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.editFormToolStripMenuItem.Text = "Edit form";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byIdToolStripMenuItem,
            this.byTeamAndNumberToolStripMenuItem,
            this.bySurnameToolStripMenuItem});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.sortToolStripMenuItem.Text = "Sort players";
            // 
            // byIdToolStripMenuItem
            // 
            this.byIdToolStripMenuItem.Name = "byIdToolStripMenuItem";
            this.byIdToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.byIdToolStripMenuItem.Text = "By id";
            this.byIdToolStripMenuItem.Click += new System.EventHandler(this.byAgeToolStripMenuItem_Click);
            // 
            // byTeamAndNumberToolStripMenuItem
            // 
            this.byTeamAndNumberToolStripMenuItem.Name = "byTeamAndNumberToolStripMenuItem";
            this.byTeamAndNumberToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.byTeamAndNumberToolStripMenuItem.Text = "By team and number ";
            this.byTeamAndNumberToolStripMenuItem.Click += new System.EventHandler(this.byTeamAndNumberToolStripMenuItem_Click);
            // 
            // bySurnameToolStripMenuItem
            // 
            this.bySurnameToolStripMenuItem.Name = "bySurnameToolStripMenuItem";
            this.bySurnameToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.bySurnameToolStripMenuItem.Text = "By surname";
            this.bySurnameToolStripMenuItem.Click += new System.EventHandler(this.bySurnameToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.searchToolStripMenuItem.Text = "Make a schedule";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // lable_table_name
            // 
            this.lable_table_name.AutoSize = true;
            this.lable_table_name.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_table_name.Location = new System.Drawing.Point(23, 46);
            this.lable_table_name.Name = "lable_table_name";
            this.lable_table_name.Size = new System.Drawing.Size(80, 24);
            this.lable_table_name.TabIndex = 3;
            this.lable_table_name.Text = "Players";
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataMember = "teams";
            this.teamsBindingSource.DataSource = this.bindingSource1;
            // 
            // matchesBindingSource
            // 
            this.matchesBindingSource.DataMember = "matches";
            this.matchesBindingSource.DataSource = this.bindingSource1;
            // 
            // judgesBindingSource
            // 
            this.judgesBindingSource.DataMember = "judges";
            this.judgesBindingSource.DataSource = this.bindingSource1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(708, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(706, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filtration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(817, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "and";
            // 
            // filter_st1
            // 
            this.filter_st1.Location = new System.Drawing.Point(711, 315);
            this.filter_st1.Name = "filter_st1";
            this.filter_st1.Size = new System.Drawing.Size(100, 20);
            this.filter_st1.TabIndex = 8;
            // 
            // filter_fn1
            // 
            this.filter_fn1.Location = new System.Drawing.Point(872, 315);
            this.filter_fn1.Name = "filter_fn1";
            this.filter_fn1.Size = new System.Drawing.Size(100, 20);
            this.filter_fn1.TabIndex = 9;
            // 
            // filter1_button
            // 
            this.filter1_button.Location = new System.Drawing.Point(710, 265);
            this.filter1_button.Name = "filter1_button";
            this.filter1_button.Size = new System.Drawing.Size(75, 23);
            this.filter1_button.TabIndex = 10;
            this.filter1_button.Text = "Age";
            this.filter1_button.UseVisualStyleBackColor = true;
            this.filter1_button.Click += new System.EventHandler(this.filter1_button_Click);
            // 
            // filter2_button
            // 
            this.filter2_button.Location = new System.Drawing.Point(792, 265);
            this.filter2_button.Name = "filter2_button";
            this.filter2_button.Size = new System.Drawing.Size(75, 23);
            this.filter2_button.TabIndex = 15;
            this.filter2_button.Text = "Salary";
            this.filter2_button.UseVisualStyleBackColor = true;
            this.filter2_button.Click += new System.EventHandler(this.filter2_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(787, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "value between";
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.Location = new System.Drawing.Point(712, 125);
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(132, 20);
            this.SearchTextbox.TabIndex = 17;
            // 
            // search1_but
            // 
            this.search1_but.Location = new System.Drawing.Point(711, 82);
            this.search1_but.Name = "search1_but";
            this.search1_but.Size = new System.Drawing.Size(75, 23);
            this.search1_but.TabIndex = 18;
            this.search1_but.Text = "Surname";
            this.search1_but.UseVisualStyleBackColor = true;
            this.search1_but.Click += new System.EventHandler(this.button1_Click);
            // 
            // search2_but
            // 
            this.search2_but.Location = new System.Drawing.Point(793, 82);
            this.search2_but.Name = "search2_but";
            this.search2_but.Size = new System.Drawing.Size(75, 23);
            this.search2_but.TabIndex = 19;
            this.search2_but.Text = "Number";
            this.search2_but.UseVisualStyleBackColor = true;
            this.search2_but.Click += new System.EventHandler(this.button2_Click);
            // 
            // search3_but
            // 
            this.search3_but.Location = new System.Drawing.Point(874, 82);
            this.search3_but.Name = "search3_but";
            this.search3_but.Size = new System.Drawing.Size(99, 23);
            this.search3_but.TabIndex = 20;
            this.search3_but.Text = "By all text fields";
            this.search3_but.UseVisualStyleBackColor = true;
            this.search3_but.Click += new System.EventHandler(this.button3_Click);
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
            // playersTableAdapter
            // 
            this.playersTableAdapter.ClearBeforeFill = true;
            // 
            // teamsTableAdapter
            // 
            this.teamsTableAdapter.ClearBeforeFill = true;
            // 
            // matchesTableAdapter
            // 
            this.matchesTableAdapter.ClearBeforeFill = true;
            // 
            // judgesTableAdapter
            // 
            this.judgesTableAdapter.ClearBeforeFill = true;
            // 
            // stadiumsTableAdapter
            // 
            this.stadiumsTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(984, 385);
            this.Controls.Add(this.search3_but);
            this.Controls.Add(this.search2_but);
            this.Controls.Add(this.search1_but);
            this.Controls.Add(this.SearchTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.filter2_button);
            this.Controls.Add(this.filter1_button);
            this.Controls.Add(this.filter_fn1);
            this.Controls.Add(this.filter_st1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lable_table_name);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Main form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stadiumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.judgesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uEFA_leagueDataSet)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byTeamAndNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bySurnameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byIdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox filter_st1;
        private System.Windows.Forms.TextBox filter_fn1;
        private System.Windows.Forms.Button filter1_button;
        private System.Windows.Forms.Button filter2_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SearchTextbox;
        private System.Windows.Forms.Button search1_but;
        private System.Windows.Forms.Button search2_but;
        private System.Windows.Forms.Button search3_but;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
    }
}

