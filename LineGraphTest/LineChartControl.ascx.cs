using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace LineGraphTest
{
    public partial class LineChartControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("My test Control");
            DrawChart();
        }

        public void DrawChart()
        {
            DataSet ds = new DataSet();

            foreach (DataTable dataTable in ds.Tables)
                dataTable.BeginLoadData();
            ds.ReadXml("C:\\Chitran\\PMI-Spice\\POC\\LineGraphTest\\LineGraphTest\\Barchart.xml");
            DataTable ChartData = ds.Tables[0];

            string[] XPointMember = new string[ChartData.Rows.Count];
            int[] YPointMember = new int[ChartData.Rows.Count];

            for (int count = 0; count < ChartData.Rows.Count; count++)
            {
                //storing Values for X axis   
                XPointMember[count] = ChartData.Rows[count]["Over"].ToString();
                //storing values for Y Axis   
                YPointMember[count] = Convert.ToInt32(ChartData.Rows[count]["Run"]);

            }

            //binding chart control   
            Graph.Series[0].Points.DataBindXY(XPointMember, YPointMember);

            //Setting width of line   
            Graph.Series[0].BorderWidth = 1;
            //setting Chart type    
            //LineChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType;
            Graph.Series[0].ChartType = System.Web.UI.DataVisualization.Charting.SeriesChartType.Line;
            // Chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;   
            // Chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;   
            //  Chart1.Series[0].ChartType = SeriesChartType.Spline;   
            //Chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;  
            Graph.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            Graph.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;


            DataSet ds1 = new DataSet();

            foreach (DataTable dataTable in ds1.Tables)
                dataTable.BeginLoadData();
            ds1.ReadXml("C:\\Chitran\\PMI-Spice\\POC\\LineGraphTest\\LineGraphTest\\Barchart1.xml");
            DataTable ChartData1 = ds1.Tables[0];

            string[] XPointMember1 = new string[ChartData1.Rows.Count];
            int[] YPointMember1 = new int[ChartData1.Rows.Count];

            for (int count = 0; count < ChartData1.Rows.Count; count++)
            {
                //storing Values for X axis   
                XPointMember[count] = ChartData1.Rows[count]["Over"].ToString();
                //storing values for Y Axis   
                YPointMember[count] = Convert.ToInt32(ChartData1.Rows[count]["Run"]);

            }

            //binding chart control   
            Graph.Series[1].Points.DataBindXY(XPointMember, YPointMember);
            Graph.Series[1].BorderWidth = 1;
            Graph.Series[1].ChartType = System.Web.UI.DataVisualization.Charting.SeriesChartType.Line;
            //Graph.Series[1].Color = Red; 
            Graph.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            Graph.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
        }
    }
}