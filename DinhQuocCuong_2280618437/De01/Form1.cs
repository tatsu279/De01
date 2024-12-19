using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using De01.Model;

namespace De01
{
    public partial class frmSinhVien : Form
    {
        Model1 dbsinhvien = new Model1();
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Sinhvien> Student_list = dbsinhvien.Sinhviens.ToList();
            List<Lop> classlist = dbsinhvien.Lops.ToList();
            FillLopCombobox(classlist);
            BidGid(Student_list);
            btLuu.Enabled = false; // Disables the button
            btKhong.Enabled = false;

        }
        private void BidGid(List<Sinhvien> studentlist)
        {
            // Clear the existing rows in the DataGridView
            dgvSinhVien.Rows.Clear();

            // Load all classes into a dictionary for faster lookups
            Dictionary<string, string> classDictionary = dbsinhvien.Lops
                .ToDictionary(c => c.MaLop, c => c.TenLop);

            // Iterate through the student list and add rows to the DataGridView
            foreach (var student in studentlist)
            {
                // Check if the student has a valid class and retrieve the class name
                string className = classDictionary.ContainsKey(student.MaLop)
                    ? classDictionary[student.MaLop]
                    : "Khong Ten"; // Fallback in case class is not found

                // Add a new row to the DataGridView and set its values
                int index = dgvSinhVien.Rows.Add();
                dgvSinhVien.Rows[index].Cells[0].Value = student.MaSV; // Ensure MaSV is saved in the first column
                dgvSinhVien.Rows[index].Cells[1].Value = student.HotenSV;
                dgvSinhVien.Rows[index].Cells[2].Value = student.NgaySinh; // Adjust date format
                dgvSinhVien.Rows[index].Cells[3].Value = className;
            }
        }

        private void FillLopCombobox(List<Lop> listFaculties)
        {
            cboLop.DataSource = listFaculties;
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
        }


        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    var student = new Sinhvien
                    {
                        MaSV = txtMaSV.Text,
                        HotenSV = txtHotenSV.Text,
                        NgaySinh = dtNgaysinh.Value,
                        MaLop = (string)cboLop.SelectedValue
                    };

                    context.Sinhviens.Add(student);
                    context.SaveChanges();

                    MessageBox.Show("Thêm sinh viên thành công!");
                    LoadData();          
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
    }


        private void btTim_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    if (!string.IsNullOrWhiteSpace(txtTim.Text))
                    {
                        var searchName = txtTim.Text.ToLower();

                        var result = context.Sinhviens
                            .Where(s => s.HotenSV.ToLower().Contains(searchName))
                            .Select(s => new
                            {
                                s.MaSV,
                                s.HotenSV,
                                s.NgaySinh,
                                Tenlop = s.Lop.TenLop
                            })
                            .ToList();

                        dgvSinhVien.DataSource = result;

                        if (result.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy sinh viên phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập tên sinh viên để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            using (var context = new Model1())
            {
                var listStudents = context.Sinhviens
                    .Select(s => new
                    {
                        s.MaSV,
                        s.HotenSV,
                        Lop = s.Lop.TenLop,
                        s.NgaySinh,
                    }).ToList();

                dgvSinhVien.DataSource = listStudents;
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSinhVien.CurrentRow != null)
                {
                    string studentID = dgvSinhVien.CurrentRow.Cells["MaSV"].Value.ToString();

                    using (var context = new Model1())
                    {
                        var student = context.Sinhviens.FirstOrDefault(s => s.MaSV == studentID);

                        if (student != null)
                        {
                            student.HotenSV = txtHotenSV.Text;
                            student.NgaySinh = dtNgaysinh.Value;
                            student.MaLop = (string)cboLop.SelectedValue;

                            context.SaveChanges();

                            MessageBox.Show("Cập nhật sinh viên thành công!");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sinh viên để sửa.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một sinh viên để sửa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSinhVien.CurrentRow != null)
                {
                    string studentID = dgvSinhVien.CurrentRow.Cells["MaSV"].Value.ToString();

                    using (var context = new Model1())
                    {
                        var student = context.Sinhviens.FirstOrDefault(s => s.MaSV == studentID);

                        if (student != null)
                        {
                            context.Sinhviens.Remove(student);
                            context.SaveChanges();

                            MessageBox.Show("Xóa sinh viên thành công!");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sinh viên để xóa.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một sinh viên để xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    // Kiểm tra trạng thái (Thêm, Sửa hoặc Xóa) và xử lý tương ứng
                }
                if (txtMaSV.Enabled) // Nếu thêm mới
                {
                    var newStudent = new Sinhvien
                    {
                        MaSV = txtMaSV.Text,
                        HotenSV = txtHotenSV.Text,
                        NgaySinh = dtNgaysinh.Value,
                        MaLop = cboLop.SelectedValue.ToString()
                    };

                    dbsinhvien.Sinhviens.Add(newStudent);
                }
                else if (txtHotenSV.Enabled) // Nếu sửa
                {
                    var student = dbsinhvien.Sinhviens.FirstOrDefault(s => s.MaSV == txtMaSV.Text);
                    if (student != null)
                    {
                        student.HotenSV = txtHotenSV.Text;
                        student.NgaySinh = dtNgaysinh.Value;
                        student.MaLop = cboLop.SelectedValue.ToString();
                    }
                }
                else // Nếu xóa
                {
                    var student = dbsinhvien.Sinhviens.FirstOrDefault(s => s.MaSV == txtMaSV.Text);
                    if (student != null)
                    {
                        dbsinhvien.Sinhviens.Remove(student);
                    }
                }

                dbsinhvien.SaveChanges();
                MessageBox.Show("Thao tác thành công!");

                // Tải lại dữ liệu và reset giao diện
                LoadData();
                ResetControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }
        private void ResetControls()
        {
            // Tắt các nút Lưu và Không Lưu
            btLuu.Visible = false;
            btKhong.Visible = false;

            // Tắt nhập liệu
            txtMaSV.Enabled = false;
            txtHotenSV.Enabled = false;
            dtNgaysinh.Enabled = false;
            cboLop.Enabled = false;

            // Hiển thị lại các nút Thêm, Sửa, Xóa
            btThem.Enabled = true;
            btSua.Enabled = true;
            btXoa.Enabled = true;

            // Xóa các ô nhập liệu
            txtMaSV.Clear();
            txtHotenSV.Clear();
            dtNgaysinh.Value = DateTime.Now;
            cboLop.SelectedIndex = -1;
        }

        private void btnkluu_Click(object sender, EventArgs e)
        {
            // Hủy bỏ thao tác và reset giao diện
            ResetControls();
        }

        private void btKhong_Click(object sender, EventArgs e)
        {

        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];

                    txtMaSV.Text = row.Cells["MaSV"].Value?.ToString();
                    txtHotenSV.Text = row.Cells["HotenSV"].Value?.ToString();
                    dtNgaysinh.Value = row.Cells["Ngaysinh"].Value != null
                        ? Convert.ToDateTime(row.Cells["Ngaysinh"].Value)
                        : DateTime.Now;
                    cboLop.Text = row.Cells["Tenlop"].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    } 
}
