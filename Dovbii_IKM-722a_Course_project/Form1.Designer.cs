namespace Dovbii_IKM_722a_Course_project
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
            this.components = new System.ComponentModel.Container();
            this.tClock = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.відкритиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.зберегтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиЯкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.роботаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пускToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.проНакопичувачіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.довідкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.ofdOpen = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.LabelStack = new System.Windows.Forms.Label();
            this.StackText = new System.Windows.Forms.Label();
            this.Stacktb = new System.Windows.Forms.TextBox();
            this.Pop = new System.Windows.Forms.Button();
            this.Push = new System.Windows.Forms.Button();
            this.Peek = new System.Windows.Forms.Button();
            this.Peek_q = new System.Windows.Forms.Button();
            this.Dequeue = new System.Windows.Forms.Button();
            this.Enqueue = new System.Windows.Forms.Button();
            this.Queuetb = new System.Windows.Forms.TextBox();
            this.LabelQueue = new System.Windows.Forms.Label();
            this.QueueText = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgwOpen = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.tabPages1 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.bStart = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOpen)).BeginInit();
            this.tabPages1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tClock
            // 
            this.tClock.Interval = 25000;
            this.tClock.Tick += new System.EventHandler(this.tClock_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.роботаToolStripMenuItem,
            this.довідкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1863, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новийToolStripMenuItem,
            this.toolStripSeparator1,
            this.відкритиToolStripMenuItem,
            this.toolStripSeparator2,
            this.зберегтиToolStripMenuItem,
            this.зберегтиЯкToolStripMenuItem,
            this.toolStripSeparator3,
            this.вихідToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новийToolStripMenuItem
            // 
            this.новийToolStripMenuItem.Name = "новийToolStripMenuItem";
            this.новийToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.новийToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.новийToolStripMenuItem.Text = "Новий";
            this.новийToolStripMenuItem.Click += new System.EventHandler(this.новийToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // відкритиToolStripMenuItem
            // 
            this.відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            this.відкритиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.відкритиToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.відкритиToolStripMenuItem.Text = "Відкрити";
            this.відкритиToolStripMenuItem.Click += new System.EventHandler(this.відкритиToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(162, 6);
            // 
            // зберегтиToolStripMenuItem
            // 
            this.зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            this.зберегтиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.зберегтиToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.зберегтиToolStripMenuItem.Text = "Зберегти";
            this.зберегтиToolStripMenuItem.Click += new System.EventHandler(this.зберегтиToolStripMenuItem_Click);
            // 
            // зберегтиЯкToolStripMenuItem
            // 
            this.зберегтиЯкToolStripMenuItem.Name = "зберегтиЯкToolStripMenuItem";
            this.зберегтиЯкToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.зберегтиЯкToolStripMenuItem.Text = "Зберегти як...";
            this.зберегтиЯкToolStripMenuItem.Click += new System.EventHandler(this.зберегтиЯкToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(162, 6);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // роботаToolStripMenuItem
            // 
            this.роботаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пускToolStripMenuItem,
            this.toolStripSeparator4,
            this.проНакопичувачіToolStripMenuItem});
            this.роботаToolStripMenuItem.Name = "роботаToolStripMenuItem";
            this.роботаToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.роботаToolStripMenuItem.Text = "Робота";
            // 
            // пускToolStripMenuItem
            // 
            this.пускToolStripMenuItem.Name = "пускToolStripMenuItem";
            this.пускToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.пускToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.пускToolStripMenuItem.Text = "Пуск";
            this.пускToolStripMenuItem.Click += new System.EventHandler(this.bStart_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(172, 6);
            // 
            // проНакопичувачіToolStripMenuItem
            // 
            this.проНакопичувачіToolStripMenuItem.Name = "проНакопичувачіToolStripMenuItem";
            this.проНакопичувачіToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.проНакопичувачіToolStripMenuItem.Text = "Про накопичувачі";
            this.проНакопичувачіToolStripMenuItem.Click += new System.EventHandler(this.проНакопичувачіToolStripMenuItem_Click);
            // 
            // довідкаToolStripMenuItem
            // 
            this.довідкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проПрограмуToolStripMenuItem});
            this.довідкаToolStripMenuItem.Name = "довідкаToolStripMenuItem";
            this.довідкаToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.довідкаToolStripMenuItem.Text = "Довідка";
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            this.проПрограмуToolStripMenuItem.Click += new System.EventHandler(this.проПрограмуToolStripMenuItem_Click);
            // 
            // sfdSave
            // 
            this.sfdSave.Filter = "рабочие файлы|*.DUM|Все файлы|*.*";
            // 
            // ofdOpen
            // 
            this.ofdOpen.FileName = "openFileDialog1";
            this.ofdOpen.Filter = "рабочие файлы|*.DUM|Все файлы|*.*";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1843, 850);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Стек/Черга";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightGray;
            this.splitContainer1.Panel1.Controls.Add(this.LabelStack);
            this.splitContainer1.Panel1.Controls.Add(this.StackText);
            this.splitContainer1.Panel1.Controls.Add(this.Stacktb);
            this.splitContainer1.Panel1.Controls.Add(this.Pop);
            this.splitContainer1.Panel1.Controls.Add(this.Push);
            this.splitContainer1.Panel1.Controls.Add(this.Peek);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.SystemColors.GrayText;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Silver;
            this.splitContainer1.Panel2.Controls.Add(this.Peek_q);
            this.splitContainer1.Panel2.Controls.Add(this.Dequeue);
            this.splitContainer1.Panel2.Controls.Add(this.Enqueue);
            this.splitContainer1.Panel2.Controls.Add(this.Queuetb);
            this.splitContainer1.Panel2.Controls.Add(this.LabelQueue);
            this.splitContainer1.Panel2.Controls.Add(this.QueueText);
            this.splitContainer1.Size = new System.Drawing.Size(1837, 844);
            this.splitContainer1.SplitterDistance = 861;
            this.splitContainer1.TabIndex = 0;
            // 
            // LabelStack
            // 
            this.LabelStack.AutoSize = true;
            this.LabelStack.Location = new System.Drawing.Point(320, 626);
            this.LabelStack.Name = "LabelStack";
            this.LabelStack.Size = new System.Drawing.Size(61, 13);
            this.LabelStack.TabIndex = 5;
            this.LabelStack.Text = "LabelStack";
            // 
            // StackText
            // 
            this.StackText.AutoSize = true;
            this.StackText.Location = new System.Drawing.Point(320, 279);
            this.StackText.Name = "StackText";
            this.StackText.Size = new System.Drawing.Size(35, 13);
            this.StackText.TabIndex = 4;
            this.StackText.Text = "СТЕК";
            // 
            // Stacktb
            // 
            this.Stacktb.Location = new System.Drawing.Point(263, 336);
            this.Stacktb.Name = "Stacktb";
            this.Stacktb.Size = new System.Drawing.Size(162, 20);
            this.Stacktb.TabIndex = 3;
            // 
            // Pop
            // 
            this.Pop.Location = new System.Drawing.Point(306, 410);
            this.Pop.Name = "Pop";
            this.Pop.Size = new System.Drawing.Size(75, 23);
            this.Pop.TabIndex = 2;
            this.Pop.Text = "Pop";
            this.Pop.UseVisualStyleBackColor = true;
            this.Pop.Click += new System.EventHandler(this.Pop_Click);
            // 
            // Push
            // 
            this.Push.Location = new System.Drawing.Point(146, 410);
            this.Push.Name = "Push";
            this.Push.Size = new System.Drawing.Size(75, 23);
            this.Push.TabIndex = 1;
            this.Push.Text = "Push";
            this.Push.UseVisualStyleBackColor = true;
            this.Push.Click += new System.EventHandler(this.Push_Click);
            // 
            // Peek
            // 
            this.Peek.Location = new System.Drawing.Point(471, 410);
            this.Peek.Name = "Peek";
            this.Peek.Size = new System.Drawing.Size(75, 23);
            this.Peek.TabIndex = 0;
            this.Peek.Text = "Peek";
            this.Peek.UseVisualStyleBackColor = true;
            this.Peek.Click += new System.EventHandler(this.Peek_Click);
            // 
            // Peek_q
            // 
            this.Peek_q.Location = new System.Drawing.Point(583, 410);
            this.Peek_q.Name = "Peek_q";
            this.Peek_q.Size = new System.Drawing.Size(75, 23);
            this.Peek_q.TabIndex = 5;
            this.Peek_q.Text = "Peek_q";
            this.Peek_q.UseVisualStyleBackColor = true;
            this.Peek_q.Click += new System.EventHandler(this.Peek_q_Click);
            // 
            // Dequeue
            // 
            this.Dequeue.Location = new System.Drawing.Point(431, 410);
            this.Dequeue.Name = "Dequeue";
            this.Dequeue.Size = new System.Drawing.Size(75, 23);
            this.Dequeue.TabIndex = 4;
            this.Dequeue.Text = "Dequeue";
            this.Dequeue.UseVisualStyleBackColor = true;
            this.Dequeue.Click += new System.EventHandler(this.Dequeue_Click);
            // 
            // Enqueue
            // 
            this.Enqueue.Location = new System.Drawing.Point(270, 410);
            this.Enqueue.Name = "Enqueue";
            this.Enqueue.Size = new System.Drawing.Size(75, 23);
            this.Enqueue.TabIndex = 3;
            this.Enqueue.Text = "Enqueue";
            this.Enqueue.UseVisualStyleBackColor = true;
            this.Enqueue.Click += new System.EventHandler(this.Enqueue_Click);
            // 
            // Queuetb
            // 
            this.Queuetb.Location = new System.Drawing.Point(404, 336);
            this.Queuetb.Name = "Queuetb";
            this.Queuetb.Size = new System.Drawing.Size(120, 20);
            this.Queuetb.TabIndex = 2;
            // 
            // LabelQueue
            // 
            this.LabelQueue.AutoSize = true;
            this.LabelQueue.Location = new System.Drawing.Point(428, 626);
            this.LabelQueue.Name = "LabelQueue";
            this.LabelQueue.Size = new System.Drawing.Size(65, 13);
            this.LabelQueue.TabIndex = 1;
            this.LabelQueue.Text = "LabelQueue";
            // 
            // QueueText
            // 
            this.QueueText.AutoSize = true;
            this.QueueText.Location = new System.Drawing.Point(444, 279);
            this.QueueText.Name = "QueueText";
            this.QueueText.Size = new System.Drawing.Size(38, 13);
            this.QueueText.TabIndex = 0;
            this.QueueText.Text = "Черга";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPage2.Controls.Add(this.dgwOpen);
            this.tabPage2.Controls.Add(this.tbSearch);
            this.tabPage2.Controls.Add(this.bSearch);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1843, 850);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Робота з файлами";
            // 
            // dgwOpen
            // 
            this.dgwOpen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOpen.Location = new System.Drawing.Point(52, 63);
            this.dgwOpen.Name = "dgwOpen";
            this.dgwOpen.Size = new System.Drawing.Size(1086, 684);
            this.dgwOpen.TabIndex = 4;
            this.dgwOpen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwOpen_CellContentClick);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(1417, 187);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(212, 20);
            this.tbSearch.TabIndex = 6;
            this.tbSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(1474, 131);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(90, 31);
            this.bSearch.TabIndex = 5;
            this.bSearch.Text = "Пошук";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // tabPages1
            // 
            this.tabPages1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPages1.Controls.Add(this.statusStrip1);
            this.tabPages1.Controls.Add(this.bStart);
            this.tabPages1.Controls.Add(this.tbInput);
            this.tabPages1.Controls.Add(this.label1);
            this.tabPages1.Location = new System.Drawing.Point(4, 22);
            this.tabPages1.Name = "tabPages1";
            this.tabPages1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPages1.Size = new System.Drawing.Size(1843, 850);
            this.tabPages1.TabIndex = 0;
            this.tabPages1.Text = "Введення даних";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(3, 825);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1837, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(846, 339);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(138, 47);
            this.bStart.TabIndex = 0;
            this.bStart.Text = "Пуск";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // tbInput
            // 
            this.tbInput.Enabled = false;
            this.tbInput.Location = new System.Drawing.Point(560, 230);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(739, 20);
            this.tbInput.TabIndex = 1;
            this.tbInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(897, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPages1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1851, 876);
            this.tabControl1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1863, 899);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOpen)).EndInit();
            this.tabPages1.ResumeLayout(false);
            this.tabPages1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tClock;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відкритиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиЯкToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem роботаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пускToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проНакопичувачіToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem довідкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.SaveFileDialog sfdSave;
        private System.Windows.Forms.OpenFileDialog ofdOpen;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgwOpen;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.TabPage tabPages1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button Pop;
        private System.Windows.Forms.Button Push;
        private System.Windows.Forms.Button Peek;
        private System.Windows.Forms.TextBox Stacktb;
        private System.Windows.Forms.Label LabelStack;
        private System.Windows.Forms.Label StackText;
        private System.Windows.Forms.Button Peek_q;
        private System.Windows.Forms.Button Dequeue;
        private System.Windows.Forms.Button Enqueue;
        private System.Windows.Forms.TextBox Queuetb;
        private System.Windows.Forms.Label LabelQueue;
        private System.Windows.Forms.Label QueueText;
    }
}

