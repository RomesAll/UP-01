
namespace PolomkaProgrammVersion2
{
    partial class WorkKlientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkKlientForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteClientBtn = new System.Windows.Forms.Button();
            this.SearchTelephoneTx = new System.Windows.Forms.TextBox();
            this.OtborGenderCb = new System.Windows.Forms.ComboBox();
            this.SearchNameTx = new System.Windows.Forms.TextBox();
            this.SearchFamTx = new System.Windows.Forms.TextBox();
            this.SearchMailTx = new System.Windows.Forms.TextBox();
            this.SearchOtchTx = new System.Windows.Forms.TextBox();
            this.SelectTegDg = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectClientDg = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectAllstrBtn = new System.Windows.Forms.Button();
            this.Select30strBtn = new System.Windows.Forms.Button();
            this.Select20strBtn = new System.Windows.Forms.Button();
            this.Select10strBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NextBtn = new System.Windows.Forms.Button();
            this.PreviousBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.OtborSearhBtn = new System.Windows.Forms.Button();
            this.SelectClientBirthdayBtn = new System.Windows.Forms.Button();
            this.SortNameBtn = new System.Windows.Forms.Button();
            this.SortFamBtn = new System.Windows.Forms.Button();
            this.SortOtchBtn = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.SortGB = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SelectTegDg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectClientDg)).BeginInit();
            this.SortGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 650);
            this.panel1.TabIndex = 0;
            // 
            // DeleteClientBtn
            // 
            this.DeleteClientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteClientBtn.Location = new System.Drawing.Point(340, 415);
            this.DeleteClientBtn.Name = "DeleteClientBtn";
            this.DeleteClientBtn.Size = new System.Drawing.Size(137, 38);
            this.DeleteClientBtn.TabIndex = 32;
            this.DeleteClientBtn.Text = "Удалить запись";
            this.DeleteClientBtn.UseVisualStyleBackColor = true;
            this.DeleteClientBtn.Click += new System.EventHandler(this.DeleteClientBtn_Click_1);
            // 
            // SearchTelephoneTx
            // 
            this.SearchTelephoneTx.BackColor = System.Drawing.SystemColors.Control;
            this.SearchTelephoneTx.ForeColor = System.Drawing.Color.Black;
            this.SearchTelephoneTx.Location = new System.Drawing.Point(686, 31);
            this.SearchTelephoneTx.Name = "SearchTelephoneTx";
            this.SearchTelephoneTx.Size = new System.Drawing.Size(121, 20);
            this.SearchTelephoneTx.TabIndex = 30;
            this.SearchTelephoneTx.Visible = false;
            this.SearchTelephoneTx.TextChanged += new System.EventHandler(this.SearchTelephoneTx_TextChanged);
            // 
            // OtborGenderCb
            // 
            this.OtborGenderCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OtborGenderCb.FormattingEnabled = true;
            this.OtborGenderCb.Items.AddRange(new object[] {
            "Муж.",
            "Жен.",
            "Все"});
            this.OtborGenderCb.Location = new System.Drawing.Point(813, 30);
            this.OtborGenderCb.Name = "OtborGenderCb";
            this.OtborGenderCb.Size = new System.Drawing.Size(112, 21);
            this.OtborGenderCb.TabIndex = 25;
            this.OtborGenderCb.Visible = false;
            this.OtborGenderCb.SelectedIndexChanged += new System.EventHandler(this.OtborGenderCb_SelectedIndexChanged);
            // 
            // SearchNameTx
            // 
            this.SearchNameTx.BackColor = System.Drawing.SystemColors.Control;
            this.SearchNameTx.ForeColor = System.Drawing.Color.Black;
            this.SearchNameTx.Location = new System.Drawing.Point(179, 31);
            this.SearchNameTx.Name = "SearchNameTx";
            this.SearchNameTx.Size = new System.Drawing.Size(120, 20);
            this.SearchNameTx.TabIndex = 26;
            this.SearchNameTx.Visible = false;
            this.SearchNameTx.TextChanged += new System.EventHandler(this.SearchNameTx_TextChanged);
            // 
            // SearchFamTx
            // 
            this.SearchFamTx.BackColor = System.Drawing.SystemColors.Control;
            this.SearchFamTx.ForeColor = System.Drawing.Color.Black;
            this.SearchFamTx.Location = new System.Drawing.Point(305, 31);
            this.SearchFamTx.Name = "SearchFamTx";
            this.SearchFamTx.Size = new System.Drawing.Size(121, 20);
            this.SearchFamTx.TabIndex = 27;
            this.SearchFamTx.Visible = false;
            this.SearchFamTx.TextChanged += new System.EventHandler(this.SearchFamTx_TextChanged);
            // 
            // SearchMailTx
            // 
            this.SearchMailTx.BackColor = System.Drawing.SystemColors.Control;
            this.SearchMailTx.ForeColor = System.Drawing.Color.Black;
            this.SearchMailTx.Location = new System.Drawing.Point(559, 31);
            this.SearchMailTx.Name = "SearchMailTx";
            this.SearchMailTx.Size = new System.Drawing.Size(121, 20);
            this.SearchMailTx.TabIndex = 29;
            this.SearchMailTx.Visible = false;
            this.SearchMailTx.TextChanged += new System.EventHandler(this.SearchMailTx_TextChanged);
            // 
            // SearchOtchTx
            // 
            this.SearchOtchTx.BackColor = System.Drawing.SystemColors.Control;
            this.SearchOtchTx.ForeColor = System.Drawing.Color.Black;
            this.SearchOtchTx.Location = new System.Drawing.Point(432, 31);
            this.SearchOtchTx.Name = "SearchOtchTx";
            this.SearchOtchTx.Size = new System.Drawing.Size(121, 20);
            this.SearchOtchTx.TabIndex = 28;
            this.SearchOtchTx.Visible = false;
            this.SearchOtchTx.TextChanged += new System.EventHandler(this.SearchOtchTx_TextChanged);
            // 
            // SelectTegDg
            // 
            this.SelectTegDg.AllowUserToAddRows = false;
            this.SelectTegDg.AllowUserToDeleteRows = false;
            this.SelectTegDg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SelectTegDg.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SelectTegDg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SelectTegDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectTegDg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column11,
            this.Column12});
            this.SelectTegDg.Location = new System.Drawing.Point(43, 57);
            this.SelectTegDg.Name = "SelectTegDg";
            this.SelectTegDg.ReadOnly = true;
            this.SelectTegDg.Size = new System.Drawing.Size(130, 352);
            this.SelectTegDg.TabIndex = 21;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "ID";
            this.Column10.HeaderText = "Номер тега";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.DataPropertyName = "Title";
            this.Column11.HeaderText = "Название тега";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "Color";
            this.Column12.HeaderText = "Цвет";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Visible = false;
            // 
            // SelectClientDg
            // 
            this.SelectClientDg.AllowUserToAddRows = false;
            this.SelectClientDg.AllowUserToDeleteRows = false;
            this.SelectClientDg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SelectClientDg.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SelectClientDg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SelectClientDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectClientDg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column13});
            this.SelectClientDg.GridColor = System.Drawing.Color.White;
            this.SelectClientDg.Location = new System.Drawing.Point(179, 57);
            this.SelectClientDg.Name = "SelectClientDg";
            this.SelectClientDg.ReadOnly = true;
            this.SelectClientDg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SelectClientDg.Size = new System.Drawing.Size(746, 352);
            this.SelectClientDg.TabIndex = 20;
            this.SelectClientDg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectClientDg_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "Номер клиента";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "FirstName";
            this.Column2.HeaderText = "Имя";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "LastName";
            this.Column3.HeaderText = "Фамилия";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Patronymic";
            this.Column4.HeaderText = "Отчество";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Birthday";
            this.Column5.HeaderText = "День рождения";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "RegistrationDate";
            this.Column6.HeaderText = "Дата регистрации";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Email";
            this.Column7.HeaderText = "Почта";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Phone";
            this.Column8.HeaderText = "Телефон";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Name";
            this.Column9.HeaderText = "Гендер";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "PhotoPath";
            this.Column13.HeaderText = "Фото";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // SelectAllstrBtn
            // 
            this.SelectAllstrBtn.Location = new System.Drawing.Point(926, 226);
            this.SelectAllstrBtn.Name = "SelectAllstrBtn";
            this.SelectAllstrBtn.Size = new System.Drawing.Size(10, 50);
            this.SelectAllstrBtn.TabIndex = 25;
            this.SelectAllstrBtn.Text = "Все";
            this.SelectAllstrBtn.UseVisualStyleBackColor = true;
            this.SelectAllstrBtn.Click += new System.EventHandler(this.SelectAllstrBtn_Click);
            // 
            // Select30strBtn
            // 
            this.Select30strBtn.Location = new System.Drawing.Point(926, 170);
            this.Select30strBtn.Name = "Select30strBtn";
            this.Select30strBtn.Size = new System.Drawing.Size(10, 50);
            this.Select30strBtn.TabIndex = 24;
            this.Select30strBtn.Text = "30 стр";
            this.Select30strBtn.UseVisualStyleBackColor = true;
            this.Select30strBtn.Click += new System.EventHandler(this.Select30strBtn_Click);
            // 
            // Select20strBtn
            // 
            this.Select20strBtn.Location = new System.Drawing.Point(926, 114);
            this.Select20strBtn.Name = "Select20strBtn";
            this.Select20strBtn.Size = new System.Drawing.Size(10, 50);
            this.Select20strBtn.TabIndex = 23;
            this.Select20strBtn.Text = "20 стр";
            this.Select20strBtn.UseVisualStyleBackColor = true;
            this.Select20strBtn.Click += new System.EventHandler(this.Select20strBtn_Click);
            // 
            // Select10strBtn
            // 
            this.Select10strBtn.Location = new System.Drawing.Point(926, 58);
            this.Select10strBtn.Name = "Select10strBtn";
            this.Select10strBtn.Size = new System.Drawing.Size(10, 50);
            this.Select10strBtn.TabIndex = 22;
            this.Select10strBtn.Text = "10 стр";
            this.Select10strBtn.UseVisualStyleBackColor = true;
            this.Select10strBtn.Click += new System.EventHandler(this.Select10strBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(912, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(857, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "0";
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(661, 415);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(146, 10);
            this.NextBtn.TabIndex = 27;
            this.NextBtn.Text = "Следующая страница";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // PreviousBtn
            // 
            this.PreviousBtn.Location = new System.Drawing.Point(514, 415);
            this.PreviousBtn.Name = "PreviousBtn";
            this.PreviousBtn.Size = new System.Drawing.Size(141, 10);
            this.PreviousBtn.TabIndex = 26;
            this.PreviousBtn.Text = "Предыдущая страница";
            this.PreviousBtn.UseVisualStyleBackColor = true;
            this.PreviousBtn.Click += new System.EventHandler(this.PreviousBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // OtborSearhBtn
            // 
            this.OtborSearhBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OtborSearhBtn.Location = new System.Drawing.Point(43, 27);
            this.OtborSearhBtn.Name = "OtborSearhBtn";
            this.OtborSearhBtn.Size = new System.Drawing.Size(130, 28);
            this.OtborSearhBtn.TabIndex = 33;
            this.OtborSearhBtn.Text = "Поиск / Отбор";
            this.OtborSearhBtn.UseVisualStyleBackColor = true;
            this.OtborSearhBtn.Click += new System.EventHandler(this.OtborSearhBtn_Click);
            // 
            // SelectClientBirthdayBtn
            // 
            this.SelectClientBirthdayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectClientBirthdayBtn.Location = new System.Drawing.Point(43, 459);
            this.SelectClientBirthdayBtn.Name = "SelectClientBirthdayBtn";
            this.SelectClientBirthdayBtn.Size = new System.Drawing.Size(434, 44);
            this.SelectClientBirthdayBtn.TabIndex = 34;
            this.SelectClientBirthdayBtn.Text = "Показать клиентов у котороых день рождения в этом месяце";
            this.SelectClientBirthdayBtn.UseVisualStyleBackColor = true;
            this.SelectClientBirthdayBtn.Click += new System.EventHandler(this.SelectClientBirthdayBtn_Click);
            // 
            // SortNameBtn
            // 
            this.SortNameBtn.Location = new System.Drawing.Point(73, 30);
            this.SortNameBtn.Name = "SortNameBtn";
            this.SortNameBtn.Size = new System.Drawing.Size(126, 32);
            this.SortNameBtn.TabIndex = 36;
            this.SortNameBtn.Text = "По имени";
            this.SortNameBtn.UseVisualStyleBackColor = true;
            this.SortNameBtn.Click += new System.EventHandler(this.SortNameBtn_Click);
            // 
            // SortFamBtn
            // 
            this.SortFamBtn.Location = new System.Drawing.Point(337, 30);
            this.SortFamBtn.Name = "SortFamBtn";
            this.SortFamBtn.Size = new System.Drawing.Size(126, 32);
            this.SortFamBtn.TabIndex = 37;
            this.SortFamBtn.Text = "По фамилии";
            this.SortFamBtn.UseVisualStyleBackColor = true;
            this.SortFamBtn.Click += new System.EventHandler(this.SortFamBtn_Click);
            // 
            // SortOtchBtn
            // 
            this.SortOtchBtn.Location = new System.Drawing.Point(205, 30);
            this.SortOtchBtn.Name = "SortOtchBtn";
            this.SortOtchBtn.Size = new System.Drawing.Size(126, 32);
            this.SortOtchBtn.TabIndex = 38;
            this.SortOtchBtn.Text = "По отчеству";
            this.SortOtchBtn.UseVisualStyleBackColor = true;
            this.SortOtchBtn.Click += new System.EventHandler(this.SortOtchBtn_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(7, 68);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(258, 32);
            this.button13.TabIndex = 39;
            this.button13.Text = "По дате последнего посещения";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(271, 68);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(258, 32);
            this.button14.TabIndex = 40;
            this.button14.Text = "По количеству посещений";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // SortGB
            // 
            this.SortGB.Controls.Add(this.SortNameBtn);
            this.SortGB.Controls.Add(this.button14);
            this.SortGB.Controls.Add(this.SortFamBtn);
            this.SortGB.Controls.Add(this.button13);
            this.SortGB.Controls.Add(this.SortOtchBtn);
            this.SortGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortGB.Location = new System.Drawing.Point(220, 525);
            this.SortGB.Name = "SortGB";
            this.SortGB.Size = new System.Drawing.Size(560, 113);
            this.SortGB.TabIndex = 41;
            this.SortGB.TabStop = false;
            this.SortGB.Text = "Сортировка";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(43, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 38);
            this.button1.TabIndex = 42;
            this.button1.Text = "Добавить клиента";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(883, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "из";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(186, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 38);
            this.button2.TabIndex = 43;
            this.button2.Text = "Редактировать клиента";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // WorkKlientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SelectClientBirthdayBtn);
            this.Controls.Add(this.DeleteClientBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SortGB);
            this.Controls.Add(this.OtborSearhBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OtborGenderCb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchTelephoneTx);
            this.Controls.Add(this.SearchOtchTx);
            this.Controls.Add(this.SearchMailTx);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.SearchFamTx);
            this.Controls.Add(this.SearchNameTx);
            this.Controls.Add(this.PreviousBtn);
            this.Controls.Add(this.SelectAllstrBtn);
            this.Controls.Add(this.Select30strBtn);
            this.Controls.Add(this.Select20strBtn);
            this.Controls.Add(this.Select10strBtn);
            this.Controls.Add(this.SelectTegDg);
            this.Controls.Add(this.SelectClientDg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WorkKlientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с клиентом";
            this.Load += new System.EventHandler(this.WorkKlientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SelectTegDg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectClientDg)).EndInit();
            this.SortGB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView SelectTegDg;
        private System.Windows.Forms.DataGridView SelectClientDg;
        private System.Windows.Forms.Button DeleteClientBtn;
        private System.Windows.Forms.TextBox SearchTelephoneTx;
        private System.Windows.Forms.ComboBox OtborGenderCb;
        private System.Windows.Forms.TextBox SearchNameTx;
        private System.Windows.Forms.TextBox SearchFamTx;
        private System.Windows.Forms.TextBox SearchMailTx;
        private System.Windows.Forms.TextBox SearchOtchTx;
        private System.Windows.Forms.Button SelectAllstrBtn;
        private System.Windows.Forms.Button Select30strBtn;
        private System.Windows.Forms.Button Select20strBtn;
        private System.Windows.Forms.Button Select10strBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button PreviousBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button OtborSearhBtn;
        private System.Windows.Forms.Button SelectClientBirthdayBtn;
        private System.Windows.Forms.Button SortNameBtn;
        private System.Windows.Forms.Button SortFamBtn;
        private System.Windows.Forms.Button SortOtchBtn;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.GroupBox SortGB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
    }
}