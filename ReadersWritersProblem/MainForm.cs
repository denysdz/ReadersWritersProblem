using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ReadersWritersProblem
{
    public partial class MainForm : Form
    {
      
        private Logger _logger;
        private SimulationStatistics _statistics;
        private SimulationManager _simulationManager;

       
        private System.Windows.Forms.Timer _statusUpdateTimer;
        private System.Windows.Forms.Timer _chartUpdateTimer;

    
        private SynchronizationContext _uiContext;

        public MainForm()
        {
            InitializeComponent();

            _uiContext = SynchronizationContext.Current;
         
            _logger = new Logger();
            _statistics = new SimulationStatistics();
            _simulationManager = new SimulationManager(_logger, _statistics);

            _statusUpdateTimer = new System.Windows.Forms.Timer();
            _statusUpdateTimer.Interval = 50;
            _statusUpdateTimer.Tick += UpdateStatusUI;
            _statusUpdateTimer.Start();

            _chartUpdateTimer = new System.Windows.Forms.Timer();
            _chartUpdateTimer.Interval = 500; 
            _chartUpdateTimer.Tick += UpdateChartsUI;
            _chartUpdateTimer.Start();

            InitializeCharts();
            txtStatusLog.MaxLength = 10000;
        }

        private void InitializeCharts()
        {
            chartQueueLength.Series.Clear();
            var queueSeries = new Series("Queue Length");
            queueSeries.ChartType = SeriesChartType.Line;
            chartQueueLength.Series.Add(queueSeries);
            if (chartQueueLength.ChartAreas.Count == 0)
                chartQueueLength.ChartAreas.Add(new ChartArea());
            chartQueueLength.ChartAreas[0].AxisY.Minimum = 0;
            chartWaitTimes.Series.Clear();
            var readerWaitSeries = new Series("Reader Wait Time");
            readerWaitSeries.ChartType = SeriesChartType.Column;
            var writerWaitSeries = new Series("Writer Wait Time");
            writerWaitSeries.ChartType = SeriesChartType.Column;
            chartWaitTimes.Series.Add(readerWaitSeries);
            chartWaitTimes.Series.Add(writerWaitSeries);
            if (chartWaitTimes.ChartAreas.Count == 0)
                chartWaitTimes.ChartAreas.Add(new ChartArea());
            chartWaitTimes.ChartAreas[0].AxisY.Minimum = 0;
            chartServiceTimes.Series.Clear();
            var readerServiceSeries = new Series("Reader Service Time");
            readerServiceSeries.ChartType = SeriesChartType.Column;
            var writerServiceSeries = new Series("Writer Service Time");
            writerServiceSeries.ChartType = SeriesChartType.Column;
            chartServiceTimes.Series.Add(readerServiceSeries);
            chartServiceTimes.Series.Add(writerServiceSeries);
            if (chartServiceTimes.ChartAreas.Count == 0)
                chartServiceTimes.ChartAreas.Add(new ChartArea());
            chartServiceTimes.ChartAreas[0].AxisY.Minimum = 0;
        }

        private void btnStartSimulation_Click(object sender, EventArgs e)
        {
            Task.Run(() => {
                int numReaders = (int)nudReaders.Value;
                int numWriters = (int)nudWriters.Value;
                int minReaderThinkingTime = (int)nudReaderMinTime.Value;
                int maxReaderThinkingTime = (int)nudReaderMaxTime.Value;
                int minWriterThinkingTime = (int)nudWriterMinTime.Value;
                int maxWriterThinkingTime = (int)nudWriterMaxTime.Value;
                int minReadingTime = (int)nudReaderMinReadTime.Value;
                int maxReadingTime = (int)nudReaderMaxReadTime.Value;
                int minWritingTime = (int)nudWriterMinWriteTime.Value;
                int maxWritingTime = (int)nudWriterMaxWriteTime.Value;

                _simulationManager.StartSimulation(numReaders, numWriters,
                                                minReaderThinkingTime, maxReaderThinkingTime,
                                                minWriterThinkingTime, maxWriterThinkingTime,
                                                minReadingTime, maxReadingTime,
                                                minWritingTime, maxWritingTime);
            });
            _uiContext.Post(_ => {
                btnStartSimulation.Enabled = false;
                btnStopSimulation.Enabled = true;
            }, null);
        }

        private void btnStopSimulation_Click(object sender, EventArgs e)
        {
            Task.Run(() => _simulationManager.StopSimulation());
            _uiContext.Post(_ => {
                btnStartSimulation.Enabled = true;
                btnStopSimulation.Enabled = false;
            }, null);
        }

        private void AddStatus(string message)
        {
            _logger.AddStatus(message);
        }
        private void UpdateStatusUI(object sender, EventArgs e)
        {
            try
            {
                string[] newLogs = _logger.GetLatestLogs(10);
                if (newLogs.Length > 0)
                {
                    StringBuilder statusBuilder = new StringBuilder();
                    foreach (string log in newLogs)
                    {
                        statusBuilder.AppendLine(log);
                    }
                    txtStatusLog.Text = statusBuilder.ToString() + txtStatusLog.Text;
                    if (txtStatusLog.TextLength > txtStatusLog.MaxLength * 0.9)
                    {
                        txtStatusLog.Text = txtStatusLog.Text.Substring(0, (int)(txtStatusLog.MaxLength * 0.7));
                    }
                }

                lblReadersCount.Text = _simulationManager.ReadersCount.ToString();
                lblWriterActive.Text = _simulationManager.WriterActive ? "Yes" : "No";

                lblTotalReaders.Text = _statistics.TotalReadersServed.ToString();
                lblTotalWriters.Text = _statistics.TotalWritersServed.ToString();
                lblMaxQueue.Text = _statistics.MaxQueueLength.ToString();
                lblAvgQueue.Text = _statistics.GetAverageQueueLength().ToString("F2");

                lstQueue.Items.Clear();
                foreach (string client in _simulationManager.ClientQueue)
                {
                    lstQueue.Items.Add(client);
                }
                lblCurrentQueue.Text = _simulationManager.ClientQueueCount.ToString();

                if (DateTime.Now.Second % 5 == 0 && DateTime.Now.Millisecond < 100)
                {
                    var activeProcessList = _simulationManager.ActiveProcesses.ToList();
                    if (activeProcessList.Count > 0)
                    {
                        string activeProcessesStr = string.Join(", ", activeProcessList);
                        AddStatus($"Active processes: {activeProcessesStr}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"UI update error: {ex.Message}");
            }
        }
        private void UpdateChartsUI(object sender, EventArgs e)
        {
            try
            {
                chartQueueLength.Series[0].Points.Clear();

                var queueHistory = _statistics.QueueLengthHistory.ToArray();
                int startIdx = Math.Max(0, queueHistory.Length - 50);
                for (int i = startIdx; i < queueHistory.Length; i++)
                {
                    chartQueueLength.Series[0].Points.AddY(queueHistory[i]);
                }

                chartWaitTimes.Series[0].Points.Clear();
                chartWaitTimes.Series[1].Points.Clear();

                double avgReaderWait = _statistics.GetAverageReaderWaitTime();
                double avgWriterWait = _statistics.GetAverageWriterWaitTime();

                chartWaitTimes.Series[0].Points.AddY(avgReaderWait);
                chartWaitTimes.Series[1].Points.AddY(avgWriterWait);

                chartServiceTimes.Series[0].Points.Clear();
                chartServiceTimes.Series[1].Points.Clear();

                double avgReaderService = _statistics.GetAverageReaderServiceTime();
                double avgWriterService = _statistics.GetAverageWriterServiceTime();

                chartServiceTimes.Series[0].Points.AddY(avgReaderService);
                chartServiceTimes.Series[1].Points.AddY(avgWriterService);
            }
            catch (Exception ex)
            {
                AddStatus($"Error updating charts: {ex.Message}");
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _statusUpdateTimer.Stop();
            _chartUpdateTimer.Stop();
            _simulationManager.Dispose();
        }
    }
}