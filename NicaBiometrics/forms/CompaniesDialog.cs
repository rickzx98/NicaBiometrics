using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using NicaBiometrics.models;

namespace NicaBiometrics.forms
{
    public partial class CompaniesDialog : Form
    {
        private readonly Companies _companies;
        private List<Companies.Company> _companyResult;

        public CompaniesDialog()
        {
            _companies = new Companies();
            InitializeComponent();
        }

        public CompaniesDialog(Action<List<Companies.Company>> worker)
        {
            _companies = new Companies();
            Worker = worker ?? throw new ArgumentNullException();
            InitializeComponent();
        }

        private Action<List<Companies.Company>> Worker { get; }

        private void CompaniesDialog_Load(object sender, EventArgs e)
        {
            Start();
            Task.Factory.StartNew(() =>
                {
                    _companies.LoadCompanies(out var companies);
                    _companyResult = companies;
                })
                .ContinueWith(t => { Done(); },
                    TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void Start()
        {
            PROGRESS_SEARCH.Visible = true;
            PROGRESS_SEARCH.Value = 0;
            VALUE_FIND_COMPANY.Enabled = false;
            BUTTON_SEARCH_COMPANY.Enabled = false;
            BUTTON_SAVE.Enabled = false;
            BUTTON_CANCEL.Enabled = false;
            TIME_PROGRESS.Start();
        }

        private void Done()
        {
            PROGRESS_SEARCH.Visible = false;
            PROGRESS_SEARCH.Value = 0;
            VALUE_FIND_COMPANY.Enabled = true;
            BUTTON_SEARCH_COMPANY.Enabled = true;
            BUTTON_SAVE.Enabled = true;
            BUTTON_CANCEL.Enabled = true;
            TIME_PROGRESS.Stop();
            SetCompanyList();
        }

        private void TIME_PROGRESS_Tick(object sender, EventArgs e)
        {
            if (PROGRESS_SEARCH.Value == 100) PROGRESS_SEARCH.Value = 0;
            PROGRESS_SEARCH.Increment(5);
        }

        private void SetCompanyList()
        {
            LIST_COMPANIES.DataSource = _companyResult;
            LIST_COMPANIES.DisplayMember = "Name";
            LIST_COMPANIES.ValueMember = "IsChecked";

            for (var index = 0; index < _companyResult.Count; index++)
                LIST_COMPANIES.SetItemChecked(index, _companyResult[index].IsChecked);
        }

        private void VALUE_FIND_COMPANY_TextChanged(object sender, EventArgs e)
        {
            _companies.SetSearch(((TextBox) sender).Text);
        }

        private void BUTTON_SEARCH_COMPANY_Click(object sender, EventArgs e)
        {
            Start();
            Task.Factory.StartNew(() =>
                {
                    _companies.Search(out var companies);
                    _companyResult = companies;
                })
                .ContinueWith(t => { Done(); },
                    TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void VALUE_FIND_COMPANY_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Start();
                Task.Factory.StartNew(() =>
                    {
                        _companies.Search(out var companies);
                        _companyResult = companies;
                    })
                    .ContinueWith(t => { Done(); },
                        TaskScheduler.FromCurrentSynchronizationContext());
            }
        }

        private void Cancel()
        {
            Close();
        }

        private void BUTTON_CANCEL_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void Save()
        {
            var companies = new List<Companies.Company>();
            foreach (Companies.Company checkedItem in LIST_COMPANIES.CheckedItems) companies.Add(checkedItem);
            Worker.Invoke(companies);
            Close();
        }

        private void BUTTON_SAVE_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}