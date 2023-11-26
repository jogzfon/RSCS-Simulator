using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace RSCSS
{
    public partial class AssemblyResultsDialog : Form
    {
        private Button okButton;
        public AssemblyResultsDialog()
        {
            InitializeComponent();
        }
        public AssemblyResultsDialog(Form parent, string title, bool modal, AssemblyResults results)
        {
            Text = title;
            StartPosition = FormStartPosition.CenterParent;

            AssemblyError[] errors = results.GetErrors();

            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            if (errors == null || errors.Length == 0)
            {
                Label successLabel = new Label();
                successLabel.Text = "Assembly successful.";
                successLabel.TextAlign = ContentAlignment.MiddleCenter;
                successLabel.Font = new System.Drawing.Font("SansSerif", 12, FontStyle.Bold);

                tableLayoutPanel.Controls.Add(successLabel, 0, 0);

                okButton = new Button();
                okButton.Text = "OK";
                okButton.Click += OkButton_Click;

                tableLayoutPanel.Controls.Add(okButton, 0, 1);
            }
            else
            {
                Label errorLabel = new Label();
                errorLabel.Text = "There are " + errors.Length + " error(s):";
                errorLabel.TextAlign = ContentAlignment.MiddleCenter;
                errorLabel.Font = new System.Drawing.Font("SansSerif", 12, FontStyle.Bold);

                tableLayoutPanel.Controls.Add(errorLabel, 0, 0);

                ListBox errorList = new ListBox();
                errorList.Height = 5 * errorList.ItemHeight;

                for (int index = 0; index < errors.Length; index++)
                {
                    AssemblyError err = errors[index];
                    errorList.Items.Add("Line " + err.GetLineNumber() + ": " + err.GetString());
                }

                tableLayoutPanel.Controls.Add(errorList, 0, 1);

                okButton = new Button();
                okButton.Text = "OK";
                okButton.Click += OkButton_Click;

                tableLayoutPanel.Controls.Add(okButton, 0, 2);
            }

            Controls.Add(tableLayoutPanel);

            FormClosing += (sender, e) => Dispose();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // AssemblyResultsDialog
            // 
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Name = "AssemblyResultsDialog";
            this.ResumeLayout(false);

        }
    }
}
