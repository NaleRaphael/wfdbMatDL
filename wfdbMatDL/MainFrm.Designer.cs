namespace wfdbMatDL
{
    partial class MainFrm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_WebsiteURL = new System.Windows.Forms.TextBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tssl_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.grp_URLSetting = new System.Windows.Forms.GroupBox();
            this.grp_Input = new System.Windows.Forms.GroupBox();
            this.lbl_Signal = new System.Windows.Forms.Label();
            this.lbl_Annotations = new System.Windows.Forms.Label();
            this.lbl_Record = new System.Windows.Forms.Label();
            this.lbl_Database = new System.Windows.Forms.Label();
            this.cmb_Signal = new System.Windows.Forms.ComboBox();
            this.cmb_Annotations = new System.Windows.Forms.ComboBox();
            this.cmb_Record_SubDir = new System.Windows.Forms.ComboBox();
            this.cmb_Record = new System.Windows.Forms.ComboBox();
            this.cmb_Database = new System.Windows.Forms.ComboBox();
            this.btn_Test = new System.Windows.Forms.Button();
            this.txt_Message = new System.Windows.Forms.TextBox();
            this.lbl_Length = new System.Windows.Forms.Label();
            this.rbtn_Length_10s = new System.Windows.Forms.RadioButton();
            this.grp_Output = new System.Windows.Forms.GroupBox();
            this.pnl_rbtnGrp02 = new System.Windows.Forms.Panel();
            this.lbl_TimeFormat = new System.Windows.Forms.Label();
            this.rbtn_TF_Samples = new System.Windows.Forms.RadioButton();
            this.rbtn_TF_TimeDate = new System.Windows.Forms.RadioButton();
            this.rbtn_TF_Seconds = new System.Windows.Forms.RadioButton();
            this.rbtn_TF_ElapsedTime = new System.Windows.Forms.RadioButton();
            this.rbtn_TF_Minutes = new System.Windows.Forms.RadioButton();
            this.rbtn_TF_Hours = new System.Windows.Forms.RadioButton();
            this.pnl_rbtnGrp01 = new System.Windows.Forms.Panel();
            this.rbtn_Length_1min = new System.Windows.Forms.RadioButton();
            this.rbtn_Length_ToEnd = new System.Windows.Forms.RadioButton();
            this.rbtn_Length_1hr = new System.Windows.Forms.RadioButton();
            this.rbtn_Length_12hr = new System.Windows.Forms.RadioButton();
            this.rbtn_DF_RawADCUnits = new System.Windows.Forms.RadioButton();
            this.rbtn_DF_HPrecision = new System.Windows.Forms.RadioButton();
            this.rbtn_DF_Stanard = new System.Windows.Forms.RadioButton();
            this.lbl_DataFormat = new System.Windows.Forms.Label();
            this.pnl_rbtnGrp03 = new System.Windows.Forms.Panel();
            this.grp_SaveSetting = new System.Windows.Forms.GroupBox();
            this.chk_CreateFolder = new System.Windows.Forms.CheckBox();
            this.clb_BatchDLList = new System.Windows.Forms.CheckedListBox();
            this.btn_SavePath = new System.Windows.Forms.Button();
            this.btn_Download = new System.Windows.Forms.Button();
            this.txt_SavePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckb_EnableBatchDL = new System.Windows.Forms.CheckBox();
            this.statusStrip.SuspendLayout();
            this.grp_URLSetting.SuspendLayout();
            this.grp_Input.SuspendLayout();
            this.grp_Output.SuspendLayout();
            this.pnl_rbtnGrp02.SuspendLayout();
            this.pnl_rbtnGrp01.SuspendLayout();
            this.pnl_rbtnGrp03.SuspendLayout();
            this.grp_SaveSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_WebsiteURL
            // 
            this.txt_WebsiteURL.Location = new System.Drawing.Point(6, 21);
            this.txt_WebsiteURL.Name = "txt_WebsiteURL";
            this.txt_WebsiteURL.Size = new System.Drawing.Size(548, 22);
            this.txt_WebsiteURL.TabIndex = 0;
            this.txt_WebsiteURL.Text = "http://physionet.org/cgi-bin/atm/ATM";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(479, 49);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 23);
            this.btn_Connect.TabIndex = 1;
            this.btn_Connect.Text = "Connet";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_GetURLSource_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_Status});
            this.statusStrip.Location = new System.Drawing.Point(0, 540);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(584, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tssl_Status
            // 
            this.tssl_Status.Name = "tssl_Status";
            this.tssl_Status.Size = new System.Drawing.Size(0, 17);
            // 
            // grp_URLSetting
            // 
            this.grp_URLSetting.Controls.Add(this.txt_WebsiteURL);
            this.grp_URLSetting.Controls.Add(this.btn_Connect);
            this.grp_URLSetting.Location = new System.Drawing.Point(12, 12);
            this.grp_URLSetting.Name = "grp_URLSetting";
            this.grp_URLSetting.Size = new System.Drawing.Size(560, 79);
            this.grp_URLSetting.TabIndex = 3;
            this.grp_URLSetting.TabStop = false;
            this.grp_URLSetting.Text = "Website URL";
            // 
            // grp_Input
            // 
            this.grp_Input.Controls.Add(this.lbl_Signal);
            this.grp_Input.Controls.Add(this.lbl_Annotations);
            this.grp_Input.Controls.Add(this.lbl_Record);
            this.grp_Input.Controls.Add(this.lbl_Database);
            this.grp_Input.Controls.Add(this.cmb_Signal);
            this.grp_Input.Controls.Add(this.cmb_Annotations);
            this.grp_Input.Controls.Add(this.cmb_Record_SubDir);
            this.grp_Input.Controls.Add(this.cmb_Record);
            this.grp_Input.Controls.Add(this.cmb_Database);
            this.grp_Input.Location = new System.Drawing.Point(12, 97);
            this.grp_Input.Name = "grp_Input";
            this.grp_Input.Size = new System.Drawing.Size(560, 102);
            this.grp_Input.TabIndex = 4;
            this.grp_Input.TabStop = false;
            this.grp_Input.Text = "Input";
            // 
            // lbl_Signal
            // 
            this.lbl_Signal.AutoSize = true;
            this.lbl_Signal.Location = new System.Drawing.Point(333, 50);
            this.lbl_Signal.Name = "lbl_Signal";
            this.lbl_Signal.Size = new System.Drawing.Size(34, 12);
            this.lbl_Signal.TabIndex = 1;
            this.lbl_Signal.Text = "Signal";
            // 
            // lbl_Annotations
            // 
            this.lbl_Annotations.AutoSize = true;
            this.lbl_Annotations.Location = new System.Drawing.Point(6, 76);
            this.lbl_Annotations.Name = "lbl_Annotations";
            this.lbl_Annotations.Size = new System.Drawing.Size(61, 12);
            this.lbl_Annotations.TabIndex = 1;
            this.lbl_Annotations.Text = "Annotations";
            // 
            // lbl_Record
            // 
            this.lbl_Record.AutoSize = true;
            this.lbl_Record.Location = new System.Drawing.Point(28, 50);
            this.lbl_Record.Name = "lbl_Record";
            this.lbl_Record.Size = new System.Drawing.Size(39, 12);
            this.lbl_Record.TabIndex = 1;
            this.lbl_Record.Text = "Record";
            // 
            // lbl_Database
            // 
            this.lbl_Database.AutoSize = true;
            this.lbl_Database.Location = new System.Drawing.Point(21, 24);
            this.lbl_Database.Name = "lbl_Database";
            this.lbl_Database.Size = new System.Drawing.Size(46, 12);
            this.lbl_Database.TabIndex = 1;
            this.lbl_Database.Text = "Database";
            // 
            // cmb_Signal
            // 
            this.cmb_Signal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Signal.FormattingEnabled = true;
            this.cmb_Signal.Location = new System.Drawing.Point(373, 47);
            this.cmb_Signal.Name = "cmb_Signal";
            this.cmb_Signal.Size = new System.Drawing.Size(120, 20);
            this.cmb_Signal.TabIndex = 0;
            // 
            // cmb_Annotations
            // 
            this.cmb_Annotations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Annotations.FormattingEnabled = true;
            this.cmb_Annotations.Location = new System.Drawing.Point(73, 73);
            this.cmb_Annotations.Name = "cmb_Annotations";
            this.cmb_Annotations.Size = new System.Drawing.Size(194, 20);
            this.cmb_Annotations.TabIndex = 0;
            // 
            // cmb_Record_SubDir
            // 
            this.cmb_Record_SubDir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Record_SubDir.FormattingEnabled = true;
            this.cmb_Record_SubDir.Location = new System.Drawing.Point(199, 47);
            this.cmb_Record_SubDir.Name = "cmb_Record_SubDir";
            this.cmb_Record_SubDir.Size = new System.Drawing.Size(120, 20);
            this.cmb_Record_SubDir.TabIndex = 0;
            // 
            // cmb_Record
            // 
            this.cmb_Record.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Record.FormattingEnabled = true;
            this.cmb_Record.Location = new System.Drawing.Point(73, 47);
            this.cmb_Record.Name = "cmb_Record";
            this.cmb_Record.Size = new System.Drawing.Size(120, 20);
            this.cmb_Record.TabIndex = 0;
            this.cmb_Record.SelectedIndexChanged += new System.EventHandler(this.cmb_Record_SelectedIndexChanged);
            // 
            // cmb_Database
            // 
            this.cmb_Database.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Database.FormattingEnabled = true;
            this.cmb_Database.Location = new System.Drawing.Point(73, 21);
            this.cmb_Database.Name = "cmb_Database";
            this.cmb_Database.Size = new System.Drawing.Size(420, 20);
            this.cmb_Database.TabIndex = 0;
            this.cmb_Database.SelectedIndexChanged += new System.EventHandler(this.cmb_Database_SelectedIndexChanged);
            // 
            // btn_Test
            // 
            this.btn_Test.Location = new System.Drawing.Point(479, 68);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(75, 23);
            this.btn_Test.TabIndex = 2;
            this.btn_Test.Text = "test";
            this.btn_Test.UseVisualStyleBackColor = true;
            this.btn_Test.Click += new System.EventHandler(this.btn_Test_Click);
            // 
            // txt_Message
            // 
            this.txt_Message.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Message.Location = new System.Drawing.Point(12, 480);
            this.txt_Message.Multiline = true;
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.ReadOnly = true;
            this.txt_Message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Message.Size = new System.Drawing.Size(560, 57);
            this.txt_Message.TabIndex = 0;
            // 
            // lbl_Length
            // 
            this.lbl_Length.AutoSize = true;
            this.lbl_Length.Location = new System.Drawing.Point(3, 5);
            this.lbl_Length.Name = "lbl_Length";
            this.lbl_Length.Size = new System.Drawing.Size(38, 12);
            this.lbl_Length.TabIndex = 1;
            this.lbl_Length.Text = "Length";
            // 
            // rbtn_Length_10s
            // 
            this.rbtn_Length_10s.AutoSize = true;
            this.rbtn_Length_10s.Location = new System.Drawing.Point(47, 3);
            this.rbtn_Length_10s.Name = "rbtn_Length_10s";
            this.rbtn_Length_10s.Size = new System.Drawing.Size(52, 16);
            this.rbtn_Length_10s.TabIndex = 3;
            this.rbtn_Length_10s.TabStop = true;
            this.rbtn_Length_10s.Text = "10 sec";
            this.rbtn_Length_10s.UseVisualStyleBackColor = true;
            // 
            // grp_Output
            // 
            this.grp_Output.Controls.Add(this.pnl_rbtnGrp02);
            this.grp_Output.Controls.Add(this.pnl_rbtnGrp01);
            this.grp_Output.Controls.Add(this.btn_Test);
            this.grp_Output.Location = new System.Drawing.Point(12, 205);
            this.grp_Output.Name = "grp_Output";
            this.grp_Output.Size = new System.Drawing.Size(560, 98);
            this.grp_Output.TabIndex = 5;
            this.grp_Output.TabStop = false;
            this.grp_Output.Text = "Output";
            // 
            // pnl_rbtnGrp02
            // 
            this.pnl_rbtnGrp02.Controls.Add(this.lbl_TimeFormat);
            this.pnl_rbtnGrp02.Controls.Add(this.rbtn_TF_Samples);
            this.pnl_rbtnGrp02.Controls.Add(this.rbtn_TF_TimeDate);
            this.pnl_rbtnGrp02.Controls.Add(this.rbtn_TF_Seconds);
            this.pnl_rbtnGrp02.Controls.Add(this.rbtn_TF_ElapsedTime);
            this.pnl_rbtnGrp02.Controls.Add(this.rbtn_TF_Minutes);
            this.pnl_rbtnGrp02.Controls.Add(this.rbtn_TF_Hours);
            this.pnl_rbtnGrp02.Location = new System.Drawing.Point(2, 43);
            this.pnl_rbtnGrp02.Name = "pnl_rbtnGrp02";
            this.pnl_rbtnGrp02.Size = new System.Drawing.Size(477, 24);
            this.pnl_rbtnGrp02.TabIndex = 4;
            // 
            // lbl_TimeFormat
            // 
            this.lbl_TimeFormat.AutoSize = true;
            this.lbl_TimeFormat.Location = new System.Drawing.Point(3, 5);
            this.lbl_TimeFormat.Name = "lbl_TimeFormat";
            this.lbl_TimeFormat.Size = new System.Drawing.Size(63, 12);
            this.lbl_TimeFormat.TabIndex = 1;
            this.lbl_TimeFormat.Text = "Time format";
            // 
            // rbtn_TF_Samples
            // 
            this.rbtn_TF_Samples.AutoSize = true;
            this.rbtn_TF_Samples.Location = new System.Drawing.Point(414, 3);
            this.rbtn_TF_Samples.Name = "rbtn_TF_Samples";
            this.rbtn_TF_Samples.Size = new System.Drawing.Size(59, 16);
            this.rbtn_TF_Samples.TabIndex = 3;
            this.rbtn_TF_Samples.TabStop = true;
            this.rbtn_TF_Samples.Text = "samples";
            this.rbtn_TF_Samples.UseVisualStyleBackColor = true;
            // 
            // rbtn_TF_TimeDate
            // 
            this.rbtn_TF_TimeDate.AutoSize = true;
            this.rbtn_TF_TimeDate.Location = new System.Drawing.Point(72, 3);
            this.rbtn_TF_TimeDate.Name = "rbtn_TF_TimeDate";
            this.rbtn_TF_TimeDate.Size = new System.Drawing.Size(65, 16);
            this.rbtn_TF_TimeDate.TabIndex = 3;
            this.rbtn_TF_TimeDate.TabStop = true;
            this.rbtn_TF_TimeDate.Text = "time/date";
            this.rbtn_TF_TimeDate.UseVisualStyleBackColor = true;
            // 
            // rbtn_TF_Seconds
            // 
            this.rbtn_TF_Seconds.AutoSize = true;
            this.rbtn_TF_Seconds.Location = new System.Drawing.Point(349, 3);
            this.rbtn_TF_Seconds.Name = "rbtn_TF_Seconds";
            this.rbtn_TF_Seconds.Size = new System.Drawing.Size(59, 16);
            this.rbtn_TF_Seconds.TabIndex = 3;
            this.rbtn_TF_Seconds.TabStop = true;
            this.rbtn_TF_Seconds.Text = "seconds";
            this.rbtn_TF_Seconds.UseVisualStyleBackColor = true;
            // 
            // rbtn_TF_ElapsedTime
            // 
            this.rbtn_TF_ElapsedTime.AutoSize = true;
            this.rbtn_TF_ElapsedTime.Location = new System.Drawing.Point(143, 3);
            this.rbtn_TF_ElapsedTime.Name = "rbtn_TF_ElapsedTime";
            this.rbtn_TF_ElapsedTime.Size = new System.Drawing.Size(80, 16);
            this.rbtn_TF_ElapsedTime.TabIndex = 3;
            this.rbtn_TF_ElapsedTime.TabStop = true;
            this.rbtn_TF_ElapsedTime.Text = "elapsed time";
            this.rbtn_TF_ElapsedTime.UseVisualStyleBackColor = true;
            // 
            // rbtn_TF_Minutes
            // 
            this.rbtn_TF_Minutes.AutoSize = true;
            this.rbtn_TF_Minutes.Location = new System.Drawing.Point(284, 3);
            this.rbtn_TF_Minutes.Name = "rbtn_TF_Minutes";
            this.rbtn_TF_Minutes.Size = new System.Drawing.Size(59, 16);
            this.rbtn_TF_Minutes.TabIndex = 3;
            this.rbtn_TF_Minutes.TabStop = true;
            this.rbtn_TF_Minutes.Text = "minutes";
            this.rbtn_TF_Minutes.UseVisualStyleBackColor = true;
            // 
            // rbtn_TF_Hours
            // 
            this.rbtn_TF_Hours.AutoSize = true;
            this.rbtn_TF_Hours.Location = new System.Drawing.Point(226, 3);
            this.rbtn_TF_Hours.Name = "rbtn_TF_Hours";
            this.rbtn_TF_Hours.Size = new System.Drawing.Size(49, 16);
            this.rbtn_TF_Hours.TabIndex = 3;
            this.rbtn_TF_Hours.TabStop = true;
            this.rbtn_TF_Hours.Text = "hours";
            this.rbtn_TF_Hours.UseVisualStyleBackColor = true;
            // 
            // pnl_rbtnGrp01
            // 
            this.pnl_rbtnGrp01.Controls.Add(this.rbtn_Length_10s);
            this.pnl_rbtnGrp01.Controls.Add(this.lbl_Length);
            this.pnl_rbtnGrp01.Controls.Add(this.rbtn_Length_1min);
            this.pnl_rbtnGrp01.Controls.Add(this.rbtn_Length_ToEnd);
            this.pnl_rbtnGrp01.Controls.Add(this.rbtn_Length_1hr);
            this.pnl_rbtnGrp01.Controls.Add(this.rbtn_Length_12hr);
            this.pnl_rbtnGrp01.Location = new System.Drawing.Point(27, 18);
            this.pnl_rbtnGrp01.Name = "pnl_rbtnGrp01";
            this.pnl_rbtnGrp01.Size = new System.Drawing.Size(348, 23);
            this.pnl_rbtnGrp01.TabIndex = 4;
            // 
            // rbtn_Length_1min
            // 
            this.rbtn_Length_1min.AutoSize = true;
            this.rbtn_Length_1min.Location = new System.Drawing.Point(105, 3);
            this.rbtn_Length_1min.Name = "rbtn_Length_1min";
            this.rbtn_Length_1min.Size = new System.Drawing.Size(50, 16);
            this.rbtn_Length_1min.TabIndex = 3;
            this.rbtn_Length_1min.TabStop = true;
            this.rbtn_Length_1min.Text = "1 min";
            this.rbtn_Length_1min.UseVisualStyleBackColor = true;
            // 
            // rbtn_Length_ToEnd
            // 
            this.rbtn_Length_ToEnd.AutoSize = true;
            this.rbtn_Length_ToEnd.Location = new System.Drawing.Point(287, 3);
            this.rbtn_Length_ToEnd.Name = "rbtn_Length_ToEnd";
            this.rbtn_Length_ToEnd.Size = new System.Drawing.Size(56, 16);
            this.rbtn_Length_ToEnd.TabIndex = 3;
            this.rbtn_Length_ToEnd.TabStop = true;
            this.rbtn_Length_ToEnd.Text = "To end";
            this.rbtn_Length_ToEnd.UseVisualStyleBackColor = true;
            // 
            // rbtn_Length_1hr
            // 
            this.rbtn_Length_1hr.AutoSize = true;
            this.rbtn_Length_1hr.Location = new System.Drawing.Point(161, 3);
            this.rbtn_Length_1hr.Name = "rbtn_Length_1hr";
            this.rbtn_Length_1hr.Size = new System.Drawing.Size(54, 16);
            this.rbtn_Length_1hr.TabIndex = 3;
            this.rbtn_Length_1hr.TabStop = true;
            this.rbtn_Length_1hr.Text = "1 hour";
            this.rbtn_Length_1hr.UseVisualStyleBackColor = true;
            // 
            // rbtn_Length_12hr
            // 
            this.rbtn_Length_12hr.AutoSize = true;
            this.rbtn_Length_12hr.Location = new System.Drawing.Point(221, 3);
            this.rbtn_Length_12hr.Name = "rbtn_Length_12hr";
            this.rbtn_Length_12hr.Size = new System.Drawing.Size(60, 16);
            this.rbtn_Length_12hr.TabIndex = 3;
            this.rbtn_Length_12hr.TabStop = true;
            this.rbtn_Length_12hr.Text = "12 hour";
            this.rbtn_Length_12hr.UseVisualStyleBackColor = true;
            // 
            // rbtn_DF_RawADCUnits
            // 
            this.rbtn_DF_RawADCUnits.AutoSize = true;
            this.rbtn_DF_RawADCUnits.Location = new System.Drawing.Point(235, 4);
            this.rbtn_DF_RawADCUnits.Name = "rbtn_DF_RawADCUnits";
            this.rbtn_DF_RawADCUnits.Size = new System.Drawing.Size(92, 16);
            this.rbtn_DF_RawADCUnits.TabIndex = 3;
            this.rbtn_DF_RawADCUnits.TabStop = true;
            this.rbtn_DF_RawADCUnits.Text = "raw ADC units";
            this.rbtn_DF_RawADCUnits.UseVisualStyleBackColor = true;
            // 
            // rbtn_DF_HPrecision
            // 
            this.rbtn_DF_HPrecision.AutoSize = true;
            this.rbtn_DF_HPrecision.Location = new System.Drawing.Point(140, 4);
            this.rbtn_DF_HPrecision.Name = "rbtn_DF_HPrecision";
            this.rbtn_DF_HPrecision.Size = new System.Drawing.Size(89, 16);
            this.rbtn_DF_HPrecision.TabIndex = 3;
            this.rbtn_DF_HPrecision.TabStop = true;
            this.rbtn_DF_HPrecision.Text = "high precision";
            this.rbtn_DF_HPrecision.UseVisualStyleBackColor = true;
            // 
            // rbtn_DF_Stanard
            // 
            this.rbtn_DF_Stanard.AutoSize = true;
            this.rbtn_DF_Stanard.Location = new System.Drawing.Point(72, 4);
            this.rbtn_DF_Stanard.Name = "rbtn_DF_Stanard";
            this.rbtn_DF_Stanard.Size = new System.Drawing.Size(62, 16);
            this.rbtn_DF_Stanard.TabIndex = 3;
            this.rbtn_DF_Stanard.TabStop = true;
            this.rbtn_DF_Stanard.Text = "standard";
            this.rbtn_DF_Stanard.UseVisualStyleBackColor = true;
            // 
            // lbl_DataFormat
            // 
            this.lbl_DataFormat.AutoSize = true;
            this.lbl_DataFormat.Location = new System.Drawing.Point(6, 6);
            this.lbl_DataFormat.Name = "lbl_DataFormat";
            this.lbl_DataFormat.Size = new System.Drawing.Size(60, 12);
            this.lbl_DataFormat.TabIndex = 1;
            this.lbl_DataFormat.Text = "Data format";
            // 
            // pnl_rbtnGrp03
            // 
            this.pnl_rbtnGrp03.Controls.Add(this.lbl_DataFormat);
            this.pnl_rbtnGrp03.Controls.Add(this.rbtn_DF_Stanard);
            this.pnl_rbtnGrp03.Controls.Add(this.rbtn_DF_RawADCUnits);
            this.pnl_rbtnGrp03.Controls.Add(this.rbtn_DF_HPrecision);
            this.pnl_rbtnGrp03.Location = new System.Drawing.Point(14, 273);
            this.pnl_rbtnGrp03.Name = "pnl_rbtnGrp03";
            this.pnl_rbtnGrp03.Size = new System.Drawing.Size(331, 24);
            this.pnl_rbtnGrp03.TabIndex = 4;
            // 
            // grp_SaveSetting
            // 
            this.grp_SaveSetting.Controls.Add(this.chk_CreateFolder);
            this.grp_SaveSetting.Controls.Add(this.clb_BatchDLList);
            this.grp_SaveSetting.Controls.Add(this.btn_SavePath);
            this.grp_SaveSetting.Controls.Add(this.btn_Download);
            this.grp_SaveSetting.Controls.Add(this.txt_SavePath);
            this.grp_SaveSetting.Controls.Add(this.label1);
            this.grp_SaveSetting.Controls.Add(this.ckb_EnableBatchDL);
            this.grp_SaveSetting.Location = new System.Drawing.Point(12, 309);
            this.grp_SaveSetting.Name = "grp_SaveSetting";
            this.grp_SaveSetting.Size = new System.Drawing.Size(560, 165);
            this.grp_SaveSetting.TabIndex = 6;
            this.grp_SaveSetting.TabStop = false;
            this.grp_SaveSetting.Text = "Save Setting";
            // 
            // chk_CreateFolder
            // 
            this.chk_CreateFolder.AutoSize = true;
            this.chk_CreateFolder.Location = new System.Drawing.Point(237, 48);
            this.chk_CreateFolder.Name = "chk_CreateFolder";
            this.chk_CreateFolder.Size = new System.Drawing.Size(132, 16);
            this.chk_CreateFolder.TabIndex = 4;
            this.chk_CreateFolder.Text = "Save in the same folder";
            this.chk_CreateFolder.UseVisualStyleBackColor = true;
            // 
            // clb_BatchDLList
            // 
            this.clb_BatchDLList.Enabled = false;
            this.clb_BatchDLList.FormattingEnabled = true;
            this.clb_BatchDLList.Location = new System.Drawing.Point(37, 66);
            this.clb_BatchDLList.Name = "clb_BatchDLList";
            this.clb_BatchDLList.Size = new System.Drawing.Size(433, 89);
            this.clb_BatchDLList.TabIndex = 3;
            // 
            // btn_SavePath
            // 
            this.btn_SavePath.Location = new System.Drawing.Point(530, 20);
            this.btn_SavePath.Name = "btn_SavePath";
            this.btn_SavePath.Size = new System.Drawing.Size(24, 24);
            this.btn_SavePath.TabIndex = 2;
            this.btn_SavePath.Text = "...";
            this.btn_SavePath.UseVisualStyleBackColor = true;
            this.btn_SavePath.Click += new System.EventHandler(this.btn_SavePath_Click);
            // 
            // btn_Download
            // 
            this.btn_Download.Location = new System.Drawing.Point(479, 132);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(75, 23);
            this.btn_Download.TabIndex = 2;
            this.btn_Download.Text = "Download";
            this.btn_Download.UseVisualStyleBackColor = true;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // txt_SavePath
            // 
            this.txt_SavePath.Location = new System.Drawing.Point(37, 21);
            this.txt_SavePath.Name = "txt_SavePath";
            this.txt_SavePath.Size = new System.Drawing.Size(496, 22);
            this.txt_SavePath.TabIndex = 0;
            this.txt_SavePath.Text = "E:\\Users\\SPLab\\Documents\\PhysiobankDatabase";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path";
            // 
            // ckb_EnableBatchDL
            // 
            this.ckb_EnableBatchDL.AutoSize = true;
            this.ckb_EnableBatchDL.Location = new System.Drawing.Point(37, 48);
            this.ckb_EnableBatchDL.Name = "ckb_EnableBatchDL";
            this.ckb_EnableBatchDL.Size = new System.Drawing.Size(102, 16);
            this.ckb_EnableBatchDL.TabIndex = 0;
            this.ckb_EnableBatchDL.Text = "Batch Download";
            this.ckb_EnableBatchDL.UseVisualStyleBackColor = true;
            this.ckb_EnableBatchDL.CheckedChanged += new System.EventHandler(this.ckb_EnableBatchDL_CheckedChanged);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.grp_SaveSetting);
            this.Controls.Add(this.pnl_rbtnGrp03);
            this.Controls.Add(this.grp_Input);
            this.Controls.Add(this.grp_URLSetting);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.txt_Message);
            this.Controls.Add(this.grp_Output);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainFrm";
            this.Text = "Physionet Database Downloader";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.grp_URLSetting.ResumeLayout(false);
            this.grp_URLSetting.PerformLayout();
            this.grp_Input.ResumeLayout(false);
            this.grp_Input.PerformLayout();
            this.grp_Output.ResumeLayout(false);
            this.pnl_rbtnGrp02.ResumeLayout(false);
            this.pnl_rbtnGrp02.PerformLayout();
            this.pnl_rbtnGrp01.ResumeLayout(false);
            this.pnl_rbtnGrp01.PerformLayout();
            this.pnl_rbtnGrp03.ResumeLayout(false);
            this.pnl_rbtnGrp03.PerformLayout();
            this.grp_SaveSetting.ResumeLayout(false);
            this.grp_SaveSetting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_WebsiteURL;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tssl_Status;
        private System.Windows.Forms.GroupBox grp_URLSetting;
        private System.Windows.Forms.GroupBox grp_Input;
        private System.Windows.Forms.Label lbl_Database;
        private System.Windows.Forms.ComboBox cmb_Database;
        private System.Windows.Forms.TextBox txt_Message;
        private System.Windows.Forms.Button btn_Test;
        private System.Windows.Forms.Label lbl_Signal;
        private System.Windows.Forms.Label lbl_Annotations;
        private System.Windows.Forms.Label lbl_Record;
        private System.Windows.Forms.ComboBox cmb_Signal;
        private System.Windows.Forms.ComboBox cmb_Annotations;
        private System.Windows.Forms.ComboBox cmb_Record;
        private System.Windows.Forms.Label lbl_Length;
        private System.Windows.Forms.RadioButton rbtn_Length_10s;
        private System.Windows.Forms.GroupBox grp_Output;
        private System.Windows.Forms.RadioButton rbtn_Length_1min;
        private System.Windows.Forms.RadioButton rbtn_TF_Seconds;
        private System.Windows.Forms.RadioButton rbtn_Length_ToEnd;
        private System.Windows.Forms.RadioButton rbtn_TF_Minutes;
        private System.Windows.Forms.RadioButton rbtn_Length_12hr;
        private System.Windows.Forms.RadioButton rbtn_TF_Hours;
        private System.Windows.Forms.RadioButton rbtn_Length_1hr;
        private System.Windows.Forms.RadioButton rbtn_TF_ElapsedTime;
        private System.Windows.Forms.RadioButton rbtn_TF_TimeDate;
        private System.Windows.Forms.Label lbl_TimeFormat;
        private System.Windows.Forms.RadioButton rbtn_TF_Samples;
        private System.Windows.Forms.RadioButton rbtn_DF_RawADCUnits;
        private System.Windows.Forms.RadioButton rbtn_DF_HPrecision;
        private System.Windows.Forms.RadioButton rbtn_DF_Stanard;
        private System.Windows.Forms.Label lbl_DataFormat;
        private System.Windows.Forms.ComboBox cmb_Record_SubDir;
        private System.Windows.Forms.Panel pnl_rbtnGrp01;
        private System.Windows.Forms.Panel pnl_rbtnGrp02;
        private System.Windows.Forms.Panel pnl_rbtnGrp03;
        private System.Windows.Forms.GroupBox grp_SaveSetting;
        private System.Windows.Forms.TextBox txt_SavePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckb_EnableBatchDL;
        private System.Windows.Forms.Button btn_SavePath;
        private System.Windows.Forms.CheckedListBox clb_BatchDLList;
        private System.Windows.Forms.Button btn_Download;
        private System.Windows.Forms.CheckBox chk_CreateFolder;
    }
}

