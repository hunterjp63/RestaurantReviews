namespace RestaurantReviewApp
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            FoodName = new TextBox();
            AddFood = new Button();
            FoodCost = new TextBox();
            FoodDescription = new TextBox();
            label4 = new Label();
            AddFoodPanel = new Panel();
            addWords = new Panel();
            exitKeyword = new Button();
            addKeywordbutton = new Button();
            addKeywords = new TextBox();
            backToFood = new Button();
            foodDescDisplay = new TextBox();
            removeFood1 = new Button();
            FoodRating = new TextBox();
            gridFood1 = new DataGridView();
            addRestPanel = new Panel();
            backtoMainRest1 = new Button();
            removeRest1 = new Button();
            gridRest1 = new DataGridView();
            EditRest = new Button();
            label5 = new Label();
            TypeofRest = new TextBox();
            RestAddress = new TextBox();
            RestName = new TextBox();
            AddRest = new Button();
            mainMenu = new Panel();
            foodDescDisplay2 = new TextBox();
            label3 = new Label();
            addFoodtoRest = new Button();
            backToMainRest = new Button();
            removeFood2 = new Button();
            gridFood2 = new DataGridView();
            mainRest = new Panel();
            label1 = new Label();
            addRest1 = new Button();
            saveFile = new Button();
            removeRest2 = new Button();
            gridRest2 = new DataGridView();
            ViewRest = new Button();
            RestaurantLabel = new Label();
            AddFoodPanel.SuspendLayout();
            addWords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridFood1).BeginInit();
            addRestPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridRest1).BeginInit();
            mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridFood2).BeginInit();
            mainRest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridRest2).BeginInit();
            SuspendLayout();
            // 
            // FoodName
            // 
            FoodName.BackColor = Color.Honeydew;
            FoodName.Font = new Font("Rockwell Condensed", 14F, FontStyle.Bold);
            FoodName.Location = new Point(1155, 154);
            FoodName.Name = "FoodName";
            FoodName.PlaceholderText = "Name of Dish";
            FoodName.Size = new Size(460, 40);
            FoodName.TabIndex = 0;
            // 
            // AddFood
            // 
            AddFood.BackColor = Color.Gray;
            AddFood.Font = new Font("Rockwell Condensed", 11F, FontStyle.Bold);
            AddFood.ForeColor = Color.Transparent;
            AddFood.Location = new Point(1621, 405);
            AddFood.Name = "AddFood";
            AddFood.Size = new Size(186, 39);
            AddFood.TabIndex = 1;
            AddFood.Text = "Add Food";
            AddFood.UseVisualStyleBackColor = false;
            AddFood.Click += AddFood_Click;
            // 
            // FoodCost
            // 
            FoodCost.BackColor = Color.Honeydew;
            FoodCost.Font = new Font("Rockwell Condensed", 14F, FontStyle.Bold);
            FoodCost.Location = new Point(1155, 217);
            FoodCost.Name = "FoodCost";
            FoodCost.PlaceholderText = "Cost";
            FoodCost.Size = new Size(460, 40);
            FoodCost.TabIndex = 3;
            // 
            // FoodDescription
            // 
            FoodDescription.BackColor = Color.Honeydew;
            FoodDescription.Font = new Font("Rockwell Condensed", 14F, FontStyle.Bold);
            FoodDescription.Location = new Point(1155, 278);
            FoodDescription.Multiline = true;
            FoodDescription.Name = "FoodDescription";
            FoodDescription.PlaceholderText = "Description";
            FoodDescription.Size = new Size(460, 102);
            FoodDescription.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SeaGreen;
            label4.Font = new Font("Rockwell Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(1382, 63);
            label4.Name = "label4";
            label4.Size = new Size(391, 56);
            label4.TabIndex = 8;
            label4.Text = "Add Food To Menu";
            // 
            // AddFoodPanel
            // 
            AddFoodPanel.BackColor = Color.LightGray;
            AddFoodPanel.BorderStyle = BorderStyle.FixedSingle;
            AddFoodPanel.Controls.Add(addWords);
            AddFoodPanel.Controls.Add(backToFood);
            AddFoodPanel.Controls.Add(foodDescDisplay);
            AddFoodPanel.Controls.Add(removeFood1);
            AddFoodPanel.Controls.Add(FoodRating);
            AddFoodPanel.Controls.Add(gridFood1);
            AddFoodPanel.Controls.Add(AddFood);
            AddFoodPanel.Controls.Add(label4);
            AddFoodPanel.Controls.Add(FoodCost);
            AddFoodPanel.Controls.Add(FoodName);
            AddFoodPanel.Controls.Add(FoodDescription);
            AddFoodPanel.Dock = DockStyle.Fill;
            AddFoodPanel.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddFoodPanel.Location = new Point(0, 0);
            AddFoodPanel.Name = "AddFoodPanel";
            AddFoodPanel.Size = new Size(3035, 1456);
            AddFoodPanel.TabIndex = 9;
            // 
            // addWords
            // 
            addWords.BackColor = Color.White;
            addWords.Controls.Add(exitKeyword);
            addWords.Controls.Add(addKeywordbutton);
            addWords.Controls.Add(addKeywords);
            addWords.Location = new Point(1836, 889);
            addWords.Name = "addWords";
            addWords.Size = new Size(259, 121);
            addWords.TabIndex = 11;
            // 
            // exitKeyword
            // 
            exitKeyword.BackColor = Color.Gray;
            exitKeyword.Font = new Font("Rockwell Condensed", 9F, FontStyle.Bold);
            exitKeyword.ForeColor = Color.Transparent;
            exitKeyword.Location = new Point(196, 0);
            exitKeyword.Name = "exitKeyword";
            exitKeyword.Size = new Size(63, 36);
            exitKeyword.TabIndex = 2;
            exitKeyword.Text = "X";
            exitKeyword.UseVisualStyleBackColor = false;
            exitKeyword.Click += exitKeyword_Click;
            // 
            // addKeywordbutton
            // 
            addKeywordbutton.BackColor = Color.Gray;
            addKeywordbutton.Font = new Font("Rockwell Condensed", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addKeywordbutton.ForeColor = Color.Transparent;
            addKeywordbutton.Location = new Point(14, 75);
            addKeywordbutton.Name = "addKeywordbutton";
            addKeywordbutton.Size = new Size(112, 34);
            addKeywordbutton.TabIndex = 1;
            addKeywordbutton.Text = "Add";
            addKeywordbutton.UseVisualStyleBackColor = false;
            addKeywordbutton.Click += addKeywordbutton_Click;
            // 
            // addKeywords
            // 
            addKeywords.BackColor = Color.Honeydew;
            addKeywords.Font = new Font("Rockwell Condensed", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addKeywords.Location = new Point(14, 36);
            addKeywords.Name = "addKeywords";
            addKeywords.PlaceholderText = "Add Keywords";
            addKeywords.Size = new Size(172, 33);
            addKeywords.TabIndex = 0;
            // 
            // backToFood
            // 
            backToFood.BackColor = Color.Gray;
            backToFood.Font = new Font("Rockwell Condensed", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backToFood.ForeColor = Color.Transparent;
            backToFood.Location = new Point(1836, 521);
            backToFood.Name = "backToFood";
            backToFood.Size = new Size(152, 34);
            backToFood.TabIndex = 15;
            backToFood.Text = "Back";
            backToFood.UseVisualStyleBackColor = false;
            backToFood.Click += backToFood_Click;
            // 
            // foodDescDisplay
            // 
            foodDescDisplay.BackColor = Color.Honeydew;
            foodDescDisplay.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            foodDescDisplay.Location = new Point(1155, 1055);
            foodDescDisplay.Multiline = true;
            foodDescDisplay.Name = "foodDescDisplay";
            foodDescDisplay.ReadOnly = true;
            foodDescDisplay.Size = new Size(652, 141);
            foodDescDisplay.TabIndex = 3;
            // 
            // removeFood1
            // 
            removeFood1.BackColor = Color.Gray;
            removeFood1.Font = new Font("Rockwell Condensed", 11F, FontStyle.Bold);
            removeFood1.ForeColor = Color.Transparent;
            removeFood1.Location = new Point(1836, 469);
            removeFood1.Name = "removeFood1";
            removeFood1.Size = new Size(152, 34);
            removeFood1.TabIndex = 13;
            removeFood1.Text = "Remove";
            removeFood1.UseVisualStyleBackColor = false;
            removeFood1.Click += removeFood1_Click;
            // 
            // FoodRating
            // 
            FoodRating.BackColor = Color.Honeydew;
            FoodRating.Font = new Font("Rockwell Condensed", 14F, FontStyle.Bold);
            FoodRating.Location = new Point(1155, 403);
            FoodRating.Name = "FoodRating";
            FoodRating.PlaceholderText = "Rating";
            FoodRating.Size = new Size(460, 40);
            FoodRating.TabIndex = 10;
            // 
            // gridFood1
            // 
            gridFood1.BackgroundColor = Color.Honeydew;
            gridFood1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridFood1.Location = new Point(1155, 469);
            gridFood1.Name = "gridFood1";
            gridFood1.RowHeadersWidth = 62;
            gridFood1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridFood1.Size = new Size(652, 541);
            gridFood1.TabIndex = 9;
            gridFood1.CellDoubleClick += gridFood1_CellDoubleClick;
            // 
            // addRestPanel
            // 
            addRestPanel.BackColor = Color.LightGray;
            addRestPanel.Controls.Add(backtoMainRest1);
            addRestPanel.Controls.Add(removeRest1);
            addRestPanel.Controls.Add(gridRest1);
            addRestPanel.Controls.Add(EditRest);
            addRestPanel.Controls.Add(label5);
            addRestPanel.Controls.Add(TypeofRest);
            addRestPanel.Controls.Add(RestAddress);
            addRestPanel.Controls.Add(RestName);
            addRestPanel.Controls.Add(AddRest);
            addRestPanel.Dock = DockStyle.Fill;
            addRestPanel.ForeColor = Color.Transparent;
            addRestPanel.Location = new Point(0, 0);
            addRestPanel.Name = "addRestPanel";
            addRestPanel.Size = new Size(3035, 1456);
            addRestPanel.TabIndex = 0;
            // 
            // backtoMainRest1
            // 
            backtoMainRest1.BackColor = Color.Gray;
            backtoMainRest1.Font = new Font("Rockwell Condensed", 11F, FontStyle.Bold);
            backtoMainRest1.Location = new Point(1837, 1116);
            backtoMainRest1.Name = "backtoMainRest1";
            backtoMainRest1.Size = new Size(152, 34);
            backtoMainRest1.TabIndex = 14;
            backtoMainRest1.Text = "Back";
            backtoMainRest1.UseVisualStyleBackColor = false;
            backtoMainRest1.Click += backtoMainRest1_Click;
            // 
            // removeRest1
            // 
            removeRest1.BackColor = Color.Gray;
            removeRest1.Font = new Font("Rockwell Condensed", 11F, FontStyle.Bold);
            removeRest1.Location = new Point(1837, 470);
            removeRest1.Name = "removeRest1";
            removeRest1.Size = new Size(152, 34);
            removeRest1.TabIndex = 13;
            removeRest1.Text = "Remove ";
            removeRest1.UseVisualStyleBackColor = false;
            removeRest1.Click += removeRest1_Click_1;
            // 
            // gridRest1
            // 
            gridRest1.BackgroundColor = Color.Honeydew;
            gridRest1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridRest1.Location = new Point(1155, 418);
            gridRest1.Name = "gridRest1";
            gridRest1.RowHeadersWidth = 62;
            gridRest1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridRest1.Size = new Size(652, 732);
            gridRest1.TabIndex = 12;
            gridRest1.CellDoubleClick += gridRest1_CellDoubleClick;
            // 
            // EditRest
            // 
            EditRest.BackColor = Color.Gray;
            EditRest.Font = new Font("Rockwell Condensed", 11F, FontStyle.Bold);
            EditRest.Location = new Point(1837, 418);
            EditRest.Name = "EditRest";
            EditRest.Size = new Size(152, 34);
            EditRest.TabIndex = 5;
            EditRest.Text = "Edit Menu";
            EditRest.UseVisualStyleBackColor = false;
            EditRest.Click += ViewRest_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.SeaGreen;
            label5.Font = new Font("Rockwell Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(1382, 63);
            label5.Name = "label5";
            label5.Size = new Size(319, 56);
            label5.TabIndex = 9;
            label5.Text = "Add Restaurant";
            // 
            // TypeofRest
            // 
            TypeofRest.BackColor = Color.Honeydew;
            TypeofRest.Font = new Font("Rockwell Condensed", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TypeofRest.Location = new Point(1155, 232);
            TypeofRest.Name = "TypeofRest";
            TypeofRest.PlaceholderText = "Type of Food";
            TypeofRest.Size = new Size(390, 40);
            TypeofRest.TabIndex = 4;
            // 
            // RestAddress
            // 
            RestAddress.BackColor = Color.Honeydew;
            RestAddress.Font = new Font("Rockwell Condensed", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RestAddress.Location = new Point(1155, 292);
            RestAddress.Multiline = true;
            RestAddress.Name = "RestAddress";
            RestAddress.PlaceholderText = "Address";
            RestAddress.Size = new Size(390, 105);
            RestAddress.TabIndex = 3;
            // 
            // RestName
            // 
            RestName.BackColor = Color.Honeydew;
            RestName.Font = new Font("Rockwell Condensed", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RestName.ForeColor = SystemColors.WindowText;
            RestName.Location = new Point(1155, 181);
            RestName.Name = "RestName";
            RestName.PlaceholderText = "Name";
            RestName.Size = new Size(390, 40);
            RestName.TabIndex = 2;
            // 
            // AddRest
            // 
            AddRest.BackColor = Color.Gray;
            AddRest.Font = new Font("Rockwell Condensed", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddRest.Location = new Point(1563, 315);
            AddRest.Name = "AddRest";
            AddRest.Size = new Size(245, 82);
            AddRest.TabIndex = 0;
            AddRest.Text = "Add Restaurant";
            AddRest.UseVisualStyleBackColor = false;
            AddRest.Click += AddRest_Click_1;
            // 
            // mainMenu
            // 
            mainMenu.BackColor = Color.LightGray;
            mainMenu.Controls.Add(foodDescDisplay2);
            mainMenu.Controls.Add(label3);
            mainMenu.Controls.Add(addFoodtoRest);
            mainMenu.Controls.Add(backToMainRest);
            mainMenu.Controls.Add(removeFood2);
            mainMenu.Controls.Add(gridFood2);
            mainMenu.Dock = DockStyle.Fill;
            mainMenu.Location = new Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(3035, 1456);
            mainMenu.TabIndex = 3;
            // 
            // foodDescDisplay2
            // 
            foodDescDisplay2.BackColor = Color.Honeydew;
            foodDescDisplay2.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            foodDescDisplay2.ForeColor = Color.DimGray;
            foodDescDisplay2.Location = new Point(1155, 828);
            foodDescDisplay2.Multiline = true;
            foodDescDisplay2.Name = "foodDescDisplay2";
            foodDescDisplay2.ReadOnly = true;
            foodDescDisplay2.Size = new Size(652, 157);
            foodDescDisplay2.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SeaGreen;
            label3.Font = new Font("Rockwell Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(1382, 63);
            label3.Name = "label3";
            label3.Size = new Size(129, 56);
            label3.TabIndex = 18;
            label3.Text = "Menu";
            // 
            // addFoodtoRest
            // 
            addFoodtoRest.BackColor = Color.Gray;
            addFoodtoRest.Font = new Font("Rockwell Condensed", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addFoodtoRest.ForeColor = Color.Transparent;
            addFoodtoRest.Location = new Point(1823, 269);
            addFoodtoRest.Name = "addFoodtoRest";
            addFoodtoRest.Size = new Size(166, 46);
            addFoodtoRest.TabIndex = 16;
            addFoodtoRest.Text = "Edit Menu";
            addFoodtoRest.UseVisualStyleBackColor = false;
            addFoodtoRest.Click += addFoodtoRest_Click;
            // 
            // backToMainRest
            // 
            backToMainRest.BackColor = Color.Gray;
            backToMainRest.Font = new Font("Rockwell Condensed", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backToMainRest.ForeColor = Color.Transparent;
            backToMainRest.Location = new Point(1823, 764);
            backToMainRest.Name = "backToMainRest";
            backToMainRest.Size = new Size(166, 46);
            backToMainRest.TabIndex = 15;
            backToMainRest.Text = "Back";
            backToMainRest.UseVisualStyleBackColor = false;
            backToMainRest.Click += backToMainRest_Click;
            // 
            // removeFood2
            // 
            removeFood2.BackColor = Color.Gray;
            removeFood2.Font = new Font("Rockwell Condensed", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeFood2.ForeColor = Color.Transparent;
            removeFood2.Location = new Point(1823, 181);
            removeFood2.Name = "removeFood2";
            removeFood2.Size = new Size(166, 46);
            removeFood2.TabIndex = 14;
            removeFood2.Text = "Remove";
            removeFood2.UseVisualStyleBackColor = false;
            removeFood2.Click += removeFood2_Click;
            // 
            // gridFood2
            // 
            gridFood2.AccessibleDescription = "";
            gridFood2.BackgroundColor = Color.Honeydew;
            gridFood2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            gridFood2.DefaultCellStyle = dataGridViewCellStyle1;
            gridFood2.Location = new Point(1155, 181);
            gridFood2.Margin = new Padding(5);
            gridFood2.Name = "gridFood2";
            gridFood2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            gridFood2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridFood2.Size = new Size(652, 629);
            gridFood2.TabIndex = 10;
            gridFood2.CellDoubleClick += gridFood2_CellDoubleClick;
            // 
            // mainRest
            // 
            mainRest.BackColor = Color.LightGray;
            mainRest.Controls.Add(label1);
            mainRest.Controls.Add(addRest1);
            mainRest.Controls.Add(saveFile);
            mainRest.Controls.Add(removeRest2);
            mainRest.Controls.Add(gridRest2);
            mainRest.Controls.Add(ViewRest);
            mainRest.Dock = DockStyle.Fill;
            mainRest.Location = new Point(0, 0);
            mainRest.Name = "mainRest";
            mainRest.Size = new Size(3035, 1456);
            mainRest.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SeaGreen;
            label1.Font = new Font("Rockwell Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(1382, 63);
            label1.Name = "label1";
            label1.Size = new Size(206, 56);
            label1.TabIndex = 15;
            label1.Text = "Food Log";
            // 
            // addRest1
            // 
            addRest1.BackColor = Color.Gray;
            addRest1.Font = new Font("Rockwell Condensed", 11F, FontStyle.Bold);
            addRest1.ForeColor = Color.Transparent;
            addRest1.Location = new Point(1823, 321);
            addRest1.Name = "addRest1";
            addRest1.Size = new Size(166, 46);
            addRest1.TabIndex = 14;
            addRest1.Text = "Add Restaurant";
            addRest1.UseVisualStyleBackColor = false;
            addRest1.Click += addRest1_Click;
            // 
            // saveFile
            // 
            saveFile.BackColor = Color.Gray;
            saveFile.Font = new Font("Rockwell Condensed", 11F, FontStyle.Bold);
            saveFile.ForeColor = Color.Transparent;
            saveFile.Location = new Point(1823, 522);
            saveFile.Name = "saveFile";
            saveFile.Size = new Size(166, 46);
            saveFile.TabIndex = 13;
            saveFile.Text = "Save";
            saveFile.UseVisualStyleBackColor = false;
            saveFile.Click += saveFile_Click;
            // 
            // removeRest2
            // 
            removeRest2.BackColor = Color.Gray;
            removeRest2.Font = new Font("Rockwell Condensed", 11F, FontStyle.Bold);
            removeRest2.ForeColor = Color.Transparent;
            removeRest2.Location = new Point(1823, 181);
            removeRest2.Name = "removeRest2";
            removeRest2.Size = new Size(166, 46);
            removeRest2.TabIndex = 11;
            removeRest2.Text = "Remove";
            removeRest2.UseVisualStyleBackColor = false;
            removeRest2.Click += removeRest2_Click;
            // 
            // gridRest2
            // 
            gridRest2.BackgroundColor = Color.Honeydew;
            gridRest2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridRest2.Location = new Point(1155, 181);
            gridRest2.Name = "gridRest2";
            gridRest2.RowHeadersWidth = 62;
            gridRest2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridRest2.Size = new Size(652, 747);
            gridRest2.TabIndex = 12;
            gridRest2.CellDoubleClick += gridRest2_CellDoubleClick;
            // 
            // ViewRest
            // 
            ViewRest.BackColor = Color.Gray;
            ViewRest.Font = new Font("Rockwell Condensed", 11F, FontStyle.Bold);
            ViewRest.ForeColor = Color.Transparent;
            ViewRest.Location = new Point(1823, 244);
            ViewRest.Name = "ViewRest";
            ViewRest.Size = new Size(166, 46);
            ViewRest.TabIndex = 11;
            ViewRest.Text = "View Restaurant";
            ViewRest.UseVisualStyleBackColor = false;
            ViewRest.Click += ViewRest_Click_1;
            // 
            // RestaurantLabel
            // 
            RestaurantLabel.AutoSize = true;
            RestaurantLabel.Font = new Font("Cambria", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RestaurantLabel.Location = new Point(289, 24);
            RestaurantLabel.Name = "RestaurantLabel";
            RestaurantLabel.Size = new Size(249, 57);
            RestaurantLabel.TabIndex = 5;
            RestaurantLabel.Text = "Restaurant";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(3035, 1456);
            Controls.Add(addRestPanel);
            Controls.Add(AddFoodPanel);
            Controls.Add(mainMenu);
            Controls.Add(mainRest);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            AddFoodPanel.ResumeLayout(false);
            AddFoodPanel.PerformLayout();
            addWords.ResumeLayout(false);
            addWords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridFood1).EndInit();
            addRestPanel.ResumeLayout(false);
            addRestPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridRest1).EndInit();
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridFood2).EndInit();
            mainRest.ResumeLayout(false);
            mainRest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridRest2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox FoodName;
        private Button AddFood;
        private TextBox FoodCost;
        private TextBox FoodDescription;
        private Label label4;
        private Panel AddFoodPanel;
        private Panel addRestPanel;
        private Button AddRest;
        private TextBox RestAddress;
        private TextBox RestName;
        private TextBox TypeofRest;
        private Label RestaurantLabel;
        private Button EditRest;
        private Label label5;
        private DataGridView gridFood1;
        private Panel mainRest;
        private Panel mainMenu;
        private DataGridView gridFood2;
        private Button ViewRest;
        private TextBox FoodRating;
        private DataGridView gridRest1;
        private DataGridView gridRest2;
        private Button removeRest1;
        private Button removeRest2;
        private Button removeFood1;
        private Button removeFood2;
        private Panel addWords;
        private Button addKeywordbutton;
        private TextBox addKeywords;
        private TextBox foodDescDisplay;
        private Button exitKeyword;
        private Button loadFile;
        private Button saveFile;
        private Button backToMainRest;
        private Button addFoodtoRest;
        private Button addRest1;
        private Button backtoMainRest1;
        private Button backToFood;
        private Label label1;
        private Label label3;
        private TextBox foodDescDisplay2;
    }
}
