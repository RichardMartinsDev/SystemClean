using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;
namespace DeletarArquivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnExibirArquivos_Click(object sender, EventArgs e)
        {
            string[] arquivos = Directory.GetFiles(@"c:\Windows\Temp", "*", SearchOption.TopDirectoryOnly);



            foreach (DirectoryInfo subDir in new DirectoryInfo(@"c:\Windows\Temp").GetDirectories())
                try
                {
                    subDir.Delete(true);
                    }

                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao deletar arquivo. " + ex.Message);

                    if (MessageBox.Show("Erro ao deletar arquivo. "
                        + ex.Message +
                        Environment.NewLine + Environment.NewLine +
                        "Pressione OK para ignorar.", "Erro encontrado",
                        MessageBoxButtons.OK, MessageBoxIcon.Question)
                            == DialogResult.No)


                        MessageBox.Show("Arquivos excluídos com Sucesso !");
                }

                foreach (string arquivo in arquivos)
            {
                //nome = Path.GetFileName(arquivo);
                //File.Delete(arquivo);

                try
                {
                    //deleta o arquivo e remove da lista
                    File.Delete(arquivo);
              
                    chklbArquivos.Items.Remove(arquivo);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao deletar arquivo. " + ex.Message);

                    if (MessageBox.Show("Erro ao deletar arquivo. "
                        + ex.Message +
                        Environment.NewLine + Environment.NewLine +
                        "Pressione OK para ignorar.", "Erro encontrado",
                        MessageBoxButtons.OK, MessageBoxIcon.Question)
                            == DialogResult.No)
                       
                    break;
                    MessageBox.Show("Arquivos excluídos com Sucesso !");



                }

            }

        }

        

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Encerrar ?", "Encerrar", MessageBoxButtons.YesNo)
                 == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void chklbArquivos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

 

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {

            //string strCmdText;
                
                //Abrir CMD
                //strCmdText = "/K drfgui";
                //System.Diagnostics.Process.Start("CMD.exe", strCmdText);
                System.Diagnostics.Process.Start("dfrgui", @"C:\Windows\System32\");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strCmdText;
            strCmdText = "/K chkdsk  ";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            {
                string[] arquivos = Directory.GetFiles(@"c:\temp\.", "*", SearchOption.TopDirectoryOnly);



                foreach (DirectoryInfo subDir in new DirectoryInfo(@"c:\temp\.").GetDirectories())
                    try
                    {
                        subDir.Delete(true);
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine("Erro ao deletar arquivo. " + ex.Message);

                        if (MessageBox.Show("Erro ao deletar arquivo. "
                            + ex.Message +
                            Environment.NewLine + Environment.NewLine +
                            "Pressione OK para ignorar.", "Erro encontrado",
                            MessageBoxButtons.OK, MessageBoxIcon.Question)
                                == DialogResult.No)


                            MessageBox.Show("Arquivos excluídos com Sucesso !");
                    }
                       Thread.Sleep(1000);
                      MessageBox.Show("Arquivos excluídos com Sucesso !");
                foreach (string arquivo in arquivos)
                {
                    //nome = Path.GetFileName(arquivo);
                    //File.Delete(arquivo);

                    try
                    {
                        //deleta o arquivo e remove da lista
                        File.Delete(arquivo);

                        chklbArquivos.Items.Remove(arquivo);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erro ao deletar arquivo. " + ex.Message);

                        if (MessageBox.Show("Erro ao deletar arquivo. "
                            + ex.Message +
                            Environment.NewLine + Environment.NewLine +
                            "Pressione OK para ignorar.", "Erro encontrado",
                            MessageBoxButtons.OK, MessageBoxIcon.Question)
                                == DialogResult.No)

                            break;
                        MessageBox.Show("Arquivos excluídos com Sucesso !");



                    }

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string strCmdText;

            //Abrir CMD
            strCmdText = "/c" + " del" +@" c:\Users\%username%\AppData\Local\Temp /s /q";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            Thread.Sleep(1000);
            MessageBox.Show("Arquivos excluídos com Sucesso !");


        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                string[] arquivos = Directory.GetFiles(@"c:\Windows\Prefetch\", "*", SearchOption.TopDirectoryOnly);



                foreach (DirectoryInfo subDir in new DirectoryInfo(@"c:\Windows\Prefetch\").GetDirectories())
                    try
                    {
                        subDir.Delete(true);
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine("Erro ao deletar arquivo. " + ex.Message);

                        if (MessageBox.Show("Erro ao deletar arquivo. "
                            + ex.Message +
                            Environment.NewLine + Environment.NewLine +
                            "Pressione OK para ignorar.", "Erro encontrado",
                            MessageBoxButtons.OK, MessageBoxIcon.Question)
                                == DialogResult.No)


                            MessageBox.Show("Arquivos excluídos com Sucesso !");
                    }

                foreach (string arquivo in arquivos)
                {
                    //nome = Path.GetFileName(arquivo);
                    //File.Delete(arquivo);

                    try
                    {
                        //deleta o arquivo e remove da lista
                        File.Delete(arquivo);

                        chklbArquivos.Items.Remove(arquivo);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erro ao deletar arquivo. " + ex.Message);

                        if (MessageBox.Show("Erro ao deletar arquivo. "
                            + ex.Message +
                            Environment.NewLine + Environment.NewLine +
                            "Pressione OK para ignorar.", "Erro encontrado",
                            MessageBoxButtons.OK, MessageBoxIcon.Question)
                                == DialogResult.No)

                            break;
                        MessageBox.Show("Arquivos excluídos com Sucesso !");



                    }

                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string strCmdText;

            //Abrir CMD
           strCmdText = "/c" + "ping";
           System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            Thread.Sleep(1000);
            MessageBox.Show("Internet otimizada com Sucesso !");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process pStart = new System.Diagnostics.Process();
            pStart.StartInfo = new System.Diagnostics.ProcessStartInfo(@"http://www.google.com/search?q=Teste+de+Internet&");
            pStart.Start();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versão v1.0.0 BETA" + System.Environment.NewLine + "Copyright ©  2021 - Richard Martins");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Encerrar ?", "Encerrar", MessageBoxButtons.YesNo)
                 == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }
    }
}
