namespace UHFReader288MPDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lrtxtLog = new CustomControl.LogRichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Maintab = new System.Windows.Forms.TabControl();
            this.Main_Page1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Basic = new System.Windows.Forms.TabPage();
            this.gbReturnLoss = new System.Windows.Forms.GroupBox();
            this.cbbAnt = new System.Windows.Forms.ComboBox();
            this.label120 = new System.Windows.Forms.Label();
            this.label121 = new System.Windows.Forms.Label();
            this.cmbReturnLossFreq = new System.Windows.Forms.ComboBox();
            this.label122 = new System.Windows.Forms.Label();
            this.textReturnLoss = new System.Windows.Forms.TextBox();
            this.btReturnLoss = new System.Windows.Forms.Button();
            this.gbCmdTemperature = new System.Windows.Forms.GroupBox();
            this.btnGetReaderTemperature = new System.Windows.Forms.Button();
            this.txtReaderTemperature = new System.Windows.Forms.TextBox();
            this.gbp_DRM = new System.Windows.Forms.GroupBox();
            this.DRM_CLOSE = new System.Windows.Forms.RadioButton();
            this.DRM_OPEN = new System.Windows.Forms.RadioButton();
            this.bt_GetDRM = new System.Windows.Forms.Button();
            this.bt_setDRM = new System.Windows.Forms.Button();
            this.gbp_Retry = new System.Windows.Forms.GroupBox();
            this.com_retrytimes = new System.Windows.Forms.ComboBox();
            this.bt_Getretry = new System.Windows.Forms.Button();
            this.bt_Setretry = new System.Windows.Forms.Button();
            this.gbp_wpower = new System.Windows.Forms.GroupBox();
            this.label112 = new System.Windows.Forms.Label();
            this.com_wpower = new System.Windows.Forms.ComboBox();
            this.rb_wp2 = new System.Windows.Forms.RadioButton();
            this.rb_wp1 = new System.Windows.Forms.RadioButton();
            this.bt_GetWpower = new System.Windows.Forms.Button();
            this.bt_SetWpower = new System.Windows.Forms.Button();
            this.group_maxtime = new System.Windows.Forms.GroupBox();
            this.comboBox_maxtime = new System.Windows.Forms.ComboBox();
            this.btSetMaxtime = new System.Windows.Forms.Button();
            this.gbp_buff = new System.Windows.Forms.GroupBox();
            this.rb496 = new System.Windows.Forms.RadioButton();
            this.rb128 = new System.Windows.Forms.RadioButton();
            this.btGetEPCandTIDLen = new System.Windows.Forms.Button();
            this.btSetEPCandTIDLen = new System.Windows.Forms.Button();
            this.btGetInformation = new System.Windows.Forms.Button();
            this.btDefault = new System.Windows.Forms.Button();
            this.gpb_antconfig = new System.Windows.Forms.GroupBox();
            this.Button_Ant = new System.Windows.Forms.Button();
            this.checkant4 = new System.Windows.Forms.CheckBox();
            this.checkant3 = new System.Windows.Forms.CheckBox();
            this.checkant2 = new System.Windows.Forms.CheckBox();
            this.checkant1 = new System.Windows.Forms.CheckBox();
            this.gpb_checkant = new System.Windows.Forms.GroupBox();
            this.btSetcheckant = new System.Windows.Forms.Button();
            this.rb_Closecheckant = new System.Windows.Forms.RadioButton();
            this.rb_Opencheckant = new System.Windows.Forms.RadioButton();
            this.gpb_GPIO = new System.Windows.Forms.GroupBox();
            this.Button_GetGPIO = new System.Windows.Forms.Button();
            this.Button_SetGPIO = new System.Windows.Forms.Button();
            this.check_int2 = new System.Windows.Forms.CheckBox();
            this.check_int1 = new System.Windows.Forms.CheckBox();
            this.check_out2 = new System.Windows.Forms.CheckBox();
            this.check_out1 = new System.Windows.Forms.CheckBox();
            this.gpb_OutputRep = new System.Windows.Forms.GroupBox();
            this.btOutputRep = new System.Windows.Forms.Button();
            this.check_OutputRep4 = new System.Windows.Forms.CheckBox();
            this.check_OutputRep3 = new System.Windows.Forms.CheckBox();
            this.check_OutputRep2 = new System.Windows.Forms.CheckBox();
            this.check_OutputRep1 = new System.Windows.Forms.CheckBox();
            this.gpb_Relay = new System.Windows.Forms.GroupBox();
            this.label38 = new System.Windows.Forms.Label();
            this.ComboBox_RelayTime = new System.Windows.Forms.ComboBox();
            this.label37 = new System.Windows.Forms.Label();
            this.btRelay = new System.Windows.Forms.Button();
            this.gpb_baud = new System.Windows.Forms.GroupBox();
            this.ComboBox_baud = new System.Windows.Forms.ComboBox();
            this.btBaudRate = new System.Windows.Forms.Button();
            this.gpb_DBM = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ComboBox_PowerDbm = new System.Windows.Forms.ComboBox();
            this.BT_DBM = new System.Windows.Forms.Button();
            this.gpb_Freq = new System.Windows.Forms.GroupBox();
            this.radioButton_band8 = new System.Windows.Forms.RadioButton();
            this.CheckBox_SameFre = new System.Windows.Forms.CheckBox();
            this.radioButton_band4 = new System.Windows.Forms.RadioButton();
            this.radioButton_band3 = new System.Windows.Forms.RadioButton();
            this.radioButton_band2 = new System.Windows.Forms.RadioButton();
            this.radioButton_band1 = new System.Windows.Forms.RadioButton();
            this.btFreq = new System.Windows.Forms.Button();
            this.ComboBox_dmaxfre = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ComboBox_dminfre = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.gpb_beep = new System.Windows.Forms.GroupBox();
            this.Radio_beepDis = new System.Windows.Forms.RadioButton();
            this.Radio_beepEn = new System.Windows.Forms.RadioButton();
            this.Button_Beep = new System.Windows.Forms.Button();
            this.gpb_RDVersion = new System.Windows.Forms.GroupBox();
            this.text_RDVersion = new System.Windows.Forms.TextBox();
            this.gpb_Serial = new System.Windows.Forms.GroupBox();
            this.text_Serial = new System.Windows.Forms.TextBox();
            this.btSerial = new System.Windows.Forms.Button();
            this.gpb_address = new System.Windows.Forms.GroupBox();
            this.text_address = new System.Windows.Forms.TextBox();
            this.btaddress = new System.Windows.Forms.Button();
            this.gpb_tcp = new System.Windows.Forms.GroupBox();
            this.tb_Port = new System.Windows.Forms.TextBox();
            this.ipServerIP = new CustomControl.IpAddressTextBox();
            this.btDisConnectTcp = new System.Windows.Forms.Button();
            this.btConnectTcp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gpb_rs232 = new System.Windows.Forms.GroupBox();
            this.btDisConnect232 = new System.Windows.Forms.Button();
            this.btConnect232 = new System.Windows.Forms.Button();
            this.ComboBox_baud2 = new System.Windows.Forms.ComboBox();
            this.label47 = new System.Windows.Forms.Label();
            this.ComboBox_COM = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_tcp = new System.Windows.Forms.RadioButton();
            this.rb_rs232 = new System.Windows.Forms.RadioButton();
            this.tabPage_Module = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btMSetParameter = new System.Windows.Forms.Button();
            this.btMGetParameter = new System.Windows.Forms.Button();
            this.groupBox39 = new System.Windows.Forms.GroupBox();
            this.btSetMmode = new System.Windows.Forms.Button();
            this.com_Mmode = new System.Windows.Forms.ComboBox();
            this.label111 = new System.Windows.Forms.Label();
            this.groupBox38 = new System.Windows.Forms.GroupBox();
            this.checkBox_tid = new System.Windows.Forms.CheckBox();
            this.txt_Mtidlen = new System.Windows.Forms.TextBox();
            this.label103 = new System.Windows.Forms.Label();
            this.txt_mtidaddr = new System.Windows.Forms.TextBox();
            this.label104 = new System.Windows.Forms.Label();
            this.groupBox34 = new System.Windows.Forms.GroupBox();
            this.checkBox_mask = new System.Windows.Forms.CheckBox();
            this.txt_Mdata = new System.Windows.Forms.TextBox();
            this.label100 = new System.Windows.Forms.Label();
            this.txt_Mlen = new System.Windows.Forms.TextBox();
            this.label101 = new System.Windows.Forms.Label();
            this.txt_Maddr = new System.Windows.Forms.TextBox();
            this.label102 = new System.Windows.Forms.Label();
            this.RBM_USER = new System.Windows.Forms.RadioButton();
            this.RBM_TID = new System.Windows.Forms.RadioButton();
            this.RBM_EPC = new System.Windows.Forms.RadioButton();
            this.groupBox33 = new System.Windows.Forms.GroupBox();
            this.com_MS = new System.Windows.Forms.ComboBox();
            this.label99 = new System.Windows.Forms.Label();
            this.com_MQ = new System.Windows.Forms.ComboBox();
            this.label98 = new System.Windows.Forms.Label();
            this.groupBox32 = new System.Windows.Forms.GroupBox();
            this.com_MFliterTime = new System.Windows.Forms.ComboBox();
            this.label97 = new System.Windows.Forms.Label();
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            this.COM_MRPTime = new System.Windows.Forms.ComboBox();
            this.label96 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MRB_6B = new System.Windows.Forms.RadioButton();
            this.MRB_G2 = new System.Windows.Forms.RadioButton();
            this.Main_Page2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage_answer = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lxLedControl6 = new LxControl.LxLedControl();
            this.label119 = new System.Windows.Forms.Label();
            this.gbp_MixRead = new System.Windows.Forms.GroupBox();
            this.text_readpsd = new System.Windows.Forms.TextBox();
            this.label118 = new System.Windows.Forms.Label();
            this.text_readLen = new System.Windows.Forms.TextBox();
            this.label117 = new System.Windows.Forms.Label();
            this.text_readadr = new System.Windows.Forms.TextBox();
            this.label115 = new System.Windows.Forms.Label();
            this.com_MixMem = new System.Windows.Forms.ComboBox();
            this.label114 = new System.Windows.Forms.Label();
            this.lxLedControl5 = new LxControl.LxLedControl();
            this.label9 = new System.Windows.Forms.Label();
            this.lxLedControl4 = new LxControl.LxLedControl();
            this.label8 = new System.Windows.Forms.Label();
            this.lxLedControl3 = new LxControl.LxLedControl();
            this.label7 = new System.Windows.Forms.Label();
            this.lxLedControl2 = new LxControl.LxLedControl();
            this.label6 = new System.Windows.Forms.Label();
            this.lxLedControl1 = new LxControl.LxLedControl();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox_rate = new System.Windows.Forms.CheckBox();
            this.label80 = new System.Windows.Forms.Label();
            this.text_target = new System.Windows.Forms.TextBox();
            this.check_num = new System.Windows.Forms.CheckBox();
            this.com_Target = new System.Windows.Forms.ComboBox();
            this.label79 = new System.Windows.Forms.Label();
            this.com_scantime = new System.Windows.Forms.ComboBox();
            this.label39 = new System.Windows.Forms.Label();
            this.com_S = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.com_Q = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.group_ant1 = new System.Windows.Forms.GroupBox();
            this.check_ant4 = new System.Windows.Forms.CheckBox();
            this.check_ant3 = new System.Windows.Forms.CheckBox();
            this.check_ant2 = new System.Windows.Forms.CheckBox();
            this.check_ant1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_fastid = new System.Windows.Forms.RadioButton();
            this.rb_mix = new System.Windows.Forms.RadioButton();
            this.rb_tid = new System.Windows.Forms.RadioButton();
            this.rb_epc = new System.Windows.Forms.RadioButton();
            this.btIventoryG2 = new System.Windows.Forms.Button();
            this.tabPage_Realtime = new System.Windows.Forms.TabPage();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox41 = new System.Windows.Forms.GroupBox();
            this.lxLed_Mtime = new LxControl.LxLedControl();
            this.label113 = new System.Windows.Forms.Label();
            this.lxLed_Mtag = new LxControl.LxLedControl();
            this.label116 = new System.Windows.Forms.Label();
            this.groupBox42 = new System.Windows.Forms.GroupBox();
            this.btStartMactive = new System.Windows.Forms.Button();
            this.tabPage_Buff = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.groupBox27 = new System.Windows.Forms.GroupBox();
            this.btQueryBuffNum = new System.Windows.Forms.Button();
            this.btRandCbuff = new System.Windows.Forms.Button();
            this.btClearBuff = new System.Windows.Forms.Button();
            this.btReadBuff = new System.Windows.Forms.Button();
            this.groupBox29 = new System.Windows.Forms.GroupBox();
            this.rb_btid = new System.Windows.Forms.RadioButton();
            this.rb_bepc = new System.Windows.Forms.RadioButton();
            this.btStartBuff = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox30 = new System.Windows.Forms.GroupBox();
            this.lxLed_cmdTime = new LxControl.LxLedControl();
            this.label86 = new System.Windows.Forms.Label();
            this.lxLed_Btoltime = new LxControl.LxLedControl();
            this.label83 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.lxLed_Btoltag = new LxControl.LxLedControl();
            this.label92 = new System.Windows.Forms.Label();
            this.lxLed_Bcmdsud = new LxControl.LxLedControl();
            this.label94 = new System.Windows.Forms.Label();
            this.lxLed_BNum = new LxControl.LxLedControl();
            this.label95 = new System.Windows.Forms.Label();
            this.tabPage_RW = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.btCheckReadProtected_G2 = new System.Windows.Forms.Button();
            this.btRemoveReadProtect_G2 = new System.Windows.Forms.Button();
            this.btSetMultiReadProtect_G2 = new System.Windows.Forms.Button();
            this.btSetReadProtect_G2 = new System.Windows.Forms.Button();
            this.text_AccessCode4 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.btWriteEPC_G2 = new System.Windows.Forms.Button();
            this.text_AccessCode3 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.text_WriteEPC = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.btDestroyCard = new System.Windows.Forms.Button();
            this.text_DestroyCode = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btCheckEASAlarm = new System.Windows.Forms.Button();
            this.btSetEASAlarm_G2 = new System.Windows.Forms.Button();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.NoAlarm_G2 = new System.Windows.Forms.RadioButton();
            this.Alarm_G2 = new System.Windows.Forms.RadioButton();
            this.text_AccessCode5 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.btSetProtectState = new System.Windows.Forms.Button();
            this.Edit_AccessCode6 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.AlwaysNot2 = new System.Windows.Forms.RadioButton();
            this.Always2 = new System.Windows.Forms.RadioButton();
            this.Proect2 = new System.Windows.Forms.RadioButton();
            this.NoProect2 = new System.Windows.Forms.RadioButton();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.p_pass = new System.Windows.Forms.RadioButton();
            this.P_User = new System.Windows.Forms.RadioButton();
            this.P_TID = new System.Windows.Forms.RadioButton();
            this.P_EPC = new System.Windows.Forms.RadioButton();
            this.P_kill = new System.Windows.Forms.RadioButton();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.btExtWrite = new System.Windows.Forms.Button();
            this.btExtRead = new System.Windows.Forms.Button();
            this.textBox_pc = new System.Windows.Forms.TextBox();
            this.checkBox_pc = new System.Windows.Forms.CheckBox();
            this.btBlockWrite = new System.Windows.Forms.Button();
            this.btBlockErase = new System.Windows.Forms.Button();
            this.btWrite = new System.Windows.Forms.Button();
            this.btRead = new System.Windows.Forms.Button();
            this.text_WriteData = new System.Windows.Forms.TextBox();
            this.text_AccessCode2 = new System.Windows.Forms.TextBox();
            this.text_RWlen = new System.Windows.Forms.TextBox();
            this.text_WordPtr = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.C_User = new System.Windows.Forms.RadioButton();
            this.C_TID = new System.Windows.Forms.RadioButton();
            this.C_EPC = new System.Windows.Forms.RadioButton();
            this.C_Reserve = new System.Windows.Forms.RadioButton();
            this.groupBox31 = new System.Windows.Forms.GroupBox();
            this.maskData_textBox = new System.Windows.Forms.TextBox();
            this.label60 = new System.Windows.Forms.Label();
            this.groupBox40 = new System.Windows.Forms.GroupBox();
            this.R_User = new System.Windows.Forms.RadioButton();
            this.R_TID = new System.Windows.Forms.RadioButton();
            this.R_EPC = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.maskLen_textBox = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.maskadr_textbox = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btSelectTag = new System.Windows.Forms.Button();
            this.comboBox_EPC = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.text_epc = new System.Windows.Forms.TextBox();
            this.check_selecttag = new System.Windows.Forms.CheckBox();
            this.Main_Page3 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.text_Statu6B = new System.Windows.Forms.TextBox();
            this.btCheckLock6B = new System.Windows.Forms.Button();
            this.btLock6B = new System.Windows.Forms.Button();
            this.text_checkaddr = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.text_lock6b = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.text_W6B = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.btWrite6B = new System.Windows.Forms.Button();
            this.text_W6BLen = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.text_W6BAddr = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.text_R6B = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.btRead6B = new System.Windows.Forms.Button();
            this.text_R6BLen = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.text_R6BAddr = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.text_6BUID = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.ListView_ID_6B = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.rb_mutiple = new System.Windows.Forms.RadioButton();
            this.rb_single = new System.Windows.Forms.RadioButton();
            this.btInventory6B = new System.Windows.Forms.Button();
            this.Main_Page4 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.DeviceListView = new System.Windows.Forms.ListView();
            this.deviceName = new System.Windows.Forms.ColumnHeader();
            this.deviceIP = new System.Windows.Forms.ColumnHeader();
            this.deviceMac = new System.Windows.Forms.ColumnHeader();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.iEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telnetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.label63 = new System.Windows.Forms.Label();
            this.stcprecv = new CustomControl.LogRichTextBox();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.listtcp = new System.Windows.Forms.ListBox();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.btStop = new System.Windows.Forms.Button();
            this.btListen = new System.Windows.Forms.Button();
            this.stcpport = new System.Windows.Forms.TextBox();
            this.label62 = new System.Windows.Forms.Label();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.groupBox26 = new System.Windows.Forms.GroupBox();
            this.bttcpdisconnect = new System.Windows.Forms.Button();
            this.bttcpconnect = new System.Windows.Forms.Button();
            this.remotePort = new System.Windows.Forms.TextBox();
            this.label71 = new System.Windows.Forms.Label();
            this.tcpremoteIp = new CustomControl.IpAddressTextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.bttcpsend = new System.Windows.Forms.Button();
            this.label69 = new System.Windows.Forms.Label();
            this.ctctsend = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.ctctrecv = new CustomControl.LogRichTextBox();
            this.btFlashCl = new System.Windows.Forms.Button();
            this.timer_answer = new System.Windows.Forms.Timer(this.components);
            this.timer_runmode = new System.Windows.Forms.Timer(this.components);
            this.timer_EAS = new System.Windows.Forms.Timer(this.components);
            this.Timer_Test_6B = new System.Windows.Forms.Timer(this.components);
            this.timer_Buff = new System.Windows.Forms.Timer(this.components);
            this.timer_RealTime = new System.Windows.Forms.Timer(this.components);
            this.ckClearOperationRec = new System.Windows.Forms.CheckBox();
            this.radioButton_band12 = new System.Windows.Forms.RadioButton();
            this.Maintab.SuspendLayout();
            this.Main_Page1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_Basic.SuspendLayout();
            this.gbReturnLoss.SuspendLayout();
            this.gbCmdTemperature.SuspendLayout();
            this.gbp_DRM.SuspendLayout();
            this.gbp_Retry.SuspendLayout();
            this.gbp_wpower.SuspendLayout();
            this.group_maxtime.SuspendLayout();
            this.gbp_buff.SuspendLayout();
            this.gpb_antconfig.SuspendLayout();
            this.gpb_checkant.SuspendLayout();
            this.gpb_GPIO.SuspendLayout();
            this.gpb_OutputRep.SuspendLayout();
            this.gpb_Relay.SuspendLayout();
            this.gpb_baud.SuspendLayout();
            this.gpb_DBM.SuspendLayout();
            this.gpb_Freq.SuspendLayout();
            this.gpb_beep.SuspendLayout();
            this.gpb_RDVersion.SuspendLayout();
            this.gpb_Serial.SuspendLayout();
            this.gpb_address.SuspendLayout();
            this.gpb_tcp.SuspendLayout();
            this.gpb_rs232.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage_Module.SuspendLayout();
            this.panel9.SuspendLayout();
            this.groupBox39.SuspendLayout();
            this.groupBox38.SuspendLayout();
            this.groupBox34.SuspendLayout();
            this.groupBox33.SuspendLayout();
            this.groupBox32.SuspendLayout();
            this.groupBox28.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Main_Page2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage_answer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl6)).BeginInit();
            this.gbp_MixRead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.group_ant1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage_Realtime.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.groupBox41.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_Mtime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_Mtag)).BeginInit();
            this.groupBox42.SuspendLayout();
            this.tabPage_Buff.SuspendLayout();
            this.panel8.SuspendLayout();
            this.groupBox27.SuspendLayout();
            this.groupBox29.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox30.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_cmdTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_Btoltime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_Btoltag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_Bcmdsud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_BNum)).BeginInit();
            this.tabPage_RW.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox17.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox31.SuspendLayout();
            this.groupBox40.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.Main_Page3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.Main_Page4.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.groupBox25.SuspendLayout();
            this.groupBox24.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.groupBox26.SuspendLayout();
            this.SuspendLayout();
            // 
            // lrtxtLog
            // 
            this.lrtxtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lrtxtLog.EnableAutoDragDrop = true;
            this.lrtxtLog.Location = new System.Drawing.Point(-1, 632);
            this.lrtxtLog.Name = "lrtxtLog";
            this.lrtxtLog.Size = new System.Drawing.Size(1080, 89);
            this.lrtxtLog.TabIndex = 0;
            this.lrtxtLog.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 608);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Operation records:";
            // 
            // Maintab
            // 
            this.Maintab.Controls.Add(this.Main_Page1);
            this.Maintab.Controls.Add(this.Main_Page2);
            this.Maintab.Controls.Add(this.Main_Page3);
            this.Maintab.Controls.Add(this.Main_Page4);
            this.Maintab.Dock = System.Windows.Forms.DockStyle.Top;
            this.Maintab.ItemSize = new System.Drawing.Size(72, 23);
            this.Maintab.Location = new System.Drawing.Point(0, 0);
            this.Maintab.Multiline = true;
            this.Maintab.Name = "Maintab";
            this.Maintab.SelectedIndex = 0;
            this.Maintab.Size = new System.Drawing.Size(1079, 602);
            this.Maintab.TabIndex = 3;
            this.Maintab.SelectedIndexChanged += new System.EventHandler(this.Maintab_SelectedIndexChanged);
            // 
            // Main_Page1
            // 
            this.Main_Page1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Main_Page1.Controls.Add(this.tabControl1);
            this.Main_Page1.Location = new System.Drawing.Point(4, 27);
            this.Main_Page1.Name = "Main_Page1";
            this.Main_Page1.Padding = new System.Windows.Forms.Padding(3);
            this.Main_Page1.Size = new System.Drawing.Size(1071, 571);
            this.Main_Page1.TabIndex = 0;
            this.Main_Page1.Text = "   Command  ";
            this.Main_Page1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Basic);
            this.tabControl1.Controls.Add(this.tabPage_Module);
            this.tabControl1.HotTrack = true;
            this.tabControl1.ItemSize = new System.Drawing.Size(84, 23);
            this.tabControl1.Location = new System.Drawing.Point(1, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1065, 568);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.Maintab_SelectedIndexChanged);
            // 
            // tabPage_Basic
            // 
            this.tabPage_Basic.Controls.Add(this.gbReturnLoss);
            this.tabPage_Basic.Controls.Add(this.gbCmdTemperature);
            this.tabPage_Basic.Controls.Add(this.gbp_DRM);
            this.tabPage_Basic.Controls.Add(this.gbp_Retry);
            this.tabPage_Basic.Controls.Add(this.gbp_wpower);
            this.tabPage_Basic.Controls.Add(this.group_maxtime);
            this.tabPage_Basic.Controls.Add(this.gbp_buff);
            this.tabPage_Basic.Controls.Add(this.btGetInformation);
            this.tabPage_Basic.Controls.Add(this.btDefault);
            this.tabPage_Basic.Controls.Add(this.gpb_antconfig);
            this.tabPage_Basic.Controls.Add(this.gpb_checkant);
            this.tabPage_Basic.Controls.Add(this.gpb_GPIO);
            this.tabPage_Basic.Controls.Add(this.gpb_OutputRep);
            this.tabPage_Basic.Controls.Add(this.gpb_Relay);
            this.tabPage_Basic.Controls.Add(this.gpb_baud);
            this.tabPage_Basic.Controls.Add(this.gpb_DBM);
            this.tabPage_Basic.Controls.Add(this.gpb_Freq);
            this.tabPage_Basic.Controls.Add(this.gpb_beep);
            this.tabPage_Basic.Controls.Add(this.gpb_RDVersion);
            this.tabPage_Basic.Controls.Add(this.gpb_Serial);
            this.tabPage_Basic.Controls.Add(this.gpb_address);
            this.tabPage_Basic.Controls.Add(this.gpb_tcp);
            this.tabPage_Basic.Controls.Add(this.gpb_rs232);
            this.tabPage_Basic.Controls.Add(this.groupBox1);
            this.tabPage_Basic.Location = new System.Drawing.Point(4, 27);
            this.tabPage_Basic.Name = "tabPage_Basic";
            this.tabPage_Basic.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Basic.Size = new System.Drawing.Size(1057, 537);
            this.tabPage_Basic.TabIndex = 0;
            this.tabPage_Basic.Text = "  Basic  ";
            this.tabPage_Basic.UseVisualStyleBackColor = true;
            // 
            // gbReturnLoss
            // 
            this.gbReturnLoss.BackColor = System.Drawing.Color.Transparent;
            this.gbReturnLoss.Controls.Add(this.cbbAnt);
            this.gbReturnLoss.Controls.Add(this.label120);
            this.gbReturnLoss.Controls.Add(this.label121);
            this.gbReturnLoss.Controls.Add(this.cmbReturnLossFreq);
            this.gbReturnLoss.Controls.Add(this.label122);
            this.gbReturnLoss.Controls.Add(this.textReturnLoss);
            this.gbReturnLoss.Controls.Add(this.btReturnLoss);
            this.gbReturnLoss.ForeColor = System.Drawing.Color.Black;
            this.gbReturnLoss.Location = new System.Drawing.Point(704, 337);
            this.gbReturnLoss.Name = "gbReturnLoss";
            this.gbReturnLoss.Size = new System.Drawing.Size(341, 46);
            this.gbReturnLoss.TabIndex = 77;
            this.gbReturnLoss.TabStop = false;
            this.gbReturnLoss.Text = "Measuring antenna ports Return Loss";
            // 
            // cbbAnt
            // 
            this.cbbAnt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAnt.FormattingEnabled = true;
            this.cbbAnt.Items.AddRange(new object[] {
            "Ant1",
            "Ant2",
            "Ant3",
            "Ant4"});
            this.cbbAnt.Location = new System.Drawing.Point(198, 18);
            this.cbbAnt.Name = "cbbAnt";
            this.cbbAnt.Size = new System.Drawing.Size(70, 20);
            this.cbbAnt.TabIndex = 16;
            // 
            // label120
            // 
            this.label120.AutoSize = true;
            this.label120.Location = new System.Drawing.Point(86, 22);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(11, 12);
            this.label120.TabIndex = 15;
            this.label120.Text = "@";
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.Location = new System.Drawing.Point(170, 22);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(23, 12);
            this.label121.TabIndex = 14;
            this.label121.Text = "MHz";
            // 
            // cmbReturnLossFreq
            // 
            this.cmbReturnLossFreq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReturnLossFreq.FormattingEnabled = true;
            this.cmbReturnLossFreq.Location = new System.Drawing.Point(97, 18);
            this.cmbReturnLossFreq.Name = "cmbReturnLossFreq";
            this.cmbReturnLossFreq.Size = new System.Drawing.Size(71, 20);
            this.cmbReturnLossFreq.TabIndex = 13;
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.Location = new System.Drawing.Point(11, 22);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(23, 12);
            this.label122.TabIndex = 12;
            this.label122.Text = "RL:";
            // 
            // textReturnLoss
            // 
            this.textReturnLoss.Location = new System.Drawing.Point(40, 18);
            this.textReturnLoss.Name = "textReturnLoss";
            this.textReturnLoss.ReadOnly = true;
            this.textReturnLoss.Size = new System.Drawing.Size(44, 21);
            this.textReturnLoss.TabIndex = 11;
            this.textReturnLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btReturnLoss
            // 
            this.btReturnLoss.Location = new System.Drawing.Point(276, 15);
            this.btReturnLoss.Name = "btReturnLoss";
            this.btReturnLoss.Size = new System.Drawing.Size(55, 23);
            this.btReturnLoss.TabIndex = 10;
            this.btReturnLoss.Text = "Get";
            this.btReturnLoss.UseVisualStyleBackColor = true;
            this.btReturnLoss.Click += new System.EventHandler(this.btReturnLoss_Click);
            // 
            // gbCmdTemperature
            // 
            this.gbCmdTemperature.Controls.Add(this.btnGetReaderTemperature);
            this.gbCmdTemperature.Controls.Add(this.txtReaderTemperature);
            this.gbCmdTemperature.ForeColor = System.Drawing.Color.Black;
            this.gbCmdTemperature.Location = new System.Drawing.Point(702, 279);
            this.gbCmdTemperature.Name = "gbCmdTemperature";
            this.gbCmdTemperature.Size = new System.Drawing.Size(342, 49);
            this.gbCmdTemperature.TabIndex = 76;
            this.gbCmdTemperature.TabStop = false;
            this.gbCmdTemperature.Text = "Working temperature monitoring";
            // 
            // btnGetReaderTemperature
            // 
            this.btnGetReaderTemperature.Location = new System.Drawing.Point(233, 18);
            this.btnGetReaderTemperature.Name = "btnGetReaderTemperature";
            this.btnGetReaderTemperature.Size = new System.Drawing.Size(90, 23);
            this.btnGetReaderTemperature.TabIndex = 0;
            this.btnGetReaderTemperature.Text = "Get";
            this.btnGetReaderTemperature.UseVisualStyleBackColor = true;
            this.btnGetReaderTemperature.Click += new System.EventHandler(this.btnGetReaderTemperature_Click);
            // 
            // txtReaderTemperature
            // 
            this.txtReaderTemperature.Location = new System.Drawing.Point(6, 20);
            this.txtReaderTemperature.Name = "txtReaderTemperature";
            this.txtReaderTemperature.ReadOnly = true;
            this.txtReaderTemperature.Size = new System.Drawing.Size(120, 21);
            this.txtReaderTemperature.TabIndex = 1;
            this.txtReaderTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbp_DRM
            // 
            this.gbp_DRM.Controls.Add(this.DRM_CLOSE);
            this.gbp_DRM.Controls.Add(this.DRM_OPEN);
            this.gbp_DRM.Controls.Add(this.bt_GetDRM);
            this.gbp_DRM.Controls.Add(this.bt_setDRM);
            this.gbp_DRM.Location = new System.Drawing.Point(355, 431);
            this.gbp_DRM.Name = "gbp_DRM";
            this.gbp_DRM.Size = new System.Drawing.Size(343, 48);
            this.gbp_DRM.TabIndex = 75;
            this.gbp_DRM.TabStop = false;
            this.gbp_DRM.Text = "DRM status";
            // 
            // DRM_CLOSE
            // 
            this.DRM_CLOSE.AutoSize = true;
            this.DRM_CLOSE.Location = new System.Drawing.Point(103, 20);
            this.DRM_CLOSE.Name = "DRM_CLOSE";
            this.DRM_CLOSE.Size = new System.Drawing.Size(53, 16);
            this.DRM_CLOSE.TabIndex = 12;
            this.DRM_CLOSE.Text = "Close";
            this.DRM_CLOSE.UseVisualStyleBackColor = true;
            // 
            // DRM_OPEN
            // 
            this.DRM_OPEN.AutoSize = true;
            this.DRM_OPEN.Location = new System.Drawing.Point(13, 20);
            this.DRM_OPEN.Name = "DRM_OPEN";
            this.DRM_OPEN.Size = new System.Drawing.Size(47, 16);
            this.DRM_OPEN.TabIndex = 11;
            this.DRM_OPEN.Text = "Open";
            this.DRM_OPEN.UseVisualStyleBackColor = true;
            // 
            // bt_GetDRM
            // 
            this.bt_GetDRM.Location = new System.Drawing.Point(247, 17);
            this.bt_GetDRM.Name = "bt_GetDRM";
            this.bt_GetDRM.Size = new System.Drawing.Size(77, 23);
            this.bt_GetDRM.TabIndex = 9;
            this.bt_GetDRM.Text = "Get";
            this.bt_GetDRM.UseVisualStyleBackColor = true;
            this.bt_GetDRM.Click += new System.EventHandler(this.bt_GetDRM_Click);
            // 
            // bt_setDRM
            // 
            this.bt_setDRM.Location = new System.Drawing.Point(158, 17);
            this.bt_setDRM.Name = "bt_setDRM";
            this.bt_setDRM.Size = new System.Drawing.Size(77, 23);
            this.bt_setDRM.TabIndex = 8;
            this.bt_setDRM.Text = "Set";
            this.bt_setDRM.UseVisualStyleBackColor = true;
            this.bt_setDRM.Click += new System.EventHandler(this.bt_setDRM_Click);
            // 
            // gbp_Retry
            // 
            this.gbp_Retry.Controls.Add(this.com_retrytimes);
            this.gbp_Retry.Controls.Add(this.bt_Getretry);
            this.gbp_Retry.Controls.Add(this.bt_Setretry);
            this.gbp_Retry.Location = new System.Drawing.Point(354, 378);
            this.gbp_Retry.Name = "gbp_Retry";
            this.gbp_Retry.Size = new System.Drawing.Size(343, 48);
            this.gbp_Retry.TabIndex = 74;
            this.gbp_Retry.TabStop = false;
            this.gbp_Retry.Text = "Retry write times set and get";
            // 
            // com_retrytimes
            // 
            this.com_retrytimes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_retrytimes.FormattingEnabled = true;
            this.com_retrytimes.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.com_retrytimes.Location = new System.Drawing.Point(14, 19);
            this.com_retrytimes.Name = "com_retrytimes";
            this.com_retrytimes.Size = new System.Drawing.Size(100, 20);
            this.com_retrytimes.TabIndex = 26;
            // 
            // bt_Getretry
            // 
            this.bt_Getretry.Location = new System.Drawing.Point(247, 17);
            this.bt_Getretry.Name = "bt_Getretry";
            this.bt_Getretry.Size = new System.Drawing.Size(77, 23);
            this.bt_Getretry.TabIndex = 9;
            this.bt_Getretry.Text = "Get";
            this.bt_Getretry.UseVisualStyleBackColor = true;
            this.bt_Getretry.Click += new System.EventHandler(this.bt_Getretry_Click);
            // 
            // bt_Setretry
            // 
            this.bt_Setretry.Location = new System.Drawing.Point(158, 17);
            this.bt_Setretry.Name = "bt_Setretry";
            this.bt_Setretry.Size = new System.Drawing.Size(77, 23);
            this.bt_Setretry.TabIndex = 8;
            this.bt_Setretry.Text = "Set";
            this.bt_Setretry.UseVisualStyleBackColor = true;
            this.bt_Setretry.Click += new System.EventHandler(this.bt_Setretry_Click);
            // 
            // gbp_wpower
            // 
            this.gbp_wpower.Controls.Add(this.label112);
            this.gbp_wpower.Controls.Add(this.com_wpower);
            this.gbp_wpower.Controls.Add(this.rb_wp2);
            this.gbp_wpower.Controls.Add(this.rb_wp1);
            this.gbp_wpower.Controls.Add(this.bt_GetWpower);
            this.gbp_wpower.Controls.Add(this.bt_SetWpower);
            this.gbp_wpower.Location = new System.Drawing.Point(6, 392);
            this.gbp_wpower.Name = "gbp_wpower";
            this.gbp_wpower.Size = new System.Drawing.Size(343, 68);
            this.gbp_wpower.TabIndex = 73;
            this.gbp_wpower.TabStop = false;
            this.gbp_wpower.Text = "Write Power Set and get";
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Location = new System.Drawing.Point(120, 44);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(23, 12);
            this.label112.TabIndex = 27;
            this.label112.Text = "dBm";
            // 
            // com_wpower
            // 
            this.com_wpower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_wpower.FormattingEnabled = true;
            this.com_wpower.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.com_wpower.Location = new System.Drawing.Point(14, 41);
            this.com_wpower.Name = "com_wpower";
            this.com_wpower.Size = new System.Drawing.Size(100, 20);
            this.com_wpower.TabIndex = 26;
            // 
            // rb_wp2
            // 
            this.rb_wp2.AutoSize = true;
            this.rb_wp2.Location = new System.Drawing.Point(157, 18);
            this.rb_wp2.Name = "rb_wp2";
            this.rb_wp2.Size = new System.Drawing.Size(59, 16);
            this.rb_wp2.TabIndex = 11;
            this.rb_wp2.Text = "Enable";
            this.rb_wp2.UseVisualStyleBackColor = true;
            // 
            // rb_wp1
            // 
            this.rb_wp1.AutoSize = true;
            this.rb_wp1.Checked = true;
            this.rb_wp1.Location = new System.Drawing.Point(15, 18);
            this.rb_wp1.Name = "rb_wp1";
            this.rb_wp1.Size = new System.Drawing.Size(65, 16);
            this.rb_wp1.TabIndex = 10;
            this.rb_wp1.TabStop = true;
            this.rb_wp1.Text = "Disable";
            this.rb_wp1.UseVisualStyleBackColor = true;
            // 
            // bt_GetWpower
            // 
            this.bt_GetWpower.Location = new System.Drawing.Point(247, 39);
            this.bt_GetWpower.Name = "bt_GetWpower";
            this.bt_GetWpower.Size = new System.Drawing.Size(77, 23);
            this.bt_GetWpower.TabIndex = 9;
            this.bt_GetWpower.Text = "Get";
            this.bt_GetWpower.UseVisualStyleBackColor = true;
            this.bt_GetWpower.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_SetWpower
            // 
            this.bt_SetWpower.Location = new System.Drawing.Point(158, 39);
            this.bt_SetWpower.Name = "bt_SetWpower";
            this.bt_SetWpower.Size = new System.Drawing.Size(77, 23);
            this.bt_SetWpower.TabIndex = 8;
            this.bt_SetWpower.Text = "Set";
            this.bt_SetWpower.UseVisualStyleBackColor = true;
            this.bt_SetWpower.Click += new System.EventHandler(this.button2_Click);
            // 
            // group_maxtime
            // 
            this.group_maxtime.Controls.Add(this.comboBox_maxtime);
            this.group_maxtime.Controls.Add(this.btSetMaxtime);
            this.group_maxtime.Location = new System.Drawing.Point(6, 290);
            this.group_maxtime.Name = "group_maxtime";
            this.group_maxtime.Size = new System.Drawing.Size(342, 41);
            this.group_maxtime.TabIndex = 72;
            this.group_maxtime.TabStop = false;
            this.group_maxtime.Text = "Max inventory time";
            // 
            // comboBox_maxtime
            // 
            this.comboBox_maxtime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_maxtime.FormattingEnabled = true;
            this.comboBox_maxtime.Location = new System.Drawing.Point(94, 15);
            this.comboBox_maxtime.Name = "comboBox_maxtime";
            this.comboBox_maxtime.Size = new System.Drawing.Size(122, 20);
            this.comboBox_maxtime.TabIndex = 26;
            // 
            // btSetMaxtime
            // 
            this.btSetMaxtime.Location = new System.Drawing.Point(233, 14);
            this.btSetMaxtime.Name = "btSetMaxtime";
            this.btSetMaxtime.Size = new System.Drawing.Size(90, 23);
            this.btSetMaxtime.TabIndex = 23;
            this.btSetMaxtime.Text = "Set";
            this.btSetMaxtime.UseVisualStyleBackColor = true;
            this.btSetMaxtime.Click += new System.EventHandler(this.btSetMaxtime_Click);
            // 
            // gbp_buff
            // 
            this.gbp_buff.Controls.Add(this.rb496);
            this.gbp_buff.Controls.Add(this.rb128);
            this.gbp_buff.Controls.Add(this.btGetEPCandTIDLen);
            this.gbp_buff.Controls.Add(this.btSetEPCandTIDLen);
            this.gbp_buff.Location = new System.Drawing.Point(5, 335);
            this.gbp_buff.Name = "gbp_buff";
            this.gbp_buff.Size = new System.Drawing.Size(343, 55);
            this.gbp_buff.TabIndex = 71;
            this.gbp_buff.TabStop = false;
            this.gbp_buff.Text = "Saved EPC/TID length";
            // 
            // rb496
            // 
            this.rb496.AutoSize = true;
            this.rb496.Location = new System.Drawing.Point(93, 25);
            this.rb496.Name = "rb496";
            this.rb496.Size = new System.Drawing.Size(59, 16);
            this.rb496.TabIndex = 11;
            this.rb496.Text = "496bit";
            this.rb496.UseVisualStyleBackColor = true;
            // 
            // rb128
            // 
            this.rb128.AutoSize = true;
            this.rb128.Checked = true;
            this.rb128.Location = new System.Drawing.Point(15, 25);
            this.rb128.Name = "rb128";
            this.rb128.Size = new System.Drawing.Size(59, 16);
            this.rb128.TabIndex = 10;
            this.rb128.TabStop = true;
            this.rb128.Text = "128bit";
            this.rb128.UseVisualStyleBackColor = true;
            // 
            // btGetEPCandTIDLen
            // 
            this.btGetEPCandTIDLen.Location = new System.Drawing.Point(247, 22);
            this.btGetEPCandTIDLen.Name = "btGetEPCandTIDLen";
            this.btGetEPCandTIDLen.Size = new System.Drawing.Size(77, 23);
            this.btGetEPCandTIDLen.TabIndex = 9;
            this.btGetEPCandTIDLen.Text = "Get";
            this.btGetEPCandTIDLen.UseVisualStyleBackColor = true;
            this.btGetEPCandTIDLen.Click += new System.EventHandler(this.btGetEPCandTIDLen_Click);
            // 
            // btSetEPCandTIDLen
            // 
            this.btSetEPCandTIDLen.Location = new System.Drawing.Point(158, 22);
            this.btSetEPCandTIDLen.Name = "btSetEPCandTIDLen";
            this.btSetEPCandTIDLen.Size = new System.Drawing.Size(77, 23);
            this.btSetEPCandTIDLen.TabIndex = 8;
            this.btSetEPCandTIDLen.Text = "Set";
            this.btSetEPCandTIDLen.UseVisualStyleBackColor = true;
            this.btSetEPCandTIDLen.Click += new System.EventHandler(this.btSetEPCandTIDLen_Click);
            // 
            // btGetInformation
            // 
            this.btGetInformation.Location = new System.Drawing.Point(704, 389);
            this.btGetInformation.Name = "btGetInformation";
            this.btGetInformation.Size = new System.Drawing.Size(169, 43);
            this.btGetInformation.TabIndex = 58;
            this.btGetInformation.Text = "Get reader information";
            this.btGetInformation.UseVisualStyleBackColor = true;
            this.btGetInformation.Click += new System.EventHandler(this.btGetInformation_Click);
            // 
            // btDefault
            // 
            this.btDefault.Location = new System.Drawing.Point(883, 389);
            this.btDefault.Name = "btDefault";
            this.btDefault.Size = new System.Drawing.Size(169, 43);
            this.btDefault.TabIndex = 57;
            this.btDefault.Text = "Default setting";
            this.btDefault.UseVisualStyleBackColor = true;
            this.btDefault.Click += new System.EventHandler(this.btDefault_Click);
            // 
            // gpb_antconfig
            // 
            this.gpb_antconfig.Controls.Add(this.Button_Ant);
            this.gpb_antconfig.Controls.Add(this.checkant4);
            this.gpb_antconfig.Controls.Add(this.checkant3);
            this.gpb_antconfig.Controls.Add(this.checkant2);
            this.gpb_antconfig.Controls.Add(this.checkant1);
            this.gpb_antconfig.Location = new System.Drawing.Point(354, 331);
            this.gpb_antconfig.Name = "gpb_antconfig";
            this.gpb_antconfig.Size = new System.Drawing.Size(342, 42);
            this.gpb_antconfig.TabIndex = 54;
            this.gpb_antconfig.TabStop = false;
            this.gpb_antconfig.Text = "Antenna config";
            // 
            // Button_Ant
            // 
            this.Button_Ant.Location = new System.Drawing.Point(233, 12);
            this.Button_Ant.Name = "Button_Ant";
            this.Button_Ant.Size = new System.Drawing.Size(90, 23);
            this.Button_Ant.TabIndex = 5;
            this.Button_Ant.Text = "Set";
            this.Button_Ant.UseVisualStyleBackColor = true;
            this.Button_Ant.Click += new System.EventHandler(this.Button_Ant_Click);
            // 
            // checkant4
            // 
            this.checkant4.AutoSize = true;
            this.checkant4.Location = new System.Drawing.Point(177, 15);
            this.checkant4.Name = "checkant4";
            this.checkant4.Size = new System.Drawing.Size(48, 16);
            this.checkant4.TabIndex = 4;
            this.checkant4.Text = "ANT4";
            this.checkant4.UseVisualStyleBackColor = true;
            // 
            // checkant3
            // 
            this.checkant3.AutoSize = true;
            this.checkant3.Location = new System.Drawing.Point(120, 15);
            this.checkant3.Name = "checkant3";
            this.checkant3.Size = new System.Drawing.Size(48, 16);
            this.checkant3.TabIndex = 3;
            this.checkant3.Text = "ANT3";
            this.checkant3.UseVisualStyleBackColor = true;
            // 
            // checkant2
            // 
            this.checkant2.AutoSize = true;
            this.checkant2.Location = new System.Drawing.Point(62, 15);
            this.checkant2.Name = "checkant2";
            this.checkant2.Size = new System.Drawing.Size(48, 16);
            this.checkant2.TabIndex = 2;
            this.checkant2.Text = "ANT2";
            this.checkant2.UseVisualStyleBackColor = true;
            // 
            // checkant1
            // 
            this.checkant1.AutoSize = true;
            this.checkant1.Location = new System.Drawing.Point(8, 15);
            this.checkant1.Name = "checkant1";
            this.checkant1.Size = new System.Drawing.Size(48, 16);
            this.checkant1.TabIndex = 1;
            this.checkant1.Text = "ANT1";
            this.checkant1.UseVisualStyleBackColor = true;
            // 
            // gpb_checkant
            // 
            this.gpb_checkant.Controls.Add(this.btSetcheckant);
            this.gpb_checkant.Controls.Add(this.rb_Closecheckant);
            this.gpb_checkant.Controls.Add(this.rb_Opencheckant);
            this.gpb_checkant.Location = new System.Drawing.Point(354, 278);
            this.gpb_checkant.Name = "gpb_checkant";
            this.gpb_checkant.Size = new System.Drawing.Size(342, 51);
            this.gpb_checkant.TabIndex = 53;
            this.gpb_checkant.TabStop = false;
            this.gpb_checkant.Text = "Antenna checked";
            // 
            // btSetcheckant
            // 
            this.btSetcheckant.Location = new System.Drawing.Point(233, 19);
            this.btSetcheckant.Name = "btSetcheckant";
            this.btSetcheckant.Size = new System.Drawing.Size(90, 23);
            this.btSetcheckant.TabIndex = 2;
            this.btSetcheckant.Text = "Set";
            this.btSetcheckant.UseVisualStyleBackColor = true;
            this.btSetcheckant.Click += new System.EventHandler(this.btSetcheckant_Click);
            // 
            // rb_Closecheckant
            // 
            this.rb_Closecheckant.AutoSize = true;
            this.rb_Closecheckant.Location = new System.Drawing.Point(7, 32);
            this.rb_Closecheckant.Name = "rb_Closecheckant";
            this.rb_Closecheckant.Size = new System.Drawing.Size(173, 16);
            this.rb_Closecheckant.TabIndex = 1;
            this.rb_Closecheckant.Text = "Disable antenna detection";
            this.rb_Closecheckant.UseVisualStyleBackColor = true;
            // 
            // rb_Opencheckant
            // 
            this.rb_Opencheckant.AutoSize = true;
            this.rb_Opencheckant.Checked = true;
            this.rb_Opencheckant.Location = new System.Drawing.Point(7, 14);
            this.rb_Opencheckant.Name = "rb_Opencheckant";
            this.rb_Opencheckant.Size = new System.Drawing.Size(167, 16);
            this.rb_Opencheckant.TabIndex = 0;
            this.rb_Opencheckant.TabStop = true;
            this.rb_Opencheckant.Text = "Enable antenna detection";
            this.rb_Opencheckant.UseVisualStyleBackColor = true;
            // 
            // gpb_GPIO
            // 
            this.gpb_GPIO.Controls.Add(this.Button_GetGPIO);
            this.gpb_GPIO.Controls.Add(this.Button_SetGPIO);
            this.gpb_GPIO.Controls.Add(this.check_int2);
            this.gpb_GPIO.Controls.Add(this.check_int1);
            this.gpb_GPIO.Controls.Add(this.check_out2);
            this.gpb_GPIO.Controls.Add(this.check_out1);
            this.gpb_GPIO.Location = new System.Drawing.Point(354, 233);
            this.gpb_GPIO.Name = "gpb_GPIO";
            this.gpb_GPIO.Size = new System.Drawing.Size(693, 43);
            this.gpb_GPIO.TabIndex = 49;
            this.gpb_GPIO.TabStop = false;
            this.gpb_GPIO.Text = "GPIO Operation";
            // 
            // Button_GetGPIO
            // 
            this.Button_GetGPIO.Location = new System.Drawing.Point(585, 14);
            this.Button_GetGPIO.Name = "Button_GetGPIO";
            this.Button_GetGPIO.Size = new System.Drawing.Size(90, 23);
            this.Button_GetGPIO.TabIndex = 9;
            this.Button_GetGPIO.Text = "Get";
            this.Button_GetGPIO.UseVisualStyleBackColor = true;
            this.Button_GetGPIO.Click += new System.EventHandler(this.Button_GetGPIO_Click);
            // 
            // Button_SetGPIO
            // 
            this.Button_SetGPIO.Location = new System.Drawing.Point(483, 14);
            this.Button_SetGPIO.Name = "Button_SetGPIO";
            this.Button_SetGPIO.Size = new System.Drawing.Size(90, 23);
            this.Button_SetGPIO.TabIndex = 8;
            this.Button_SetGPIO.Text = "Set";
            this.Button_SetGPIO.UseVisualStyleBackColor = true;
            this.Button_SetGPIO.Click += new System.EventHandler(this.Button_SetGPIO_Click);
            // 
            // check_int2
            // 
            this.check_int2.AutoSize = true;
            this.check_int2.Enabled = false;
            this.check_int2.Location = new System.Drawing.Point(302, 18);
            this.check_int2.Name = "check_int2";
            this.check_int2.Size = new System.Drawing.Size(42, 16);
            this.check_int2.TabIndex = 5;
            this.check_int2.Text = "IN2";
            this.check_int2.UseVisualStyleBackColor = true;
            this.check_int2.CheckedChanged += new System.EventHandler(this.check_int2_CheckedChanged);
            // 
            // check_int1
            // 
            this.check_int1.AutoSize = true;
            this.check_int1.Enabled = false;
            this.check_int1.Location = new System.Drawing.Point(227, 18);
            this.check_int1.Name = "check_int1";
            this.check_int1.Size = new System.Drawing.Size(42, 16);
            this.check_int1.TabIndex = 4;
            this.check_int1.Text = "IN1";
            this.check_int1.UseVisualStyleBackColor = true;
            // 
            // check_out2
            // 
            this.check_out2.AutoSize = true;
            this.check_out2.Location = new System.Drawing.Point(83, 18);
            this.check_out2.Name = "check_out2";
            this.check_out2.Size = new System.Drawing.Size(48, 16);
            this.check_out2.TabIndex = 1;
            this.check_out2.Text = "OUT2";
            this.check_out2.UseVisualStyleBackColor = true;
            // 
            // check_out1
            // 
            this.check_out1.AutoSize = true;
            this.check_out1.Location = new System.Drawing.Point(8, 18);
            this.check_out1.Name = "check_out1";
            this.check_out1.Size = new System.Drawing.Size(48, 16);
            this.check_out1.TabIndex = 0;
            this.check_out1.Text = "OUT1";
            this.check_out1.UseVisualStyleBackColor = true;
            // 
            // gpb_OutputRep
            // 
            this.gpb_OutputRep.Controls.Add(this.btOutputRep);
            this.gpb_OutputRep.Controls.Add(this.check_OutputRep4);
            this.gpb_OutputRep.Controls.Add(this.check_OutputRep3);
            this.gpb_OutputRep.Controls.Add(this.check_OutputRep2);
            this.gpb_OutputRep.Controls.Add(this.check_OutputRep1);
            this.gpb_OutputRep.Location = new System.Drawing.Point(705, 189);
            this.gpb_OutputRep.Name = "gpb_OutputRep";
            this.gpb_OutputRep.Size = new System.Drawing.Size(342, 42);
            this.gpb_OutputRep.TabIndex = 48;
            this.gpb_OutputRep.TabStop = false;
            this.gpb_OutputRep.Text = "Set notification pluse output";
            // 
            // btOutputRep
            // 
            this.btOutputRep.Location = new System.Drawing.Point(234, 13);
            this.btOutputRep.Name = "btOutputRep";
            this.btOutputRep.Size = new System.Drawing.Size(90, 23);
            this.btOutputRep.TabIndex = 5;
            this.btOutputRep.Text = "Set";
            this.btOutputRep.UseVisualStyleBackColor = true;
            this.btOutputRep.Click += new System.EventHandler(this.btOutputRep_Click);
            // 
            // check_OutputRep4
            // 
            this.check_OutputRep4.AutoSize = true;
            this.check_OutputRep4.Location = new System.Drawing.Point(184, 16);
            this.check_OutputRep4.Name = "check_OutputRep4";
            this.check_OutputRep4.Size = new System.Drawing.Size(48, 16);
            this.check_OutputRep4.TabIndex = 4;
            this.check_OutputRep4.Text = "OUT4";
            this.check_OutputRep4.UseVisualStyleBackColor = true;
            // 
            // check_OutputRep3
            // 
            this.check_OutputRep3.AutoSize = true;
            this.check_OutputRep3.Location = new System.Drawing.Point(125, 16);
            this.check_OutputRep3.Name = "check_OutputRep3";
            this.check_OutputRep3.Size = new System.Drawing.Size(48, 16);
            this.check_OutputRep3.TabIndex = 3;
            this.check_OutputRep3.Text = "OUT3";
            this.check_OutputRep3.UseVisualStyleBackColor = true;
            // 
            // check_OutputRep2
            // 
            this.check_OutputRep2.AutoSize = true;
            this.check_OutputRep2.Location = new System.Drawing.Point(66, 16);
            this.check_OutputRep2.Name = "check_OutputRep2";
            this.check_OutputRep2.Size = new System.Drawing.Size(48, 16);
            this.check_OutputRep2.TabIndex = 2;
            this.check_OutputRep2.Text = "OUT2";
            this.check_OutputRep2.UseVisualStyleBackColor = true;
            // 
            // check_OutputRep1
            // 
            this.check_OutputRep1.AutoSize = true;
            this.check_OutputRep1.Location = new System.Drawing.Point(8, 16);
            this.check_OutputRep1.Name = "check_OutputRep1";
            this.check_OutputRep1.Size = new System.Drawing.Size(48, 16);
            this.check_OutputRep1.TabIndex = 1;
            this.check_OutputRep1.Text = "OUT1";
            this.check_OutputRep1.UseVisualStyleBackColor = true;
            // 
            // gpb_Relay
            // 
            this.gpb_Relay.Controls.Add(this.label38);
            this.gpb_Relay.Controls.Add(this.ComboBox_RelayTime);
            this.gpb_Relay.Controls.Add(this.label37);
            this.gpb_Relay.Controls.Add(this.btRelay);
            this.gpb_Relay.Location = new System.Drawing.Point(354, 189);
            this.gpb_Relay.Name = "gpb_Relay";
            this.gpb_Relay.Size = new System.Drawing.Size(342, 42);
            this.gpb_Relay.TabIndex = 31;
            this.gpb_Relay.TabStop = false;
            this.gpb_Relay.Text = "Relay control";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(182, 18);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(35, 12);
            this.label38.TabIndex = 26;
            this.label38.Text = "*50ms";
            // 
            // ComboBox_RelayTime
            // 
            this.ComboBox_RelayTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_RelayTime.FormattingEnabled = true;
            this.ComboBox_RelayTime.Location = new System.Drawing.Point(82, 15);
            this.ComboBox_RelayTime.Name = "ComboBox_RelayTime";
            this.ComboBox_RelayTime.Size = new System.Drawing.Size(96, 20);
            this.ComboBox_RelayTime.TabIndex = 25;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(4, 19);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(83, 12);
            this.label37.TabIndex = 24;
            this.label37.Text = "Release time:";
            // 
            // btRelay
            // 
            this.btRelay.Location = new System.Drawing.Point(233, 13);
            this.btRelay.Name = "btRelay";
            this.btRelay.Size = new System.Drawing.Size(90, 23);
            this.btRelay.TabIndex = 23;
            this.btRelay.Text = "Set";
            this.btRelay.UseVisualStyleBackColor = true;
            this.btRelay.Click += new System.EventHandler(this.btRelay_Click);
            // 
            // gpb_baud
            // 
            this.gpb_baud.Controls.Add(this.ComboBox_baud);
            this.gpb_baud.Controls.Add(this.btBaudRate);
            this.gpb_baud.Location = new System.Drawing.Point(706, 123);
            this.gpb_baud.Name = "gpb_baud";
            this.gpb_baud.Size = new System.Drawing.Size(342, 60);
            this.gpb_baud.TabIndex = 30;
            this.gpb_baud.TabStop = false;
            this.gpb_baud.Text = "RS232/485 baud rate";
            // 
            // ComboBox_baud
            // 
            this.ComboBox_baud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_baud.FormattingEnabled = true;
            this.ComboBox_baud.Items.AddRange(new object[] {
            "9600bps",
            "19200bps",
            "38400bps",
            "57600bps",
            "115200bps"});
            this.ComboBox_baud.Location = new System.Drawing.Point(69, 25);
            this.ComboBox_baud.Name = "ComboBox_baud";
            this.ComboBox_baud.Size = new System.Drawing.Size(121, 20);
            this.ComboBox_baud.TabIndex = 24;
            // 
            // btBaudRate
            // 
            this.btBaudRate.Location = new System.Drawing.Point(233, 22);
            this.btBaudRate.Name = "btBaudRate";
            this.btBaudRate.Size = new System.Drawing.Size(90, 23);
            this.btBaudRate.TabIndex = 23;
            this.btBaudRate.Text = "Set";
            this.btBaudRate.UseVisualStyleBackColor = true;
            this.btBaudRate.Click += new System.EventHandler(this.btBaudRate_Click);
            // 
            // gpb_DBM
            // 
            this.gpb_DBM.Controls.Add(this.label10);
            this.gpb_DBM.Controls.Add(this.ComboBox_PowerDbm);
            this.gpb_DBM.Controls.Add(this.BT_DBM);
            this.gpb_DBM.Location = new System.Drawing.Point(354, 123);
            this.gpb_DBM.Name = "gpb_DBM";
            this.gpb_DBM.Size = new System.Drawing.Size(342, 62);
            this.gpb_DBM.TabIndex = 29;
            this.gpb_DBM.TabStop = false;
            this.gpb_DBM.Text = "Power";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(157, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 12);
            this.label10.TabIndex = 25;
            this.label10.Text = "dBm";
            // 
            // ComboBox_PowerDbm
            // 
            this.ComboBox_PowerDbm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_PowerDbm.FormattingEnabled = true;
            this.ComboBox_PowerDbm.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.ComboBox_PowerDbm.Location = new System.Drawing.Point(51, 23);
            this.ComboBox_PowerDbm.Name = "ComboBox_PowerDbm";
            this.ComboBox_PowerDbm.Size = new System.Drawing.Size(100, 20);
            this.ComboBox_PowerDbm.TabIndex = 24;
            // 
            // BT_DBM
            // 
            this.BT_DBM.Location = new System.Drawing.Point(233, 23);
            this.BT_DBM.Name = "BT_DBM";
            this.BT_DBM.Size = new System.Drawing.Size(90, 23);
            this.BT_DBM.TabIndex = 23;
            this.BT_DBM.Text = "Set";
            this.BT_DBM.UseVisualStyleBackColor = true;
            this.BT_DBM.Click += new System.EventHandler(this.BT_DBM_Click);
            // 
            // gpb_Freq
            // 
            this.gpb_Freq.Controls.Add(this.radioButton_band12);
            this.gpb_Freq.Controls.Add(this.radioButton_band8);
            this.gpb_Freq.Controls.Add(this.CheckBox_SameFre);
            this.gpb_Freq.Controls.Add(this.radioButton_band4);
            this.gpb_Freq.Controls.Add(this.radioButton_band3);
            this.gpb_Freq.Controls.Add(this.radioButton_band2);
            this.gpb_Freq.Controls.Add(this.radioButton_band1);
            this.gpb_Freq.Controls.Add(this.btFreq);
            this.gpb_Freq.Controls.Add(this.ComboBox_dmaxfre);
            this.gpb_Freq.Controls.Add(this.label15);
            this.gpb_Freq.Controls.Add(this.ComboBox_dminfre);
            this.gpb_Freq.Controls.Add(this.label14);
            this.gpb_Freq.Location = new System.Drawing.Point(354, 51);
            this.gpb_Freq.Name = "gpb_Freq";
            this.gpb_Freq.Size = new System.Drawing.Size(695, 70);
            this.gpb_Freq.TabIndex = 28;
            this.gpb_Freq.TabStop = false;
            this.gpb_Freq.Text = "Region";
            // 
            // radioButton_band8
            // 
            this.radioButton_band8.AutoSize = true;
            this.radioButton_band8.Location = new System.Drawing.Point(10, 17);
            this.radioButton_band8.Name = "radioButton_band8";
            this.radioButton_band8.Size = new System.Drawing.Size(101, 16);
            this.radioButton_band8.TabIndex = 17;
            this.radioButton_band8.TabStop = true;
            this.radioButton_band8.Text = "Chinese band1";
            this.radioButton_band8.UseVisualStyleBackColor = true;
            this.radioButton_band8.CheckedChanged += new System.EventHandler(this.radioButton_band8_CheckedChanged);
            // 
            // CheckBox_SameFre
            // 
            this.CheckBox_SameFre.AutoSize = true;
            this.CheckBox_SameFre.Location = new System.Drawing.Point(585, 16);
            this.CheckBox_SameFre.Name = "CheckBox_SameFre";
            this.CheckBox_SameFre.Size = new System.Drawing.Size(60, 16);
            this.CheckBox_SameFre.TabIndex = 16;
            this.CheckBox_SameFre.Text = "Single";
            this.CheckBox_SameFre.UseVisualStyleBackColor = true;
            this.CheckBox_SameFre.CheckedChanged += new System.EventHandler(this.CheckBox_SameFre_CheckedChanged);
            // 
            // radioButton_band4
            // 
            this.radioButton_band4.AutoSize = true;
            this.radioButton_band4.Location = new System.Drawing.Point(122, 44);
            this.radioButton_band4.Name = "radioButton_band4";
            this.radioButton_band4.Size = new System.Drawing.Size(65, 16);
            this.radioButton_band4.TabIndex = 15;
            this.radioButton_band4.TabStop = true;
            this.radioButton_band4.Text = "EU band";
            this.radioButton_band4.UseVisualStyleBackColor = true;
            this.radioButton_band4.CheckedChanged += new System.EventHandler(this.radioButton_band4_CheckedChanged);
            // 
            // radioButton_band3
            // 
            this.radioButton_band3.AutoSize = true;
            this.radioButton_band3.Location = new System.Drawing.Point(14, 41);
            this.radioButton_band3.Name = "radioButton_band3";
            this.radioButton_band3.Size = new System.Drawing.Size(89, 16);
            this.radioButton_band3.TabIndex = 14;
            this.radioButton_band3.TabStop = true;
            this.radioButton_band3.Text = "Korean band";
            this.radioButton_band3.UseVisualStyleBackColor = true;
            this.radioButton_band3.CheckedChanged += new System.EventHandler(this.radioButton_band3_CheckedChanged);
            // 
            // radioButton_band2
            // 
            this.radioButton_band2.AutoSize = true;
            this.radioButton_band2.Location = new System.Drawing.Point(247, 16);
            this.radioButton_band2.Name = "radioButton_band2";
            this.radioButton_band2.Size = new System.Drawing.Size(65, 16);
            this.radioButton_band2.TabIndex = 13;
            this.radioButton_band2.TabStop = true;
            this.radioButton_band2.Text = "US band";
            this.radioButton_band2.UseVisualStyleBackColor = true;
            this.radioButton_band2.CheckedChanged += new System.EventHandler(this.radioButton_band2_CheckedChanged);
            // 
            // radioButton_band1
            // 
            this.radioButton_band1.AutoSize = true;
            this.radioButton_band1.Location = new System.Drawing.Point(122, 17);
            this.radioButton_band1.Name = "radioButton_band1";
            this.radioButton_band1.Size = new System.Drawing.Size(101, 16);
            this.radioButton_band1.TabIndex = 12;
            this.radioButton_band1.TabStop = true;
            this.radioButton_band1.Text = "Chinese band2";
            this.radioButton_band1.UseVisualStyleBackColor = true;
            this.radioButton_band1.CheckedChanged += new System.EventHandler(this.radioButton_band1_CheckedChanged);
            // 
            // btFreq
            // 
            this.btFreq.Location = new System.Drawing.Point(585, 37);
            this.btFreq.Name = "btFreq";
            this.btFreq.Size = new System.Drawing.Size(90, 23);
            this.btFreq.TabIndex = 11;
            this.btFreq.Text = "Set";
            this.btFreq.UseVisualStyleBackColor = true;
            this.btFreq.Click += new System.EventHandler(this.btFreq_Click);
            // 
            // ComboBox_dmaxfre
            // 
            this.ComboBox_dmaxfre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_dmaxfre.FormattingEnabled = true;
            this.ComboBox_dmaxfre.Location = new System.Drawing.Point(421, 42);
            this.ComboBox_dmaxfre.Name = "ComboBox_dmaxfre";
            this.ComboBox_dmaxfre.Size = new System.Drawing.Size(100, 20);
            this.ComboBox_dmaxfre.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(332, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 12);
            this.label15.TabIndex = 9;
            this.label15.Text = "Maxfre:";
            // 
            // ComboBox_dminfre
            // 
            this.ComboBox_dminfre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_dminfre.FormattingEnabled = true;
            this.ComboBox_dminfre.Location = new System.Drawing.Point(421, 13);
            this.ComboBox_dminfre.Name = "ComboBox_dminfre";
            this.ComboBox_dminfre.Size = new System.Drawing.Size(100, 20);
            this.ComboBox_dminfre.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(332, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 12);
            this.label14.TabIndex = 7;
            this.label14.Text = "Minfre:";
            // 
            // gpb_beep
            // 
            this.gpb_beep.Controls.Add(this.Radio_beepDis);
            this.gpb_beep.Controls.Add(this.Radio_beepEn);
            this.gpb_beep.Controls.Add(this.Button_Beep);
            this.gpb_beep.Location = new System.Drawing.Point(707, 5);
            this.gpb_beep.Name = "gpb_beep";
            this.gpb_beep.Size = new System.Drawing.Size(342, 44);
            this.gpb_beep.TabIndex = 27;
            this.gpb_beep.TabStop = false;
            this.gpb_beep.Text = "Beep";
            // 
            // Radio_beepDis
            // 
            this.Radio_beepDis.AutoSize = true;
            this.Radio_beepDis.Checked = true;
            this.Radio_beepDis.Location = new System.Drawing.Point(123, 18);
            this.Radio_beepDis.Name = "Radio_beepDis";
            this.Radio_beepDis.Size = new System.Drawing.Size(53, 16);
            this.Radio_beepDis.TabIndex = 10;
            this.Radio_beepDis.TabStop = true;
            this.Radio_beepDis.Text = "Close";
            this.Radio_beepDis.UseVisualStyleBackColor = true;
            // 
            // Radio_beepEn
            // 
            this.Radio_beepEn.AutoSize = true;
            this.Radio_beepEn.Location = new System.Drawing.Point(33, 18);
            this.Radio_beepEn.Name = "Radio_beepEn";
            this.Radio_beepEn.Size = new System.Drawing.Size(47, 16);
            this.Radio_beepEn.TabIndex = 9;
            this.Radio_beepEn.Text = "Open";
            this.Radio_beepEn.UseVisualStyleBackColor = true;
            // 
            // Button_Beep
            // 
            this.Button_Beep.Location = new System.Drawing.Point(232, 14);
            this.Button_Beep.Name = "Button_Beep";
            this.Button_Beep.Size = new System.Drawing.Size(90, 23);
            this.Button_Beep.TabIndex = 8;
            this.Button_Beep.Text = "Set";
            this.Button_Beep.UseVisualStyleBackColor = true;
            this.Button_Beep.Click += new System.EventHandler(this.Button_Beep_Click);
            // 
            // gpb_RDVersion
            // 
            this.gpb_RDVersion.Controls.Add(this.text_RDVersion);
            this.gpb_RDVersion.Location = new System.Drawing.Point(354, 5);
            this.gpb_RDVersion.Name = "gpb_RDVersion";
            this.gpb_RDVersion.Size = new System.Drawing.Size(342, 44);
            this.gpb_RDVersion.TabIndex = 26;
            this.gpb_RDVersion.TabStop = false;
            this.gpb_RDVersion.Text = "Firmware version";
            // 
            // text_RDVersion
            // 
            this.text_RDVersion.Location = new System.Drawing.Point(95, 15);
            this.text_RDVersion.MaxLength = 2;
            this.text_RDVersion.Name = "text_RDVersion";
            this.text_RDVersion.ReadOnly = true;
            this.text_RDVersion.Size = new System.Drawing.Size(160, 21);
            this.text_RDVersion.TabIndex = 24;
            // 
            // gpb_Serial
            // 
            this.gpb_Serial.Controls.Add(this.text_Serial);
            this.gpb_Serial.Controls.Add(this.btSerial);
            this.gpb_Serial.Location = new System.Drawing.Point(6, 243);
            this.gpb_Serial.Name = "gpb_Serial";
            this.gpb_Serial.Size = new System.Drawing.Size(342, 43);
            this.gpb_Serial.TabIndex = 6;
            this.gpb_Serial.TabStop = false;
            this.gpb_Serial.Text = "Reader serial number\n";
            // 
            // text_Serial
            // 
            this.text_Serial.Location = new System.Drawing.Point(95, 13);
            this.text_Serial.MaxLength = 8;
            this.text_Serial.Name = "text_Serial";
            this.text_Serial.ReadOnly = true;
            this.text_Serial.Size = new System.Drawing.Size(121, 21);
            this.text_Serial.TabIndex = 24;
            // 
            // btSerial
            // 
            this.btSerial.Location = new System.Drawing.Point(233, 13);
            this.btSerial.Name = "btSerial";
            this.btSerial.Size = new System.Drawing.Size(90, 23);
            this.btSerial.TabIndex = 23;
            this.btSerial.Text = "Get";
            this.btSerial.UseVisualStyleBackColor = true;
            this.btSerial.Click += new System.EventHandler(this.btSerial_Click);
            // 
            // gpb_address
            // 
            this.gpb_address.Controls.Add(this.text_address);
            this.gpb_address.Controls.Add(this.btaddress);
            this.gpb_address.Location = new System.Drawing.Point(6, 196);
            this.gpb_address.Name = "gpb_address";
            this.gpb_address.Size = new System.Drawing.Size(342, 45);
            this.gpb_address.TabIndex = 5;
            this.gpb_address.TabStop = false;
            this.gpb_address.Text = "Reader address";
            // 
            // text_address
            // 
            this.text_address.Location = new System.Drawing.Point(95, 14);
            this.text_address.MaxLength = 2;
            this.text_address.Name = "text_address";
            this.text_address.Size = new System.Drawing.Size(121, 21);
            this.text_address.TabIndex = 24;
            this.text_address.Text = "00";
            this.text_address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // btaddress
            // 
            this.btaddress.Location = new System.Drawing.Point(233, 14);
            this.btaddress.Name = "btaddress";
            this.btaddress.Size = new System.Drawing.Size(90, 23);
            this.btaddress.TabIndex = 23;
            this.btaddress.Text = "Set";
            this.btaddress.UseVisualStyleBackColor = true;
            this.btaddress.Click += new System.EventHandler(this.btaddress_Click);
            // 
            // gpb_tcp
            // 
            this.gpb_tcp.Controls.Add(this.tb_Port);
            this.gpb_tcp.Controls.Add(this.ipServerIP);
            this.gpb_tcp.Controls.Add(this.btDisConnectTcp);
            this.gpb_tcp.Controls.Add(this.btConnectTcp);
            this.gpb_tcp.Controls.Add(this.label2);
            this.gpb_tcp.Controls.Add(this.label4);
            this.gpb_tcp.Location = new System.Drawing.Point(5, 123);
            this.gpb_tcp.Name = "gpb_tcp";
            this.gpb_tcp.Size = new System.Drawing.Size(343, 71);
            this.gpb_tcp.TabIndex = 4;
            this.gpb_tcp.TabStop = false;
            this.gpb_tcp.Text = "TCP/IP";
            // 
            // tb_Port
            // 
            this.tb_Port.Location = new System.Drawing.Point(96, 40);
            this.tb_Port.Name = "tb_Port";
            this.tb_Port.Size = new System.Drawing.Size(121, 21);
            this.tb_Port.TabIndex = 22;
            this.tb_Port.Text = "27011";
            this.tb_Port.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // ipServerIP
            // 
            this.ipServerIP.IpAddressStr = "192.168.0.250";
            this.ipServerIP.Location = new System.Drawing.Point(96, 15);
            this.ipServerIP.Name = "ipServerIP";
            this.ipServerIP.Size = new System.Drawing.Size(121, 21);
            this.ipServerIP.TabIndex = 21;
            this.ipServerIP.Tag = "";
            // 
            // btDisConnectTcp
            // 
            this.btDisConnectTcp.Enabled = false;
            this.btDisConnectTcp.Location = new System.Drawing.Point(234, 40);
            this.btDisConnectTcp.Name = "btDisConnectTcp";
            this.btDisConnectTcp.Size = new System.Drawing.Size(90, 23);
            this.btDisConnectTcp.TabIndex = 20;
            this.btDisConnectTcp.Text = "Disconnect";
            this.btDisConnectTcp.UseVisualStyleBackColor = true;
            this.btDisConnectTcp.Click += new System.EventHandler(this.btDisConnectTcp_Click);
            // 
            // btConnectTcp
            // 
            this.btConnectTcp.Location = new System.Drawing.Point(234, 13);
            this.btConnectTcp.Name = "btConnectTcp";
            this.btConnectTcp.Size = new System.Drawing.Size(90, 23);
            this.btConnectTcp.TabIndex = 19;
            this.btConnectTcp.Text = "Connect";
            this.btConnectTcp.UseVisualStyleBackColor = true;
            this.btConnectTcp.Click += new System.EventHandler(this.btConnectTcp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "Port:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "IP Addr:";
            // 
            // gpb_rs232
            // 
            this.gpb_rs232.Controls.Add(this.btDisConnect232);
            this.gpb_rs232.Controls.Add(this.btConnect232);
            this.gpb_rs232.Controls.Add(this.ComboBox_baud2);
            this.gpb_rs232.Controls.Add(this.label47);
            this.gpb_rs232.Controls.Add(this.ComboBox_COM);
            this.gpb_rs232.Controls.Add(this.label3);
            this.gpb_rs232.Location = new System.Drawing.Point(5, 51);
            this.gpb_rs232.Name = "gpb_rs232";
            this.gpb_rs232.Size = new System.Drawing.Size(343, 70);
            this.gpb_rs232.TabIndex = 3;
            this.gpb_rs232.TabStop = false;
            this.gpb_rs232.Text = "RS232";
            // 
            // btDisConnect232
            // 
            this.btDisConnect232.Enabled = false;
            this.btDisConnect232.Location = new System.Drawing.Point(234, 41);
            this.btDisConnect232.Name = "btDisConnect232";
            this.btDisConnect232.Size = new System.Drawing.Size(90, 23);
            this.btDisConnect232.TabIndex = 20;
            this.btDisConnect232.Text = "Disconnect";
            this.btDisConnect232.UseVisualStyleBackColor = true;
            this.btDisConnect232.Click += new System.EventHandler(this.btDisConnect232_Click);
            // 
            // btConnect232
            // 
            this.btConnect232.Location = new System.Drawing.Point(234, 13);
            this.btConnect232.Name = "btConnect232";
            this.btConnect232.Size = new System.Drawing.Size(90, 23);
            this.btConnect232.TabIndex = 19;
            this.btConnect232.Text = "Connect";
            this.btConnect232.UseVisualStyleBackColor = true;
            this.btConnect232.Click += new System.EventHandler(this.btConnect232_Click);
            // 
            // ComboBox_baud2
            // 
            this.ComboBox_baud2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_baud2.FormattingEnabled = true;
            this.ComboBox_baud2.Items.AddRange(new object[] {
            "9600bps",
            "19200bps",
            "38400bps",
            "57600bps",
            "115200bps"});
            this.ComboBox_baud2.Location = new System.Drawing.Point(96, 43);
            this.ComboBox_baud2.Name = "ComboBox_baud2";
            this.ComboBox_baud2.Size = new System.Drawing.Size(121, 20);
            this.ComboBox_baud2.TabIndex = 18;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(21, 48);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(65, 12);
            this.label47.TabIndex = 17;
            this.label47.Text = "Baud rate:";
            // 
            // ComboBox_COM
            // 
            this.ComboBox_COM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_COM.FormattingEnabled = true;
            this.ComboBox_COM.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.ComboBox_COM.Location = new System.Drawing.Point(96, 15);
            this.ComboBox_COM.Name = "ComboBox_COM";
            this.ComboBox_COM.Size = new System.Drawing.Size(121, 20);
            this.ComboBox_COM.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "Serial Port:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_tcp);
            this.groupBox1.Controls.Add(this.rb_rs232);
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 44);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect Type";
            // 
            // rb_tcp
            // 
            this.rb_tcp.AutoSize = true;
            this.rb_tcp.Location = new System.Drawing.Point(190, 18);
            this.rb_tcp.Name = "rb_tcp";
            this.rb_tcp.Size = new System.Drawing.Size(59, 16);
            this.rb_tcp.TabIndex = 1;
            this.rb_tcp.Text = "TCP/IP";
            this.rb_tcp.UseVisualStyleBackColor = true;
            this.rb_tcp.CheckedChanged += new System.EventHandler(this.rb_tcp_CheckedChanged);
            // 
            // rb_rs232
            // 
            this.rb_rs232.AutoSize = true;
            this.rb_rs232.Location = new System.Drawing.Point(33, 18);
            this.rb_rs232.Name = "rb_rs232";
            this.rb_rs232.Size = new System.Drawing.Size(53, 16);
            this.rb_rs232.TabIndex = 0;
            this.rb_rs232.Text = "RS232";
            this.rb_rs232.UseVisualStyleBackColor = true;
            this.rb_rs232.CheckedChanged += new System.EventHandler(this.rb_rs232_CheckedChanged);
            // 
            // tabPage_Module
            // 
            this.tabPage_Module.Controls.Add(this.panel9);
            this.tabPage_Module.Location = new System.Drawing.Point(4, 27);
            this.tabPage_Module.Name = "tabPage_Module";
            this.tabPage_Module.Size = new System.Drawing.Size(1057, 537);
            this.tabPage_Module.TabIndex = 2;
            this.tabPage_Module.Text = "Real-time-inventory setting";
            this.tabPage_Module.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btMSetParameter);
            this.panel9.Controls.Add(this.btMGetParameter);
            this.panel9.Controls.Add(this.groupBox39);
            this.panel9.Controls.Add(this.groupBox38);
            this.panel9.Controls.Add(this.groupBox34);
            this.panel9.Controls.Add(this.groupBox33);
            this.panel9.Controls.Add(this.groupBox32);
            this.panel9.Controls.Add(this.groupBox28);
            this.panel9.Controls.Add(this.groupBox3);
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1059, 506);
            this.panel9.TabIndex = 0;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // btMSetParameter
            // 
            this.btMSetParameter.Location = new System.Drawing.Point(928, 118);
            this.btMSetParameter.Name = "btMSetParameter";
            this.btMSetParameter.Size = new System.Drawing.Size(119, 33);
            this.btMSetParameter.TabIndex = 86;
            this.btMSetParameter.Text = "Set Parameter";
            this.btMSetParameter.UseVisualStyleBackColor = true;
            this.btMSetParameter.Click += new System.EventHandler(this.btMSetParameter_Click);
            // 
            // btMGetParameter
            // 
            this.btMGetParameter.Location = new System.Drawing.Point(928, 74);
            this.btMGetParameter.Name = "btMGetParameter";
            this.btMGetParameter.Size = new System.Drawing.Size(119, 33);
            this.btMGetParameter.TabIndex = 85;
            this.btMGetParameter.Text = "Get Parameter";
            this.btMGetParameter.UseVisualStyleBackColor = true;
            this.btMGetParameter.Click += new System.EventHandler(this.btMGetParameter_Click);
            // 
            // groupBox39
            // 
            this.groupBox39.Controls.Add(this.btSetMmode);
            this.groupBox39.Controls.Add(this.com_Mmode);
            this.groupBox39.Controls.Add(this.label111);
            this.groupBox39.Location = new System.Drawing.Point(656, 69);
            this.groupBox39.Name = "groupBox39";
            this.groupBox39.Size = new System.Drawing.Size(265, 87);
            this.groupBox39.TabIndex = 84;
            this.groupBox39.TabStop = false;
            this.groupBox39.Text = "Work Mode";
            // 
            // btSetMmode
            // 
            this.btSetMmode.Location = new System.Drawing.Point(170, 56);
            this.btSetMmode.Name = "btSetMmode";
            this.btSetMmode.Size = new System.Drawing.Size(90, 23);
            this.btSetMmode.TabIndex = 2;
            this.btSetMmode.Text = "Set";
            this.btSetMmode.UseVisualStyleBackColor = true;
            this.btSetMmode.Click += new System.EventHandler(this.btSetMmode_Click);
            // 
            // com_Mmode
            // 
            this.com_Mmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_Mmode.FormattingEnabled = true;
            this.com_Mmode.Items.AddRange(new object[] {
            "Answer mode",
            "Real-time-inventory mode",
            "trigger-mode"});
            this.com_Mmode.Location = new System.Drawing.Point(92, 23);
            this.com_Mmode.Name = "com_Mmode";
            this.com_Mmode.Size = new System.Drawing.Size(168, 20);
            this.com_Mmode.TabIndex = 1;
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(7, 26);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(77, 12);
            this.label111.TabIndex = 0;
            this.label111.Text = "Mode Select:";
            // 
            // groupBox38
            // 
            this.groupBox38.Controls.Add(this.checkBox_tid);
            this.groupBox38.Controls.Add(this.txt_Mtidlen);
            this.groupBox38.Controls.Add(this.label103);
            this.groupBox38.Controls.Add(this.txt_mtidaddr);
            this.groupBox38.Controls.Add(this.label104);
            this.groupBox38.Location = new System.Drawing.Point(436, 69);
            this.groupBox38.Name = "groupBox38";
            this.groupBox38.Size = new System.Drawing.Size(214, 87);
            this.groupBox38.TabIndex = 83;
            this.groupBox38.TabStop = false;
            this.groupBox38.Text = "TID Parameter Setting";
            // 
            // checkBox_tid
            // 
            this.checkBox_tid.AutoSize = true;
            this.checkBox_tid.Location = new System.Drawing.Point(160, 60);
            this.checkBox_tid.Name = "checkBox_tid";
            this.checkBox_tid.Size = new System.Drawing.Size(60, 16);
            this.checkBox_tid.TabIndex = 10;
            this.checkBox_tid.Text = "Enable";
            this.checkBox_tid.UseVisualStyleBackColor = true;
            // 
            // txt_Mtidlen
            // 
            this.txt_Mtidlen.Location = new System.Drawing.Point(87, 58);
            this.txt_Mtidlen.MaxLength = 2;
            this.txt_Mtidlen.Name = "txt_Mtidlen";
            this.txt_Mtidlen.Size = new System.Drawing.Size(60, 21);
            this.txt_Mtidlen.TabIndex = 5;
            this.txt_Mtidlen.Text = "04";
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Location = new System.Drawing.Point(13, 61);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(77, 12);
            this.label103.TabIndex = 4;
            this.label103.Text = "Length(Hex):";
            // 
            // txt_mtidaddr
            // 
            this.txt_mtidaddr.Location = new System.Drawing.Point(138, 23);
            this.txt_mtidaddr.MaxLength = 2;
            this.txt_mtidaddr.Name = "txt_mtidaddr";
            this.txt_mtidaddr.Size = new System.Drawing.Size(64, 21);
            this.txt_mtidaddr.TabIndex = 3;
            this.txt_mtidaddr.Text = "02";
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Location = new System.Drawing.Point(13, 26);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(119, 12);
            this.label104.TabIndex = 0;
            this.label104.Text = "Start address(Hex):";
            // 
            // groupBox34
            // 
            this.groupBox34.Controls.Add(this.checkBox_mask);
            this.groupBox34.Controls.Add(this.txt_Mdata);
            this.groupBox34.Controls.Add(this.label100);
            this.groupBox34.Controls.Add(this.txt_Mlen);
            this.groupBox34.Controls.Add(this.label101);
            this.groupBox34.Controls.Add(this.txt_Maddr);
            this.groupBox34.Controls.Add(this.label102);
            this.groupBox34.Controls.Add(this.RBM_USER);
            this.groupBox34.Controls.Add(this.RBM_TID);
            this.groupBox34.Controls.Add(this.RBM_EPC);
            this.groupBox34.Location = new System.Drawing.Point(8, 69);
            this.groupBox34.Name = "groupBox34";
            this.groupBox34.Size = new System.Drawing.Size(420, 87);
            this.groupBox34.TabIndex = 82;
            this.groupBox34.TabStop = false;
            this.groupBox34.Text = "Mask setting";
            // 
            // checkBox_mask
            // 
            this.checkBox_mask.AutoSize = true;
            this.checkBox_mask.Location = new System.Drawing.Point(323, 13);
            this.checkBox_mask.Name = "checkBox_mask";
            this.checkBox_mask.Size = new System.Drawing.Size(60, 16);
            this.checkBox_mask.TabIndex = 9;
            this.checkBox_mask.Text = "Enable";
            this.checkBox_mask.UseVisualStyleBackColor = true;
            // 
            // txt_Mdata
            // 
            this.txt_Mdata.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Mdata.Location = new System.Drawing.Point(94, 61);
            this.txt_Mdata.Name = "txt_Mdata";
            this.txt_Mdata.Size = new System.Drawing.Size(316, 21);
            this.txt_Mdata.TabIndex = 8;
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(6, 67);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(65, 12);
            this.label100.TabIndex = 7;
            this.label100.Text = "Data(Hex):";
            // 
            // txt_Mlen
            // 
            this.txt_Mlen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Mlen.Location = new System.Drawing.Point(348, 33);
            this.txt_Mlen.MaxLength = 2;
            this.txt_Mlen.Name = "txt_Mlen";
            this.txt_Mlen.Size = new System.Drawing.Size(62, 21);
            this.txt_Mlen.TabIndex = 6;
            this.txt_Mlen.Text = "00";
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Location = new System.Drawing.Point(247, 40);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(77, 12);
            this.label101.TabIndex = 5;
            this.label101.Text = "Length(Hex):";
            // 
            // txt_Maddr
            // 
            this.txt_Maddr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Maddr.Location = new System.Drawing.Point(137, 33);
            this.txt_Maddr.MaxLength = 4;
            this.txt_Maddr.Name = "txt_Maddr";
            this.txt_Maddr.Size = new System.Drawing.Size(55, 21);
            this.txt_Maddr.TabIndex = 4;
            this.txt_Maddr.Text = "0000";
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Location = new System.Drawing.Point(6, 40);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(119, 12);
            this.label102.TabIndex = 3;
            this.label102.Text = "Start address(Hex):";
            // 
            // RBM_USER
            // 
            this.RBM_USER.AutoSize = true;
            this.RBM_USER.Location = new System.Drawing.Point(247, 14);
            this.RBM_USER.Name = "RBM_USER";
            this.RBM_USER.Size = new System.Drawing.Size(47, 16);
            this.RBM_USER.TabIndex = 2;
            this.RBM_USER.Text = "User";
            this.RBM_USER.UseVisualStyleBackColor = true;
            // 
            // RBM_TID
            // 
            this.RBM_TID.AutoSize = true;
            this.RBM_TID.Location = new System.Drawing.Point(136, 14);
            this.RBM_TID.Name = "RBM_TID";
            this.RBM_TID.Size = new System.Drawing.Size(41, 16);
            this.RBM_TID.TabIndex = 1;
            this.RBM_TID.Text = "TID";
            this.RBM_TID.UseVisualStyleBackColor = true;
            // 
            // RBM_EPC
            // 
            this.RBM_EPC.AutoSize = true;
            this.RBM_EPC.Checked = true;
            this.RBM_EPC.Location = new System.Drawing.Point(20, 14);
            this.RBM_EPC.Name = "RBM_EPC";
            this.RBM_EPC.Size = new System.Drawing.Size(41, 16);
            this.RBM_EPC.TabIndex = 0;
            this.RBM_EPC.TabStop = true;
            this.RBM_EPC.Text = "EPC";
            this.RBM_EPC.UseVisualStyleBackColor = true;
            // 
            // groupBox33
            // 
            this.groupBox33.Controls.Add(this.com_MS);
            this.groupBox33.Controls.Add(this.label99);
            this.groupBox33.Controls.Add(this.com_MQ);
            this.groupBox33.Controls.Add(this.label98);
            this.groupBox33.Location = new System.Drawing.Point(656, 6);
            this.groupBox33.Name = "groupBox33";
            this.groupBox33.Size = new System.Drawing.Size(394, 56);
            this.groupBox33.TabIndex = 81;
            this.groupBox33.TabStop = false;
            this.groupBox33.Text = "Mutiple query parameter";
            // 
            // com_MS
            // 
            this.com_MS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_MS.FormattingEnabled = true;
            this.com_MS.Items.AddRange(new object[] {
            "S0",
            "S1",
            "S2",
            "S3",
            "AUTO"});
            this.com_MS.Location = new System.Drawing.Point(267, 23);
            this.com_MS.Name = "com_MS";
            this.com_MS.Size = new System.Drawing.Size(117, 20);
            this.com_MS.TabIndex = 3;
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Location = new System.Drawing.Point(194, 26);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(59, 12);
            this.label99.TabIndex = 2;
            this.label99.Text = "Session：";
            // 
            // com_MQ
            // 
            this.com_MQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_MQ.FormattingEnabled = true;
            this.com_MQ.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.com_MQ.Location = new System.Drawing.Point(47, 23);
            this.com_MQ.Name = "com_MQ";
            this.com_MQ.Size = new System.Drawing.Size(117, 20);
            this.com_MQ.TabIndex = 1;
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Location = new System.Drawing.Point(7, 26);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(23, 12);
            this.label98.TabIndex = 0;
            this.label98.Text = "Q：";
            // 
            // groupBox32
            // 
            this.groupBox32.Controls.Add(this.com_MFliterTime);
            this.groupBox32.Controls.Add(this.label97);
            this.groupBox32.Location = new System.Drawing.Point(436, 6);
            this.groupBox32.Name = "groupBox32";
            this.groupBox32.Size = new System.Drawing.Size(214, 56);
            this.groupBox32.TabIndex = 80;
            this.groupBox32.TabStop = false;
            this.groupBox32.Text = "Tag Filter";
            // 
            // com_MFliterTime
            // 
            this.com_MFliterTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_MFliterTime.FormattingEnabled = true;
            this.com_MFliterTime.Location = new System.Drawing.Point(87, 23);
            this.com_MFliterTime.Name = "com_MFliterTime";
            this.com_MFliterTime.Size = new System.Drawing.Size(117, 20);
            this.com_MFliterTime.TabIndex = 1;
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Location = new System.Drawing.Point(7, 26);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(77, 12);
            this.label97.TabIndex = 0;
            this.label97.Text = "Filter time:";
            // 
            // groupBox28
            // 
            this.groupBox28.Controls.Add(this.COM_MRPTime);
            this.groupBox28.Controls.Add(this.label96);
            this.groupBox28.Location = new System.Drawing.Point(214, 6);
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.Size = new System.Drawing.Size(214, 56);
            this.groupBox28.TabIndex = 79;
            this.groupBox28.TabStop = false;
            this.groupBox28.Text = "Pulse interval";
            // 
            // COM_MRPTime
            // 
            this.COM_MRPTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COM_MRPTime.FormattingEnabled = true;
            this.COM_MRPTime.Items.AddRange(new object[] {
            "10ms",
            "20ms",
            "30ms",
            "50ms",
            "100ms"});
            this.COM_MRPTime.Location = new System.Drawing.Point(73, 23);
            this.COM_MRPTime.Name = "COM_MRPTime";
            this.COM_MRPTime.Size = new System.Drawing.Size(131, 20);
            this.COM_MRPTime.TabIndex = 1;
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Location = new System.Drawing.Point(7, 26);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(71, 12);
            this.label96.TabIndex = 0;
            this.label96.Text = "Pulse Time:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MRB_6B);
            this.groupBox3.Controls.Add(this.MRB_G2);
            this.groupBox3.Location = new System.Drawing.Point(8, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 56);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Protocl";
            // 
            // MRB_6B
            // 
            this.MRB_6B.AutoSize = true;
            this.MRB_6B.Location = new System.Drawing.Point(106, 20);
            this.MRB_6B.Name = "MRB_6B";
            this.MRB_6B.Size = new System.Drawing.Size(71, 16);
            this.MRB_6B.TabIndex = 1;
            this.MRB_6B.Text = "18000-6B";
            this.MRB_6B.UseVisualStyleBackColor = true;
            // 
            // MRB_G2
            // 
            this.MRB_G2.AutoSize = true;
            this.MRB_G2.Checked = true;
            this.MRB_G2.Location = new System.Drawing.Point(10, 20);
            this.MRB_G2.Name = "MRB_G2";
            this.MRB_G2.Size = new System.Drawing.Size(71, 16);
            this.MRB_G2.TabIndex = 0;
            this.MRB_G2.TabStop = true;
            this.MRB_G2.Text = "EPCC1-G2";
            this.MRB_G2.UseVisualStyleBackColor = true;
            // 
            // Main_Page2
            // 
            this.Main_Page2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Main_Page2.Controls.Add(this.tabControl2);
            this.Main_Page2.Location = new System.Drawing.Point(4, 27);
            this.Main_Page2.Name = "Main_Page2";
            this.Main_Page2.Padding = new System.Windows.Forms.Padding(3);
            this.Main_Page2.Size = new System.Drawing.Size(1071, 571);
            this.Main_Page2.TabIndex = 1;
            this.Main_Page2.Text = "EPCC1-G2 Test";
            this.Main_Page2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage_answer);
            this.tabControl2.Controls.Add(this.tabPage_Realtime);
            this.tabControl2.Controls.Add(this.tabPage_Buff);
            this.tabControl2.Controls.Add(this.tabPage_RW);
            this.tabControl2.ItemSize = new System.Drawing.Size(120, 23);
            this.tabControl2.Location = new System.Drawing.Point(-1, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1071, 565);
            this.tabControl2.TabIndex = 0;
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.Maintab_SelectedIndexChanged);
            // 
            // tabPage_answer
            // 
            this.tabPage_answer.Controls.Add(this.panel1);
            this.tabPage_answer.Location = new System.Drawing.Point(4, 27);
            this.tabPage_answer.Name = "tabPage_answer";
            this.tabPage_answer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_answer.Size = new System.Drawing.Size(1063, 534);
            this.tabPage_answer.TabIndex = 0;
            this.tabPage_answer.Text = "Answer Mode";
            this.tabPage_answer.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lxLedControl6);
            this.panel1.Controls.Add(this.label119);
            this.panel1.Controls.Add(this.gbp_MixRead);
            this.panel1.Controls.Add(this.lxLedControl5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lxLedControl4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lxLedControl3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lxLedControl2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lxLedControl1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.group_ant1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 530);
            this.panel1.TabIndex = 0;
            // 
            // lxLedControl6
            // 
            this.lxLedControl6.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl6.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl6.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl6.BevelRate = 0.5F;
            this.lxLedControl6.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl6.BorderWidth = 3;
            this.lxLedControl6.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl6.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLedControl6.HighlightOpaque = ((byte)(50));
            this.lxLedControl6.Location = new System.Drawing.Point(712, 228);
            this.lxLedControl6.Name = "lxLedControl6";
            this.lxLedControl6.RoundCorner = true;
            this.lxLedControl6.ShowHighlight = true;
            this.lxLedControl6.Size = new System.Drawing.Size(313, 85);
            this.lxLedControl6.TabIndex = 31;
            this.lxLedControl6.Text = "0";
            this.lxLedControl6.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLedControl6.TotalCharCount = 7;
            // 
            // label119
            // 
            this.label119.AutoSize = true;
            this.label119.Location = new System.Drawing.Point(709, 209);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(71, 12);
            this.label119.TabIndex = 30;
            this.label119.Text = "TID Number:";
            // 
            // gbp_MixRead
            // 
            this.gbp_MixRead.Controls.Add(this.text_readpsd);
            this.gbp_MixRead.Controls.Add(this.label118);
            this.gbp_MixRead.Controls.Add(this.text_readLen);
            this.gbp_MixRead.Controls.Add(this.label117);
            this.gbp_MixRead.Controls.Add(this.text_readadr);
            this.gbp_MixRead.Controls.Add(this.label115);
            this.gbp_MixRead.Controls.Add(this.com_MixMem);
            this.gbp_MixRead.Controls.Add(this.label114);
            this.gbp_MixRead.Enabled = false;
            this.gbp_MixRead.Location = new System.Drawing.Point(396, 1);
            this.gbp_MixRead.Name = "gbp_MixRead";
            this.gbp_MixRead.Size = new System.Drawing.Size(222, 71);
            this.gbp_MixRead.TabIndex = 29;
            this.gbp_MixRead.TabStop = false;
            this.gbp_MixRead.Text = "Mix";
            // 
            // text_readpsd
            // 
            this.text_readpsd.Location = new System.Drawing.Point(64, 42);
            this.text_readpsd.MaxLength = 8;
            this.text_readpsd.Name = "text_readpsd";
            this.text_readpsd.Size = new System.Drawing.Size(65, 21);
            this.text_readpsd.TabIndex = 7;
            this.text_readpsd.Text = "00000000";
            this.text_readpsd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label118
            // 
            this.label118.AutoSize = true;
            this.label118.Location = new System.Drawing.Point(6, 46);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(59, 12);
            this.label118.TabIndex = 6;
            this.label118.Text = "Password:";
            // 
            // text_readLen
            // 
            this.text_readLen.Location = new System.Drawing.Point(176, 44);
            this.text_readLen.MaxLength = 2;
            this.text_readLen.Name = "text_readLen";
            this.text_readLen.Size = new System.Drawing.Size(41, 21);
            this.text_readLen.TabIndex = 5;
            this.text_readLen.Text = "04";
            this.text_readLen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.Location = new System.Drawing.Point(136, 48);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(29, 12);
            this.label117.TabIndex = 4;
            this.label117.Text = "Len:";
            // 
            // text_readadr
            // 
            this.text_readadr.Location = new System.Drawing.Point(176, 13);
            this.text_readadr.MaxLength = 4;
            this.text_readadr.Name = "text_readadr";
            this.text_readadr.Size = new System.Drawing.Size(41, 21);
            this.text_readadr.TabIndex = 3;
            this.text_readadr.Text = "0002";
            this.text_readadr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.Location = new System.Drawing.Point(136, 17);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(35, 12);
            this.label115.TabIndex = 2;
            this.label115.Text = "Addr:";
            // 
            // com_MixMem
            // 
            this.com_MixMem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_MixMem.FormattingEnabled = true;
            this.com_MixMem.Items.AddRange(new object[] {
            "Password",
            "EPC",
            "TID",
            "User"});
            this.com_MixMem.Location = new System.Drawing.Point(64, 12);
            this.com_MixMem.Name = "com_MixMem";
            this.com_MixMem.Size = new System.Drawing.Size(66, 20);
            this.com_MixMem.TabIndex = 1;
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.Location = new System.Drawing.Point(5, 16);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(29, 12);
            this.label114.TabIndex = 0;
            this.label114.Text = "Mem:";
            // 
            // lxLedControl5
            // 
            this.lxLedControl5.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl5.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl5.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl5.BevelRate = 0.5F;
            this.lxLedControl5.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl5.BorderWidth = 3;
            this.lxLedControl5.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl5.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLedControl5.HighlightOpaque = ((byte)(50));
            this.lxLedControl5.Location = new System.Drawing.Point(886, 449);
            this.lxLedControl5.Name = "lxLedControl5";
            this.lxLedControl5.RoundCorner = true;
            this.lxLedControl5.ShowHighlight = true;
            this.lxLedControl5.Size = new System.Drawing.Size(154, 40);
            this.lxLedControl5.TabIndex = 28;
            this.lxLedControl5.Text = "0";
            this.lxLedControl5.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLedControl5.TotalCharCount = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(884, 429);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 12);
            this.label9.TabIndex = 27;
            this.label9.Text = "Total-cmd-time(ms):";
            // 
            // lxLedControl4
            // 
            this.lxLedControl4.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl4.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl4.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl4.BevelRate = 0.5F;
            this.lxLedControl4.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl4.BorderWidth = 3;
            this.lxLedControl4.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl4.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLedControl4.HighlightOpaque = ((byte)(50));
            this.lxLedControl4.Location = new System.Drawing.Point(711, 448);
            this.lxLedControl4.Name = "lxLedControl4";
            this.lxLedControl4.RoundCorner = true;
            this.lxLedControl4.ShowHighlight = true;
            this.lxLedControl4.Size = new System.Drawing.Size(154, 41);
            this.lxLedControl4.TabIndex = 26;
            this.lxLedControl4.Text = "0";
            this.lxLedControl4.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLedControl4.TotalCharCount = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(709, 429);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 12);
            this.label8.TabIndex = 25;
            this.label8.Text = "Total tag number:";
            // 
            // lxLedControl3
            // 
            this.lxLedControl3.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl3.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl3.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl3.BevelRate = 0.5F;
            this.lxLedControl3.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl3.BorderWidth = 3;
            this.lxLedControl3.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl3.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl3.ForeColor = System.Drawing.Color.Purple;
            this.lxLedControl3.HighlightOpaque = ((byte)(50));
            this.lxLedControl3.Location = new System.Drawing.Point(886, 367);
            this.lxLedControl3.Name = "lxLedControl3";
            this.lxLedControl3.RoundCorner = true;
            this.lxLedControl3.ShowHighlight = true;
            this.lxLedControl3.Size = new System.Drawing.Size(154, 29);
            this.lxLedControl3.TabIndex = 24;
            this.lxLedControl3.Text = "0";
            this.lxLedControl3.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLedControl3.TotalCharCount = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(884, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "cmd time(ms):";
            // 
            // lxLedControl2
            // 
            this.lxLedControl2.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl2.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl2.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl2.BevelRate = 0.5F;
            this.lxLedControl2.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl2.BorderWidth = 3;
            this.lxLedControl2.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl2.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl2.ForeColor = System.Drawing.Color.Purple;
            this.lxLedControl2.HighlightOpaque = ((byte)(50));
            this.lxLedControl2.Location = new System.Drawing.Point(711, 367);
            this.lxLedControl2.Name = "lxLedControl2";
            this.lxLedControl2.RoundCorner = true;
            this.lxLedControl2.ShowHighlight = true;
            this.lxLedControl2.Size = new System.Drawing.Size(154, 29);
            this.lxLedControl2.TabIndex = 22;
            this.lxLedControl2.Text = "0";
            this.lxLedControl2.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLedControl2.TotalCharCount = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(709, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 21;
            this.label6.Text = "Speed:";
            // 
            // lxLedControl1
            // 
            this.lxLedControl1.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl1.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl1.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl1.BevelRate = 0.5F;
            this.lxLedControl1.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl1.BorderWidth = 3;
            this.lxLedControl1.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl1.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLedControl1.HighlightOpaque = ((byte)(50));
            this.lxLedControl1.Location = new System.Drawing.Point(712, 110);
            this.lxLedControl1.Name = "lxLedControl1";
            this.lxLedControl1.RoundCorner = true;
            this.lxLedControl1.ShowHighlight = true;
            this.lxLedControl1.Size = new System.Drawing.Size(313, 85);
            this.lxLedControl1.TabIndex = 20;
            this.lxLedControl1.Text = "0";
            this.lxLedControl1.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLedControl1.TotalCharCount = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(709, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "EPC Number:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Location = new System.Drawing.Point(4, 79);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(678, 445);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tag list(No Repeat)";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(664, 421);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox_rate);
            this.groupBox4.Controls.Add(this.label80);
            this.groupBox4.Controls.Add(this.text_target);
            this.groupBox4.Controls.Add(this.check_num);
            this.groupBox4.Controls.Add(this.com_Target);
            this.groupBox4.Controls.Add(this.label79);
            this.groupBox4.Controls.Add(this.com_scantime);
            this.groupBox4.Controls.Add(this.label39);
            this.groupBox4.Controls.Add(this.com_S);
            this.groupBox4.Controls.Add(this.label32);
            this.groupBox4.Controls.Add(this.com_Q);
            this.groupBox4.Controls.Add(this.label31);
            this.groupBox4.Location = new System.Drawing.Point(619, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(437, 71);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            // 
            // checkBox_rate
            // 
            this.checkBox_rate.AutoSize = true;
            this.checkBox_rate.Location = new System.Drawing.Point(317, 46);
            this.checkBox_rate.Name = "checkBox_rate";
            this.checkBox_rate.Size = new System.Drawing.Size(96, 16);
            this.checkBox_rate.TabIndex = 37;
            this.checkBox_rate.Text = "Return Speed";
            this.checkBox_rate.UseVisualStyleBackColor = true;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(102, 48);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(203, 12);
            this.label80.TabIndex = 36;
            this.label80.Text = "times no tag.then A/B conversion ";
            // 
            // text_target
            // 
            this.text_target.ForeColor = System.Drawing.Color.Red;
            this.text_target.Location = new System.Drawing.Point(55, 42);
            this.text_target.MaxLength = 2;
            this.text_target.Name = "text_target";
            this.text_target.Size = new System.Drawing.Size(43, 21);
            this.text_target.TabIndex = 35;
            this.text_target.Text = "5";
            this.text_target.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_target.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // check_num
            // 
            this.check_num.AutoSize = true;
            this.check_num.Checked = true;
            this.check_num.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_num.Location = new System.Drawing.Point(7, 46);
            this.check_num.Name = "check_num";
            this.check_num.Size = new System.Drawing.Size(48, 16);
            this.check_num.TabIndex = 34;
            this.check_num.Text = "Read";
            this.check_num.UseVisualStyleBackColor = true;
            // 
            // com_Target
            // 
            this.com_Target.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_Target.FormattingEnabled = true;
            this.com_Target.Items.AddRange(new object[] {
            "A",
            "B"});
            this.com_Target.Location = new System.Drawing.Point(384, 14);
            this.com_Target.Name = "com_Target";
            this.com_Target.Size = new System.Drawing.Size(51, 20);
            this.com_Target.TabIndex = 33;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(339, 18);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(47, 12);
            this.label79.TabIndex = 32;
            this.label79.Text = "Target:";
            // 
            // com_scantime
            // 
            this.com_scantime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_scantime.FormattingEnabled = true;
            this.com_scantime.Location = new System.Drawing.Point(258, 14);
            this.com_scantime.Name = "com_scantime";
            this.com_scantime.Size = new System.Drawing.Size(77, 20);
            this.com_scantime.TabIndex = 31;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(191, 18);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(59, 12);
            this.label39.TabIndex = 30;
            this.label39.Text = "ScanTime:";
            // 
            // com_S
            // 
            this.com_S.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_S.FormattingEnabled = true;
            this.com_S.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "AUTO"});
            this.com_S.Location = new System.Drawing.Point(125, 19);
            this.com_S.Name = "com_S";
            this.com_S.Size = new System.Drawing.Size(59, 20);
            this.com_S.TabIndex = 29;
            this.com_S.SelectedIndexChanged += new System.EventHandler(this.com_S_SelectedIndexChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(71, 18);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(59, 12);
            this.label32.TabIndex = 28;
            this.label32.Text = "Session：";
            // 
            // com_Q
            // 
            this.com_Q.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_Q.FormattingEnabled = true;
            this.com_Q.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.com_Q.Location = new System.Drawing.Point(18, 14);
            this.com_Q.Name = "com_Q";
            this.com_Q.Size = new System.Drawing.Size(51, 20);
            this.com_Q.TabIndex = 27;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(3, 18);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(17, 12);
            this.label31.TabIndex = 26;
            this.label31.Text = "Q:";
            // 
            // group_ant1
            // 
            this.group_ant1.Controls.Add(this.check_ant4);
            this.group_ant1.Controls.Add(this.check_ant3);
            this.group_ant1.Controls.Add(this.check_ant2);
            this.group_ant1.Controls.Add(this.check_ant1);
            this.group_ant1.Location = new System.Drawing.Point(262, 1);
            this.group_ant1.Name = "group_ant1";
            this.group_ant1.Size = new System.Drawing.Size(135, 71);
            this.group_ant1.TabIndex = 16;
            this.group_ant1.TabStop = false;
            // 
            // check_ant4
            // 
            this.check_ant4.AutoSize = true;
            this.check_ant4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.check_ant4.Location = new System.Drawing.Point(80, 43);
            this.check_ant4.Name = "check_ant4";
            this.check_ant4.Size = new System.Drawing.Size(48, 16);
            this.check_ant4.TabIndex = 37;
            this.check_ant4.Text = "ANT4";
            this.check_ant4.UseVisualStyleBackColor = true;
            // 
            // check_ant3
            // 
            this.check_ant3.AutoSize = true;
            this.check_ant3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.check_ant3.Location = new System.Drawing.Point(20, 43);
            this.check_ant3.Name = "check_ant3";
            this.check_ant3.Size = new System.Drawing.Size(48, 16);
            this.check_ant3.TabIndex = 36;
            this.check_ant3.Text = "ANT3";
            this.check_ant3.UseVisualStyleBackColor = true;
            // 
            // check_ant2
            // 
            this.check_ant2.AutoSize = true;
            this.check_ant2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.check_ant2.Location = new System.Drawing.Point(80, 16);
            this.check_ant2.Name = "check_ant2";
            this.check_ant2.Size = new System.Drawing.Size(48, 16);
            this.check_ant2.TabIndex = 35;
            this.check_ant2.Text = "ANT2";
            this.check_ant2.UseVisualStyleBackColor = true;
            // 
            // check_ant1
            // 
            this.check_ant1.AutoSize = true;
            this.check_ant1.Checked = true;
            this.check_ant1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_ant1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.check_ant1.Location = new System.Drawing.Point(20, 16);
            this.check_ant1.Name = "check_ant1";
            this.check_ant1.Size = new System.Drawing.Size(48, 16);
            this.check_ant1.TabIndex = 34;
            this.check_ant1.Text = "ANT1";
            this.check_ant1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_fastid);
            this.groupBox2.Controls.Add(this.rb_mix);
            this.groupBox2.Controls.Add(this.rb_tid);
            this.groupBox2.Controls.Add(this.rb_epc);
            this.groupBox2.Controls.Add(this.btIventoryG2);
            this.groupBox2.Location = new System.Drawing.Point(5, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 71);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // rb_fastid
            // 
            this.rb_fastid.AutoSize = true;
            this.rb_fastid.Location = new System.Drawing.Point(123, 43);
            this.rb_fastid.Name = "rb_fastid";
            this.rb_fastid.Size = new System.Drawing.Size(59, 16);
            this.rb_fastid.TabIndex = 4;
            this.rb_fastid.Text = "FastID";
            this.rb_fastid.UseVisualStyleBackColor = true;
            this.rb_fastid.CheckedChanged += new System.EventHandler(this.rb_fastid_CheckedChanged);
            // 
            // rb_mix
            // 
            this.rb_mix.AutoSize = true;
            this.rb_mix.Location = new System.Drawing.Point(207, 43);
            this.rb_mix.Name = "rb_mix";
            this.rb_mix.Size = new System.Drawing.Size(41, 16);
            this.rb_mix.TabIndex = 3;
            this.rb_mix.Text = "MIX";
            this.rb_mix.UseVisualStyleBackColor = true;
            this.rb_mix.Click += new System.EventHandler(this.rb_mix_Click);
            this.rb_mix.CheckedChanged += new System.EventHandler(this.rb_mix_CheckedChanged);
            // 
            // rb_tid
            // 
            this.rb_tid.AutoSize = true;
            this.rb_tid.Location = new System.Drawing.Point(207, 19);
            this.rb_tid.Name = "rb_tid";
            this.rb_tid.Size = new System.Drawing.Size(41, 16);
            this.rb_tid.TabIndex = 2;
            this.rb_tid.Text = "TID";
            this.rb_tid.UseVisualStyleBackColor = true;
            this.rb_tid.CheckedChanged += new System.EventHandler(this.rb_tid_CheckedChanged);
            // 
            // rb_epc
            // 
            this.rb_epc.AutoSize = true;
            this.rb_epc.Checked = true;
            this.rb_epc.Location = new System.Drawing.Point(123, 20);
            this.rb_epc.Name = "rb_epc";
            this.rb_epc.Size = new System.Drawing.Size(41, 16);
            this.rb_epc.TabIndex = 1;
            this.rb_epc.TabStop = true;
            this.rb_epc.Text = "EPC";
            this.rb_epc.UseVisualStyleBackColor = true;
            this.rb_epc.CheckedChanged += new System.EventHandler(this.rb_epc_CheckedChanged);
            // 
            // btIventoryG2
            // 
            this.btIventoryG2.BackColor = System.Drawing.Color.Transparent;
            this.btIventoryG2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btIventoryG2.ForeColor = System.Drawing.Color.DarkBlue;
            this.btIventoryG2.Location = new System.Drawing.Point(6, 20);
            this.btIventoryG2.Name = "btIventoryG2";
            this.btIventoryG2.Size = new System.Drawing.Size(109, 40);
            this.btIventoryG2.TabIndex = 0;
            this.btIventoryG2.Text = "Start";
            this.btIventoryG2.UseVisualStyleBackColor = false;
            this.btIventoryG2.Click += new System.EventHandler(this.btIventoryG2_Click);
            // 
            // tabPage_Realtime
            // 
            this.tabPage_Realtime.Controls.Add(this.panel10);
            this.tabPage_Realtime.Location = new System.Drawing.Point(4, 27);
            this.tabPage_Realtime.Name = "tabPage_Realtime";
            this.tabPage_Realtime.Size = new System.Drawing.Size(1063, 534);
            this.tabPage_Realtime.TabIndex = 4;
            this.tabPage_Realtime.Text = "Real-time-inventory";
            this.tabPage_Realtime.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.dataGridView4);
            this.panel10.Controls.Add(this.groupBox41);
            this.panel10.Controls.Add(this.groupBox42);
            this.panel10.Location = new System.Drawing.Point(1, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1063, 533);
            this.panel10.TabIndex = 0;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AllowUserToResizeColumns = false;
            this.dataGridView4.AllowUserToResizeRows = false;
            this.dataGridView4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.Column1,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.dataGridView4.Location = new System.Drawing.Point(358, 20);
            this.dataGridView4.MultiSelect = false;
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.RowTemplate.Height = 23;
            this.dataGridView4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(702, 509);
            this.dataGridView4.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "No.";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn10.Width = 80;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "EPC";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn11.Width = 310;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Length";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Antenna";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "RSSI";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox41
            // 
            this.groupBox41.Controls.Add(this.lxLed_Mtime);
            this.groupBox41.Controls.Add(this.label113);
            this.groupBox41.Controls.Add(this.lxLed_Mtag);
            this.groupBox41.Controls.Add(this.label116);
            this.groupBox41.Location = new System.Drawing.Point(3, 73);
            this.groupBox41.Name = "groupBox41";
            this.groupBox41.Size = new System.Drawing.Size(349, 224);
            this.groupBox41.TabIndex = 25;
            this.groupBox41.TabStop = false;
            this.groupBox41.Text = "Data";
            // 
            // lxLed_Mtime
            // 
            this.lxLed_Mtime.BackColor = System.Drawing.Color.Transparent;
            this.lxLed_Mtime.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLed_Mtime.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLed_Mtime.BevelRate = 0.5F;
            this.lxLed_Mtime.BorderColor = System.Drawing.Color.Lavender;
            this.lxLed_Mtime.BorderWidth = 3;
            this.lxLed_Mtime.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLed_Mtime.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLed_Mtime.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLed_Mtime.HighlightOpaque = ((byte)(50));
            this.lxLed_Mtime.Location = new System.Drawing.Point(22, 162);
            this.lxLed_Mtime.Name = "lxLed_Mtime";
            this.lxLed_Mtime.RoundCorner = true;
            this.lxLed_Mtime.ShowHighlight = true;
            this.lxLed_Mtime.Size = new System.Drawing.Size(175, 46);
            this.lxLed_Mtime.TabIndex = 32;
            this.lxLed_Mtime.Text = "0";
            this.lxLed_Mtime.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLed_Mtime.TotalCharCount = 7;
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label113.Location = new System.Drawing.Point(20, 135);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(95, 12);
            this.label113.TabIndex = 31;
            this.label113.Text = "Total Time(ms):";
            // 
            // lxLed_Mtag
            // 
            this.lxLed_Mtag.BackColor = System.Drawing.Color.Transparent;
            this.lxLed_Mtag.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLed_Mtag.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLed_Mtag.BevelRate = 0.5F;
            this.lxLed_Mtag.BorderColor = System.Drawing.Color.Lavender;
            this.lxLed_Mtag.BorderWidth = 3;
            this.lxLed_Mtag.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLed_Mtag.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLed_Mtag.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLed_Mtag.HighlightOpaque = ((byte)(50));
            this.lxLed_Mtag.Location = new System.Drawing.Point(22, 69);
            this.lxLed_Mtag.Name = "lxLed_Mtag";
            this.lxLed_Mtag.RoundCorner = true;
            this.lxLed_Mtag.ShowHighlight = true;
            this.lxLed_Mtag.Size = new System.Drawing.Size(175, 46);
            this.lxLed_Mtag.TabIndex = 22;
            this.lxLed_Mtag.Text = "0";
            this.lxLed_Mtag.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLed_Mtag.TotalCharCount = 7;
            // 
            // label116
            // 
            this.label116.AutoSize = true;
            this.label116.Location = new System.Drawing.Point(21, 41);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(71, 12);
            this.label116.TabIndex = 21;
            this.label116.Text = "Tag Number:";
            // 
            // groupBox42
            // 
            this.groupBox42.Controls.Add(this.btStartMactive);
            this.groupBox42.Location = new System.Drawing.Point(4, 0);
            this.groupBox42.Name = "groupBox42";
            this.groupBox42.Size = new System.Drawing.Size(348, 66);
            this.groupBox42.TabIndex = 24;
            this.groupBox42.TabStop = false;
            // 
            // btStartMactive
            // 
            this.btStartMactive.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btStartMactive.ForeColor = System.Drawing.Color.DarkBlue;
            this.btStartMactive.Location = new System.Drawing.Point(21, 16);
            this.btStartMactive.Name = "btStartMactive";
            this.btStartMactive.Size = new System.Drawing.Size(296, 40);
            this.btStartMactive.TabIndex = 0;
            this.btStartMactive.Text = "Start";
            this.btStartMactive.UseVisualStyleBackColor = true;
            this.btStartMactive.Click += new System.EventHandler(this.btStartMactive_Click);
            // 
            // tabPage_Buff
            // 
            this.tabPage_Buff.Controls.Add(this.panel8);
            this.tabPage_Buff.Location = new System.Drawing.Point(4, 27);
            this.tabPage_Buff.Name = "tabPage_Buff";
            this.tabPage_Buff.Size = new System.Drawing.Size(1063, 534);
            this.tabPage_Buff.TabIndex = 3;
            this.tabPage_Buff.Text = "Buffer operation";
            this.tabPage_Buff.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.groupBox27);
            this.panel8.Controls.Add(this.groupBox29);
            this.panel8.Controls.Add(this.dataGridView3);
            this.panel8.Controls.Add(this.groupBox30);
            this.panel8.Location = new System.Drawing.Point(-2, 1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1067, 531);
            this.panel8.TabIndex = 1;
            // 
            // groupBox27
            // 
            this.groupBox27.Controls.Add(this.btQueryBuffNum);
            this.groupBox27.Controls.Add(this.btRandCbuff);
            this.groupBox27.Controls.Add(this.btClearBuff);
            this.groupBox27.Controls.Add(this.btReadBuff);
            this.groupBox27.Location = new System.Drawing.Point(315, 5);
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.Size = new System.Drawing.Size(370, 71);
            this.groupBox27.TabIndex = 25;
            this.groupBox27.TabStop = false;
            // 
            // btQueryBuffNum
            // 
            this.btQueryBuffNum.ForeColor = System.Drawing.Color.Blue;
            this.btQueryBuffNum.Location = new System.Drawing.Point(194, 42);
            this.btQueryBuffNum.Name = "btQueryBuffNum";
            this.btQueryBuffNum.Size = new System.Drawing.Size(151, 23);
            this.btQueryBuffNum.TabIndex = 3;
            this.btQueryBuffNum.Text = "Get buffer tag number";
            this.btQueryBuffNum.UseVisualStyleBackColor = true;
            this.btQueryBuffNum.Click += new System.EventHandler(this.btQueryBuffNum_Click);
            // 
            // btRandCbuff
            // 
            this.btRandCbuff.ForeColor = System.Drawing.Color.Blue;
            this.btRandCbuff.Location = new System.Drawing.Point(194, 13);
            this.btRandCbuff.Name = "btRandCbuff";
            this.btRandCbuff.Size = new System.Drawing.Size(151, 23);
            this.btRandCbuff.TabIndex = 2;
            this.btRandCbuff.Text = "Read and Clear Buffer";
            this.btRandCbuff.UseVisualStyleBackColor = true;
            this.btRandCbuff.Click += new System.EventHandler(this.btRandCbuff_Click);
            // 
            // btClearBuff
            // 
            this.btClearBuff.ForeColor = System.Drawing.Color.Blue;
            this.btClearBuff.Location = new System.Drawing.Point(31, 42);
            this.btClearBuff.Name = "btClearBuff";
            this.btClearBuff.Size = new System.Drawing.Size(151, 23);
            this.btClearBuff.TabIndex = 1;
            this.btClearBuff.Text = "Clear Buffer";
            this.btClearBuff.UseVisualStyleBackColor = true;
            this.btClearBuff.Click += new System.EventHandler(this.btClearBuff_Click);
            // 
            // btReadBuff
            // 
            this.btReadBuff.ForeColor = System.Drawing.Color.Blue;
            this.btReadBuff.Location = new System.Drawing.Point(31, 13);
            this.btReadBuff.Name = "btReadBuff";
            this.btReadBuff.Size = new System.Drawing.Size(151, 23);
            this.btReadBuff.TabIndex = 0;
            this.btReadBuff.Text = "Read Buffer";
            this.btReadBuff.UseVisualStyleBackColor = true;
            this.btReadBuff.Click += new System.EventHandler(this.btReadBuff_Click);
            // 
            // groupBox29
            // 
            this.groupBox29.Controls.Add(this.rb_btid);
            this.groupBox29.Controls.Add(this.rb_bepc);
            this.groupBox29.Controls.Add(this.btStartBuff);
            this.groupBox29.Location = new System.Drawing.Point(8, 5);
            this.groupBox29.Name = "groupBox29";
            this.groupBox29.Size = new System.Drawing.Size(307, 71);
            this.groupBox29.TabIndex = 23;
            this.groupBox29.TabStop = false;
            // 
            // rb_btid
            // 
            this.rb_btid.AutoSize = true;
            this.rb_btid.Location = new System.Drawing.Point(214, 42);
            this.rb_btid.Name = "rb_btid";
            this.rb_btid.Size = new System.Drawing.Size(41, 16);
            this.rb_btid.TabIndex = 2;
            this.rb_btid.Text = "TID";
            this.rb_btid.UseVisualStyleBackColor = true;
            // 
            // rb_bepc
            // 
            this.rb_bepc.AutoSize = true;
            this.rb_bepc.Checked = true;
            this.rb_bepc.Location = new System.Drawing.Point(214, 20);
            this.rb_bepc.Name = "rb_bepc";
            this.rb_bepc.Size = new System.Drawing.Size(41, 16);
            this.rb_bepc.TabIndex = 1;
            this.rb_bepc.TabStop = true;
            this.rb_bepc.Text = "EPC";
            this.rb_bepc.UseVisualStyleBackColor = true;
            // 
            // btStartBuff
            // 
            this.btStartBuff.BackColor = System.Drawing.Color.Transparent;
            this.btStartBuff.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btStartBuff.ForeColor = System.Drawing.Color.DarkBlue;
            this.btStartBuff.Location = new System.Drawing.Point(18, 20);
            this.btStartBuff.Name = "btStartBuff";
            this.btStartBuff.Size = new System.Drawing.Size(171, 40);
            this.btStartBuff.TabIndex = 0;
            this.btStartBuff.Text = "Start";
            this.btStartBuff.UseVisualStyleBackColor = false;
            this.btStartBuff.Click += new System.EventHandler(this.btStartBuff_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.Column7});
            this.dataGridView3.Location = new System.Drawing.Point(3, 290);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(1057, 232);
            this.dataGridView3.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "No.";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "EPC";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn6.Width = 520;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Lenth";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "RSSI";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "RSSI";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Times";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // groupBox30
            // 
            this.groupBox30.Controls.Add(this.lxLed_cmdTime);
            this.groupBox30.Controls.Add(this.label86);
            this.groupBox30.Controls.Add(this.lxLed_Btoltime);
            this.groupBox30.Controls.Add(this.label83);
            this.groupBox30.Controls.Add(this.label91);
            this.groupBox30.Controls.Add(this.lxLed_Btoltag);
            this.groupBox30.Controls.Add(this.label92);
            this.groupBox30.Controls.Add(this.lxLed_Bcmdsud);
            this.groupBox30.Controls.Add(this.label94);
            this.groupBox30.Controls.Add(this.lxLed_BNum);
            this.groupBox30.Controls.Add(this.label95);
            this.groupBox30.Location = new System.Drawing.Point(7, 81);
            this.groupBox30.Name = "groupBox30";
            this.groupBox30.Size = new System.Drawing.Size(1053, 447);
            this.groupBox30.TabIndex = 20;
            this.groupBox30.TabStop = false;
            // 
            // lxLed_cmdTime
            // 
            this.lxLed_cmdTime.BackColor = System.Drawing.Color.Transparent;
            this.lxLed_cmdTime.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLed_cmdTime.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLed_cmdTime.BevelRate = 0.5F;
            this.lxLed_cmdTime.BorderColor = System.Drawing.Color.Lavender;
            this.lxLed_cmdTime.BorderWidth = 3;
            this.lxLed_cmdTime.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLed_cmdTime.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLed_cmdTime.ForeColor = System.Drawing.Color.Purple;
            this.lxLed_cmdTime.HighlightOpaque = ((byte)(50));
            this.lxLed_cmdTime.Location = new System.Drawing.Point(492, 129);
            this.lxLed_cmdTime.Name = "lxLed_cmdTime";
            this.lxLed_cmdTime.RoundCorner = true;
            this.lxLed_cmdTime.ShowHighlight = true;
            this.lxLed_cmdTime.Size = new System.Drawing.Size(146, 38);
            this.lxLed_cmdTime.TabIndex = 34;
            this.lxLed_cmdTime.Text = "0";
            this.lxLed_cmdTime.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLed_cmdTime.TotalCharCount = 7;
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.ForeColor = System.Drawing.Color.Teal;
            this.label86.Location = new System.Drawing.Point(490, 114);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(83, 12);
            this.label86.TabIndex = 33;
            this.label86.Text = "cmd time(ms):";
            // 
            // lxLed_Btoltime
            // 
            this.lxLed_Btoltime.BackColor = System.Drawing.Color.Transparent;
            this.lxLed_Btoltime.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLed_Btoltime.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLed_Btoltime.BevelRate = 0.5F;
            this.lxLed_Btoltime.BorderColor = System.Drawing.Color.Lavender;
            this.lxLed_Btoltime.BorderWidth = 3;
            this.lxLed_Btoltime.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLed_Btoltime.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLed_Btoltime.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLed_Btoltime.HighlightOpaque = ((byte)(50));
            this.lxLed_Btoltime.Location = new System.Drawing.Point(749, 137);
            this.lxLed_Btoltime.Name = "lxLed_Btoltime";
            this.lxLed_Btoltime.RoundCorner = true;
            this.lxLed_Btoltime.ShowHighlight = true;
            this.lxLed_Btoltime.Size = new System.Drawing.Size(162, 30);
            this.lxLed_Btoltime.TabIndex = 32;
            this.lxLed_Btoltime.Text = "0";
            this.lxLed_Btoltime.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLed_Btoltime.TotalCharCount = 10;
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label83.Location = new System.Drawing.Point(5, 179);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(59, 12);
            this.label83.TabIndex = 22;
            this.label83.Text = "Tag List:";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.ForeColor = System.Drawing.Color.Teal;
            this.label91.Location = new System.Drawing.Point(747, 117);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(95, 12);
            this.label91.TabIndex = 31;
            this.label91.Text = "Total time(ms):";
            // 
            // lxLed_Btoltag
            // 
            this.lxLed_Btoltag.BackColor = System.Drawing.Color.Transparent;
            this.lxLed_Btoltag.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLed_Btoltag.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLed_Btoltag.BevelRate = 0.5F;
            this.lxLed_Btoltag.BorderColor = System.Drawing.Color.Lavender;
            this.lxLed_Btoltag.BorderWidth = 3;
            this.lxLed_Btoltag.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLed_Btoltag.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLed_Btoltag.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLed_Btoltag.HighlightOpaque = ((byte)(50));
            this.lxLed_Btoltag.Location = new System.Drawing.Point(749, 68);
            this.lxLed_Btoltag.Name = "lxLed_Btoltag";
            this.lxLed_Btoltag.RoundCorner = true;
            this.lxLed_Btoltag.ShowHighlight = true;
            this.lxLed_Btoltag.Size = new System.Drawing.Size(162, 30);
            this.lxLed_Btoltag.TabIndex = 30;
            this.lxLed_Btoltag.Text = "0";
            this.lxLed_Btoltag.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLed_Btoltag.TotalCharCount = 10;
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.ForeColor = System.Drawing.Color.Teal;
            this.label92.Location = new System.Drawing.Point(747, 50);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(83, 12);
            this.label92.TabIndex = 29;
            this.label92.Text = "Total number:";
            // 
            // lxLed_Bcmdsud
            // 
            this.lxLed_Bcmdsud.BackColor = System.Drawing.Color.Transparent;
            this.lxLed_Bcmdsud.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLed_Bcmdsud.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLed_Bcmdsud.BevelRate = 0.5F;
            this.lxLed_Bcmdsud.BorderColor = System.Drawing.Color.Lavender;
            this.lxLed_Bcmdsud.BorderWidth = 3;
            this.lxLed_Bcmdsud.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLed_Bcmdsud.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLed_Bcmdsud.ForeColor = System.Drawing.Color.Purple;
            this.lxLed_Bcmdsud.HighlightOpaque = ((byte)(50));
            this.lxLed_Bcmdsud.Location = new System.Drawing.Point(492, 60);
            this.lxLed_Bcmdsud.Name = "lxLed_Bcmdsud";
            this.lxLed_Bcmdsud.RoundCorner = true;
            this.lxLed_Bcmdsud.ShowHighlight = true;
            this.lxLed_Bcmdsud.Size = new System.Drawing.Size(146, 38);
            this.lxLed_Bcmdsud.TabIndex = 26;
            this.lxLed_Bcmdsud.Text = "0";
            this.lxLed_Bcmdsud.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLed_Bcmdsud.TotalCharCount = 7;
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.ForeColor = System.Drawing.Color.Teal;
            this.label94.Location = new System.Drawing.Point(490, 41);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(41, 12);
            this.label94.TabIndex = 25;
            this.label94.Text = "Speed:";
            // 
            // lxLed_BNum
            // 
            this.lxLed_BNum.BackColor = System.Drawing.Color.Transparent;
            this.lxLed_BNum.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLed_BNum.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLed_BNum.BevelRate = 0.5F;
            this.lxLed_BNum.BorderColor = System.Drawing.Color.Lavender;
            this.lxLed_BNum.BorderWidth = 3;
            this.lxLed_BNum.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLed_BNum.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLed_BNum.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLed_BNum.HighlightOpaque = ((byte)(50));
            this.lxLed_BNum.Location = new System.Drawing.Point(101, 40);
            this.lxLed_BNum.Name = "lxLed_BNum";
            this.lxLed_BNum.RoundCorner = true;
            this.lxLed_BNum.ShowHighlight = true;
            this.lxLed_BNum.Size = new System.Drawing.Size(329, 127);
            this.lxLed_BNum.TabIndex = 22;
            this.lxLed_BNum.Text = "0";
            this.lxLed_BNum.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Location = new System.Drawing.Point(99, 22);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(71, 12);
            this.label95.TabIndex = 21;
            this.label95.Text = "Tag Number:";
            // 
            // tabPage_RW
            // 
            this.tabPage_RW.Controls.Add(this.panel4);
            this.tabPage_RW.Location = new System.Drawing.Point(4, 27);
            this.tabPage_RW.Name = "tabPage_RW";
            this.tabPage_RW.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_RW.Size = new System.Drawing.Size(1063, 534);
            this.tabPage_RW.TabIndex = 2;
            this.tabPage_RW.Text = "Read/Write Tag";
            this.tabPage_RW.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox21);
            this.panel4.Controls.Add(this.groupBox20);
            this.panel4.Controls.Add(this.groupBox18);
            this.panel4.Controls.Add(this.groupBox16);
            this.panel4.Controls.Add(this.groupBox13);
            this.panel4.Controls.Add(this.groupBox11);
            this.panel4.Controls.Add(this.groupBox31);
            this.panel4.Controls.Add(this.groupBox10);
            this.panel4.Location = new System.Drawing.Point(-2, -3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1067, 562);
            this.panel4.TabIndex = 0;
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.btCheckReadProtected_G2);
            this.groupBox21.Controls.Add(this.btRemoveReadProtect_G2);
            this.groupBox21.Controls.Add(this.btSetMultiReadProtect_G2);
            this.groupBox21.Controls.Add(this.btSetReadProtect_G2);
            this.groupBox21.Controls.Add(this.text_AccessCode4);
            this.groupBox21.Controls.Add(this.label34);
            this.groupBox21.Location = new System.Drawing.Point(346, 361);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(310, 146);
            this.groupBox21.TabIndex = 23;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Read Protection-NXP";
            // 
            // btCheckReadProtected_G2
            // 
            this.btCheckReadProtected_G2.Location = new System.Drawing.Point(12, 119);
            this.btCheckReadProtected_G2.Name = "btCheckReadProtected_G2";
            this.btCheckReadProtected_G2.Size = new System.Drawing.Size(285, 23);
            this.btCheckReadProtected_G2.TabIndex = 6;
            this.btCheckReadProtected_G2.Text = "Detect Privacy   ";
            this.btCheckReadProtected_G2.UseVisualStyleBackColor = true;
            this.btCheckReadProtected_G2.Click += new System.EventHandler(this.btCheckReadProtected_G2_Click);
            // 
            // btRemoveReadProtect_G2
            // 
            this.btRemoveReadProtect_G2.Location = new System.Drawing.Point(12, 94);
            this.btRemoveReadProtect_G2.Name = "btRemoveReadProtect_G2";
            this.btRemoveReadProtect_G2.Size = new System.Drawing.Size(285, 23);
            this.btRemoveReadProtect_G2.TabIndex = 5;
            this.btRemoveReadProtect_G2.Text = "Reset Privacy";
            this.btRemoveReadProtect_G2.UseVisualStyleBackColor = true;
            this.btRemoveReadProtect_G2.Click += new System.EventHandler(this.btRemoveReadProtect_G2_Click);
            // 
            // btSetMultiReadProtect_G2
            // 
            this.btSetMultiReadProtect_G2.Location = new System.Drawing.Point(12, 68);
            this.btSetMultiReadProtect_G2.Name = "btSetMultiReadProtect_G2";
            this.btSetMultiReadProtect_G2.Size = new System.Drawing.Size(285, 23);
            this.btSetMultiReadProtect_G2.TabIndex = 4;
            this.btSetMultiReadProtect_G2.Text = "Set Privacy Without EPC";
            this.btSetMultiReadProtect_G2.UseVisualStyleBackColor = true;
            this.btSetMultiReadProtect_G2.Click += new System.EventHandler(this.btSetMultiReadProtect_G2_Click);
            // 
            // btSetReadProtect_G2
            // 
            this.btSetReadProtect_G2.Location = new System.Drawing.Point(12, 41);
            this.btSetReadProtect_G2.Name = "btSetReadProtect_G2";
            this.btSetReadProtect_G2.Size = new System.Drawing.Size(285, 23);
            this.btSetReadProtect_G2.TabIndex = 3;
            this.btSetReadProtect_G2.Text = "Set Privacy By EPC";
            this.btSetReadProtect_G2.UseVisualStyleBackColor = true;
            this.btSetReadProtect_G2.Click += new System.EventHandler(this.btSetReadProtect_G2_Click);
            // 
            // text_AccessCode4
            // 
            this.text_AccessCode4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_AccessCode4.Location = new System.Drawing.Point(196, 14);
            this.text_AccessCode4.MaxLength = 8;
            this.text_AccessCode4.Name = "text_AccessCode4";
            this.text_AccessCode4.Size = new System.Drawing.Size(100, 21);
            this.text_AccessCode4.TabIndex = 2;
            this.text_AccessCode4.Text = "00000000";
            this.text_AccessCode4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(15, 20);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(95, 12);
            this.label34.TabIndex = 1;
            this.label34.Text = "Password:(Hex):";
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.btWriteEPC_G2);
            this.groupBox20.Controls.Add(this.text_AccessCode3);
            this.groupBox20.Controls.Add(this.label27);
            this.groupBox20.Controls.Add(this.text_WriteEPC);
            this.groupBox20.Controls.Add(this.label33);
            this.groupBox20.Location = new System.Drawing.Point(8, 427);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(332, 79);
            this.groupBox20.TabIndex = 22;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Write EPC";
            // 
            // btWriteEPC_G2
            // 
            this.btWriteEPC_G2.Location = new System.Drawing.Point(229, 44);
            this.btWriteEPC_G2.Name = "btWriteEPC_G2";
            this.btWriteEPC_G2.Size = new System.Drawing.Size(90, 23);
            this.btWriteEPC_G2.TabIndex = 4;
            this.btWriteEPC_G2.Text = "Write EPC";
            this.btWriteEPC_G2.UseVisualStyleBackColor = true;
            this.btWriteEPC_G2.Click += new System.EventHandler(this.btWriteEPC_G2_Click);
            // 
            // text_AccessCode3
            // 
            this.text_AccessCode3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_AccessCode3.Location = new System.Drawing.Point(155, 44);
            this.text_AccessCode3.MaxLength = 8;
            this.text_AccessCode3.Name = "text_AccessCode3";
            this.text_AccessCode3.Size = new System.Drawing.Size(57, 21);
            this.text_AccessCode3.TabIndex = 3;
            this.text_AccessCode3.Text = "00000000";
            this.text_AccessCode3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(5, 50);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(95, 12);
            this.label27.TabIndex = 2;
            this.label27.Text = "Password:(Hex):";
            // 
            // text_WriteEPC
            // 
            this.text_WriteEPC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_WriteEPC.Location = new System.Drawing.Point(77, 17);
            this.text_WriteEPC.MaxLength = 60;
            this.text_WriteEPC.Name = "text_WriteEPC";
            this.text_WriteEPC.Size = new System.Drawing.Size(242, 21);
            this.text_WriteEPC.TabIndex = 1;
            this.text_WriteEPC.Text = "0000";
            this.text_WriteEPC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(6, 21);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(29, 12);
            this.label33.TabIndex = 0;
            this.label33.Text = "EPC:";
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.btDestroyCard);
            this.groupBox18.Controls.Add(this.text_DestroyCode);
            this.groupBox18.Controls.Add(this.label26);
            this.groupBox18.Location = new System.Drawing.Point(8, 361);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(332, 56);
            this.groupBox18.TabIndex = 20;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Kill Tag";
            // 
            // btDestroyCard
            // 
            this.btDestroyCard.Location = new System.Drawing.Point(229, 21);
            this.btDestroyCard.Name = "btDestroyCard";
            this.btDestroyCard.Size = new System.Drawing.Size(90, 23);
            this.btDestroyCard.TabIndex = 3;
            this.btDestroyCard.Text = "Kill tag";
            this.btDestroyCard.UseVisualStyleBackColor = true;
            this.btDestroyCard.Click += new System.EventHandler(this.btDestroyCard_Click);
            // 
            // text_DestroyCode
            // 
            this.text_DestroyCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_DestroyCode.Location = new System.Drawing.Point(155, 23);
            this.text_DestroyCode.MaxLength = 8;
            this.text_DestroyCode.Name = "text_DestroyCode";
            this.text_DestroyCode.Size = new System.Drawing.Size(56, 21);
            this.text_DestroyCode.TabIndex = 2;
            this.text_DestroyCode.Text = "00000000";
            this.text_DestroyCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 26);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(119, 12);
            this.label26.TabIndex = 1;
            this.label26.Text = "Kill Password:(Hex)";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.pictureBox2);
            this.groupBox16.Controls.Add(this.btCheckEASAlarm);
            this.groupBox16.Controls.Add(this.btSetEASAlarm_G2);
            this.groupBox16.Controls.Add(this.groupBox17);
            this.groupBox16.Controls.Add(this.text_AccessCode5);
            this.groupBox16.Controls.Add(this.label28);
            this.groupBox16.Location = new System.Drawing.Point(662, 239);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(397, 267);
            this.groupBox16.TabIndex = 19;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "EAS Alarm";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(63, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(137, 137);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // btCheckEASAlarm
            // 
            this.btCheckEASAlarm.Location = new System.Drawing.Point(280, 78);
            this.btCheckEASAlarm.Name = "btCheckEASAlarm";
            this.btCheckEASAlarm.Size = new System.Drawing.Size(90, 23);
            this.btCheckEASAlarm.TabIndex = 13;
            this.btCheckEASAlarm.Text = "Detect";
            this.btCheckEASAlarm.UseVisualStyleBackColor = true;
            this.btCheckEASAlarm.Click += new System.EventHandler(this.btCheckEASAlarm_Click);
            // 
            // btSetEASAlarm_G2
            // 
            this.btSetEASAlarm_G2.Location = new System.Drawing.Point(280, 25);
            this.btSetEASAlarm_G2.Name = "btSetEASAlarm_G2";
            this.btSetEASAlarm_G2.Size = new System.Drawing.Size(90, 23);
            this.btSetEASAlarm_G2.TabIndex = 12;
            this.btSetEASAlarm_G2.Text = "Configure";
            this.btSetEASAlarm_G2.UseVisualStyleBackColor = true;
            this.btSetEASAlarm_G2.Click += new System.EventHandler(this.btSetEASAlarm_G2_Click);
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.NoAlarm_G2);
            this.groupBox17.Controls.Add(this.Alarm_G2);
            this.groupBox17.Location = new System.Drawing.Point(9, 47);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(249, 54);
            this.groupBox17.TabIndex = 11;
            this.groupBox17.TabStop = false;
            // 
            // NoAlarm_G2
            // 
            this.NoAlarm_G2.AutoSize = true;
            this.NoAlarm_G2.Location = new System.Drawing.Point(113, 20);
            this.NoAlarm_G2.Name = "NoAlarm_G2";
            this.NoAlarm_G2.Size = new System.Drawing.Size(71, 16);
            this.NoAlarm_G2.TabIndex = 1;
            this.NoAlarm_G2.Text = "No Alarm";
            this.NoAlarm_G2.UseVisualStyleBackColor = true;
            // 
            // Alarm_G2
            // 
            this.Alarm_G2.AutoSize = true;
            this.Alarm_G2.Checked = true;
            this.Alarm_G2.Location = new System.Drawing.Point(6, 20);
            this.Alarm_G2.Name = "Alarm_G2";
            this.Alarm_G2.Size = new System.Drawing.Size(53, 16);
            this.Alarm_G2.TabIndex = 0;
            this.Alarm_G2.TabStop = true;
            this.Alarm_G2.Text = "Alarm";
            this.Alarm_G2.UseVisualStyleBackColor = true;
            // 
            // text_AccessCode5
            // 
            this.text_AccessCode5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_AccessCode5.Location = new System.Drawing.Point(158, 22);
            this.text_AccessCode5.MaxLength = 8;
            this.text_AccessCode5.Name = "text_AccessCode5";
            this.text_AccessCode5.Size = new System.Drawing.Size(100, 21);
            this.text_AccessCode5.TabIndex = 10;
            this.text_AccessCode5.Text = "00000000";
            this.text_AccessCode5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 26);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(95, 12);
            this.label28.TabIndex = 9;
            this.label28.Text = "Password:(Hex):";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.btSetProtectState);
            this.groupBox13.Controls.Add(this.Edit_AccessCode6);
            this.groupBox13.Controls.Add(this.label25);
            this.groupBox13.Controls.Add(this.groupBox14);
            this.groupBox13.Controls.Add(this.groupBox15);
            this.groupBox13.Location = new System.Drawing.Point(5, 239);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(651, 121);
            this.groupBox13.TabIndex = 18;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Set Protect For Reading Or Writing";
            // 
            // btSetProtectState
            // 
            this.btSetProtectState.Location = new System.Drawing.Point(551, 84);
            this.btSetProtectState.Name = "btSetProtectState";
            this.btSetProtectState.Size = new System.Drawing.Size(90, 23);
            this.btSetProtectState.TabIndex = 6;
            this.btSetProtectState.Text = "Lock";
            this.btSetProtectState.UseVisualStyleBackColor = true;
            this.btSetProtectState.Click += new System.EventHandler(this.btSetProtectState_Click);
            // 
            // Edit_AccessCode6
            // 
            this.Edit_AccessCode6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Edit_AccessCode6.Location = new System.Drawing.Point(551, 44);
            this.Edit_AccessCode6.MaxLength = 8;
            this.Edit_AccessCode6.Name = "Edit_AccessCode6";
            this.Edit_AccessCode6.Size = new System.Drawing.Size(90, 21);
            this.Edit_AccessCode6.TabIndex = 5;
            this.Edit_AccessCode6.Text = "00000000";
            this.Edit_AccessCode6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(503, 17);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(95, 12);
            this.label25.TabIndex = 4;
            this.label25.Text = "Password:(Hex):";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.AlwaysNot2);
            this.groupBox14.Controls.Add(this.Always2);
            this.groupBox14.Controls.Add(this.Proect2);
            this.groupBox14.Controls.Add(this.NoProect2);
            this.groupBox14.Location = new System.Drawing.Point(4, 68);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(476, 44);
            this.groupBox14.TabIndex = 3;
            this.groupBox14.TabStop = false;
            // 
            // AlwaysNot2
            // 
            this.AlwaysNot2.AutoSize = true;
            this.AlwaysNot2.Location = new System.Drawing.Point(321, 18);
            this.AlwaysNot2.Name = "AlwaysNot2";
            this.AlwaysNot2.Size = new System.Drawing.Size(95, 16);
            this.AlwaysNot2.TabIndex = 3;
            this.AlwaysNot2.Text = "Lock forever\n";
            this.AlwaysNot2.UseVisualStyleBackColor = true;
            // 
            // Always2
            // 
            this.Always2.AutoSize = true;
            this.Always2.Location = new System.Drawing.Point(178, 18);
            this.Always2.Name = "Always2";
            this.Always2.Size = new System.Drawing.Size(107, 16);
            this.Always2.TabIndex = 2;
            this.Always2.Text = "Unlock forever\n";
            this.Always2.UseVisualStyleBackColor = true;
            // 
            // Proect2
            // 
            this.Proect2.AutoSize = true;
            this.Proect2.Location = new System.Drawing.Point(98, 18);
            this.Proect2.Name = "Proect2";
            this.Proect2.Size = new System.Drawing.Size(47, 16);
            this.Proect2.TabIndex = 1;
            this.Proect2.Text = "Lock";
            this.Proect2.UseVisualStyleBackColor = true;
            // 
            // NoProect2
            // 
            this.NoProect2.AutoSize = true;
            this.NoProect2.Checked = true;
            this.NoProect2.Location = new System.Drawing.Point(9, 18);
            this.NoProect2.Name = "NoProect2";
            this.NoProect2.Size = new System.Drawing.Size(59, 16);
            this.NoProect2.TabIndex = 0;
            this.NoProect2.TabStop = true;
            this.NoProect2.Text = "UnLock";
            this.NoProect2.UseVisualStyleBackColor = true;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.p_pass);
            this.groupBox15.Controls.Add(this.P_User);
            this.groupBox15.Controls.Add(this.P_TID);
            this.groupBox15.Controls.Add(this.P_EPC);
            this.groupBox15.Controls.Add(this.P_kill);
            this.groupBox15.Location = new System.Drawing.Point(4, 13);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(476, 52);
            this.groupBox15.TabIndex = 2;
            this.groupBox15.TabStop = false;
            // 
            // p_pass
            // 
            this.p_pass.AutoSize = true;
            this.p_pass.Checked = true;
            this.p_pass.Location = new System.Drawing.Point(133, 18);
            this.p_pass.Name = "p_pass";
            this.p_pass.Size = new System.Drawing.Size(113, 16);
            this.p_pass.TabIndex = 4;
            this.p_pass.TabStop = true;
            this.p_pass.Text = "Access Password";
            this.p_pass.UseVisualStyleBackColor = true;
            // 
            // P_User
            // 
            this.P_User.AutoSize = true;
            this.P_User.Location = new System.Drawing.Point(404, 18);
            this.P_User.Name = "P_User";
            this.P_User.Size = new System.Drawing.Size(47, 16);
            this.P_User.TabIndex = 3;
            this.P_User.Text = "User";
            this.P_User.UseVisualStyleBackColor = true;
            // 
            // P_TID
            // 
            this.P_TID.AutoSize = true;
            this.P_TID.Location = new System.Drawing.Point(341, 18);
            this.P_TID.Name = "P_TID";
            this.P_TID.Size = new System.Drawing.Size(41, 16);
            this.P_TID.TabIndex = 2;
            this.P_TID.Text = "TID";
            this.P_TID.UseVisualStyleBackColor = true;
            // 
            // P_EPC
            // 
            this.P_EPC.AutoSize = true;
            this.P_EPC.Location = new System.Drawing.Point(276, 18);
            this.P_EPC.Name = "P_EPC";
            this.P_EPC.Size = new System.Drawing.Size(41, 16);
            this.P_EPC.TabIndex = 1;
            this.P_EPC.Text = "EPC";
            this.P_EPC.UseVisualStyleBackColor = true;
            // 
            // P_kill
            // 
            this.P_kill.AutoSize = true;
            this.P_kill.Location = new System.Drawing.Point(9, 18);
            this.P_kill.Name = "P_kill";
            this.P_kill.Size = new System.Drawing.Size(101, 16);
            this.P_kill.TabIndex = 0;
            this.P_kill.Text = "Kill Password";
            this.P_kill.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.btExtWrite);
            this.groupBox11.Controls.Add(this.btExtRead);
            this.groupBox11.Controls.Add(this.textBox_pc);
            this.groupBox11.Controls.Add(this.checkBox_pc);
            this.groupBox11.Controls.Add(this.btBlockWrite);
            this.groupBox11.Controls.Add(this.btBlockErase);
            this.groupBox11.Controls.Add(this.btWrite);
            this.groupBox11.Controls.Add(this.btRead);
            this.groupBox11.Controls.Add(this.text_WriteData);
            this.groupBox11.Controls.Add(this.text_AccessCode2);
            this.groupBox11.Controls.Add(this.text_RWlen);
            this.groupBox11.Controls.Add(this.text_WordPtr);
            this.groupBox11.Controls.Add(this.label21);
            this.groupBox11.Controls.Add(this.label22);
            this.groupBox11.Controls.Add(this.label23);
            this.groupBox11.Controls.Add(this.label24);
            this.groupBox11.Controls.Add(this.groupBox12);
            this.groupBox11.Location = new System.Drawing.Point(5, 119);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(1055, 119);
            this.groupBox11.TabIndex = 17;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Read Data / Write Data / Block Erase";
            // 
            // btExtWrite
            // 
            this.btExtWrite.Location = new System.Drawing.Point(950, 92);
            this.btExtWrite.Name = "btExtWrite";
            this.btExtWrite.Size = new System.Drawing.Size(77, 23);
            this.btExtWrite.TabIndex = 33;
            this.btExtWrite.Text = "Ext Write";
            this.btExtWrite.UseVisualStyleBackColor = true;
            this.btExtWrite.Click += new System.EventHandler(this.btExtWrite_Click);
            // 
            // btExtRead
            // 
            this.btExtRead.Location = new System.Drawing.Point(950, 55);
            this.btExtRead.Name = "btExtRead";
            this.btExtRead.Size = new System.Drawing.Size(77, 23);
            this.btExtRead.TabIndex = 32;
            this.btExtRead.Text = "Ext Read";
            this.btExtRead.UseVisualStyleBackColor = true;
            this.btExtRead.Click += new System.EventHandler(this.btExtRead_Click);
            // 
            // textBox_pc
            // 
            this.textBox_pc.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_pc.Location = new System.Drawing.Point(616, 57);
            this.textBox_pc.Name = "textBox_pc";
            this.textBox_pc.ReadOnly = true;
            this.textBox_pc.Size = new System.Drawing.Size(138, 21);
            this.textBox_pc.TabIndex = 29;
            this.textBox_pc.Text = "0800";
            // 
            // checkBox_pc
            // 
            this.checkBox_pc.AutoSize = true;
            this.checkBox_pc.Location = new System.Drawing.Point(405, 59);
            this.checkBox_pc.Name = "checkBox_pc";
            this.checkBox_pc.Size = new System.Drawing.Size(162, 16);
            this.checkBox_pc.TabIndex = 28;
            this.checkBox_pc.Text = "Auto Compute and add PC";
            this.checkBox_pc.UseVisualStyleBackColor = true;
            this.checkBox_pc.CheckedChanged += new System.EventHandler(this.checkBox_pc_CheckedChanged);
            // 
            // btBlockWrite
            // 
            this.btBlockWrite.Location = new System.Drawing.Point(770, 92);
            this.btBlockWrite.Name = "btBlockWrite";
            this.btBlockWrite.Size = new System.Drawing.Size(77, 23);
            this.btBlockWrite.TabIndex = 17;
            this.btBlockWrite.Text = "BlockWrite";
            this.btBlockWrite.UseVisualStyleBackColor = true;
            this.btBlockWrite.Click += new System.EventHandler(this.btBlockWrite_Click);
            // 
            // btBlockErase
            // 
            this.btBlockErase.Location = new System.Drawing.Point(861, 92);
            this.btBlockErase.Name = "btBlockErase";
            this.btBlockErase.Size = new System.Drawing.Size(77, 23);
            this.btBlockErase.TabIndex = 13;
            this.btBlockErase.Text = "BlockErace";
            this.btBlockErase.UseVisualStyleBackColor = true;
            this.btBlockErase.Click += new System.EventHandler(this.btBlockErase_Click);
            // 
            // btWrite
            // 
            this.btWrite.Location = new System.Drawing.Point(861, 55);
            this.btWrite.Name = "btWrite";
            this.btWrite.Size = new System.Drawing.Size(77, 23);
            this.btWrite.TabIndex = 12;
            this.btWrite.Text = "Write";
            this.btWrite.UseVisualStyleBackColor = true;
            this.btWrite.Click += new System.EventHandler(this.btWrite_Click);
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(770, 55);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(77, 23);
            this.btRead.TabIndex = 11;
            this.btRead.Text = "Read";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // text_WriteData
            // 
            this.text_WriteData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_WriteData.Location = new System.Drawing.Point(529, 20);
            this.text_WriteData.Name = "text_WriteData";
            this.text_WriteData.Size = new System.Drawing.Size(504, 21);
            this.text_WriteData.TabIndex = 10;
            this.text_WriteData.Text = "0000";
            this.text_WriteData.TextChanged += new System.EventHandler(this.text_WriteData_TextChanged);
            this.text_WriteData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // text_AccessCode2
            // 
            this.text_AccessCode2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_AccessCode2.Location = new System.Drawing.Point(205, 87);
            this.text_AccessCode2.MaxLength = 8;
            this.text_AccessCode2.Name = "text_AccessCode2";
            this.text_AccessCode2.Size = new System.Drawing.Size(118, 21);
            this.text_AccessCode2.TabIndex = 9;
            this.text_AccessCode2.Text = "00000000";
            this.text_AccessCode2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // text_RWlen
            // 
            this.text_RWlen.Location = new System.Drawing.Point(205, 57);
            this.text_RWlen.MaxLength = 2;
            this.text_RWlen.Name = "text_RWlen";
            this.text_RWlen.Size = new System.Drawing.Size(117, 21);
            this.text_RWlen.TabIndex = 8;
            this.text_RWlen.Text = "4";
            this.text_RWlen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // text_WordPtr
            // 
            this.text_WordPtr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_WordPtr.Location = new System.Drawing.Point(205, 19);
            this.text_WordPtr.MaxLength = 4;
            this.text_WordPtr.Name = "text_WordPtr";
            this.text_WordPtr.Size = new System.Drawing.Size(117, 21);
            this.text_WordPtr.TabIndex = 7;
            this.text_WordPtr.Text = "0000";
            this.text_WordPtr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(402, 23);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(131, 12);
            this.label21.TabIndex = 5;
            this.label21.Text = "Read/Write data(Hex):";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 91);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(95, 12);
            this.label22.TabIndex = 4;
            this.label22.Text = "Password:(Hex):";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 61);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 12);
            this.label23.TabIndex = 3;
            this.label23.Text = "Length(Dec):";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 23);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(125, 12);
            this.label24.TabIndex = 2;
            this.label24.Text = "Start address:(Hex):";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.C_User);
            this.groupBox12.Controls.Add(this.C_TID);
            this.groupBox12.Controls.Add(this.C_EPC);
            this.groupBox12.Controls.Add(this.C_Reserve);
            this.groupBox12.Location = new System.Drawing.Point(402, 81);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(353, 31);
            this.groupBox12.TabIndex = 1;
            this.groupBox12.TabStop = false;
            // 
            // C_User
            // 
            this.C_User.AutoSize = true;
            this.C_User.Location = new System.Drawing.Point(207, 11);
            this.C_User.Name = "C_User";
            this.C_User.Size = new System.Drawing.Size(47, 16);
            this.C_User.TabIndex = 3;
            this.C_User.Text = "User";
            this.C_User.UseVisualStyleBackColor = true;
            this.C_User.CheckedChanged += new System.EventHandler(this.C_EPC_CheckedChanged);
            // 
            // C_TID
            // 
            this.C_TID.AutoSize = true;
            this.C_TID.Location = new System.Drawing.Point(149, 11);
            this.C_TID.Name = "C_TID";
            this.C_TID.Size = new System.Drawing.Size(41, 16);
            this.C_TID.TabIndex = 2;
            this.C_TID.Text = "TID";
            this.C_TID.UseVisualStyleBackColor = true;
            this.C_TID.CheckedChanged += new System.EventHandler(this.C_EPC_CheckedChanged);
            // 
            // C_EPC
            // 
            this.C_EPC.AutoSize = true;
            this.C_EPC.Checked = true;
            this.C_EPC.Location = new System.Drawing.Point(90, 11);
            this.C_EPC.Name = "C_EPC";
            this.C_EPC.Size = new System.Drawing.Size(41, 16);
            this.C_EPC.TabIndex = 1;
            this.C_EPC.TabStop = true;
            this.C_EPC.Text = "EPC";
            this.C_EPC.UseVisualStyleBackColor = true;
            this.C_EPC.CheckedChanged += new System.EventHandler(this.C_EPC_CheckedChanged);
            // 
            // C_Reserve
            // 
            this.C_Reserve.AutoSize = true;
            this.C_Reserve.Location = new System.Drawing.Point(4, 11);
            this.C_Reserve.Name = "C_Reserve";
            this.C_Reserve.Size = new System.Drawing.Size(71, 16);
            this.C_Reserve.TabIndex = 0;
            this.C_Reserve.Text = "Password";
            this.C_Reserve.UseVisualStyleBackColor = true;
            this.C_Reserve.CheckedChanged += new System.EventHandler(this.C_EPC_CheckedChanged);
            // 
            // groupBox31
            // 
            this.groupBox31.Controls.Add(this.maskData_textBox);
            this.groupBox31.Controls.Add(this.label60);
            this.groupBox31.Controls.Add(this.groupBox40);
            this.groupBox31.Controls.Add(this.checkBox1);
            this.groupBox31.Controls.Add(this.maskLen_textBox);
            this.groupBox31.Controls.Add(this.label44);
            this.groupBox31.Controls.Add(this.maskadr_textbox);
            this.groupBox31.Controls.Add(this.label43);
            this.groupBox31.Location = new System.Drawing.Point(5, 47);
            this.groupBox31.Name = "groupBox31";
            this.groupBox31.Size = new System.Drawing.Size(1056, 69);
            this.groupBox31.TabIndex = 16;
            this.groupBox31.TabStop = false;
            this.groupBox31.Text = "Mask";
            // 
            // maskData_textBox
            // 
            this.maskData_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.maskData_textBox.Enabled = false;
            this.maskData_textBox.Location = new System.Drawing.Point(528, 44);
            this.maskData_textBox.Name = "maskData_textBox";
            this.maskData_textBox.Size = new System.Drawing.Size(505, 21);
            this.maskData_textBox.TabIndex = 8;
            this.maskData_textBox.Text = "00";
            this.maskData_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(403, 48);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(71, 12);
            this.label60.TabIndex = 7;
            this.label60.Text = "Data(Hex)：";
            // 
            // groupBox40
            // 
            this.groupBox40.Controls.Add(this.R_User);
            this.groupBox40.Controls.Add(this.R_TID);
            this.groupBox40.Controls.Add(this.R_EPC);
            this.groupBox40.Location = new System.Drawing.Point(402, 10);
            this.groupBox40.Name = "groupBox40";
            this.groupBox40.Size = new System.Drawing.Size(513, 30);
            this.groupBox40.TabIndex = 6;
            this.groupBox40.TabStop = false;
            // 
            // R_User
            // 
            this.R_User.AutoSize = true;
            this.R_User.Enabled = false;
            this.R_User.Location = new System.Drawing.Point(381, 11);
            this.R_User.Name = "R_User";
            this.R_User.Size = new System.Drawing.Size(47, 16);
            this.R_User.TabIndex = 2;
            this.R_User.Text = "User";
            this.R_User.UseVisualStyleBackColor = true;
            // 
            // R_TID
            // 
            this.R_TID.AutoSize = true;
            this.R_TID.Enabled = false;
            this.R_TID.Location = new System.Drawing.Point(218, 10);
            this.R_TID.Name = "R_TID";
            this.R_TID.Size = new System.Drawing.Size(41, 16);
            this.R_TID.TabIndex = 1;
            this.R_TID.Text = "TID";
            this.R_TID.UseVisualStyleBackColor = true;
            // 
            // R_EPC
            // 
            this.R_EPC.AutoSize = true;
            this.R_EPC.Checked = true;
            this.R_EPC.Enabled = false;
            this.R_EPC.Location = new System.Drawing.Point(59, 10);
            this.R_EPC.Name = "R_EPC";
            this.R_EPC.Size = new System.Drawing.Size(41, 16);
            this.R_EPC.TabIndex = 0;
            this.R_EPC.TabStop = true;
            this.R_EPC.Text = "EPC";
            this.R_EPC.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(948, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 16);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Enable";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // maskLen_textBox
            // 
            this.maskLen_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.maskLen_textBox.Enabled = false;
            this.maskLen_textBox.Location = new System.Drawing.Point(148, 44);
            this.maskLen_textBox.MaxLength = 2;
            this.maskLen_textBox.Name = "maskLen_textBox";
            this.maskLen_textBox.Size = new System.Drawing.Size(174, 21);
            this.maskLen_textBox.TabIndex = 4;
            this.maskLen_textBox.Text = "00";
            this.maskLen_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(12, 48);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(83, 12);
            this.label44.TabIndex = 3;
            this.label44.Text = "Length(Hex)：";
            // 
            // maskadr_textbox
            // 
            this.maskadr_textbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.maskadr_textbox.Enabled = false;
            this.maskadr_textbox.Location = new System.Drawing.Point(148, 18);
            this.maskadr_textbox.MaxLength = 4;
            this.maskadr_textbox.Name = "maskadr_textbox";
            this.maskadr_textbox.Size = new System.Drawing.Size(174, 21);
            this.maskadr_textbox.TabIndex = 2;
            this.maskadr_textbox.Text = "0000";
            this.maskadr_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(12, 24);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(125, 12);
            this.label43.TabIndex = 1;
            this.label43.Text = "Start address(Hex)：";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.btSelectTag);
            this.groupBox10.Controls.Add(this.comboBox_EPC);
            this.groupBox10.Controls.Add(this.label16);
            this.groupBox10.Controls.Add(this.text_epc);
            this.groupBox10.Controls.Add(this.check_selecttag);
            this.groupBox10.Location = new System.Drawing.Point(5, 4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(1057, 41);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            // 
            // btSelectTag
            // 
            this.btSelectTag.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btSelectTag.Location = new System.Drawing.Point(943, 13);
            this.btSelectTag.Name = "btSelectTag";
            this.btSelectTag.Size = new System.Drawing.Size(90, 23);
            this.btSelectTag.TabIndex = 4;
            this.btSelectTag.Text = "Select";
            this.btSelectTag.UseVisualStyleBackColor = true;
            this.btSelectTag.Click += new System.EventHandler(this.btSelectTag_Click);
            // 
            // comboBox_EPC
            // 
            this.comboBox_EPC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_EPC.FormattingEnabled = true;
            this.comboBox_EPC.Location = new System.Drawing.Point(570, 14);
            this.comboBox_EPC.Name = "comboBox_EPC";
            this.comboBox_EPC.Size = new System.Drawing.Size(345, 20);
            this.comboBox_EPC.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label16.Location = new System.Drawing.Point(503, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 12);
            this.label16.TabIndex = 2;
            this.label16.Text = "Tag list:";
            // 
            // text_epc
            // 
            this.text_epc.Location = new System.Drawing.Point(113, 14);
            this.text_epc.Name = "text_epc";
            this.text_epc.Size = new System.Drawing.Size(345, 21);
            this.text_epc.TabIndex = 1;
            // 
            // check_selecttag
            // 
            this.check_selecttag.AutoSize = true;
            this.check_selecttag.Checked = true;
            this.check_selecttag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_selecttag.ForeColor = System.Drawing.Color.RoyalBlue;
            this.check_selecttag.Location = new System.Drawing.Point(17, 16);
            this.check_selecttag.Name = "check_selecttag";
            this.check_selecttag.Size = new System.Drawing.Size(102, 16);
            this.check_selecttag.TabIndex = 0;
            this.check_selecttag.Text = "Selected tag:";
            this.check_selecttag.UseVisualStyleBackColor = true;
            // 
            // Main_Page3
            // 
            this.Main_Page3.Controls.Add(this.panel5);
            this.Main_Page3.Location = new System.Drawing.Point(4, 27);
            this.Main_Page3.Name = "Main_Page3";
            this.Main_Page3.Padding = new System.Windows.Forms.Padding(3);
            this.Main_Page3.Size = new System.Drawing.Size(1071, 571);
            this.Main_Page3.TabIndex = 2;
            this.Main_Page3.Text = "18000-6B Test";
            this.Main_Page3.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox23);
            this.panel5.Controls.Add(this.groupBox22);
            this.panel5.Controls.Add(this.text_6BUID);
            this.panel5.Controls.Add(this.label29);
            this.panel5.Controls.Add(this.ListView_ID_6B);
            this.panel5.Controls.Add(this.groupBox19);
            this.panel5.Location = new System.Drawing.Point(-1, -1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1069, 569);
            this.panel5.TabIndex = 0;
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.text_Statu6B);
            this.groupBox23.Controls.Add(this.btCheckLock6B);
            this.groupBox23.Controls.Add(this.btLock6B);
            this.groupBox23.Controls.Add(this.text_checkaddr);
            this.groupBox23.Controls.Add(this.label52);
            this.groupBox23.Controls.Add(this.text_lock6b);
            this.groupBox23.Controls.Add(this.label51);
            this.groupBox23.Location = new System.Drawing.Point(561, 429);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(495, 110);
            this.groupBox23.TabIndex = 21;
            this.groupBox23.TabStop = false;
            // 
            // text_Statu6B
            // 
            this.text_Statu6B.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_Statu6B.ForeColor = System.Drawing.Color.Red;
            this.text_Statu6B.Location = new System.Drawing.Point(252, 75);
            this.text_Statu6B.MaxLength = 2;
            this.text_Statu6B.Name = "text_Statu6B";
            this.text_Statu6B.ReadOnly = true;
            this.text_Statu6B.Size = new System.Drawing.Size(111, 21);
            this.text_Statu6B.TabIndex = 19;
            // 
            // btCheckLock6B
            // 
            this.btCheckLock6B.Location = new System.Drawing.Point(383, 66);
            this.btCheckLock6B.Name = "btCheckLock6B";
            this.btCheckLock6B.Size = new System.Drawing.Size(100, 30);
            this.btCheckLock6B.TabIndex = 18;
            this.btCheckLock6B.Text = "Check lock";
            this.btCheckLock6B.UseVisualStyleBackColor = true;
            this.btCheckLock6B.Click += new System.EventHandler(this.btCheckLock6B_Click);
            // 
            // btLock6B
            // 
            this.btLock6B.Location = new System.Drawing.Point(383, 20);
            this.btLock6B.Name = "btLock6B";
            this.btLock6B.Size = new System.Drawing.Size(100, 30);
            this.btLock6B.TabIndex = 17;
            this.btLock6B.Text = "Lock";
            this.btLock6B.UseVisualStyleBackColor = true;
            this.btLock6B.Click += new System.EventHandler(this.btLock6B_Click);
            // 
            // text_checkaddr
            // 
            this.text_checkaddr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_checkaddr.Location = new System.Drawing.Point(202, 75);
            this.text_checkaddr.MaxLength = 2;
            this.text_checkaddr.Name = "text_checkaddr";
            this.text_checkaddr.Size = new System.Drawing.Size(44, 21);
            this.text_checkaddr.TabIndex = 16;
            this.text_checkaddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(47, 78);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(149, 12);
            this.label52.TabIndex = 15;
            this.label52.Text = "Check lock address(Hex):";
            // 
            // text_lock6b
            // 
            this.text_lock6b.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_lock6b.Location = new System.Drawing.Point(202, 29);
            this.text_lock6b.MaxLength = 2;
            this.text_lock6b.Name = "text_lock6b";
            this.text_lock6b.Size = new System.Drawing.Size(44, 21);
            this.text_lock6b.TabIndex = 14;
            this.text_lock6b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(71, 32);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(113, 12);
            this.label51.TabIndex = 0;
            this.label51.Text = "Lock address(Hex):";
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.text_W6B);
            this.groupBox22.Controls.Add(this.label48);
            this.groupBox22.Controls.Add(this.btWrite6B);
            this.groupBox22.Controls.Add(this.text_W6BLen);
            this.groupBox22.Controls.Add(this.label49);
            this.groupBox22.Controls.Add(this.text_W6BAddr);
            this.groupBox22.Controls.Add(this.label50);
            this.groupBox22.Controls.Add(this.text_R6B);
            this.groupBox22.Controls.Add(this.label36);
            this.groupBox22.Controls.Add(this.btRead6B);
            this.groupBox22.Controls.Add(this.text_R6BLen);
            this.groupBox22.Controls.Add(this.label35);
            this.groupBox22.Controls.Add(this.text_R6BAddr);
            this.groupBox22.Controls.Add(this.label30);
            this.groupBox22.Location = new System.Drawing.Point(563, 70);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(495, 359);
            this.groupBox22.TabIndex = 20;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Read/Write Data";
            // 
            // text_W6B
            // 
            this.text_W6B.Location = new System.Drawing.Point(122, 234);
            this.text_W6B.Multiline = true;
            this.text_W6B.Name = "text_W6B";
            this.text_W6B.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_W6B.Size = new System.Drawing.Size(359, 118);
            this.text_W6B.TabIndex = 18;
            this.text_W6B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(18, 234);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(119, 12);
            this.label48.TabIndex = 17;
            this.label48.Text = "Write data(Hex):   ";
            // 
            // btWrite6B
            // 
            this.btWrite6B.Location = new System.Drawing.Point(381, 194);
            this.btWrite6B.Name = "btWrite6B";
            this.btWrite6B.Size = new System.Drawing.Size(100, 30);
            this.btWrite6B.TabIndex = 16;
            this.btWrite6B.Text = "Write";
            this.btWrite6B.UseVisualStyleBackColor = true;
            this.btWrite6B.Click += new System.EventHandler(this.btWrite6B_Click);
            // 
            // text_W6BLen
            // 
            this.text_W6BLen.Location = new System.Drawing.Point(294, 199);
            this.text_W6BLen.MaxLength = 2;
            this.text_W6BLen.Name = "text_W6BLen";
            this.text_W6BLen.Size = new System.Drawing.Size(44, 21);
            this.text_W6BLen.TabIndex = 15;
            this.text_W6BLen.TextChanged += new System.EventHandler(this.text_W6BLen_TextChanged);
            this.text_W6BLen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(187, 203);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(113, 12);
            this.label49.TabIndex = 14;
            this.label49.Text = "Write length(Hex):";
            // 
            // text_W6BAddr
            // 
            this.text_W6BAddr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_W6BAddr.Location = new System.Drawing.Point(133, 200);
            this.text_W6BAddr.MaxLength = 2;
            this.text_W6BAddr.Name = "text_W6BAddr";
            this.text_W6BAddr.Size = new System.Drawing.Size(44, 21);
            this.text_W6BAddr.TabIndex = 13;
            this.text_W6BAddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(18, 203);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(137, 12);
            this.label50.TabIndex = 12;
            this.label50.Text = "Start address(Hex):   ";
            // 
            // text_R6B
            // 
            this.text_R6B.Location = new System.Drawing.Point(122, 62);
            this.text_R6B.Multiline = true;
            this.text_R6B.Name = "text_R6B";
            this.text_R6B.ReadOnly = true;
            this.text_R6B.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_R6B.Size = new System.Drawing.Size(359, 118);
            this.text_R6B.TabIndex = 11;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(18, 62);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(113, 12);
            this.label36.TabIndex = 10;
            this.label36.Text = "Read data(Hex):   ";
            // 
            // btRead6B
            // 
            this.btRead6B.Location = new System.Drawing.Point(381, 20);
            this.btRead6B.Name = "btRead6B";
            this.btRead6B.Size = new System.Drawing.Size(100, 30);
            this.btRead6B.TabIndex = 9;
            this.btRead6B.Text = "read";
            this.btRead6B.UseVisualStyleBackColor = true;
            this.btRead6B.Click += new System.EventHandler(this.btRead6B_Click);
            // 
            // text_R6BLen
            // 
            this.text_R6BLen.Location = new System.Drawing.Point(294, 25);
            this.text_R6BLen.MaxLength = 2;
            this.text_R6BLen.Name = "text_R6BLen";
            this.text_R6BLen.Size = new System.Drawing.Size(44, 21);
            this.text_R6BLen.TabIndex = 8;
            this.text_R6BLen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(193, 29);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(107, 12);
            this.label35.TabIndex = 7;
            this.label35.Text = "Read length(Hex):";
            // 
            // text_R6BAddr
            // 
            this.text_R6BAddr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_R6BAddr.Location = new System.Drawing.Point(133, 25);
            this.text_R6BAddr.MaxLength = 2;
            this.text_R6BAddr.Name = "text_R6BAddr";
            this.text_R6BAddr.Size = new System.Drawing.Size(44, 21);
            this.text_R6BAddr.TabIndex = 6;
            this.text_R6BAddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(18, 29);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(137, 12);
            this.label30.TabIndex = 5;
            this.label30.Text = "Start address(Hex):   ";
            // 
            // text_6BUID
            // 
            this.text_6BUID.Location = new System.Drawing.Point(696, 39);
            this.text_6BUID.Name = "text_6BUID";
            this.text_6BUID.ReadOnly = true;
            this.text_6BUID.Size = new System.Drawing.Size(214, 21);
            this.text_6BUID.TabIndex = 19;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(559, 44);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(131, 12);
            this.label29.TabIndex = 18;
            this.label29.Text = "Current Selected UID:";
            // 
            // ListView_ID_6B
            // 
            this.ListView_ID_6B.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ListView_ID_6B.AllowDrop = true;
            this.ListView_ID_6B.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader2,
            this.columnHeader3});
            this.ListView_ID_6B.FullRowSelect = true;
            this.ListView_ID_6B.GridLines = true;
            this.ListView_ID_6B.HotTracking = true;
            this.ListView_ID_6B.HoverSelection = true;
            this.ListView_ID_6B.Location = new System.Drawing.Point(10, 82);
            this.ListView_ID_6B.Name = "ListView_ID_6B";
            this.ListView_ID_6B.Size = new System.Drawing.Size(524, 482);
            this.ListView_ID_6B.TabIndex = 17;
            this.ListView_ID_6B.UseCompatibleStateImageBehavior = false;
            this.ListView_ID_6B.View = System.Windows.Forms.View.Details;
            this.ListView_ID_6B.DoubleClick += new System.EventHandler(this.ListView_ID_6B_DoubleClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "No.";
            this.columnHeader5.Width = 50;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 230;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ant(4,3,2,1)";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Times";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "RSSI";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.rb_mutiple);
            this.groupBox19.Controls.Add(this.rb_single);
            this.groupBox19.Controls.Add(this.btInventory6B);
            this.groupBox19.Location = new System.Drawing.Point(10, 5);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(524, 71);
            this.groupBox19.TabIndex = 16;
            this.groupBox19.TabStop = false;
            // 
            // rb_mutiple
            // 
            this.rb_mutiple.AutoSize = true;
            this.rb_mutiple.Location = new System.Drawing.Point(377, 35);
            this.rb_mutiple.Name = "rb_mutiple";
            this.rb_mutiple.Size = new System.Drawing.Size(65, 16);
            this.rb_mutiple.TabIndex = 2;
            this.rb_mutiple.Text = "Mutiple";
            this.rb_mutiple.UseVisualStyleBackColor = true;
            // 
            // rb_single
            // 
            this.rb_single.AutoSize = true;
            this.rb_single.Checked = true;
            this.rb_single.Location = new System.Drawing.Point(246, 35);
            this.rb_single.Name = "rb_single";
            this.rb_single.Size = new System.Drawing.Size(59, 16);
            this.rb_single.TabIndex = 1;
            this.rb_single.TabStop = true;
            this.rb_single.Text = "Single";
            this.rb_single.UseVisualStyleBackColor = true;
            // 
            // btInventory6B
            // 
            this.btInventory6B.BackColor = System.Drawing.Color.Transparent;
            this.btInventory6B.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btInventory6B.ForeColor = System.Drawing.Color.DarkBlue;
            this.btInventory6B.Location = new System.Drawing.Point(18, 20);
            this.btInventory6B.Name = "btInventory6B";
            this.btInventory6B.Size = new System.Drawing.Size(171, 40);
            this.btInventory6B.TabIndex = 0;
            this.btInventory6B.Text = "Start";
            this.btInventory6B.UseVisualStyleBackColor = false;
            this.btInventory6B.Click += new System.EventHandler(this.btInventory6B_Click);
            // 
            // Main_Page4
            // 
            this.Main_Page4.Controls.Add(this.tabControl3);
            this.Main_Page4.Location = new System.Drawing.Point(4, 27);
            this.Main_Page4.Name = "Main_Page4";
            this.Main_Page4.Padding = new System.Windows.Forms.Padding(3);
            this.Main_Page4.Size = new System.Drawing.Size(1071, 571);
            this.Main_Page4.TabIndex = 3;
            this.Main_Page4.Text = "Network module config";
            this.Main_Page4.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Controls.Add(this.tabPage8);
            this.tabControl3.Controls.Add(this.tabPage9);
            this.tabControl3.ItemSize = new System.Drawing.Size(60, 23);
            this.tabControl3.Location = new System.Drawing.Point(-1, 4);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(1072, 561);
            this.tabControl3.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.DeviceListView);
            this.tabPage6.Controls.Add(this.menuStrip);
            this.tabPage6.Location = new System.Drawing.Point(4, 27);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1064, 530);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "   TCP config       ";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // DeviceListView
            // 
            this.DeviceListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.deviceName,
            this.deviceIP,
            this.deviceMac});
            this.DeviceListView.FullRowSelect = true;
            this.DeviceListView.Location = new System.Drawing.Point(8, 30);
            this.DeviceListView.Name = "DeviceListView";
            this.DeviceListView.Size = new System.Drawing.Size(1050, 497);
            this.DeviceListView.TabIndex = 5;
            this.DeviceListView.UseCompatibleStateImageBehavior = false;
            this.DeviceListView.View = System.Windows.Forms.View.Details;
            this.DeviceListView.DoubleClick += new System.EventHandler(this.DeviceListView_DoubleClick);
            // 
            // deviceName
            // 
            this.deviceName.Text = "Name";
            this.deviceName.Width = 220;
            // 
            // deviceIP
            // 
            this.deviceIP.Text = "IP Address";
            this.deviceIP.Width = 280;
            // 
            // deviceMac
            // 
            this.deviceMac.Text = "Mac";
            this.deviceMac.Width = 245;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.languageToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(3, 3);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1058, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.configToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(71, 20);
            this.toolStripMenuItem1.Text = "&Operation";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.configToolStripMenuItem.Text = "&Config";
            this.configToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(103, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iEToolStripMenuItem,
            this.telnetToolStripMenuItem,
            this.pingToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(41, 20);
            this.toolStripMenuItem2.Text = "&Tool";
            // 
            // iEToolStripMenuItem
            // 
            this.iEToolStripMenuItem.Name = "iEToolStripMenuItem";
            this.iEToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.iEToolStripMenuItem.Text = "&IE";
            this.iEToolStripMenuItem.Click += new System.EventHandler(this.iEToolStripMenuItem_Click);
            // 
            // telnetToolStripMenuItem
            // 
            this.telnetToolStripMenuItem.Name = "telnetToolStripMenuItem";
            this.telnetToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.telnetToolStripMenuItem.Text = "&Telnet";
            this.telnetToolStripMenuItem.Click += new System.EventHandler(this.telnetToolStripMenuItem_Click);
            // 
            // pingToolStripMenuItem
            // 
            this.pingToolStripMenuItem.Name = "pingToolStripMenuItem";
            this.pingToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.pingToolStripMenuItem.Text = "&Ping";
            this.pingToolStripMenuItem.Click += new System.EventHandler(this.pingToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.languageToolStripMenuItem.Text = "&Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.englishToolStripMenuItem.Text = "&English";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.label63);
            this.tabPage8.Controls.Add(this.stcprecv);
            this.tabPage8.Controls.Add(this.groupBox25);
            this.tabPage8.Controls.Add(this.groupBox24);
            this.tabPage8.Location = new System.Drawing.Point(4, 27);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(1064, 530);
            this.tabPage8.TabIndex = 2;
            this.tabPage8.Text = "   TCP Server   ";
            this.tabPage8.UseVisualStyleBackColor = true;
            this.tabPage8.Click += new System.EventHandler(this.tabPage8_Click);
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(204, 125);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(113, 12);
            this.label63.TabIndex = 3;
            this.label63.Text = "Receive data(Hex):";
            // 
            // stcprecv
            // 
            this.stcprecv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stcprecv.EnableAutoDragDrop = true;
            this.stcprecv.Location = new System.Drawing.Point(202, 140);
            this.stcprecv.Name = "stcprecv";
            this.stcprecv.Size = new System.Drawing.Size(617, 381);
            this.stcprecv.TabIndex = 2;
            this.stcprecv.Text = "";
            // 
            // groupBox25
            // 
            this.groupBox25.Controls.Add(this.listtcp);
            this.groupBox25.Location = new System.Drawing.Point(512, 6);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Size = new System.Drawing.Size(307, 106);
            this.groupBox25.TabIndex = 1;
            this.groupBox25.TabStop = false;
            this.groupBox25.Text = "Client";
            // 
            // listtcp
            // 
            this.listtcp.FormattingEnabled = true;
            this.listtcp.ItemHeight = 12;
            this.listtcp.Location = new System.Drawing.Point(8, 20);
            this.listtcp.Name = "listtcp";
            this.listtcp.Size = new System.Drawing.Size(287, 76);
            this.listtcp.TabIndex = 0;
            // 
            // groupBox24
            // 
            this.groupBox24.Controls.Add(this.btStop);
            this.groupBox24.Controls.Add(this.btListen);
            this.groupBox24.Controls.Add(this.stcpport);
            this.groupBox24.Controls.Add(this.label62);
            this.groupBox24.Location = new System.Drawing.Point(202, 6);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new System.Drawing.Size(301, 106);
            this.groupBox24.TabIndex = 0;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "Server Setting";
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(191, 63);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(92, 33);
            this.btStop.TabIndex = 3;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btListen
            // 
            this.btListen.Location = new System.Drawing.Point(93, 63);
            this.btListen.Name = "btListen";
            this.btListen.Size = new System.Drawing.Size(92, 33);
            this.btListen.TabIndex = 2;
            this.btListen.Text = "Listen";
            this.btListen.UseVisualStyleBackColor = true;
            this.btListen.Click += new System.EventHandler(this.btListen_Click);
            // 
            // stcpport
            // 
            this.stcpport.Location = new System.Drawing.Point(93, 25);
            this.stcpport.Name = "stcpport";
            this.stcpport.Size = new System.Drawing.Size(187, 21);
            this.stcpport.TabIndex = 1;
            this.stcpport.Text = "6000";
            this.stcpport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(17, 32);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(65, 12);
            this.label62.TabIndex = 0;
            this.label62.Text = " TCP Port:";
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.groupBox26);
            this.tabPage9.Controls.Add(this.bttcpsend);
            this.tabPage9.Controls.Add(this.label69);
            this.tabPage9.Controls.Add(this.ctctsend);
            this.tabPage9.Controls.Add(this.label68);
            this.tabPage9.Controls.Add(this.ctctrecv);
            this.tabPage9.Location = new System.Drawing.Point(4, 27);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(1064, 530);
            this.tabPage9.TabIndex = 3;
            this.tabPage9.Text = "   TCP Client   ";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // groupBox26
            // 
            this.groupBox26.Controls.Add(this.bttcpdisconnect);
            this.groupBox26.Controls.Add(this.bttcpconnect);
            this.groupBox26.Controls.Add(this.remotePort);
            this.groupBox26.Controls.Add(this.label71);
            this.groupBox26.Controls.Add(this.tcpremoteIp);
            this.groupBox26.Controls.Add(this.label70);
            this.groupBox26.Location = new System.Drawing.Point(209, 6);
            this.groupBox26.Name = "groupBox26";
            this.groupBox26.Size = new System.Drawing.Size(617, 63);
            this.groupBox26.TabIndex = 9;
            this.groupBox26.TabStop = false;
            this.groupBox26.Text = "Setting";
            // 
            // bttcpdisconnect
            // 
            this.bttcpdisconnect.Location = new System.Drawing.Point(521, 25);
            this.bttcpdisconnect.Name = "bttcpdisconnect";
            this.bttcpdisconnect.Size = new System.Drawing.Size(90, 23);
            this.bttcpdisconnect.TabIndex = 26;
            this.bttcpdisconnect.Text = "Disconnect";
            this.bttcpdisconnect.UseVisualStyleBackColor = true;
            this.bttcpdisconnect.Click += new System.EventHandler(this.bttcpdisconnect_Click);
            // 
            // bttcpconnect
            // 
            this.bttcpconnect.Location = new System.Drawing.Point(415, 25);
            this.bttcpconnect.Name = "bttcpconnect";
            this.bttcpconnect.Size = new System.Drawing.Size(90, 23);
            this.bttcpconnect.TabIndex = 25;
            this.bttcpconnect.Text = "Connect";
            this.bttcpconnect.UseVisualStyleBackColor = true;
            this.bttcpconnect.Click += new System.EventHandler(this.bttcpconnect_Click);
            // 
            // remotePort
            // 
            this.remotePort.Location = new System.Drawing.Point(268, 25);
            this.remotePort.Name = "remotePort";
            this.remotePort.Size = new System.Drawing.Size(94, 21);
            this.remotePort.TabIndex = 24;
            this.remotePort.Text = "27011";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(227, 30);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(35, 12);
            this.label71.TabIndex = 23;
            this.label71.Text = "Port:";
            // 
            // tcpremoteIp
            // 
            this.tcpremoteIp.IpAddressStr = "192.168.0.250";
            this.tcpremoteIp.Location = new System.Drawing.Point(85, 25);
            this.tcpremoteIp.Name = "tcpremoteIp";
            this.tcpremoteIp.Size = new System.Drawing.Size(121, 21);
            this.tcpremoteIp.TabIndex = 22;
            this.tcpremoteIp.Tag = "";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(14, 30);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(65, 12);
            this.label70.TabIndex = 0;
            this.label70.Text = "Server IP:";
            // 
            // bttcpsend
            // 
            this.bttcpsend.Enabled = false;
            this.bttcpsend.Location = new System.Drawing.Point(730, 79);
            this.bttcpsend.Name = "bttcpsend";
            this.bttcpsend.Size = new System.Drawing.Size(90, 23);
            this.bttcpsend.TabIndex = 8;
            this.bttcpsend.Text = "Send";
            this.bttcpsend.UseVisualStyleBackColor = true;
            this.bttcpsend.Click += new System.EventHandler(this.bttcpsend_Click);
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(211, 86);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(95, 12);
            this.label69.TabIndex = 7;
            this.label69.Text = "Send data(Hex):";
            // 
            // ctctsend
            // 
            this.ctctsend.Location = new System.Drawing.Point(209, 107);
            this.ctctsend.Multiline = true;
            this.ctctsend.Name = "ctctsend";
            this.ctctsend.Size = new System.Drawing.Size(617, 86);
            this.ctctsend.TabIndex = 6;
            this.ctctsend.Text = "04 FF 21 19 95";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(211, 201);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(113, 12);
            this.label68.TabIndex = 5;
            this.label68.Text = "Receive data(Hex):";
            // 
            // ctctrecv
            // 
            this.ctctrecv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ctctrecv.EnableAutoDragDrop = true;
            this.ctctrecv.Location = new System.Drawing.Point(209, 216);
            this.ctctrecv.Name = "ctctrecv";
            this.ctctrecv.Size = new System.Drawing.Size(617, 304);
            this.ctctrecv.TabIndex = 4;
            this.ctctrecv.Text = "";
            // 
            // btFlashCl
            // 
            this.btFlashCl.Location = new System.Drawing.Point(939, 603);
            this.btFlashCl.Name = "btFlashCl";
            this.btFlashCl.Size = new System.Drawing.Size(100, 23);
            this.btFlashCl.TabIndex = 5;
            this.btFlashCl.Text = "Refresh";
            this.btFlashCl.UseVisualStyleBackColor = true;
            this.btFlashCl.Click += new System.EventHandler(this.btFlashCl_Click);
            // 
            // timer_answer
            // 
            this.timer_answer.Interval = 50;
            this.timer_answer.Tick += new System.EventHandler(this.timer_answer_Tick);
            // 
            // timer_runmode
            // 
            this.timer_runmode.Interval = 50;
            this.timer_runmode.Tick += new System.EventHandler(this.timer_runmode_Tick);
            // 
            // timer_EAS
            // 
            this.timer_EAS.Tick += new System.EventHandler(this.timer_EAS_Tick);
            // 
            // Timer_Test_6B
            // 
            this.Timer_Test_6B.Tick += new System.EventHandler(this.Timer_Test_6B_Tick);
            // 
            // timer_Buff
            // 
            this.timer_Buff.Interval = 50;
            this.timer_Buff.Tick += new System.EventHandler(this.timer_Buff_Tick);
            // 
            // timer_RealTime
            // 
            this.timer_RealTime.Interval = 50;
            this.timer_RealTime.Tick += new System.EventHandler(this.timer_RealTime_Tick);
            // 
            // ckClearOperationRec
            // 
            this.ckClearOperationRec.AutoSize = true;
            this.ckClearOperationRec.Checked = true;
            this.ckClearOperationRec.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckClearOperationRec.Location = new System.Drawing.Point(134, 608);
            this.ckClearOperationRec.Name = "ckClearOperationRec";
            this.ckClearOperationRec.Size = new System.Drawing.Size(84, 16);
            this.ckClearOperationRec.TabIndex = 18;
            this.ckClearOperationRec.Text = "Auto-Clear";
            this.ckClearOperationRec.UseVisualStyleBackColor = true;
            // 
            // radioButton_band12
            // 
            this.radioButton_band12.AutoSize = true;
            this.radioButton_band12.Location = new System.Drawing.Point(247, 44);
            this.radioButton_band12.Name = "radioButton_band12";
            this.radioButton_band12.Size = new System.Drawing.Size(71, 16);
            this.radioButton_band12.TabIndex = 18;
            this.radioButton_band12.TabStop = true;
            this.radioButton_band12.Text = "US band3";
            this.radioButton_band12.UseVisualStyleBackColor = true;
            this.radioButton_band12.CheckedChanged += new System.EventHandler(this.radioButton_band12_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 723);
            this.Controls.Add(this.ckClearOperationRec);
            this.Controls.Add(this.btFlashCl);
            this.Controls.Add(this.Maintab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lrtxtLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UHFReader288MP Demo V2.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Maintab.ResumeLayout(false);
            this.Main_Page1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Basic.ResumeLayout(false);
            this.gbReturnLoss.ResumeLayout(false);
            this.gbReturnLoss.PerformLayout();
            this.gbCmdTemperature.ResumeLayout(false);
            this.gbCmdTemperature.PerformLayout();
            this.gbp_DRM.ResumeLayout(false);
            this.gbp_DRM.PerformLayout();
            this.gbp_Retry.ResumeLayout(false);
            this.gbp_wpower.ResumeLayout(false);
            this.gbp_wpower.PerformLayout();
            this.group_maxtime.ResumeLayout(false);
            this.gbp_buff.ResumeLayout(false);
            this.gbp_buff.PerformLayout();
            this.gpb_antconfig.ResumeLayout(false);
            this.gpb_antconfig.PerformLayout();
            this.gpb_checkant.ResumeLayout(false);
            this.gpb_checkant.PerformLayout();
            this.gpb_GPIO.ResumeLayout(false);
            this.gpb_GPIO.PerformLayout();
            this.gpb_OutputRep.ResumeLayout(false);
            this.gpb_OutputRep.PerformLayout();
            this.gpb_Relay.ResumeLayout(false);
            this.gpb_Relay.PerformLayout();
            this.gpb_baud.ResumeLayout(false);
            this.gpb_DBM.ResumeLayout(false);
            this.gpb_DBM.PerformLayout();
            this.gpb_Freq.ResumeLayout(false);
            this.gpb_Freq.PerformLayout();
            this.gpb_beep.ResumeLayout(false);
            this.gpb_beep.PerformLayout();
            this.gpb_RDVersion.ResumeLayout(false);
            this.gpb_RDVersion.PerformLayout();
            this.gpb_Serial.ResumeLayout(false);
            this.gpb_Serial.PerformLayout();
            this.gpb_address.ResumeLayout(false);
            this.gpb_address.PerformLayout();
            this.gpb_tcp.ResumeLayout(false);
            this.gpb_tcp.PerformLayout();
            this.gpb_rs232.ResumeLayout(false);
            this.gpb_rs232.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage_Module.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.groupBox39.ResumeLayout(false);
            this.groupBox39.PerformLayout();
            this.groupBox38.ResumeLayout(false);
            this.groupBox38.PerformLayout();
            this.groupBox34.ResumeLayout(false);
            this.groupBox34.PerformLayout();
            this.groupBox33.ResumeLayout(false);
            this.groupBox33.PerformLayout();
            this.groupBox32.ResumeLayout(false);
            this.groupBox32.PerformLayout();
            this.groupBox28.ResumeLayout(false);
            this.groupBox28.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Main_Page2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage_answer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl6)).EndInit();
            this.gbp_MixRead.ResumeLayout(false);
            this.gbp_MixRead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.group_ant1.ResumeLayout(false);
            this.group_ant1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage_Realtime.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.groupBox41.ResumeLayout(false);
            this.groupBox41.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_Mtime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_Mtag)).EndInit();
            this.groupBox42.ResumeLayout(false);
            this.tabPage_Buff.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.groupBox27.ResumeLayout(false);
            this.groupBox29.ResumeLayout(false);
            this.groupBox29.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox30.ResumeLayout(false);
            this.groupBox30.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_cmdTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_Btoltime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_Btoltag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_Bcmdsud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_BNum)).EndInit();
            this.tabPage_RW.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox31.ResumeLayout(false);
            this.groupBox31.PerformLayout();
            this.groupBox40.ResumeLayout(false);
            this.groupBox40.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.Main_Page3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.Main_Page4.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.groupBox25.ResumeLayout(false);
            this.groupBox24.ResumeLayout(false);
            this.groupBox24.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.groupBox26.ResumeLayout(false);
            this.groupBox26.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControl.LogRichTextBox lrtxtLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl Maintab;
        private System.Windows.Forms.TabPage Main_Page1;
        private System.Windows.Forms.TabPage Main_Page2;
        private System.Windows.Forms.TabPage Main_Page3;
        private System.Windows.Forms.TabPage Main_Page4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Basic;
        private System.Windows.Forms.GroupBox gpb_rs232;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_tcp;
        private System.Windows.Forms.RadioButton rb_rs232;
        private System.Windows.Forms.Button btDisConnect232;
        private System.Windows.Forms.Button btConnect232;
        private System.Windows.Forms.ComboBox ComboBox_baud2;
        private System.Windows.Forms.Label label47;
        internal System.Windows.Forms.ComboBox ComboBox_COM;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpb_tcp;
        private System.Windows.Forms.Button btDisConnectTcp;
        private System.Windows.Forms.Button btConnectTcp;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Port;
        private CustomControl.IpAddressTextBox ipServerIP;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage_answer;
        private System.Windows.Forms.Button btFlashCl;
        private System.Windows.Forms.Timer timer_answer;
        private System.Windows.Forms.Panel panel1;
        private LxControl.LxLedControl lxLedControl5;
        private System.Windows.Forms.Label label9;
        private LxControl.LxLedControl lxLedControl4;
        private System.Windows.Forms.Label label8;
        private LxControl.LxLedControl lxLedControl3;
        private System.Windows.Forms.Label label7;
        private LxControl.LxLedControl lxLedControl2;
        private System.Windows.Forms.Label label6;
        private LxControl.LxLedControl lxLedControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox com_scantime;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.ComboBox com_S;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox com_Q;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.GroupBox group_ant1;
        public System.Windows.Forms.CheckBox check_ant4;
        public System.Windows.Forms.CheckBox check_ant3;
        public System.Windows.Forms.CheckBox check_ant2;
        public System.Windows.Forms.CheckBox check_ant1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_tid;
        private System.Windows.Forms.RadioButton rb_epc;
        private System.Windows.Forms.Button btIventoryG2;
        private System.Windows.Forms.GroupBox gpb_address;
        private System.Windows.Forms.TextBox text_address;
        private System.Windows.Forms.Button btaddress;
        private System.Windows.Forms.GroupBox gpb_Serial;
        private System.Windows.Forms.TextBox text_Serial;
        private System.Windows.Forms.Button btSerial;
        private System.Windows.Forms.GroupBox gpb_beep;
        private System.Windows.Forms.GroupBox gpb_RDVersion;
        private System.Windows.Forms.TextBox text_RDVersion;
        private System.Windows.Forms.RadioButton Radio_beepDis;
        private System.Windows.Forms.RadioButton Radio_beepEn;
        private System.Windows.Forms.Button Button_Beep;
        private System.Windows.Forms.GroupBox gpb_Freq;
        private System.Windows.Forms.RadioButton radioButton_band4;
        private System.Windows.Forms.RadioButton radioButton_band3;
        private System.Windows.Forms.RadioButton radioButton_band2;
        private System.Windows.Forms.RadioButton radioButton_band1;
        private System.Windows.Forms.Button btFreq;
        private System.Windows.Forms.ComboBox ComboBox_dmaxfre;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox ComboBox_dminfre;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox CheckBox_SameFre;
        private System.Windows.Forms.GroupBox gpb_DBM;
        private System.Windows.Forms.Button BT_DBM;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ComboBox_PowerDbm;
        private System.Windows.Forms.GroupBox gpb_baud;
        private System.Windows.Forms.Button btBaudRate;
        private System.Windows.Forms.ComboBox ComboBox_baud;
        private System.Windows.Forms.GroupBox gpb_Relay;
        private System.Windows.Forms.Button btRelay;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.ComboBox ComboBox_RelayTime;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.GroupBox gpb_OutputRep;
        private System.Windows.Forms.Button btOutputRep;
        private System.Windows.Forms.CheckBox check_OutputRep4;
        private System.Windows.Forms.CheckBox check_OutputRep3;
        private System.Windows.Forms.CheckBox check_OutputRep2;
        private System.Windows.Forms.CheckBox check_OutputRep1;
        private System.Windows.Forms.GroupBox gpb_antconfig;
        private System.Windows.Forms.Button Button_Ant;
        private System.Windows.Forms.CheckBox checkant4;
        private System.Windows.Forms.CheckBox checkant3;
        private System.Windows.Forms.CheckBox checkant2;
        private System.Windows.Forms.CheckBox checkant1;
        private System.Windows.Forms.GroupBox gpb_checkant;
        private System.Windows.Forms.Button btSetcheckant;
        private System.Windows.Forms.RadioButton rb_Closecheckant;
        private System.Windows.Forms.RadioButton rb_Opencheckant;
        private System.Windows.Forms.GroupBox gpb_GPIO;
        private System.Windows.Forms.Button Button_GetGPIO;
        private System.Windows.Forms.Button Button_SetGPIO;
        private System.Windows.Forms.CheckBox check_int2;
        private System.Windows.Forms.CheckBox check_int1;
        private System.Windows.Forms.CheckBox check_out2;
        private System.Windows.Forms.CheckBox check_out1;
        private System.Windows.Forms.Button btGetInformation;
        private System.Windows.Forms.Button btDefault;
        private System.Windows.Forms.Timer timer_runmode;
        private System.Windows.Forms.TabPage tabPage_RW;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox text_epc;
        private System.Windows.Forms.CheckBox check_selecttag;
        private System.Windows.Forms.Button btSelectTag;
        private System.Windows.Forms.ComboBox comboBox_EPC;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox31;
        private System.Windows.Forms.TextBox maskData_textBox;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.GroupBox groupBox40;
        private System.Windows.Forms.RadioButton R_User;
        private System.Windows.Forms.RadioButton R_TID;
        private System.Windows.Forms.RadioButton R_EPC;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox maskLen_textBox;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox maskadr_textbox;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox textBox_pc;
        private System.Windows.Forms.CheckBox checkBox_pc;
        private System.Windows.Forms.Button btBlockWrite;
        private System.Windows.Forms.Button btBlockErase;
        private System.Windows.Forms.Button btWrite;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.TextBox text_WriteData;
        private System.Windows.Forms.TextBox text_AccessCode2;
        private System.Windows.Forms.TextBox text_RWlen;
        private System.Windows.Forms.TextBox text_WordPtr;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.RadioButton C_User;
        private System.Windows.Forms.RadioButton C_TID;
        private System.Windows.Forms.RadioButton C_EPC;
        private System.Windows.Forms.RadioButton C_Reserve;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Button btSetProtectState;
        private System.Windows.Forms.TextBox Edit_AccessCode6;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.RadioButton AlwaysNot2;
        private System.Windows.Forms.RadioButton Always2;
        private System.Windows.Forms.RadioButton Proect2;
        private System.Windows.Forms.RadioButton NoProect2;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.RadioButton P_User;
        private System.Windows.Forms.RadioButton P_TID;
        private System.Windows.Forms.RadioButton P_EPC;
        private System.Windows.Forms.RadioButton P_kill;
        private System.Windows.Forms.RadioButton p_pass;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Button btCheckEASAlarm;
        private System.Windows.Forms.Button btSetEASAlarm_G2;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.RadioButton NoAlarm_G2;
        private System.Windows.Forms.RadioButton Alarm_G2;
        private System.Windows.Forms.TextBox text_AccessCode5;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.Button btCheckReadProtected_G2;
        private System.Windows.Forms.Button btRemoveReadProtect_G2;
        private System.Windows.Forms.Button btSetMultiReadProtect_G2;
        private System.Windows.Forms.Button btSetReadProtect_G2;
        private System.Windows.Forms.TextBox text_AccessCode4;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.Button btWriteEPC_G2;
        private System.Windows.Forms.TextBox text_AccessCode3;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox text_WriteEPC;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.Button btDestroyCard;
        private System.Windows.Forms.TextBox text_DestroyCode;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Timer timer_EAS;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListView ListView_ID_6B;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.RadioButton rb_mutiple;
        private System.Windows.Forms.RadioButton rb_single;
        private System.Windows.Forms.Button btInventory6B;
        private System.Windows.Forms.Timer Timer_Test_6B;
        private System.Windows.Forms.TextBox text_6BUID;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.GroupBox groupBox23;
        private System.Windows.Forms.TextBox text_R6BLen;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox text_R6BAddr;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox text_R6B;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button btRead6B;
        private System.Windows.Forms.TextBox text_W6B;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Button btWrite6B;
        private System.Windows.Forms.TextBox text_W6BLen;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox text_W6BAddr;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TextBox text_lock6b;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox text_Statu6B;
        private System.Windows.Forms.Button btCheckLock6B;
        private System.Windows.Forms.Button btLock6B;
        private System.Windows.Forms.TextBox text_checkaddr;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem iEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telnetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListView DeviceListView;
        private System.Windows.Forms.ColumnHeader deviceName;
        private System.Windows.Forms.ColumnHeader deviceIP;
        private System.Windows.Forms.ColumnHeader deviceMac;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.GroupBox groupBox25;
        private System.Windows.Forms.ListBox listtcp;
        private System.Windows.Forms.GroupBox groupBox24;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btListen;
        private System.Windows.Forms.TextBox stcpport;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label63;
        private CustomControl.LogRichTextBox stcprecv;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.Button bttcpsend;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.TextBox ctctsend;
        private System.Windows.Forms.Label label68;
        private CustomControl.LogRichTextBox ctctrecv;
        private System.Windows.Forms.GroupBox groupBox26;
        private System.Windows.Forms.Button bttcpdisconnect;
        private System.Windows.Forms.Button bttcpconnect;
        private System.Windows.Forms.TextBox remotePort;
        private System.Windows.Forms.Label label71;
        private CustomControl.IpAddressTextBox tcpremoteIp;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.TextBox text_target;
        private System.Windows.Forms.CheckBox check_num;
        private System.Windows.Forms.ComboBox com_Target;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.GroupBox gbp_buff;
        private System.Windows.Forms.RadioButton rb496;
        private System.Windows.Forms.RadioButton rb128;
        private System.Windows.Forms.Button btGetEPCandTIDLen;
        private System.Windows.Forms.Button btSetEPCandTIDLen;
        private System.Windows.Forms.TabPage tabPage_Buff;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.GroupBox groupBox27;
        private System.Windows.Forms.Button btQueryBuffNum;
        private System.Windows.Forms.Button btRandCbuff;
        private System.Windows.Forms.Button btClearBuff;
        private System.Windows.Forms.Button btReadBuff;
        private System.Windows.Forms.GroupBox groupBox29;
        private System.Windows.Forms.RadioButton rb_btid;
        private System.Windows.Forms.RadioButton rb_bepc;
        private System.Windows.Forms.Button btStartBuff;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.GroupBox groupBox30;
        private LxControl.LxLedControl lxLed_cmdTime;
        private System.Windows.Forms.Label label86;
        private LxControl.LxLedControl lxLed_Btoltime;
        private System.Windows.Forms.Label label91;
        private LxControl.LxLedControl lxLed_Btoltag;
        private System.Windows.Forms.Label label92;
        private LxControl.LxLedControl lxLed_Bcmdsud;
        private System.Windows.Forms.Label label94;
        private LxControl.LxLedControl lxLed_BNum;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Timer timer_Buff;
        private System.Windows.Forms.Button btExtWrite;
        private System.Windows.Forms.Button btExtRead;
        private System.Windows.Forms.GroupBox group_maxtime;
        private System.Windows.Forms.Button btSetMaxtime;
        private System.Windows.Forms.ComboBox comboBox_maxtime;
        private System.Windows.Forms.CheckBox checkBox_rate;
        private System.Windows.Forms.TabPage tabPage_Module;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.GroupBox groupBox32;
        private System.Windows.Forms.ComboBox com_MFliterTime;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.GroupBox groupBox28;
        private System.Windows.Forms.ComboBox COM_MRPTime;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton MRB_6B;
        private System.Windows.Forms.RadioButton MRB_G2;
        private System.Windows.Forms.GroupBox groupBox33;
        private System.Windows.Forms.ComboBox com_MS;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.ComboBox com_MQ;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.GroupBox groupBox38;
        private System.Windows.Forms.TextBox txt_Mtidlen;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.TextBox txt_mtidaddr;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.GroupBox groupBox34;
        private System.Windows.Forms.TextBox txt_Mdata;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.TextBox txt_Mlen;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.TextBox txt_Maddr;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.RadioButton RBM_USER;
        private System.Windows.Forms.RadioButton RBM_TID;
        private System.Windows.Forms.RadioButton RBM_EPC;
        private System.Windows.Forms.Button btMGetParameter;
        private System.Windows.Forms.GroupBox groupBox39;
        private System.Windows.Forms.Button btSetMmode;
        private System.Windows.Forms.ComboBox com_Mmode;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Button btMSetParameter;
        private System.Windows.Forms.TabPage tabPage_Realtime;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.GroupBox groupBox41;
        private LxControl.LxLedControl lxLed_Mtime;
        private System.Windows.Forms.Label label113;
        private LxControl.LxLedControl lxLed_Mtag;
        private System.Windows.Forms.Label label116;
        private System.Windows.Forms.GroupBox groupBox42;
        private System.Windows.Forms.Button btStartMactive;
        private System.Windows.Forms.Timer timer_RealTime;
        private System.Windows.Forms.CheckBox checkBox_tid;
        private System.Windows.Forms.CheckBox checkBox_mask;
        private System.Windows.Forms.RadioButton radioButton_band8;
        private System.Windows.Forms.GroupBox gbp_wpower;
        private System.Windows.Forms.RadioButton rb_wp2;
        private System.Windows.Forms.RadioButton rb_wp1;
        private System.Windows.Forms.Button bt_GetWpower;
        private System.Windows.Forms.Button bt_SetWpower;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.ComboBox com_wpower;
        private System.Windows.Forms.GroupBox gbp_Retry;
        private System.Windows.Forms.ComboBox com_retrytimes;
        private System.Windows.Forms.Button bt_Getretry;
        private System.Windows.Forms.Button bt_Setretry;
        private System.Windows.Forms.GroupBox gbp_MixRead;
        private System.Windows.Forms.ComboBox com_MixMem;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.RadioButton rb_mix;
        private System.Windows.Forms.TextBox text_readpsd;
        private System.Windows.Forms.Label label118;
        private System.Windows.Forms.TextBox text_readLen;
        private System.Windows.Forms.Label label117;
        private System.Windows.Forms.TextBox text_readadr;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.RadioButton rb_fastid;
        private LxControl.LxLedControl lxLedControl6;
        private System.Windows.Forms.Label label119;
        private System.Windows.Forms.GroupBox gbp_DRM;
        private System.Windows.Forms.RadioButton DRM_CLOSE;
        private System.Windows.Forms.RadioButton DRM_OPEN;
        private System.Windows.Forms.Button bt_GetDRM;
        private System.Windows.Forms.Button bt_setDRM;
        private System.Windows.Forms.GroupBox gbReturnLoss;
        private System.Windows.Forms.Label label120;
        private System.Windows.Forms.Label label121;
        private System.Windows.Forms.ComboBox cmbReturnLossFreq;
        private System.Windows.Forms.Label label122;
        private System.Windows.Forms.TextBox textReturnLoss;
        private System.Windows.Forms.Button btReturnLoss;
        private System.Windows.Forms.GroupBox gbCmdTemperature;
        private System.Windows.Forms.Button btnGetReaderTemperature;
        private System.Windows.Forms.TextBox txtReaderTemperature;
        private System.Windows.Forms.ComboBox cbbAnt;
        private System.Windows.Forms.CheckBox ckClearOperationRec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.RadioButton radioButton_band12;
    }
}

