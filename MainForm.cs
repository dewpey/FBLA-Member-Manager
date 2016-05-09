using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Data.OleDb;
namespace Inforum
{
    public partial class MainForm : Form
    {
        //Initialize the form
        public MainForm()
        {
            InitializeComponent();
        }

        //When the main form is finished loading...
        private void Form1_Load(object sender, EventArgs e)
        {
            //create new instance of the loading form
            LoadingForm loadingForm = new LoadingForm();
            //show the loading form
            loadingForm.Show();
            //bring the loading form to the front
            loadingForm.TopMost = true;
        }

        //when the create report button is pressed...
        private void ribbonButton11_Click(object sender, EventArgs e)
        {
            //shows the export menu
            //hide the datagridview chart
            dataGridView1.Hide();
            //enable the back to spreadsheet button
            backToSpreadsheet.Enabled = true;
        }

        //***This reason this is all  in one method is to save on memory allocation and to prevent excess programming required with "this" instancing***
        //
        //This is the main part of the program that exports the files to excel
        //The two parameters for this method are open and print which are both boolean
        public void exportToExcel(Boolean open, Boolean print)
        {

            // Creating a Excel objects, workbooks, and worksheets
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            //create an instance of the save dialog for saving later on
            SaveFileDialog saveDialog = new SaveFileDialog();
            //try this method with catch
            try
            {
                //Define worksheet as Sheet1
                worksheet = workbook.Sheets["Sheet1"];
                //Make sheet1 our main sheet
                worksheet = workbook.ActiveSheet;

                //organize the DataGridView by state from A-Z
                dataGridView1.Sort(state, ListSortDirection.Ascending);

                //Using for loop, export the column headers from the dataGridView to excel worksheet
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
              
                //Using for loop, export all the data from the dataGridView to excel worksheet
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Rows[i].Cells.Count; j++)
                    {
                            worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;

                    }

                }

                //create an boolean array of the output parameters
                Boolean[] output1 = new Boolean[10];

                //Go through 11 if statements and if they are checked then on the array position write true
                if (memberNumberBox.Checked)
                {
                    output1[0] = true;
                }
                if (firstNameBox.Checked)
                {
                    output1[1] = true;
                }
                if (lastNameBox.Checked)
                {
                    output1[2] = true;
                }
                if (schoolBox.Checked)
                {
                    output1[3] = true;
                }
                if (stateBox.Checked)
                {
                    output1[4] = true;
                }
                if (emailBox.Checked)
                {
                    output1[5] = true;
                }
                if (yearJoinedBox.Checked)
                {
                    output1[6] = true;
                }
                if (graduationYearBox.Checked)
                {
                    output1[7] = true;
                }
                if (currentActiveBox.Checked)
                {
                    output1[8] = true;
                }
                if (AmountBox.Checked)
                {
                    output1[9] = true;
                }



                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if ((activeBox.Checked == false && worksheet.Cells[i+1,9].Value.ToString() == "Yes"))
                    {
                        worksheet.Rows[i + 1].Delete();
                    }

                    if ((nonActiveBox.Checked == false && worksheet.Cells[i + 1, 9].Value.ToString() == "No"))
                    {
                        worksheet.Rows[i + 1].Delete();
                    }

                    if ((freshmenBox.Checked == false && worksheet.Cells[i + 1, 8].Value.ToString() == "2019"))
                    {
                        worksheet.Rows[i + 1].Delete();
                    }
                    if ((sophmoreBox.Checked == false && worksheet.Cells[i + 1, 8].Value.ToString() == "2018"))
                    {
                        worksheet.Rows[i + 1].Delete();
                    }
                    if ((juniorBox.Checked == false && worksheet.Cells[i + 1, 8].Value.ToString() == "2017"))
                    {
                        worksheet.Rows[i + 1].Delete();
                    }
                    if ((seniorBox.Checked == false && worksheet.Cells[i + 1, 8].Value.ToString() == "2016"))
                    {
                        worksheet.Rows[i + 1].Delete();
                    }
                    if ((sophmoreBox.Checked == false && worksheet.Cells[i + 1, 8].Value.ToString() == "2018"))
                    {
                        worksheet.Rows[i + 1].Delete();
                    }
                    if ((balanceBox.Checked == false && worksheet.Cells[i + 1, 10].Value.ToString() != null))
                    {
                        worksheet.Rows[i + 1].Delete();
                    }


  
                }
/*
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (freshmenBox.Checked == false && worksheet.Columns.Columns[7].Rows.Rows[i] == 2019)
                    {
                        //worksheet.Rows.Rows[i].Delete();
                        Console.WriteLine("no fresh");
                    }
                    if (sophmoreBox.Checked == false && worksheet.Columns.Columns[7].Rows.Rows[i] == 2018)
                    {
                        //worksheet.Rows.Rows[i].Delete();
                        Console.WriteLine("no soph");
                    }
                    if (juniorBox.Checked == false && worksheet.Columns.Columns[7].Rows.Rows[i] == 2017)
                    {
                        //worksheet.Rows.Rows[i].Delete();
                        Console.WriteLine("no junior");
                    }
                    if (seniorBox.Checked == false && worksheet.Columns.Columns[7].Rows.Rows[i] == 2016)
                    {
                        //worksheet.Rows.Rows[i].Delete();
                        Console.WriteLine("no senior");
                    }
                } */

