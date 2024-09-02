using System.Collections.Specialized;
using System.Data;
using System.Web;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace RestaurantReviewApp
{
    public partial class RestReview : Form
    {
        public DataTable restTable = new DataTable(); // Data Table that holds the restaurants
        List<Restaurant> listRestaurant = new List<Restaurant>(); // List that holds the restaurants
        Restaurant selectedRestaurant = new Restaurant(); // Restaurant variable to assign the selected Restaurant to
        bool fromMenu = true;

        /** Restaurant Class holds a name, address, rating, list of food,
         * and a Data Table of food
         **/
        public class Restaurant
        {
            public Restaurant(string name, string type, string address) // Constructor
            {
                name_ = name;
                address_ = address;
                type_ = type;
                averageRating_ = 0;
                menu_ = new List<Food>();
                foodTable_ = new DataTable();
                foodTable_.Columns.Add("Name", typeof(string));
                foodTable_.Columns.Add("Cost", typeof(string));
                foodTable_.Columns.Add("Rating", typeof(double));
            }
            public Restaurant() // Default constructor
            {
                name_ = "";
                address_ = " ";
                type_ = "";
                averageRating_ = 0;
                menu_ = new List<Food>();
                foodTable_ = new DataTable();
                foodTable_.Columns.Add("Name", typeof(string));
                foodTable_.Columns.Add("Cost", typeof(string));
                foodTable_.Columns.Add("Rating", typeof(double));
            }
            public Restaurant(Restaurant rest) // Copy constructor
            {
                name_ = rest.name_;
                address_ = rest.address_;
                type_ = rest.type_;
                averageRating_ = rest.averageRating_;
                menu_ = rest.menu_;
                foodTable_ = rest.foodTable_;

            }
            public string GetName()
            {
                return name_;
            }
            public void SetName(string name)
            {
                name_ = name;
            }
            public string GetType()
            {
                return type_;
            }
            public void SetType(string type)
            {
                type_ = type;
            }
            public double GetRating()
            {
                double sum = 0;
                for (int i = 0; i < menu_.Count(); i++)
                {
                    sum += menu_[i].GetRating();
                }
                averageRating_ = sum / menu_.Count();
                return averageRating_;
            }
            public string GetAddress()
            {
                return address_;
            }
            public void SetAddress(string address)
            {
                address_ = address;
            }
            public void UpdateRating()
            {
                double sum = 0;
                for (int i = 0; i < menu_.Count(); i++)
                {
                    sum += menu_[i].GetRating();
                }
                averageRating_ = sum / menu_.Count();
            }
            string name_;
            string type_;
            string address_;
            double averageRating_;
            public List<Food> menu_;
            public DataTable foodTable_;
        }


        /** Food class holds the name, rating, description, cost, and a list of
         * keywords to describe the dish
        **/
        public class Food
        {
            public Food()
            {
                name_ = "";
                cost_ = 0;
                description_ = "";
                averageRating_ = 0;
                keywords_ = new List<string>();
            }
            public Food(string name, double cost, string description, int rating)
            {
                name_ = name;
                cost_ = cost;
                description_ = description;
                averageRating_ = rating;
                keywords_ = new List<string>();
            }
            public string GetName()
            {
                return name_;
            }
            public void SetName(string name)
            {
                name_ = name;
            }
            public double GetCost()
            {
                return cost_;
            }
            public void SetCost(double cost)
            {
                cost_ = cost;
            }
            public string GetDescription()
            {
                return description_;
            }
            public void SetDescription(string description)
            {
                description_ = description;
            }
            public double GetRating()
            {
                return averageRating_;
            }
            public void AddRating(double rating)
            {
                averageRating_ = rating;
            }
            public void AddKeywords(string keyword)
            {
                keywords_.Add(keyword);
            }
            public string GetKeywords()
            {
                string print = "";
                for (int i = 0; i < keywords_.Count(); i++)
                {
                    print += keywords_[i] + "\n";
                }
                print.TrimEnd();
                return print;
            }
            public string PrintKeywords()
            {
                string print = "";
                for (int i = 0; i < keywords_.Count(); i++)
                {
                    print += keywords_[i] + " ";
                }

                return print;
            }
            public int KeyWordCount()
            {
                return keywords_.Count();
            }
            public override string ToString()
            {
                return name_ + " " + cost_ + " " + description_ + " " + averageRating_;
            }
            string name_;
            string description_;
            double cost_;
            double averageRating_;
            List<string> keywords_;

        }

        public RestReview()
        {
            InitializeComponent();
            mainRest.Show();
        }
        // Add food button
        private void AddFood_Click(object sender, EventArgs e)
        {
            // Checks if the text boxes have valid inputs
            if (string.IsNullOrEmpty(FoodRating.Text))
                return;
            if (string.IsNullOrEmpty(FoodCost.Text))
                return;
            if (string.IsNullOrEmpty(FoodDescription.Text))
                return;
            int x;
            if (!int.TryParse(FoodRating.Text, out x))
                return;

            x = Int32.Parse(FoodRating.Text);
            Food newItem = new Food(FoodName.Text, Convert.ToDouble(FoodCost.Text), FoodDescription.Text, x); // new food item
            // add food to selected Restaurant's menu and Data Table
            selectedRestaurant.menu_.Add(newItem);
            selectedRestaurant.UpdateRating();
            DataRow addRow = selectedRestaurant.foodTable_.NewRow();
            addRow["Name"] = newItem.GetName();
            addRow["Cost"] = newItem.GetCost();
            addRow["Rating"] = newItem.GetRating();
            selectedRestaurant.foodTable_.Rows.Add(addRow);
            selectedRestaurant.foodTable_.AcceptChanges();

            //Update data grid views and restaurant ratings
            gridFood1.DataSource = selectedRestaurant.foodTable_;
            gridFood2.DataSource = selectedRestaurant.foodTable_;

            for (int i = 0; i < restTable.Rows.Count; i++)
            {
                if (restTable.Rows[i]["Name"].ToString() == selectedRestaurant.GetName())
                {
                    restTable.Rows[i]["Rating"] = selectedRestaurant.GetRating();
                }
            }

            gridRest1.DataSource = restTable;
            gridRest2.DataSource = restTable;
            //Clear text boxes
            FoodName.Clear();
            FoodCost.Clear();
            FoodDescription.Clear();
            FoodRating.Clear();
        }

        private void AddRest_Click_1(object sender, EventArgs e)
        {
            // checks if inputs are valuid
            string name, type, address;
            if (string.IsNullOrEmpty(RestName.Text))
                return;
            else
                name = RestName.Text;

            if (string.IsNullOrEmpty(TypeofRest.Text))
                return;
            else
                type = TypeofRest.Text;
            if (string.IsNullOrEmpty(RestAddress.Text))
                return;
            else
                address = RestAddress.Text;

            //Adds restaurant to global list of restaurants and data table
            Restaurant newPlace = new Restaurant(name, type, address);
            listRestaurant.Add(newPlace);

            if (restTable.Columns.Count == 0) // if table was empty
            {
                restTable.Columns.Add("Name", typeof(string));
                restTable.Columns.Add("Type of Food", typeof(string));
                restTable.Columns.Add("Address", typeof(string));
                restTable.Columns.Add("Rating", typeof(double));
            }


            DataRow addRow = restTable.NewRow();
            addRow["Name"] = newPlace.GetName();
            addRow["Type of Food"] = newPlace.GetType();
            addRow["Address"] = newPlace.GetAddress();
            addRow["Rating"] = newPlace.GetRating();

            restTable.Rows.Add(addRow);
            restTable.AcceptChanges();


            gridRest1.DataSource = restTable;
            gridRest2.DataSource = restTable;
            RestName.Clear();
            TypeofRest.Clear();
            RestAddress.Clear();
        }

        private void ViewRest_Click(object sender, EventArgs e)
        {
            // Selects the restaurant and moves panels
            if (gridRest1.Rows.Count > 0)
            {
                int rowIndex = gridRest1.SelectedCells[0].RowIndex;
                int colIndex = gridRest1.SelectedCells[0].ColumnIndex;
                string restName = gridRest1.Rows[rowIndex].Cells[colIndex].Value.ToString();
                label4.Text = restName + " Menu";
                selectedRestaurant = listRestaurant.Find(x => x.GetName() == (restName));
                gridFood1.DataSource = selectedRestaurant.foodTable_;
                addRestPanel.Visible = false;
                AddFoodPanel.Visible = true;
                fromMenu = false;
            }

        }

        private void ViewRest_Click_1(object sender, EventArgs e)
        {
            // Selects the restaurant and moves panels
            if (gridRest1.Rows.Count > 0)
            {
                int rowIndex = gridRest2.SelectedCells[0].RowIndex;
                int colIndex = gridRest2.SelectedCells[0].ColumnIndex;
                string restName = gridRest2.Rows[rowIndex].Cells[colIndex].Value.ToString();
                selectedRestaurant = listRestaurant.Find(x => x.GetName() == (restName));
                gridFood2.DataSource = selectedRestaurant.foodTable_;
                label3.Text = selectedRestaurant.GetName() + " Menu";
                mainRest.Visible = false;
                mainMenu.Visible = true;
            }
        }

        private void removeRest2_Click(object sender, EventArgs e)
        {
            // Removes the selected restaurant
            if (gridRest2.Rows.Count > 0)
            {
                int rowIndex = gridRest2.SelectedCells[0].RowIndex;
                restTable.Rows[rowIndex].Delete();
                restTable.AcceptChanges();

                listRestaurant.RemoveAt(rowIndex);

                gridRest1.DataSource = restTable;
                gridRest2.DataSource = restTable;
            }
        }

        private void removeFood1_Click(object sender, EventArgs e)
        {
            // Removes the selected food item
            if (gridFood1.Rows.Count > 0)
            {
                int rowIndex = gridFood1.SelectedCells[0].RowIndex;
                selectedRestaurant.foodTable_.Rows[rowIndex].Delete();
                selectedRestaurant.foodTable_.AcceptChanges();

                selectedRestaurant.menu_.RemoveAt(rowIndex);
                selectedRestaurant.UpdateRating();

                for (int i = 0; i < restTable.Rows.Count; i++)
                {
                    if (restTable.Rows[i]["Name"].ToString() == selectedRestaurant.GetName())
                    {
                        restTable.Rows[i]["Rating"] = selectedRestaurant.GetRating();
                    }
                }
                gridRest1.DataSource = restTable;
                gridRest2.DataSource = restTable;

                gridFood1.DataSource = selectedRestaurant.foodTable_;
                gridFood2.DataSource = selectedRestaurant.foodTable_;
            }
        }

        private void removeFood2_Click(object sender, EventArgs e)
        {
            // removes the selected food item
            if (gridFood2.Rows.Count > 0)
            {
                int rowIndex = gridFood2.SelectedCells[0].RowIndex;
                selectedRestaurant.foodTable_.Rows[rowIndex].Delete();
                selectedRestaurant.foodTable_.AcceptChanges();
                selectedRestaurant.menu_.RemoveAt(rowIndex);
                selectedRestaurant.UpdateRating();

                for (int i = 0; i < restTable.Rows.Count; i++)
                {
                    if (restTable.Rows[i]["Name"].ToString() == selectedRestaurant.GetName())
                    {
                        restTable.Rows[i]["Rating"] = selectedRestaurant.GetRating();
                    }
                }
                gridRest1.DataSource = restTable;
                gridRest2.DataSource = restTable;

                gridFood1.DataSource = selectedRestaurant.foodTable_;
                gridFood2.DataSource = selectedRestaurant.foodTable_;
            }
        }
        private void addKeywordbutton_Click(object sender, EventArgs e)
        {
            // Adds keyword to selected food item
            int rowIndex = gridFood2.SelectedCells[0].RowIndex;
            int colIndex = gridFood2.SelectedCells[0].ColumnIndex;
            string foodName = gridFood2.Rows[rowIndex].Cells[colIndex].Value.ToString();

            if (!string.IsNullOrEmpty(addKeywords.Text))
            {
                selectedRestaurant.menu_.Find(x => x.GetName() == foodName).AddKeywords(addKeywords.Text);
                addKeywords.Clear();
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // has the main panel visible only
            mainRest.Visible = true;
            // Reads in from file
            StreamReader sr = new StreamReader("restTable.txt");
            try
            {
                string line = sr.ReadLine();
                int numRest = Int32.Parse(line);

                for (int k = 0; k < numRest; k++)
                {
                    line = sr.ReadLine();
                    Restaurant newRest = new Restaurant();
                    newRest.SetName(line);
                    line = sr.ReadLine();
                    newRest.SetType(line);
                    line = sr.ReadLine();
                    newRest.SetAddress(line);
                    line = sr.ReadLine();
                    int counter = Int32.Parse(line);
                    for (int i = 0; i < counter; i++)
                    {
                        line = sr.ReadLine();
                        Food newFood = new Food();
                        newFood.SetName(line);
                        line = sr.ReadLine();
                        newFood.SetCost(Convert.ToDouble(line));
                        line = sr.ReadLine();
                        newFood.SetDescription(line);
                        line = sr.ReadLine();
                        newFood.AddRating(Convert.ToDouble(line));
                        line = sr.ReadLine();
                        int counter1 = Int32.Parse(line);

                        for (int j = 0; j < counter1; j++)
                        {
                            line = sr.ReadLine();
                            newFood.AddKeywords(line);
                        }

                        newRest.menu_.Add(newFood);
                        DataRow addRow1 = newRest.foodTable_.NewRow();
                        addRow1["Name"] = newFood.GetName();
                        addRow1["Cost"] = newFood.GetCost().ToString();
                        addRow1["Rating"] = newFood.GetRating().ToString();
                        newRest.foodTable_.Rows.Add(addRow1);
                        newRest.foodTable_.AcceptChanges();
                    }

                    listRestaurant.Add(newRest);

                    if (restTable.Columns.Count == 0)
                    {
                        restTable.Columns.Add("Name", typeof(string));
                        restTable.Columns.Add("Type of Food", typeof(string));
                        restTable.Columns.Add("Address", typeof(string));
                        restTable.Columns.Add("Rating", typeof(double));
                    }

                    DataRow addRow = restTable.NewRow();
                    addRow["Name"] = newRest.GetName();
                    addRow["Type of Food"] = newRest.GetType();
                    addRow["Address"] = newRest.GetAddress();
                    addRow["Rating"] = newRest.GetRating();

                    restTable.Rows.Add(addRow);
                    restTable.AcceptChanges();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            sr.Close();

            // Assigns rest table to the grid and ensures other panels aren't visible
            gridRest1.DataSource = restTable;
            gridRest2.DataSource = restTable;
            addWords.Visible = false;
            mainMenu.Visible = false;
            addRestPanel.Visible = false;
            AddFoodPanel.Visible = false;

        }

        private void gridFood1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // When you select a food in the grid table
            addWords.Visible = true;
            int rowIndex = gridFood1.SelectedCells[0].RowIndex;
            int colIndex = gridFood1.SelectedCells[0].ColumnIndex;
            string foodName = gridFood1.Rows[rowIndex].Cells[colIndex].Value.ToString();

            Food temp = selectedRestaurant.menu_.Find(x => x.GetName() == foodName);

            string description = "Desription: " + temp.GetDescription();
            string keywords = "Keywords: " + temp.PrintKeywords();

            foodDescDisplay.Text = "Desription: " + temp.GetDescription() + Environment.NewLine + "Keywords: " + temp.PrintKeywords();


        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            // Saves information to text file 
            StreamWriter sw = new StreamWriter("restTable.txt");
            sw.WriteLine(listRestaurant.Count());
            for (int i = 0; i < listRestaurant.Count(); i++)
            {
                sw.WriteLine(listRestaurant[i].GetName());
                sw.WriteLine(listRestaurant[i].GetType());
                sw.WriteLine(listRestaurant[i].GetAddress());
                sw.WriteLine(listRestaurant[i].menu_.Count());
                for (int j = 0; j < listRestaurant[i].menu_.Count(); j++)
                {
                    sw.WriteLine(listRestaurant[i].menu_[j].GetName());
                    sw.WriteLine(listRestaurant[i].menu_[j].GetCost());
                    sw.WriteLine(listRestaurant[i].menu_[j].GetDescription());
                    sw.WriteLine(listRestaurant[i].menu_[j].GetRating());
                    sw.WriteLine(listRestaurant[i].menu_[j].KeyWordCount());
                    if((listRestaurant[i].menu_[j].KeyWordCount()) > 0) 
                        sw.WriteLine(listRestaurant[i].menu_[j].GetKeywords());
                }

            }
            sw.Close();

        }

        private void backToMainRest_Click(object sender, EventArgs e)
        {
            // Back button
            mainRest.Visible = true;
            mainMenu.Visible = false;
            foodDescDisplay.Clear();
            foodDescDisplay2.Clear();
        }

        private void addFoodtoRest_Click(object sender, EventArgs e)
        {
            // add food to the menu
            if (gridRest2.Rows.Count > 0)
            {
                int rowIndex = gridRest1.SelectedCells[0].RowIndex;
                int colIndex = gridRest1.SelectedCells[0].ColumnIndex;
                string restName = gridRest1.Rows[rowIndex].Cells[colIndex].Value.ToString();
                label4.Text = restName + " Menu";
                selectedRestaurant = listRestaurant.Find(x => x.GetName() == (restName));
                gridFood1.DataSource = selectedRestaurant.foodTable_;
                fromMenu = true;
                mainMenu.Visible = false;
                AddFoodPanel.Visible = true;
            }
        }

        private void addRest1_Click(object sender, EventArgs e)
        {
            // takes you to add rest panel
            mainRest.Visible = false;
            addRestPanel.Visible = true;
        }

        private void backtoMainRest1_Click(object sender, EventArgs e)
        {
            // takes you to main panel
            mainRest.Visible = true;
            addRestPanel.Visible = false;
        }

        private void backToFood_Click(object sender, EventArgs e)
        {
            // takes you to the previous panel from the add food panel
            if (fromMenu)
                mainMenu.Visible = true;
            else
                addRestPanel.Visible = true;

            AddFoodPanel.Visible = false;
            foodDescDisplay.Clear();
            foodDescDisplay2.Clear();
        }

        private void exitKeyword_Click(object sender, EventArgs e)
        {
            // exits out of keyword popup window
            addWords.Visible = false;
        }

        private void removeRest1_Click_1(object sender, EventArgs e)
        {
            // Removes a restaurant from the list and data table
            if (gridRest1.Rows.Count > 0)
            {
                int rowIndex = gridRest1.SelectedCells[0].RowIndex;
                restTable.Rows[rowIndex].Delete();
                restTable.AcceptChanges();

                listRestaurant.RemoveAt(rowIndex);

                gridRest1.DataSource = restTable;
                gridRest2.DataSource = restTable;
            }
        }

        private void gridFood2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Provides a description when you select a food in the menu
            addWords.Visible = true;
            int rowIndex = gridFood2.SelectedCells[0].RowIndex;
            int colIndex = gridFood2.SelectedCells[0].ColumnIndex;
            string foodName = gridFood2.Rows[rowIndex].Cells[colIndex].Value.ToString();

            Food temp = selectedRestaurant.menu_.Find(x => x.GetName() == foodName);

            foodDescDisplay2.Text = "Desription: " + temp.GetDescription() + Environment.NewLine + "Keywords: " + temp.PrintKeywords();
        }

        private void gridRest1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Selects the restaurant and moves panels
            if (gridRest1.Rows.Count > 0)
            {
                int rowIndex = gridRest1.SelectedCells[0].RowIndex;
                int colIndex = gridRest1.SelectedCells[0].ColumnIndex;
                string restName = gridRest1.Rows[rowIndex].Cells[colIndex].Value.ToString();
                label4.Text = restName + " Menu";
                selectedRestaurant = listRestaurant.Find(x => x.GetName() == (restName));
                gridFood1.DataSource = selectedRestaurant.foodTable_;
                addRestPanel.Visible = false;
                AddFoodPanel.Visible = true;
                fromMenu = false;
            }
        }

        private void gridRest2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridRest1.Rows.Count > 0)
            {
                int rowIndex = gridRest2.SelectedCells[0].RowIndex;
                int colIndex = gridRest2.SelectedCells[0].ColumnIndex;
                string restName = gridRest2.Rows[rowIndex].Cells[colIndex].Value.ToString();
                selectedRestaurant = listRestaurant.Find(x => x.GetName() == (restName));
                gridFood2.DataSource = selectedRestaurant.foodTable_;
                label3.Text = selectedRestaurant.GetName() + " Menu";
                mainRest.Visible = false;
                mainMenu.Visible = true;
            }
        }
    }
}
