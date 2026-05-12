namespace AmeenaAppProject
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			tabControlMain = new TabControl();
			tpIndividuals = new TabPage();
			lblIndvTitle = new Label();
			lblIndvName = new Label();
			txtIndvName = new TextBox();
			clbIndvSports = new CheckedListBox();
			clbIndvAcademic = new CheckedListBox();
			cbIndvSpecial = new ComboBox();
			btnIndvAdd = new Button();
			dgvIndividuals = new DataGridView();
			dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
			tpTeams = new TabPage();
			lblTeamTitle = new Label();
			lblTeamNameLabel = new Label();
			txtTeamName = new TextBox();
			txtMember1 = new TextBox();
			txtMember2 = new TextBox();
			txtMember3 = new TextBox();
			txtMember4 = new TextBox();
			txtMember5 = new TextBox();
			clbTeamSports = new CheckedListBox();
			clbTeamAcademic = new CheckedListBox();
			cbTeamSpecial = new ComboBox();
			btnTeamAdd = new Button();
			dgvTeams = new DataGridView();
			dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn18 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn19 = new DataGridViewTextBoxColumn();
			tabPage1 = new TabPage();
			button1 = new Button();
			dataGridView1 = new DataGridView();
			dataGridViewTextBoxColumn20 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn21 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn22 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn23 = new DataGridViewTextBoxColumn();
			label1 = new Label();
			tabPage2 = new TabPage();
			label2 = new Label();
			lblClock = new Label();
			button2 = new Button();
			timer1 = new System.Windows.Forms.Timer(components);
			tabControlMain.SuspendLayout();
			tpIndividuals.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvIndividuals).BeginInit();
			tpTeams.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvTeams).BeginInit();
			tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			tabPage2.SuspendLayout();
			SuspendLayout();
			// 
			// tabControlMain
			// 
			tabControlMain.Controls.Add(tpIndividuals);
			tabControlMain.Controls.Add(tpTeams);
			tabControlMain.Controls.Add(tabPage1);
			tabControlMain.Controls.Add(tabPage2);
			tabControlMain.Dock = DockStyle.Fill;
			tabControlMain.Location = new Point(0, 0);
			tabControlMain.Name = "tabControlMain";
			tabControlMain.SelectedIndex = 0;
			tabControlMain.Size = new Size(1150, 700);
			tabControlMain.TabIndex = 0;
			// 
			// tpIndividuals
			// 
			tpIndividuals.BackColor = Color.Silver;
			tpIndividuals.Controls.Add(lblIndvTitle);
			tpIndividuals.Controls.Add(lblIndvName);
			tpIndividuals.Controls.Add(txtIndvName);
			tpIndividuals.Controls.Add(clbIndvSports);
			tpIndividuals.Controls.Add(clbIndvAcademic);
			tpIndividuals.Controls.Add(cbIndvSpecial);
			tpIndividuals.Controls.Add(btnIndvAdd);
			tpIndividuals.Controls.Add(dgvIndividuals);
			tpIndividuals.Location = new Point(4, 34);
			tpIndividuals.Name = "tpIndividuals";
			tpIndividuals.Size = new Size(1142, 662);
			tpIndividuals.TabIndex = 0;
			tpIndividuals.Text = "نظام الأفراد";
			tpIndividuals.Click += tpIndividuals_Click;
			// 
			// lblIndvTitle
			// 
			lblIndvTitle.BackColor = Color.Silver;
			lblIndvTitle.Dock = DockStyle.Top;
			lblIndvTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
			lblIndvTitle.Location = new Point(0, 0);
			lblIndvTitle.Name = "lblIndvTitle";
			lblIndvTitle.Size = new Size(1142, 50);
			lblIndvTitle.TabIndex = 0;
			lblIndvTitle.Text = "إدارة الفعاليات الفردية";
			lblIndvTitle.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblIndvName
			// 
			lblIndvName.Location = new Point(20, 70);
			lblIndvName.Name = "lblIndvName";
			lblIndvName.Size = new Size(100, 23);
			lblIndvName.TabIndex = 1;
			lblIndvName.Text = "اسم المشارك:";
			lblIndvName.Click += lblIndvName_Click;
			// 
			// txtIndvName
			// 
			txtIndvName.Location = new Point(120, 70);
			txtIndvName.Name = "txtIndvName";
			txtIndvName.Size = new Size(200, 31);
			txtIndvName.TabIndex = 2;
			// 
			// clbIndvSports
			// 
			clbIndvSports.Items.AddRange(new object[] { "سباق الجري 1", "كرة السلة 2", "تمارين 3" });
			clbIndvSports.Location = new Point(20, 110);
			clbIndvSports.Name = "clbIndvSports";
			clbIndvSports.Size = new Size(300, 88);
			clbIndvSports.TabIndex = 3;
			// 
			// clbIndvAcademic
			// 
			clbIndvAcademic.Items.AddRange(new object[] { "البرمجة 4", "الرياضيات 5", "العلوم 6" });
			clbIndvAcademic.Location = new Point(20, 200);
			clbIndvAcademic.Name = "clbIndvAcademic";
			clbIndvAcademic.Size = new Size(300, 88);
			clbIndvAcademic.TabIndex = 4;
			// 
			// cbIndvSpecial
			// 
			cbIndvSpecial.Items.AddRange(new object[] { "فعالية مميزة 7" });
			cbIndvSpecial.Location = new Point(20, 290);
			cbIndvSpecial.Name = "cbIndvSpecial";
			cbIndvSpecial.Size = new Size(200, 33);
			cbIndvSpecial.TabIndex = 5;
			cbIndvSpecial.SelectedIndexChanged += cbIndvSpecial_SelectedIndexChanged;
			// 
			// btnIndvAdd
			// 
			btnIndvAdd.Location = new Point(20, 362);
			btnIndvAdd.Name = "btnIndvAdd";
			btnIndvAdd.Size = new Size(75, 23);
			btnIndvAdd.TabIndex = 6;
			btnIndvAdd.Text = "إضافة";
			// 
			// dgvIndividuals
			// 
			dgvIndividuals.AllowUserToAddRows = false;
			dgvIndividuals.AllowUserToDeleteRows = false;
			dgvIndividuals.BackgroundColor = Color.Snow;
			dgvIndividuals.ColumnHeadersHeight = 34;
			dgvIndividuals.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9 });
			dgvIndividuals.Location = new Point(350, 70);
			dgvIndividuals.Name = "dgvIndividuals";
			dgvIndividuals.ReadOnly = true;
			dgvIndividuals.RowHeadersWidth = 62;
			dgvIndividuals.Size = new Size(750, 500);
			dgvIndividuals.TabIndex = 9;
			// 
			// dataGridViewTextBoxColumn1
			// 
			dataGridViewTextBoxColumn1.HeaderText = "الاسم";
			dataGridViewTextBoxColumn1.MinimumWidth = 8;
			dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			dataGridViewTextBoxColumn1.ReadOnly = true;
			dataGridViewTextBoxColumn1.Width = 150;
			// 
			// dataGridViewTextBoxColumn2
			// 
			dataGridViewTextBoxColumn2.HeaderText = "1";
			dataGridViewTextBoxColumn2.MinimumWidth = 8;
			dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			dataGridViewTextBoxColumn2.ReadOnly = true;
			dataGridViewTextBoxColumn2.Width = 150;
			// 
			// dataGridViewTextBoxColumn3
			// 
			dataGridViewTextBoxColumn3.HeaderText = "2";
			dataGridViewTextBoxColumn3.MinimumWidth = 8;
			dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			dataGridViewTextBoxColumn3.ReadOnly = true;
			dataGridViewTextBoxColumn3.Width = 150;
			// 
			// dataGridViewTextBoxColumn4
			// 
			dataGridViewTextBoxColumn4.HeaderText = "3";
			dataGridViewTextBoxColumn4.MinimumWidth = 8;
			dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			dataGridViewTextBoxColumn4.ReadOnly = true;
			dataGridViewTextBoxColumn4.Width = 150;
			// 
			// dataGridViewTextBoxColumn5
			// 
			dataGridViewTextBoxColumn5.HeaderText = "4";
			dataGridViewTextBoxColumn5.MinimumWidth = 8;
			dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			dataGridViewTextBoxColumn5.ReadOnly = true;
			dataGridViewTextBoxColumn5.Width = 150;
			// 
			// dataGridViewTextBoxColumn6
			// 
			dataGridViewTextBoxColumn6.HeaderText = "5";
			dataGridViewTextBoxColumn6.MinimumWidth = 8;
			dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			dataGridViewTextBoxColumn6.ReadOnly = true;
			dataGridViewTextBoxColumn6.Width = 150;
			// 
			// dataGridViewTextBoxColumn7
			// 
			dataGridViewTextBoxColumn7.HeaderText = "6";
			dataGridViewTextBoxColumn7.MinimumWidth = 8;
			dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			dataGridViewTextBoxColumn7.ReadOnly = true;
			dataGridViewTextBoxColumn7.Width = 150;
			// 
			// dataGridViewTextBoxColumn8
			// 
			dataGridViewTextBoxColumn8.HeaderText = "7";
			dataGridViewTextBoxColumn8.MinimumWidth = 8;
			dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			dataGridViewTextBoxColumn8.ReadOnly = true;
			dataGridViewTextBoxColumn8.Width = 150;
			// 
			// dataGridViewTextBoxColumn9
			// 
			dataGridViewTextBoxColumn9.HeaderText = "المجموع";
			dataGridViewTextBoxColumn9.MinimumWidth = 8;
			dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			dataGridViewTextBoxColumn9.ReadOnly = true;
			dataGridViewTextBoxColumn9.Width = 150;
			// 
			// tpTeams
			// 
			tpTeams.BackColor = Color.Silver;
			tpTeams.Controls.Add(lblTeamTitle);
			tpTeams.Controls.Add(lblTeamNameLabel);
			tpTeams.Controls.Add(txtTeamName);
			tpTeams.Controls.Add(txtMember1);
			tpTeams.Controls.Add(txtMember2);
			tpTeams.Controls.Add(txtMember3);
			tpTeams.Controls.Add(txtMember4);
			tpTeams.Controls.Add(txtMember5);
			tpTeams.Controls.Add(clbTeamSports);
			tpTeams.Controls.Add(clbTeamAcademic);
			tpTeams.Controls.Add(cbTeamSpecial);
			tpTeams.Controls.Add(btnTeamAdd);
			tpTeams.Controls.Add(dgvTeams);
			tpTeams.Location = new Point(4, 34);
			tpTeams.Name = "tpTeams";
			tpTeams.Size = new Size(1142, 662);
			tpTeams.TabIndex = 1;
			tpTeams.Text = "نظام المجموعات";
			// 
			// lblTeamTitle
			// 
			lblTeamTitle.BackColor = Color.Silver;
			lblTeamTitle.Dock = DockStyle.Top;
			lblTeamTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
			lblTeamTitle.Location = new Point(0, 0);
			lblTeamTitle.Name = "lblTeamTitle";
			lblTeamTitle.Size = new Size(1142, 50);
			lblTeamTitle.TabIndex = 0;
			lblTeamTitle.Text = "إدارة المجموعات";
			lblTeamTitle.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblTeamNameLabel
			// 
			lblTeamNameLabel.BackColor = Color.DarkGray;
			lblTeamNameLabel.Location = new Point(20, 70);
			lblTeamNameLabel.Name = "lblTeamNameLabel";
			lblTeamNameLabel.Size = new Size(100, 23);
			lblTeamNameLabel.TabIndex = 1;
			lblTeamNameLabel.Text = "اسم المجموعة:";
			// 
			// txtTeamName
			// 
			txtTeamName.Location = new Point(126, 70);
			txtTeamName.Name = "txtTeamName";
			txtTeamName.Size = new Size(200, 31);
			txtTeamName.TabIndex = 2;
			// 
			// txtMember1
			// 
			txtMember1.Location = new Point(20, 110);
			txtMember1.Name = "txtMember1";
			txtMember1.PlaceholderText = "عضو1";
			txtMember1.Size = new Size(201, 31);
			txtMember1.TabIndex = 3;
			// 
			// txtMember2
			// 
			txtMember2.Location = new Point(20, 141);
			txtMember2.Name = "txtMember2";
			txtMember2.PlaceholderText = "عضو2";
			txtMember2.Size = new Size(201, 31);
			txtMember2.TabIndex = 4;
			// 
			// txtMember3
			// 
			txtMember3.Location = new Point(20, 170);
			txtMember3.Name = "txtMember3";
			txtMember3.PlaceholderText = "عضو3";
			txtMember3.Size = new Size(201, 31);
			txtMember3.TabIndex = 5;
			// 
			// txtMember4
			// 
			txtMember4.Location = new Point(20, 200);
			txtMember4.Name = "txtMember4";
			txtMember4.PlaceholderText = "عضو4";
			txtMember4.Size = new Size(201, 31);
			txtMember4.TabIndex = 6;
			// 
			// txtMember5
			// 
			txtMember5.Location = new Point(20, 230);
			txtMember5.Name = "txtMember5";
			txtMember5.PlaceholderText = "عضو5";
			txtMember5.Size = new Size(201, 31);
			txtMember5.TabIndex = 7;
			// 
			// clbTeamSports
			// 
			clbTeamSports.Items.AddRange(new object[] { "سباق المجموعات 1", "كرة الطائرة 2", "شد الحبل 3" });
			clbTeamSports.Location = new Point(30, 309);
			clbTeamSports.Name = "clbTeamSports";
			clbTeamSports.Size = new Size(180, 88);
			clbTeamSports.TabIndex = 8;
			clbTeamSports.SelectedIndexChanged += clbTeamSports_SelectedIndexChanged;
			// 
			// clbTeamAcademic
			// 
			clbTeamAcademic.Items.AddRange(new object[] { "بحث علمي 4", "ابتكار 5", "ثقافة 6" });
			clbTeamAcademic.Location = new Point(226, 309);
			clbTeamAcademic.Name = "clbTeamAcademic";
			clbTeamAcademic.Size = new Size(192, 88);
			clbTeamAcademic.TabIndex = 9;
			// 
			// cbTeamSpecial
			// 
			cbTeamSpecial.Items.AddRange(new object[] { "مشروع مميز 7" });
			cbTeamSpecial.Location = new Point(68, 419);
			cbTeamSpecial.Name = "cbTeamSpecial";
			cbTeamSpecial.Size = new Size(121, 33);
			cbTeamSpecial.TabIndex = 10;
			// 
			// btnTeamAdd
			// 
			btnTeamAdd.Location = new Point(343, 474);
			btnTeamAdd.Name = "btnTeamAdd";
			btnTeamAdd.Size = new Size(75, 23);
			btnTeamAdd.TabIndex = 11;
			btnTeamAdd.Text = "إضافة";
			// 
			// dgvTeams
			// 
			dgvTeams.AllowUserToAddRows = false;
			dgvTeams.AllowUserToDeleteRows = false;
			dgvTeams.BackgroundColor = Color.WhiteSmoke;
			dgvTeams.ColumnHeadersHeight = 34;
			dgvTeams.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12, dataGridViewTextBoxColumn13, dataGridViewTextBoxColumn14, dataGridViewTextBoxColumn15, dataGridViewTextBoxColumn16, dataGridViewTextBoxColumn17, dataGridViewTextBoxColumn18, dataGridViewTextBoxColumn19 });
			dgvTeams.Location = new Point(450, 70);
			dgvTeams.Name = "dgvTeams";
			dgvTeams.ReadOnly = true;
			dgvTeams.RowHeadersWidth = 62;
			dgvTeams.Size = new Size(650, 500);
			dgvTeams.TabIndex = 14;
			// 
			// dataGridViewTextBoxColumn10
			// 
			dataGridViewTextBoxColumn10.HeaderText = "المجموعة";
			dataGridViewTextBoxColumn10.MinimumWidth = 8;
			dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			dataGridViewTextBoxColumn10.ReadOnly = true;
			dataGridViewTextBoxColumn10.Width = 150;
			// 
			// dataGridViewTextBoxColumn11
			// 
			dataGridViewTextBoxColumn11.HeaderText = "الأعضاء";
			dataGridViewTextBoxColumn11.MinimumWidth = 8;
			dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			dataGridViewTextBoxColumn11.ReadOnly = true;
			dataGridViewTextBoxColumn11.Width = 150;
			// 
			// dataGridViewTextBoxColumn12
			// 
			dataGridViewTextBoxColumn12.HeaderText = "1";
			dataGridViewTextBoxColumn12.MinimumWidth = 8;
			dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
			dataGridViewTextBoxColumn12.ReadOnly = true;
			dataGridViewTextBoxColumn12.Width = 150;
			// 
			// dataGridViewTextBoxColumn13
			// 
			dataGridViewTextBoxColumn13.HeaderText = "2";
			dataGridViewTextBoxColumn13.MinimumWidth = 8;
			dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
			dataGridViewTextBoxColumn13.ReadOnly = true;
			dataGridViewTextBoxColumn13.Width = 150;
			// 
			// dataGridViewTextBoxColumn14
			// 
			dataGridViewTextBoxColumn14.HeaderText = "3";
			dataGridViewTextBoxColumn14.MinimumWidth = 8;
			dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
			dataGridViewTextBoxColumn14.ReadOnly = true;
			dataGridViewTextBoxColumn14.Width = 150;
			// 
			// dataGridViewTextBoxColumn15
			// 
			dataGridViewTextBoxColumn15.HeaderText = "4";
			dataGridViewTextBoxColumn15.MinimumWidth = 8;
			dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
			dataGridViewTextBoxColumn15.ReadOnly = true;
			dataGridViewTextBoxColumn15.Width = 150;
			// 
			// dataGridViewTextBoxColumn16
			// 
			dataGridViewTextBoxColumn16.HeaderText = "5";
			dataGridViewTextBoxColumn16.MinimumWidth = 8;
			dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
			dataGridViewTextBoxColumn16.ReadOnly = true;
			dataGridViewTextBoxColumn16.Width = 150;
			// 
			// dataGridViewTextBoxColumn17
			// 
			dataGridViewTextBoxColumn17.HeaderText = "6";
			dataGridViewTextBoxColumn17.MinimumWidth = 8;
			dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
			dataGridViewTextBoxColumn17.ReadOnly = true;
			dataGridViewTextBoxColumn17.Width = 150;
			// 
			// dataGridViewTextBoxColumn18
			// 
			dataGridViewTextBoxColumn18.HeaderText = "7";
			dataGridViewTextBoxColumn18.MinimumWidth = 8;
			dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
			dataGridViewTextBoxColumn18.ReadOnly = true;
			dataGridViewTextBoxColumn18.Width = 150;
			// 
			// dataGridViewTextBoxColumn19
			// 
			dataGridViewTextBoxColumn19.HeaderText = "المجموع";
			dataGridViewTextBoxColumn19.MinimumWidth = 8;
			dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
			dataGridViewTextBoxColumn19.ReadOnly = true;
			dataGridViewTextBoxColumn19.Width = 150;
			// 
			// tabPage1
			// 
			tabPage1.BackColor = Color.Silver;
			tabPage1.Controls.Add(button1);
			tabPage1.Controls.Add(dataGridView1);
			tabPage1.Controls.Add(label1);
			tabPage1.Location = new Point(4, 34);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(1142, 662);
			tabPage1.TabIndex = 2;
			tabPage1.Text = "النتائج النهائية";
			tabPage1.Click += tabPage1_Click;
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(52, 152, 219);
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			button1.ForeColor = Color.White;
			button1.Location = new Point(445, 530);
			button1.Name = "button1";
			button1.Size = new Size(250, 55);
			button1.TabIndex = 2;
			button1.Text = "عرض النتائج بالترتيب";
			button1.UseVisualStyleBackColor = false;
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView1.BackgroundColor = Color.Snow;
			dataGridView1.BorderStyle = BorderStyle.None;
			dataGridView1.ColumnHeadersHeight = 45;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn20, dataGridViewTextBoxColumn21, dataGridViewTextBoxColumn22, dataGridViewTextBoxColumn23 });
			dataGridView1.Location = new Point(50, 85);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersVisible = false;
			dataGridView1.RowHeadersWidth = 62;
			dataGridView1.Size = new Size(1040, 420);
			dataGridView1.TabIndex = 1;
			// 
			// dataGridViewTextBoxColumn20
			// 
			dataGridViewTextBoxColumn20.HeaderText = "اسم الفرد أو المجموعة";
			dataGridViewTextBoxColumn20.MinimumWidth = 8;
			dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
			dataGridViewTextBoxColumn20.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn21
			// 
			dataGridViewTextBoxColumn21.HeaderText = "التصنيف (فرد / مجموعة)";
			dataGridViewTextBoxColumn21.MinimumWidth = 8;
			dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
			dataGridViewTextBoxColumn21.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn22
			// 
			dataGridViewTextBoxColumn22.HeaderText = "عدد النقاط";
			dataGridViewTextBoxColumn22.MinimumWidth = 8;
			dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
			dataGridViewTextBoxColumn22.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn23
			// 
			dataGridViewTextBoxColumn23.HeaderText = "المركز";
			dataGridViewTextBoxColumn23.MinimumWidth = 8;
			dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
			dataGridViewTextBoxColumn23.ReadOnly = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
			label1.ForeColor = Color.DarkSlateBlue;
			label1.Location = new Point(420, 25);
			label1.Name = "label1";
			label1.Size = new Size(397, 60);
			label1.TabIndex = 0;
			label1.Text = "صفحة النتائج النهائية";
			// 
			// tabPage2
			// 
			tabPage2.BackColor = Color.DarkSalmon;
			tabPage2.Controls.Add(label2);
			tabPage2.Controls.Add(lblClock);
			tabPage2.Controls.Add(button2);
			tabPage2.Location = new Point(4, 34);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(1142, 662);
			tabPage2.TabIndex = 3;
			tabPage2.Text = "شاشة البداية";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Silver;
			label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = SystemColors.ActiveCaptionText;
			label2.Location = new Point(453, 3);
			label2.Name = "label2";
			label2.Size = new Size(437, 48);
			label2.TabIndex = 2;
			label2.Text = "نظام إدارة البطولات الطلابية";
			// 
			// lblClock
			// 
			lblClock.AutoSize = true;
			lblClock.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblClock.Location = new Point(669, 303);
			lblClock.Name = "lblClock";
			lblClock.Size = new Size(115, 48);
			lblClock.TabIndex = 1;
			lblClock.Text = "label2";
			// 
			// button2
			// 
			button2.Location = new Point(672, 429);
			button2.Name = "button2";
			button2.Size = new Size(112, 34);
			button2.TabIndex = 0;
			button2.Text = "الدخول للنظام";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// timer1
			// 
			timer1.Interval = 1000;
			timer1.Tick += timer1_Tick;
			// 
			// Form1
			// 
			ClientSize = new Size(1150, 700);
			Controls.Add(tabControlMain);
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "نظام إدارة الفعاليات الموحد";
			Load += Form1_Load;
			tabControlMain.ResumeLayout(false);
			tpIndividuals.ResumeLayout(false);
			tpIndividuals.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvIndividuals).EndInit();
			tpTeams.ResumeLayout(false);
			tpTeams.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvTeams).EndInit();
			tabPage1.ResumeLayout(false);
			tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			tabPage2.ResumeLayout(false);
			tabPage2.PerformLayout();
			ResumeLayout(false);

		}

		#endregion

		private TabControl tabControlMain;
        private TabPage tpIndividuals;
        private TabPage tpTeams;

        private Label lblIndvTitle;
        private Label lblTeamTitle;
        private Label lblIndvName;
        private Label lblTeamNameLabel;

        private TextBox txtIndvName;
        private TextBox txtTeamName;
        private TextBox txtMember1, txtMember2, txtMember3, txtMember4, txtMember5;

        private CheckedListBox clbIndvSports;
        private CheckedListBox clbIndvAcademic;
        private CheckedListBox clbTeamSports;
        private CheckedListBox clbTeamAcademic;

        private ComboBox cbIndvSpecial;
        private ComboBox cbTeamSpecial;

        private Button btnIndvAdd;

        private Button btnTeamAdd;

        private DataGridView dgvIndividuals;
        private DataGridView dgvTeams;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private TabPage tabPage1;
        private Label label1;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
		private TabPage tabPage2;
		private Button button2;
		private System.Windows.Forms.Timer timer1;
		private Label lblClock;
		private Label label2;
	}
}