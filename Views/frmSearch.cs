using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BooksProject.Controllers;
using BooksProject.Models;
using DevExpress.XtraEditors;

namespace BooksProject
{
    public partial class frmSearch : DevExpress.XtraEditors.XtraForm
    {

        private SearchController _Controller;
        public frmSearch()
        {
            InitializeComponent();
            this._Controller = new SearchController();
        }

        private async void frmSearch_Shown(object sender, EventArgs e)
        {
            cmbAccuracy.Properties.Items.AddRange([1, 2, 3]);
            cmbAccuracy.SelectedIndex = 0;
            cmbPriority.Properties.Items.AddRange(["عنوان کتاب", "نام نویسنده"]);
            cmbPriority.SelectedIndex = 0;

            var places = await this._Controller.GetPublishPlaces();
            if (places != null)
                cmbPublish_Place.Properties.Items.AddRange(places);
        }
        private void gridView_Books_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
        private void txtFullSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((sender as DevExpress.XtraEditors.TextEdit).Name == txtFullSearch.Name)
                    btnSearch_Normal.PerformClick();
                else
                    btnSearch_Advanced.PerformClick();
            }
        }
        private void AllComboboxes_Validating(object sender, CancelEventArgs e)
        {
            var targetCombo = sender as DevExpress.XtraEditors.ComboBoxEdit;
            if (targetCombo.SelectedIndex == -1)
            {
                if (targetCombo.Name == "cmbPublish_Place" && string.IsNullOrWhiteSpace(Convert.ToString(targetCombo.SelectedItem)))
                    return;

                targetCombo.ErrorText = "مقدار وارد شده قابل قبول نمی باشد";
                e.Cancel = true;
            }
        }
        private void grpFilter_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Tag.ToString() == "btnClear")
            {
                txtFullSearch.Clear();
                cmbPriority.SelectedIndex = 0;

                txtTitle.Clear();
                txtAuthor.Clear();
                txtPublisher.Clear();
                txtPublish_Date_From.Clear();
                txtPublish_Date_To.Clear();
                cmbPublish_Place.SelectedIndex = -1;
                cmbAccuracy.SelectedIndex = 0;

                bsBooks.Clear();
                gridView_Books.RefreshData();
            }
        }
        private async void btnSearch_Normal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullSearch.Text))
            {
                if (XtraMessageBox.Show("هیچ مقداری برای جستجو وجود ندارد، ادامه می دهید ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
            }

            var searchParameters = new SearchViewModel
            {
                IsNormalSearch = true,
                Priority = cmbPriority.SelectedIndex == 0 ? PriorityEnum.Title : PriorityEnum.Author,
                FullSearch = txtFullSearch.Text
            };

            bsBooks.DataSource = await this._Controller.GetBooks(searchParameters);
            gridView_Books.RefreshData();
        }
        private async void btnSearch_Advanced_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) && string.IsNullOrWhiteSpace(txtAuthor.Text) && string.IsNullOrWhiteSpace(txtPublisher.Text)
                && string.IsNullOrWhiteSpace(txtPublish_Date_From.Text) && string.IsNullOrWhiteSpace(txtPublish_Date_To.Text)
                && string.IsNullOrWhiteSpace(Convert.ToString(cmbPublish_Place.SelectedItem)))
            {
                if (XtraMessageBox.Show("هیچ فیلتری برای جستجو وجود ندارد، ادامه می دهید ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
            }

            var searchParameters = new SearchViewModel
            {
                IsNormalSearch = false,
                Accuracy = Convert.ToInt32(cmbAccuracy.SelectedItem) == 1 ? AccuracyEnum.MatchPhrase
                    : Convert.ToInt32(cmbAccuracy.SelectedItem) == 2 ? AccuracyEnum.Match : AccuracyEnum.Wildcard,
                Title = txtTitle.Text,
                Author = txtAuthor.Text,
                Publisher = txtPublisher.Text,
                PublishPlace = Convert.ToString(cmbPublish_Place.SelectedItem),
                PublishDateFrom = txtPublish_Date_From.Text,
                PublishDateTo = txtPublish_Date_To.Text
            };

            bsBooks.DataSource = await this._Controller.GetBooks(searchParameters);
            gridView_Books.RefreshData();
        }
    }
}
