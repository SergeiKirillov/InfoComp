using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StatisticPC : System.Web.UI.Page
{
    SqlDataReader SqlDataSource1;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            BoundField bfield1 = new BoundField();
            bfield1.HeaderText = "Дата/Время";
            bfield1.DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}";
            bfield1.SortExpression = "datatimeComp";
            bfield1.DataField = "datatimeComp";
            bfield1.ItemStyle.HorizontalAlign = HorizontalAlign.Center;
            gvStatisticPCView.Columns.Add(bfield1);

            BoundField bfield2 = new BoundField();
            bfield2.HeaderText = "Имя компьютера";
            bfield2.DataFormatString = "{0:N1}";
            bfield2.SortExpression = "computer";
            bfield2.DataField = "computer";
            bfield2.ItemStyle.HorizontalAlign = HorizontalAlign.Center;
            gvStatisticPCView.Columns.Add(bfield2);

            BoundField bfield3 = new BoundField();
            bfield3.HeaderText = "Домен";
            bfield3.DataFormatString = "{0:N1}";
            bfield3.SortExpression = "Domain";
            bfield3.DataField = "Domain";
            bfield3.ItemStyle.HorizontalAlign = HorizontalAlign.Center;
            gvStatisticPCView.Columns.Add(bfield3);

            BoundField bfield4 = new BoundField();
            bfield4.HeaderText = "Аккаунт";
            bfield4.DataFormatString = "{0:N1}";
            bfield4.SortExpression = "userName";
            bfield4.DataField = "userName";
            bfield4.ItemStyle.HorizontalAlign = HorizontalAlign.Center;
            gvStatisticPCView.Columns.Add(bfield4);

            BoundField bfield5 = new BoundField();
            bfield5.HeaderText = "Серийный номер системного блока";
            bfield5.DataFormatString = "{0:N1}";
            bfield5.SortExpression = "serialNumber";
            bfield5.DataField = "serialNumber";
            bfield5.ItemStyle.HorizontalAlign = HorizontalAlign.Center;
            gvStatisticPCView.Columns.Add(bfield5);

            BoundField bfield6 = new BoundField();
            bfield6.HeaderText = "Модель системного блока";
            bfield6.DataFormatString = "{0:N1}";
            bfield6.SortExpression = "ModelNameComp";
            bfield6.DataField = "ModelNameComp";
            bfield6.ItemStyle.HorizontalAlign = HorizontalAlign.Center;
            gvStatisticPCView.Columns.Add(bfield6);

            BoundField bfield7 = new BoundField();
            bfield7.HeaderText = "Мониторы";
            bfield7.DataFormatString = "{0:N1}";
            bfield7.SortExpression = "MonitorName";
            bfield7.DataField = "MonitorName";
            bfield7.ItemStyle.HorizontalAlign = HorizontalAlign.Center;
            gvStatisticPCView.Columns.Add(bfield7);

            BoundField bfield8 = new BoundField();
            bfield8.HeaderText = "IP адресс";
            bfield8.DataFormatString = "{0:N1}";
            bfield8.SortExpression = "ipAdress";
            bfield8.DataField = "ipAdress";
            bfield8.ItemStyle.HorizontalAlign = HorizontalAlign.Center;
            gvStatisticPCView.Columns.Add(bfield8);

            BoundField bfield9 = new BoundField();
            bfield9.HeaderText = "Название ОС";
            bfield9.DataFormatString = "{0:N1}";
            bfield9.SortExpression = "OScaption";
            bfield9.DataField = "OScaption";
            bfield9.ItemStyle.HorizontalAlign = HorizontalAlign.Center;
            gvStatisticPCView.Columns.Add(bfield9);

            BoundField bfield10 = new BoundField();
            bfield10.HeaderText = "Version ОС";
            bfield10.DataFormatString = "{0:N1}";
            bfield10.SortExpression = "OSversion";
            bfield10.DataField = "OSversion";
            bfield10.ItemStyle.HorizontalAlign = HorizontalAlign.Center;
            gvStatisticPCView.Columns.Add(bfield10);

            BoundField bfield11 = new BoundField();
            bfield11.HeaderText = "Build OC";
            bfield11.DataFormatString = "{0:N1}";
            bfield11.SortExpression = "OSbuild";
            bfield11.DataField = "OSbuild";
            bfield11.ItemStyle.HorizontalAlign = HorizontalAlign.Center;
            gvStatisticPCView.Columns.Add(bfield11);

            BoundField bfield12 = new BoundField();
            bfield12.HeaderText = "Название ОС";
            bfield12.DataFormatString = "{0:N1}";
            bfield12.SortExpression = "OSdataInstall";
            bfield12.DataField = "OSdataInstall";
            bfield12.ItemStyle.HorizontalAlign = HorizontalAlign.Center;
            gvStatisticPCView.Columns.Add(bfield12);

            BoundField bfield13 = new BoundField();
            bfield13.HeaderText = "Update";
            bfield13.DataFormatString = "{0:N1}";
            bfield13.SortExpression = "OSupdate";
            bfield13.DataField = "OSupdate";
            bfield13.ItemStyle.HorizontalAlign = HorizontalAlign.Center;
            gvStatisticPCView.Columns.Add(bfield13);

            BoundField bfield14 = new BoundField();
            bfield14.HeaderText = "Коментарий";
            bfield14.DataFormatString = "{0:N1}";
            bfield14.SortExpression = "comment";
            bfield14.DataField = "comment";
            bfield14.ItemStyle.HorizontalAlign = HorizontalAlign.Center;
            gvStatisticPCView.Columns.Add(bfield14);


            //this.BindGrid();
            this.BindGridView();


        }
    }

    //private void BindGrid(string sortExp = null)
    //{

    //    SqlConnection conOCI = csSQLConnect.GetConnectionString(csSQLConnect.Database.AdminBD);
    //    conOCI.Open();
    //    SqlCommand comOCI = new SqlCommand();
    //    comOCI.Connection = conOCI;

    //    comOCI.CommandText = "Select [datatimeComp],[computer],[Domain],[userName],[serialNumber],[ModelNameComp],[MonitorName],[ipAdress],[PrintName],[PrintSN],[OScaption],[OSversion],[OSbuild],[OSdataInstall],[OSupdate],[comment] FROM [AdminBD].[dbo].[SerialNumberComp] where datatimeComp in (SELECT MAX(datatimeComp) FROM [AdminBD].[dbo].[SerialNumberComp]  group by computer) ORDER BY datatimeComp desc";


    //    SqlDataSource1 = comOCI.ExecuteReader();

    //    gvStatisticPCView.DataSource = SqlDataSource1;
    //    gvStatisticPCView.DataBind();

    //}

    private void BindGridView(string sortExp = null)
    {
        using (SqlConnection con = csSQLConnect.GetConnectionString(csSQLConnect.Database.AdminBD))
        {
            using (SqlCommand cmd = new SqlCommand("Select [datatimeComp],[computer],[Domain],[userName],[serialNumber],[ModelNameComp],[MonitorName],[ipAdress],[PrintName],[PrintSN],[OScaption],[OSversion],[OSbuild],[OSdataInstall],[OSupdate],[comment] FROM [AdminBD].[dbo].[SerialNumberComp] where datatimeComp in (SELECT MAX(datatimeComp) FROM [AdminBD].[dbo].[SerialNumberComp]  group by computer) ORDER BY datatimeComp desc"))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        if (sortExp != null)
                        {
                            DataView dv = dt.AsDataView();
                            this.SortDirection = this.SortDirection == "ASC" ? "DESC" : "ASC";

                            dv.Sort = sortExp + " " + this.SortDirection;

                            gvStatisticPCView.DataSource = dv;

                        }
                        else
                        {
                            gvStatisticPCView.DataSource = dt;
                        }
                        gvStatisticPCView.DataBind();
                    }
                }
            }
        }

    }

    private string SortDirection
    {
        get { return ViewState["SortDirection"] != null ? ViewState["SortDirection"].ToString() : "ASC"; }
        set { ViewState["SortDirection"] = value; }
    }

    protected void gvStatisticPCView_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //if (e.Row.RowType == DataControlRowType.DataRow)
        //{
        //    int val = (int)DataBinder.Eval(e.Row.DataItem, "VidPerevalki");

        //    if (val == 1) //плановая перевалка
        //    {
        //        e.Row.BackColor = System.Drawing.Color.Green;
        //        e.Row.ForeColor = System.Drawing.Color.White;
        //        e.Row.Cells[7].Text = "Плановая";
        //    }
        //    else if (val == 2) //внеплановая перевалка
        //    {
        //        e.Row.BackColor = System.Drawing.Color.IndianRed;
        //        e.Row.ForeColor = System.Drawing.Color.White;
        //        e.Row.Cells[7].Text = "Внеплановая";
        //    }
        //    else if (val == 4) //производственная необходимость
        //    {
        //        e.Row.BackColor = System.Drawing.Color.Yellow;
        //        e.Row.ForeColor = System.Drawing.Color.Black;
        //        e.Row.Cells[7].Text = "Производственная необходимость";
        //    }
        //    else
        //    {
        //        e.Row.BackColor = System.Drawing.Color.OrangeRed;
        //        e.Row.ForeColor = System.Drawing.Color.White;
        //        e.Row.Cells[7].Text = "Error ";
        //    }


        //}
    }

    protected void gvStatisticPCView_Sorting(object sender, GridViewSortEventArgs e)
    {
        this.BindGridView(e.SortExpression);
    }
}