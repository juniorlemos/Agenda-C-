using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DBAgenda;Data Source=JUNIOR";
        private string strSql = string.Empty;
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CPF_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Criar_Click(object sender, EventArgs e)
        {

            strSql = "insert into dbo.tblAgenda (CPF, Nome, Sexo, Telefone) values(@CPF, @Nome, @Sexo, @Telefone)";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@CPF", SqlDbType.VarChar).Value = CpftextBox.Text;
            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = NometextBox.Text;
            comando.Parameters.Add("@Sexo", SqlDbType.Char).Value = SexotextBox.Text;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = TelefonetextBox.Text;
            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();

                listarGrid();
                NometextBox.Text = string.Empty;
                CpftextBox.Text = string.Empty;
                TelefonetextBox.Text = string.Empty;
                SexotextBox.Text = string.Empty;
            }
        }

        private void Deletar_Click(object sender, EventArgs e)
        {
            strSql = "delete from dbo.tblAgenda where CPF=@pesquisa";
            
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@pesquisa", SqlDbType.VarChar).Value = pesquisa.Text;
            if (MessageBox.Show("Deseja deletar este cadastro?", "AVISO !", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlCon.Close();
                    pesquisa.Text = string.Empty;
                    listarGrid();
                }

            }
           
            
        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
            strSql = "update dbo.tblAgenda set CPF=@CPF, Nome=@Nome, Sexo=@Sexo, Telefone=@telefone where CPF=@CPF ";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);



            comando.Parameters.Add("@CPF", SqlDbType.VarChar).Value = CpftextBox.Text;
            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = NometextBox.Text;
            comando.Parameters.Add("@Sexo", SqlDbType.Char).Value = SexotextBox.Text;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = TelefonetextBox.Text;

            if (MessageBox.Show("Deseja atualizar este cadastro?", "AVISO !", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlCon.Close();
                    CpftextBox.Text = string.Empty;
                    NometextBox.Text = string.Empty;
                    TelefonetextBox.Text = string.Empty;
                    SexotextBox.Text = string.Empty;
                    listarGrid();
                }
            }
        }

        private void CpftextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Selecionar_Click(object sender, EventArgs e)
        {
            strSql = "select * from dbo.tblAgenda  where CPF=@pesquisa ";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);



            comando.Parameters.Add("@pesquisa", SqlDbType.VarChar).Value = pesquisa.Text;


            
            try
            {
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();

                dr.Read();

                CpftextBox.Text = Convert.ToString(dr["CPF"]);
                NometextBox.Text = Convert.ToString(dr["Nome"]);
                SexotextBox.Text = Convert.ToString(dr["Sexo"]);
                TelefonetextBox.Text = Convert.ToString(dr["Telefone"]);
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
                pesquisa.Text = string.Empty;
               
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dBAgendaDataSet.tblAgenda'. Você pode movê-la ou removê-la conforme necessário.
            listarGrid();

        }

        public void listarGrid()
        {
         strSql = "select * from dbo.tblAgenda";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            try
            {
                SqlDataAdapter adp = new SqlDataAdapter(comando);

                DataTable lista = new DataTable();
                adp.Fill(lista);
                dg.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Pesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dg_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
