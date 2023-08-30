using Market_Desktop_App0.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Desktop_App0
{
    public partial class Form2 : Form
    {
        //sql bağlantısı
        SqlConnection connection = new(Connection.ConnectionString);
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GetReceipts();
        }

        private void GetReceipts()
        {
            connection.Open();
            SqlCommand command = new("Select * From Receipts Order By Date Desc", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dgReceipts.Rows.Add();
                int rowCount = dgReceipts.Rows.Count - 1;

                //veritabanındaki kayıtları okur
                dgReceipts.Rows[rowCount].Cells["Count"].Value = rowCount + 1;
                dgReceipts.Rows[rowCount].Cells["ReceiptNumber"].Value = reader["ReceiptNumber"];
                dgReceipts.Rows[rowCount].Cells["Date"].Value = reader["Date"];
                dgReceipts.Rows[rowCount].Cells["Total"].Value = reader["Total"];
                dgReceipts.Rows[rowCount].Cells["Payment"].Value = reader["Payment"];
                dgReceipts.Rows[rowCount].Cells["Remaining"].Value = reader["Remaining"];
            }

            connection.Close();
        }

        private void dgReceipts_Click(object sender, EventArgs e)
        {
            dgReceiptDetails.Rows.Clear();

            DataGridViewRow row = dgReceipts.CurrentRow; //seçili satırı alır
            if (row != null && !row.IsNewRow)
            {
                object value = row.Cells["ReceiptNumber"].Value;
                string receiptNumber = value?.ToString(); //null değilse stringe çevirir

                connection.Open();
                SqlCommand receiptCmd = new("Select * From Receipts Where ReceiptNumber = @ReceiptNumber", connection);
                receiptCmd.Parameters.AddWithValue("@ReceiptNumber", receiptNumber);
                SqlDataReader receiptReader = receiptCmd.ExecuteReader();
                if (receiptReader.Read())
                {
                    //id'yi al
                    int receiptId = (int)receiptReader["Id"];

                    receiptReader.Close();

                    SqlCommand receiptDetailsCmd = new("Select p.Name As Name, rd.Quantity as Quantity, rd.Price as Price, rd.Total as Total From ReceiptDetails As rd Left Join Products As p on rd.ProductId = p.Id Where ReceiptId = @ReceiptId", connection);
                    receiptDetailsCmd.Parameters.AddWithValue("@ReceiptId", receiptId);
                    SqlDataReader receiptDetailReader = receiptDetailsCmd.ExecuteReader();
                    if (receiptDetailReader.Read())
                    {
                        while (receiptDetailReader.Read())
                        {
                            dgReceiptDetails.Rows.Add();
                            int dgRDCount = dgReceiptDetails.Rows.Count - 1;

                            dgReceiptDetails.Rows[dgRDCount].Cells["RDCount"].Value = dgRDCount + 1;
                            dgReceiptDetails.Rows[dgRDCount].Cells["RDProductName"].Value = receiptDetailReader["Name"];
                            dgReceiptDetails.Rows[dgRDCount].Cells["RDQuantity"].Value = receiptDetailReader["Quantity"];
                            dgReceiptDetails.Rows[dgRDCount].Cells["RDPrice"].Value = receiptDetailReader["Price"];
                            dgReceiptDetails.Rows[dgRDCount].Cells["RDTotal"].Value = receiptDetailReader["Total"];
                        }

                        receiptDetailReader.Close();
                    }
                }

                dgReceiptDetails.ClearSelection();
                connection.Close();
            }
        }
    }
}
