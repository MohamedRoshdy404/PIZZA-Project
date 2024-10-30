namespace PIZZA_Project
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpBox1 = new System.Windows.Forms.GroupBox();
            this.radbtn3 = new System.Windows.Forms.RadioButton();
            this.radbtn1 = new System.Windows.Forms.RadioButton();
            this.radbtn2 = new System.Windows.Forms.RadioButton();
            this.grpBox2 = new System.Windows.Forms.GroupBox();
            this.grpBox2radio1 = new System.Windows.Forms.RadioButton();
            this.grpBox2radio2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBox3 = new System.Windows.Forms.GroupBox();
            this.grpBox3radio1 = new System.Windows.Forms.RadioButton();
            this.grpBox3radio2 = new System.Windows.Forms.RadioButton();
            this.btnPizzaOrder = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.GroupBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkExtraChees = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labWhereToEat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labCurstType = new System.Windows.Forms.Label();
            this.labNameOrderSize = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labPrice = new System.Windows.Forms.Label();
            this.labTotalPrice = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.grpBox1.SuspendLayout();
            this.grpBox2.SuspendLayout();
            this.grpBox3.SuspendLayout();
            this.label2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox1
            // 
            this.grpBox1.BackColor = System.Drawing.Color.DarkOrange;
            this.grpBox1.Controls.Add(this.radbtn3);
            this.grpBox1.Controls.Add(this.radbtn1);
            this.grpBox1.Controls.Add(this.radbtn2);
            this.grpBox1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox1.Location = new System.Drawing.Point(24, 132);
            this.grpBox1.Name = "grpBox1";
            this.grpBox1.Size = new System.Drawing.Size(207, 199);
            this.grpBox1.TabIndex = 0;
            this.grpBox1.TabStop = false;
            this.grpBox1.Text = "Size";
            // 
            // radbtn3
            // 
            this.radbtn3.AutoSize = true;
            this.radbtn3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtn3.Location = new System.Drawing.Point(24, 140);
            this.radbtn3.Name = "radbtn3";
            this.radbtn3.Size = new System.Drawing.Size(65, 27);
            this.radbtn3.TabIndex = 3;
            this.radbtn3.TabStop = true;
            this.radbtn3.Tag = "30";
            this.radbtn3.Text = "Larg";
            this.radbtn3.UseVisualStyleBackColor = true;
            this.radbtn3.CheckedChanged += new System.EventHandler(this.radbtn3_CheckedChanged_1);
            // 
            // radbtn1
            // 
            this.radbtn1.AutoSize = true;
            this.radbtn1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtn1.Location = new System.Drawing.Point(24, 48);
            this.radbtn1.Name = "radbtn1";
            this.radbtn1.Size = new System.Drawing.Size(73, 27);
            this.radbtn1.TabIndex = 1;
            this.radbtn1.TabStop = true;
            this.radbtn1.Tag = "10";
            this.radbtn1.Text = "Small";
            this.radbtn1.UseVisualStyleBackColor = true;
            this.radbtn1.CheckedChanged += new System.EventHandler(this.radbtn1_CheckedChanged_1);
            // 
            // radbtn2
            // 
            this.radbtn2.AutoSize = true;
            this.radbtn2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtn2.Location = new System.Drawing.Point(24, 94);
            this.radbtn2.Name = "radbtn2";
            this.radbtn2.Size = new System.Drawing.Size(95, 27);
            this.radbtn2.TabIndex = 2;
            this.radbtn2.TabStop = true;
            this.radbtn2.Tag = "20";
            this.radbtn2.Text = "Meduim";
            this.radbtn2.UseVisualStyleBackColor = true;
            this.radbtn2.CheckedChanged += new System.EventHandler(this.radbtn2_CheckedChanged_1);
            // 
            // grpBox2
            // 
            this.grpBox2.BackColor = System.Drawing.Color.DarkOrange;
            this.grpBox2.Controls.Add(this.grpBox2radio1);
            this.grpBox2.Controls.Add(this.grpBox2radio2);
            this.grpBox2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox2.Location = new System.Drawing.Point(24, 354);
            this.grpBox2.Name = "grpBox2";
            this.grpBox2.Size = new System.Drawing.Size(207, 199);
            this.grpBox2.TabIndex = 4;
            this.grpBox2.TabStop = false;
            this.grpBox2.Text = "Curst Type";
            // 
            // grpBox2radio1
            // 
            this.grpBox2radio1.AutoSize = true;
            this.grpBox2radio1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox2radio1.Location = new System.Drawing.Point(24, 48);
            this.grpBox2radio1.Name = "grpBox2radio1";
            this.grpBox2radio1.Size = new System.Drawing.Size(114, 27);
            this.grpBox2radio1.TabIndex = 1;
            this.grpBox2radio1.TabStop = true;
            this.grpBox2radio1.Tag = "2";
            this.grpBox2radio1.Text = "Thin Curst";
            this.grpBox2radio1.UseVisualStyleBackColor = true;
            this.grpBox2radio1.CheckedChanged += new System.EventHandler(this.grpBox2radio1_CheckedChanged);
            // 
            // grpBox2radio2
            // 
            this.grpBox2radio2.AutoSize = true;
            this.grpBox2radio2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox2radio2.Location = new System.Drawing.Point(24, 94);
            this.grpBox2radio2.Name = "grpBox2radio2";
            this.grpBox2radio2.Size = new System.Drawing.Size(123, 27);
            this.grpBox2radio2.TabIndex = 2;
            this.grpBox2radio2.TabStop = true;
            this.grpBox2radio2.Tag = "4";
            this.grpBox2radio2.Text = "Think Curst";
            this.grpBox2radio2.UseVisualStyleBackColor = true;
            this.grpBox2radio2.CheckedChanged += new System.EventHandler(this.grpBox2radio2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(256, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(657, 114);
            this.label1.TabIndex = 5;
            this.label1.Text = "MAKE YOUR PIZZA";
            // 
            // grpBox3
            // 
            this.grpBox3.BackColor = System.Drawing.Color.DarkOrange;
            this.grpBox3.Controls.Add(this.grpBox3radio1);
            this.grpBox3.Controls.Add(this.grpBox3radio2);
            this.grpBox3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox3.Location = new System.Drawing.Point(342, 354);
            this.grpBox3.Name = "grpBox3";
            this.grpBox3.Size = new System.Drawing.Size(387, 121);
            this.grpBox3.TabIndex = 5;
            this.grpBox3.TabStop = false;
            this.grpBox3.Text = "Where To Eat";
            // 
            // grpBox3radio1
            // 
            this.grpBox3radio1.AutoSize = true;
            this.grpBox3radio1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox3radio1.Location = new System.Drawing.Point(10, 63);
            this.grpBox3radio1.Name = "grpBox3radio1";
            this.grpBox3radio1.Size = new System.Drawing.Size(79, 27);
            this.grpBox3radio1.TabIndex = 1;
            this.grpBox3radio1.TabStop = true;
            this.grpBox3radio1.Tag = "";
            this.grpBox3radio1.Text = "Eat In";
            this.grpBox3radio1.UseVisualStyleBackColor = true;
            this.grpBox3radio1.CheckedChanged += new System.EventHandler(this.grpBox3radio1_CheckedChanged);
            // 
            // grpBox3radio2
            // 
            this.grpBox3radio2.AutoSize = true;
            this.grpBox3radio2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox3radio2.Location = new System.Drawing.Point(171, 63);
            this.grpBox3radio2.Name = "grpBox3radio2";
            this.grpBox3radio2.Size = new System.Drawing.Size(104, 27);
            this.grpBox3radio2.TabIndex = 2;
            this.grpBox3radio2.TabStop = true;
            this.grpBox3radio2.Tag = "";
            this.grpBox3radio2.Text = "Take Out";
            this.grpBox3radio2.UseVisualStyleBackColor = true;
            this.grpBox3radio2.CheckedChanged += new System.EventHandler(this.grpBox3radio2_CheckedChanged);
            // 
            // btnPizzaOrder
            // 
            this.btnPizzaOrder.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPizzaOrder.Location = new System.Drawing.Point(342, 507);
            this.btnPizzaOrder.Name = "btnPizzaOrder";
            this.btnPizzaOrder.Size = new System.Drawing.Size(170, 61);
            this.btnPizzaOrder.TabIndex = 6;
            this.btnPizzaOrder.Text = "PizzaOrder";
            this.btnPizzaOrder.UseVisualStyleBackColor = true;
            this.btnPizzaOrder.Click += new System.EventHandler(this.btnPizzaOrder_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetForm.Location = new System.Drawing.Point(559, 507);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(170, 61);
            this.btnResetForm.TabIndex = 7;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkOrange;
            this.label2.Controls.Add(this.chkOlives);
            this.label2.Controls.Add(this.chkGreenPeppers);
            this.label2.Controls.Add(this.chkOnion);
            this.label2.Controls.Add(this.chkMushrooms);
            this.label2.Controls.Add(this.chkTomatoes);
            this.label2.Controls.Add(this.chkExtraChees);
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 199);
            this.label2.TabIndex = 4;
            this.label2.TabStop = false;
            this.label2.Text = "Toppings";
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOlives.Location = new System.Drawing.Point(213, 84);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(77, 27);
            this.chkOlives.TabIndex = 21;
            this.chkOlives.Tag = "4";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGreenPeppers.Location = new System.Drawing.Point(213, 142);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(153, 27);
            this.chkGreenPeppers.TabIndex = 20;
            this.chkGreenPeppers.Tag = "3";
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnion.Location = new System.Drawing.Point(213, 30);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(78, 27);
            this.chkOnion.TabIndex = 19;
            this.chkOnion.Tag = "1";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMushrooms.Location = new System.Drawing.Point(41, 84);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(125, 27);
            this.chkMushrooms.TabIndex = 18;
            this.chkMushrooms.Tag = "2";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTomatoes.Location = new System.Drawing.Point(41, 142);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(110, 27);
            this.chkTomatoes.TabIndex = 17;
            this.chkTomatoes.Tag = "6";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkExtraChees
            // 
            this.chkExtraChees.AutoSize = true;
            this.chkExtraChees.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExtraChees.Location = new System.Drawing.Point(41, 30);
            this.chkExtraChees.Name = "chkExtraChees";
            this.chkExtraChees.Size = new System.Drawing.Size(128, 27);
            this.chkExtraChees.TabIndex = 16;
            this.chkExtraChees.Tag = "5";
            this.chkExtraChees.Text = "Extra Chees";
            this.chkExtraChees.UseVisualStyleBackColor = true;
            this.chkExtraChees.CheckedChanged += new System.EventHandler(this.chkExtraChees_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(1116, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labWhereToEat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labCurstType);
            this.groupBox1.Controls.Add(this.labNameOrderSize);
            this.groupBox1.Controls.Add(this.lblToppings);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labPrice);
            this.groupBox1.Controls.Add(this.labTotalPrice);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(759, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 491);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Summary";
            // 
            // labWhereToEat
            // 
            this.labWhereToEat.AutoSize = true;
            this.labWhereToEat.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.labWhereToEat.Location = new System.Drawing.Point(117, 305);
            this.labWhereToEat.MaximumSize = new System.Drawing.Size(200, 100);
            this.labWhereToEat.Name = "labWhereToEat";
            this.labWhereToEat.Size = new System.Drawing.Size(93, 17);
            this.labWhereToEat.TabIndex = 36;
            this.labWhereToEat.Text = "Curst Type :";
            this.labWhereToEat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Where To Eat :";
            // 
            // labCurstType
            // 
            this.labCurstType.AutoSize = true;
            this.labCurstType.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.labCurstType.Location = new System.Drawing.Point(117, 200);
            this.labCurstType.MaximumSize = new System.Drawing.Size(200, 100);
            this.labCurstType.Name = "labCurstType";
            this.labCurstType.Size = new System.Drawing.Size(93, 17);
            this.labCurstType.TabIndex = 34;
            this.labCurstType.Text = "Curst Type :";
            this.labCurstType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labNameOrderSize
            // 
            this.labNameOrderSize.AutoSize = true;
            this.labNameOrderSize.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.labNameOrderSize.Location = new System.Drawing.Point(117, 47);
            this.labNameOrderSize.MaximumSize = new System.Drawing.Size(200, 100);
            this.labNameOrderSize.Name = "labNameOrderSize";
            this.labNameOrderSize.Size = new System.Drawing.Size(35, 17);
            this.labNameOrderSize.TabIndex = 33;
            this.labNameOrderSize.Text = "Size";
            this.labNameOrderSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblToppings.Location = new System.Drawing.Point(117, 130);
            this.lblToppings.MaximumSize = new System.Drawing.Size(200, 100);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(96, 17);
            this.lblToppings.TabIndex = 31;
            this.lblToppings.Text = "No Toppings";
            this.lblToppings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Toppings: ";
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labPrice.Location = new System.Drawing.Point(92, 395);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(56, 58);
            this.labPrice.TabIndex = 29;
            this.labPrice.Text = "0";
            // 
            // labTotalPrice
            // 
            this.labTotalPrice.AutoSize = true;
            this.labTotalPrice.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.labTotalPrice.Location = new System.Drawing.Point(92, 345);
            this.labTotalPrice.Name = "labTotalPrice";
            this.labTotalPrice.Size = new System.Drawing.Size(138, 27);
            this.labTotalPrice.TabIndex = 28;
            this.labTotalPrice.Text = "Total Price:";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1161, 634);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnPizzaOrder);
            this.Controls.Add(this.grpBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpBox2);
            this.Controls.Add(this.grpBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBox1.ResumeLayout(false);
            this.grpBox1.PerformLayout();
            this.grpBox2.ResumeLayout(false);
            this.grpBox2.PerformLayout();
            this.grpBox3.ResumeLayout(false);
            this.grpBox3.PerformLayout();
            this.label2.ResumeLayout(false);
            this.label2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox1;
        private System.Windows.Forms.RadioButton radbtn3;
        private System.Windows.Forms.RadioButton radbtn1;
        private System.Windows.Forms.RadioButton radbtn2;
        private System.Windows.Forms.GroupBox grpBox2;
        private System.Windows.Forms.RadioButton grpBox2radio1;
        private System.Windows.Forms.RadioButton grpBox2radio2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBox3;
        private System.Windows.Forms.RadioButton grpBox3radio1;
        private System.Windows.Forms.RadioButton grpBox3radio2;
        private System.Windows.Forms.Button btnPizzaOrder;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.GroupBox label2;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkExtraChees;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labWhereToEat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labCurstType;
        private System.Windows.Forms.Label labNameOrderSize;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.Label labTotalPrice;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}

