using System;
using System.Windows;
using System.ComponentModel;

namespace YoutubeDemo
{
    public partial class Video7 : Window
    {
        BackgroundWorker bgWorker = new BackgroundWorker();
        int counterMax = 100;
        public Video7()
        {
            InitializeComponent();
            bgWorker.DoWork += BgWorker_DoWork;
            bgWorker.ProgressChanged += BgWorker_ProgressChanged;
            bgWorker.RunWorkerCompleted += BgWorker_RunWorkerCompleted;

            bgWorker.WorkerSupportsCancellation = true;
            bgWorker.WorkerReportsProgress = true;

            this.progressbar.Maximum = this.counterMax;
        }
        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                this.lblStatus.Content = "Stopped!";
                this.progressbar.Value = 0;
                this.lblCounter.Content = 0;
            }
                
            else
                this.lblStatus.Content = "Completed!";

            this.btnStart.Content = "Start";

        }

        private void BgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.lblCounter.Content = e.ProgressPercentage;
            this.progressbar.Value = e.ProgressPercentage;
        }

        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i <= this.counterMax; i++)
            {
                Console.WriteLine(i);

                bgWorker.ReportProgress(i);

                System.Threading.Thread.Sleep(100);

                if (bgWorker.CancellationPending)
                {
                    Console.WriteLine("Thread is exiting....");
                    e.Cancel = true;
                    break;
                }
            }
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            if (!bgWorker.IsBusy)
            {
                bgWorker.RunWorkerAsync();
                btnStart.Content = "Stop";
                this.lblStatus.Content = "Running...";
            } else
            {
                bgWorker.CancelAsync();
                btnStart.Content = "Start";
                this.lblStatus.Content = "Stopped...";
            }
        }
    }
}