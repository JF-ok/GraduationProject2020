namespace GeoVizuality
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ms_File = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_File_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.main_splitContainer = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.p = new System.Windows.Forms.PictureBox();
            this.p_for_label = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Rastr_btn = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Inter_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_lines_Y = new System.Windows.Forms.TextBox();
            this.tb_step_Y = new System.Windows.Forms.TextBox();
            this.lbl_min_Y = new System.Windows.Forms.Label();
            this.lbl_max_Y = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_lines_X = new System.Windows.Forms.TextBox();
            this.tb_step_X = new System.Windows.Forms.TextBox();
            this.lbl_max_X = new System.Windows.Forms.Label();
            this.lbl_min_X = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.color_panel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Counter = new System.Windows.Forms.NumericUpDown();
            this.tb_step = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.Main_tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_splitContainer)).BeginInit();
            this.main_splitContainer.Panel1.SuspendLayout();
            this.main_splitContainer.Panel2.SuspendLayout();
            this.main_splitContainer.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_for_label)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Counter)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_File});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ms_File
            // 
            this.ms_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_File_Open});
            this.ms_File.Name = "ms_File";
            this.ms_File.Size = new System.Drawing.Size(48, 20);
            this.ms_File.Text = "Файл";
            // 
            // ms_File_Open
            // 
            this.ms_File_Open.Name = "ms_File_Open";
            this.ms_File_Open.Size = new System.Drawing.Size(121, 22);
            this.ms_File_Open.Text = "Открыть";
            this.ms_File_Open.Click += new System.EventHandler(this.ms_File_Open_Click);
            // 
            // Main_tableLayoutPanel
            // 
            this.Main_tableLayoutPanel.ColumnCount = 3;
            this.Main_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Main_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.Main_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Main_tableLayoutPanel.Controls.Add(this.main_splitContainer, 1, 0);
            this.Main_tableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.Main_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_tableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.Main_tableLayoutPanel.Name = "Main_tableLayoutPanel";
            this.Main_tableLayoutPanel.RowCount = 1;
            this.Main_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Main_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Main_tableLayoutPanel.Size = new System.Drawing.Size(1264, 657);
            this.Main_tableLayoutPanel.TabIndex = 1;
            // 
            // main_splitContainer
            // 
            this.main_splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_splitContainer.Location = new System.Drawing.Point(189, 0);
            this.main_splitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.main_splitContainer.Name = "main_splitContainer";
            this.main_splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // main_splitContainer.Panel1
            // 
            this.main_splitContainer.Panel1.Controls.Add(this.tableLayoutPanel6);
            this.main_splitContainer.Panel1.Controls.Add(this.p);
            this.main_splitContainer.Panel1.Controls.Add(this.p_for_label);
            this.main_splitContainer.Panel1MinSize = 350;
            // 
            // main_splitContainer.Panel2
            // 
            this.main_splitContainer.Panel2.Controls.Add(this.chart1);
            this.main_splitContainer.Panel2.Controls.Add(this.splitter1);
            this.main_splitContainer.Panel2MinSize = 0;
            this.main_splitContainer.Size = new System.Drawing.Size(884, 657);
            this.main_splitContainer.SplitterDistance = 500;
            this.main_splitContainer.SplitterWidth = 5;
            this.main_splitContainer.TabIndex = 0;
            this.main_splitContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.main_splitContainer_SplitterMoved);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.trackBar1, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 475);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(884, 25);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(50, 0);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(784, 25);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // p
            // 
            this.p.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p.BackColor = System.Drawing.Color.Transparent;
            this.p.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p.Location = new System.Drawing.Point(60, 60);
            this.p.Margin = new System.Windows.Forms.Padding(0);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(764, 380);
            this.p.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.p.TabIndex = 1;
            this.p.TabStop = false;
            this.p.MouseLeave += new System.EventHandler(this.p_MouseLeave);
            this.p.MouseMove += new System.Windows.Forms.MouseEventHandler(this.p_MouseMove);
            // 
            // p_for_label
            // 
            this.p_for_label.BackColor = System.Drawing.Color.Transparent;
            this.p_for_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_for_label.Location = new System.Drawing.Point(0, 0);
            this.p_for_label.Margin = new System.Windows.Forms.Padding(0);
            this.p_for_label.Name = "p_for_label";
            this.p_for_label.Size = new System.Drawing.Size(884, 500);
            this.p_for_label.TabIndex = 0;
            this.p_for_label.TabStop = false;
            // 
            // chart1
            // 
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 73.80319F;
            chartArea1.InnerPlotPosition.Width = 92F;
            chartArea1.InnerPlotPosition.X = 4F;
            chartArea1.InnerPlotPosition.Y = 6.70213F;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.MaximumAutoSize = 10F;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Margin = new System.Windows.Forms.Padding(0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(884, 149);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 149);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(884, 3);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.38095F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.61905F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(189, 657);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.Rastr_btn, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.checkedListBox1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.Inter_btn, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.697108F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.07306F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.24201F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.35008F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(98, 657);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // Rastr_btn
            // 
            this.Rastr_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Rastr_btn.Location = new System.Drawing.Point(3, 83);
            this.Rastr_btn.Name = "Rastr_btn";
            this.Rastr_btn.Size = new System.Drawing.Size(92, 23);
            this.Rastr_btn.TabIndex = 0;
            this.Rastr_btn.Text = "Отобразить";
            this.Rastr_btn.UseVisualStyleBackColor = true;
            this.Rastr_btn.Click += new System.EventHandler(this.Rastr_btn_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Рядовые",
            "Опорные",
            "Всё"});
            this.checkedListBox1.Location = new System.Drawing.Point(3, 112);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(88, 94);
            this.checkedListBox1.TabIndex = 2;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // Inter_btn
            // 
            this.Inter_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Inter_btn.Location = new System.Drawing.Point(3, 236);
            this.Inter_btn.Name = "Inter_btn";
            this.Inter_btn.Size = new System.Drawing.Size(92, 23);
            this.Inter_btn.TabIndex = 7;
            this.Inter_btn.Text = "Регулярная";
            this.Inter_btn.UseVisualStyleBackColor = true;
            this.Inter_btn.Click += new System.EventHandler(this.Inter_btn_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 262);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.36709F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.63291F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(98, 237);
            this.tableLayoutPanel5.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tb_lines_Y);
            this.groupBox2.Controls.Add(this.tb_step_Y);
            this.groupBox2.Controls.Add(this.lbl_min_Y);
            this.groupBox2.Controls.Add(this.lbl_max_Y);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(3, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(92, 115);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "по Y";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(-2, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Линий:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Шаг:";
            // 
            // tb_lines_Y
            // 
            this.tb_lines_Y.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_lines_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_lines_Y.Location = new System.Drawing.Point(44, 76);
            this.tb_lines_Y.Name = "tb_lines_Y";
            this.tb_lines_Y.Size = new System.Drawing.Size(48, 20);
            this.tb_lines_Y.TabIndex = 3;
            this.tb_lines_Y.Tag = "ly";
            this.tb_lines_Y.Text = "100";
            this.tb_lines_Y.Click += new System.EventHandler(this.tb_Click);
            this.tb_lines_Y.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            // 
            // tb_step_Y
            // 
            this.tb_step_Y.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_step_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_step_Y.Location = new System.Drawing.Point(44, 51);
            this.tb_step_Y.Name = "tb_step_Y";
            this.tb_step_Y.Size = new System.Drawing.Size(48, 20);
            this.tb_step_Y.TabIndex = 2;
            this.tb_step_Y.Tag = "sy";
            this.tb_step_Y.Click += new System.EventHandler(this.tb_Click);
            this.tb_step_Y.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            // 
            // lbl_min_Y
            // 
            this.lbl_min_Y.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_min_Y.AutoSize = true;
            this.lbl_min_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_min_Y.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_min_Y.Location = new System.Drawing.Point(2, 17);
            this.lbl_min_Y.Name = "lbl_min_Y";
            this.lbl_min_Y.Size = new System.Drawing.Size(78, 13);
            this.lbl_min_Y.TabIndex = 1;
            this.lbl_min_Y.Text = "Минимальное";
            // 
            // lbl_max_Y
            // 
            this.lbl_max_Y.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_max_Y.AutoSize = true;
            this.lbl_max_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_max_Y.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_max_Y.Location = new System.Drawing.Point(2, 34);
            this.lbl_max_Y.Name = "lbl_max_Y";
            this.lbl_max_Y.Size = new System.Drawing.Size(84, 13);
            this.lbl_max_Y.TabIndex = 0;
            this.lbl_max_Y.Text = "Максимальное";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_lines_X);
            this.groupBox1.Controls.Add(this.tb_step_X);
            this.groupBox1.Controls.Add(this.lbl_max_X);
            this.groupBox1.Controls.Add(this.lbl_min_X);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(92, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "по X";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(-2, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Линий:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Шаг:";
            // 
            // tb_lines_X
            // 
            this.tb_lines_X.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_lines_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_lines_X.Location = new System.Drawing.Point(44, 76);
            this.tb_lines_X.Name = "tb_lines_X";
            this.tb_lines_X.Size = new System.Drawing.Size(48, 20);
            this.tb_lines_X.TabIndex = 3;
            this.tb_lines_X.Tag = "lx";
            this.tb_lines_X.Text = "100";
            this.tb_lines_X.Click += new System.EventHandler(this.tb_Click);
            this.tb_lines_X.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            // 
            // tb_step_X
            // 
            this.tb_step_X.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_step_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_step_X.Location = new System.Drawing.Point(44, 51);
            this.tb_step_X.Name = "tb_step_X";
            this.tb_step_X.Size = new System.Drawing.Size(48, 20);
            this.tb_step_X.TabIndex = 2;
            this.tb_step_X.Tag = "sx";
            this.tb_step_X.Click += new System.EventHandler(this.tb_Click);
            this.tb_step_X.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            // 
            // lbl_max_X
            // 
            this.lbl_max_X.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_max_X.AutoSize = true;
            this.lbl_max_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_max_X.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_max_X.Location = new System.Drawing.Point(2, 33);
            this.lbl_max_X.Name = "lbl_max_X";
            this.lbl_max_X.Size = new System.Drawing.Size(84, 13);
            this.lbl_max_X.TabIndex = 1;
            this.lbl_max_X.Text = "Максимальное";
            // 
            // lbl_min_X
            // 
            this.lbl_min_X.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_min_X.AutoSize = true;
            this.lbl_min_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_min_X.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_min_X.Location = new System.Drawing.Point(2, 16);
            this.lbl_min_X.Name = "lbl_min_X";
            this.lbl_min_X.Size = new System.Drawing.Size(78, 13);
            this.lbl_min_X.TabIndex = 0;
            this.lbl_min_X.Text = "Минимальное";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.color_panel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(98, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(91, 657);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // color_panel
            // 
            this.color_panel.ColumnCount = 2;
            this.color_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.10526F));
            this.color_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.89474F));
            this.color_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.color_panel.Location = new System.Drawing.Point(0, 0);
            this.color_panel.Margin = new System.Windows.Forms.Padding(0);
            this.color_panel.Name = "color_panel";
            this.color_panel.RowCount = 1;
            this.color_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.color_panel.Size = new System.Drawing.Size(91, 500);
            this.color_panel.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.6383F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.3617F));
            this.tableLayoutPanel3.Controls.Add(this.Counter, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tb_step, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 500);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(91, 157);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // Counter
            // 
            this.Counter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Counter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Counter.Location = new System.Drawing.Point(55, 0);
            this.Counter.Margin = new System.Windows.Forms.Padding(0);
            this.Counter.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.Counter.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(36, 22);
            this.Counter.TabIndex = 1;
            this.Counter.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.Counter.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.Counter.ValueChanged += new System.EventHandler(this.Counter_ValueChanged);
            // 
            // tb_step
            // 
            this.tb_step.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_step.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_step.Location = new System.Drawing.Point(5, 0);
            this.tb_step.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.tb_step.Name = "tb_step";
            this.tb_step.Size = new System.Drawing.Size(50, 22);
            this.tb_step.TabIndex = 2;
            this.tb_step.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_step_MouseClick);
            this.tb_step.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_step_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Main_tableLayoutPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(640, 360);
            this.Name = "Form1";
            this.Text = "GeoVizuality";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Main_tableLayoutPanel.ResumeLayout(false);
            this.main_splitContainer.Panel1.ResumeLayout(false);
            this.main_splitContainer.Panel1.PerformLayout();
            this.main_splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.main_splitContainer)).EndInit();
            this.main_splitContainer.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_for_label)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Counter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ms_File;
        private System.Windows.Forms.ToolStripMenuItem ms_File_Open;
        private System.Windows.Forms.TableLayoutPanel Main_tableLayoutPanel;
        private System.Windows.Forms.SplitContainer main_splitContainer;
        private System.Windows.Forms.PictureBox p;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.NumericUpDown Counter;
        private System.Windows.Forms.TextBox tb_step;
        private System.Windows.Forms.PictureBox p_for_label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button Rastr_btn;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button Inter_btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_lines_Y;
        private System.Windows.Forms.TextBox tb_step_Y;
        private System.Windows.Forms.Label lbl_min_Y;
        private System.Windows.Forms.Label lbl_max_Y;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_lines_X;
        private System.Windows.Forms.TextBox tb_step_X;
        private System.Windows.Forms.Label lbl_max_X;
        private System.Windows.Forms.Label lbl_min_X;
        private System.Windows.Forms.TableLayoutPanel color_panel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

