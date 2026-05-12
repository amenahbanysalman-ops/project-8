using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AmeenaAppProject
{
	public partial class Form1 : Form
	{
		// الثوابت والقيود (Constants)
		const int MaxIndividuals = 20;
		const int MaxTeams = 4;

		// القواميس لتتبع عدد المشاركين في كل فعالية (1 إلى 7)
		Dictionary<int, List<string>> individualTracker = new Dictionary<int, List<string>>();
		Dictionary<int, int> teamTracker = new Dictionary<int, int>();

		public Form1()
		{
			InitializeComponent();
			InitializeSystem();
		}

		private void InitializeSystem()
		{
			// تهيئة المتتبعات لـ 7 فعاليات (3 رياضة + 3 أكاديمي + 1 مميزة)
			for (int i = 1; i <= 7; i++)
			{
				individualTracker[i] = new List<string>();
				teamTracker[i] = 0;
			}

			// ربط الأحداث (Events Wiring)
			btnIndvAdd.Click += BtnIndvAdd_Click;
			btnTeamAdd.Click += BtnTeamAdd_Click;
			button1.Click += Button1_Click; // زر عرض النتائج النهائية في التبويب الرئيسي
			cbIndvSpecial.SelectedIndexChanged += CbIndvSpecialChanged;
			cbTeamSpecial.SelectedIndexChanged += CbTeamSpecialChanged;
		}

		// ================= عرض النتائج النهائية والترتيب =================

		private void Button1_Click(object sender, EventArgs e)
		{
			// مسح الجدول الحالي في تبويب النتائج (dataGridView1)
			dataGridView1.Rows.Clear();

			List<ResultItem> allResults = new List<ResultItem>();

			// 1. جلب بيانات الأفراد من dgvIndividuals وترتيبهم
			foreach (DataGridViewRow row in dgvIndividuals.Rows)
			{
				if (row.IsNewRow) continue;

				string name = row.Cells[0].Value?.ToString();
				if (string.IsNullOrEmpty(name)) continue;

				int points = 0;
				int.TryParse(row.Cells[8].Value?.ToString(), out points);

				allResults.Add(new ResultItem
				{
					Name = name,
					Type = "فرد",
					Points = points
				});
			}

			// 2. جلب بيانات المجموعات من dgvTeams
			foreach (DataGridViewRow row in dgvTeams.Rows)
			{
				if (row.IsNewRow) continue;

				string name = row.Cells[0].Value?.ToString();
				if (string.IsNullOrEmpty(name)) continue;

				int points = 0;
				int.TryParse(row.Cells[9].Value?.ToString(), out points);

				allResults.Add(new ResultItem
				{
					Name = name,
					Type = "مجموعة",
					Points = points
				});
			}

			// 3. الترتيب من الأعلى للأقل بناءً على النقاط (Order By descending)
			var sorted = allResults
				.OrderByDescending(x => x.Points)
				.ToList();

			// 4. عرض النتائج في dataGridView1 مع إضافة رقم المركز
			int rank = 1;
			foreach (var item in sorted)
			{
				dataGridView1.Rows.Add(
					item.Name,
					item.Type,
					item.Points,
					rank
				);
				rank++;
			}

			if (sorted.Count == 0)
			{
				MessageBox.Show("لا توجد نتائج لعرضها حالياً. قم بإضافة مشاركين أولاً.");
			}
		}

		// ================= التحكم في الواجهة (الفعالية المميزة) =================

		private void CbIndvSpecialChanged(object sender, EventArgs e)
		{
			if (cbIndvSpecial.SelectedIndex != -1)
			{
				clbIndvSports.Enabled = false;
				clbIndvAcademic.Enabled = false;
				ClearIndividualChecks();
			}
			else
			{
				clbIndvSports.Enabled = true;
				clbIndvAcademic.Enabled = true;
			}
		}

		private void CbTeamSpecialChanged(object sender, EventArgs e)
		{
			if (cbTeamSpecial.SelectedIndex != -1)
			{
				clbTeamSports.Enabled = false;
				clbTeamAcademic.Enabled = false;
				ClearTeamChecks();
			}
			else
			{
				clbTeamSports.Enabled = true;
				clbTeamAcademic.Enabled = true;
			}
		}

		// ================= إضافة الأفراد (قيد 20 فرد) =================

		private void BtnIndvAdd_Click(object sender, EventArgs e)
		{
			// التأكد من عدم تجاوز الحد الأقصى للأفراد
			if (dgvIndividuals.Rows.Count >= MaxIndividuals)
			{
				MessageBox.Show($"عذراً، تم الوصول للحد الأقصى للمشاركين ({MaxIndividuals} فرد)");
				return;
			}

			string name = txtIndvName.Text.Trim();
			if (string.IsNullOrEmpty(name) || !Regex.IsMatch(name, @"^[a-zA-Z\u0600-\u06FF\s]+$") || name.Length < 2)
			{
				MessageBox.Show("يرجى إدخال اسم صحيح (حرفين على الأقل)");
				return;
			}

			List<int> events = GetSelectedIndividualEvents();
			if (events.Count == 0)
			{
				MessageBox.Show("يرجى اختيار فعالية واحدة على الأقل");
				return;
			}

			if (events.Count > 5)
			{
				MessageBox.Show("لا يمكن اختيار أكثر من 5 فعاليات للفرد الواحد");
				return;
			}

			object[] rowData = new object[9];
			rowData[0] = name;
			int totalPoints = 0;

			if (events.Contains(7)) // الفعالية المميزة (50 نقطة مباشرة)
			{
				individualTracker[7].Add(name);
				rowData[7] = individualTracker[7].Count;
				totalPoints = 50;
			}
			else
			{
				foreach (int ev in events)
				{
					individualTracker[ev].Add(name);
					int rank = individualTracker[ev].Count;
					int points = Math.Max(0, 21 - rank);
					totalPoints += points;
					rowData[ev] = rank; // وضع الترتيب في العمود المناسب
				}
			}

			rowData[8] = totalPoints;
			dgvIndividuals.Rows.Add(rowData);
			ClearAllFields();
		}

		// ================= إضافة المجموعات (قيد 4 فرق و 5 أعضاء مكتملين) =================

		private void BtnTeamAdd_Click(object sender, EventArgs e)
		{
			// التأكد من عدم تجاوز الحد الأقصى للمجموعات
			if (dgvTeams.Rows.Count >= MaxTeams)
			{
				MessageBox.Show($"عذراً، تم الوصول للحد الأقصى للمجموعات ({MaxTeams} فرق)");
				return;
			}

			// التأكد من وجود اسم الفريق واكتمال كافة الأعضاء الخمسة
			TextBox[] memberTextBoxes = { txtMember1, txtMember2, txtMember3, txtMember4, txtMember5 };
			bool allMembersEntered = memberTextBoxes.All(tb => !string.IsNullOrWhiteSpace(tb.Text));

			if (string.IsNullOrWhiteSpace(txtTeamName.Text) || !allMembersEntered)
			{
				MessageBox.Show("يرجى إدخال اسم الفريق وجميع الأعضاء الخمسة. لا يمكن ترك حقل عضو فارغ.");
				return;
			}

			List<int> events = GetSelectedTeamEvents();
			if (events.Count == 0)
			{
				MessageBox.Show("يرجى اختيار فعالية واحدة على الأقل للمجموعة");
				return;
			}

			object[] rowData = new object[10];
			rowData[0] = txtTeamName.Text.Trim();
			rowData[1] = $"{txtMember1.Text}, {txtMember2.Text}, {txtMember3.Text}, {txtMember4.Text}, {txtMember5.Text}";

			int totalPoints = 0;

			if (events.Contains(7)) // الفعالية المميزة للمجموعات
			{
				teamTracker[7]++;
				rowData[8] = teamTracker[7];
				totalPoints = 50;
			}
			else
			{
				foreach (int ev in events)
				{
					teamTracker[ev]++;
					int rank = teamTracker[ev];
					// منطق نقاط المجموعات: 1=20, 2=15, 3=10, 4=5
					int points = (rank == 1) ? 20 : (rank == 2) ? 15 : (rank == 3) ? 10 : (rank == 4) ? 5 : 0;
					totalPoints += points;
					rowData[ev + 1] = rank;
				}
			}

			rowData[9] = totalPoints;
			dgvTeams.Rows.Add(rowData);
			ClearAllFields();
		}

		// ================= أدوات المساعدة (Helpers) =================

		private List<int> GetSelectedIndividualEvents()
		{
			if (cbIndvSpecial.SelectedIndex != -1) return new List<int> { 7 };

			List<int> list = new List<int>();
			for (int i = 0; i < clbIndvSports.Items.Count; i++)
				if (clbIndvSports.GetItemChecked(i)) list.Add(i + 1);

			for (int i = 0; i < clbIndvAcademic.Items.Count; i++)
				if (clbIndvAcademic.GetItemChecked(i)) list.Add(i + 4);

			return list;
		}

		private List<int> GetSelectedTeamEvents()
		{
			if (cbTeamSpecial.SelectedIndex != -1) return new List<int> { 7 };

			List<int> list = new List<int>();
			for (int i = 0; i < clbTeamSports.Items.Count; i++)
				if (clbTeamSports.GetItemChecked(i)) list.Add(i + 1);

			for (int i = 0; i < clbTeamAcademic.Items.Count; i++)
				if (clbTeamAcademic.GetItemChecked(i)) list.Add(i + 4);

			return list;
		}

		private void ClearAllFields()
		{
			txtIndvName.Clear();
			txtTeamName.Clear();
			txtMember1.Clear(); txtMember2.Clear(); txtMember3.Clear(); txtMember4.Clear(); txtMember5.Clear();
			cbIndvSpecial.SelectedIndex = -1;
			cbTeamSpecial.SelectedIndex = -1;
			ClearIndividualChecks();
			ClearTeamChecks();
		}

		private void ClearIndividualChecks()
		{
			for (int i = 0; i < clbIndvSports.Items.Count; i++) clbIndvSports.SetItemChecked(i, false);
			for (int i = 0; i < clbIndvAcademic.Items.Count; i++) clbIndvAcademic.SetItemChecked(i, false);
		}

		private void ClearTeamChecks()
		{
			for (int i = 0; i < clbTeamSports.Items.Count; i++) clbTeamSports.SetItemChecked(i, false);
			for (int i = 0; i < clbTeamAcademic.Items.Count; i++) clbTeamAcademic.SetItemChecked(i, false);
		}

		// كلاس مساعد لتخزين البيانات أثناء عملية الترتيب والفرز
		public class ResultItem
		{
			public string Name { get; set; }
			public string Type { get; set; }
			public int Points { get; set; }
		}

		private void tabPage1_Click(object sender, EventArgs e) { }

		private void clbTeamSports_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void cbIndvSpecial_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void tpIndividuals_Click(object sender, EventArgs e)
		{

		}

		private void lblIndvName_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			tabControlMain.SelectedIndex = 1;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			timer1.Start();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lblClock.Text = DateTime.Now.ToString("hh:mm:ss tt");
		}
	}
}