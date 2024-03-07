namespace TcpUdp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTcpServerReceived = new Label();
            txtTcpServerSendTxt = new TextBox();
            lblTcpServerSend = new Label();
            txtTcpServerReceivedTxt = new TextBox();
            btnTcpServerListen = new Button();
            txtTcpServerPort = new TextBox();
            lblTcpServerPort = new Label();
            tabPage2 = new TabPage();
            button1 = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            label2 = new Label();
            txtTcpClientSend = new TextBox();
            label3 = new Label();
            txtTcpClientReceive = new TextBox();
            btnTcpClientSend = new Button();
            txtTcpClientIp = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtTcpClientPort = new TextBox();
            btTcpClientConect = new Button();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            btnColorPicker = new Button();
            btnUdpClientSend = new Button();
            txtUdpClientIP = new TextBox();
            lblUpdClientIP = new Label();
            btnUdpClientConnect = new Button();
            txtUdpClientPort = new TextBox();
            lblUdpClientPort = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblUpdClientReceived = new Label();
            txtUdpClientSend = new TextBox();
            lblUpdClientSend = new Label();
            txtUdpClientReceived = new TextBox();
            colorDialog1 = new ColorDialog();
            label1 = new Label();
            textBox1 = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tabPage4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(11, 9);
            tabControl1.Margin = new Padding(2, 2, 2, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1419, 577);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Controls.Add(btnTcpServerListen);
            tabPage1.Controls.Add(txtTcpServerPort);
            tabPage1.Controls.Add(lblTcpServerPort);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2, 2, 2, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 2, 2, 2);
            tabPage1.Size = new Size(1684, 549);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "TCP Server";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblTcpServerReceived, 0, 0);
            tableLayoutPanel1.Controls.Add(txtTcpServerSendTxt, 0, 3);
            tableLayoutPanel1.Controls.Add(lblTcpServerSend, 0, 2);
            tableLayoutPanel1.Controls.Add(txtTcpServerReceivedTxt, 0, 1);
            tableLayoutPanel1.Location = new Point(5, 31);
            tableLayoutPanel1.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.301887F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 91.69811F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 174F));
            tableLayoutPanel1.Size = new Size(1675, 517);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lblTcpServerReceived
            // 
            lblTcpServerReceived.AutoSize = true;
            lblTcpServerReceived.Location = new Point(2, 0);
            lblTcpServerReceived.Margin = new Padding(2, 0, 2, 0);
            lblTcpServerReceived.Name = "lblTcpServerReceived";
            lblTcpServerReceived.Size = new Size(57, 15);
            lblTcpServerReceived.TabIndex = 6;
            lblTcpServerReceived.Text = "Received:";
            // 
            // txtTcpServerSendTxt
            // 
            txtTcpServerSendTxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTcpServerSendTxt.Location = new Point(2, 344);
            txtTcpServerSendTxt.Margin = new Padding(2, 2, 2, 2);
            txtTcpServerSendTxt.Multiline = true;
            txtTcpServerSendTxt.Name = "txtTcpServerSendTxt";
            txtTcpServerSendTxt.ScrollBars = ScrollBars.Both;
            txtTcpServerSendTxt.Size = new Size(1671, 171);
            txtTcpServerSendTxt.TabIndex = 4;
            // 
            // lblTcpServerSend
            // 
            lblTcpServerSend.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTcpServerSend.AutoSize = true;
            lblTcpServerSend.Location = new Point(2, 327);
            lblTcpServerSend.Margin = new Padding(2, 0, 2, 0);
            lblTcpServerSend.Name = "lblTcpServerSend";
            lblTcpServerSend.Size = new Size(36, 15);
            lblTcpServerSend.TabIndex = 5;
            lblTcpServerSend.Text = "Send:";
            // 
            // txtTcpServerReceivedTxt
            // 
            txtTcpServerReceivedTxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTcpServerReceivedTxt.Location = new Point(2, 27);
            txtTcpServerReceivedTxt.Margin = new Padding(2, 2, 2, 2);
            txtTcpServerReceivedTxt.Multiline = true;
            txtTcpServerReceivedTxt.Name = "txtTcpServerReceivedTxt";
            txtTcpServerReceivedTxt.ReadOnly = true;
            txtTcpServerReceivedTxt.ScrollBars = ScrollBars.Both;
            txtTcpServerReceivedTxt.Size = new Size(1671, 283);
            txtTcpServerReceivedTxt.TabIndex = 3;
            // 
            // btnTcpServerListen
            // 
            btnTcpServerListen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTcpServerListen.Location = new Point(1598, 4);
            btnTcpServerListen.Margin = new Padding(2, 2, 2, 2);
            btnTcpServerListen.Name = "btnTcpServerListen";
            btnTcpServerListen.Size = new Size(82, 22);
            btnTcpServerListen.TabIndex = 2;
            btnTcpServerListen.Text = "Listen";
            btnTcpServerListen.UseVisualStyleBackColor = true;
            // 
            // txtTcpServerPort
            // 
            txtTcpServerPort.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTcpServerPort.Location = new Point(1473, 6);
            txtTcpServerPort.Margin = new Padding(2, 2, 2, 2);
            txtTcpServerPort.Name = "txtTcpServerPort";
            txtTcpServerPort.Size = new Size(110, 23);
            txtTcpServerPort.TabIndex = 1;
            // 
            // lblTcpServerPort
            // 
            lblTcpServerPort.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTcpServerPort.AutoSize = true;
            lblTcpServerPort.Location = new Point(1424, 8);
            lblTcpServerPort.Margin = new Padding(2, 0, 2, 0);
            lblTcpServerPort.Name = "lblTcpServerPort";
            lblTcpServerPort.Size = new Size(32, 15);
            lblTcpServerPort.TabIndex = 0;
            lblTcpServerPort.Text = "Port:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(tableLayoutPanel4);
            tabPage2.Controls.Add(btnTcpClientSend);
            tabPage2.Controls.Add(txtTcpClientIp);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(txtTcpClientPort);
            tabPage2.Controls.Add(btTcpClientConect);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2, 2, 2, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 2, 2, 2);
            tabPage2.Size = new Size(1400, 549);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "TCP Client";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(571, 5);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 17;
            button1.Text = "Color";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnColorPickerTcpClient_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label2, 0, 0);
            tableLayoutPanel4.Controls.Add(txtTcpClientSend, 0, 3);
            tableLayoutPanel4.Controls.Add(label3, 0, 2);
            tableLayoutPanel4.Controls.Add(txtTcpClientReceive, 0, 1);
            tableLayoutPanel4.Location = new Point(5, 31);
            tableLayoutPanel4.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 8.301887F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 91.69811F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 174F));
            tableLayoutPanel4.Size = new Size(1391, 517);
            tableLayoutPanel4.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 0);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 6;
            label2.Text = "Received:";
            // 
            // txtTcpClientSend
            // 
            txtTcpClientSend.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTcpClientSend.Location = new Point(2, 344);
            txtTcpClientSend.Margin = new Padding(2, 2, 2, 2);
            txtTcpClientSend.Multiline = true;
            txtTcpClientSend.Name = "txtTcpClientSend";
            txtTcpClientSend.ScrollBars = ScrollBars.Both;
            txtTcpClientSend.Size = new Size(1387, 171);
            txtTcpClientSend.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(2, 327);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 5;
            label3.Text = "Send:";
            // 
            // txtTcpClientReceive
            // 
            txtTcpClientReceive.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTcpClientReceive.Location = new Point(2, 27);
            txtTcpClientReceive.Margin = new Padding(2, 2, 2, 2);
            txtTcpClientReceive.Multiline = true;
            txtTcpClientReceive.Name = "txtTcpClientReceive";
            txtTcpClientReceive.ReadOnly = true;
            txtTcpClientReceive.ScrollBars = ScrollBars.Both;
            txtTcpClientReceive.Size = new Size(1387, 283);
            txtTcpClientReceive.TabIndex = 3;
            // 
            // btnTcpClientSend
            // 
            btnTcpClientSend.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTcpClientSend.Location = new Point(658, 5);
            btnTcpClientSend.Margin = new Padding(2, 2, 2, 2);
            btnTcpClientSend.Name = "btnTcpClientSend";
            btnTcpClientSend.Size = new Size(82, 22);
            btnTcpClientSend.TabIndex = 16;
            btnTcpClientSend.Text = "Send";
            btnTcpClientSend.UseVisualStyleBackColor = true;
            btnTcpClientSend.Click += btnTcpClientSend_Click;
            // 
            // txtTcpClientIp
            // 
            txtTcpClientIp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTcpClientIp.Location = new Point(784, 6);
            txtTcpClientIp.Margin = new Padding(2, 2, 2, 2);
            txtTcpClientIp.Name = "txtTcpClientIp";
            txtTcpClientIp.Size = new Size(348, 23);
            txtTcpClientIp.TabIndex = 15;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(1137, 9);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 11;
            label5.Text = "Port:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(746, 9);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(20, 15);
            label4.TabIndex = 14;
            label4.Text = "IP:";
            // 
            // txtTcpClientPort
            // 
            txtTcpClientPort.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTcpClientPort.Location = new Point(1186, 6);
            txtTcpClientPort.Margin = new Padding(2, 2, 2, 2);
            txtTcpClientPort.Name = "txtTcpClientPort";
            txtTcpClientPort.Size = new Size(110, 23);
            txtTcpClientPort.TabIndex = 12;
            // 
            // btTcpClientConect
            // 
            btTcpClientConect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btTcpClientConect.Location = new Point(1310, 5);
            btTcpClientConect.Margin = new Padding(2, 2, 2, 2);
            btTcpClientConect.Name = "btTcpClientConect";
            btTcpClientConect.Size = new Size(82, 22);
            btTcpClientConect.TabIndex = 13;
            btTcpClientConect.Text = "Connect";
            btTcpClientConect.UseVisualStyleBackColor = true;
            btTcpClientConect.Click += btTcpClientConect_Click;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(2, 2, 2, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1400, 549);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "UDP Server";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(btnColorPicker);
            tabPage4.Controls.Add(btnUdpClientSend);
            tabPage4.Controls.Add(txtUdpClientIP);
            tabPage4.Controls.Add(lblUpdClientIP);
            tabPage4.Controls.Add(btnUdpClientConnect);
            tabPage4.Controls.Add(txtUdpClientPort);
            tabPage4.Controls.Add(lblUdpClientPort);
            tabPage4.Controls.Add(tableLayoutPanel2);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Margin = new Padding(2, 2, 2, 2);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1411, 549);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "UDP Client";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnColorPicker
            // 
            btnColorPicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnColorPicker.Location = new Point(586, 3);
            btnColorPicker.Margin = new Padding(2, 2, 2, 2);
            btnColorPicker.Name = "btnColorPicker";
            btnColorPicker.Size = new Size(82, 22);
            btnColorPicker.TabIndex = 10;
            btnColorPicker.Text = "Color";
            btnColorPicker.UseVisualStyleBackColor = true;
            btnColorPicker.Click += btnColorPicker_Click;
            // 
            // btnUdpClientSend
            // 
            btnUdpClientSend.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUdpClientSend.Location = new Point(673, 2);
            btnUdpClientSend.Margin = new Padding(2, 2, 2, 2);
            btnUdpClientSend.Name = "btnUdpClientSend";
            btnUdpClientSend.Size = new Size(82, 22);
            btnUdpClientSend.TabIndex = 9;
            btnUdpClientSend.Text = "Send";
            btnUdpClientSend.UseVisualStyleBackColor = true;
            btnUdpClientSend.Click += btnUdpClientSend_Click;
            // 
            // txtUdpClientIP
            // 
            txtUdpClientIP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtUdpClientIP.Location = new Point(799, 4);
            txtUdpClientIP.Margin = new Padding(2, 2, 2, 2);
            txtUdpClientIP.Name = "txtUdpClientIP";
            txtUdpClientIP.Size = new Size(348, 23);
            txtUdpClientIP.TabIndex = 8;
            // 
            // lblUpdClientIP
            // 
            lblUpdClientIP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUpdClientIP.AutoSize = true;
            lblUpdClientIP.Location = new Point(761, 6);
            lblUpdClientIP.Margin = new Padding(2, 0, 2, 0);
            lblUpdClientIP.Name = "lblUpdClientIP";
            lblUpdClientIP.Size = new Size(20, 15);
            lblUpdClientIP.TabIndex = 7;
            lblUpdClientIP.Text = "IP:";
            // 
            // btnUdpClientConnect
            // 
            btnUdpClientConnect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUdpClientConnect.Location = new Point(1325, 4);
            btnUdpClientConnect.Margin = new Padding(2, 2, 2, 2);
            btnUdpClientConnect.Name = "btnUdpClientConnect";
            btnUdpClientConnect.Size = new Size(82, 22);
            btnUdpClientConnect.TabIndex = 6;
            btnUdpClientConnect.Text = "Connect";
            btnUdpClientConnect.UseVisualStyleBackColor = true;
            btnUdpClientConnect.Click += btnUdpClientConnect_Click;
            // 
            // txtUdpClientPort
            // 
            txtUdpClientPort.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtUdpClientPort.Location = new Point(1200, 6);
            txtUdpClientPort.Margin = new Padding(2, 2, 2, 2);
            txtUdpClientPort.Name = "txtUdpClientPort";
            txtUdpClientPort.Size = new Size(110, 23);
            txtUdpClientPort.TabIndex = 4;
            // 
            // lblUdpClientPort
            // 
            lblUdpClientPort.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUdpClientPort.AutoSize = true;
            lblUdpClientPort.Location = new Point(1151, 8);
            lblUdpClientPort.Margin = new Padding(2, 0, 2, 0);
            lblUdpClientPort.Name = "lblUdpClientPort";
            lblUdpClientPort.Size = new Size(32, 15);
            lblUdpClientPort.TabIndex = 3;
            lblUdpClientPort.Text = "Port:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(lblUpdClientReceived, 0, 0);
            tableLayoutPanel2.Controls.Add(txtUdpClientSend, 0, 3);
            tableLayoutPanel2.Controls.Add(lblUpdClientSend, 0, 2);
            tableLayoutPanel2.Controls.Add(txtUdpClientReceived, 0, 1);
            tableLayoutPanel2.Location = new Point(5, 31);
            tableLayoutPanel2.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8.301887F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 91.69811F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 174F));
            tableLayoutPanel2.Size = new Size(1402, 517);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // lblUpdClientReceived
            // 
            lblUpdClientReceived.AutoSize = true;
            lblUpdClientReceived.Location = new Point(2, 0);
            lblUpdClientReceived.Margin = new Padding(2, 0, 2, 0);
            lblUpdClientReceived.Name = "lblUpdClientReceived";
            lblUpdClientReceived.Size = new Size(57, 15);
            lblUpdClientReceived.TabIndex = 6;
            lblUpdClientReceived.Text = "Received:";
            // 
            // txtUdpClientSend
            // 
            txtUdpClientSend.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUdpClientSend.Location = new Point(2, 344);
            txtUdpClientSend.Margin = new Padding(2, 2, 2, 2);
            txtUdpClientSend.Multiline = true;
            txtUdpClientSend.Name = "txtUdpClientSend";
            txtUdpClientSend.ScrollBars = ScrollBars.Both;
            txtUdpClientSend.Size = new Size(1398, 171);
            txtUdpClientSend.TabIndex = 4;
            // 
            // lblUpdClientSend
            // 
            lblUpdClientSend.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblUpdClientSend.AutoSize = true;
            lblUpdClientSend.Location = new Point(2, 327);
            lblUpdClientSend.Margin = new Padding(2, 0, 2, 0);
            lblUpdClientSend.Name = "lblUpdClientSend";
            lblUpdClientSend.Size = new Size(36, 15);
            lblUpdClientSend.TabIndex = 5;
            lblUpdClientSend.Text = "Send:";
            // 
            // txtUdpClientReceived
            // 
            txtUdpClientReceived.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUdpClientReceived.Location = new Point(2, 27);
            txtUdpClientReceived.Margin = new Padding(2, 2, 2, 2);
            txtUdpClientReceived.Multiline = true;
            txtUdpClientReceived.Name = "txtUdpClientReceived";
            txtUdpClientReceived.ReadOnly = true;
            txtUdpClientReceived.ScrollBars = ScrollBars.Both;
            txtUdpClientReceived.Size = new Size(1398, 283);
            txtUdpClientReceived.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 0);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 6;
            label1.Text = "Received:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(6, 47);
            textBox1.Margin = new Padding(6);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(188, 465);
            textBox1.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1441, 596);
            Controls.Add(tabControl1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TcpUdp";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TextBox txtTcpServerPort;
        private Label lblTcpServerPort;
        private Button btnTcpServerListen;
        private TextBox txtTcpServerReceivedTxt;
        private TextBox txtTcpServerSendTxt;
        private Label lblTcpServerSend;
        private Label lblTcpServerReceived;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnUdpClientConnect;
        private TextBox txtUdpClientPort;
        private Label lblUdpClientPort;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblUpdClientReceived;
        private TextBox txtUdpClientSend;
        private Label lblUpdClientSend;
        private TextBox txtUdpClientReceived;
        private TextBox txtUdpClientIP;
        private Label lblUpdClientIP;
        private Button btnUdpClientSend;
        private ColorDialog colorDialog1;
        private Button btnColorPicker;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label2;
        private TextBox txtTcpClientSend;
        private Label label3;
        private TextBox txtTcpClientReceive;
        private Label label1;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button1;
        private Button btnTcpClientSend;
        private TextBox txtTcpClientIp;
        private Label label5;
        private Label label4;
        private TextBox txtTcpClientPort;
        private Button btTcpClientConect;
    }
}
