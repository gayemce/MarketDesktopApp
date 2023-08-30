using Market_Desktop_App0.Constants;
using System.Data.SqlClient;
using System.Transactions;

namespace Market_Desktop_App0
{
    public partial class Form1 : Form
    {

        //sql bağlantısı
        SqlConnection connection = new(Connection.ConnectionString);

        int receiptId = 0;
        decimal total = 0;
        decimal remaining = 0;

        //buradan alınan veriler veritabnına kaydedileceği için böyle yapıldı.
        //Classların liste türünde instanceları türetildi, sonrasında nesne instanceları ile değerler atanıp onlarda listeye ekleniyor.
        List<ReceiptDetail> receiptDetails = new();
        List<ReceiptPayment> receiptPayments = new();

        public Form1()
        {
            InitializeComponent();
        }
        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                connection.Open();

                int id;
                if (!int.TryParse(txtBarcode.Text, out id))
                {
                    MessageBox.Show("Sadece numaratik değerler girebilirsiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //sql sorgusu id'ye göre ürün getir
                SqlCommand command = new("Select Top 1 * From Products WHERE Id =" + id, connection);
                SqlDataReader reader = command.ExecuteReader(); //sql kodunu okuması için, veri bunun içinde
                if (reader.Read())
                {
                    //okuduysa ürün bilgilerini veritabanından al.
                    var name = reader["Name"].ToString();//obje içindeki veriler böyle okunabilir
                    var price = (decimal)reader["Price"];

                    //methodu çağırarak listeye yazdır
                    AddShopingCard(id, name, price);
                }
                else
                {
                    MessageBox.Show("Ürün bulunamadı", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                connection.Close();

            }
        }

        private void AddShopingCard(int id, string name, decimal price)
        {

            dgList.Rows.Add(); //her seferinde yeni bir satır ekliyor
            int count = dgList.Rows.Count - 1; //1 den başladığı için 1 azalltık 

            //Datagride default öge atama
            dgList.Rows[count].Cells[0].Value = count + 1; //id
            dgList.Rows[count].Cells[1].Value = name; //name
            dgList.Rows[count].Cells[2].Value = 1; //quantity
            dgList.Rows[count].Cells[3].Value = price; //price
            dgList.Rows[count].Cells[4].Value = (price * 1).ToString("#,##0.00") + "₺"; //total price

            //Obje oluşturulur, verileri veritabanına göre ekleniyor
            ReceiptDetail receiptDetail = new()
            {
                Price = price,
                Total = price * 1,
                ProductId = 1,
                ReceiptId = 1,
                Quantity = 1
            };
            receiptDetails.Add(receiptDetail); //listeye ekle

            txtBarcode.Text = "";

            //Toplam sepet tutarı
            total = 0;
            for (int i = 0; i < dgList.Rows.Count; i++)
            {   //quantity * price
                total += (Convert.ToDecimal(dgList.Rows[i].Cells["Quantity"].Value) * Convert.ToDecimal(dgList.Rows[i].Cells["Price"].Value));
            }

            lblTotal.Text = total.ToString("#,##0.00") + " ₺"; //tl format

            //Ödenen miktarı hesapla
            decimal totalPayment = 0;
            for (int i = 0; i < dgPayment.Rows.Count; i++)
            {
                totalPayment += Convert.ToDecimal(dgPayment.Rows[i].Cells[1].Value);
            }

            //remaing buradan alınır, ödenen miktarı çıkartır.
            remaining = total - totalPayment; ;

            //remaingi yazdır
            lblRemaing.Text = remaining.ToString("#,##0.00") + " ₺"; ;

            //paymenti yazdır
            txtPayment.Text = remaining.ToString();
        }

        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            string payment = txtPayment.Text;
            dgPayment.Rows.Add("Credit Card", payment);
            txtPayment.Text = "0";

            //ödeme sonrası kalan ödemeyi hesapla
            remaining -= Convert.ToDecimal(payment);

            //fazla para verildiğinde ödeme yöntemlerini kapat
            if (remaining <= 0) gbPayment.Enabled = false;
            lblRemaing.Text = remaining.ToString("#,##0.00") + " ₺"; ;

            ReceiptPayment receiptPayment = new()
            {
                ReceiptId = 1,
                Amount = Convert.ToDecimal(payment),
                Type = "Credit Card"
            };
            receiptPayments.Add(receiptPayment);

        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            string payment = txtPayment.Text;
            dgPayment.Rows.Add("Cash", payment);
            txtPayment.Text = "0";

            //ödeme sonrası kalan ödemeyi hesapla
            remaining -= Convert.ToDecimal(payment);

            //fazla para verildiğinde ödeme yöntemlerini kapat
            if (remaining <= 0) gbPayment.Enabled = false;
            lblRemaing.Text = remaining.ToString("#,##0.00") + " ₺";

            ReceiptPayment receiptPayment = new()
            {
                ReceiptId = 1,
                Amount = Convert.ToDecimal(payment),
                Type = "Cash"
            };
            receiptPayments.Add(receiptPayment);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            dgList.Rows.Clear();
            dgPayment.Rows.Clear();
            lblTotal.Text = "0,00 ₺";
            lblRemaing.Text = "0,00 ₺";
            txtPayment.Text = "0";
            total = 0;
            remaining = 0;
            gbPayment.Enabled = true; //her şey silinip yeni işleme geçecek
            txtBarcode.Focus();
            receiptDetails = new();
            receiptPayments = new();
            receiptId = 0;
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            //Yapılan kaydı veritabanına aktaracak.
            if (remaining > 0)
            {
                MessageBox.Show("Tüm ödeme gerçekleştirilmedi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            connection.Open();

            SqlTransaction transaction = connection.BeginTransaction(); //log veritabanını bekletir

            try
            {

                //Fiş oluşturulur.
                Guid receiptNumber = Guid.NewGuid(); //guid, rastgele bir değer oluşturur.
                string query = "Insert into Receipts(Date,Total,Payment,Remaining,ReceiptNumber) Values(@Date,@Total,@Payment,@Remaining,@ReceiptNumber)";

                //belirlenen parametrelere değerler atandı.
                SqlCommand command = new(query, connection, transaction);
                command.Parameters.AddWithValue("@Date", DateTime.Now);
                command.Parameters.AddWithValue("@Total", total);
                command.Parameters.AddWithValue("@Payment", total - remaining);
                command.Parameters.AddWithValue("@Remaining", remaining);
                command.Parameters.AddWithValue("@ReceiptNumber", receiptNumber);

                command.ExecuteNonQuery();


                //Fiş Numarasına (ReceiptNumbera) ait id'yi elde etmemiz gerekiyor
                SqlCommand getIdCommand = new($"Select Top 1 Id From Receipts Where ReceiptNumber = @receiptNumber", connection, transaction);

                getIdCommand.Parameters.AddWithValue("@receiptNumber", receiptNumber);

                SqlDataReader reader = getIdCommand.ExecuteReader();

                if (!reader.Read()) //kayıt tamamlanamadıysa
                {
                    reader.Close();
                    connection.Close();
                    return;
                }
                receiptId = (int)reader["Id"];
                reader.Close();

                //Details tablosuna kayıt atılıyor
                foreach (var item in receiptDetails)
                {
                    SqlCommand detailCommand = new($"Insert into ReceiptDetails Values(@ReceiptId,@ProductId,@Quantity,@Price,@Total)", connection, transaction);

                    detailCommand.Parameters.AddWithValue("@ReceiptId", receiptId);
                    detailCommand.Parameters.AddWithValue("@ProductId", item.ProductId);
                    detailCommand.Parameters.AddWithValue("@Quantity", item.Quantity);
                    detailCommand.Parameters.AddWithValue("@Price", item.Price);
                    detailCommand.Parameters.AddWithValue("@Total", item.Price);

                    detailCommand.ExecuteNonQuery();
                }

                //Payments tablosuna kayıt atılıyor
                foreach (var item in receiptPayments)
                {
                    SqlCommand paymentCommand = new($"Insert into ReceiptPayments Values(@receiptId,@Type,@Amount)", connection, transaction);
                    paymentCommand.Parameters.AddWithValue("@receiptId", receiptId);
                    paymentCommand.Parameters.AddWithValue("@Type", item.Type);
                    paymentCommand.Parameters.AddWithValue("@Amount", item.Amount);

                    paymentCommand.ExecuteNonQuery();
                }

                transaction.Commit(); //işlem başarılıysa gönderir

                Clear();

                MessageBox.Show("Alışveriş başarıyla tamamlandı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                //hata çıkarsa yapıan tüm işlemleri geri alır, 3 tabloya aynı anda kayıt için çalışır tek veya iki tabloya kayıdı önlüyor
                transaction.Rollback();
                MessageBox.Show($"Kayıt Esnasında Hata Çıktı.\n {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

        }

        private void receiptsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new();
            frm2.Show();
        }
    }

    public class ReceiptDetail
    {
        public int ReceiptId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
    }

    public class ReceiptPayment
    {
        public int ReceiptId { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }

    }
}