using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BUS;
using DAL.Models;

namespace _3Layer
{
  public partial class frmSanPham : Form
  {
    private readonly LoaiSPService loaiSPService = new LoaiSPService();
    private readonly SanPhamService sanPhamService = new SanPhamService();
    private List<Sanpham> listTamThoi = new List<Sanpham>();

    public frmSanPham()
    {
      InitializeComponent();
    }

    // Hàm khởi tạo và nạp dữ liệu
    private void Form1_Load(object sender, EventArgs e)
    {
      LoadData();
    }

    // Hàm nạp dữ liệu từ cơ sở dữ liệu
    private void LoadData()
    {
      try
      {
        var listLoaiSP = loaiSPService.GetAll();
        var listSanPham = sanPhamService.GetAll();
        FillLoaiSPCombobox(listLoaiSP);
        BindGrid(listSanPham);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    // Hàm ràng buộc dữ liệu vào DataGridView
    private void BindGrid(List<Sanpham> listProduct)
    {
      dgvSanPham.Rows.Clear();
      foreach (var item in listProduct)
      {
        int index = dgvSanPham.Rows.Add();
        dgvSanPham.Rows[index].Cells[0].Value = item.MaSP;
        dgvSanPham.Rows[index].Cells[1].Value = item.TenSP;
        dgvSanPham.Rows[index].Cells[2].Value = item.NgayNhap;
        dgvSanPham.Rows[index].Cells[3].Value = item.LoaiSP.TenLoai;
      }
    }

    // Hàm ràng buộc danh sách loại sản phẩm vào ComboBox
    private void FillLoaiSPCombobox(List<LoaiSP> listLoaiSPs)
    {
      this.cmb_LoaiSP.DataSource = listLoaiSPs;
      this.cmb_LoaiSP.DisplayMember = "TenLoai";
      this.cmb_LoaiSP.ValueMember = "MaLoai";
    }

    // Hàm lấy thông tin sản phẩm từ input
    private Sanpham GetSanphamFromInput()
    {
      return new Sanpham
      {
        MaSP = txt_MaSP.Text.Trim(),
        TenSP = txt_TenSP.Text.Trim(),
        NgayNhap = dtp_NgayNhap.Value,
        MaLoai = cmb_LoaiSP.SelectedValue.ToString()
      };
    }

    // Hàm thêm sản phẩm
    private void btn_add_Click(object sender, EventArgs e)
    {
      try
      {
        var sanPham = GetSanphamFromInput();
        listTamThoi.Add(sanPham);

        int index = dgvSanPham.Rows.Add();
        dgvSanPham.Rows[index].Cells[0].Value = sanPham.MaSP;
        dgvSanPham.Rows[index].Cells[1].Value = sanPham.TenSP;
        dgvSanPham.Rows[index].Cells[2].Value = sanPham.NgayNhap;
        dgvSanPham.Rows[index].Cells[3].Value = cmb_LoaiSP.Text;

        btn_save.Enabled = true;
        btn_notSave.Enabled = true;
        MessageBox.Show("Thêm sản phẩm vào danh sách tạm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        ClearForm();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    // Hàm chỉnh sửa sản phẩm
    private void btn_edit_Click(object sender, EventArgs e)
    {
      try
      {
        var sanPham = GetSanphamFromInput();
        sanPhamService.InsertOrUpdate(sanPham);
        var listSanPham = sanPhamService.GetAll();
        BindGrid(listSanPham);

        MessageBox.Show("Sửa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        ClearForm();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    // Hàm xóa sản phẩm
    private void btn_delete_Click(object sender, EventArgs e)
    {
      try
      {
        var maSP = txt_MaSP.Text.Trim();

        if (string.IsNullOrEmpty(maSP))
        {
          MessageBox.Show("Vui lòng chọn sản phẩm cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          return;
        }

        var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (confirmResult == DialogResult.Yes)
        {
          sanPhamService.Delete(maSP);

          var listSanPham = sanPhamService.GetAll();
          BindGrid(listSanPham);

          MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
          ClearForm();
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    // Hàm lưu sản phẩm
    private void btn_save_Click(object sender, EventArgs e)
    {
      try
      {
        using (ProductContextDB context = new ProductContextDB())
        {
          foreach (var product in listTamThoi)
          {
            if (!context.Sanphams.Any(s => s.MaSP == product.MaSP))
            {
              context.Sanphams.Add(product);
            }
          }
          context.SaveChanges();
        }

        listTamThoi.Clear();
        btn_save.Enabled = false;
        btn_notSave.Enabled = false;
        MessageBox.Show("Đã lưu các sản phẩm mới vào cơ sở dữ liệu!");
        LoadData();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Lỗi khi lưu sản phẩm: " + ex.Message);
      }
    }

    // Hàm hủy thay đổi
    private void btn_notSave_Click(object sender, EventArgs e)
    {
      try
      {
        foreach (var product in listTamThoi)
        {
          for (int i = dgvSanPham.Rows.Count - 1; i >= 0; i--)
          {
            var row = dgvSanPham.Rows[i];
            if (row.Cells[0].Value?.ToString() == product.MaSP)
            {
              dgvSanPham.Rows.RemoveAt(i);
            }
          }
        }

        listTamThoi.Clear();
        btn_save.Enabled = false;
        btn_notSave.Enabled = false;
        dgvSanPham.Refresh();
        MessageBox.Show("Đã hủy các thay đổi chưa lưu!");
      }
      catch (Exception ex)
      {
        MessageBox.Show("Lỗi: " + ex.Message);
      }
    }

    // Hàm thoát ứng dụng
    private void btn_exit_Click(object sender, EventArgs e)
    {
      DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
      if (result == DialogResult.Cancel)
      {
        return;
      }
      else
      {
        Close();
      }
    }

    // Hàm tìm kiếm sản phẩm
    private void btn_Search_Click(object sender, EventArgs e)
    {
      try
      {
        if (dgvSanPham.IsCurrentCellInEditMode)
        {
          dgvSanPham.EndEdit();
        }

        if (dgvSanPham.IsCurrentRowDirty)
        {
          dgvSanPham.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        string keyword = txt_Search.Text.Trim();
        using (ProductContextDB context = new ProductContextDB())
        {
          List<Sanpham> filteredList = context.Sanphams.Where(s => s.TenSP.Contains(keyword)).ToList();
          BindGrid(filteredList);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
      }
    }

    // Hàm xử lý sự kiện khi thay đổi text tìm kiếm
    private void txt_Search_TextChanged(object sender, EventArgs e)
    {
      if (string.IsNullOrWhiteSpace(txt_Search.Text))
      {
        LoadData();
      }
    }

    // Hàm xử lý sự kiện khi click vào ô DataGridView
    private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];
        txt_MaSP.Text = row.Cells[0].Value?.ToString()?.Trim();
        txt_TenSP.Text = row.Cells[1].Value?.ToString();

        if (DateTime.TryParse(row.Cells[2].Value?.ToString(), out DateTime ngayNhap))
        {
          dtp_NgayNhap.Value = ngayNhap;
        }
        string tenLoaiSP = row.Cells[3].Value?.ToString()?.Trim();
        if (!string.IsNullOrEmpty(tenLoaiSP))
        {
          foreach (LoaiSP loaiSP in cmb_LoaiSP.Items)
          {
            if (loaiSP.TenLoai == tenLoaiSP)
            {
              cmb_LoaiSP.SelectedItem = loaiSP;
              break;
            }
          }
        }
      }
    }

    // Hàm dọn dẹp form
    private void ClearForm()
    {
      txt_MaSP.Clear();
      txt_TenSP.Clear();
      dtp_NgayNhap.Value = DateTime.Now;
      cmb_LoaiSP.SelectedIndex = -1;
      txt_MaSP.Focus();
    }
  }
}