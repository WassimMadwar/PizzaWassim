namespace Pizza
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
            this.Size_Box = new System.Windows.Forms.GroupBox();
            this.rb_Large = new System.Windows.Forms.RadioButton();
            this.rb_Medium = new System.Windows.Forms.RadioButton();
            this.rb_Smal = new System.Windows.Forms.RadioButton();
            this.CrustType_Box = new System.Windows.Forms.GroupBox();
            this.rb_Think = new System.Windows.Forms.RadioButton();
            this.rb_Thin = new System.Windows.Forms.RadioButton();
            this.rb_Normal = new System.Windows.Forms.RadioButton();
            this.Toppings_Box = new System.Windows.Forms.GroupBox();
            this.chk_Pappers = new System.Windows.Forms.CheckBox();
            this.chk_Olives = new System.Windows.Forms.CheckBox();
            this.chk_Onion = new System.Windows.Forms.CheckBox();
            this.chk_Tomatoes = new System.Windows.Forms.CheckBox();
            this.chk_Mushrooms = new System.Windows.Forms.CheckBox();
            this.chk_ExtraChese = new System.Windows.Forms.CheckBox();
            this.WhereToEat_Box = new System.Windows.Forms.GroupBox();
            this.rb_TakeOut = new System.Windows.Forms.RadioButton();
            this.rb_EatIn = new System.Windows.Forms.RadioButton();
            this.OrderForm_Box = new System.Windows.Forms.GroupBox();
            this.btn_RestForm = new System.Windows.Forms.Button();
            this.btn_OkOrder = new System.Windows.Forms.Button();
            this.OrderSummary_Box = new System.Windows.Forms.GroupBox();
            this.tb_Toppings = new System.Windows.Forms.TextBox();
            this.tb_Eat = new System.Windows.Forms.TextBox();
            this.tb_CrustType = new System.Windows.Forms.TextBox();
            this.tb_SizePizza = new System.Windows.Forms.TextBox();
            this.lb_Toppings = new System.Windows.Forms.Label();
            this.lb_Eat = new System.Windows.Forms.Label();
            this.lb_Crust = new System.Windows.Forms.Label();
            this.lb_SizePizza = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_TotalPrise = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.Size_Box.SuspendLayout();
            this.CrustType_Box.SuspendLayout();
            this.Toppings_Box.SuspendLayout();
            this.WhereToEat_Box.SuspendLayout();
            this.OrderForm_Box.SuspendLayout();
            this.OrderSummary_Box.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Size_Box
            // 
            this.Size_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Size_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Size_Box.Controls.Add(this.rb_Large);
            this.Size_Box.Controls.Add(this.rb_Medium);
            this.Size_Box.Controls.Add(this.rb_Smal);
            this.Size_Box.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Size_Box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Size_Box.Font = new System.Drawing.Font("Freestyle Script", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Size_Box.ForeColor = System.Drawing.Color.Red;
            this.Size_Box.Location = new System.Drawing.Point(63, 25);
            this.Size_Box.Margin = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.Size_Box.Name = "Size_Box";
            this.Size_Box.Padding = new System.Windows.Forms.Padding(4);
            this.Size_Box.Size = new System.Drawing.Size(193, 247);
            this.Size_Box.TabIndex = 0;
            this.Size_Box.TabStop = false;
            this.Size_Box.Text = "Size";
            // 
            // rb_Large
            // 
            this.rb_Large.AutoSize = true;
            this.rb_Large.Font = new System.Drawing.Font("Freestyle Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Large.ForeColor = System.Drawing.Color.Black;
            this.rb_Large.Location = new System.Drawing.Point(21, 188);
            this.rb_Large.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Large.Name = "rb_Large";
            this.rb_Large.Size = new System.Drawing.Size(70, 36);
            this.rb_Large.TabIndex = 2;
            this.rb_Large.TabStop = true;
            this.rb_Large.Tag = "12";
            this.rb_Large.Text = "Large";
            this.rb_Large.UseVisualStyleBackColor = true;
            this.rb_Large.CheckedChanged += new System.EventHandler(this.rb_Large_CheckedChanged);
            // 
            // rb_Medium
            // 
            this.rb_Medium.AutoSize = true;
            this.rb_Medium.Font = new System.Drawing.Font("Freestyle Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Medium.ForeColor = System.Drawing.Color.Black;
            this.rb_Medium.Location = new System.Drawing.Point(21, 126);
            this.rb_Medium.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Medium.Name = "rb_Medium";
            this.rb_Medium.Size = new System.Drawing.Size(82, 36);
            this.rb_Medium.TabIndex = 1;
            this.rb_Medium.TabStop = true;
            this.rb_Medium.Tag = "10";
            this.rb_Medium.Text = "Medium";
            this.rb_Medium.UseVisualStyleBackColor = true;
            this.rb_Medium.CheckedChanged += new System.EventHandler(this.rb_Medium_CheckedChanged);
            // 
            // rb_Smal
            // 
            this.rb_Smal.AutoSize = true;
            this.rb_Smal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rb_Smal.Font = new System.Drawing.Font("Freestyle Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Smal.ForeColor = System.Drawing.Color.Black;
            this.rb_Smal.Location = new System.Drawing.Point(21, 64);
            this.rb_Smal.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Smal.Name = "rb_Smal";
            this.rb_Smal.Size = new System.Drawing.Size(68, 36);
            this.rb_Smal.TabIndex = 0;
            this.rb_Smal.TabStop = true;
            this.rb_Smal.Tag = "8";
            this.rb_Smal.Text = "Small";
            this.rb_Smal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_Smal.UseVisualStyleBackColor = true;
            this.rb_Smal.CheckedChanged += new System.EventHandler(this.rb_Smal_CheckedChanged);
            // 
            // CrustType_Box
            // 
            this.CrustType_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CrustType_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CrustType_Box.Controls.Add(this.rb_Think);
            this.CrustType_Box.Controls.Add(this.rb_Thin);
            this.CrustType_Box.Controls.Add(this.rb_Normal);
            this.CrustType_Box.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CrustType_Box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CrustType_Box.Font = new System.Drawing.Font("Freestyle Script", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrustType_Box.ForeColor = System.Drawing.Color.Red;
            this.CrustType_Box.Location = new System.Drawing.Point(63, 293);
            this.CrustType_Box.Margin = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.CrustType_Box.Name = "CrustType_Box";
            this.CrustType_Box.Padding = new System.Windows.Forms.Padding(4);
            this.CrustType_Box.Size = new System.Drawing.Size(193, 251);
            this.CrustType_Box.TabIndex = 1;
            this.CrustType_Box.TabStop = false;
            this.CrustType_Box.Text = "Crust Type";
            // 
            // rb_Think
            // 
            this.rb_Think.AutoSize = true;
            this.rb_Think.Font = new System.Drawing.Font("Freestyle Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Think.ForeColor = System.Drawing.Color.Black;
            this.rb_Think.Location = new System.Drawing.Point(20, 181);
            this.rb_Think.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Think.Name = "rb_Think";
            this.rb_Think.Size = new System.Drawing.Size(75, 36);
            this.rb_Think.TabIndex = 4;
            this.rb_Think.TabStop = true;
            this.rb_Think.Tag = "4";
            this.rb_Think.Text = "Think";
            this.rb_Think.UseVisualStyleBackColor = true;
            this.rb_Think.CheckedChanged += new System.EventHandler(this.rb_Think_CheckedChanged);
            // 
            // rb_Thin
            // 
            this.rb_Thin.AutoSize = true;
            this.rb_Thin.Font = new System.Drawing.Font("Freestyle Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Thin.ForeColor = System.Drawing.Color.Black;
            this.rb_Thin.Location = new System.Drawing.Point(20, 121);
            this.rb_Thin.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Thin.Name = "rb_Thin";
            this.rb_Thin.Size = new System.Drawing.Size(65, 36);
            this.rb_Thin.TabIndex = 3;
            this.rb_Thin.TabStop = true;
            this.rb_Thin.Tag = "2";
            this.rb_Thin.Text = "Thin";
            this.rb_Thin.UseVisualStyleBackColor = true;
            this.rb_Thin.CheckedChanged += new System.EventHandler(this.rb_Thin_CheckedChanged);
            // 
            // rb_Normal
            // 
            this.rb_Normal.AutoSize = true;
            this.rb_Normal.Font = new System.Drawing.Font("Freestyle Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Normal.ForeColor = System.Drawing.Color.Black;
            this.rb_Normal.Location = new System.Drawing.Point(21, 62);
            this.rb_Normal.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Normal.Name = "rb_Normal";
            this.rb_Normal.Size = new System.Drawing.Size(81, 36);
            this.rb_Normal.TabIndex = 2;
            this.rb_Normal.TabStop = true;
            this.rb_Normal.Tag = "0";
            this.rb_Normal.Text = "Normal";
            this.rb_Normal.UseVisualStyleBackColor = true;
            this.rb_Normal.CheckedChanged += new System.EventHandler(this.rb_Normal_CheckedChanged);
            // 
            // Toppings_Box
            // 
            this.Toppings_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Toppings_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Toppings_Box.Controls.Add(this.chk_Pappers);
            this.Toppings_Box.Controls.Add(this.chk_Olives);
            this.Toppings_Box.Controls.Add(this.chk_Onion);
            this.Toppings_Box.Controls.Add(this.chk_Tomatoes);
            this.Toppings_Box.Controls.Add(this.chk_Mushrooms);
            this.Toppings_Box.Controls.Add(this.chk_ExtraChese);
            this.Toppings_Box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Toppings_Box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Toppings_Box.Font = new System.Drawing.Font("Freestyle Script", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Toppings_Box.ForeColor = System.Drawing.Color.Red;
            this.Toppings_Box.Location = new System.Drawing.Point(316, 25);
            this.Toppings_Box.Margin = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.Toppings_Box.Name = "Toppings_Box";
            this.Toppings_Box.Padding = new System.Windows.Forms.Padding(4);
            this.Toppings_Box.Size = new System.Drawing.Size(416, 247);
            this.Toppings_Box.TabIndex = 2;
            this.Toppings_Box.TabStop = false;
            this.Toppings_Box.Text = "Toppings";
            this.Toppings_Box.UseWaitCursor = true;
            // 
            // chk_Pappers
            // 
            this.chk_Pappers.AutoSize = true;
            this.chk_Pappers.Font = new System.Drawing.Font("Freestyle Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Pappers.ForeColor = System.Drawing.Color.Black;
            this.chk_Pappers.Location = new System.Drawing.Point(241, 188);
            this.chk_Pappers.Margin = new System.Windows.Forms.Padding(4);
            this.chk_Pappers.Name = "chk_Pappers";
            this.chk_Pappers.Size = new System.Drawing.Size(120, 36);
            this.chk_Pappers.TabIndex = 5;
            this.chk_Pappers.Tag = "2";
            this.chk_Pappers.Text = "Gr Pappers ";
            this.chk_Pappers.UseVisualStyleBackColor = true;
            this.chk_Pappers.UseWaitCursor = true;
            this.chk_Pappers.CheckedChanged += new System.EventHandler(this.chk_Pappers_CheckedChanged);
            // 
            // chk_Olives
            // 
            this.chk_Olives.AutoSize = true;
            this.chk_Olives.Font = new System.Drawing.Font("Freestyle Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Olives.ForeColor = System.Drawing.Color.Black;
            this.chk_Olives.Location = new System.Drawing.Point(241, 127);
            this.chk_Olives.Margin = new System.Windows.Forms.Padding(4);
            this.chk_Olives.Name = "chk_Olives";
            this.chk_Olives.Size = new System.Drawing.Size(77, 36);
            this.chk_Olives.TabIndex = 4;
            this.chk_Olives.Tag = "2";
            this.chk_Olives.Text = "Olives";
            this.chk_Olives.UseVisualStyleBackColor = true;
            this.chk_Olives.UseWaitCursor = true;
            this.chk_Olives.CheckedChanged += new System.EventHandler(this.chk_Olives_CheckedChanged);
            // 
            // chk_Onion
            // 
            this.chk_Onion.AutoSize = true;
            this.chk_Onion.Font = new System.Drawing.Font("Freestyle Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Onion.ForeColor = System.Drawing.Color.Black;
            this.chk_Onion.Location = new System.Drawing.Point(241, 64);
            this.chk_Onion.Margin = new System.Windows.Forms.Padding(4);
            this.chk_Onion.Name = "chk_Onion";
            this.chk_Onion.Size = new System.Drawing.Size(70, 36);
            this.chk_Onion.TabIndex = 3;
            this.chk_Onion.Tag = "3";
            this.chk_Onion.Text = "Onion";
            this.chk_Onion.UseVisualStyleBackColor = true;
            this.chk_Onion.UseWaitCursor = true;
            this.chk_Onion.CheckedChanged += new System.EventHandler(this.chk_Onion_CheckedChanged);
            // 
            // chk_Tomatoes
            // 
            this.chk_Tomatoes.AutoSize = true;
            this.chk_Tomatoes.Font = new System.Drawing.Font("Freestyle Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Tomatoes.ForeColor = System.Drawing.Color.Black;
            this.chk_Tomatoes.Location = new System.Drawing.Point(27, 188);
            this.chk_Tomatoes.Margin = new System.Windows.Forms.Padding(4);
            this.chk_Tomatoes.Name = "chk_Tomatoes";
            this.chk_Tomatoes.Size = new System.Drawing.Size(95, 36);
            this.chk_Tomatoes.TabIndex = 2;
            this.chk_Tomatoes.Tag = "3";
            this.chk_Tomatoes.Text = "Tomatoes";
            this.chk_Tomatoes.UseVisualStyleBackColor = true;
            this.chk_Tomatoes.UseWaitCursor = true;
            this.chk_Tomatoes.CheckedChanged += new System.EventHandler(this.chk_Tomatoes_CheckedChanged);
            // 
            // chk_Mushrooms
            // 
            this.chk_Mushrooms.AutoSize = true;
            this.chk_Mushrooms.Font = new System.Drawing.Font("Freestyle Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Mushrooms.ForeColor = System.Drawing.Color.Black;
            this.chk_Mushrooms.Location = new System.Drawing.Point(27, 126);
            this.chk_Mushrooms.Margin = new System.Windows.Forms.Padding(4);
            this.chk_Mushrooms.Name = "chk_Mushrooms";
            this.chk_Mushrooms.Size = new System.Drawing.Size(107, 36);
            this.chk_Mushrooms.TabIndex = 1;
            this.chk_Mushrooms.Tag = "2";
            this.chk_Mushrooms.Text = "Mushrooms";
            this.chk_Mushrooms.UseVisualStyleBackColor = true;
            this.chk_Mushrooms.UseWaitCursor = true;
            this.chk_Mushrooms.CheckedChanged += new System.EventHandler(this.chk_Mushrooms_CheckedChanged);
            // 
            // chk_ExtraChese
            // 
            this.chk_ExtraChese.AutoSize = true;
            this.chk_ExtraChese.Font = new System.Drawing.Font("Freestyle Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_ExtraChese.ForeColor = System.Drawing.Color.Black;
            this.chk_ExtraChese.Location = new System.Drawing.Point(27, 65);
            this.chk_ExtraChese.Margin = new System.Windows.Forms.Padding(4);
            this.chk_ExtraChese.Name = "chk_ExtraChese";
            this.chk_ExtraChese.Size = new System.Drawing.Size(121, 36);
            this.chk_ExtraChese.TabIndex = 0;
            this.chk_ExtraChese.Tag = "2";
            this.chk_ExtraChese.Text = "Extra Chese";
            this.chk_ExtraChese.UseVisualStyleBackColor = true;
            this.chk_ExtraChese.UseWaitCursor = true;
            this.chk_ExtraChese.CheckedChanged += new System.EventHandler(this.chk_ExtraChese_CheckedChanged);
            // 
            // WhereToEat_Box
            // 
            this.WhereToEat_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.WhereToEat_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.WhereToEat_Box.Controls.Add(this.rb_TakeOut);
            this.WhereToEat_Box.Controls.Add(this.rb_EatIn);
            this.WhereToEat_Box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.WhereToEat_Box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WhereToEat_Box.Font = new System.Drawing.Font("Freestyle Script", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhereToEat_Box.ForeColor = System.Drawing.Color.Red;
            this.WhereToEat_Box.Location = new System.Drawing.Point(316, 293);
            this.WhereToEat_Box.Margin = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.WhereToEat_Box.Name = "WhereToEat_Box";
            this.WhereToEat_Box.Padding = new System.Windows.Forms.Padding(4);
            this.WhereToEat_Box.Size = new System.Drawing.Size(416, 107);
            this.WhereToEat_Box.TabIndex = 3;
            this.WhereToEat_Box.TabStop = false;
            this.WhereToEat_Box.Text = "Where To Eat";
            this.WhereToEat_Box.UseWaitCursor = true;
            this.WhereToEat_Box.DragEnter += new System.Windows.Forms.DragEventHandler(this.WhereToEat_Box_DragEnter);
            // 
            // rb_TakeOut
            // 
            this.rb_TakeOut.AutoSize = true;
            this.rb_TakeOut.Font = new System.Drawing.Font("Freestyle Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_TakeOut.ForeColor = System.Drawing.Color.Black;
            this.rb_TakeOut.Location = new System.Drawing.Point(241, 60);
            this.rb_TakeOut.Margin = new System.Windows.Forms.Padding(4);
            this.rb_TakeOut.Name = "rb_TakeOut";
            this.rb_TakeOut.Size = new System.Drawing.Size(101, 36);
            this.rb_TakeOut.TabIndex = 5;
            this.rb_TakeOut.TabStop = true;
            this.rb_TakeOut.Tag = "-2";
            this.rb_TakeOut.Text = "Take Out";
            this.rb_TakeOut.UseVisualStyleBackColor = true;
            this.rb_TakeOut.UseWaitCursor = true;
            this.rb_TakeOut.CheckedChanged += new System.EventHandler(this.rb_TakeOut_CheckedChanged);
            // 
            // rb_EatIn
            // 
            this.rb_EatIn.AutoSize = true;
            this.rb_EatIn.Font = new System.Drawing.Font("Freestyle Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_EatIn.ForeColor = System.Drawing.Color.Black;
            this.rb_EatIn.Location = new System.Drawing.Point(27, 60);
            this.rb_EatIn.Margin = new System.Windows.Forms.Padding(4);
            this.rb_EatIn.Name = "rb_EatIn";
            this.rb_EatIn.Size = new System.Drawing.Size(73, 36);
            this.rb_EatIn.TabIndex = 4;
            this.rb_EatIn.TabStop = true;
            this.rb_EatIn.Tag = "2";
            this.rb_EatIn.Text = "Eat in";
            this.rb_EatIn.UseVisualStyleBackColor = true;
            this.rb_EatIn.UseWaitCursor = true;
            // 
            // OrderForm_Box
            // 
            this.OrderForm_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.OrderForm_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OrderForm_Box.Controls.Add(this.btn_RestForm);
            this.OrderForm_Box.Controls.Add(this.btn_OkOrder);
            this.OrderForm_Box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.OrderForm_Box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderForm_Box.Font = new System.Drawing.Font("Freestyle Script", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderForm_Box.ForeColor = System.Drawing.Color.Red;
            this.OrderForm_Box.Location = new System.Drawing.Point(316, 415);
            this.OrderForm_Box.Margin = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.OrderForm_Box.Name = "OrderForm_Box";
            this.OrderForm_Box.Padding = new System.Windows.Forms.Padding(4);
            this.OrderForm_Box.Size = new System.Drawing.Size(416, 130);
            this.OrderForm_Box.TabIndex = 4;
            this.OrderForm_Box.TabStop = false;
            this.OrderForm_Box.Text = "Order Form";
            this.OrderForm_Box.UseWaitCursor = true;
            // 
            // btn_RestForm
            // 
            this.btn_RestForm.Font = new System.Drawing.Font("Freestyle Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RestForm.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_RestForm.Location = new System.Drawing.Point(241, 60);
            this.btn_RestForm.Margin = new System.Windows.Forms.Padding(4);
            this.btn_RestForm.Name = "btn_RestForm";
            this.btn_RestForm.Size = new System.Drawing.Size(144, 44);
            this.btn_RestForm.TabIndex = 1;
            this.btn_RestForm.Text = "Rest Form";
            this.btn_RestForm.UseVisualStyleBackColor = true;
            this.btn_RestForm.UseWaitCursor = true;
            this.btn_RestForm.Click += new System.EventHandler(this.btn_RestForm_Click);
            // 
            // btn_OkOrder
            // 
            this.btn_OkOrder.Font = new System.Drawing.Font("Freestyle Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OkOrder.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_OkOrder.Location = new System.Drawing.Point(27, 63);
            this.btn_OkOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btn_OkOrder.Name = "btn_OkOrder";
            this.btn_OkOrder.Size = new System.Drawing.Size(144, 42);
            this.btn_OkOrder.TabIndex = 0;
            this.btn_OkOrder.Text = "Ok Order";
            this.btn_OkOrder.UseVisualStyleBackColor = true;
            this.btn_OkOrder.UseWaitCursor = true;
            this.btn_OkOrder.Click += new System.EventHandler(this.btn_OkOrder_Click);
            // 
            // OrderSummary_Box
            // 
            this.OrderSummary_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.OrderSummary_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OrderSummary_Box.Controls.Add(this.tb_Toppings);
            this.OrderSummary_Box.Controls.Add(this.tb_Eat);
            this.OrderSummary_Box.Controls.Add(this.tb_CrustType);
            this.OrderSummary_Box.Controls.Add(this.tb_SizePizza);
            this.OrderSummary_Box.Controls.Add(this.lb_Toppings);
            this.OrderSummary_Box.Controls.Add(this.lb_Eat);
            this.OrderSummary_Box.Controls.Add(this.lb_Crust);
            this.OrderSummary_Box.Controls.Add(this.lb_SizePizza);
            this.OrderSummary_Box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.OrderSummary_Box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderSummary_Box.Font = new System.Drawing.Font("Freestyle Script", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderSummary_Box.ForeColor = System.Drawing.Color.Red;
            this.OrderSummary_Box.Location = new System.Drawing.Point(793, 25);
            this.OrderSummary_Box.Margin = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.OrderSummary_Box.Name = "OrderSummary_Box";
            this.OrderSummary_Box.Padding = new System.Windows.Forms.Padding(4);
            this.OrderSummary_Box.Size = new System.Drawing.Size(416, 374);
            this.OrderSummary_Box.TabIndex = 5;
            this.OrderSummary_Box.TabStop = false;
            this.OrderSummary_Box.Text = "Order Summary";
            this.OrderSummary_Box.UseWaitCursor = true;
            // 
            // tb_Toppings
            // 
            this.tb_Toppings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tb_Toppings.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Toppings.Location = new System.Drawing.Point(4, 308);
            this.tb_Toppings.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Toppings.Multiline = true;
            this.tb_Toppings.Name = "tb_Toppings";
            this.tb_Toppings.ReadOnly = true;
            this.tb_Toppings.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tb_Toppings.Size = new System.Drawing.Size(408, 62);
            this.tb_Toppings.TabIndex = 9;
            this.tb_Toppings.Text = " No Toppings";
            this.tb_Toppings.UseWaitCursor = true;
            // 
            // tb_Eat
            // 
            this.tb_Eat.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Eat.Location = new System.Drawing.Point(220, 196);
            this.tb_Eat.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Eat.Name = "tb_Eat";
            this.tb_Eat.Size = new System.Drawing.Size(171, 33);
            this.tb_Eat.TabIndex = 6;
            this.tb_Eat.Text = " Gast ";
            this.tb_Eat.UseWaitCursor = true;
            // 
            // tb_CrustType
            // 
            this.tb_CrustType.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CrustType.Location = new System.Drawing.Point(220, 129);
            this.tb_CrustType.Margin = new System.Windows.Forms.Padding(4);
            this.tb_CrustType.Name = "tb_CrustType";
            this.tb_CrustType.Size = new System.Drawing.Size(171, 33);
            this.tb_CrustType.TabIndex = 5;
            this.tb_CrustType.UseWaitCursor = true;
            // 
            // tb_SizePizza
            // 
            this.tb_SizePizza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tb_SizePizza.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SizePizza.Location = new System.Drawing.Point(223, 66);
            this.tb_SizePizza.Margin = new System.Windows.Forms.Padding(4);
            this.tb_SizePizza.Name = "tb_SizePizza";
            this.tb_SizePizza.Size = new System.Drawing.Size(168, 33);
            this.tb_SizePizza.TabIndex = 4;
            this.tb_SizePizza.UseWaitCursor = true;
            // 
            // lb_Toppings
            // 
            this.lb_Toppings.AutoSize = true;
            this.lb_Toppings.Font = new System.Drawing.Font("Freestyle Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Toppings.ForeColor = System.Drawing.Color.Black;
            this.lb_Toppings.Location = new System.Drawing.Point(37, 247);
            this.lb_Toppings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Toppings.Name = "lb_Toppings";
            this.lb_Toppings.Size = new System.Drawing.Size(85, 32);
            this.lb_Toppings.TabIndex = 3;
            this.lb_Toppings.Text = "Toppings :";
            this.lb_Toppings.UseWaitCursor = true;
            // 
            // lb_Eat
            // 
            this.lb_Eat.AutoSize = true;
            this.lb_Eat.Font = new System.Drawing.Font("Freestyle Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Eat.ForeColor = System.Drawing.Color.Black;
            this.lb_Eat.Location = new System.Drawing.Point(37, 194);
            this.lb_Eat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Eat.Name = "lb_Eat";
            this.lb_Eat.Size = new System.Drawing.Size(131, 32);
            this.lb_Eat.TabIndex = 2;
            this.lb_Eat.Text = "Where to Eat  :";
            this.lb_Eat.UseWaitCursor = true;
            // 
            // lb_Crust
            // 
            this.lb_Crust.AutoSize = true;
            this.lb_Crust.Font = new System.Drawing.Font("Freestyle Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Crust.ForeColor = System.Drawing.Color.Black;
            this.lb_Crust.Location = new System.Drawing.Point(37, 129);
            this.lb_Crust.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Crust.Name = "lb_Crust";
            this.lb_Crust.Size = new System.Drawing.Size(116, 32);
            this.lb_Crust.TabIndex = 1;
            this.lb_Crust.Text = "Crust Type : ";
            this.lb_Crust.UseWaitCursor = true;
            // 
            // lb_SizePizza
            // 
            this.lb_SizePizza.AutoSize = true;
            this.lb_SizePizza.Font = new System.Drawing.Font("Freestyle Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SizePizza.ForeColor = System.Drawing.Color.Black;
            this.lb_SizePizza.Location = new System.Drawing.Point(37, 66);
            this.lb_SizePizza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_SizePizza.Name = "lb_SizePizza";
            this.lb_SizePizza.Size = new System.Drawing.Size(103, 32);
            this.lb_SizePizza.TabIndex = 0;
            this.lb_SizePizza.Text = "Size Pizza  :";
            this.lb_SizePizza.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.tb_TotalPrise);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Freestyle Script", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(793, 415);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(416, 130);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total Pries";
            // 
            // tb_TotalPrise
            // 
            this.tb_TotalPrise.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TotalPrise.Location = new System.Drawing.Point(179, 50);
            this.tb_TotalPrise.Margin = new System.Windows.Forms.Padding(4);
            this.tb_TotalPrise.Name = "tb_TotalPrise";
            this.tb_TotalPrise.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tb_TotalPrise.Size = new System.Drawing.Size(101, 43);
            this.tb_TotalPrise.TabIndex = 9;
            this.tb_TotalPrise.UseWaitCursor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(289, 50);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(48, 43);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "$";
            this.textBox1.UseWaitCursor = true;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClose.Location = new System.Drawing.Point(0, 579);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(1284, 65);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1284, 644);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OrderSummary_Box);
            this.Controls.Add(this.CrustType_Box);
            this.Controls.Add(this.Toppings_Box);
            this.Controls.Add(this.WhereToEat_Box);
            this.Controls.Add(this.OrderForm_Box);
            this.Controls.Add(this.Size_Box);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Pizza";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Size_Box.ResumeLayout(false);
            this.Size_Box.PerformLayout();
            this.CrustType_Box.ResumeLayout(false);
            this.CrustType_Box.PerformLayout();
            this.Toppings_Box.ResumeLayout(false);
            this.Toppings_Box.PerformLayout();
            this.WhereToEat_Box.ResumeLayout(false);
            this.WhereToEat_Box.PerformLayout();
            this.OrderForm_Box.ResumeLayout(false);
            this.OrderSummary_Box.ResumeLayout(false);
            this.OrderSummary_Box.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Size_Box;
        private System.Windows.Forms.GroupBox CrustType_Box;
        private System.Windows.Forms.GroupBox Toppings_Box;
        private System.Windows.Forms.GroupBox WhereToEat_Box;
        private System.Windows.Forms.GroupBox OrderForm_Box;
        private System.Windows.Forms.GroupBox OrderSummary_Box;
        private System.Windows.Forms.RadioButton rb_Smal;
        private System.Windows.Forms.RadioButton rb_Large;
        private System.Windows.Forms.RadioButton rb_Medium;
        private System.Windows.Forms.RadioButton rb_Thin;
        private System.Windows.Forms.RadioButton rb_Normal;
        private System.Windows.Forms.RadioButton rb_TakeOut;
        private System.Windows.Forms.RadioButton rb_EatIn;
        private System.Windows.Forms.RadioButton rb_Think;
        private System.Windows.Forms.CheckBox chk_ExtraChese;
        private System.Windows.Forms.CheckBox chk_Pappers;
        private System.Windows.Forms.CheckBox chk_Olives;
        private System.Windows.Forms.CheckBox chk_Onion;
        private System.Windows.Forms.CheckBox chk_Tomatoes;
        private System.Windows.Forms.CheckBox chk_Mushrooms;
        private System.Windows.Forms.Button btn_OkOrder;
        private System.Windows.Forms.Button btn_RestForm;
        private System.Windows.Forms.Label lb_SizePizza;
        private System.Windows.Forms.Label lb_Eat;
        private System.Windows.Forms.Label lb_Crust;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_Toppings;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tb_SizePizza;
        private System.Windows.Forms.TextBox tb_Eat;
        private System.Windows.Forms.TextBox tb_CrustType;
        private System.Windows.Forms.TextBox tb_TotalPrise;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tb_Toppings;
    }
}

