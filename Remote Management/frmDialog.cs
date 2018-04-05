using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.Management.Automation;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System.Collections.ObjectModel;

namespace Remote_Management
{
    public partial class frmDialog : MetroForm
    {
        public frmDialog()
        {
            InitializeComponent();
        }

        private void frmDialog_FormClosing(object sender, FormClosingEventArgs e)
        {

            GlobalVariables.ps.AddScript("Remove-PSSession $Session");
            GlobalVariables.ps.Invoke();
            GlobalVariables.ps.Dispose();
            Environment.Exit(0);
        }

        private void btnHire_Click(object sender, EventArgs e)
        {
            var username = txtFirstName.Text.Substring(0, 1).ToLower() + txtLastName.Text.ToLower();

        }

        private void frmDialog_Load(object sender, EventArgs e)
        {
            // Populate the domain ComboBox
            GlobalVariables.ps.AddScript("Get-AcceptedDomain");
            Collection<PSObject> output = GlobalVariables.ps.Invoke();
            foreach (PSObject pbo in output) cbDomains.Items.Add(pbo.Properties["DomainName"].Value);
        }
    }
}
