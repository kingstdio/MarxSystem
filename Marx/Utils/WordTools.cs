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
        /// <summary>
        /// 创建一个word简历
        /// </summary>
        /// <param name="pathTemplate">模板地址</param>
        /// <param name="pathCache">保存地址</param>
        /// <param name="dr">信息列表</param>
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
            object[] oBookMark = new object[35];
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
            oBookMark[15] = "civilstate";
            oBookMark[16] = "initDegree";
            oBookMark[17] = "initxuewei";
            oBookMark[18] = "inittime";
            oBookMark[19] = "initschool";
            oBookMark[20] = "enddegree";
            oBookMark[21] = "endxuewei";
            oBookMark[22] = "endtime";
            oBookMark[23] = "endschool";
            oBookMark[24] = "bodao";
            oBookMark[25] = "workspan";

            oBookMark[26] = "homeaddress";
            oBookMark[27] = "hukouaddress";
            oBookMark[28] = "xkml";
            oBookMark[29] = "yjfx";
            oBookMark[30] = "members";

            //赋值任意数据到书签的位置
            oDoc.Bookmarks.get_Item(ref oBookMark[0]).Range.Text = dr["name"].ToString(); 
            oDoc.Bookmarks.get_Item(ref oBookMark[1]).Range.Text = Convert.ToDateTime( dr["birthday"]).ToString("yyyy-MM-dd");
            oDoc.Bookmarks.get_Item(ref oBookMark[2]).Range.Text = dr["nation"].ToString();
            oDoc.Bookmarks.get_Item(ref oBookMark[3]).Range.Text = dr["gender"].ToString();
            oDoc.Bookmarks.get_Item(ref oBookMark[4]).Range.Text = dr["idcard"].ToString();
            oDoc.Bookmarks.get_Item(ref oBookMark[5]).Range.Text = dr["tid"].ToString();
            oDoc.InlineShapes.AddPicture(Application.StartupPath + @"\"+dr["photo"], ref oMissing, ref oMissing, oDoc.Bookmarks.get_Item(ref oBookMark[6]).Range);
            oDoc.Bookmarks.get_Item(ref oBookMark[7]).Range.Text = dr["phone"].ToString();
            oDoc.Bookmarks.get_Item(ref oBookMark[8]).Range.Text = dr["researchSection"].ToString();
            oDoc.Bookmarks.get_Item(ref oBookMark[9]).Range.Text = dr["duty"].ToString();
            oDoc.Bookmarks.get_Item(ref oBookMark[10]).Range.Text = dr["politicalStatus"].ToString();
            oDoc.Bookmarks.get_Item(ref oBookMark[11]).Range.Text = dr["title"].ToString();
            oDoc.Bookmarks.get_Item(ref oBookMark[12]).Range.Text = dr["email"].ToString();
            oDoc.Bookmarks.get_Item(ref oBookMark[13]).Range.Text = Convert.ToDateTime(dr["workStrartDate"]).ToString("yyyy-MM-dd");
            oDoc.Bookmarks.get_Item(ref oBookMark[14]).Range.Text = Convert.ToDateTime(dr["schoolStartDate"]).ToString("yyyy-MM-dd"); 

            oDoc.Bookmarks.get_Item(ref oBookMark[15]).Range.Text = dr["civilState"].ToString();
            oDoc.Bookmarks.get_Item(ref oBookMark[16]).Range.Text = dr["initEducation"].ToString();
            oDoc.Bookmarks.get_Item(ref oBookMark[17]).Range.Text = dr["initDegree"].ToString();
            oDoc.Bookmarks.get_Item(ref oBookMark[18]).Range.Text = Convert.ToDateTime(dr["intiDate"]).ToString("yyyy-MM-dd"); 
            oDoc.Bookmarks.get_Item(ref oBookMark[19]).Range.Text = dr["initSchool"].ToString();
            oDoc.Bookmarks.get_Item(ref oBookMark[20]).Range.Text = dr["lastEducation"].ToString();
            oDoc.Bookmarks.get_Item(ref oBookMark[21]).Range.Text = dr["lastDegree"].ToString();
            oDoc.Bookmarks.get_Item(ref oBookMark[22]).Range.Text = Convert.ToDateTime(dr["lastDate"]).ToString("yyyy-MM-dd");
            oDoc.Bookmarks.get_Item(ref oBookMark[23]).Range.Text = dr["lastSchool"].ToString();

            oDoc.Bookmarks.get_Item(ref oBookMark[24]).Range.Text = (bool)dr["tutorOfPhD"] ? "是" : "否";
            oDoc.Bookmarks.get_Item(ref oBookMark[25]).Range.Text = ((float)(DateTime.Now.Subtract(Convert.ToDateTime(dr["workStrartDate"]))).Days / 365).ToString("##.#");

            oDoc.Bookmarks.get_Item(ref oBookMark[26]).Range.Text = dr["homeAddress"].ToString();
            oDoc.Bookmarks.get_Item(ref oBookMark[27]).Range.Text = dr["residenceAddress"].ToString();
            oDoc.Bookmarks.get_Item(ref oBookMark[28]).Range.Text = dr["subject"].ToString();
            oDoc.Bookmarks.get_Item(ref oBookMark[29]).Range.Text = dr["rearchArea"].ToString();
            oDoc.Bookmarks.get_Item(ref oBookMark[30]).Range.Text = dr["familyMembers"].ToString();

            object filename = pathCache;

            oDoc.SaveAs(ref filename, ref oMissing, ref oMissing, ref oMissing,
            ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
            ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
            ref oMissing, ref oMissing);
            oDoc.Close(ref oMissing, ref oMissing, ref oMissing);
            //关闭word
            oWord.Quit(ref oMissing, ref oMissing, ref oMissing);
            MessageBox.Show("导出成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
