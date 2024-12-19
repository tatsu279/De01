using System.Windows.Forms;
namespace De01
{
    partial class frmSinhVien
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
            this.components = new System.ComponentModel.Container();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblHoten = new System.Windows.Forms.Label();
            this.lblNgaysinh = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtHotenSV = new System.Windows.Forms.TextBox();
            this.dtNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btKhong = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.quanlySVDataSet = new De01.QuanlySVDataSet();
            this.quanlySVDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlySVDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanlySVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlySVDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlySVDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSV.Location = new System.Drawing.Point(30, 40);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(56, 18);
            this.lblMaSV.TabIndex = 7;
            this.lblMaSV.Text = "Mã SV:";
            // 
            // lblHoten
            // 
            this.lblHoten.AutoSize = true;
            this.lblHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoten.Location = new System.Drawing.Point(366, 40);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(56, 18);
            this.lblHoten.TabIndex = 9;
            this.lblHoten.Text = "Họ tên:";
            // 
            // lblNgaysinh
            // 
            this.lblNgaysinh.AutoSize = true;
            this.lblNgaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaysinh.Location = new System.Drawing.Point(6, 83);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(77, 18);
            this.lblNgaysinh.TabIndex = 11;
            this.lblNgaysinh.Text = "Ngày sinh:";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLop.Location = new System.Drawing.Point(363, 83);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(66, 18);
            this.lblLop.TabIndex = 13;
            this.lblLop.Text = "Lớp học:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.Location = new System.Drawing.Point(100, 40);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(245, 24);
            this.txtMaSV.TabIndex = 8;
            // 
            // txtHotenSV
            // 
            this.txtHotenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHotenSV.Location = new System.Drawing.Point(436, 40);
            this.txtHotenSV.Name = "txtHotenSV";
            this.txtHotenSV.Size = new System.Drawing.Size(227, 24);
            this.txtHotenSV.TabIndex = 10;
            // 
            // dtNgaysinh
            // 
            this.dtNgaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgaysinh.Location = new System.Drawing.Point(100, 80);
            this.dtNgaysinh.Name = "dtNgaysinh";
            this.dtNgaysinh.Size = new System.Drawing.Size(245, 24);
            this.dtNgaysinh.TabIndex = 12;
            // 
            // cboLop
            // 
            this.cboLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLop.Location = new System.Drawing.Point(436, 80);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(227, 26);
            this.cboLop.TabIndex = 14;
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AutoGenerateColumns = false;
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.HotenSV,
            this.NgaySinh,
            this.Tenlop});
            this.dgvSinhVien.DataSource = this.quanlySVDataSetBindingSource1;
            this.dgvSinhVien.Location = new System.Drawing.Point(12, 194);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersVisible = false;
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.Size = new System.Drawing.Size(726, 241);
            this.dgvSinhVien.TabIndex = 0;
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);
            this.dgvSinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellContentClick);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(3, 3);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(80, 30);
            this.btThem.TabIndex = 0;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(89, 3);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(80, 30);
            this.btSua.TabIndex = 1;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(175, 3);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(80, 30);
            this.btXoa.TabIndex = 2;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(261, 3);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(80, 30);
            this.btLuu.TabIndex = 3;
            this.btLuu.Text = "Lưu";
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btKhong
            // 
            this.btKhong.Location = new System.Drawing.Point(347, 3);
            this.btKhong.Name = "btKhong";
            this.btKhong.Size = new System.Drawing.Size(80, 30);
            this.btKhong.TabIndex = 4;
            this.btKhong.Text = "Không";
            this.btKhong.Click += new System.EventHandler(this.btKhong_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(433, 3);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(80, 30);
            this.btThoat.TabIndex = 5;
            this.btThoat.Text = "Thoát";
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtNgaysinh);
            this.groupBox1.Controls.Add(this.cboLop);
            this.groupBox1.Controls.Add(this.lblNgaysinh);
            this.groupBox1.Controls.Add(this.lblLop);
            this.groupBox1.Controls.Add(this.txtHotenSV);
            this.groupBox1.Controls.Add(this.lblHoten);
            this.groupBox1.Controls.Add(this.lblMaSV);
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 124);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN CHI TIẾT";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btThem);
            this.flowLayoutPanel1.Controls.Add(this.btSua);
            this.flowLayoutPanel1.Controls.Add(this.btXoa);
            this.flowLayoutPanel1.Controls.Add(this.btLuu);
            this.flowLayoutPanel1.Controls.Add(this.btKhong);
            this.flowLayoutPanel1.Controls.Add(this.btThoat);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(213, 143);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(525, 49);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // btTim
            // 
            this.btTim.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTim.Location = new System.Drawing.Point(127, 139);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(80, 53);
            this.btTim.TabIndex = 18;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = false;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(12, 143);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(109, 45);
            this.txtTim.TabIndex = 19;
            // 
            // quanlySVDataSet
            // 
            this.quanlySVDataSet.DataSetName = "QuanlySVDataSet";
            this.quanlySVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanlySVDataSetBindingSource
            // 
            this.quanlySVDataSetBindingSource.DataSource = this.quanlySVDataSet;
            this.quanlySVDataSetBindingSource.Position = 0;
            // 
            // quanlySVDataSetBindingSource1
            // 
            this.quanlySVDataSetBindingSource1.DataSource = this.quanlySVDataSet;
            this.quanlySVDataSetBindingSource1.Position = 0;
            // 
            // MaSV
            // 
            this.MaSV.HeaderText = "Mã số";
            this.MaSV.MinimumWidth = 6;
            this.MaSV.Name = "MaSV";
            // 
            // HotenSV
            // 
            this.HotenSV.HeaderText = "Họ tên";
            this.HotenSV.MinimumWidth = 6;
            this.HotenSV.Name = "HotenSV";
            // 
            // NgaySinh
            // 
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            // 
            // Tenlop
            // 
            this.Tenlop.HeaderText = "Lớp";
            this.Tenlop.MinimumWidth = 6;
            this.Tenlop.Name = "Tenlop";
            // 
            // frmSinhVien
            // 
            this.ClientSize = new System.Drawing.Size(750, 446);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSinhVien";
            this.Text = "DANH SÁCH SINH VIÊN";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quanlySVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlySVDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlySVDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblHoten;
        private System.Windows.Forms.Label lblNgaysinh;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtHotenSV;
        private System.Windows.Forms.DateTimePicker dtNgaysinh;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btKhong;
        private System.Windows.Forms.Button btThoat;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btTim;
        private TextBox txtTim;
        private BindingSource quanlySVDataSetBindingSource;
        private QuanlySVDataSet quanlySVDataSet;
        private BindingSource quanlySVDataSetBindingSource1;
        private DataGridViewTextBoxColumn MaSV;
        private DataGridViewTextBoxColumn HotenSV;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn Tenlop;
    }
}