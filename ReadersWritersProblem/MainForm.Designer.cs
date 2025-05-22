namespace ReadersWritersProblem
{
    partial class MainForm
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
            this.lblReadersTitle = new System.Windows.Forms.Label();
            this.lblReadersCount = new System.Windows.Forms.Label();
            this.lblWriterTitle = new System.Windows.Forms.Label();
            this.lblWriterActive = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstQueue = new System.Windows.Forms.ListBox();
            this.lblCurrentQueueTitle = new System.Windows.Forms.Label();
            this.lblCurrentQueue = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAvgQueue = new System.Windows.Forms.Label();
            this.lblAvgQueueTitle = new System.Windows.Forms.Label();
            this.lblMaxQueue = new System.Windows.Forms.Label();
            this.lblMaxQueueTitle = new System.Windows.Forms.Label();
            this.lblTotalWriters = new System.Windows.Forms.Label();
            this.lblTotalWritersTitle = new System.Windows.Forms.Label();
            this.lblTotalReaders = new System.Windows.Forms.Label();
            this.lblTotalReadersTitle = new System.Windows.Forms.Label();
            this.txtStatusLog = new System.Windows.Forms.TextBox();
            this.lblStatusTitle = new System.Windows.Forms.Label();
            this.btnStartSimulation = new System.Windows.Forms.Button();
            this.btnStopSimulation = new System.Windows.Forms.Button();
            this.nudReaders = new System.Windows.Forms.NumericUpDown();
            this.nudWriters = new System.Windows.Forms.NumericUpDown();
            this.lblReaderCount = new System.Windows.Forms.Label();
            this.lblWriterCount = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblServiceChart = new System.Windows.Forms.Label();
            this.lblWaitChart = new System.Windows.Forms.Label();
            this.lblQueueChart = new System.Windows.Forms.Label();
            this.chartServiceTimes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartWaitTimes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartQueueLength = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblReaderTimeRange = new System.Windows.Forms.Label();
            this.lblReaderMinTime = new System.Windows.Forms.Label();
            this.nudReaderMinTime = new System.Windows.Forms.NumericUpDown();
            this.lblReaderMaxTime = new System.Windows.Forms.Label();
            this.nudReaderMaxTime = new System.Windows.Forms.NumericUpDown();
            this.lblWriterTimeRange = new System.Windows.Forms.Label();
            this.lblWriterMinTime = new System.Windows.Forms.Label();
            this.nudWriterMinTime = new System.Windows.Forms.NumericUpDown();
            this.lblWriterMaxTime = new System.Windows.Forms.Label();
            this.nudWriterMaxTime = new System.Windows.Forms.NumericUpDown();
            this.lblReaderReadTimeRange = new System.Windows.Forms.Label();
            this.lblReaderMinReadTime = new System.Windows.Forms.Label();
            this.nudReaderMinReadTime = new System.Windows.Forms.NumericUpDown();
            this.lblReaderMaxReadTime = new System.Windows.Forms.Label();
            this.nudReaderMaxReadTime = new System.Windows.Forms.NumericUpDown();
            this.lblWriterWriteTimeRange = new System.Windows.Forms.Label();
            this.lblWriterMinWriteTime = new System.Windows.Forms.Label();
            this.nudWriterMinWriteTime = new System.Windows.Forms.NumericUpDown();
            this.lblWriterMaxWriteTime = new System.Windows.Forms.Label();
            this.nudWriterMaxWriteTime = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudReaders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWriters)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartServiceTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWaitTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartQueueLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReaderMinTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReaderMaxTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWriterMinTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWriterMaxTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReaderMinReadTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReaderMaxReadTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWriterMinWriteTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWriterMaxWriteTime)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReadersTitle
            // 
            this.lblReadersTitle.AutoSize = true;
            this.lblReadersTitle.Location = new System.Drawing.Point(12, 15);
            this.lblReadersTitle.Name = "lblReadersTitle";
            this.lblReadersTitle.Size = new System.Drawing.Size(114, 13);
            this.lblReadersTitle.TabIndex = 0;
            this.lblReadersTitle.Text = "Active Readers Count:";
            // 
            // lblReadersCount
            // 
            this.lblReadersCount.AutoSize = true;
            this.lblReadersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReadersCount.Location = new System.Drawing.Point(130, 15);
            this.lblReadersCount.Name = "lblReadersCount";
            this.lblReadersCount.Size = new System.Drawing.Size(14, 13);
            this.lblReadersCount.TabIndex = 1;
            this.lblReadersCount.Text = "0";
            // 
            // lblWriterTitle
            // 
            this.lblWriterTitle.AutoSize = true;
            this.lblWriterTitle.Location = new System.Drawing.Point(12, 40);
            this.lblWriterTitle.Name = "lblWriterTitle";
            this.lblWriterTitle.Size = new System.Drawing.Size(71, 13);
            this.lblWriterTitle.TabIndex = 2;
            this.lblWriterTitle.Text = "Writer Active:";
            // 
            // lblWriterActive
            // 
            this.lblWriterActive.AutoSize = true;
            this.lblWriterActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWriterActive.Location = new System.Drawing.Point(130, 40);
            this.lblWriterActive.Name = "lblWriterActive";
            this.lblWriterActive.Size = new System.Drawing.Size(23, 13);
            this.lblWriterActive.TabIndex = 3;
            this.lblWriterActive.Text = "No";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstQueue);
            this.groupBox1.Controls.Add(this.lblCurrentQueueTitle);
            this.groupBox1.Controls.Add(this.lblCurrentQueue);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 200);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Queue";
            // 
            // lstQueue
            // 
            this.lstQueue.FormattingEnabled = true;
            this.lstQueue.Location = new System.Drawing.Point(6, 42);
            this.lstQueue.Name = "lstQueue";
            this.lstQueue.Size = new System.Drawing.Size(188, 147);
            this.lstQueue.TabIndex = 2;
            // 
            // lblCurrentQueueTitle
            // 
            this.lblCurrentQueueTitle.AutoSize = true;
            this.lblCurrentQueueTitle.Location = new System.Drawing.Point(6, 20);
            this.lblCurrentQueueTitle.Name = "lblCurrentQueueTitle";
            this.lblCurrentQueueTitle.Size = new System.Drawing.Size(80, 13);
            this.lblCurrentQueueTitle.TabIndex = 0;
            this.lblCurrentQueueTitle.Text = "Current Length:";
            // 
            // lblCurrentQueue
            // 
            this.lblCurrentQueue.AutoSize = true;
            this.lblCurrentQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentQueue.Location = new System.Drawing.Point(96, 20);
            this.lblCurrentQueue.Name = "lblCurrentQueue";
            this.lblCurrentQueue.Size = new System.Drawing.Size(14, 13);
            this.lblCurrentQueue.TabIndex = 1;
            this.lblCurrentQueue.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAvgQueue);
            this.groupBox2.Controls.Add(this.lblAvgQueueTitle);
            this.groupBox2.Controls.Add(this.lblMaxQueue);
            this.groupBox2.Controls.Add(this.lblMaxQueueTitle);
            this.groupBox2.Controls.Add(this.lblTotalWriters);
            this.groupBox2.Controls.Add(this.lblTotalWritersTitle);
            this.groupBox2.Controls.Add(this.lblTotalReaders);
            this.groupBox2.Controls.Add(this.lblTotalReadersTitle);
            this.groupBox2.Location = new System.Drawing.Point(218, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 120);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Statistics";
            // 
            // lblAvgQueue
            // 
            this.lblAvgQueue.AutoSize = true;
            this.lblAvgQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgQueue.Location = new System.Drawing.Point(143, 94);
            this.lblAvgQueue.Name = "lblAvgQueue";
            this.lblAvgQueue.Size = new System.Drawing.Size(32, 13);
            this.lblAvgQueue.TabIndex = 7;
            this.lblAvgQueue.Text = "0.00";
            // 
            // lblAvgQueueTitle
            // 
            this.lblAvgQueueTitle.AutoSize = true;
            this.lblAvgQueueTitle.Location = new System.Drawing.Point(6, 94);
            this.lblAvgQueueTitle.Name = "lblAvgQueueTitle";
            this.lblAvgQueueTitle.Size = new System.Drawing.Size(121, 13);
            this.lblAvgQueueTitle.TabIndex = 6;
            this.lblAvgQueueTitle.Text = "Average Queue Length:";
            // 
            // lblMaxQueue
            // 
            this.lblMaxQueue.AutoSize = true;
            this.lblMaxQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxQueue.Location = new System.Drawing.Point(143, 69);
            this.lblMaxQueue.Name = "lblMaxQueue";
            this.lblMaxQueue.Size = new System.Drawing.Size(14, 13);
            this.lblMaxQueue.TabIndex = 5;
            this.lblMaxQueue.Text = "0";
            // 
            // lblMaxQueueTitle
            // 
            this.lblMaxQueueTitle.AutoSize = true;
            this.lblMaxQueueTitle.Location = new System.Drawing.Point(6, 69);
            this.lblMaxQueueTitle.Name = "lblMaxQueueTitle";
            this.lblMaxQueueTitle.Size = new System.Drawing.Size(125, 13);
            this.lblMaxQueueTitle.TabIndex = 4;
            this.lblMaxQueueTitle.Text = "Maximum Queue Length:";
            // 
            // lblTotalWriters
            // 
            this.lblTotalWriters.AutoSize = true;
            this.lblTotalWriters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWriters.Location = new System.Drawing.Point(143, 44);
            this.lblTotalWriters.Name = "lblTotalWriters";
            this.lblTotalWriters.Size = new System.Drawing.Size(14, 13);
            this.lblTotalWriters.TabIndex = 3;
            this.lblTotalWriters.Text = "0";
            // 
            // lblTotalWritersTitle
            // 
            this.lblTotalWritersTitle.AutoSize = true;
            this.lblTotalWritersTitle.Location = new System.Drawing.Point(6, 44);
            this.lblTotalWritersTitle.Name = "lblTotalWritersTitle";
            this.lblTotalWritersTitle.Size = new System.Drawing.Size(107, 13);
            this.lblTotalWritersTitle.TabIndex = 2;
            this.lblTotalWritersTitle.Text = "Total Writers Served:";
            // 
            // lblTotalReaders
            // 
            this.lblTotalReaders.AutoSize = true;
            this.lblTotalReaders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalReaders.Location = new System.Drawing.Point(143, 19);
            this.lblTotalReaders.Name = "lblTotalReaders";
            this.lblTotalReaders.Size = new System.Drawing.Size(14, 13);
            this.lblTotalReaders.TabIndex = 1;
            this.lblTotalReaders.Text = "0";
            // 
            // lblTotalReadersTitle
            // 
            this.lblTotalReadersTitle.AutoSize = true;
            this.lblTotalReadersTitle.Location = new System.Drawing.Point(6, 19);
            this.lblTotalReadersTitle.Name = "lblTotalReadersTitle";
            this.lblTotalReadersTitle.Size = new System.Drawing.Size(114, 13);
            this.lblTotalReadersTitle.TabIndex = 0;
            this.lblTotalReadersTitle.Text = "Total Readers Served:";
            // 
            // txtStatusLog
            // 
            this.txtStatusLog.Location = new System.Drawing.Point(218, 154);
            this.txtStatusLog.Multiline = true;
            this.txtStatusLog.Name = "txtStatusLog";
            this.txtStatusLog.ReadOnly = true;
            this.txtStatusLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatusLog.Size = new System.Drawing.Size(200, 111);
            this.txtStatusLog.TabIndex = 6;
            // 
            // lblStatusTitle
            // 
            this.lblStatusTitle.AutoSize = true;
            this.lblStatusTitle.Location = new System.Drawing.Point(218, 138);
            this.lblStatusTitle.Name = "lblStatusTitle";
            this.lblStatusTitle.Size = new System.Drawing.Size(40, 13);
            this.lblStatusTitle.TabIndex = 7;
            this.lblStatusTitle.Text = "Status:";
            // 
            // btnStartSimulation
            // 
            this.btnStartSimulation.Location = new System.Drawing.Point(12, 317);
            this.btnStartSimulation.Name = "btnStartSimulation";
            this.btnStartSimulation.Size = new System.Drawing.Size(100, 30);
            this.btnStartSimulation.TabIndex = 8;
            this.btnStartSimulation.Text = "Start Simulation";
            this.btnStartSimulation.UseVisualStyleBackColor = true;
            this.btnStartSimulation.Click += new System.EventHandler(this.btnStartSimulation_Click);
            // 
            // btnStopSimulation
            // 
            this.btnStopSimulation.Enabled = false;
            this.btnStopSimulation.Location = new System.Drawing.Point(118, 317);
            this.btnStopSimulation.Name = "btnStopSimulation";
            this.btnStopSimulation.Size = new System.Drawing.Size(100, 30);
            this.btnStopSimulation.TabIndex = 9;
            this.btnStopSimulation.Text = "Stop Simulation";
            this.btnStopSimulation.UseVisualStyleBackColor = true;
            this.btnStopSimulation.Click += new System.EventHandler(this.btnStopSimulation_Click);
            // 
            // nudReaders
            // 
            this.nudReaders.Location = new System.Drawing.Point(118, 271);
            this.nudReaders.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudReaders.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudReaders.Name = "nudReaders";
            this.nudReaders.Size = new System.Drawing.Size(60, 20);
            this.nudReaders.TabIndex = 10;
            this.nudReaders.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nudWriters
            // 
            this.nudWriters.Location = new System.Drawing.Point(118, 291);
            this.nudWriters.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudWriters.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWriters.Name = "nudWriters";
            this.nudWriters.Size = new System.Drawing.Size(60, 20);
            this.nudWriters.TabIndex = 11;
            this.nudWriters.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblReaderCount
            // 
            this.lblReaderCount.AutoSize = true;
            this.lblReaderCount.Location = new System.Drawing.Point(12, 273);
            this.lblReaderCount.Name = "lblReaderCount";
            this.lblReaderCount.Size = new System.Drawing.Size(102, 13);
            this.lblReaderCount.TabIndex = 12;
            this.lblReaderCount.Text = "Number of Readers:";
            // 
            // lblWriterCount
            // 
            this.lblWriterCount.AutoSize = true;
            this.lblWriterCount.Location = new System.Drawing.Point(12, 293);
            this.lblWriterCount.Name = "lblWriterCount";
            this.lblWriterCount.Size = new System.Drawing.Size(95, 13);
            this.lblWriterCount.TabIndex = 13;
            this.lblWriterCount.Text = "Number of Writers:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblServiceChart);
            this.groupBox3.Controls.Add(this.lblWaitChart);
            this.groupBox3.Controls.Add(this.lblQueueChart);
            this.groupBox3.Controls.Add(this.chartServiceTimes);
            this.groupBox3.Controls.Add(this.chartWaitTimes);
            this.groupBox3.Controls.Add(this.chartQueueLength);
            this.groupBox3.Location = new System.Drawing.Point(500, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(397, 500);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Statistics Charts";
            // 
            // lblServiceChart
            // 
            this.lblServiceChart.AutoSize = true;
            this.lblServiceChart.Location = new System.Drawing.Point(6, 318);
            this.lblServiceChart.Name = "lblServiceChart";
            this.lblServiceChart.Size = new System.Drawing.Size(180, 13);
            this.lblServiceChart.TabIndex = 5;
            this.lblServiceChart.Text = "Average Service Times (in seconds):";
            // 
            // lblWaitChart
            // 
            this.lblWaitChart.AutoSize = true;
            this.lblWaitChart.Location = new System.Drawing.Point(6, 167);
            this.lblWaitChart.Name = "lblWaitChart";
            this.lblWaitChart.Size = new System.Drawing.Size(166, 13);
            this.lblWaitChart.TabIndex = 4;
            this.lblWaitChart.Text = "Average Wait Times (in seconds):";
            // 
            // lblQueueChart
            // 
            this.lblQueueChart.AutoSize = true;
            this.lblQueueChart.Location = new System.Drawing.Point(6, 16);
            this.lblQueueChart.Name = "lblQueueChart";
            this.lblQueueChart.Size = new System.Drawing.Size(113, 13);
            this.lblQueueChart.TabIndex = 3;
            this.lblQueueChart.Text = "Queue Length History:";
            // 
            // chartServiceTimes
            // 
            this.chartServiceTimes.Location = new System.Drawing.Point(6, 334);
            this.chartServiceTimes.Name = "chartServiceTimes";
            this.chartServiceTimes.Size = new System.Drawing.Size(338, 120);
            this.chartServiceTimes.TabIndex = 2;
            this.chartServiceTimes.Text = "Service Times";
            // 
            // chartWaitTimes
            // 
            this.chartWaitTimes.Location = new System.Drawing.Point(6, 183);
            this.chartWaitTimes.Name = "chartWaitTimes";
            this.chartWaitTimes.Size = new System.Drawing.Size(338, 120);
            this.chartWaitTimes.TabIndex = 1;
            this.chartWaitTimes.Text = "Wait Times";
            // 
            // chartQueueLength
            // 
            this.chartQueueLength.Location = new System.Drawing.Point(6, 32);
            this.chartQueueLength.Name = "chartQueueLength";
            this.chartQueueLength.Size = new System.Drawing.Size(338, 120);
            this.chartQueueLength.TabIndex = 0;
            this.chartQueueLength.Text = "Queue Length";
            // 
            // lblReaderTimeRange
            // 
            this.lblReaderTimeRange.AutoSize = true;
            this.lblReaderTimeRange.Location = new System.Drawing.Point(12, 355);
            this.lblReaderTimeRange.Name = "lblReaderTimeRange";
            this.lblReaderTimeRange.Size = new System.Drawing.Size(148, 13);
            this.lblReaderTimeRange.TabIndex = 14;
            this.lblReaderTimeRange.Text = "Reader Generation Time (ms):";
            // 
            // lblReaderMinTime
            // 
            this.lblReaderMinTime.AutoSize = true;
            this.lblReaderMinTime.Location = new System.Drawing.Point(30, 375);
            this.lblReaderMinTime.Name = "lblReaderMinTime";
            this.lblReaderMinTime.Size = new System.Drawing.Size(27, 13);
            this.lblReaderMinTime.TabIndex = 15;
            this.lblReaderMinTime.Text = "Min:";
            // 
            // nudReaderMinTime
            // 
            this.nudReaderMinTime.Location = new System.Drawing.Point(63, 373);
            this.nudReaderMinTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudReaderMinTime.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudReaderMinTime.Name = "nudReaderMinTime";
            this.nudReaderMinTime.Size = new System.Drawing.Size(70, 20);
            this.nudReaderMinTime.TabIndex = 16;
            this.nudReaderMinTime.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblReaderMaxTime
            // 
            this.lblReaderMaxTime.AutoSize = true;
            this.lblReaderMaxTime.Location = new System.Drawing.Point(140, 375);
            this.lblReaderMaxTime.Name = "lblReaderMaxTime";
            this.lblReaderMaxTime.Size = new System.Drawing.Size(30, 13);
            this.lblReaderMaxTime.TabIndex = 17;
            this.lblReaderMaxTime.Text = "Max:";
            // 
            // nudReaderMaxTime
            // 
            this.nudReaderMaxTime.Location = new System.Drawing.Point(176, 373);
            this.nudReaderMaxTime.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudReaderMaxTime.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudReaderMaxTime.Name = "nudReaderMaxTime";
            this.nudReaderMaxTime.Size = new System.Drawing.Size(70, 20);
            this.nudReaderMaxTime.TabIndex = 18;
            this.nudReaderMaxTime.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // lblWriterTimeRange
            // 
            this.lblWriterTimeRange.AutoSize = true;
            this.lblWriterTimeRange.Location = new System.Drawing.Point(12, 405);
            this.lblWriterTimeRange.Name = "lblWriterTimeRange";
            this.lblWriterTimeRange.Size = new System.Drawing.Size(141, 13);
            this.lblWriterTimeRange.TabIndex = 19;
            this.lblWriterTimeRange.Text = "Writer Generation Time (ms):";
            // 
            // lblWriterMinTime
            // 
            this.lblWriterMinTime.AutoSize = true;
            this.lblWriterMinTime.Location = new System.Drawing.Point(30, 425);
            this.lblWriterMinTime.Name = "lblWriterMinTime";
            this.lblWriterMinTime.Size = new System.Drawing.Size(27, 13);
            this.lblWriterMinTime.TabIndex = 20;
            this.lblWriterMinTime.Text = "Min:";
            // 
            // nudWriterMinTime
            // 
            this.nudWriterMinTime.Location = new System.Drawing.Point(63, 423);
            this.nudWriterMinTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudWriterMinTime.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudWriterMinTime.Name = "nudWriterMinTime";
            this.nudWriterMinTime.Size = new System.Drawing.Size(70, 20);
            this.nudWriterMinTime.TabIndex = 21;
            this.nudWriterMinTime.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // lblWriterMaxTime
            // 
            this.lblWriterMaxTime.AutoSize = true;
            this.lblWriterMaxTime.Location = new System.Drawing.Point(140, 425);
            this.lblWriterMaxTime.Name = "lblWriterMaxTime";
            this.lblWriterMaxTime.Size = new System.Drawing.Size(30, 13);
            this.lblWriterMaxTime.TabIndex = 22;
            this.lblWriterMaxTime.Text = "Max:";
            // 
            // nudWriterMaxTime
            // 
            this.nudWriterMaxTime.Location = new System.Drawing.Point(176, 423);
            this.nudWriterMaxTime.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudWriterMaxTime.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudWriterMaxTime.Name = "nudWriterMaxTime";
            this.nudWriterMaxTime.Size = new System.Drawing.Size(70, 20);
            this.nudWriterMaxTime.TabIndex = 23;
            this.nudWriterMaxTime.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // lblReaderReadTimeRange
            // 
            this.lblReaderReadTimeRange.AutoSize = true;
            this.lblReaderReadTimeRange.Location = new System.Drawing.Point(260, 355);
            this.lblReaderReadTimeRange.Name = "lblReaderReadTimeRange";
            this.lblReaderReadTimeRange.Size = new System.Drawing.Size(136, 13);
            this.lblReaderReadTimeRange.TabIndex = 24;
            this.lblReaderReadTimeRange.Text = "Reader Reading Time (ms):";
            // 
            // lblReaderMinReadTime
            // 
            this.lblReaderMinReadTime.AutoSize = true;
            this.lblReaderMinReadTime.Location = new System.Drawing.Point(278, 375);
            this.lblReaderMinReadTime.Name = "lblReaderMinReadTime";
            this.lblReaderMinReadTime.Size = new System.Drawing.Size(27, 13);
            this.lblReaderMinReadTime.TabIndex = 25;
            this.lblReaderMinReadTime.Text = "Min:";
            // 
            // nudReaderMinReadTime
            // 
            this.nudReaderMinReadTime.Location = new System.Drawing.Point(311, 373);
            this.nudReaderMinReadTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudReaderMinReadTime.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudReaderMinReadTime.Name = "nudReaderMinReadTime";
            this.nudReaderMinReadTime.Size = new System.Drawing.Size(70, 20);
            this.nudReaderMinReadTime.TabIndex = 26;
            this.nudReaderMinReadTime.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // lblReaderMaxReadTime
            // 
            this.lblReaderMaxReadTime.AutoSize = true;
            this.lblReaderMaxReadTime.Location = new System.Drawing.Point(388, 375);
            this.lblReaderMaxReadTime.Name = "lblReaderMaxReadTime";
            this.lblReaderMaxReadTime.Size = new System.Drawing.Size(30, 13);
            this.lblReaderMaxReadTime.TabIndex = 27;
            this.lblReaderMaxReadTime.Text = "Max:";
            // 
            // nudReaderMaxReadTime
            // 
            this.nudReaderMaxReadTime.Location = new System.Drawing.Point(424, 373);
            this.nudReaderMaxReadTime.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudReaderMaxReadTime.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudReaderMaxReadTime.Name = "nudReaderMaxReadTime";
            this.nudReaderMaxReadTime.Size = new System.Drawing.Size(70, 20);
            this.nudReaderMaxReadTime.TabIndex = 28;
            this.nudReaderMaxReadTime.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // lblWriterWriteTimeRange
            // 
            this.lblWriterWriteTimeRange.AutoSize = true;
            this.lblWriterWriteTimeRange.Location = new System.Drawing.Point(260, 405);
            this.lblWriterWriteTimeRange.Name = "lblWriterWriteTimeRange";
            this.lblWriterWriteTimeRange.Size = new System.Drawing.Size(122, 13);
            this.lblWriterWriteTimeRange.TabIndex = 29;
            this.lblWriterWriteTimeRange.Text = "Writer Writing Time (ms):";
            // 
            // lblWriterMinWriteTime
            // 
            this.lblWriterMinWriteTime.AutoSize = true;
            this.lblWriterMinWriteTime.Location = new System.Drawing.Point(278, 425);
            this.lblWriterMinWriteTime.Name = "lblWriterMinWriteTime";
            this.lblWriterMinWriteTime.Size = new System.Drawing.Size(27, 13);
            this.lblWriterMinWriteTime.TabIndex = 30;
            this.lblWriterMinWriteTime.Text = "Min:";
            // 
            // nudWriterMinWriteTime
            // 
            this.nudWriterMinWriteTime.Location = new System.Drawing.Point(311, 423);
            this.nudWriterMinWriteTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudWriterMinWriteTime.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudWriterMinWriteTime.Name = "nudWriterMinWriteTime";
            this.nudWriterMinWriteTime.Size = new System.Drawing.Size(70, 20);
            this.nudWriterMinWriteTime.TabIndex = 31;
            this.nudWriterMinWriteTime.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblWriterMaxWriteTime
            // 
            this.lblWriterMaxWriteTime.AutoSize = true;
            this.lblWriterMaxWriteTime.Location = new System.Drawing.Point(388, 425);
            this.lblWriterMaxWriteTime.Name = "lblWriterMaxWriteTime";
            this.lblWriterMaxWriteTime.Size = new System.Drawing.Size(30, 13);
            this.lblWriterMaxWriteTime.TabIndex = 32;
            this.lblWriterMaxWriteTime.Text = "Max:";
            // 
            // nudWriterMaxWriteTime
            // 
            this.nudWriterMaxWriteTime.Location = new System.Drawing.Point(424, 423);
            this.nudWriterMaxWriteTime.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudWriterMaxWriteTime.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudWriterMaxWriteTime.Name = "nudWriterMaxWriteTime";
            this.nudWriterMaxWriteTime.Size = new System.Drawing.Size(70, 20);
            this.nudWriterMaxWriteTime.TabIndex = 33;
            this.nudWriterMaxWriteTime.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 527);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblWriterCount);
            this.Controls.Add(this.lblReaderCount);
            this.Controls.Add(this.nudWriters);
            this.Controls.Add(this.nudReaders);
            this.Controls.Add(this.btnStopSimulation);
            this.Controls.Add(this.btnStartSimulation);
            this.Controls.Add(this.lblStatusTitle);
            this.Controls.Add(this.txtStatusLog);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblWriterActive);
            this.Controls.Add(this.lblWriterTitle);
            this.Controls.Add(this.lblReadersCount);
            this.Controls.Add(this.lblReadersTitle);
            this.Controls.Add(this.lblReaderTimeRange);
            this.Controls.Add(this.lblReaderMinTime);
            this.Controls.Add(this.nudReaderMinTime);
            this.Controls.Add(this.lblReaderMaxTime);
            this.Controls.Add(this.nudReaderMaxTime);
            this.Controls.Add(this.lblWriterTimeRange);
            this.Controls.Add(this.lblWriterMinTime);
            this.Controls.Add(this.nudWriterMinTime);
            this.Controls.Add(this.lblWriterMaxTime);
            this.Controls.Add(this.nudWriterMaxTime);
            this.Controls.Add(this.lblReaderReadTimeRange);
            this.Controls.Add(this.lblReaderMinReadTime);
            this.Controls.Add(this.nudReaderMinReadTime);
            this.Controls.Add(this.lblReaderMaxReadTime);
            this.Controls.Add(this.nudReaderMaxReadTime);
            this.Controls.Add(this.lblWriterWriteTimeRange);
            this.Controls.Add(this.lblWriterMinWriteTime);
            this.Controls.Add(this.nudWriterMinWriteTime);
            this.Controls.Add(this.lblWriterMaxWriteTime);
            this.Controls.Add(this.nudWriterMaxWriteTime);
            this.Name = "MainForm";
            this.Text = "Readers-Writers Problem (Asymmetric Reading)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudReaders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWriters)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartServiceTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWaitTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartQueueLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReaderMinTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReaderMaxTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWriterMinTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWriterMaxTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReaderMinReadTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReaderMaxReadTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWriterMinWriteTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWriterMaxWriteTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReadersTitle;
        private System.Windows.Forms.Label lblReadersCount;
        private System.Windows.Forms.Label lblWriterTitle;
        private System.Windows.Forms.Label lblWriterActive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstQueue;
        private System.Windows.Forms.Label lblCurrentQueueTitle;
        private System.Windows.Forms.Label lblCurrentQueue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAvgQueue;
        private System.Windows.Forms.Label lblAvgQueueTitle;
        private System.Windows.Forms.Label lblMaxQueue;
        private System.Windows.Forms.Label lblMaxQueueTitle;
        private System.Windows.Forms.Label lblTotalWriters;
        private System.Windows.Forms.Label lblTotalWritersTitle;
        private System.Windows.Forms.Label lblTotalReaders;
        private System.Windows.Forms.Label lblTotalReadersTitle;
        private System.Windows.Forms.TextBox txtStatusLog;
        private System.Windows.Forms.Label lblStatusTitle;
        private System.Windows.Forms.Button btnStartSimulation;
        private System.Windows.Forms.Button btnStopSimulation;
        private System.Windows.Forms.NumericUpDown nudReaders;
        private System.Windows.Forms.NumericUpDown nudWriters;
        private System.Windows.Forms.Label lblReaderCount;
        private System.Windows.Forms.Label lblWriterCount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblServiceChart;
        private System.Windows.Forms.Label lblWaitChart;
        private System.Windows.Forms.Label lblQueueChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartServiceTimes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWaitTimes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartQueueLength;
        // Додати ці змінні елементів керування в клас MainForm
        private System.Windows.Forms.NumericUpDown nudReaderMinTime;
        private System.Windows.Forms.NumericUpDown nudReaderMaxTime;
        private System.Windows.Forms.NumericUpDown nudWriterMinTime;
        private System.Windows.Forms.NumericUpDown nudWriterMaxTime;
        private System.Windows.Forms.Label lblReaderTimeRange;
        private System.Windows.Forms.Label lblWriterTimeRange;
        private System.Windows.Forms.Label lblReaderMinTime;
        private System.Windows.Forms.Label lblReaderMaxTime;
        private System.Windows.Forms.Label lblWriterMinTime;
        private System.Windows.Forms.Label lblWriterMaxTime;

        private System.Windows.Forms.Label lblReaderReadTimeRange;
        private System.Windows.Forms.Label lblReaderMinReadTime;
        private System.Windows.Forms.Label lblReaderMaxReadTime;
        private System.Windows.Forms.NumericUpDown nudReaderMinReadTime;
        private System.Windows.Forms.NumericUpDown nudReaderMaxReadTime;
        private System.Windows.Forms.Label lblWriterWriteTimeRange;
        private System.Windows.Forms.Label lblWriterMinWriteTime;
        private System.Windows.Forms.Label lblWriterMaxWriteTime;
        private System.Windows.Forms.NumericUpDown nudWriterMinWriteTime;
        private System.Windows.Forms.NumericUpDown nudWriterMaxWriteTime;
    }
}