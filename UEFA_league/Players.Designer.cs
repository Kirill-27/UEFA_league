namespace UEFA_league
{
    partial class Players
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Players));
            System.Windows.Forms.Label team_idLabel;
            System.Windows.Forms.Label team_nameLabel;
            System.Windows.Forms.Label stadium_idLabel;
            System.Windows.Forms.Label date_of_creationLabel;
            System.Windows.Forms.Label budgetLabel;
            System.Windows.Forms.Label home_uniformLabel;
            System.Windows.Forms.Label guest_uniformLabel;
            this.uEFA_leagueDataSet = new UEFA_league.UEFA_leagueDataSet();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamsTableAdapter = new UEFA_league.UEFA_leagueDataSetTableAdapters.teamsTableAdapter();
            this.tableAdapterManager = new UEFA_league.UEFA_leagueDataSetTableAdapters.TableAdapterManager();
            this.teamsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.teamsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.team_idTextBox = new System.Windows.Forms.TextBox();
            this.team_nameTextBox = new System.Windows.Forms.TextBox();
            this.stadium_idTextBox = new System.Windows.Forms.TextBox();
            this.date_of_creationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.budgetTextBox = new System.Windows.Forms.TextBox();
            this.home_uniformTextBox = new System.Windows.Forms.TextBox();
            this.guest_uniformTextBox = new System.Windows.Forms.TextBox();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playersTableAdapter = new UEFA_league.UEFA_leagueDataSetTableAdapters.playersTableAdapter();
            this.playersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            team_idLabel = new System.Windows.Forms.Label();
            team_nameLabel = new System.Windows.Forms.Label();
            stadium_idLabel = new System.Windows.Forms.Label();
            date_of_creationLabel = new System.Windows.Forms.Label();
            budgetLabel = new System.Windows.Forms.Label();
            home_uniformLabel = new System.Windows.Forms.Label();
            guest_uniformLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uEFA_leagueDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingNavigator)).BeginInit();
            this.teamsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uEFA_leagueDataSet
            // 
            this.uEFA_leagueDataSet.DataSetName = "UEFA_leagueDataSet";
            this.uEFA_leagueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataMember = "teams";
            this.teamsBindingSource.DataSource = this.uEFA_leagueDataSet;
            // 
            // teamsTableAdapter
            // 
            this.teamsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.judgesTableAdapter = null;
            this.tableAdapterManager.matchesTableAdapter = null;
            this.tableAdapterManager.playersTableAdapter = this.playersTableAdapter;
            this.tableAdapterManager.stadiumsTableAdapter = null;
            this.tableAdapterManager.teamsTableAdapter = this.teamsTableAdapter;
            this.tableAdapterManager.UpdateOrder = UEFA_league.UEFA_leagueDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // teamsBindingNavigator
            // 
            this.teamsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.teamsBindingNavigator.BindingSource = this.teamsBindingSource;
            this.teamsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.teamsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.teamsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.teamsBindingNavigatorSaveItem});
            this.teamsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.teamsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.teamsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.teamsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.teamsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.teamsBindingNavigator.Name = "teamsBindingNavigator";
            this.teamsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.teamsBindingNavigator.Size = new System.Drawing.Size(725, 25);
            this.teamsBindingNavigator.TabIndex = 0;
            this.teamsBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // teamsBindingNavigatorSaveItem
            // 
            this.teamsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.teamsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("teamsBindingNavigatorSaveItem.Image")));
            this.teamsBindingNavigatorSaveItem.Name = "teamsBindingNavigatorSaveItem";
            this.teamsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.teamsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.teamsBindingNavigatorSaveItem.Click += new System.EventHandler(this.teamsBindingNavigatorSaveItem_Click);
            // 
            // team_idLabel
            // 
            team_idLabel.AutoSize = true;
            team_idLabel.Location = new System.Drawing.Point(72, 61);
            team_idLabel.Name = "team_idLabel";
            team_idLabel.Size = new System.Drawing.Size(44, 13);
            team_idLabel.TabIndex = 1;
            team_idLabel.Text = "team id:";
            // 
            // team_idTextBox
            // 
            this.team_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamsBindingSource, "team_id", true));
            this.team_idTextBox.Location = new System.Drawing.Point(162, 58);
            this.team_idTextBox.Name = "team_idTextBox";
            this.team_idTextBox.Size = new System.Drawing.Size(200, 20);
            this.team_idTextBox.TabIndex = 2;
            // 
            // team_nameLabel
            // 
            team_nameLabel.AutoSize = true;
            team_nameLabel.Location = new System.Drawing.Point(72, 87);
            team_nameLabel.Name = "team_nameLabel";
            team_nameLabel.Size = new System.Drawing.Size(62, 13);
            team_nameLabel.TabIndex = 3;
            team_nameLabel.Text = "team name:";
            // 
            // team_nameTextBox
            // 
            this.team_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamsBindingSource, "team_name", true));
            this.team_nameTextBox.Location = new System.Drawing.Point(162, 84);
            this.team_nameTextBox.Name = "team_nameTextBox";
            this.team_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.team_nameTextBox.TabIndex = 4;
            // 
            // stadium_idLabel
            // 
            stadium_idLabel.AutoSize = true;
            stadium_idLabel.Location = new System.Drawing.Point(72, 113);
            stadium_idLabel.Name = "stadium_idLabel";
            stadium_idLabel.Size = new System.Drawing.Size(57, 13);
            stadium_idLabel.TabIndex = 5;
            stadium_idLabel.Text = "stadium id:";
            // 
            // stadium_idTextBox
            // 
            this.stadium_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamsBindingSource, "stadium_id", true));
            this.stadium_idTextBox.Location = new System.Drawing.Point(162, 110);
            this.stadium_idTextBox.Name = "stadium_idTextBox";
            this.stadium_idTextBox.Size = new System.Drawing.Size(200, 20);
            this.stadium_idTextBox.TabIndex = 6;
            // 
            // date_of_creationLabel
            // 
            date_of_creationLabel.AutoSize = true;
            date_of_creationLabel.Location = new System.Drawing.Point(72, 140);
            date_of_creationLabel.Name = "date_of_creationLabel";
            date_of_creationLabel.Size = new System.Drawing.Size(84, 13);
            date_of_creationLabel.TabIndex = 7;
            date_of_creationLabel.Text = "date of creation:";
            // 
            // date_of_creationDateTimePicker
            // 
            this.date_of_creationDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.teamsBindingSource, "date_of_creation", true));
            this.date_of_creationDateTimePicker.Location = new System.Drawing.Point(162, 136);
            this.date_of_creationDateTimePicker.Name = "date_of_creationDateTimePicker";
            this.date_of_creationDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_of_creationDateTimePicker.TabIndex = 8;
            // 
            // budgetLabel
            // 
            budgetLabel.AutoSize = true;
            budgetLabel.Location = new System.Drawing.Point(374, 83);
            budgetLabel.Name = "budgetLabel";
            budgetLabel.Size = new System.Drawing.Size(43, 13);
            budgetLabel.TabIndex = 9;
            budgetLabel.Text = "budget:";
            // 
            // budgetTextBox
            // 
            this.budgetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamsBindingSource, "budget", true));
            this.budgetTextBox.Location = new System.Drawing.Point(464, 80);
            this.budgetTextBox.Name = "budgetTextBox";
            this.budgetTextBox.Size = new System.Drawing.Size(200, 20);
            this.budgetTextBox.TabIndex = 10;
            // 
            // home_uniformLabel
            // 
            home_uniformLabel.AutoSize = true;
            home_uniformLabel.Location = new System.Drawing.Point(374, 109);
            home_uniformLabel.Name = "home_uniformLabel";
            home_uniformLabel.Size = new System.Drawing.Size(73, 13);
            home_uniformLabel.TabIndex = 11;
            home_uniformLabel.Text = "home uniform:";
            // 
            // home_uniformTextBox
            // 
            this.home_uniformTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamsBindingSource, "home_uniform", true));
            this.home_uniformTextBox.Location = new System.Drawing.Point(464, 106);
            this.home_uniformTextBox.Name = "home_uniformTextBox";
            this.home_uniformTextBox.Size = new System.Drawing.Size(200, 20);
            this.home_uniformTextBox.TabIndex = 12;
            // 
            // guest_uniformLabel
            // 
            guest_uniformLabel.AutoSize = true;
            guest_uniformLabel.Location = new System.Drawing.Point(374, 135);
            guest_uniformLabel.Name = "guest_uniformLabel";
            guest_uniformLabel.Size = new System.Drawing.Size(73, 13);
            guest_uniformLabel.TabIndex = 13;
            guest_uniformLabel.Text = "guest uniform:";
            // 
            // guest_uniformTextBox
            // 
            this.guest_uniformTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamsBindingSource, "guest_uniform", true));
            this.guest_uniformTextBox.Location = new System.Drawing.Point(464, 132);
            this.guest_uniformTextBox.Name = "guest_uniformTextBox";
            this.guest_uniformTextBox.Size = new System.Drawing.Size(200, 20);
            this.guest_uniformTextBox.TabIndex = 14;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "FK__players__team__173876EA";
            this.playersBindingSource.DataSource = this.teamsBindingSource;
            // 
            // playersTableAdapter
            // 
            this.playersTableAdapter.ClearBeforeFill = true;
            // 
            // playersDataGridView
            // 
            this.playersDataGridView.AutoGenerateColumns = false;
            this.playersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.playersDataGridView.DataSource = this.playersBindingSource;
            this.playersDataGridView.Location = new System.Drawing.Point(59, 178);
            this.playersDataGridView.Name = "playersDataGridView";
            this.playersDataGridView.Size = new System.Drawing.Size(623, 157);
            this.playersDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "player_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "player_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "player_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "player_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "surname";
            this.dataGridViewTextBoxColumn3.HeaderText = "surname";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "number";
            this.dataGridViewTextBoxColumn4.HeaderText = "number";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "age";
            this.dataGridViewTextBoxColumn5.HeaderText = "age";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "nationality";
            this.dataGridViewTextBoxColumn6.HeaderText = "nationality";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "team";
            this.dataGridViewTextBoxColumn7.HeaderText = "team";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "salary_per_month";
            this.dataGridViewTextBoxColumn8.HeaderText = "salary_per_month";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // Players
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(725, 370);
            this.Controls.Add(this.playersDataGridView);
            this.Controls.Add(team_idLabel);
            this.Controls.Add(this.team_idTextBox);
            this.Controls.Add(team_nameLabel);
            this.Controls.Add(this.team_nameTextBox);
            this.Controls.Add(stadium_idLabel);
            this.Controls.Add(this.stadium_idTextBox);
            this.Controls.Add(date_of_creationLabel);
            this.Controls.Add(this.date_of_creationDateTimePicker);
            this.Controls.Add(budgetLabel);
            this.Controls.Add(this.budgetTextBox);
            this.Controls.Add(home_uniformLabel);
            this.Controls.Add(this.home_uniformTextBox);
            this.Controls.Add(guest_uniformLabel);
            this.Controls.Add(this.guest_uniformTextBox);
            this.Controls.Add(this.teamsBindingNavigator);
            this.Name = "Players";
            this.Text = "Distribution by teams";
            this.Load += new System.EventHandler(this.Players_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uEFA_leagueDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingNavigator)).EndInit();
            this.teamsBindingNavigator.ResumeLayout(false);
            this.teamsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UEFA_leagueDataSet uEFA_leagueDataSet;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private UEFA_leagueDataSetTableAdapters.teamsTableAdapter teamsTableAdapter;
        private UEFA_leagueDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator teamsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton teamsBindingNavigatorSaveItem;
        private UEFA_leagueDataSetTableAdapters.playersTableAdapter playersTableAdapter;
        private System.Windows.Forms.TextBox team_idTextBox;
        private System.Windows.Forms.TextBox team_nameTextBox;
        private System.Windows.Forms.TextBox stadium_idTextBox;
        private System.Windows.Forms.DateTimePicker date_of_creationDateTimePicker;
        private System.Windows.Forms.TextBox budgetTextBox;
        private System.Windows.Forms.TextBox home_uniformTextBox;
        private System.Windows.Forms.TextBox guest_uniformTextBox;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private System.Windows.Forms.DataGridView playersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}