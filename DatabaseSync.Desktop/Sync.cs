using DatabaseSync.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSync.Desktop
{
    public partial class Sync : Form
    {
        public Sync()
        {
            InitializeComponent();

            txtLocalDatabase.Text = @"Data Source=C:\github\Acat\Acat.Desktop\ACATDB.db";
            txtRemoteDatabase.Text = @"Server=thedbinstance.cfkstczprruw.us-east-1.rds.amazonaws.com;Database=ACAT;User Id=sheriff123;Password=acatteam;";
        }

        private async void BtnUpload_Click(object sender, EventArgs e)
        {
            DisableButtons();

            if (!IsValidConnectionStrings())
            {
                return;
            }

            try
            {
                await Synchronizer.SyncLocalToRemoteAsync(txtLocalDatabase.Text, txtRemoteDatabase.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while synchronizing records. Exception: {ex}");
                EnableButtons();
                return;
            }

            MessageBox.Show("Synchronization executed successfully");

            EnableButtons();
        }

        private async void BtnDownload_Click(object sender, EventArgs e)
        {
            DisableButtons();

            if (!IsValidConnectionStrings())
            {
                return;
            }

            try
            {
                await Synchronizer.SyncRemoteToLocalAsync(txtLocalDatabase.Text, txtRemoteDatabase.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while synchronizing records. Exception: {ex}");
                EnableButtons();
                return;
            }

            MessageBox.Show("Synchronization executed successfully");

            EnableButtons();
        }

        private void DisableButtons()
        {
            btnUpload.Enabled = false;
            btnDownload.Enabled = false;
        }

        private void EnableButtons()
        {
            btnUpload.Enabled = true;
            btnDownload.Enabled = true;
        }

        private bool IsValidConnectionStrings()
        {
            var result = ValidateLocalConnectionString();
            if (!result.IsValid)
            {
                MessageBox.Show(result.ErrorMessage);

                return false;
            }

            var resultRemote = ValidateRemoteConnectionString();
            if (!resultRemote.IsValid)
            {
                MessageBox.Show(resultRemote.ErrorMessage);

                return false;
            }

            return true;
        }

        private (bool IsValid, string ErrorMessage) ValidateLocalConnectionString()
        {
            if (string.IsNullOrEmpty(txtLocalDatabase.Text))
            {
                return (false, "The 'Local Database' field is required");
            }

            if (!Validator.ValidateLocalConnectionString(txtLocalDatabase.Text))
            {
                return (false, "The 'Local Database' field value is invalid");
            }

            return (true, string.Empty);
        }

        private (bool IsValid, string ErrorMessage) ValidateRemoteConnectionString()
        {
            if (string.IsNullOrEmpty(txtRemoteDatabase.Text))
            {
                return (false, "The 'Remote Database' field is required");
            }

            if (!Validator.ValidateRemoteConnectionString(txtRemoteDatabase.Text))
            {
                return (false, "The 'Remote Database' field value is invalid");
            }

            return (true, string.Empty);
        }
    }
}
