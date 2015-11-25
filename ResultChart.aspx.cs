using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.IO;
public partial class ResultChart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            for (int y = 1944; y <= 2013; y++)
                year.Items.Add(y.ToString());
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        try
        {
            if (name.Text.Length == 0)
            {
                message.Text = "Please provide the name to check";
                return;
            }

            string nvar = name.Text.ToLower();
            Session["name"] = nvar;
            string g = gender.SelectedValue.ToLower();
            int y = Convert.ToInt32(year.SelectedValue);


            string s = Server.MapPath("data");
            DirectoryInfo d = new DirectoryInfo(s);
            FileInfo[] fs = d.GetFiles();


            List<FileInfo> ar = new List<FileInfo>();
            foreach (FileInfo f in fs)
            {
                string fname = f.Name.ToLower();
                int yr = int.Parse(fname.Substring(fname.Length - 12, 4));

                if (yr >= y)
                {
                    if ((g == "male" || g == "female") && fname.StartsWith(g))
                        ar.Add(f);
                    else if (g == "both")
                        ar.Add(f);
                }
            }

            List<string> years = new List<string>();
            List<string> count = new List<string>();
            foreach (FileInfo ft in ar)
            {
                StreamReader sr = ft.OpenText();
                int line = 1;
                while (!sr.EndOfStream)
                {
                    string yr = ft.Name.Substring(ft.Name.Length - 12, 4);
                    

                    string str = sr.ReadLine();
                    string[] strar = str.Split(',');
                    if (line != 1)
                    {
                        string n = strar[0].Replace("\"", "");
                        string r = strar[1].Replace("\"", "");
                        string c = strar[2].Replace("\"", "").Replace("=","");
                        if (n.ToLower() == nvar.ToLower())
                        {
                            years.Add(yr);
                            count.Add(c);
                            Response.Write(yr + "," + n + "," + r + "," + c + "<br>");
                        }
                    }
                    line++;
                }
            }
            Session["years"] = years.ToArray<string>(); //new[] { "1950", "1951", "1952", "1953", "1954" };
            Session["data"] = count.ToArray<string>(); //new[] { "234", "900", "344", "540", "345" };
            Response.Redirect("ColumnChart.cshtml");
        }
        catch(Exception ex)
        {
            Response.Write("Error : "+ex.Message);
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            if (name.Text.Length == 0)
            {
                message.Text = "Please provide the name to check";
                return;
            }

            string nvar = name.Text.ToLower();
            Session["name"] = nvar;
            string g = gender.SelectedValue.ToLower();
            int y = Convert.ToInt32(year.SelectedValue);


            string s = Server.MapPath("data");
            DirectoryInfo d = new DirectoryInfo(s);
            FileInfo[] fs = d.GetFiles();


            List<FileInfo> ar = new List<FileInfo>();
            foreach (FileInfo f in fs)
            {
                string fname = f.Name.ToLower();
                int yr = int.Parse(fname.Substring(fname.Length - 12, 4));

                if (yr >= y)
                {
                    if ((g == "male" || g == "female") && fname.StartsWith(g))
                        ar.Add(f);
                    else if (g == "both")
                        ar.Add(f);
                }
            }

            List<string> years = new List<string>();
            List<string> count = new List<string>();
            foreach (FileInfo ft in ar)
            {
                StreamReader sr = ft.OpenText();
                int line = 1;
                while (!sr.EndOfStream)
                {
                    string yr = ft.Name.Substring(ft.Name.Length - 12, 4);


                    string str = sr.ReadLine();
                    string[] strar = str.Split(',');
                    if (line != 1)
                    {
                        string n = strar[0].Replace("\"", "");
                        string r = strar[1].Replace("\"", "");
                        string c = strar[2].Replace("\"", "").Replace("=", "");
                        if (n.ToLower() == nvar.ToLower())
                        {
                            years.Add(yr);
                            count.Add(c);
                            Response.Write(yr + "," + n + "," + r + "," + c + "<br>");
                        }
                    }
                    line++;
                }
            }
            Session["years"] = years.ToArray<string>(); //new[] { "1950", "1951", "1952", "1953", "1954" };
            Session["data"] = count.ToArray<string>(); //new[] { "234", "900", "344", "540", "345" };
            Response.Redirect("PieChart.cshtml");
        }
        catch (Exception ex)
        {
            Response.Write("Error : " + ex.Message);
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        List<NameInfo> lst = new List<NameInfo>();

        try
        {
            if (name.Text.Length == 0)
            {
                message.Text = "Please provide the name to check";
                return;
            }

            string nvar = name.Text.ToLower();
            Session["name"] = nvar;
            string g = gender.SelectedValue.ToLower();
            int y = Convert.ToInt32(year.SelectedValue);


            string s = Server.MapPath("data");
            DirectoryInfo d = new DirectoryInfo(s);
            FileInfo[] fs = d.GetFiles();


            List<FileInfo> ar = new List<FileInfo>();
            foreach (FileInfo f in fs)
            {
                string fname = f.Name.ToLower();
                int yr = int.Parse(fname.Substring(fname.Length - 12, 4));

                if (yr >= y)
                {
                    if ((g == "male" || g == "female") && fname.StartsWith(g))
                        ar.Add(f);
                    else if (g == "both")
                        ar.Add(f);
                }
            }

            List<string> years = new List<string>();
            List<string> count = new List<string>();
            foreach (FileInfo ft in ar)
            {
                StreamReader sr = ft.OpenText();
                int line = 1;
                while (!sr.EndOfStream)
                {
                    string yr = ft.Name.Substring(ft.Name.Length - 12, 4);


                    string str = sr.ReadLine();
                    string[] strar = str.Split(',');
                    if (line != 1)
                    {
                        string n = strar[0].Replace("\"", "");
                        string r = strar[1].Replace("\"", "");
                        string c = strar[2].Replace("\"", "").Replace("=", "");
                        if (n.ToLower() == nvar.ToLower())
                        {
                            years.Add(yr);
                            count.Add(c);
                            NameInfo x = new NameInfo();
                            x.Year = yr;
                            x.Amount = c;
                            lst.Add(x);
                            //Response.Write(yr + "," + n + "," + r + "," + c + "<br>");
                        }
                       
                    }
                    line++;
                }
            }
            Session["nameinfo"] = lst;
            Response.Redirect("ShowGrid.aspx");
        }
        catch (Exception ex)
        {
            Response.Write("Error : " + ex.Message);
        }
    }
}
