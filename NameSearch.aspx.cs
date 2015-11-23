using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.IO;
public partial class NameSearch : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        for (int y = 1944; y <= 2013; y++)
            year.Items.Add(y.ToString());

        
    }

    protected void filternow_Click(object sender, EventArgs e)
    {
        string g = gender.SelectedValue.ToLower();
        int y = Convert.ToInt32(year.SelectedValue);
        int t = Convert.ToInt32(top.SelectedValue);

        if (g == "both") t = t / 2;

        string s = Server.MapPath("data");
        DirectoryInfo d = new DirectoryInfo(s);
        FileInfo[] fs = d.GetFiles();

        
        List<FileInfo> ar = new List<FileInfo>();
        foreach (FileInfo f in fs)
        {
            string fname = f.Name.ToLower();
            int yr = int.Parse(fname.Substring(fname.Length - 12, 4));

            if ((g == "male" || g == "female") && yr == y)
            {
                if (fname.StartsWith(g))
                    ar.Add(f);
            }
            else if (yr == y)
                ar.Add(f);
                
            
        }

        List<string> names = new List<string>();
        foreach (FileInfo ft in ar)
        {
            StreamReader sr = ft.OpenText();
            int i = 0;
            int line = 1;
            while (!sr.EndOfStream)
            {
                string str = sr.ReadLine();
                string[] strar = str.Split(',');
                if (line != 1)
                    names.Add(strar[0].Replace('\"', '\u0000'));
                if (t != 0)
                {
                    if (i < t)
                        i++;
                    else
                        break;
                }

                line++;
            }
        }

        GridView1.DataSource = names;
        GridView1.DataBind();
            
    }
}
