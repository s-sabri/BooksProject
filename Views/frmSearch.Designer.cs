namespace BooksProject
{
    partial class frmSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions1 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            grpFilter = new DevExpress.XtraEditors.GroupControl();
            grpFilter_Normal = new DevExpress.XtraEditors.GroupControl();
            labelControl9 = new DevExpress.XtraEditors.LabelControl();
            cmbPriority = new DevExpress.XtraEditors.ComboBoxEdit();
            txtFullSearch = new DevExpress.XtraEditors.TextEdit();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            btnSearch_Normal = new DevExpress.XtraEditors.SimpleButton();
            grpFilter_Advanced = new DevExpress.XtraEditors.GroupControl();
            cmbAccuracy = new DevExpress.XtraEditors.ComboBoxEdit();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            btnSearch_Advanced = new DevExpress.XtraEditors.SimpleButton();
            tblSeparate = new System.Windows.Forms.TableLayoutPanel();
            txtPublish_Date_To = new DevExpress.XtraEditors.TextEdit();
            cmbPublish_Place = new DevExpress.XtraEditors.ComboBoxEdit();
            txtPublish_Date_From = new DevExpress.XtraEditors.TextEdit();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            txtTitle = new DevExpress.XtraEditors.TextEdit();
            txtAuthor = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            txtPublisher = new DevExpress.XtraEditors.TextEdit();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            grpGrid = new DevExpress.XtraEditors.GroupControl();
            gridControl_Books = new DevExpress.XtraGrid.GridControl();
            bsBooks = new System.Windows.Forms.BindingSource(components);
            gridView_Books = new DevExpress.XtraGrid.Views.Grid.GridView();
            colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            colAuthor = new DevExpress.XtraGrid.Columns.GridColumn();
            colPublisher = new DevExpress.XtraGrid.Columns.GridColumn();
            colPublish_date = new DevExpress.XtraGrid.Columns.GridColumn();
            colPublish_place = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)grpFilter).BeginInit();
            grpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grpFilter_Normal).BeginInit();
            grpFilter_Normal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbPriority.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtFullSearch.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grpFilter_Advanced).BeginInit();
            grpFilter_Advanced.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbAccuracy.Properties).BeginInit();
            tblSeparate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtPublish_Date_To.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbPublish_Place.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPublish_Date_From.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTitle.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAuthor.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPublisher.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grpGrid).BeginInit();
            grpGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl_Books).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView_Books).BeginInit();
            SuspendLayout();
            // 
            // grpFilter
            // 
            grpFilter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpFilter.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            grpFilter.AppearanceCaption.Options.UseFont = true;
            grpFilter.CaptionImageOptions.Image = (System.Drawing.Image)resources.GetObject("grpFilter.CaptionImageOptions.Image");
            grpFilter.Controls.Add(grpFilter_Normal);
            grpFilter.Controls.Add(grpFilter_Advanced);
            buttonImageOptions1.Image = (System.Drawing.Image)resources.GetObject("buttonImageOptions1.Image");
            buttonImageOptions1.Location = DevExpress.XtraEditors.ButtonPanel.ImageLocation.AfterText;
            grpFilter.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] { new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("حذف فیلترها", false, buttonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "حذف فیلترهای جستجو", -1, true, null, true, false, true, "btnClear", -1) });
            grpFilter.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            grpFilter.Location = new System.Drawing.Point(12, 12);
            grpFilter.Name = "grpFilter";
            grpFilter.Size = new System.Drawing.Size(1174, 263);
            grpFilter.TabIndex = 0;
            grpFilter.Text = "جستجوی اطلاعات";
            grpFilter.CustomButtonClick += grpFilter_CustomButtonClick;
            // 
            // grpFilter_Normal
            // 
            grpFilter_Normal.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpFilter_Normal.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            grpFilter_Normal.AppearanceCaption.Options.UseFont = true;
            grpFilter_Normal.Controls.Add(labelControl9);
            grpFilter_Normal.Controls.Add(cmbPriority);
            grpFilter_Normal.Controls.Add(txtFullSearch);
            grpFilter_Normal.Controls.Add(labelControl8);
            grpFilter_Normal.Controls.Add(btnSearch_Normal);
            grpFilter_Normal.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            grpFilter_Normal.Location = new System.Drawing.Point(5, 46);
            grpFilter_Normal.Name = "grpFilter_Normal";
            grpFilter_Normal.Size = new System.Drawing.Size(1164, 80);
            grpFilter_Normal.TabIndex = 0;
            grpFilter_Normal.Text = "جستجوی عادی";
            // 
            // labelControl9
            // 
            labelControl9.Location = new System.Drawing.Point(353, 38);
            labelControl9.Name = "labelControl9";
            labelControl9.Size = new System.Drawing.Size(43, 16);
            labelControl9.TabIndex = 7;
            labelControl9.Text = "اولویت :";
            // 
            // cmbPriority
            // 
            cmbPriority.Location = new System.Drawing.Point(214, 35);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbPriority.Size = new System.Drawing.Size(120, 22);
            cmbPriority.TabIndex = 1;
            cmbPriority.Validating += AllComboboxes_Validating;
            // 
            // txtFullSearch
            // 
            txtFullSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtFullSearch.Location = new System.Drawing.Point(426, 35);
            txtFullSearch.Name = "txtFullSearch";
            txtFullSearch.Size = new System.Drawing.Size(635, 22);
            txtFullSearch.TabIndex = 0;
            txtFullSearch.KeyDown += txtFullSearch_KeyDown;
            // 
            // labelControl8
            // 
            labelControl8.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            labelControl8.Location = new System.Drawing.Point(1077, 38);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new System.Drawing.Size(69, 16);
            labelControl8.TabIndex = 5;
            labelControl8.Text = "عنوان / نام :";
            // 
            // btnSearch_Normal
            // 
            btnSearch_Normal.Location = new System.Drawing.Point(15, 35);
            btnSearch_Normal.Name = "btnSearch_Normal";
            btnSearch_Normal.Size = new System.Drawing.Size(158, 23);
            btnSearch_Normal.TabIndex = 3;
            btnSearch_Normal.Text = "جستجو";
            btnSearch_Normal.Click += btnSearch_Normal_Click;
            // 
            // grpFilter_Advanced
            // 
            grpFilter_Advanced.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpFilter_Advanced.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            grpFilter_Advanced.AppearanceCaption.Options.UseFont = true;
            grpFilter_Advanced.Controls.Add(cmbAccuracy);
            grpFilter_Advanced.Controls.Add(labelControl7);
            grpFilter_Advanced.Controls.Add(btnSearch_Advanced);
            grpFilter_Advanced.Controls.Add(tblSeparate);
            grpFilter_Advanced.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            grpFilter_Advanced.Location = new System.Drawing.Point(5, 127);
            grpFilter_Advanced.Name = "grpFilter_Advanced";
            grpFilter_Advanced.Size = new System.Drawing.Size(1164, 131);
            grpFilter_Advanced.TabIndex = 1;
            grpFilter_Advanced.Text = "جستجوی پیشرفته";
            // 
            // cmbAccuracy
            // 
            cmbAccuracy.Location = new System.Drawing.Point(15, 38);
            cmbAccuracy.Name = "cmbAccuracy";
            cmbAccuracy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbAccuracy.Size = new System.Drawing.Size(66, 22);
            cmbAccuracy.TabIndex = 0;
            cmbAccuracy.Validating += AllComboboxes_Validating;
            // 
            // labelControl7
            // 
            labelControl7.Location = new System.Drawing.Point(94, 39);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new System.Drawing.Size(79, 16);
            labelControl7.TabIndex = 3;
            labelControl7.Text = "دقت جستجو :";
            // 
            // btnSearch_Advanced
            // 
            btnSearch_Advanced.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnSearch_Advanced.ImageOptions.Image");
            btnSearch_Advanced.Location = new System.Drawing.Point(15, 66);
            btnSearch_Advanced.Name = "btnSearch_Advanced";
            btnSearch_Advanced.Size = new System.Drawing.Size(158, 48);
            btnSearch_Advanced.TabIndex = 1;
            btnSearch_Advanced.Text = "جستجو     ";
            btnSearch_Advanced.Click += btnSearch_Advanced_Click;
            // 
            // tblSeparate
            // 
            tblSeparate.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tblSeparate.ColumnCount = 5;
            tblSeparate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            tblSeparate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tblSeparate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            tblSeparate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            tblSeparate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tblSeparate.Controls.Add(txtPublish_Date_To, 4, 2);
            tblSeparate.Controls.Add(cmbPublish_Place, 4, 0);
            tblSeparate.Controls.Add(txtPublish_Date_From, 4, 1);
            tblSeparate.Controls.Add(labelControl6, 3, 2);
            tblSeparate.Controls.Add(labelControl1, 0, 0);
            tblSeparate.Controls.Add(labelControl4, 3, 1);
            tblSeparate.Controls.Add(labelControl2, 0, 1);
            tblSeparate.Controls.Add(txtTitle, 1, 0);
            tblSeparate.Controls.Add(txtAuthor, 1, 1);
            tblSeparate.Controls.Add(labelControl3, 0, 2);
            tblSeparate.Controls.Add(txtPublisher, 1, 2);
            tblSeparate.Controls.Add(labelControl5, 3, 0);
            tblSeparate.Location = new System.Drawing.Point(211, 36);
            tblSeparate.Name = "tblSeparate";
            tblSeparate.RowCount = 3;
            tblSeparate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            tblSeparate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            tblSeparate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            tblSeparate.Size = new System.Drawing.Size(938, 80);
            tblSeparate.TabIndex = 0;
            // 
            // txtPublish_Date_To
            // 
            txtPublish_Date_To.Dock = System.Windows.Forms.DockStyle.Fill;
            txtPublish_Date_To.Location = new System.Drawing.Point(3, 55);
            txtPublish_Date_To.Name = "txtPublish_Date_To";
            txtPublish_Date_To.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateOnlyMaskManager));
            txtPublish_Date_To.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            txtPublish_Date_To.Properties.MaskSettings.Set("mask", "yyyy/MM/dd");
            txtPublish_Date_To.Properties.UseMaskAsDisplayFormat = true;
            txtPublish_Date_To.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtPublish_Date_To.Size = new System.Drawing.Size(366, 22);
            txtPublish_Date_To.TabIndex = 5;
            txtPublish_Date_To.KeyDown += txtFullSearch_KeyDown;
            // 
            // cmbPublish_Place
            // 
            cmbPublish_Place.Dock = System.Windows.Forms.DockStyle.Fill;
            cmbPublish_Place.Location = new System.Drawing.Point(3, 3);
            cmbPublish_Place.Name = "cmbPublish_Place";
            cmbPublish_Place.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbPublish_Place.Size = new System.Drawing.Size(366, 22);
            cmbPublish_Place.TabIndex = 3;
            cmbPublish_Place.Validating += AllComboboxes_Validating;
            // 
            // txtPublish_Date_From
            // 
            txtPublish_Date_From.Dock = System.Windows.Forms.DockStyle.Fill;
            txtPublish_Date_From.Location = new System.Drawing.Point(3, 29);
            txtPublish_Date_From.Name = "txtPublish_Date_From";
            txtPublish_Date_From.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateOnlyMaskManager));
            txtPublish_Date_From.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            txtPublish_Date_From.Properties.MaskSettings.Set("mask", "yyyy/MM/dd");
            txtPublish_Date_From.Properties.UseMaskAsDisplayFormat = true;
            txtPublish_Date_From.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtPublish_Date_From.Size = new System.Drawing.Size(366, 22);
            txtPublish_Date_From.TabIndex = 4;
            txtPublish_Date_From.KeyDown += txtFullSearch_KeyDown;
            // 
            // labelControl6
            // 
            labelControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            labelControl6.Location = new System.Drawing.Point(375, 55);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new System.Drawing.Size(79, 22);
            labelControl6.TabIndex = 3;
            labelControl6.Text = "تاریخ / تا :";
            // 
            // labelControl1
            // 
            labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            labelControl1.Location = new System.Drawing.Point(856, 3);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(79, 20);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "عنوان کتاب :";
            // 
            // labelControl4
            // 
            labelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            labelControl4.Location = new System.Drawing.Point(375, 29);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(79, 20);
            labelControl4.TabIndex = 1;
            labelControl4.Text = "تاریخ / از :";
            // 
            // labelControl2
            // 
            labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            labelControl2.Location = new System.Drawing.Point(856, 29);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(79, 20);
            labelControl2.TabIndex = 1;
            labelControl2.Text = "نام نویسنده :";
            // 
            // txtTitle
            // 
            txtTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            txtTitle.Location = new System.Drawing.Point(485, 3);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new System.Drawing.Size(365, 22);
            txtTitle.TabIndex = 0;
            txtTitle.KeyDown += txtFullSearch_KeyDown;
            // 
            // txtAuthor
            // 
            txtAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            txtAuthor.Location = new System.Drawing.Point(485, 29);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new System.Drawing.Size(365, 22);
            txtAuthor.TabIndex = 1;
            txtAuthor.KeyDown += txtFullSearch_KeyDown;
            // 
            // labelControl3
            // 
            labelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            labelControl3.Location = new System.Drawing.Point(856, 55);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(79, 22);
            labelControl3.TabIndex = 4;
            labelControl3.Text = "انتشارات :";
            // 
            // txtPublisher
            // 
            txtPublisher.Dock = System.Windows.Forms.DockStyle.Fill;
            txtPublisher.Location = new System.Drawing.Point(485, 55);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new System.Drawing.Size(365, 22);
            txtPublisher.TabIndex = 2;
            txtPublisher.KeyDown += txtFullSearch_KeyDown;
            // 
            // labelControl5
            // 
            labelControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            labelControl5.Location = new System.Drawing.Point(375, 3);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new System.Drawing.Size(79, 20);
            labelControl5.TabIndex = 2;
            labelControl5.Text = "محل انتشار :";
            // 
            // grpGrid
            // 
            grpGrid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpGrid.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            grpGrid.AppearanceCaption.Options.UseFont = true;
            grpGrid.CaptionImageOptions.Image = (System.Drawing.Image)resources.GetObject("grpGrid.CaptionImageOptions.Image");
            grpGrid.Controls.Add(gridControl_Books);
            grpGrid.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            grpGrid.Location = new System.Drawing.Point(12, 281);
            grpGrid.Name = "grpGrid";
            grpGrid.Size = new System.Drawing.Size(1174, 387);
            grpGrid.TabIndex = 1;
            grpGrid.Text = "لیست کتاب ها ";
            // 
            // gridControl_Books
            // 
            gridControl_Books.DataSource = bsBooks;
            gridControl_Books.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControl_Books.Location = new System.Drawing.Point(2, 33);
            gridControl_Books.MainView = gridView_Books;
            gridControl_Books.Name = "gridControl_Books";
            gridControl_Books.Size = new System.Drawing.Size(1170, 352);
            gridControl_Books.TabIndex = 0;
            gridControl_Books.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView_Books });
            // 
            // bsBooks
            // 
            bsBooks.DataSource = typeof(Models.BookViewModel);
            // 
            // gridView_Books
            // 
            gridView_Books.Appearance.ViewCaption.Options.UseTextOptions = true;
            gridView_Books.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView_Books.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            gridView_Books.AutoFillColumn = colTitle;
            gridView_Books.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colTitle, colAuthor, colPublisher, colPublish_date, colPublish_place });
            gridView_Books.GridControl = gridControl_Books;
            gridView_Books.IndicatorWidth = 50;
            gridView_Books.Name = "gridView_Books";
            gridView_Books.OptionsBehavior.Editable = false;
            gridView_Books.OptionsPrint.AutoWidth = false;
            gridView_Books.OptionsView.ColumnAutoWidth = false;
            gridView_Books.OptionsView.ShowAutoFilterRow = true;
            gridView_Books.OptionsView.ShowGroupPanel = false;
            gridView_Books.CustomDrawRowIndicator += gridView_Books_CustomDrawRowIndicator;
            // 
            // colTitle
            // 
            colTitle.AppearanceCell.Options.UseTextOptions = true;
            colTitle.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colTitle.AppearanceHeader.Options.UseTextOptions = true;
            colTitle.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colTitle.Caption = "عنوان کتاب";
            colTitle.FieldName = "Title";
            colTitle.MinWidth = 25;
            colTitle.Name = "colTitle";
            colTitle.Visible = true;
            colTitle.VisibleIndex = 1;
            colTitle.Width = 230;
            // 
            // colId
            // 
            colId.AppearanceCell.Options.UseTextOptions = true;
            colId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colId.AppearanceHeader.Options.UseTextOptions = true;
            colId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colId.Caption = "شناسه";
            colId.FieldName = "Id";
            colId.MinWidth = 25;
            colId.Name = "colId";
            colId.Visible = true;
            colId.VisibleIndex = 0;
            colId.Width = 60;
            // 
            // colAuthor
            // 
            colAuthor.AppearanceCell.Options.UseTextOptions = true;
            colAuthor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colAuthor.AppearanceHeader.Options.UseTextOptions = true;
            colAuthor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colAuthor.Caption = "نویسنده";
            colAuthor.FieldName = "Author";
            colAuthor.MinWidth = 25;
            colAuthor.Name = "colAuthor";
            colAuthor.Visible = true;
            colAuthor.VisibleIndex = 2;
            colAuthor.Width = 320;
            // 
            // colPublisher
            // 
            colPublisher.AppearanceCell.Options.UseTextOptions = true;
            colPublisher.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colPublisher.AppearanceHeader.Options.UseTextOptions = true;
            colPublisher.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colPublisher.Caption = "انتشارات";
            colPublisher.FieldName = "Publisher";
            colPublisher.MinWidth = 25;
            colPublisher.Name = "colPublisher";
            colPublisher.Visible = true;
            colPublisher.VisibleIndex = 3;
            colPublisher.Width = 320;
            // 
            // colPublish_date
            // 
            colPublish_date.AppearanceCell.Options.UseTextOptions = true;
            colPublish_date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colPublish_date.AppearanceHeader.Options.UseTextOptions = true;
            colPublish_date.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colPublish_date.Caption = "تاریخ انتشار";
            colPublish_date.FieldName = "Publish_date";
            colPublish_date.MinWidth = 25;
            colPublish_date.Name = "colPublish_date";
            colPublish_date.Visible = true;
            colPublish_date.VisibleIndex = 4;
            colPublish_date.Width = 85;
            // 
            // colPublish_place
            // 
            colPublish_place.AppearanceCell.Options.UseTextOptions = true;
            colPublish_place.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colPublish_place.AppearanceHeader.Options.UseTextOptions = true;
            colPublish_place.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colPublish_place.Caption = "محل انتشار";
            colPublish_place.FieldName = "Publish_place";
            colPublish_place.MinWidth = 25;
            colPublish_place.Name = "colPublish_place";
            colPublish_place.Visible = true;
            colPublish_place.VisibleIndex = 5;
            colPublish_place.Width = 85;
            // 
            // frmSearch
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1198, 680);
            Controls.Add(grpGrid);
            Controls.Add(grpFilter);
            Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            IconOptions.ShowIcon = false;
            Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            Name = "frmSearch";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Shown += frmSearch_Shown;
            ((System.ComponentModel.ISupportInitialize)grpFilter).EndInit();
            grpFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grpFilter_Normal).EndInit();
            grpFilter_Normal.ResumeLayout(false);
            grpFilter_Normal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbPriority.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtFullSearch.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)grpFilter_Advanced).EndInit();
            grpFilter_Advanced.ResumeLayout(false);
            grpFilter_Advanced.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbAccuracy.Properties).EndInit();
            tblSeparate.ResumeLayout(false);
            tblSeparate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtPublish_Date_To.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbPublish_Place.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPublish_Date_From.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTitle.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAuthor.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPublisher.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)grpGrid).EndInit();
            grpGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl_Books).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView_Books).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpFilter;
        private DevExpress.XtraEditors.GroupControl grpGrid;
        private DevExpress.XtraGrid.GridControl gridControl_Books;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Books;
        private DevExpress.XtraEditors.GroupControl grpFilter_Advanced;
        private System.Windows.Forms.TableLayoutPanel tblSeparate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTitle;
        private DevExpress.XtraEditors.TextEdit txtAuthor;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtPublisher;
        private DevExpress.XtraEditors.SimpleButton btnSearch_Advanced;
        private DevExpress.XtraEditors.ComboBoxEdit cmbPublish_Place;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit cmbAccuracy;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.GroupControl grpFilter_Normal;
        private DevExpress.XtraEditors.SimpleButton btnSearch_Normal;
        private DevExpress.XtraEditors.TextEdit txtFullSearch;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtPublish_Date_From;
        private DevExpress.XtraEditors.TextEdit txtPublish_Date_To;
        private System.Windows.Forms.BindingSource bsBooks;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthor;
        private DevExpress.XtraGrid.Columns.GridColumn colPublisher;
        private DevExpress.XtraGrid.Columns.GridColumn colPublish_date;
        private DevExpress.XtraGrid.Columns.GridColumn colPublish_place;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.ComboBoxEdit cmbPriority;
    }
}

