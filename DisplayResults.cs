using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace a
{
    public partial class DisplayResults : Form
    {
        private string[,] dt = null;
        private int count = 0;
        private int currentPage = 1;
        private int pageSize = 10;
        private int totalPage = 0;
        
        public DisplayResults(string[,] dt)
        {
            this.dt = dt;
            
            InitializeComponent();
        }

        // Calculates the total pages of a result for page count use
        private int CalculateTotalPages(string[,] dt, int totalPage)
        {
            int rowCount = dt.Length;
            totalPage = rowCount / pageSize;

            if (rowCount % pageSize > 0)
                totalPage += 1;
            return totalPage;
        }
        
        // Displays the result in a list
        private void DisplayResults_Load(object sender, EventArgs e)
        {

            if(dt != null)
            {

                for (int i = count; i < 10; i++)
                {
                    i = ResultsShow2.Rows.Add();
                    if (count < dt.GetLength(0) - 1)
                    {
                        ResultsShow2.Rows[i].Cells[0].Value = dt[i, 0];
                        ResultsShow2.Rows[i].Cells[1].Value = dt[i, 1];
                        ResultsShow2.Rows[i].Cells[2].Value = dt[i, 2];
                        ResultsShow2.Rows[i].Cells[3].Value = dt[i, 3].Substring(0, dt[i, 3].IndexOf(".")) + ".";
                    }
                    else
                    {
                        ResultsShow2.Rows[i].Cells[0].Value = "";
                        ResultsShow2.Rows[i].Cells[1].Value = "";
                        ResultsShow2.Rows[i].Cells[2].Value = "";
                        ResultsShow2.Rows[i].Cells[3].Value = "";
                    }
                    count = i;
                    Console.WriteLine(count);
                }

            }
            
        }
       
        // Next page button click
        private void NextButton_Click(object sender, EventArgs e)
        {

            currentPage++;
            PageNum.Text = currentPage.ToString();
            if (currentPage == totalPage)
            {
                PageNum.Text = currentPage.ToString();
                MessageBox.Show("This is the last page.");
            }

            if (dt != null)
            {
                int w = dt.GetLength(0) / 10 + 2;

                if (count < dt.GetLength(0) - 1)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (count < dt.GetLength(0) - 1)
                        {

                            ResultsShow2.Rows[i].Cells[0].Value = dt[count + 1, 0];
                            ResultsShow2.Rows[i].Cells[1].Value = dt[count + 1, 1];
                            ResultsShow2.Rows[i].Cells[2].Value = dt[count + 1, 2];
                            ResultsShow2.Rows[i].Cells[3].Value = dt[count + 1, 3].Substring(0, dt[count + 1, 3].IndexOf(".")) + ".";
                            count++;

                        }
                        else
                        {
                            ResultsShow2.Rows[i].Cells[0].Value = "";
                            ResultsShow2.Rows[i].Cells[1].Value = "";
                            ResultsShow2.Rows[i].Cells[2].Value = "";
                            ResultsShow2.Rows[i].Cells[3].Value = "";

                            count++;
                        }

                    }

                }
            }
            
        }

        // Previous page button click
        private void PreviousButton_Click(object sender, EventArgs e)
        {

            currentPage--;
            PageNum.Text = currentPage.ToString();
            if (currentPage == 1)
            {
                PageNum.Text = currentPage.ToString();
                
            }


            if (count > 18)
            {
                count = count - 20;
                for (int i = 0; i < 10; i++)
                {
                        ResultsShow2.Rows[i].Cells[0].Value = dt[count + 1, 0];
                        ResultsShow2.Rows[i].Cells[1].Value = dt[count + 1, 1];
                        ResultsShow2.Rows[i].Cells[2].Value = dt[count + 1, 2];
                        ResultsShow2.Rows[i].Cells[3].Value = dt[count + 1, 3].Substring(0, dt[count + 1, 3].IndexOf(".")) + ".";
                        count++;
                        //Console.WriteLine(i);
                }
            }                         
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            System.Windows.Forms.MessageBox.Show("Title: " + dt[count - 9 + e.RowIndex, 0] + "\n\nAuthor: " + dt[count - 9 + e.RowIndex, 1] + "\n\nBibliographic: " + dt[count - 9 + e.RowIndex, 2] + "\n\nAbstract :" + dt[count -9 + e.RowIndex, 3]);
        }

        private void Instruction_Click(object sender, EventArgs e)
        {

        }

        private void PageNum_Click(object sender, EventArgs e)
        {
        }


    }
}
