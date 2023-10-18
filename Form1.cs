using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace _0102
{
    public partial class Form1 : Form
    {
        private int updateIntervalInSeconds = 35;
        private System.Threading.Timer timer;
        private int numberItem = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer = new System.Threading.Timer(UpdateProcessesList, null, 0, updateIntervalInSeconds * 1000);
        }

        private void UpdateProcessesList(object state)
        {
            numberItem = 0;
            if (listViewProcesses.InvokeRequired)
            {
                listViewProcesses.Invoke(new Action(() => { listViewProcesses.Items.Clear(); }));
            }
            else
            {
                listViewProcesses.Items.Clear();
            }

            Process[] processes = Process.GetProcesses();

            foreach (Process process in processes)
            {
                try
                {
                    if (!process.HasExited)
                    {
                        if (listViewProcesses.InvokeRequired)
                        {
                            listViewProcesses.Invoke(new Action(() =>
                            {
                                listViewProcesses.Items.Add(new ListViewItem(new string[] {
                        (numberItem + 1).ToString(),
                        process.ProcessName,
                        process.Id.ToString(),
                        process.StartTime.ToString(),
                        process.TotalProcessorTime.ToString(@"hh\:mm\:ss"),
                        process.Threads.Count.ToString(),
                        Process.GetProcessesByName(process.ProcessName).Length.ToString()
                    }));
                            }));
                            numberItem++;
                        }
                        else
                        {
                            listViewProcesses.Items.Add(new ListViewItem(new string[] {
                    (numberItem + 1).ToString(),
                    process.ProcessName,
                    process.Id.ToString(),
                    process.StartTime.ToString(),
                    process.TotalProcessorTime.ToString(@"hh\:mm\:ss"),
                    process.Threads.Count.ToString(),
                    Process.GetProcessesByName(process.ProcessName).Length.ToString()
                }));
                            numberItem++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Обробка винятку
                    Console.WriteLine("Помилка: " + ex.Message);
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSetInterval_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxInterval.Text, out int interval) && int.Parse(textBoxInterval.Text) > 0)
            {
                updateIntervalInSeconds = interval;
                timer.Change(0, updateIntervalInSeconds * 1000);
            }
            else
            {
                MessageBox.Show("Неправильно введенні дані. Будь ласка введіть коректне число у секундах.");
            }
        }

        private void ButtonKillProcess_Click(object sender, EventArgs e)
        {
            if (int.TryParse(idProcessForKill.Text, out int processId))
            {
                try
                {
                    Process process = Process.GetProcessById(processId);
                    process.Kill();
                    timer.Change(0, updateIntervalInSeconds * 1000);
                    idProcessForKill.Clear();
                    MessageBox.Show($"Процес із ідентифікатором {processId} був завершений.");
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show($"Не вдалося знайти процес із ідентифікатором {processId}. Помилка: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Сталася помилка при спробі завершити процес із ідентифікатором {processId}. Помилка: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректний ідентифікатор процесу.");
            }
        }
    }
}