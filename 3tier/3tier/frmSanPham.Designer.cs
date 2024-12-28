using System.Drawing;
using System.Windows.Forms;

namespace _3Layer
{
  partial class frmSanPham
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
      this.btn_Search = new System.Windows.Forms.Button();
      this.dtp_NgayNhap = new System.Windows.Forms.DateTimePicker();
      this.lblLoaiSP = new System.Windows.Forms.Label();
      this.lblNgayNhap = new System.Windows.Forms.Label();
      this.lblTenSP = new System.Windows.Forms.Label();
      this.lblMaSP = new System.Windows.Forms.Label();
      this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cmb_LoaiSP = new System.Windows.Forms.ComboBox();
      this.dgvSanPham = new System.Windows.Forms.DataGridView();
      this.btn_exit = new System.Windows.Forms.Button();
      this.btn_notSave = new System.Windows.Forms.Button();
      this.btn_save = new System.Windows.Forms.Button();
      this.btn_delete = new System.Windows.Forms.Button();
      this.btn_edit = new System.Windows.Forms.Button();
      this.btn_add = new System.Windows.Forms.Button();
      this.lblDanhMucSanPham = new System.Windows.Forms.Label();
      this.txt_TenSP = new System.Windows.Forms.TextBox();
      this.txt_MaSP = new System.Windows.Forms.TextBox();
      this.txt_Search = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
      this.SuspendLayout();
      //
      // btn_Search
      //
      this.btn_Search.Location = new System.Drawing.Point(1222, 134);
      this.btn_Search.Margin = new System.Windows.Forms.Padding(6);
      this.btn_Search.Name = "btn_Search";
      this.btn_Search.Size = new System.Drawing.Size(138, 42);
      this.btn_Search.TabIndex = 35;
      this.btn_Search.Text = "Tìm kiếm";
      this.btn_Search.UseVisualStyleBackColor = true;
      this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
      //
      // dtp_NgayNhap
      //
      this.dtp_NgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtp_NgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtp_NgayNhap.Location = new System.Drawing.Point(1113, 399);
      this.dtp_NgayNhap.Margin = new System.Windows.Forms.Padding(6);
      this.dtp_NgayNhap.Name = "dtp_NgayNhap";
      this.dtp_NgayNhap.Size = new System.Drawing.Size(187, 34);
      this.dtp_NgayNhap.TabIndex = 33;
      //
      // lblLoaiSP
      //
      this.lblLoaiSP.AutoSize = true;
      this.lblLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblLoaiSP.Location = new System.Drawing.Point(919, 473);
      this.lblLoaiSP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.lblLoaiSP.Name = "lblLoaiSP";
      this.lblLoaiSP.Size = new System.Drawing.Size(181, 29);
      this.lblLoaiSP.TabIndex = 32;
      this.lblLoaiSP.Text = "Loại sản phẩm :";
      //
      // lblNgayNhap
      //
      this.lblNgayNhap.AutoSize = true;
      this.lblNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblNgayNhap.Location = new System.Drawing.Point(951, 402);
      this.lblNgayNhap.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.lblNgayNhap.Name = "lblNgayNhap";
      this.lblNgayNhap.Size = new System.Drawing.Size(140, 29);
      this.lblNgayNhap.TabIndex = 31;
      this.lblNgayNhap.Text = "Ngày nhập :";
      //
      // lblTenSP
      //
      this.lblTenSP.AutoSize = true;
      this.lblTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTenSP.Location = new System.Drawing.Point(969, 329);
      this.lblTenSP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.lblTenSP.Name = "lblTenSP";
      this.lblTenSP.Size = new System.Drawing.Size(106, 29);
      this.lblTenSP.TabIndex = 30;
      this.lblTenSP.Text = "Tên SP :";
      //
      // lblMaSP
      //
      this.lblMaSP.AutoSize = true;
      this.lblMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblMaSP.Location = new System.Drawing.Point(976, 257);
      this.lblMaSP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.lblMaSP.Name = "lblMaSP";
      this.lblMaSP.Size = new System.Drawing.Size(96, 29);
      this.lblMaSP.TabIndex = 29;
      this.lblMaSP.Text = "Mã SP :";
      //
      // Column4
      //
      this.Column4.HeaderText = "Loại SP";
      this.Column4.MinimumWidth = 9;
      this.Column4.Name = "Column4";
      //
      // Column3
      //
      this.Column3.HeaderText = "Ngày nhập";
      this.Column3.MinimumWidth = 9;
      this.Column3.Name = "Column3";
      //
      // Column2
      //
      this.Column2.HeaderText = "Tên sản phẩm";
      this.Column2.MinimumWidth = 9;
      this.Column2.Name = "Column2";
      //
      // Column1
      //
      this.Column1.HeaderText = "MaSP";
      this.Column1.MinimumWidth = 9;
      this.Column1.Name = "Column1";
      //
      // cmb_LoaiSP
      //
      this.cmb_LoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmb_LoaiSP.FormattingEnabled = true;
      this.cmb_LoaiSP.Location = new System.Drawing.Point(1113, 468);
      this.cmb_LoaiSP.Margin = new System.Windows.Forms.Padding(6);
      this.cmb_LoaiSP.Name = "cmb_LoaiSP";
      this.cmb_LoaiSP.Size = new System.Drawing.Size(168, 37);
      this.cmb_LoaiSP.TabIndex = 34;
      //
      // dgvSanPham
      //
      this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
this.Column1,
this.Column2,
this.Column3,
this.Column4});
      this.dgvSanPham.Location = new System.Drawing.Point(15, 134);
      this.dgvSanPham.Margin = new System.Windows.Forms.Padding(6);
      this.dgvSanPham.Name = "dgvSanPham";
      this.dgvSanPham.RowHeadersWidth = 72;
      this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvSanPham.Size = new System.Drawing.Size(870, 559);
      this.dgvSanPham.TabIndex = 28;
      this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
      //
      // btn_exit
      //
      this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_exit.Location = new System.Drawing.Point(996, 736);
      this.btn_exit.Margin = new System.Windows.Forms.Padding(6);
      this.btn_exit.Name = "btn_exit";
      this.btn_exit.Size = new System.Drawing.Size(136, 42);
      this.btn_exit.TabIndex = 27;
      this.btn_exit.Text = "Thoát";
      this.btn_exit.UseVisualStyleBackColor = true;
      this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
      //
      // btn_notSave
      //
      this.btn_notSave.Enabled = false;
      this.btn_notSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_notSave.Location = new System.Drawing.Point(847, 736);
      this.btn_notSave.Margin = new System.Windows.Forms.Padding(6);
      this.btn_notSave.Name = "btn_notSave";
      this.btn_notSave.Size = new System.Drawing.Size(138, 42);
      this.btn_notSave.TabIndex = 26;
      this.btn_notSave.Text = "K.Lưu";
      this.btn_notSave.UseVisualStyleBackColor = true;
      this.btn_notSave.Click += new System.EventHandler(this.btn_notSave_Click);
      //
      // btn_save
      //
      this.btn_save.Enabled = false;
      this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_save.Location = new System.Drawing.Point(698, 736);
      this.btn_save.Margin = new System.Windows.Forms.Padding(6);
      this.btn_save.Name = "btn_save";
      this.btn_save.Size = new System.Drawing.Size(138, 42);
      this.btn_save.TabIndex = 25;
      this.btn_save.Text = "Lưu";
      this.btn_save.UseVisualStyleBackColor = true;
      this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
      //
      // btn_delete
      //
      this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_delete.Location = new System.Drawing.Point(550, 736);
      this.btn_delete.Margin = new System.Windows.Forms.Padding(6);
      this.btn_delete.Name = "btn_delete";
      this.btn_delete.Size = new System.Drawing.Size(138, 42);
      this.btn_delete.TabIndex = 24;
      this.btn_delete.Text = "Xóa";
      this.btn_delete.UseVisualStyleBackColor = true;
      this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
      //
      // btn_edit
      //
      this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_edit.Location = new System.Drawing.Point(402, 736);
      this.btn_edit.Margin = new System.Windows.Forms.Padding(6);
      this.btn_edit.Name = "btn_edit";
      this.btn_edit.Size = new System.Drawing.Size(138, 42);
      this.btn_edit.TabIndex = 23;
      this.btn_edit.Text = "Sửa";
      this.btn_edit.UseVisualStyleBackColor = true;
      this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
      //
      // btn_add
      //
      this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_add.Location = new System.Drawing.Point(253, 736);
      this.btn_add.Margin = new System.Windows.Forms.Padding(6);
      this.btn_add.Name = "btn_add";
      this.btn_add.Size = new System.Drawing.Size(138, 42);
      this.btn_add.TabIndex = 22;
      this.btn_add.Text = "Thêm";
      this.btn_add.UseVisualStyleBackColor = true;
      this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
      //
      // lblDanhMucSanPham
      //
      this.lblDanhMucSanPham.AutoSize = true;
      this.lblDanhMucSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblDanhMucSanPham.Location = new System.Drawing.Point(511, 30);
      this.lblDanhMucSanPham.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.lblDanhMucSanPham.Name = "lblDanhMucSanPham";
      this.lblDanhMucSanPham.Size = new System.Drawing.Size(523, 59);
      this.lblDanhMucSanPham.TabIndex = 21;
      this.lblDanhMucSanPham.Text = "Danh Mục Sản Phẩm";
      //
      // txt_TenSP
      //
      this.txt_TenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txt_TenSP.Location = new System.Drawing.Point(1113, 324);
      this.txt_TenSP.Margin = new System.Windows.Forms.Padding(6);
      this.txt_TenSP.Name = "txt_TenSP";
      this.txt_TenSP.Size = new System.Drawing.Size(303, 34);
      this.txt_TenSP.TabIndex = 20;
      //
      // txt_MaSP
      //
      this.txt_MaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txt_MaSP.Location = new System.Drawing.Point(1113, 252);
      this.txt_MaSP.Margin = new System.Windows.Forms.Padding(6);
      this.txt_MaSP.Name = "txt_MaSP";
      this.txt_MaSP.Size = new System.Drawing.Size(129, 34);
      this.txt_MaSP.TabIndex = 19;
      //
      // txt_Search
      //
      this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txt_Search.Location = new System.Drawing.Point(958, 138);
      this.txt_Search.Margin = new System.Windows.Forms.Padding(6);
      this.txt_Search.Name = "txt_Search";
      this.txt_Search.Size = new System.Drawing.Size(250, 34);
      this.txt_Search.TabIndex = 18;
      this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
      //
      // frmSanPham
      //
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1446, 806);
      this.Controls.Add(this.btn_Search);
      this.Controls.Add(this.dtp_NgayNhap);
      this.Controls.Add(this.lblLoaiSP);
      this.Controls.Add(this.lblNgayNhap);
      this.Controls.Add(this.lblTenSP);
      this.Controls.Add(this.lblMaSP);
      this.Controls.Add(this.cmb_LoaiSP);
      this.Controls.Add(this.dgvSanPham);
      this.Controls.Add(this.btn_exit);
      this.Controls.Add(this.btn_notSave);
      this.Controls.Add(this.btn_save);
      this.Controls.Add(this.btn_delete);
      this.Controls.Add(this.btn_edit);
      this.Controls.Add(this.btn_add);
      this.Controls.Add(this.lblDanhMucSanPham);
      this.Controls.Add(this.txt_TenSP);
      this.Controls.Add(this.txt_MaSP);
      this.Controls.Add(this.txt_Search);
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "frmSanPham";
      this.Text = "frmSanPham";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btn_Search;
    private System.Windows.Forms.DateTimePicker dtp_NgayNhap;
    private System.Windows.Forms.Label lblLoaiSP;
    private System.Windows.Forms.Label lblNgayNhap;
    private System.Windows.Forms.Label lblTenSP;
    private System.Windows.Forms.Label lblMaSP;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    private System.Windows.Forms.ComboBox cmb_LoaiSP;
    private System.Windows.Forms.DataGridView dgvSanPham;
    private System.Windows.Forms.Button btn_exit;
    private System.Windows.Forms.Button btn_notSave;
    private System.Windows.Forms.Button btn_save;
    private System.Windows.Forms.Button btn_delete;
    private System.Windows.Forms.Button btn_edit;
    private System.Windows.Forms.Button btn_add;
    private System.Windows.Forms.Label lblDanhMucSanPham;
    private System.Windows.Forms.TextBox txt_TenSP;
    private System.Windows.Forms.TextBox txt_MaSP;
    private System.Windows.Forms.TextBox txt_Search;
  }
}