                //Using a for loop, cycle through the array we created above and if they aren't true delete the column from the worksheet
               /* for (int i = 0; i < output1.Length; i++ )
                {
                    if (!(output1[i]))
                    {
                        worksheet.Columns.Columns[i].Delete();
                    }
                }
                */
                int j = 0;
                 foreach(object item in checkedListBox1.CheckedItems) {
                     if (!checkedListBox1.CheckedItems.Contains(item))
                            {
                         worksheet.Columns.Columns[j].Delete();
                            }
                        j++;
                    }
                
                worksheet.PageSetup.CenterFooter = "Dankmemes";

                //Getting the location and file name of the excel to save from user. 
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                //If save dialog is closed and location has been selected...
                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //save the file and say that the export was successful
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Export Successful");
                }
                //if the print boolean is true...
                if (print)
                {
                    //show the print dialog in Excel
                    //printing is offloaded to Excel to reduce application size
                    excel.Dialogs[Microsoft.Office.Interop.Excel.XlBuiltInDialog.xlDialogPrint].Show();
                }
                //exit the excel instance which is not visible
                excel.Quit();
                //if the open boolean is true...
                if (open)
                {
                    //Open the recently saved file
                    System.Diagnostics.Process.Start(saveDialog.FileName);
                }
               
            }
                //Catch any errors and output them to the user
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

                //At the end clear the workbook and excel variables
            finally
            {
                workbook = null;
                excel = null;
            }
          
        }
        
        //Show the datagridview and disable the back to spreadsheet button
        private void button1_Click_2(object sender, EventArgs e)
        {
            dataGridView1.Show();
            backToSpreadsheet.Enabled = false;
        }

        //Show the datagridview and disable the back to spreadsheet button
        private void ribbonButton7_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Show();
            backToSpreadsheet.Enabled = false;
        }

        //When the save and view in Excel file button is clicked...
        private void button2_Click_1(object sender, EventArgs e)
        {
            //Execute the exportToExcel method with open as true and print as false
            exportToExcel(true, false);
        }

        //When the print button is clicked...
        private void button3_Click(object sender, EventArgs e)
        {
            //Execute the exportToExcel method with open as false and print as true
            exportToExcel(false, true);
        }

        //When the save button is clicked...
        private void button5_Click(object sender, EventArgs e)
        {
            //Execute the exportToExcel method with open as false and print as false
            exportToExcel(false, false);
        }

        //When the save button in the file menu is clicked...
        private void ribbonOrbMenuItem4_Click(object sender, EventArgs e)
        {
            //Execute the exportToExcel method with open as false and print as false
            exportToExcel(false, false);
        }

        //This method is used to open Excel files and load them into the DataGridView
        private void ribbonButton8_Click(object sender, EventArgs e)
        {
            //Create instance of openFileDialog
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;

            //Disable multi file selection
            openFileDialog1.Multiselect = false;

            // Call the ShowDialog method to show the dialog box.
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Name target sheet as Sheet1
                String name = "Sheet1";
                //Create the MySQL constructor built for Excel 2007 and above
                String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + openFileDialog1.FileName
                                 +
                                ";Extended Properties='Excel 12.0 XML;HDR=YES;';";

                //Create the Database Connection instance
                OleDbConnection con = new OleDbConnection(constr);
                OleDbCommand oconn = new OleDbCommand("Select * From [" + name + "$]", con);
                con.Open();

                //Create Database data adapter to convert from OleDB to DataTable
                OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
                //Create DataTable Instance
                DataTable data = new DataTable();
                //Fill DataTable with Database data
                sda.Fill(data);
                //Clear the DataGridView completely
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                //Load DataTable into DataGridView
                dataGridView1.DataSource = data;
             
            }
           
        }

        //Open the documentation word file when the documentation button is clicked
        private void documentationButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("documentation-sysrq-tutorials.docx");
        }

        private void deleteRowButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
            {
                if (oneCell.Selected)
                    dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
            }
        }
    }
}
