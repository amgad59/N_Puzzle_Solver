namespace Puzzle_Solver
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            selectTest_cb = new ComboBox();
            groupBox1 = new GroupBox();
            BFS_rb = new RadioButton();
            manhattan_rb = new RadioButton();
            hamming_rb = new RadioButton();
            puzzleSize_tb = new TextBox();
            label6 = new Label();
            simulateSolve_btn = new Button();
            insertPuzzle_btn = new Button();
            label7 = new Label();
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Modern No. 20", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(343, 47);
            label1.Name = "label1";
            label1.Size = new Size(197, 50);
            label1.TabIndex = 0;
            label1.Text = "N puzzle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Mongolian Baiti", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(486, 190);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 1;
            label2.Text = "Puzzle size";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Mongolian Baiti", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(593, 151);
            label3.Name = "label3";
            label3.Size = new Size(158, 25);
            label3.TabIndex = 2;
            label3.Text = "Create puzzle";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Mongolian Baiti", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(93, 151);
            label4.Name = "label4";
            label4.Size = new Size(243, 25);
            label4.TabIndex = 3;
            label4.Text = "Select existing puzzle";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Mongolian Baiti", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(25, 190);
            label5.Name = "label5";
            label5.Size = new Size(130, 25);
            label5.TabIndex = 4;
            label5.Text = "Select Test";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Location = new Point(444, 156);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(6, 232);
            panel1.TabIndex = 5;
            // 
            // selectTest_cb
            // 
            selectTest_cb.BackColor = Color.FromArgb(224, 224, 224);
            selectTest_cb.FormattingEnabled = true;
            selectTest_cb.Location = new Point(178, 193);
            selectTest_cb.Margin = new Padding(3, 2, 3, 2);
            selectTest_cb.Name = "selectTest_cb";
            selectTest_cb.Size = new Size(215, 23);
            selectTest_cb.TabIndex = 6;
            selectTest_cb.SelectedIndexChanged += selectTest_cb_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(BFS_rb);
            groupBox1.Controls.Add(manhattan_rb);
            groupBox1.Controls.Add(hamming_rb);
            groupBox1.Font = new Font("Mongolian Baiti", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(116, 235);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(225, 112);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Solve by";
            // 
            // BFS_rb
            // 
            BFS_rb.AutoSize = true;
            BFS_rb.Location = new Point(52, 82);
            BFS_rb.Margin = new Padding(3, 2, 3, 2);
            BFS_rb.Name = "BFS_rb";
            BFS_rb.Size = new Size(54, 19);
            BFS_rb.TabIndex = 2;
            BFS_rb.TabStop = true;
            BFS_rb.Text = "DFS";
            BFS_rb.UseVisualStyleBackColor = true;
            // 
            // manhattan_rb
            // 
            manhattan_rb.AutoSize = true;
            manhattan_rb.Location = new Point(52, 20);
            manhattan_rb.Margin = new Padding(3, 2, 3, 2);
            manhattan_rb.Name = "manhattan_rb";
            manhattan_rb.Size = new Size(93, 19);
            manhattan_rb.TabIndex = 1;
            manhattan_rb.TabStop = true;
            manhattan_rb.Text = "Manhattan";
            manhattan_rb.UseVisualStyleBackColor = true;
            // 
            // hamming_rb
            // 
            hamming_rb.AutoSize = true;
            hamming_rb.Location = new Point(52, 55);
            hamming_rb.Margin = new Padding(3, 2, 3, 2);
            hamming_rb.Name = "hamming_rb";
            hamming_rb.Size = new Size(88, 19);
            hamming_rb.TabIndex = 0;
            hamming_rb.TabStop = true;
            hamming_rb.Text = "Hamming";
            hamming_rb.UseVisualStyleBackColor = true;
            // 
            // puzzleSize_tb
            // 
            puzzleSize_tb.BackColor = Color.LightGray;
            puzzleSize_tb.Font = new Font("Modern No. 20", 12F, FontStyle.Bold, GraphicsUnit.Point);
            puzzleSize_tb.Location = new Point(644, 192);
            puzzleSize_tb.Margin = new Padding(3, 2, 3, 2);
            puzzleSize_tb.Name = "puzzleSize_tb";
            puzzleSize_tb.Size = new Size(81, 25);
            puzzleSize_tb.TabIndex = 8;
            puzzleSize_tb.Text = "N";
            puzzleSize_tb.TextAlign = HorizontalAlignment.Center;
            puzzleSize_tb.TextChanged += puzzleSize_tb_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Mongolian Baiti", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(738, 201);
            label6.Name = "label6";
            label6.Size = new Size(70, 13);
            label6.TabIndex = 9;
            label6.Text = "N x N puzzle";
            // 
            // simulateSolve_btn
            // 
            simulateSolve_btn.BackColor = Color.Gainsboro;
            simulateSolve_btn.Font = new Font("Mongolian Baiti", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            simulateSolve_btn.Location = new Point(132, 351);
            simulateSolve_btn.Margin = new Padding(3, 2, 3, 2);
            simulateSolve_btn.Name = "simulateSolve_btn";
            simulateSolve_btn.Size = new Size(197, 37);
            simulateSolve_btn.TabIndex = 10;
            simulateSolve_btn.Text = "Simulate solve";
            simulateSolve_btn.UseVisualStyleBackColor = false;
            simulateSolve_btn.Click += simulateSolve_btn_Click;
            // 
            // insertPuzzle_btn
            // 
            insertPuzzle_btn.BackColor = Color.LightGray;
            insertPuzzle_btn.Font = new Font("Mongolian Baiti", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            insertPuzzle_btn.Location = new Point(593, 235);
            insertPuzzle_btn.Margin = new Padding(3, 2, 3, 2);
            insertPuzzle_btn.Name = "insertPuzzle_btn";
            insertPuzzle_btn.Size = new Size(197, 37);
            insertPuzzle_btn.TabIndex = 11;
            insertPuzzle_btn.Text = "Insert puzzle";
            insertPuzzle_btn.UseVisualStyleBackColor = false;
            insertPuzzle_btn.Click += insertPuzzle_btn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Mongolian Baiti", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(472, 327);
            label7.Name = "label7";
            label7.Size = new Size(150, 25);
            label7.TabIndex = 12;
            label7.Text = "Load puzzle:";
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Font = new Font("Mongolian Baiti", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(644, 325);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(156, 29);
            button1.TabIndex = 13;
            button1.Text = "Explore";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(880, 397);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(insertPuzzle_btn);
            Controls.Add(simulateSolve_btn);
            Controls.Add(label6);
            Controls.Add(puzzleSize_tb);
            Controls.Add(groupBox1);
            Controls.Add(selectTest_cb);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "N puzzle";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private ComboBox selectTest_cb;
        private GroupBox groupBox1;
        private RadioButton manhattan_rb;
        private RadioButton hamming_rb;
        private TextBox puzzleSize_tb;
        private Label label6;
        private Button simulateSolve_btn;
        private Button insertPuzzle_btn;
        private Label label7;
        private Button button1;
        private OpenFileDialog openFileDialog1;
        private RadioButton BFS_rb;
    }
}