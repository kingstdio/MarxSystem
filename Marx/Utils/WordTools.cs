using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marx.Utils
{
    public class WordTools
    {
        public static void  Create(String pathTemplate, String pathCache, DataRow dr)
        {
            ////加载Word模板

            object oMissing = System.Reflection.Missing.Value;
            //创建一个Word应用程序实例
            Microsoft.Office.Interop.Word.Application oWord = new Microsoft.Office.Interop.Word.Application();
            //设置为不可见
            oWord.Visible = false;
            //模板文件地址，这里假设在X盘根目录
            object oTemplate = pathTemplate;
            //以模板为基础生成文档
            Microsoft.Office.Interop.Word.Document oDoc = oWord.Documents.Add(ref oTemplate, ref oMissing, ref oMissing, ref oMissing);
            //声明书签数组
            object[] oBookMark = new object[20];
            //赋值书签名
            oBookMark[0] = "name";
            oBookMark[1] = "birthday";
            oBookMark[2] = "nation";
            oBookMark[3] = "sex";
            oBookMark[4] = "idcard";
            oBookMark[5] = "workid";
            oBookMark[6] = "photo";
            oBookMark[7] = "phone";
            oBookMark[8] = "jys";
            oBookMark[9] = "zhiwu";
            oBookMark[10] = "zzmm";
            oBookMark[11] = "zhicheng";
            oBookMark[12] = "email";
            oBookMark[13] = "worktime";
            oBookMark[14] = "schooltime";


            //赋值任意数据到书签的位置
            oDoc.Bookmarks.get_Item(ref oBookMark[0]).Range.Text = dr["name"].ToString(); 
            oDoc.Bookmarks.get_Item(ref oBookMark[1]).Range.Text = dr["birthday"].ToString();
            oDoc.Bookmarks.get_Item(ref oBookMark[2]).Range.Text = dr["nation"].ToString();
            oDoc.Bookmarks.get_Item(ref oBookMark[3]).Range.Text = dr["gender"].ToString();
            oDoc.Bookmarks.get_Item(ref oBookMark[4]).Range.Text = dr["idcard"].ToString();
            oDoc.Bookmarks.get_Item(ref oBookMark[5]).Range.Text = dr["tid"].ToString();
            oDoc.InlineShapes.AddPicture(Application.StartupPath + @"\image\demo.jpg", ref oMissing, ref oMissing, oDoc.Bookmarks.get_Item(ref oBookMark[6]).Range);
            oDoc.Bookmarks.get_Item(ref oBookMark[7]).Range.Text = dr["phone"].ToString();
            oDoc.Bookmarks.get_Item(ref oBookMark[8]).Range.Text = dr["researchSection"].ToString();
            oDoc.Bookmarks.get_Item(ref oBookMark[9]).Range.Text = dr["duty"].ToString();
            oDoc.Bookmarks.get_Item(ref oBookMark[10]).Range.Text = dr["politicalStatus"].ToString();
            oDoc.Bookmarks.get_Item(ref oBookMark[11]).Range.Text = dr["title"].ToString();
            oDoc.Bookmarks.get_Item(ref oBookMark[12]).Range.Text = dr["email"].ToString();
            oDoc.Bookmarks.get_Item(ref oBookMark[13]).Range.Text = dr["workStrartDate"].ToString();
            oDoc.Bookmarks.get_Item(ref oBookMark[14]).Range.Text = dr["schoolStartDate"].ToString();



            object filename = pathCache +@"\"+ dr["idcard"].ToString() + ".docx";

            oDoc.SaveAs(ref filename, ref oMissing, ref oMissing, ref oMissing,
            ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
            ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
            ref oMissing, ref oMissing);
            oDoc.Close(ref oMissing, ref oMissing, ref oMissing);
            //关闭word
            oWord.Quit(ref oMissing, ref oMissing, ref oMissing);
        }
    }
}
