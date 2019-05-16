using System;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;

namespace OutilRessources
{
    public partial class DashboardForm : Form
    {
        System.Data.DataTable dtListeRes = new System.Data.DataTable();
        OpenFileDialog fdlg = new OpenFileDialog();
        string fname = "";

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void selectFile_Click(object sender, EventArgs e)
        {
            
            fdlg.Filter = "Excel Sheet(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                fname = fdlg.FileName;
            }

            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook xlWorkbook = xlApp.Workbooks.Open(fname);

            //First sheet -> to table RES_ListeRes
            Worksheet xlWorksheetListeRes = xlWorkbook.Sheets[1];
            Range xlRangeListeRes = xlWorksheetListeRes.UsedRange;

            int rowCount = xlRangeListeRes.Rows.Count;
            int colCount = xlRangeListeRes.Columns.Count;
            
            dtListeRes.Columns.AddRange(new DataColumn[9] {
                new DataColumn("intID_res", typeof(int)),
                new DataColumn("charType_res", typeof(string)),
                new DataColumn("charNom_res", typeof(string)),
                new DataColumn("intParent_res", typeof(int)),
                new DataColumn("charLstParents_res", typeof(string)),
                new DataColumn("intFils_res", typeof(int)),
                new DataColumn("intNiveau_res", typeof(int)),
                new DataColumn("intOrdre_res", typeof(int)),
                new DataColumn("intCommu_res", typeof(int))
            });

            for (int i = 2; i <= rowCount; i++)
            {
                int intId_res = Convert.ToInt32(xlRangeListeRes.Cells[i, 1].Value2.ToString());
                string chartype_res = xlRangeListeRes.Cells[i, 2].Value2.ToString();
                string charnom_res = xlRangeListeRes.Cells[i, 3].Value2.ToString();
                int intparent_res = Convert.ToInt32(xlRangeListeRes.Cells[i, 4].Value2.ToString());
                string charLstParents_res = xlRangeListeRes.Cells[i, 5].Value2.ToString();
                int intfils_res = Convert.ToInt32(xlRangeListeRes.Cells[i, 6].Value2.ToString());
                int intniveau_res = Convert.ToInt32(xlRangeListeRes.Cells[i, 7].Value2.ToString());
                int intordre_res = Convert.ToInt32(xlRangeListeRes.Cells[i, 8].Value2.ToString());
                int intcommu_res = Convert.ToInt32(xlRangeListeRes.Cells[i, 9].Value2.ToString());
                dtListeRes.Rows.Add(intId_res, chartype_res, charnom_res, intparent_res, charLstParents_res, intfils_res, intniveau_res, intordre_res, intcommu_res);

            }

            NameFile.Text = "Fichier séléctionné : " + fdlg.SafeFileName;

            for(int i = 1; i <= rowCount; i++)
            {
                
                for(int j = 1; j <= colCount; j++)
                {
                    if (xlRangeListeRes.Cells[i, j] != null && xlRangeListeRes.Cells[i, j].Value2 != null)
                    {
                        dataGridViewExcel.Rows[i].Cells[j].Value = xlRangeListeRes.Cells[i, j].Value2.ToString();
                    }
                        
                }
            }

            //cleanup  
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //release com objects to fully kill excel process from running in the background  
            Marshal.ReleaseComObject(xlRangeListeRes);
            Marshal.ReleaseComObject(xlWorksheetListeRes);

            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);
            
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);

        }

        private void downloadTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "ModeleRessources";
            savefile.Filter = "Excel Sheet(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                string sourcePath = System.Windows.Forms.Application.StartupPath;
                File.Copy(sourcePath + "\\ModeleRessources.xlsx", savefile.FileName);
            }
        }

        private void validImport_Click(object sender, EventArgs e)
        {
            if (dtListeRes.Rows.Count > 0)
            {
                string str = ConfigurationManager.ConnectionStrings["MaConnection"].ConnectionString;
                try
                {
                    using (SqlConnection con = new SqlConnection(str))
                    {
                        try
                        {
                            using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                            {
                                sqlBulkCopy.DestinationTableName = "dbo.RES_ListeRes";
                                sqlBulkCopy.ColumnMappings.Add("intID_res", "intID_res");
                                sqlBulkCopy.ColumnMappings.Add("charType_res", "charType_res");
                                sqlBulkCopy.ColumnMappings.Add("charNom_res", "charNom_res");
                                sqlBulkCopy.ColumnMappings.Add("intParent_res", "intParent_res");
                                sqlBulkCopy.ColumnMappings.Add("charLstParents_res", "charLstParents_res");
                                sqlBulkCopy.ColumnMappings.Add("intFils_res", "intFils_res");
                                sqlBulkCopy.ColumnMappings.Add("intNiveau_res", "intNiveau_res");
                                sqlBulkCopy.ColumnMappings.Add("intOrdre_res", "intOrdre_res");
                                sqlBulkCopy.ColumnMappings.Add("intCommu_res", "intCommu_res");
                                con.Open();
                                sqlBulkCopy.WriteToServer(dtListeRes);
                                con.Close();
                                MessageBox.Show("L'import a bien réussi :) ");
                                NameFile.Text = "";
                                fdlg = new OpenFileDialog();
                                fname = "";

                            }
                        }
                        catch(Exception exception)
                        {
                            MessageBox.Show("Erreur dans l'import : " + exception.Message);
                        }
                    }
                }
                catch (SqlException SQL)
                {
                    MessageBox.Show("Erreur dans la connexion SQL : " + SQL.Message);

                }
            }
        }
        
    }
}
