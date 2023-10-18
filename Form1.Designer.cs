namespace _0102
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listViewProcesses = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            Id = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            textBoxInterval = new TextBox();
            buttonSetInterval = new Button();
            ButtonKillProcess = new Button();
            idProcessForKill = new TextBox();
            SuspendLayout();
            // 
            // listViewProcesses
            // 
            listViewProcesses.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, Id, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listViewProcesses.Location = new Point(12, 12);
            listViewProcesses.Name = "listViewProcesses";
            listViewProcesses.Size = new Size(795, 587);
            listViewProcesses.TabIndex = 0;
            listViewProcesses.UseCompatibleStateImageBehavior = false;
            listViewProcesses.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "№";
            columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.Width = 150;
            // 
            // Id
            // 
            Id.Text = "Id";
            Id.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Час початку";
            columnHeader3.Width = 125;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Всього процесорного часу";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Кількість потоків";
            columnHeader5.Width = 50;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Кількість копій процесу";
            columnHeader6.Width = 150;
            // 
            // textBoxInterval
            // 
            textBoxInterval.Location = new Point(826, 38);
            textBoxInterval.Name = "textBoxInterval";
            textBoxInterval.PlaceholderText = "Введіть час оновлення у секундах";
            textBoxInterval.Size = new Size(206, 23);
            textBoxInterval.TabIndex = 1;
            // 
            // buttonSetInterval
            // 
            buttonSetInterval.Location = new Point(826, 85);
            buttonSetInterval.Name = "buttonSetInterval";
            buttonSetInterval.Size = new Size(206, 23);
            buttonSetInterval.TabIndex = 2;
            buttonSetInterval.Text = "Оновити час оновлення";
            buttonSetInterval.UseVisualStyleBackColor = true;
            buttonSetInterval.Click += buttonSetInterval_Click;
            // 
            // ButtonKillProcess
            // 
            ButtonKillProcess.Location = new Point(826, 175);
            ButtonKillProcess.Name = "ButtonKillProcess";
            ButtonKillProcess.Size = new Size(206, 23);
            ButtonKillProcess.TabIndex = 3;
            ButtonKillProcess.Text = "Завершити обраний процес";
            ButtonKillProcess.UseVisualStyleBackColor = true;
            ButtonKillProcess.Click += ButtonKillProcess_Click;
            // 
            // idProcessForKill
            // 
            idProcessForKill.Location = new Point(826, 135);
            idProcessForKill.Name = "idProcessForKill";
            idProcessForKill.PlaceholderText = "Введіть ID процеса для завершення";
            idProcessForKill.Size = new Size(206, 23);
            idProcessForKill.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 611);
            Controls.Add(idProcessForKill);
            Controls.Add(ButtonKillProcess);
            Controls.Add(buttonSetInterval);
            Controls.Add(textBoxInterval);
            Controls.Add(listViewProcesses);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewProcesses;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader Id;
        private TextBox textBoxInterval;
        private Button buttonSetInterval;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button ButtonKillProcess;
        private TextBox idProcessForKill;
    }
}