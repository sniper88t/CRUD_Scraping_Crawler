using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Collections.ObjectModel;
using MySql.Data.MySqlClient;  //Its for MySQL 

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
            showDataBase();
        }

        public class Prices
        {
            // BRAND | ITEM NAME | ITEM ID | PRICE_FROM_DB | FETCHED_PRICE | DISCOUNT AMOUNT
            private string cs_brand;
            private string cs_itemName;
            private string cs_itemID;
            private string cs_costprice;
            private string cs_fetched_price;
            private string cs_discount_price;

            public Prices(string brand, string itemName, string itemID, string costprice, string fetched_price, string discount_price)
            {
                this.cs_brand = brand;
                this.cs_itemName = itemName;
                this.cs_itemID = itemID;
                this.cs_costprice = costprice;
                this.cs_fetched_price = fetched_price;
                this.cs_discount_price = discount_price;
            }

            public string Brand
            {
                get { return this.cs_brand; }
            }
 
            public string ItemName
            {
                get { return this.cs_itemName; }
            }
            public string ItemID
            {
                get { return this.cs_itemID; }
            }

            public string CostPrice
            {
                get { return this.cs_costprice; }
            }
            public string Fetched_Price
            {
                get { return this.cs_fetched_price; }
            }

            public string Discount_Price
            {
                get { return this.cs_discount_price; }
            }

        }

        private void btnFetchData_Click(object sender, EventArgs e)
        {
            showDataBase();
        }

        // Fetching data of DB into DataGridView
        private void showDataBase() {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;database=discountdb";
                //Display query  
                string Query = "select * from testtable;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                                                   // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Display the result(7 items)
        private void listModule()
        {
            try
            {
                //var wholeArrayList = new ArrayList();
                ArrayList wholelist = new ArrayList();
                string MyConnection2 = "datasource=localhost;port=3306;username=root;database=discountdb";
                string Query = "select * from testtable";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                
                while (MyReader2.Read())
                {                   
                    int idProduct = Convert.ToInt32(MyReader2["id"]);
                    string brand = Convert.ToString(MyReader2["brand"]);
                    string item_name = Convert.ToString(MyReader2["item_name"]);
                    string item_id = Convert.ToString(MyReader2["item_id"]);
                    string cost_price = Convert.ToString(MyReader2["cost_price"]);
                    List<string> tmpscrape = new List<string>();
                    tmpscrape = scrapingMudule(item_id);
                    wholelist.Add(new Prices(brand, item_name, item_id, cost_price, tmpscrape[0].ToString(), tmpscrape[1].ToString()));
                    Console.WriteLine(wholelist);
                }
                
                MyConn2.Close();
                Console.WriteLine(wholelist);
                dataGridView1.DataSource = wholelist;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private List<string> scrapingMudule(string item_id)
        {
            List<string> listresult = new List<string>();
            try 
            {
                var options = new ChromeOptions();
                options.AddUserProfilePreference("download.default_directory", "YOUR_DownloadPath");
                options.AddUserProfilePreference("disable-popup-blocking", "true");
                options.AddUserProfilePreference("download.prompt_for_download", false);
                options.AddArguments("disable-infobars");
                options.AddArgument("--headless");
                IWebDriver driver = new ChromeDriver(options);

                driver.Navigate().GoToUrl("https://www.swansonvitamins.com/");
                Thread.Sleep(5000);

                driver.FindElement(By.Id("search")).SendKeys(item_id);
                Thread.Sleep(1000);
                driver.FindElement(By.Id("search")).SendKeys(OpenQA.Selenium.Keys.Enter);
                Thread.Sleep(1000);

                ReadOnlyCollection<IWebElement> fetchPrice = driver.FindElements(By.ClassName("lg-price"));
                Console.WriteLine(fetchPrice[0].Text);

                ReadOnlyCollection<IWebElement> discount = driver.FindElements(By.ClassName("diagonal-cross-out"));
                Console.WriteLine(discount[0].Text);

                ReadOnlyCollection<IWebElement> pecentDiscount = driver.FindElements(By.ClassName("swanson-save-percent"));
                Console.WriteLine(pecentDiscount[0].Text);

                Thread.Sleep(1000);
                listresult.Add(fetchPrice[0].Text);
                listresult.Add(discount[0].Text);
                listresult.Add(pecentDiscount[0].Text);
                driver.Quit();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return listresult;

        }

        private void btnAllData_Click(object sender, EventArgs e)
        {
            listModule();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                txtID.Text = row.Cells[0].Value.ToString();
                txtBrandName.Text = row.Cells[1].Value.ToString();
                txtItemName.Text = row.Cells[2].Value.ToString();
                txtItemID.Text = row.Cells[3].Value.ToString();
                txtCostPrice.Text = row.Cells[4].Value.ToString();
            }
        }
        //Insert New data into MySQL DB
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBrandName.Text != "" && txtItemID.Text != "" && txtItemName.Text !="" && txtCostPrice.Text != "")
            {
                try
                {
                    //This is my connection string i have assigned the database file address path  
                    string MyConnection2 = "datasource=localhost;port=3306;username=root;database=discountdb";
                    //This is my insert query in which i am taking input from the user through windows forms  
                    string Query = "insert into testtable(brand,item_name,item_id,cost_price) values('" + this.txtBrandName.Text + "','" + this.txtItemName.Text + "','" + this.txtItemID.Text + "','" + this.txtCostPrice.Text + "');";
                    //This is  MySqlConnection here i have created the object and pass my connection string.  
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    //This is command class which will handle the query and connection object.  
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                    MessageBox.Show("Save Data");
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                showDataBase();
            }
            else
            {
                MessageBox.Show("Fill in all data items before adding the data!");
            }
                
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtID.Text != "")
            {
                try
                {
                    //This is my connection string i have assigned the database file address path  
                    string MyConnection2 = "datasource=localhost;port=3306;username=root;database=discountdb";
                    //This is my update query in which i am taking input from the user through windows forms and update the record.  
                    string Query = "update testtable set brand='" + this.txtBrandName.Text + "',item_name='" + this.txtItemName.Text + "',item_id='" + this.txtItemID.Text + "',cost_price='" + this.txtCostPrice.Text + "' where id='" + this.txtID.Text + "';";
                    //This is  MySqlConnection here i have created the object and pass my connection string.  
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Data Updated");
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();//Connection closed here  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                showDataBase();
            }
            else
            {
                MessageBox.Show("Select the item you want to update!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                try
                {
                    string MyConnection2 = "datasource=localhost;port=3306;username=root;database=discountdb";
                    string Query = "delete from testtable where id='" + this.txtID.Text + "';";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Data Deleted");
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                showDataBase();
            }
            else
            {
                MessageBox.Show("Select the item you want to delete");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showDataBase();
            txtID.Text = "";
            txtBrandName.Text = "";
            txtItemID.Text = "";
            txtItemName.Text = "";
            txtCostPrice.Text = "";
        }
    }
}
