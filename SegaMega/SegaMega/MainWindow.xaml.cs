using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SegaMega
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BackgroundWorker backgroundWorker;
        public MainWindow()
        {
            InitializeComponent();
            backgroundWorker = (BackgroundWorker)this.FindResource("backgroundWorker");
        }

        private void bSubmit_Click(object sender, RoutedEventArgs e)
        {
            bSubmit.IsEnabled = false;
            bCancel.IsEnabled = true;
            Result.Items.Clear();
            int from, to;
            try
            {
                from = Int32.Parse(From.Text.Trim());
                to = Int32.Parse(To.Text.Trim());
            }
            catch(Exception ex)
            {
                MessageBox.Show("В полях для ввода некорректные значения");
                return;
            }
            PrimesInput input = new PrimesInput(from, to);
            backgroundWorker.RunWorkerAsync(input);
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            PrimesInput input = (PrimesInput)e.Argument;
            int[] primes = Worker.FindPrimes(input,backgroundWorker);
            if (backgroundWorker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }
            e.Result = primes;
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (e.Cancelled)
            {
                MessageBox.Show("Поиск отменён");
            }
            else
            {
                int[] primes = (int[])e.Result;
                foreach(var p in primes)
                {
                    Result.Items.Add(p);
                }
            }
            bSubmit.IsEnabled = true;
            bCancel.IsEnabled = false;
            progressBar.Value = 0;
        }

        private void bCancel_Click(object sender, RoutedEventArgs e)
        {
            backgroundWorker.CancelAsync();
            bSubmit.IsEnabled = true;
            bCancel.IsEnabled = false;
        }
    }
}
