using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using System.Management.Automation;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System.Collections.ObjectModel;

namespace Remote_Management
{
    public partial class frmLogin : MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Create a PowerShell session
            lvLoginDebug.Items.Add("Creating PowerShell session... TEST");
            GlobalVariables.ps = PowerShell.Create();

            // Remove any open powershell sessions
            lvLoginDebug.Items.Add("Removing existing Exchange sessions...");
            GlobalVariables.ps.AddScript("Get-PSSession | Remove-PSSession");
            GlobalVariables.ps.Invoke();

            // Set execution policy, assign variables
            lvLoginDebug.Items.Add("Setting execution policy and assigning variables...");
            GlobalVariables.ps.AddScript($"Set-ExecutionPolicy RemoteSigned; $pass = ConvertTo-SecureString \"{txtPassword.Text}\" -AsPlainText -Force; $UC = New-Object System.Management.Automation.PSCredential (\"{txtEmail.Text}\", $pass); ");
            GlobalVariables.ps.Invoke();

            // Create the PowerShell session with Microsoft Exchange
            lvLoginDebug.Items.Add("Creating session with Microsoft Exchange...");
            GlobalVariables.ps.AddScript("$Session = New-PSSession -ConfigurationName Microsoft.Exchange -ConnectionUri https://outlook.office365.com/powershell-liveid/ -Credential $UC -Authentication Basic -AllowRedirection; ");
            GlobalVariables.ps.Invoke();

            // Install MSOnline, import module, connect to service
            lvLoginDebug.Items.Add("Installing packages and connecting to services...");
            GlobalVariables.ps.AddScript("Install-Package MsOnline; Import-Module MsOnline; Connect-MsolService -Credential $UC");
            GlobalVariables.ps.Invoke();
            
            // Import the PowerShell session
            lvLoginDebug.Items.Add("Importing Exchange session...");
            GlobalVariables.ps.AddScript("Import-PSSession $Session");
            GlobalVariables.ps.Invoke();

            if (GlobalVariables.ps.Streams.Error.Count == 0)
            {
                this.Hide();
                frmDialog frm = new frmDialog();
                frm.ShowDialog();
            }
            else MessageBox.Show(GlobalVariables.ps.Streams.Error[0].Exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (GlobalVariables.ps.InvocationStateInfo.State == PSInvocationState.Running)
            {
                GlobalVariables.ps.AddScript("Remove-PSSession $Session");
                GlobalVariables.ps.Invoke();
                GlobalVariables.ps.Dispose();
            }
        }
    }
}
