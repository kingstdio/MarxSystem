using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Marx
{
    public partial class F_main : DevComponents.DotNetBar.OfficeForm
    {
        private string js_xm = string.Empty;
        private string js_gzzh = string.Empty;
        private string js_sfzh = string.Empty;
        private string sql = string.Empty;

        private bool isInsert = true;

        private string idcard;
        private string gzzh;
        private string phone;
        private string name;
        private string gender;
        private string jiaoyanshi;
        private string nation;
        private string zhiwu;
        private string title;
        private DateTime birthday;
        private DateTime worktime;
        private DateTime schooltime;
        private string zzmm;
        private string email;
        private string hunyin;
        private string iniXueli;
        private string inidegree;
        private DateTime iniTime;
        private string iniSchool;
        private string endXueli;
        private string enddegree;
        private DateTime endTime;
        private string endSchool;
        private bool phdTutor;
        private string researchArea;
        private string subject;
        private string familyMember;
        private string homeAddress;
        private string hukouAddress;
        private string photoPath;

        private DataTable qdatatable;

        private string pathDocCache = Application.StartupPath + @"\cache\";
        private string pathDocTemplate = Application.StartupPath + @"\template\resume.dotx";




        private DevComponents.DotNetBar.SuperTabControl superTabControl1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.Controls.SwitchButton sw_t_phdTutor;
        private DateTimePicker dtp_t_endTime;
        private DateTimePicker dtp_t_initime;
        private DateTimePicker dtp_t_schoolTime;
        private DateTimePicker dtp_t_worktime;
        private DateTimePicker dtp_t_birthday;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_t_title;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_t_zhiwu;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_t_nation;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_t_gender;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_t_endSchool;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_t_hunyin;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_t_endDegree;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_t_inischool;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_t_endxueli;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_t_workLength;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_t_iniDegree;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_t_inixueli;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_t_email;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_t_zzmm;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_t_familyMember;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_t_researchArea;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_t_subject;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_t_hukouaddress;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_t_homeAddress;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_t_jiaoyanshi;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_t_idcard;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_t_phone;
        private DevComponents.DotNetBar.LabelX labelX24;
        private DevComponents.DotNetBar.LabelX labelX23;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_t_gzz;
        private DevComponents.DotNetBar.LabelX labelX22;
        private DevComponents.DotNetBar.LabelX labelX18;
        private DevComponents.DotNetBar.LabelX labelX21;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_t_xm;
        private DevComponents.DotNetBar.LabelX labelX32;
        private DevComponents.DotNetBar.LabelX labelX20;
        private DevComponents.DotNetBar.LabelX labelX31;
        private DevComponents.DotNetBar.LabelX labelX28;
        private DevComponents.DotNetBar.LabelX labelX27;
        private DevComponents.DotNetBar.LabelX labelX30;
        private DevComponents.DotNetBar.LabelX labelX17;
        private DevComponents.DotNetBar.LabelX labelX33;
        private DevComponents.DotNetBar.LabelX labelX26;
        private DevComponents.DotNetBar.LabelX labelX29;
        private DevComponents.DotNetBar.LabelX labelX19;
        private DevComponents.DotNetBar.LabelX labelX25;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.LabelX labelX16;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.LabelX labelX15;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DataGridView dgv_qresult;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX bt_jiansuo;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_sfzh;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_gzzh;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_xm;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtp_i_initime;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_i_inidegree;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_i_inixueli;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtp_i_endtime;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_i_endschool;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_i_inischool;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_i_enddegree;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_i_endxueli;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_i_hukouAddress;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_i_homeaddress;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_i_familymember;
        private DevComponents.DotNetBar.ButtonX bt_save;
        private DevComponents.DotNetBar.ButtonX bt_clear;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_i_title;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtp_i_schooltime;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_i_phone;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_i_jys;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem comboItem5;
        private DevComponents.Editors.ComboItem comboItem6;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_i_hunyin;
        private DevComponents.Editors.ComboItem comboItem7;
        private DevComponents.Editors.ComboItem comboItem8;
        private DevComponents.Editors.ComboItem comboItem9;
        private DevComponents.Editors.ComboItem comboItem10;
        private DevComponents.Editors.ComboItem comboItem11;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_i_email;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_i_zhiwu;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtp_i_worktime;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_i_gender;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_i_idcard;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_i_gzz;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtp_i_birthday;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_i_nation;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_i_zzmm;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_i_name;
        private DevComponents.DotNetBar.Controls.SwitchButton sw_i_phdtutor;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_i_subject;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_i_researchArea;
        private DevComponents.DotNetBar.LabelX labelX63;
        private DevComponents.DotNetBar.LabelX labelX62;
        private DevComponents.DotNetBar.LabelX labelX61;
        private DevComponents.DotNetBar.LabelX labelX60;
        private DevComponents.DotNetBar.LabelX labelX59;
        private DevComponents.DotNetBar.LabelX labelX58;
        private DevComponents.DotNetBar.LabelX labelX57;
        private DevComponents.DotNetBar.LabelX labelX56;
        private DevComponents.DotNetBar.LabelX labelX55;
        private DevComponents.DotNetBar.LabelX labelX54;
        private DevComponents.DotNetBar.LabelX labelX53;
        private DevComponents.DotNetBar.LabelX labelX52;
        private DevComponents.DotNetBar.LabelX labelX50;
        private DevComponents.DotNetBar.LabelX labelX51;
        private DevComponents.DotNetBar.LabelX labelX49;
        private DevComponents.DotNetBar.LabelX labelX48;
        private DevComponents.DotNetBar.LabelX labelX47;
        private DevComponents.DotNetBar.LabelX labelX45;
        private DevComponents.DotNetBar.LabelX labelX44;
        private DevComponents.DotNetBar.LabelX labelX46;
        private DevComponents.DotNetBar.LabelX labelX43;
        private DevComponents.DotNetBar.LabelX labelX64;
        private DevComponents.DotNetBar.LabelX labelX42;
        private DevComponents.DotNetBar.LabelX labelX40;
        private DevComponents.DotNetBar.LabelX labelX38;
        private DevComponents.DotNetBar.LabelX labelX34;
        private DevComponents.DotNetBar.LabelX labelX37;
        private DevComponents.DotNetBar.LabelX labelX35;
        private DevComponents.DotNetBar.LabelX labelX36;
        private DevComponents.DotNetBar.SuperTabItem superTabItem2;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.ComponentModel.IContainer components;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lb_totalNum;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.LabelX labelX39;
        private OpenFileDialog opf_picture;
        private PictureBox pb_person;
        private DevComponents.DotNetBar.LabelX labelX41;
        private ContextMenuStrip cms_dgvAction;
        private ToolStripMenuItem 删除ToolStripMenuItem;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel3;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.LabelX lb_zaizhi;
        private DevComponents.DotNetBar.SuperTabItem superTabItem3;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel4;
        private DevComponents.DotNetBar.LabelX lb_dangyuan;
        private Uri personuri = new Uri(Application.StartupPath + @"/template/personDetail.html");

        public F_main()
        {
            InitializeComponent();
            initUI();
            tb_xm.Focus();
        }

        #region 初始化界面数据
        private void initUI()
        {
            sql = @"select name from tb_jiaoyanshi";
            DataTable dataTable = SQLHELPER.ExecuteDataTable(sql);
            dataTable.Rows.InsertAt(dataTable.NewRow(), 0);
            cmb_i_jys.DataSource = dataTable;
            cmb_i_jys.DisplayMember = "name";
            pb_person.Load(@"./image/demo.jpg");
            sql = @"select count(id) from tb_basicInfo";
            int numCount = SQLHELPER.GetSingleResultInt(sql);
            lb_totalNum.Text = "人数合计：" + numCount;
            lb_zaizhi.Text = numCount.ToString();
            sql = @"select count(id) from tb_basicInfo where politicalStatus ='中共党员'";
            lb_dangyuan.Text = SQLHELPER.GetSingleResultString(sql);

            //初始化缓冲文件夹
            if (!Directory.Exists(pathDocCache))
            {
                Directory.CreateDirectory(pathDocCache);
            }

        }
        #endregion

        #region 检索按钮
        private void bt_jiansuo_Click(object sender, EventArgs e)
        {
            fillQueryDgv();
        }

        private void fillQueryDgv()
        {
            js_xm = tb_xm.Text.Trim();
            js_gzzh = tb_gzzh.Text.Trim();
            js_sfzh = tb_sfzh.Text.Trim();

            sql = @"select name as '姓名', gender as '性别', tid as '工作证号' ,idcard as '身份证号' from tb_basicInfo where name like '%" + js_xm + "%' and tid like '%" + js_gzzh + "%' and idcard like '%" + js_sfzh + "%'";

            qdatatable = SQLHELPER.ExecuteDataTable(sql);
            if (qdatatable.Rows.Count < 1)
            {
                MessageBox.Show("未查找到任何信息，请重新查询", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_xm.SelectAll();
                tb_xm.Focus();
                return;
            }
            dgv_qresult.DataSource = qdatatable;
            fillDetial(dgv_qresult.CurrentRow.Cells[3].Value.ToString());
        }

        #endregion

        #region 填充详细信息
        private void fillDetial(String idCard)
        {
            sql = @"SELECT id,tid,name,gender,nation,birthday,idcard,politicalStatus
                      ,email,phone,researchSection,duty,title,homeAddress,residenceAddress
                      ,workStrartDate,schoolStartDate,subject,rearchArea,civilState
                      ,familyMembers,tutorOfPhD,initDegree,initEducation,intiDate
                      ,initSchool,lastDegree,lastEducation,lastDate,lastSchool,photo
                  FROM tb_basicInfo where idcard='" + idCard + "'";
            DataRow dr = SQLHELPER.ExecuteDataRow(sql);



            //tb_t_xm.Text = dr["name"].ToString();
            //tb_t_gzz.Text = dr["tid"].ToString();
            //tb_t_phone.Text = dr["phone"].ToString();
            //tb_t_gender.Text = dr["gender"].ToString();
            //tb_t_idcard.Text = dr["idcard"].ToString();
            //tb_t_jiaoyanshi.Text = dr["researchSection"].ToString();
            //tb_t_nation.Text = dr["nation"].ToString();
            //dtp_t_birthday.Text = dr["birthday"].ToString();
            //dtp_t_worktime.Text = dr["workStrartDate"].ToString();
            //tb_t_zhiwu.Text = dr["duty"].ToString();
            //tb_t_title.Text = dr["title"].ToString();
            //tb_t_zzmm.Text = dr["politicalStatus"].ToString();
            //dtp_t_schoolTime.Text = dr["schoolStartDate"].ToString();
            //tb_t_email.Text = dr["email"].ToString();
            //tb_t_hunyin.Text = dr["civilState"].ToString();
            //tb_t_homeAddress.Text = dr["homeAddress"].ToString();
            //tb_t_hukouaddress.Text = dr["residenceAddress"].ToString();
            //tb_t_subject.Text = dr["subject"].ToString();
            //tb_t_researchArea.Text = dr["rearchArea"].ToString();
            //tb_t_familyMember.Text = dr["familyMembers"].ToString();
            //if (dr["tutorOfPhD"].ToString().Trim() != string.Empty)
            //{
            //    sw_t_phdTutor.Value = (bool)dr["tutorOfPhD"] ? true : false;
            //}
            //else
            //{
            //    sw_t_phdTutor.Value = false;
            //}
            //tb_t_workLength.Text = ((float)(DateTime.Now.Subtract(dtp_t_worktime.Value)).Days / 365).ToString("##.#");
            //tb_t_inixueli.Text = dr["initEducation"].ToString();
            //tb_t_iniDegree.Text = dr["initDegree"].ToString();
            //tb_t_inischool.Text = dr["initSchool"].ToString();
            //dtp_t_initime.Text = dr["intiDate"].ToString();
            //tb_t_endxueli.Text = dr["lastEducation"].ToString();
            //tb_t_endDegree.Text = dr["lastDegree"].ToString();
            //tb_t_endSchool.Text = dr["lastSchool"].ToString();
            //dtp_t_endTime.Text = dr["lastDate"].ToString();
            //string ppath = dr["photo"].ToString().Trim();
            //if (ppath != string.Empty)
            //{
            //    pb_person.Image = Image.FromFile((Application.StartupPath + @"\" + ppath));
            //}
            //else
            //{
            //    pb_person.Image = null;
            //}
            string cacc = DateTime.Now.ToBinary().ToString(); 
            Utils.WordTools.Create(pathDocTemplate, pathDocCache, dr);
            
            //this.axdoc_main.Open(pathDocCache + @"cache"+ cacc + ".docx",true,null,null,null);
        }
        #endregion

        #region 填充行号
        private void dgv_qresult_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

        }
        #endregion

        #region 单元格点击事件
        private void dgv_qresult_Click(object sender, EventArgs e)
        {
            if (dgv_qresult.Rows.Count > 0)
            {
                fillDetial(dgv_qresult.CurrentRow.Cells[3].Value.ToString());
            }
        }
        #endregion

        #region  设置第一个输入框焦点
        private void superTabItem2_Click(object sender, EventArgs e)
        {
            if (superTabItem2.Visible)
            {
                tb_i_idcard.Focus();
            }
        }
        #endregion

        #region 身份证验证触发事件
        private void tb_i_idcard_Leave(object sender, EventArgs e)
        {
            idcard = tb_i_idcard.Text.Trim();
            if (idcard != string.Empty)
            {
                if (valiIDcard(tb_i_idcard.Text))
                {
                    sql = @"SELECT id,tid,name,gender,nation,birthday,idcard,politicalStatus
                      ,email,phone,researchSection,duty,title,homeAddress,residenceAddress
                      ,workStrartDate,schoolStartDate,subject,rearchArea,civilState
                      ,familyMembers,tutorOfPhD,initDegree,initEducation,intiDate
                      ,initSchool,lastDegree,lastEducation,lastDate,lastSchool
                  FROM tb_basicInfo where idcard='" + idcard + "'";
                    DataRow dr = SQLHELPER.ExecuteDataRow(sql);
                    if (dr != null)
                    {
                        fillInput(dr);
                        isInsert = false;
                        bt_save.Text = "更新";
                    }
                    else
                    {
                        isInsert = true;
                        bt_save.Text = "保存";
                    }
                }
                else
                {
                    MessageBox.Show("身份证号码格式检查有误，请检查！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_i_idcard.SelectAll();
                    tb_i_idcard.Focus();
                    return;
                }
            }
        }
        #endregion

        #region 填充输入界面
        private void fillInput(DataRow dr)
        {
            tb_i_name.Text = dr["name"].ToString();
            tb_i_gzz.Text = dr["tid"].ToString();
            tb_i_phone.Text = dr["phone"].ToString();
            cmb_i_gender.Text = dr["gender"].ToString();
            cmb_i_jys.Text = dr["researchSection"].ToString();
            tb_i_nation.Text = dr["nation"].ToString();
            dtp_i_birthday.Text = dr["birthday"].ToString();
            dtp_i_worktime.Text = dr["workStrartDate"].ToString();
            tb_i_zhiwu.Text = dr["duty"].ToString();
            tb_i_title.Text = dr["title"].ToString();
            tb_i_zzmm.Text = dr["politicalStatus"].ToString();
            dtp_i_schooltime.Text = dr["schoolStartDate"].ToString();
            tb_i_email.Text = dr["email"].ToString();
            cmb_i_hunyin.Text = dr["civilState"].ToString();
            tb_i_homeaddress.Text = dr["homeAddress"].ToString();
            tb_i_hukouAddress.Text = dr["residenceAddress"].ToString();
            tb_i_subject.Text = dr["subject"].ToString();
            tb_i_researchArea.Text = dr["rearchArea"].ToString();
            tb_i_familymember.Text = dr["familyMembers"].ToString();

            if (dr["tutorOfPhD"].ToString().Trim() != string.Empty)
            {
                sw_i_phdtutor.Value = (bool)dr["tutorOfPhD"] ? true : false;
            }

            tb_i_inixueli.Text = dr["initEducation"].ToString();
            tb_i_inidegree.Text = dr["initDegree"].ToString();
            tb_i_inidegree.Text = dr["initSchool"].ToString();
            dtp_i_initime.Text = dr["intiDate"].ToString();
            tb_i_endxueli.Text = dr["lastEducation"].ToString();
            tb_i_enddegree.Text = dr["lastDegree"].ToString();
            tb_i_endschool.Text = dr["lastSchool"].ToString();
            dtp_i_endtime.Text = dr["lastDate"].ToString();
        }
        #endregion

        #region 验证身份证
        private bool valiIDcard(string idcardstr)
        {
            if ((!Regex.IsMatch(idcardstr, @"^(^\d{15}$|^\d{18}$|^\d{17}(\d|X|x))$", RegexOptions.IgnoreCase)))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        private void bt_save_Click(object sender, EventArgs e)
        {
            getText();

            if (idcard == string.Empty)
            {
                MessageBox.Show("请输入身份证号", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_i_idcard.Focus();
                return;
            }
            else
            {
                writeData();
                clearInput();
                tb_i_idcard.Focus();
            }
        }

        #region 向数据库写入内容
        private void writeData()
        {
            string strBirthday = birthday.ToString("yyyy-MM-dd");
            string strWrokday = worktime.ToString("yyyy-MM-dd");
            string strSchool = schooltime.ToString("yyyy-MM-dd");
            string strIni = iniTime.ToString("yyyy-MM-dd");
            string strEnd = endTime.ToString("yyyy-MM-dd");
            if (isInsert)
            {
                sql = @"INSERT INTO tb_basicInfo (tid,name,gender,nation,birthday,idcard,politicalStatus,email
                        ,phone ,researchSection,duty,title,homeAddress,residenceAddress,workStrartDate,schoolStartDate,subject
                        ,rearchArea,civilState,familyMembers,tutorOfPhD,initDegree,initEducation,intiDate,initSchool
                        ,lastDegree,lastEducation,lastDate,lastSchool,photo) VALUES
                        ('" + gzzh + "','" + name + "','" + gender + "','" + nation + "','" + (birthday.Year == 1 ? "" :strBirthday) + "','" + idcard + "','" + zzmm + "','" + email + "','" + phone + "','" + jiaoyanshi;
                sql += @"','" + zhiwu + "','" + title + "','" + homeAddress + "','" + hukouAddress + "','" + (worktime.Year == 1 ? "" : strWrokday) + "','" + (schooltime.Year == 1 ? "" : strSchool) + "','" + subject + "','" + researchArea;
                sql += @"','" + hunyin + "','" + familyMember + "'," + (phdTutor == true ? 1 : 0) + ",'" + inidegree + "','" + iniXueli + "','" + (iniTime.Year == 1 ? "" : strIni) + "','" + iniSchool + "','" + enddegree + "','" + endXueli + "','" + (endTime.Year == 1 ? "" : strEnd) + "','" + endSchool + "','"+photoPath+"')";

                if (SQLHELPER.ExecuteNoneQuery(sql) > 0)
                {
                    MessageBox.Show("添加成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                string aaa = birthday.ToString("yyyy-MM-dd");
                sql = @"UPDATE tb_basicInfo
                       SET tid = '" + gzzh + "' ,name = '" + name + "',gender = '" + gender + "',nation = '" + nation + "',birthday = '" + (birthday.Year == 1 ? "" : strBirthday);
                sql += "',politicalStatus = '" + zzmm + "',email = '" + email + "',phone = '" + phone + "',researchSection = '" + jiaoyanshi + "',duty = '" + zhiwu;
                sql += "',title = '" + title + "',homeAddress = '" + homeAddress + "' ,residenceAddress = '" + hukouAddress + "' ,workStrartDate = '" + (worktime.Year == 1 ? "" :strWrokday);
                sql += "',schoolStartDate = '" + (schooltime.Year == 1 ? "" : strSchool) + "',subject = '" + subject + "',rearchArea = '" + researchArea;
                sql += "',civilState = '" + hunyin + "',familyMembers = '" + familyMember + "',tutorOfPhD = " + (phdTutor == true ? 1 : 0) + ",initDegree = '" + inidegree + "',initEducation = '" + iniXueli;
                sql += "',intiDate = '" + (iniTime.Year == 1 ? "" : strIni) + "',initSchool = '" + iniSchool + "',lastDegree = '" + enddegree;
                sql += "',lastEducation = '" + endXueli + "',lastDate = '" + (endTime.Year == 1 ? "" : strEnd) + "',lastSchool = '" + endSchool + "', photo='"+photoPath+"' ";
                sql += " WHERE idcard='" + idcard + "'";

                if (SQLHELPER.ExecuteNoneQuery(sql) > 0)
                {
                    MessageBox.Show("更新成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion

        #region 获取输入内容
        private void getText()
        {
            idcard = tb_i_idcard.Text.Trim();
            gzzh = tb_i_gzz.Text.Trim();
            phone = tb_i_phone.Text.Trim();
            name = tb_i_name.Text.Trim();
            gender = cmb_i_gender.Text;
            jiaoyanshi = cmb_i_jys.Text.Trim();
            nation = tb_i_nation.Text.Trim();
            zhiwu = tb_i_zhiwu.Text.Trim();
            title = tb_i_title.Text.Trim();

            birthday = dtp_i_birthday.Value;

            worktime = dtp_i_worktime.Value;
            schooltime = dtp_i_schooltime.Value;
            zzmm = tb_i_zzmm.Text.Trim();
            email = tb_i_email.Text.Trim();
            hunyin = cmb_i_hunyin.Text.Trim();
            iniXueli = tb_i_inixueli.Text.Trim();
            inidegree = tb_i_inidegree.Text.Trim();
            iniTime = dtp_i_initime.Value;
            iniSchool = tb_i_inischool.Text.Trim();
            endXueli = tb_i_endxueli.Text.Trim();
            enddegree = tb_i_enddegree.Text.Trim();
            endTime = dtp_i_endtime.Value;
            endSchool = tb_i_endschool.Text.Trim();
            phdTutor = sw_i_phdtutor.Value;
            researchArea = tb_i_researchArea.Text.Trim();
            subject = tb_i_subject.Text.Trim();
            familyMember = tb_i_familymember.Text.Trim();
            homeAddress = tb_i_homeaddress.Text.Trim();
            hukouAddress = tb_i_hukouAddress.Text.Trim();

            if (pb_luru.Image != null)
            {
                string tempPhoto = photoPath;
                photoPath = @"image\photo\" + 
                    idcard + tempPhoto.Substring(tempPhoto.LastIndexOf("."), tempPhoto.Length- tempPhoto.LastIndexOf("."));
                pb_luru.Image.Save(photoPath);
            }
            
        }
        #endregion

        #region 清除界面内容
        private void bt_clear_Click(object sender, EventArgs e)
        {
            clearInput();
        }

        private void clearInput()
        {
            tb_i_idcard.Text = string.Empty;
            tb_i_name.Text = string.Empty;
            tb_i_gzz.Text = string.Empty;
            tb_i_phone.Text = string.Empty;
            cmb_i_gender.Text = string.Empty;
            cmb_i_jys.Text = string.Empty;
            tb_i_nation.Text = string.Empty;
            dtp_i_birthday.Text = string.Empty;
            dtp_i_worktime.Text = string.Empty;
            tb_i_zhiwu.Text = string.Empty;
            tb_i_title.Text = string.Empty;
            tb_i_zzmm.Text = string.Empty;
            dtp_i_schooltime.Text = string.Empty;
            tb_i_email.Text = string.Empty;
            cmb_i_hunyin.Text = string.Empty;
            tb_i_homeaddress.Text = string.Empty;
            tb_i_hukouAddress.Text = string.Empty;
            tb_i_subject.Text = string.Empty;
            tb_i_researchArea.Text = string.Empty;
            tb_i_familymember.Text = string.Empty;
            sw_i_phdtutor.Value = false;


            tb_i_inixueli.Text = string.Empty;
            tb_i_inidegree.Text = string.Empty;
            tb_i_inidegree.Text = string.Empty;
            dtp_i_initime.Text = string.Empty;
            tb_i_endxueli.Text = string.Empty;
            tb_i_enddegree.Text = string.Empty;
            tb_i_endschool.Text = string.Empty;
            dtp_i_endtime.Text = string.Empty;

            pb_luru.Image = null;

            tb_i_idcard.Focus();
        }

        #endregion



        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idcard = dgv_qresult.CurrentRow.Cells[3].Value.ToString();
            if (DialogResult.Yes == MessageBox.Show("确定要删除"+dgv_qresult.CurrentRow.Cells[0].Value.ToString()+"(身份证号：" + idcard + ")吗？", "系统提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                sql = @"delete from tb_basicInfo where idcard='" + idcard + "'";
                if (SQLHELPER.ExecuteNoneQuery(sql) > 0)
                {
                    clearInput();
                    MessageBox.Show("删除成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillQueryDgv();
                }
                else
                {
                    MessageBox.Show("删除失败请重试", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        #region 上传照片
        private void bt_upload_Click(object sender, EventArgs e)
        {
            opf_picture.ShowDialog();
            photoPath = opf_picture.FileName;
            if (photoPath.Trim() != string.Empty)
            {
                pb_luru.Image = Image.FromFile(photoPath);
            }
        }


        #endregion


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_main));
            this.superTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.pb_person = new System.Windows.Forms.PictureBox();
            this.sw_t_phdTutor = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgv_qresult = new System.Windows.Forms.DataGridView();
            this.cms_dgvAction = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtp_t_endTime = new System.Windows.Forms.DateTimePicker();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.bt_jiansuo = new DevComponents.DotNetBar.ButtonX();
            this.tb_sfzh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_gzzh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_xm = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dtp_t_initime = new System.Windows.Forms.DateTimePicker();
            this.dtp_t_schoolTime = new System.Windows.Forms.DateTimePicker();
            this.dtp_t_worktime = new System.Windows.Forms.DateTimePicker();
            this.dtp_t_birthday = new System.Windows.Forms.DateTimePicker();
            this.tb_t_title = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_t_zhiwu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_t_nation = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_t_gender = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_t_endSchool = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_t_hunyin = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_t_endDegree = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_t_inischool = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_t_endxueli = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_t_workLength = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_t_iniDegree = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_t_inixueli = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_t_email = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_t_zzmm = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_t_familyMember = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX33 = new DevComponents.DotNetBar.LabelX();
            this.tb_t_researchArea = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_t_subject = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_t_hukouaddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_t_homeAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_t_jiaoyanshi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_t_idcard = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_t_phone = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_t_xm = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_t_gzz = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.labelX25 = new DevComponents.DotNetBar.LabelX();
            this.labelX19 = new DevComponents.DotNetBar.LabelX();
            this.labelX29 = new DevComponents.DotNetBar.LabelX();
            this.labelX41 = new DevComponents.DotNetBar.LabelX();
            this.labelX26 = new DevComponents.DotNetBar.LabelX();
            this.labelX17 = new DevComponents.DotNetBar.LabelX();
            this.labelX30 = new DevComponents.DotNetBar.LabelX();
            this.labelX27 = new DevComponents.DotNetBar.LabelX();
            this.labelX28 = new DevComponents.DotNetBar.LabelX();
            this.labelX31 = new DevComponents.DotNetBar.LabelX();
            this.labelX20 = new DevComponents.DotNetBar.LabelX();
            this.labelX32 = new DevComponents.DotNetBar.LabelX();
            this.labelX24 = new DevComponents.DotNetBar.LabelX();
            this.labelX23 = new DevComponents.DotNetBar.LabelX();
            this.labelX21 = new DevComponents.DotNetBar.LabelX();
            this.labelX18 = new DevComponents.DotNetBar.LabelX();
            this.labelX22 = new DevComponents.DotNetBar.LabelX();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel4 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.superTabItem4 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.pb_luru = new System.Windows.Forms.PictureBox();
            this.dtp_i_initime = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.tb_i_inidegree = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_i_inixueli = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dtp_i_endtime = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.tb_i_endschool = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_i_inischool = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_i_enddegree = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_i_endxueli = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_i_hukouAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_i_homeaddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_i_familymember = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.bt_save = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.bt_clear = new DevComponents.DotNetBar.ButtonX();
            this.tb_i_title = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dtp_i_schooltime = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.tb_i_phone = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmb_i_jys = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.comboItem6 = new DevComponents.Editors.ComboItem();
            this.cmb_i_hunyin = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem7 = new DevComponents.Editors.ComboItem();
            this.comboItem8 = new DevComponents.Editors.ComboItem();
            this.comboItem9 = new DevComponents.Editors.ComboItem();
            this.comboItem10 = new DevComponents.Editors.ComboItem();
            this.comboItem11 = new DevComponents.Editors.ComboItem();
            this.tb_i_email = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_i_zhiwu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dtp_i_worktime = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cmb_i_gender = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.tb_i_idcard = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_i_gzz = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dtp_i_birthday = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.tb_i_nation = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_i_zzmm = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_i_name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.sw_i_phdtutor = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.tb_i_subject = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_i_researchArea = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX63 = new DevComponents.DotNetBar.LabelX();
            this.labelX62 = new DevComponents.DotNetBar.LabelX();
            this.labelX61 = new DevComponents.DotNetBar.LabelX();
            this.labelX60 = new DevComponents.DotNetBar.LabelX();
            this.labelX59 = new DevComponents.DotNetBar.LabelX();
            this.labelX58 = new DevComponents.DotNetBar.LabelX();
            this.labelX57 = new DevComponents.DotNetBar.LabelX();
            this.labelX56 = new DevComponents.DotNetBar.LabelX();
            this.labelX55 = new DevComponents.DotNetBar.LabelX();
            this.labelX54 = new DevComponents.DotNetBar.LabelX();
            this.labelX53 = new DevComponents.DotNetBar.LabelX();
            this.labelX52 = new DevComponents.DotNetBar.LabelX();
            this.labelX50 = new DevComponents.DotNetBar.LabelX();
            this.labelX51 = new DevComponents.DotNetBar.LabelX();
            this.labelX49 = new DevComponents.DotNetBar.LabelX();
            this.labelX48 = new DevComponents.DotNetBar.LabelX();
            this.labelX47 = new DevComponents.DotNetBar.LabelX();
            this.labelX45 = new DevComponents.DotNetBar.LabelX();
            this.labelX44 = new DevComponents.DotNetBar.LabelX();
            this.labelX46 = new DevComponents.DotNetBar.LabelX();
            this.labelX43 = new DevComponents.DotNetBar.LabelX();
            this.labelX64 = new DevComponents.DotNetBar.LabelX();
            this.labelX39 = new DevComponents.DotNetBar.LabelX();
            this.labelX42 = new DevComponents.DotNetBar.LabelX();
            this.labelX40 = new DevComponents.DotNetBar.LabelX();
            this.labelX38 = new DevComponents.DotNetBar.LabelX();
            this.labelX34 = new DevComponents.DotNetBar.LabelX();
            this.labelX37 = new DevComponents.DotNetBar.LabelX();
            this.labelX35 = new DevComponents.DotNetBar.LabelX();
            this.labelX36 = new DevComponents.DotNetBar.LabelX();
            this.superTabItem2 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel3 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.groupPanel4 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lb_dangyuan = new DevComponents.DotNetBar.LabelX();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lb_zaizhi = new DevComponents.DotNetBar.LabelX();
            this.superTabItem3 = new DevComponents.DotNetBar.SuperTabItem();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lb_totalNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.opf_picture = new System.Windows.Forms.OpenFileDialog();
            this.axdoc_main = new AxDSOFramer.AxFramerControl();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
            this.superTabControl1.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_person)).BeginInit();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qresult)).BeginInit();
            this.cms_dgvAction.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.superTabControlPanel4.SuspendLayout();
            this.superTabControlPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_luru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_i_initime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_i_endtime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_i_schooltime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_i_worktime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_i_birthday)).BeginInit();
            this.superTabControlPanel3.SuspendLayout();
            this.groupPanel4.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axdoc_main)).BeginInit();
            this.SuspendLayout();
            // 
            // superTabControl1
            // 
            this.superTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.superTabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl1.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl1.ControlBox.MenuBox.Name = "";
            this.superTabControl1.ControlBox.Name = "";
            this.superTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl1.ControlBox.MenuBox,
            this.superTabControl1.ControlBox.CloseBox});
            this.superTabControl1.Controls.Add(this.superTabControlPanel1);
            this.superTabControl1.Controls.Add(this.superTabControlPanel2);
            this.superTabControl1.Controls.Add(this.superTabControlPanel4);
            this.superTabControl1.Controls.Add(this.superTabControlPanel3);
            this.superTabControl1.ForeColor = System.Drawing.Color.Black;
            this.superTabControl1.Location = new System.Drawing.Point(1, 12);
            this.superTabControl1.Name = "superTabControl1";
            this.superTabControl1.ReorderTabsEnabled = true;
            this.superTabControl1.SelectedTabFont = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold);
            this.superTabControl1.SelectedTabIndex = 0;
            this.superTabControl1.Size = new System.Drawing.Size(1422, 744);
            this.superTabControl1.TabFont = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.superTabControl1.TabIndex = 1;
            this.superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem1,
            this.superTabItem2,
            this.superTabItem3,
            this.superTabItem4});
            this.superTabControl1.Text = "superTabControl1";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.pb_person);
            this.superTabControlPanel1.Controls.Add(this.sw_t_phdTutor);
            this.superTabControlPanel1.Controls.Add(this.groupPanel2);
            this.superTabControlPanel1.Controls.Add(this.dtp_t_endTime);
            this.superTabControlPanel1.Controls.Add(this.groupPanel1);
            this.superTabControlPanel1.Controls.Add(this.dtp_t_initime);
            this.superTabControlPanel1.Controls.Add(this.dtp_t_schoolTime);
            this.superTabControlPanel1.Controls.Add(this.dtp_t_worktime);
            this.superTabControlPanel1.Controls.Add(this.dtp_t_birthday);
            this.superTabControlPanel1.Controls.Add(this.tb_t_title);
            this.superTabControlPanel1.Controls.Add(this.tb_t_zhiwu);
            this.superTabControlPanel1.Controls.Add(this.tb_t_nation);
            this.superTabControlPanel1.Controls.Add(this.tb_t_gender);
            this.superTabControlPanel1.Controls.Add(this.tb_t_endSchool);
            this.superTabControlPanel1.Controls.Add(this.tb_t_hunyin);
            this.superTabControlPanel1.Controls.Add(this.tb_t_endDegree);
            this.superTabControlPanel1.Controls.Add(this.tb_t_inischool);
            this.superTabControlPanel1.Controls.Add(this.tb_t_endxueli);
            this.superTabControlPanel1.Controls.Add(this.tb_t_workLength);
            this.superTabControlPanel1.Controls.Add(this.tb_t_iniDegree);
            this.superTabControlPanel1.Controls.Add(this.tb_t_inixueli);
            this.superTabControlPanel1.Controls.Add(this.tb_t_email);
            this.superTabControlPanel1.Controls.Add(this.tb_t_zzmm);
            this.superTabControlPanel1.Controls.Add(this.tb_t_familyMember);
            this.superTabControlPanel1.Controls.Add(this.labelX33);
            this.superTabControlPanel1.Controls.Add(this.tb_t_researchArea);
            this.superTabControlPanel1.Controls.Add(this.tb_t_subject);
            this.superTabControlPanel1.Controls.Add(this.tb_t_hukouaddress);
            this.superTabControlPanel1.Controls.Add(this.tb_t_homeAddress);
            this.superTabControlPanel1.Controls.Add(this.tb_t_jiaoyanshi);
            this.superTabControlPanel1.Controls.Add(this.tb_t_idcard);
            this.superTabControlPanel1.Controls.Add(this.tb_t_phone);
            this.superTabControlPanel1.Controls.Add(this.tb_t_xm);
            this.superTabControlPanel1.Controls.Add(this.tb_t_gzz);
            this.superTabControlPanel1.Controls.Add(this.labelX4);
            this.superTabControlPanel1.Controls.Add(this.labelX5);
            this.superTabControlPanel1.Controls.Add(this.labelX6);
            this.superTabControlPanel1.Controls.Add(this.labelX10);
            this.superTabControlPanel1.Controls.Add(this.labelX11);
            this.superTabControlPanel1.Controls.Add(this.labelX7);
            this.superTabControlPanel1.Controls.Add(this.labelX8);
            this.superTabControlPanel1.Controls.Add(this.labelX14);
            this.superTabControlPanel1.Controls.Add(this.labelX9);
            this.superTabControlPanel1.Controls.Add(this.labelX15);
            this.superTabControlPanel1.Controls.Add(this.labelX12);
            this.superTabControlPanel1.Controls.Add(this.labelX16);
            this.superTabControlPanel1.Controls.Add(this.labelX13);
            this.superTabControlPanel1.Controls.Add(this.labelX25);
            this.superTabControlPanel1.Controls.Add(this.labelX19);
            this.superTabControlPanel1.Controls.Add(this.labelX29);
            this.superTabControlPanel1.Controls.Add(this.labelX41);
            this.superTabControlPanel1.Controls.Add(this.labelX26);
            this.superTabControlPanel1.Controls.Add(this.labelX17);
            this.superTabControlPanel1.Controls.Add(this.labelX30);
            this.superTabControlPanel1.Controls.Add(this.labelX27);
            this.superTabControlPanel1.Controls.Add(this.labelX28);
            this.superTabControlPanel1.Controls.Add(this.labelX31);
            this.superTabControlPanel1.Controls.Add(this.labelX20);
            this.superTabControlPanel1.Controls.Add(this.labelX32);
            this.superTabControlPanel1.Controls.Add(this.labelX24);
            this.superTabControlPanel1.Controls.Add(this.labelX23);
            this.superTabControlPanel1.Controls.Add(this.labelX21);
            this.superTabControlPanel1.Controls.Add(this.labelX18);
            this.superTabControlPanel1.Controls.Add(this.labelX22);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 26);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(1422, 718);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.superTabItem1;
            // 
            // pb_person
            // 
            this.pb_person.Location = new System.Drawing.Point(536, 428);
            this.pb_person.Name = "pb_person";
            this.pb_person.Size = new System.Drawing.Size(115, 153);
            this.pb_person.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_person.TabIndex = 35;
            this.pb_person.TabStop = false;
            // 
            // sw_t_phdTutor
            // 
            // 
            // 
            // 
            this.sw_t_phdTutor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.sw_t_phdTutor.Location = new System.Drawing.Point(536, 322);
            this.sw_t_phdTutor.Name = "sw_t_phdTutor";
            this.sw_t_phdTutor.OffText = "否";
            this.sw_t_phdTutor.OnText = "是";
            this.sw_t_phdTutor.Size = new System.Drawing.Size(138, 22);
            this.sw_t_phdTutor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.sw_t_phdTutor.SwitchWidth = 58;
            this.sw_t_phdTutor.TabIndex = 25;
            // 
            // groupPanel2
            // 
            this.groupPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupPanel2.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.dgv_qresult);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(11, 176);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(375, 528);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 2;
            this.groupPanel2.Text = "检索结果";
            // 
            // dgv_qresult
            // 
            this.dgv_qresult.AllowUserToAddRows = false;
            this.dgv_qresult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_qresult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_qresult.ContextMenuStrip = this.cms_dgvAction;
            this.dgv_qresult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_qresult.Location = new System.Drawing.Point(0, 0);
            this.dgv_qresult.Name = "dgv_qresult";
            this.dgv_qresult.ReadOnly = true;
            this.dgv_qresult.RowTemplate.Height = 23;
            this.dgv_qresult.Size = new System.Drawing.Size(369, 507);
            this.dgv_qresult.TabIndex = 0;
            this.dgv_qresult.TabStop = false;
            this.dgv_qresult.Click += new System.EventHandler(this.dgv_qresult_Click);
            // 
            // cms_dgvAction
            // 
            this.cms_dgvAction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.cms_dgvAction.Name = "cms_dgvAction";
            this.cms_dgvAction.Size = new System.Drawing.Size(143, 26);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // dtp_t_endTime
            // 
            this.dtp_t_endTime.Location = new System.Drawing.Point(881, 383);
            this.dtp_t_endTime.Name = "dtp_t_endTime";
            this.dtp_t_endTime.Size = new System.Drawing.Size(135, 20);
            this.dtp_t_endTime.TabIndex = 33;
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.bt_jiansuo);
            this.groupPanel1.Controls.Add(this.tb_sfzh);
            this.groupPanel1.Controls.Add(this.tb_gzzh);
            this.groupPanel1.Controls.Add(this.tb_xm);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(17, 24);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(369, 136);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 1;
            this.groupPanel1.Text = "输入检索条件";
            // 
            // bt_jiansuo
            // 
            this.bt_jiansuo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_jiansuo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_jiansuo.Location = new System.Drawing.Point(260, 16);
            this.bt_jiansuo.Name = "bt_jiansuo";
            this.bt_jiansuo.Size = new System.Drawing.Size(87, 83);
            this.bt_jiansuo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_jiansuo.TabIndex = 4;
            this.bt_jiansuo.Text = "检索";
            this.bt_jiansuo.Click += new System.EventHandler(this.bt_jiansuo_Click);
            // 
            // tb_sfzh
            // 
            this.tb_sfzh.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_sfzh.Border.Class = "TextBoxBorder";
            this.tb_sfzh.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_sfzh.DisabledBackColor = System.Drawing.Color.White;
            this.tb_sfzh.ForeColor = System.Drawing.Color.Black;
            this.tb_sfzh.Location = new System.Drawing.Point(76, 79);
            this.tb_sfzh.Name = "tb_sfzh";
            this.tb_sfzh.PreventEnterBeep = true;
            this.tb_sfzh.Size = new System.Drawing.Size(169, 20);
            this.tb_sfzh.TabIndex = 3;
            // 
            // tb_gzzh
            // 
            this.tb_gzzh.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_gzzh.Border.Class = "TextBoxBorder";
            this.tb_gzzh.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_gzzh.DisabledBackColor = System.Drawing.Color.White;
            this.tb_gzzh.ForeColor = System.Drawing.Color.Black;
            this.tb_gzzh.Location = new System.Drawing.Point(76, 48);
            this.tb_gzzh.Name = "tb_gzzh";
            this.tb_gzzh.PreventEnterBeep = true;
            this.tb_gzzh.Size = new System.Drawing.Size(169, 20);
            this.tb_gzzh.TabIndex = 2;
            // 
            // tb_xm
            // 
            this.tb_xm.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_xm.Border.Class = "TextBoxBorder";
            this.tb_xm.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_xm.DisabledBackColor = System.Drawing.Color.White;
            this.tb_xm.ForeColor = System.Drawing.Color.Black;
            this.tb_xm.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tb_xm.Location = new System.Drawing.Point(76, 17);
            this.tb_xm.Name = "tb_xm";
            this.tb_xm.PreventEnterBeep = true;
            this.tb_xm.Size = new System.Drawing.Size(169, 20);
            this.tb_xm.TabIndex = 1;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(11, 78);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "身份证号：";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(11, 47);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "工作证号：";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(11, 16);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "姓    名：";
            // 
            // dtp_t_initime
            // 
            this.dtp_t_initime.Location = new System.Drawing.Point(881, 355);
            this.dtp_t_initime.Name = "dtp_t_initime";
            this.dtp_t_initime.Size = new System.Drawing.Size(135, 20);
            this.dtp_t_initime.TabIndex = 29;
            // 
            // dtp_t_schoolTime
            // 
            this.dtp_t_schoolTime.Location = new System.Drawing.Point(1147, 122);
            this.dtp_t_schoolTime.Name = "dtp_t_schoolTime";
            this.dtp_t_schoolTime.Size = new System.Drawing.Size(250, 20);
            this.dtp_t_schoolTime.TabIndex = 16;
            // 
            // dtp_t_worktime
            // 
            this.dtp_t_worktime.Location = new System.Drawing.Point(1147, 93);
            this.dtp_t_worktime.Name = "dtp_t_worktime";
            this.dtp_t_worktime.Size = new System.Drawing.Size(250, 20);
            this.dtp_t_worktime.TabIndex = 13;
            // 
            // dtp_t_birthday
            // 
            this.dtp_t_birthday.Location = new System.Drawing.Point(789, 93);
            this.dtp_t_birthday.Name = "dtp_t_birthday";
            this.dtp_t_birthday.Size = new System.Drawing.Size(250, 20);
            this.dtp_t_birthday.TabIndex = 12;
            // 
            // tb_t_title
            // 
            this.tb_t_title.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_t_title.Border.Class = "TextBoxBorder";
            this.tb_t_title.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_t_title.DisabledBackColor = System.Drawing.Color.White;
            this.tb_t_title.ForeColor = System.Drawing.Color.Black;
            this.tb_t_title.Location = new System.Drawing.Point(536, 151);
            this.tb_t_title.Name = "tb_t_title";
            this.tb_t_title.PreventEnterBeep = true;
            this.tb_t_title.Size = new System.Drawing.Size(138, 20);
            this.tb_t_title.TabIndex = 17;
            // 
            // tb_t_zhiwu
            // 
            this.tb_t_zhiwu.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_t_zhiwu.Border.Class = "TextBoxBorder";
            this.tb_t_zhiwu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_t_zhiwu.DisabledBackColor = System.Drawing.Color.White;
            this.tb_t_zhiwu.ForeColor = System.Drawing.Color.Black;
            this.tb_t_zhiwu.Location = new System.Drawing.Point(536, 122);
            this.tb_t_zhiwu.Name = "tb_t_zhiwu";
            this.tb_t_zhiwu.PreventEnterBeep = true;
            this.tb_t_zhiwu.Size = new System.Drawing.Size(138, 20);
            this.tb_t_zhiwu.TabIndex = 14;
            // 
            // tb_t_nation
            // 
            this.tb_t_nation.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_t_nation.Border.Class = "TextBoxBorder";
            this.tb_t_nation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_t_nation.DisabledBackColor = System.Drawing.Color.White;
            this.tb_t_nation.ForeColor = System.Drawing.Color.Black;
            this.tb_t_nation.Location = new System.Drawing.Point(536, 93);
            this.tb_t_nation.Name = "tb_t_nation";
            this.tb_t_nation.PreventEnterBeep = true;
            this.tb_t_nation.Size = new System.Drawing.Size(138, 20);
            this.tb_t_nation.TabIndex = 11;
            // 
            // tb_t_gender
            // 
            this.tb_t_gender.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_t_gender.Border.Class = "TextBoxBorder";
            this.tb_t_gender.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_t_gender.DisabledBackColor = System.Drawing.Color.White;
            this.tb_t_gender.ForeColor = System.Drawing.Color.Black;
            this.tb_t_gender.Location = new System.Drawing.Point(536, 64);
            this.tb_t_gender.Name = "tb_t_gender";
            this.tb_t_gender.PreventEnterBeep = true;
            this.tb_t_gender.Size = new System.Drawing.Size(138, 20);
            this.tb_t_gender.TabIndex = 8;
            // 
            // tb_t_endSchool
            // 
            this.tb_t_endSchool.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_t_endSchool.Border.Class = "TextBoxBorder";
            this.tb_t_endSchool.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_t_endSchool.DisabledBackColor = System.Drawing.Color.White;
            this.tb_t_endSchool.ForeColor = System.Drawing.Color.Black;
            this.tb_t_endSchool.Location = new System.Drawing.Point(1103, 383);
            this.tb_t_endSchool.Name = "tb_t_endSchool";
            this.tb_t_endSchool.PreventEnterBeep = true;
            this.tb_t_endSchool.Size = new System.Drawing.Size(294, 20);
            this.tb_t_endSchool.TabIndex = 34;
            // 
            // tb_t_hunyin
            // 
            this.tb_t_hunyin.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_t_hunyin.Border.Class = "TextBoxBorder";
            this.tb_t_hunyin.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_t_hunyin.DisabledBackColor = System.Drawing.Color.White;
            this.tb_t_hunyin.ForeColor = System.Drawing.Color.Black;
            this.tb_t_hunyin.Location = new System.Drawing.Point(1147, 151);
            this.tb_t_hunyin.Name = "tb_t_hunyin";
            this.tb_t_hunyin.PreventEnterBeep = true;
            this.tb_t_hunyin.Size = new System.Drawing.Size(250, 20);
            this.tb_t_hunyin.TabIndex = 19;
            // 
            // tb_t_endDegree
            // 
            this.tb_t_endDegree.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_t_endDegree.Border.Class = "TextBoxBorder";
            this.tb_t_endDegree.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_t_endDegree.DisabledBackColor = System.Drawing.Color.White;
            this.tb_t_endDegree.ForeColor = System.Drawing.Color.Black;
            this.tb_t_endDegree.Location = new System.Drawing.Point(708, 383);
            this.tb_t_endDegree.Name = "tb_t_endDegree";
            this.tb_t_endDegree.PreventEnterBeep = true;
            this.tb_t_endDegree.Size = new System.Drawing.Size(93, 20);
            this.tb_t_endDegree.TabIndex = 32;
            // 
            // tb_t_inischool
            // 
            this.tb_t_inischool.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_t_inischool.Border.Class = "TextBoxBorder";
            this.tb_t_inischool.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_t_inischool.DisabledBackColor = System.Drawing.Color.White;
            this.tb_t_inischool.ForeColor = System.Drawing.Color.Black;
            this.tb_t_inischool.Location = new System.Drawing.Point(1103, 355);
            this.tb_t_inischool.Name = "tb_t_inischool";
            this.tb_t_inischool.PreventEnterBeep = true;
            this.tb_t_inischool.Size = new System.Drawing.Size(294, 20);
            this.tb_t_inischool.TabIndex = 30;
            // 
            // tb_t_endxueli
            // 
            this.tb_t_endxueli.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_t_endxueli.Border.Class = "TextBoxBorder";
            this.tb_t_endxueli.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_t_endxueli.DisabledBackColor = System.Drawing.Color.White;
            this.tb_t_endxueli.ForeColor = System.Drawing.Color.Black;
            this.tb_t_endxueli.Location = new System.Drawing.Point(536, 383);
            this.tb_t_endxueli.Name = "tb_t_endxueli";
            this.tb_t_endxueli.PreventEnterBeep = true;
            this.tb_t_endxueli.Size = new System.Drawing.Size(93, 20);
            this.tb_t_endxueli.TabIndex = 31;
            // 
            // tb_t_workLength
            // 
            this.tb_t_workLength.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_t_workLength.Border.Class = "TextBoxBorder";
            this.tb_t_workLength.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_t_workLength.DisabledBackColor = System.Drawing.Color.White;
            this.tb_t_workLength.ForeColor = System.Drawing.Color.Black;
            this.tb_t_workLength.Location = new System.Drawing.Point(769, 323);
            this.tb_t_workLength.Name = "tb_t_workLength";
            this.tb_t_workLength.PreventEnterBeep = true;
            this.tb_t_workLength.Size = new System.Drawing.Size(93, 20);
            this.tb_t_workLength.TabIndex = 26;
            // 
            // tb_t_iniDegree
            // 
            this.tb_t_iniDegree.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_t_iniDegree.Border.Class = "TextBoxBorder";
            this.tb_t_iniDegree.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_t_iniDegree.DisabledBackColor = System.Drawing.Color.White;
            this.tb_t_iniDegree.ForeColor = System.Drawing.Color.Black;
            this.tb_t_iniDegree.Location = new System.Drawing.Point(708, 355);
            this.tb_t_iniDegree.Name = "tb_t_iniDegree";
            this.tb_t_iniDegree.PreventEnterBeep = true;
            this.tb_t_iniDegree.Size = new System.Drawing.Size(93, 20);
            this.tb_t_iniDegree.TabIndex = 28;
            // 
            // tb_t_inixueli
            // 
            this.tb_t_inixueli.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_t_inixueli.Border.Class = "TextBoxBorder";
            this.tb_t_inixueli.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_t_inixueli.DisabledBackColor = System.Drawing.Color.White;
            this.tb_t_inixueli.ForeColor = System.Drawing.Color.Black;
            this.tb_t_inixueli.Location = new System.Drawing.Point(536, 355);
            this.tb_t_inixueli.Name = "tb_t_inixueli";
            this.tb_t_inixueli.PreventEnterBeep = true;
            this.tb_t_inixueli.Size = new System.Drawing.Size(93, 20);
            this.tb_t_inixueli.TabIndex = 27;
            // 
            // tb_t_email
            // 
            this.tb_t_email.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_t_email.Border.Class = "TextBoxBorder";
            this.tb_t_email.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_t_email.DisabledBackColor = System.Drawing.Color.White;
            this.tb_t_email.ForeColor = System.Drawing.Color.Black;
            this.tb_t_email.Location = new System.Drawing.Point(789, 151);
            this.tb_t_email.Name = "tb_t_email";
            this.tb_t_email.PreventEnterBeep = true;
            this.tb_t_email.Size = new System.Drawing.Size(250, 20);
            this.tb_t_email.TabIndex = 18;
            // 
            // tb_t_zzmm
            // 
            this.tb_t_zzmm.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_t_zzmm.Border.Class = "TextBoxBorder";
            this.tb_t_zzmm.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_t_zzmm.DisabledBackColor = System.Drawing.Color.White;
            this.tb_t_zzmm.ForeColor = System.Drawing.Color.Black;
            this.tb_t_zzmm.Location = new System.Drawing.Point(789, 122);
            this.tb_t_zzmm.Name = "tb_t_zzmm";
            this.tb_t_zzmm.PreventEnterBeep = true;
            this.tb_t_zzmm.Size = new System.Drawing.Size(250, 20);
            this.tb_t_zzmm.TabIndex = 15;
            // 
            // tb_t_familyMember
            // 
            this.tb_t_familyMember.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_t_familyMember.Border.Class = "TextBoxBorder";
            this.tb_t_familyMember.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_t_familyMember.DisabledBackColor = System.Drawing.Color.White;
            this.tb_t_familyMember.ForeColor = System.Drawing.Color.Black;
            this.tb_t_familyMember.Location = new System.Drawing.Point(536, 291);
            this.tb_t_familyMember.Name = "tb_t_familyMember";
            this.tb_t_familyMember.PreventEnterBeep = true;
            this.tb_t_familyMember.Size = new System.Drawing.Size(861, 20);
            this.tb_t_familyMember.TabIndex = 24;
            // 
            // labelX33
            // 
            // 
            // 
            // 
            this.labelX33.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX33.Location = new System.Drawing.Point(708, 322);
            this.labelX33.Name = "labelX33";
            this.labelX33.Size = new System.Drawing.Size(75, 23);
            this.labelX33.TabIndex = 3;
            this.labelX33.Text = "工作年限：";
            // 
            // tb_t_researchArea
            // 
            this.tb_t_researchArea.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_t_researchArea.Border.Class = "TextBoxBorder";
            this.tb_t_researchArea.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_t_researchArea.DisabledBackColor = System.Drawing.Color.White;
            this.tb_t_researchArea.ForeColor = System.Drawing.Color.Black;
            this.tb_t_researchArea.Location = new System.Drawing.Point(536, 264);
            this.tb_t_researchArea.Name = "tb_t_researchArea";
            this.tb_t_researchArea.PreventEnterBeep = true;
            this.tb_t_researchArea.Size = new System.Drawing.Size(861, 20);
            this.tb_t_researchArea.TabIndex = 23;
            // 
            // tb_t_subject
            // 
            this.tb_t_subject.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_t_subject.Border.Class = "TextBoxBorder";
            this.tb_t_subject.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_t_subject.DisabledBackColor = System.Drawing.Color.White;
            this.tb_t_subject.ForeColor = System.Drawing.Color.Black;
            this.tb_t_subject.Location = new System.Drawing.Point(536, 236);
            this.tb_t_subject.Name = "tb_t_subject";
            this.tb_t_subject.PreventEnterBeep = true;
            this.tb_t_subject.Size = new System.Drawing.Size(861, 20);
            this.tb_t_subject.TabIndex = 22;
            // 
            // tb_t_hukouaddress
            // 
            this.tb_t_hukouaddress.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_t_hukouaddress.Border.Class = "TextBoxBorder";
            this.tb_t_hukouaddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_t_hukouaddress.DisabledBackColor = System.Drawing.Color.White;
            this.tb_t_hukouaddress.ForeColor = System.Drawing.Color.Black;
            this.tb_t_hukouaddress.Location = new System.Drawing.Point(536, 208);
            this.tb_t_hukouaddress.Name = "tb_t_hukouaddress";
            this.tb_t_hukouaddress.PreventEnterBeep = true;
            this.tb_t_hukouaddress.Size = new System.Drawing.Size(861, 20);
            this.tb_t_hukouaddress.TabIndex = 21;
            // 
            // tb_t_homeAddress
            // 
            this.tb_t_homeAddress.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_t_homeAddress.Border.Class = "TextBoxBorder";
            this.tb_t_homeAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_t_homeAddress.DisabledBackColor = System.Drawing.Color.White;
            this.tb_t_homeAddress.ForeColor = System.Drawing.Color.Black;
            this.tb_t_homeAddress.Location = new System.Drawing.Point(536, 180);
            this.tb_t_homeAddress.Name = "tb_t_homeAddress";
            this.tb_t_homeAddress.PreventEnterBeep = true;
            this.tb_t_homeAddress.Size = new System.Drawing.Size(861, 20);
            this.tb_t_homeAddress.TabIndex = 20;
            // 
            // tb_t_jiaoyanshi
            // 
            this.tb_t_jiaoyanshi.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_t_jiaoyanshi.Border.Class = "TextBoxBorder";
            this.tb_t_jiaoyanshi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_t_jiaoyanshi.DisabledBackColor = System.Drawing.Color.White;
            this.tb_t_jiaoyanshi.ForeColor = System.Drawing.Color.Black;
            this.tb_t_jiaoyanshi.Location = new System.Drawing.Point(1147, 64);
            this.tb_t_jiaoyanshi.Name = "tb_t_jiaoyanshi";
            this.tb_t_jiaoyanshi.PreventEnterBeep = true;
            this.tb_t_jiaoyanshi.Size = new System.Drawing.Size(250, 20);
            this.tb_t_jiaoyanshi.TabIndex = 10;
            // 
            // tb_t_idcard
            // 
            this.tb_t_idcard.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_t_idcard.Border.Class = "TextBoxBorder";
            this.tb_t_idcard.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_t_idcard.DisabledBackColor = System.Drawing.Color.White;
            this.tb_t_idcard.ForeColor = System.Drawing.Color.Black;
            this.tb_t_idcard.Location = new System.Drawing.Point(789, 64);
            this.tb_t_idcard.Name = "tb_t_idcard";
            this.tb_t_idcard.PreventEnterBeep = true;
            this.tb_t_idcard.Size = new System.Drawing.Size(250, 20);
            this.tb_t_idcard.TabIndex = 9;
            // 
            // tb_t_phone
            // 
            this.tb_t_phone.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_t_phone.Border.Class = "TextBoxBorder";
            this.tb_t_phone.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_t_phone.DisabledBackColor = System.Drawing.Color.White;
            this.tb_t_phone.ForeColor = System.Drawing.Color.Black;
            this.tb_t_phone.Location = new System.Drawing.Point(1147, 35);
            this.tb_t_phone.Name = "tb_t_phone";
            this.tb_t_phone.PreventEnterBeep = true;
            this.tb_t_phone.Size = new System.Drawing.Size(250, 20);
            this.tb_t_phone.TabIndex = 7;
            // 
            // tb_t_xm
            // 
            this.tb_t_xm.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_t_xm.Border.Class = "TextBoxBorder";
            this.tb_t_xm.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_t_xm.DisabledBackColor = System.Drawing.Color.White;
            this.tb_t_xm.ForeColor = System.Drawing.Color.Black;
            this.tb_t_xm.Location = new System.Drawing.Point(536, 35);
            this.tb_t_xm.Name = "tb_t_xm";
            this.tb_t_xm.PreventEnterBeep = true;
            this.tb_t_xm.Size = new System.Drawing.Size(138, 20);
            this.tb_t_xm.TabIndex = 5;
            // 
            // tb_t_gzz
            // 
            this.tb_t_gzz.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_t_gzz.Border.Class = "TextBoxBorder";
            this.tb_t_gzz.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_t_gzz.DisabledBackColor = System.Drawing.Color.White;
            this.tb_t_gzz.ForeColor = System.Drawing.Color.Black;
            this.tb_t_gzz.Location = new System.Drawing.Point(789, 35);
            this.tb_t_gzz.Name = "tb_t_gzz";
            this.tb_t_gzz.PreventEnterBeep = true;
            this.tb_t_gzz.Size = new System.Drawing.Size(250, 20);
            this.tb_t_gzz.TabIndex = 6;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(495, 34);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "姓名：";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(495, 63);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 1;
            this.labelX5.Text = "性别：";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(495, 92);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 2;
            this.labelX6.Text = "民族：";
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(495, 121);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(75, 23);
            this.labelX10.TabIndex = 2;
            this.labelX10.Text = "职务：";
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(495, 150);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(75, 23);
            this.labelX11.TabIndex = 2;
            this.labelX11.Text = "职称：";
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(726, 34);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(75, 23);
            this.labelX7.TabIndex = 3;
            this.labelX7.Text = "工作证号：";
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(726, 63);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(75, 23);
            this.labelX8.TabIndex = 3;
            this.labelX8.Text = "身份证号：";
            // 
            // labelX14
            // 
            this.labelX14.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.Location = new System.Drawing.Point(1084, 34);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(75, 23);
            this.labelX14.TabIndex = 3;
            this.labelX14.Text = "联系电话：";
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(726, 92);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(75, 23);
            this.labelX9.TabIndex = 3;
            this.labelX9.Text = "出生时间：";
            // 
            // labelX15
            // 
            this.labelX15.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX15.Location = new System.Drawing.Point(1084, 63);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(75, 23);
            this.labelX15.TabIndex = 3;
            this.labelX15.Text = "教 研 室：";
            // 
            // labelX12
            // 
            this.labelX12.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Location = new System.Drawing.Point(726, 121);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(75, 23);
            this.labelX12.TabIndex = 3;
            this.labelX12.Text = "政治面貌：";
            // 
            // labelX16
            // 
            this.labelX16.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX16.Location = new System.Drawing.Point(1084, 92);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(75, 23);
            this.labelX16.TabIndex = 3;
            this.labelX16.Text = "工作时间：";
            // 
            // labelX13
            // 
            this.labelX13.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Location = new System.Drawing.Point(726, 150);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(75, 23);
            this.labelX13.TabIndex = 3;
            this.labelX13.Text = "电子信箱：";
            // 
            // labelX25
            // 
            this.labelX25.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX25.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX25.Location = new System.Drawing.Point(469, 354);
            this.labelX25.Name = "labelX25";
            this.labelX25.Size = new System.Drawing.Size(75, 23);
            this.labelX25.TabIndex = 3;
            this.labelX25.Text = "初始学历：";
            // 
            // labelX19
            // 
            this.labelX19.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX19.Location = new System.Drawing.Point(473, 179);
            this.labelX19.Name = "labelX19";
            this.labelX19.Size = new System.Drawing.Size(75, 23);
            this.labelX19.TabIndex = 3;
            this.labelX19.Text = "家庭住址：";
            // 
            // labelX29
            // 
            this.labelX29.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX29.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX29.Location = new System.Drawing.Point(469, 382);
            this.labelX29.Name = "labelX29";
            this.labelX29.Size = new System.Drawing.Size(75, 23);
            this.labelX29.TabIndex = 3;
            this.labelX29.Text = "最后学历：";
            // 
            // labelX41
            // 
            this.labelX41.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX41.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX41.Location = new System.Drawing.Point(455, 484);
            this.labelX41.Name = "labelX41";
            this.labelX41.Size = new System.Drawing.Size(75, 23);
            this.labelX41.TabIndex = 3;
            this.labelX41.Text = "个人照片：";
            // 
            // labelX26
            // 
            this.labelX26.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX26.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX26.Location = new System.Drawing.Point(647, 354);
            this.labelX26.Name = "labelX26";
            this.labelX26.Size = new System.Drawing.Size(75, 23);
            this.labelX26.TabIndex = 3;
            this.labelX26.Text = "初始学位：";
            // 
            // labelX17
            // 
            this.labelX17.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX17.Location = new System.Drawing.Point(1084, 121);
            this.labelX17.Name = "labelX17";
            this.labelX17.Size = new System.Drawing.Size(75, 23);
            this.labelX17.TabIndex = 3;
            this.labelX17.Text = "来校时间：";
            // 
            // labelX30
            // 
            this.labelX30.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX30.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX30.Location = new System.Drawing.Point(647, 382);
            this.labelX30.Name = "labelX30";
            this.labelX30.Size = new System.Drawing.Size(75, 23);
            this.labelX30.TabIndex = 3;
            this.labelX30.Text = "最后学位：";
            // 
            // labelX27
            // 
            this.labelX27.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX27.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX27.Location = new System.Drawing.Point(817, 354);
            this.labelX27.Name = "labelX27";
            this.labelX27.Size = new System.Drawing.Size(75, 23);
            this.labelX27.TabIndex = 3;
            this.labelX27.Text = "毕业时间：";
            // 
            // labelX28
            // 
            this.labelX28.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX28.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX28.Location = new System.Drawing.Point(1036, 354);
            this.labelX28.Name = "labelX28";
            this.labelX28.Size = new System.Drawing.Size(75, 23);
            this.labelX28.TabIndex = 3;
            this.labelX28.Text = "毕业学校：";
            // 
            // labelX31
            // 
            this.labelX31.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX31.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX31.Location = new System.Drawing.Point(817, 382);
            this.labelX31.Name = "labelX31";
            this.labelX31.Size = new System.Drawing.Size(75, 23);
            this.labelX31.TabIndex = 3;
            this.labelX31.Text = "毕业时间：";
            // 
            // labelX20
            // 
            this.labelX20.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX20.Location = new System.Drawing.Point(473, 207);
            this.labelX20.Name = "labelX20";
            this.labelX20.Size = new System.Drawing.Size(75, 23);
            this.labelX20.TabIndex = 3;
            this.labelX20.Text = "户口地址：";
            // 
            // labelX32
            // 
            this.labelX32.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX32.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX32.Location = new System.Drawing.Point(1036, 382);
            this.labelX32.Name = "labelX32";
            this.labelX32.Size = new System.Drawing.Size(75, 23);
            this.labelX32.TabIndex = 3;
            this.labelX32.Text = "毕业学校：";
            // 
            // labelX24
            // 
            this.labelX24.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX24.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX24.Location = new System.Drawing.Point(457, 322);
            this.labelX24.Name = "labelX24";
            this.labelX24.Size = new System.Drawing.Size(88, 23);
            this.labelX24.TabIndex = 3;
            this.labelX24.Text = "是否为博导：";
            // 
            // labelX23
            // 
            this.labelX23.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX23.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX23.Location = new System.Drawing.Point(446, 290);
            this.labelX23.Name = "labelX23";
            this.labelX23.Size = new System.Drawing.Size(95, 23);
            this.labelX23.TabIndex = 3;
            this.labelX23.Text = "家庭主要成员：";
            // 
            // labelX21
            // 
            this.labelX21.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX21.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX21.Location = new System.Drawing.Point(412, 235);
            this.labelX21.Name = "labelX21";
            this.labelX21.Size = new System.Drawing.Size(136, 23);
            this.labelX21.TabIndex = 3;
            this.labelX21.Text = "现主要从事学科门类：";
            // 
            // labelX18
            // 
            this.labelX18.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX18.Location = new System.Drawing.Point(1084, 150);
            this.labelX18.Name = "labelX18";
            this.labelX18.Size = new System.Drawing.Size(75, 23);
            this.labelX18.TabIndex = 3;
            this.labelX18.Text = "婚姻状况：";
            // 
            // labelX22
            // 
            this.labelX22.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX22.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX22.Location = new System.Drawing.Point(434, 263);
            this.labelX22.Name = "labelX22";
            this.labelX22.Size = new System.Drawing.Size(136, 23);
            this.labelX22.TabIndex = 3;
            this.labelX22.Text = "教学和研究方向：";
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.superTabControlPanel1;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "信息检索";
            // 
            // superTabControlPanel4
            // 
            this.superTabControlPanel4.Controls.Add(this.axdoc_main);
            this.superTabControlPanel4.Controls.Add(this.button1);
            this.superTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel4.Location = new System.Drawing.Point(0, 26);
            this.superTabControlPanel4.Name = "superTabControlPanel4";
            this.superTabControlPanel4.Size = new System.Drawing.Size(1422, 718);
            this.superTabControlPanel4.TabIndex = 0;
            this.superTabControlPanel4.TabItem = this.superTabItem4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // superTabItem4
            // 
            this.superTabItem4.AttachedControl = this.superTabControlPanel4;
            this.superTabItem4.GlobalItem = false;
            this.superTabItem4.Name = "superTabItem4";
            this.superTabItem4.Text = "superTabItem4";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Controls.Add(this.pb_luru);
            this.superTabControlPanel2.Controls.Add(this.dtp_i_initime);
            this.superTabControlPanel2.Controls.Add(this.tb_i_inidegree);
            this.superTabControlPanel2.Controls.Add(this.tb_i_inixueli);
            this.superTabControlPanel2.Controls.Add(this.dtp_i_endtime);
            this.superTabControlPanel2.Controls.Add(this.tb_i_endschool);
            this.superTabControlPanel2.Controls.Add(this.tb_i_inischool);
            this.superTabControlPanel2.Controls.Add(this.tb_i_enddegree);
            this.superTabControlPanel2.Controls.Add(this.tb_i_endxueli);
            this.superTabControlPanel2.Controls.Add(this.tb_i_hukouAddress);
            this.superTabControlPanel2.Controls.Add(this.tb_i_homeaddress);
            this.superTabControlPanel2.Controls.Add(this.tb_i_familymember);
            this.superTabControlPanel2.Controls.Add(this.bt_save);
            this.superTabControlPanel2.Controls.Add(this.buttonX1);
            this.superTabControlPanel2.Controls.Add(this.bt_clear);
            this.superTabControlPanel2.Controls.Add(this.tb_i_title);
            this.superTabControlPanel2.Controls.Add(this.dtp_i_schooltime);
            this.superTabControlPanel2.Controls.Add(this.tb_i_phone);
            this.superTabControlPanel2.Controls.Add(this.cmb_i_jys);
            this.superTabControlPanel2.Controls.Add(this.cmb_i_hunyin);
            this.superTabControlPanel2.Controls.Add(this.tb_i_email);
            this.superTabControlPanel2.Controls.Add(this.tb_i_zhiwu);
            this.superTabControlPanel2.Controls.Add(this.dtp_i_worktime);
            this.superTabControlPanel2.Controls.Add(this.cmb_i_gender);
            this.superTabControlPanel2.Controls.Add(this.tb_i_idcard);
            this.superTabControlPanel2.Controls.Add(this.tb_i_gzz);
            this.superTabControlPanel2.Controls.Add(this.dtp_i_birthday);
            this.superTabControlPanel2.Controls.Add(this.tb_i_nation);
            this.superTabControlPanel2.Controls.Add(this.tb_i_zzmm);
            this.superTabControlPanel2.Controls.Add(this.tb_i_name);
            this.superTabControlPanel2.Controls.Add(this.sw_i_phdtutor);
            this.superTabControlPanel2.Controls.Add(this.tb_i_subject);
            this.superTabControlPanel2.Controls.Add(this.tb_i_researchArea);
            this.superTabControlPanel2.Controls.Add(this.labelX63);
            this.superTabControlPanel2.Controls.Add(this.labelX62);
            this.superTabControlPanel2.Controls.Add(this.labelX61);
            this.superTabControlPanel2.Controls.Add(this.labelX60);
            this.superTabControlPanel2.Controls.Add(this.labelX59);
            this.superTabControlPanel2.Controls.Add(this.labelX58);
            this.superTabControlPanel2.Controls.Add(this.labelX57);
            this.superTabControlPanel2.Controls.Add(this.labelX56);
            this.superTabControlPanel2.Controls.Add(this.labelX55);
            this.superTabControlPanel2.Controls.Add(this.labelX54);
            this.superTabControlPanel2.Controls.Add(this.labelX53);
            this.superTabControlPanel2.Controls.Add(this.labelX52);
            this.superTabControlPanel2.Controls.Add(this.labelX50);
            this.superTabControlPanel2.Controls.Add(this.labelX51);
            this.superTabControlPanel2.Controls.Add(this.labelX49);
            this.superTabControlPanel2.Controls.Add(this.labelX48);
            this.superTabControlPanel2.Controls.Add(this.labelX47);
            this.superTabControlPanel2.Controls.Add(this.labelX45);
            this.superTabControlPanel2.Controls.Add(this.labelX44);
            this.superTabControlPanel2.Controls.Add(this.labelX46);
            this.superTabControlPanel2.Controls.Add(this.labelX43);
            this.superTabControlPanel2.Controls.Add(this.labelX64);
            this.superTabControlPanel2.Controls.Add(this.labelX39);
            this.superTabControlPanel2.Controls.Add(this.labelX42);
            this.superTabControlPanel2.Controls.Add(this.labelX40);
            this.superTabControlPanel2.Controls.Add(this.labelX38);
            this.superTabControlPanel2.Controls.Add(this.labelX34);
            this.superTabControlPanel2.Controls.Add(this.labelX37);
            this.superTabControlPanel2.Controls.Add(this.labelX35);
            this.superTabControlPanel2.Controls.Add(this.labelX36);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 26);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(1422, 718);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.superTabItem2;
            // 
            // pb_luru
            // 
            this.pb_luru.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_luru.Location = new System.Drawing.Point(216, 511);
            this.pb_luru.Name = "pb_luru";
            this.pb_luru.Size = new System.Drawing.Size(115, 153);
            this.pb_luru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_luru.TabIndex = 38;
            this.pb_luru.TabStop = false;
            // 
            // dtp_i_initime
            // 
            // 
            // 
            // 
            this.dtp_i_initime.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtp_i_initime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtp_i_initime.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtp_i_initime.ButtonDropDown.Visible = true;
            this.dtp_i_initime.CustomFormat = "yyyy-MM-dd";
            this.dtp_i_initime.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtp_i_initime.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtp_i_initime.IsPopupCalendarOpen = false;
            this.dtp_i_initime.Location = new System.Drawing.Point(602, 245);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtp_i_initime.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtp_i_initime.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtp_i_initime.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtp_i_initime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtp_i_initime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtp_i_initime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtp_i_initime.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtp_i_initime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtp_i_initime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtp_i_initime.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtp_i_initime.MonthCalendar.DisplayMonth = new System.DateTime(2017, 10, 1, 0, 0, 0, 0);
            this.dtp_i_initime.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtp_i_initime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtp_i_initime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtp_i_initime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtp_i_initime.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtp_i_initime.MonthCalendar.TodayButtonVisible = true;
            this.dtp_i_initime.Name = "dtp_i_initime";
            this.dtp_i_initime.Size = new System.Drawing.Size(161, 26);
            this.dtp_i_initime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtp_i_initime.TabIndex = 18;
            // 
            // tb_i_inidegree
            // 
            this.tb_i_inidegree.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_i_inidegree.Border.Class = "TextBoxBorder";
            this.tb_i_inidegree.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_i_inidegree.DisabledBackColor = System.Drawing.Color.White;
            this.tb_i_inidegree.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_i_inidegree.ForeColor = System.Drawing.Color.Black;
            this.tb_i_inidegree.Location = new System.Drawing.Point(407, 245);
            this.tb_i_inidegree.MaxLength = 32;
            this.tb_i_inidegree.Name = "tb_i_inidegree";
            this.tb_i_inidegree.PreventEnterBeep = true;
            this.tb_i_inidegree.Size = new System.Drawing.Size(93, 26);
            this.tb_i_inidegree.TabIndex = 17;
            // 
            // tb_i_inixueli
            // 
            this.tb_i_inixueli.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_i_inixueli.Border.Class = "TextBoxBorder";
            this.tb_i_inixueli.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_i_inixueli.DisabledBackColor = System.Drawing.Color.White;
            this.tb_i_inixueli.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_i_inixueli.ForeColor = System.Drawing.Color.Black;
            this.tb_i_inixueli.Location = new System.Drawing.Point(216, 245);
            this.tb_i_inixueli.MaxLength = 32;
            this.tb_i_inixueli.Name = "tb_i_inixueli";
            this.tb_i_inixueli.PreventEnterBeep = true;
            this.tb_i_inixueli.Size = new System.Drawing.Size(93, 26);
            this.tb_i_inixueli.TabIndex = 16;
            // 
            // dtp_i_endtime
            // 
            // 
            // 
            // 
            this.dtp_i_endtime.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtp_i_endtime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtp_i_endtime.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtp_i_endtime.ButtonDropDown.Visible = true;
            this.dtp_i_endtime.CustomFormat = "yyyy-MM-dd";
            this.dtp_i_endtime.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtp_i_endtime.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtp_i_endtime.IsPopupCalendarOpen = false;
            this.dtp_i_endtime.Location = new System.Drawing.Point(602, 289);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtp_i_endtime.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtp_i_endtime.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtp_i_endtime.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtp_i_endtime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtp_i_endtime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtp_i_endtime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtp_i_endtime.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtp_i_endtime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtp_i_endtime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtp_i_endtime.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtp_i_endtime.MonthCalendar.DisplayMonth = new System.DateTime(2017, 10, 1, 0, 0, 0, 0);
            this.dtp_i_endtime.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtp_i_endtime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtp_i_endtime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtp_i_endtime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtp_i_endtime.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtp_i_endtime.MonthCalendar.TodayButtonVisible = true;
            this.dtp_i_endtime.Name = "dtp_i_endtime";
            this.dtp_i_endtime.Size = new System.Drawing.Size(161, 26);
            this.dtp_i_endtime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtp_i_endtime.TabIndex = 22;
            // 
            // tb_i_endschool
            // 
            this.tb_i_endschool.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_i_endschool.Border.Class = "TextBoxBorder";
            this.tb_i_endschool.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_i_endschool.DisabledBackColor = System.Drawing.Color.White;
            this.tb_i_endschool.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_i_endschool.ForeColor = System.Drawing.Color.Black;
            this.tb_i_endschool.Location = new System.Drawing.Point(874, 289);
            this.tb_i_endschool.MaxLength = 50;
            this.tb_i_endschool.Name = "tb_i_endschool";
            this.tb_i_endschool.PreventEnterBeep = true;
            this.tb_i_endschool.Size = new System.Drawing.Size(364, 26);
            this.tb_i_endschool.TabIndex = 23;
            // 
            // tb_i_inischool
            // 
            this.tb_i_inischool.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_i_inischool.Border.Class = "TextBoxBorder";
            this.tb_i_inischool.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_i_inischool.DisabledBackColor = System.Drawing.Color.White;
            this.tb_i_inischool.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_i_inischool.ForeColor = System.Drawing.Color.Black;
            this.tb_i_inischool.Location = new System.Drawing.Point(874, 245);
            this.tb_i_inischool.MaxLength = 50;
            this.tb_i_inischool.Name = "tb_i_inischool";
            this.tb_i_inischool.PreventEnterBeep = true;
            this.tb_i_inischool.Size = new System.Drawing.Size(364, 26);
            this.tb_i_inischool.TabIndex = 19;
            // 
            // tb_i_enddegree
            // 
            this.tb_i_enddegree.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_i_enddegree.Border.Class = "TextBoxBorder";
            this.tb_i_enddegree.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_i_enddegree.DisabledBackColor = System.Drawing.Color.White;
            this.tb_i_enddegree.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_i_enddegree.ForeColor = System.Drawing.Color.Black;
            this.tb_i_enddegree.Location = new System.Drawing.Point(407, 289);
            this.tb_i_enddegree.MaxLength = 32;
            this.tb_i_enddegree.Name = "tb_i_enddegree";
            this.tb_i_enddegree.PreventEnterBeep = true;
            this.tb_i_enddegree.Size = new System.Drawing.Size(93, 26);
            this.tb_i_enddegree.TabIndex = 21;
            // 
            // tb_i_endxueli
            // 
            this.tb_i_endxueli.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_i_endxueli.Border.Class = "TextBoxBorder";
            this.tb_i_endxueli.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_i_endxueli.DisabledBackColor = System.Drawing.Color.White;
            this.tb_i_endxueli.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_i_endxueli.ForeColor = System.Drawing.Color.Black;
            this.tb_i_endxueli.Location = new System.Drawing.Point(216, 289);
            this.tb_i_endxueli.MaxLength = 32;
            this.tb_i_endxueli.Name = "tb_i_endxueli";
            this.tb_i_endxueli.PreventEnterBeep = true;
            this.tb_i_endxueli.Size = new System.Drawing.Size(93, 26);
            this.tb_i_endxueli.TabIndex = 20;
            // 
            // tb_i_hukouAddress
            // 
            this.tb_i_hukouAddress.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_i_hukouAddress.Border.Class = "TextBoxBorder";
            this.tb_i_hukouAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_i_hukouAddress.DisabledBackColor = System.Drawing.Color.White;
            this.tb_i_hukouAddress.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_i_hukouAddress.ForeColor = System.Drawing.Color.Black;
            this.tb_i_hukouAddress.Location = new System.Drawing.Point(215, 465);
            this.tb_i_hukouAddress.MaxLength = 128;
            this.tb_i_hukouAddress.Name = "tb_i_hukouAddress";
            this.tb_i_hukouAddress.PreventEnterBeep = true;
            this.tb_i_hukouAddress.Size = new System.Drawing.Size(1022, 26);
            this.tb_i_hukouAddress.TabIndex = 29;
            // 
            // tb_i_homeaddress
            // 
            this.tb_i_homeaddress.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_i_homeaddress.Border.Class = "TextBoxBorder";
            this.tb_i_homeaddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_i_homeaddress.DisabledBackColor = System.Drawing.Color.White;
            this.tb_i_homeaddress.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_i_homeaddress.ForeColor = System.Drawing.Color.Black;
            this.tb_i_homeaddress.Location = new System.Drawing.Point(216, 423);
            this.tb_i_homeaddress.MaxLength = 128;
            this.tb_i_homeaddress.Name = "tb_i_homeaddress";
            this.tb_i_homeaddress.PreventEnterBeep = true;
            this.tb_i_homeaddress.Size = new System.Drawing.Size(1022, 26);
            this.tb_i_homeaddress.TabIndex = 28;
            // 
            // tb_i_familymember
            // 
            this.tb_i_familymember.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_i_familymember.Border.Class = "TextBoxBorder";
            this.tb_i_familymember.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_i_familymember.DisabledBackColor = System.Drawing.Color.White;
            this.tb_i_familymember.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_i_familymember.ForeColor = System.Drawing.Color.Black;
            this.tb_i_familymember.Location = new System.Drawing.Point(216, 377);
            this.tb_i_familymember.MaxLength = 128;
            this.tb_i_familymember.Name = "tb_i_familymember";
            this.tb_i_familymember.PreventEnterBeep = true;
            this.tb_i_familymember.Size = new System.Drawing.Size(1022, 26);
            this.tb_i_familymember.TabIndex = 27;
            // 
            // bt_save
            // 
            this.bt_save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_save.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_save.Location = new System.Drawing.Point(417, 567);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(359, 58);
            this.bt_save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_save.TabIndex = 30;
            this.bt_save.Text = "保存";
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonX1.Location = new System.Drawing.Point(215, 670);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(116, 26);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 31;
            this.buttonX1.Text = "上传照片";
            this.buttonX1.Click += new System.EventHandler(this.bt_upload_Click);
            // 
            // bt_clear
            // 
            this.bt_clear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_clear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_clear.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_clear.Location = new System.Drawing.Point(853, 567);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(359, 58);
            this.bt_clear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_clear.TabIndex = 31;
            this.bt_clear.Text = "清空";
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // tb_i_title
            // 
            this.tb_i_title.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_i_title.Border.Class = "TextBoxBorder";
            this.tb_i_title.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_i_title.DisabledBackColor = System.Drawing.Color.White;
            this.tb_i_title.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_i_title.ForeColor = System.Drawing.Color.Black;
            this.tb_i_title.Location = new System.Drawing.Point(988, 113);
            this.tb_i_title.MaxLength = 10;
            this.tb_i_title.Name = "tb_i_title";
            this.tb_i_title.PreventEnterBeep = true;
            this.tb_i_title.Size = new System.Drawing.Size(250, 26);
            this.tb_i_title.TabIndex = 9;
            // 
            // dtp_i_schooltime
            // 
            // 
            // 
            // 
            this.dtp_i_schooltime.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtp_i_schooltime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtp_i_schooltime.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtp_i_schooltime.ButtonDropDown.Visible = true;
            this.dtp_i_schooltime.CustomFormat = "yyyy-MM-dd";
            this.dtp_i_schooltime.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtp_i_schooltime.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtp_i_schooltime.IsPopupCalendarOpen = false;
            this.dtp_i_schooltime.Location = new System.Drawing.Point(988, 157);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtp_i_schooltime.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtp_i_schooltime.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtp_i_schooltime.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtp_i_schooltime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtp_i_schooltime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtp_i_schooltime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtp_i_schooltime.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtp_i_schooltime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtp_i_schooltime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtp_i_schooltime.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtp_i_schooltime.MonthCalendar.DisplayMonth = new System.DateTime(2017, 10, 1, 0, 0, 0, 0);
            this.dtp_i_schooltime.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtp_i_schooltime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtp_i_schooltime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtp_i_schooltime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtp_i_schooltime.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtp_i_schooltime.MonthCalendar.TodayButtonVisible = true;
            this.dtp_i_schooltime.Name = "dtp_i_schooltime";
            this.dtp_i_schooltime.Size = new System.Drawing.Size(250, 26);
            this.dtp_i_schooltime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtp_i_schooltime.TabIndex = 12;
            // 
            // tb_i_phone
            // 
            this.tb_i_phone.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_i_phone.Border.Class = "TextBoxBorder";
            this.tb_i_phone.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_i_phone.DisabledBackColor = System.Drawing.Color.White;
            this.tb_i_phone.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_i_phone.ForeColor = System.Drawing.Color.Black;
            this.tb_i_phone.Location = new System.Drawing.Point(988, 25);
            this.tb_i_phone.MaxLength = 11;
            this.tb_i_phone.Name = "tb_i_phone";
            this.tb_i_phone.PreventEnterBeep = true;
            this.tb_i_phone.Size = new System.Drawing.Size(250, 26);
            this.tb_i_phone.TabIndex = 3;
            // 
            // cmb_i_jys
            // 
            this.cmb_i_jys.DisplayMember = "Text";
            this.cmb_i_jys.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_i_jys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_i_jys.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_i_jys.ForeColor = System.Drawing.Color.Black;
            this.cmb_i_jys.FormattingEnabled = true;
            this.cmb_i_jys.ItemHeight = 21;
            this.cmb_i_jys.Items.AddRange(new object[] {
            this.comboItem4,
            this.comboItem5,
            this.comboItem6});
            this.cmb_i_jys.Location = new System.Drawing.Point(988, 69);
            this.cmb_i_jys.Name = "cmb_i_jys";
            this.cmb_i_jys.Size = new System.Drawing.Size(250, 27);
            this.cmb_i_jys.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmb_i_jys.TabIndex = 6;
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "男";
            // 
            // comboItem6
            // 
            this.comboItem6.Text = "女";
            // 
            // cmb_i_hunyin
            // 
            this.cmb_i_hunyin.DisplayMember = "Text";
            this.cmb_i_hunyin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_i_hunyin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_i_hunyin.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_i_hunyin.ForeColor = System.Drawing.Color.Black;
            this.cmb_i_hunyin.FormattingEnabled = true;
            this.cmb_i_hunyin.ItemHeight = 21;
            this.cmb_i_hunyin.Items.AddRange(new object[] {
            this.comboItem7,
            this.comboItem8,
            this.comboItem9,
            this.comboItem10,
            this.comboItem11});
            this.cmb_i_hunyin.Location = new System.Drawing.Point(988, 201);
            this.cmb_i_hunyin.Name = "cmb_i_hunyin";
            this.cmb_i_hunyin.Size = new System.Drawing.Size(250, 27);
            this.cmb_i_hunyin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmb_i_hunyin.TabIndex = 15;
            // 
            // comboItem8
            // 
            this.comboItem8.Text = "未婚";
            // 
            // comboItem9
            // 
            this.comboItem9.Text = "已婚";
            // 
            // comboItem10
            // 
            this.comboItem10.Text = "离异";
            // 
            // comboItem11
            // 
            this.comboItem11.Text = "丧偶";
            // 
            // tb_i_email
            // 
            this.tb_i_email.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_i_email.Border.Class = "TextBoxBorder";
            this.tb_i_email.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_i_email.DisabledBackColor = System.Drawing.Color.White;
            this.tb_i_email.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_i_email.ForeColor = System.Drawing.Color.Black;
            this.tb_i_email.Location = new System.Drawing.Point(602, 201);
            this.tb_i_email.MaxLength = 50;
            this.tb_i_email.Name = "tb_i_email";
            this.tb_i_email.PreventEnterBeep = true;
            this.tb_i_email.Size = new System.Drawing.Size(250, 26);
            this.tb_i_email.TabIndex = 14;
            // 
            // tb_i_zhiwu
            // 
            this.tb_i_zhiwu.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_i_zhiwu.Border.Class = "TextBoxBorder";
            this.tb_i_zhiwu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_i_zhiwu.DisabledBackColor = System.Drawing.Color.White;
            this.tb_i_zhiwu.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_i_zhiwu.ForeColor = System.Drawing.Color.Black;
            this.tb_i_zhiwu.Location = new System.Drawing.Point(602, 113);
            this.tb_i_zhiwu.MaxLength = 32;
            this.tb_i_zhiwu.Name = "tb_i_zhiwu";
            this.tb_i_zhiwu.PreventEnterBeep = true;
            this.tb_i_zhiwu.Size = new System.Drawing.Size(250, 26);
            this.tb_i_zhiwu.TabIndex = 8;
            // 
            // dtp_i_worktime
            // 
            // 
            // 
            // 
            this.dtp_i_worktime.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtp_i_worktime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtp_i_worktime.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtp_i_worktime.ButtonDropDown.Visible = true;
            this.dtp_i_worktime.CustomFormat = "yyyy-MM-dd";
            this.dtp_i_worktime.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtp_i_worktime.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtp_i_worktime.IsPopupCalendarOpen = false;
            this.dtp_i_worktime.Location = new System.Drawing.Point(602, 157);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtp_i_worktime.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtp_i_worktime.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtp_i_worktime.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtp_i_worktime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtp_i_worktime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtp_i_worktime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtp_i_worktime.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtp_i_worktime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtp_i_worktime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtp_i_worktime.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtp_i_worktime.MonthCalendar.DisplayMonth = new System.DateTime(2017, 10, 1, 0, 0, 0, 0);
            this.dtp_i_worktime.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtp_i_worktime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtp_i_worktime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtp_i_worktime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtp_i_worktime.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtp_i_worktime.MonthCalendar.TodayButtonVisible = true;
            this.dtp_i_worktime.Name = "dtp_i_worktime";
            this.dtp_i_worktime.Size = new System.Drawing.Size(250, 26);
            this.dtp_i_worktime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtp_i_worktime.TabIndex = 11;
            // 
            // cmb_i_gender
            // 
            this.cmb_i_gender.DisplayMember = "Text";
            this.cmb_i_gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_i_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_i_gender.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_i_gender.ForeColor = System.Drawing.Color.Black;
            this.cmb_i_gender.FormattingEnabled = true;
            this.cmb_i_gender.ItemHeight = 21;
            this.cmb_i_gender.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3});
            this.cmb_i_gender.Location = new System.Drawing.Point(602, 69);
            this.cmb_i_gender.Name = "cmb_i_gender";
            this.cmb_i_gender.Size = new System.Drawing.Size(250, 27);
            this.cmb_i_gender.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmb_i_gender.TabIndex = 5;
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "男";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "女";
            // 
            // tb_i_idcard
            // 
            this.tb_i_idcard.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_i_idcard.Border.Class = "TextBoxBorder";
            this.tb_i_idcard.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_i_idcard.DisabledBackColor = System.Drawing.Color.White;
            this.tb_i_idcard.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_i_idcard.ForeColor = System.Drawing.Color.Black;
            this.tb_i_idcard.Location = new System.Drawing.Point(216, 24);
            this.tb_i_idcard.MaxLength = 18;
            this.tb_i_idcard.Name = "tb_i_idcard";
            this.tb_i_idcard.PreventEnterBeep = true;
            this.tb_i_idcard.Size = new System.Drawing.Size(250, 26);
            this.tb_i_idcard.TabIndex = 2;
            this.tb_i_idcard.Leave += new System.EventHandler(this.tb_i_idcard_Leave);
            // 
            // tb_i_gzz
            // 
            this.tb_i_gzz.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_i_gzz.Border.Class = "TextBoxBorder";
            this.tb_i_gzz.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_i_gzz.DisabledBackColor = System.Drawing.Color.White;
            this.tb_i_gzz.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_i_gzz.ForeColor = System.Drawing.Color.Black;
            this.tb_i_gzz.Location = new System.Drawing.Point(602, 25);
            this.tb_i_gzz.MaxLength = 6;
            this.tb_i_gzz.Name = "tb_i_gzz";
            this.tb_i_gzz.PreventEnterBeep = true;
            this.tb_i_gzz.Size = new System.Drawing.Size(250, 26);
            this.tb_i_gzz.TabIndex = 2;
            // 
            // dtp_i_birthday
            // 
            // 
            // 
            // 
            this.dtp_i_birthday.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtp_i_birthday.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtp_i_birthday.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtp_i_birthday.ButtonDropDown.Visible = true;
            this.dtp_i_birthday.CustomFormat = "yyyy-MM-dd";
            this.dtp_i_birthday.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtp_i_birthday.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtp_i_birthday.IsPopupCalendarOpen = false;
            this.dtp_i_birthday.Location = new System.Drawing.Point(216, 157);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtp_i_birthday.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtp_i_birthday.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtp_i_birthday.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtp_i_birthday.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtp_i_birthday.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtp_i_birthday.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtp_i_birthday.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtp_i_birthday.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtp_i_birthday.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtp_i_birthday.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtp_i_birthday.MonthCalendar.DisplayMonth = new System.DateTime(2017, 10, 1, 0, 0, 0, 0);
            this.dtp_i_birthday.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtp_i_birthday.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtp_i_birthday.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtp_i_birthday.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtp_i_birthday.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtp_i_birthday.MonthCalendar.TodayButtonVisible = true;
            this.dtp_i_birthday.Name = "dtp_i_birthday";
            this.dtp_i_birthday.Size = new System.Drawing.Size(250, 26);
            this.dtp_i_birthday.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtp_i_birthday.TabIndex = 10;
            // 
            // tb_i_nation
            // 
            this.tb_i_nation.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_i_nation.Border.Class = "TextBoxBorder";
            this.tb_i_nation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_i_nation.DisabledBackColor = System.Drawing.Color.White;
            this.tb_i_nation.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_i_nation.ForeColor = System.Drawing.Color.Black;
            this.tb_i_nation.Location = new System.Drawing.Point(216, 113);
            this.tb_i_nation.MaxLength = 32;
            this.tb_i_nation.Name = "tb_i_nation";
            this.tb_i_nation.PreventEnterBeep = true;
            this.tb_i_nation.Size = new System.Drawing.Size(250, 26);
            this.tb_i_nation.TabIndex = 7;
            // 
            // tb_i_zzmm
            // 
            this.tb_i_zzmm.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_i_zzmm.Border.Class = "TextBoxBorder";
            this.tb_i_zzmm.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_i_zzmm.DisabledBackColor = System.Drawing.Color.White;
            this.tb_i_zzmm.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_i_zzmm.ForeColor = System.Drawing.Color.Black;
            this.tb_i_zzmm.Location = new System.Drawing.Point(216, 201);
            this.tb_i_zzmm.MaxLength = 32;
            this.tb_i_zzmm.Name = "tb_i_zzmm";
            this.tb_i_zzmm.PreventEnterBeep = true;
            this.tb_i_zzmm.Size = new System.Drawing.Size(250, 26);
            this.tb_i_zzmm.TabIndex = 13;
            // 
            // tb_i_name
            // 
            this.tb_i_name.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_i_name.Border.Class = "TextBoxBorder";
            this.tb_i_name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_i_name.DisabledBackColor = System.Drawing.Color.White;
            this.tb_i_name.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_i_name.ForeColor = System.Drawing.Color.Black;
            this.tb_i_name.Location = new System.Drawing.Point(216, 69);
            this.tb_i_name.MaxLength = 32;
            this.tb_i_name.Name = "tb_i_name";
            this.tb_i_name.PreventEnterBeep = true;
            this.tb_i_name.Size = new System.Drawing.Size(250, 26);
            this.tb_i_name.TabIndex = 4;
            // 
            // sw_i_phdtutor
            // 
            // 
            // 
            // 
            this.sw_i_phdtutor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.sw_i_phdtutor.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sw_i_phdtutor.Location = new System.Drawing.Point(216, 335);
            this.sw_i_phdtutor.Name = "sw_i_phdtutor";
            this.sw_i_phdtutor.OffText = "否";
            this.sw_i_phdtutor.OnText = "是";
            this.sw_i_phdtutor.Size = new System.Drawing.Size(138, 22);
            this.sw_i_phdtutor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.sw_i_phdtutor.SwitchWidth = 58;
            this.sw_i_phdtutor.TabIndex = 24;
            // 
            // tb_i_subject
            // 
            this.tb_i_subject.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_i_subject.Border.Class = "TextBoxBorder";
            this.tb_i_subject.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_i_subject.DisabledBackColor = System.Drawing.Color.White;
            this.tb_i_subject.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_i_subject.ForeColor = System.Drawing.Color.Black;
            this.tb_i_subject.Location = new System.Drawing.Point(983, 333);
            this.tb_i_subject.MaxLength = 50;
            this.tb_i_subject.Name = "tb_i_subject";
            this.tb_i_subject.PreventEnterBeep = true;
            this.tb_i_subject.Size = new System.Drawing.Size(255, 26);
            this.tb_i_subject.TabIndex = 26;
            // 
            // tb_i_researchArea
            // 
            this.tb_i_researchArea.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_i_researchArea.Border.Class = "TextBoxBorder";
            this.tb_i_researchArea.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_i_researchArea.DisabledBackColor = System.Drawing.Color.White;
            this.tb_i_researchArea.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_i_researchArea.ForeColor = System.Drawing.Color.Black;
            this.tb_i_researchArea.Location = new System.Drawing.Point(530, 333);
            this.tb_i_researchArea.MaxLength = 128;
            this.tb_i_researchArea.Name = "tb_i_researchArea";
            this.tb_i_researchArea.PreventEnterBeep = true;
            this.tb_i_researchArea.Size = new System.Drawing.Size(255, 26);
            this.tb_i_researchArea.TabIndex = 25;
            // 
            // labelX63
            // 
            this.labelX63.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX63.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX63.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX63.Location = new System.Drawing.Point(127, 71);
            this.labelX63.Name = "labelX63";
            this.labelX63.Size = new System.Drawing.Size(83, 23);
            this.labelX63.TabIndex = 8;
            this.labelX63.Text = "姓名：";
            this.labelX63.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX62
            // 
            this.labelX62.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX62.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX62.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX62.Location = new System.Drawing.Point(508, 71);
            this.labelX62.Name = "labelX62";
            this.labelX62.Size = new System.Drawing.Size(97, 23);
            this.labelX62.TabIndex = 9;
            this.labelX62.Text = "性别：";
            this.labelX62.TextAlignment = System.Drawing.StringAlignment.Far;
            this.labelX62.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX61
            // 
            this.labelX61.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX61.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX61.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX61.Location = new System.Drawing.Point(127, 115);
            this.labelX61.Name = "labelX61";
            this.labelX61.Size = new System.Drawing.Size(83, 23);
            this.labelX61.TabIndex = 12;
            this.labelX61.Text = "民族：";
            this.labelX61.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX60
            // 
            this.labelX60.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX60.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX60.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX60.Location = new System.Drawing.Point(504, 115);
            this.labelX60.Name = "labelX60";
            this.labelX60.Size = new System.Drawing.Size(101, 23);
            this.labelX60.TabIndex = 10;
            this.labelX60.Text = "职务：";
            this.labelX60.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX59
            // 
            this.labelX59.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX59.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX59.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX59.Location = new System.Drawing.Point(880, 115);
            this.labelX59.Name = "labelX59";
            this.labelX59.Size = new System.Drawing.Size(110, 23);
            this.labelX59.TabIndex = 11;
            this.labelX59.Text = "职称：";
            this.labelX59.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX58
            // 
            this.labelX58.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX58.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX58.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX58.Location = new System.Drawing.Point(508, 27);
            this.labelX58.Name = "labelX58";
            this.labelX58.Size = new System.Drawing.Size(97, 23);
            this.labelX58.TabIndex = 33;
            this.labelX58.Text = "工作证号：";
            this.labelX58.TextAlignment = System.Drawing.StringAlignment.Far;
            this.labelX58.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX57
            // 
            this.labelX57.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX57.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX57.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX57.Location = new System.Drawing.Point(115, 27);
            this.labelX57.Name = "labelX57";
            this.labelX57.Size = new System.Drawing.Size(95, 23);
            this.labelX57.TabIndex = 32;
            this.labelX57.Text = "身份证号：";
            this.labelX57.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX56
            // 
            this.labelX56.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX56.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX56.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX56.Location = new System.Drawing.Point(853, 27);
            this.labelX56.Name = "labelX56";
            this.labelX56.Size = new System.Drawing.Size(137, 23);
            this.labelX56.TabIndex = 31;
            this.labelX56.Text = "联系电话：";
            this.labelX56.TextAlignment = System.Drawing.StringAlignment.Far;
            this.labelX56.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX55
            // 
            this.labelX55.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX55.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX55.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX55.Location = new System.Drawing.Point(95, 159);
            this.labelX55.Name = "labelX55";
            this.labelX55.Size = new System.Drawing.Size(115, 23);
            this.labelX55.TabIndex = 30;
            this.labelX55.Text = "出生时间：";
            this.labelX55.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX54
            // 
            this.labelX54.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX54.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX54.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX54.Location = new System.Drawing.Point(874, 71);
            this.labelX54.Name = "labelX54";
            this.labelX54.Size = new System.Drawing.Size(116, 23);
            this.labelX54.TabIndex = 29;
            this.labelX54.Text = "教 研 室：";
            this.labelX54.TextAlignment = System.Drawing.StringAlignment.Far;
            this.labelX54.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX53
            // 
            this.labelX53.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX53.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX53.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX53.Location = new System.Drawing.Point(98, 203);
            this.labelX53.Name = "labelX53";
            this.labelX53.Size = new System.Drawing.Size(112, 23);
            this.labelX53.TabIndex = 28;
            this.labelX53.Text = "政治面貌：";
            this.labelX53.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX52
            // 
            this.labelX52.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX52.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX52.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX52.Location = new System.Drawing.Point(490, 159);
            this.labelX52.Name = "labelX52";
            this.labelX52.Size = new System.Drawing.Size(115, 23);
            this.labelX52.TabIndex = 27;
            this.labelX52.Text = "工作时间：";
            this.labelX52.TextAlignment = System.Drawing.StringAlignment.Far;
            this.labelX52.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX50
            // 
            this.labelX50.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX50.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX50.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX50.Location = new System.Drawing.Point(114, 247);
            this.labelX50.Name = "labelX50";
            this.labelX50.Size = new System.Drawing.Size(96, 23);
            this.labelX50.TabIndex = 25;
            this.labelX50.Text = "初始学历：";
            this.labelX50.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX51
            // 
            this.labelX51.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX51.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX51.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX51.Location = new System.Drawing.Point(493, 203);
            this.labelX51.Name = "labelX51";
            this.labelX51.Size = new System.Drawing.Size(112, 23);
            this.labelX51.TabIndex = 26;
            this.labelX51.Text = "电子信箱：";
            this.labelX51.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX49
            // 
            this.labelX49.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX49.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX49.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX49.Location = new System.Drawing.Point(83, 423);
            this.labelX49.Name = "labelX49";
            this.labelX49.Size = new System.Drawing.Size(127, 23);
            this.labelX49.TabIndex = 35;
            this.labelX49.Text = "家庭住址：";
            this.labelX49.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX48
            // 
            this.labelX48.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX48.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX48.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX48.Location = new System.Drawing.Point(90, 291);
            this.labelX48.Name = "labelX48";
            this.labelX48.Size = new System.Drawing.Size(120, 23);
            this.labelX48.TabIndex = 23;
            this.labelX48.Text = "最后学历：";
            this.labelX48.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX47
            // 
            this.labelX47.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX47.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX47.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX47.Location = new System.Drawing.Point(317, 247);
            this.labelX47.Name = "labelX47";
            this.labelX47.Size = new System.Drawing.Size(99, 23);
            this.labelX47.TabIndex = 34;
            this.labelX47.Text = "初始学位：";
            this.labelX47.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX45
            // 
            this.labelX45.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX45.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX45.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX45.Location = new System.Drawing.Point(875, 159);
            this.labelX45.Name = "labelX45";
            this.labelX45.Size = new System.Drawing.Size(115, 23);
            this.labelX45.TabIndex = 21;
            this.labelX45.Text = "来校时间：";
            this.labelX45.TextAlignment = System.Drawing.StringAlignment.Far;
            this.labelX45.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX44
            // 
            this.labelX44.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX44.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX44.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX44.Location = new System.Drawing.Point(310, 291);
            this.labelX44.Name = "labelX44";
            this.labelX44.Size = new System.Drawing.Size(106, 23);
            this.labelX44.TabIndex = 20;
            this.labelX44.Text = "最后学位：";
            this.labelX44.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX46
            // 
            this.labelX46.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX46.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX46.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX46.Location = new System.Drawing.Point(521, 291);
            this.labelX46.Name = "labelX46";
            this.labelX46.Size = new System.Drawing.Size(93, 23);
            this.labelX46.TabIndex = 19;
            this.labelX46.Text = "毕业时间：";
            // 
            // labelX43
            // 
            this.labelX43.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX43.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX43.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX43.Location = new System.Drawing.Point(521, 247);
            this.labelX43.Name = "labelX43";
            this.labelX43.Size = new System.Drawing.Size(93, 23);
            this.labelX43.TabIndex = 19;
            this.labelX43.Text = "毕业时间：";
            // 
            // labelX64
            // 
            this.labelX64.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX64.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX64.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX64.Location = new System.Drawing.Point(781, 291);
            this.labelX64.Name = "labelX64";
            this.labelX64.Size = new System.Drawing.Size(96, 23);
            this.labelX64.TabIndex = 18;
            this.labelX64.Text = "毕业学校：";
            // 
            // labelX39
            // 
            this.labelX39.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX39.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX39.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX39.Location = new System.Drawing.Point(88, 580);
            this.labelX39.Name = "labelX39";
            this.labelX39.Size = new System.Drawing.Size(121, 23);
            this.labelX39.TabIndex = 16;
            this.labelX39.Text = "个人照片：";
            this.labelX39.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX42
            // 
            this.labelX42.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX42.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX42.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX42.Location = new System.Drawing.Point(781, 247);
            this.labelX42.Name = "labelX42";
            this.labelX42.Size = new System.Drawing.Size(96, 23);
            this.labelX42.TabIndex = 18;
            this.labelX42.Text = "毕业学校：";
            // 
            // labelX40
            // 
            this.labelX40.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX40.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX40.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX40.Location = new System.Drawing.Point(88, 467);
            this.labelX40.Name = "labelX40";
            this.labelX40.Size = new System.Drawing.Size(121, 23);
            this.labelX40.TabIndex = 16;
            this.labelX40.Text = "户口地址：";
            this.labelX40.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX38
            // 
            this.labelX38.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX38.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX38.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX38.Location = new System.Drawing.Point(797, 335);
            this.labelX38.Name = "labelX38";
            this.labelX38.Size = new System.Drawing.Size(193, 22);
            this.labelX38.TabIndex = 14;
            this.labelX38.Text = "现主要从事学科门类：";
            this.labelX38.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX34
            // 
            this.labelX34.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX34.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX34.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX34.Location = new System.Drawing.Point(88, 335);
            this.labelX34.Name = "labelX34";
            this.labelX34.Size = new System.Drawing.Size(122, 23);
            this.labelX34.TabIndex = 37;
            this.labelX34.Text = "是否为博导：";
            this.labelX34.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX37
            // 
            this.labelX37.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX37.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX37.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX37.Location = new System.Drawing.Point(880, 203);
            this.labelX37.Name = "labelX37";
            this.labelX37.Size = new System.Drawing.Size(112, 23);
            this.labelX37.TabIndex = 13;
            this.labelX37.Text = "婚姻状况：";
            this.labelX37.TextAlignment = System.Drawing.StringAlignment.Far;
            this.labelX37.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX35
            // 
            this.labelX35.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX35.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX35.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX35.Location = new System.Drawing.Point(70, 379);
            this.labelX35.Name = "labelX35";
            this.labelX35.Size = new System.Drawing.Size(140, 23);
            this.labelX35.TabIndex = 36;
            this.labelX35.Text = "家庭主要成员：";
            this.labelX35.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX36
            // 
            this.labelX36.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX36.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX36.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX36.Location = new System.Drawing.Point(394, 332);
            this.labelX36.Name = "labelX36";
            this.labelX36.Size = new System.Drawing.Size(150, 29);
            this.labelX36.TabIndex = 24;
            this.labelX36.Text = "教学和研究方向：";
            this.labelX36.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // superTabItem2
            // 
            this.superTabItem2.AttachedControl = this.superTabControlPanel2;
            this.superTabItem2.GlobalItem = false;
            this.superTabItem2.Name = "superTabItem2";
            this.superTabItem2.Text = "信息录入";
            // 
            // superTabControlPanel3
            // 
            this.superTabControlPanel3.Controls.Add(this.groupPanel4);
            this.superTabControlPanel3.Controls.Add(this.groupPanel3);
            this.superTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel3.Location = new System.Drawing.Point(0, 26);
            this.superTabControlPanel3.Name = "superTabControlPanel3";
            this.superTabControlPanel3.Size = new System.Drawing.Size(1422, 718);
            this.superTabControlPanel3.TabIndex = 0;
            this.superTabControlPanel3.TabItem = this.superTabItem3;
            // 
            // groupPanel4
            // 
            this.groupPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel4.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel4.Controls.Add(this.lb_dangyuan);
            this.groupPanel4.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel4.Location = new System.Drawing.Point(264, 47);
            this.groupPanel4.Name = "groupPanel4";
            this.groupPanel4.Size = new System.Drawing.Size(210, 100);
            // 
            // 
            // 
            this.groupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel4.Style.BackColorGradientAngle = 90;
            this.groupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderBottomWidth = 1;
            this.groupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderLeftWidth = 1;
            this.groupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderRightWidth = 1;
            this.groupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderTopWidth = 1;
            this.groupPanel4.Style.CornerDiameter = 4;
            this.groupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel4.TabIndex = 0;
            this.groupPanel4.Text = "党员人数";
            // 
            // lb_dangyuan
            // 
            // 
            // 
            // 
            this.lb_dangyuan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_dangyuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_dangyuan.ForeColor = System.Drawing.Color.Maroon;
            this.lb_dangyuan.Location = new System.Drawing.Point(69, 27);
            this.lb_dangyuan.Name = "lb_dangyuan";
            this.lb_dangyuan.Size = new System.Drawing.Size(101, 23);
            this.lb_dangyuan.TabIndex = 0;
            this.lb_dangyuan.Text = "labelX65";
            // 
            // groupPanel3
            // 
            this.groupPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.lb_zaizhi);
            this.groupPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel3.Location = new System.Drawing.Point(25, 49);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(210, 100);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel3.TabIndex = 0;
            this.groupPanel3.Text = "在职人数";
            // 
            // lb_zaizhi
            // 
            // 
            // 
            // 
            this.lb_zaizhi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_zaizhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_zaizhi.ForeColor = System.Drawing.Color.Maroon;
            this.lb_zaizhi.Location = new System.Drawing.Point(69, 27);
            this.lb_zaizhi.Name = "lb_zaizhi";
            this.lb_zaizhi.Size = new System.Drawing.Size(101, 23);
            this.lb_zaizhi.TabIndex = 0;
            this.lb_zaizhi.Text = "labelX65";
            // 
            // superTabItem3
            // 
            this.superTabItem3.AttachedControl = this.superTabControlPanel3;
            this.superTabItem3.GlobalItem = false;
            this.superTabItem3.Name = "superTabItem3";
            this.superTabItem3.Text = "信息统计";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199))))));
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lb_totalNum});
            this.statusStrip1.Location = new System.Drawing.Point(0, 756);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1428, 24);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lb_totalNum
            // 
            this.lb_totalNum.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lb_totalNum.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.lb_totalNum.Name = "lb_totalNum";
            this.lb_totalNum.Size = new System.Drawing.Size(76, 19);
            this.lb_totalNum.Text = "系统总人数";
            // 
            // opf_picture
            // 
            this.opf_picture.Filter = "图片|*.bmp;*.jpg;*.png;*.jpeg;*.JPG;*.PNG;*.BMP;*.JPEG|所有文件|*.*\"";
            // 
            // axdoc_main
            // 
            this.axdoc_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axdoc_main.Enabled = true;
            this.axdoc_main.Location = new System.Drawing.Point(422, 0);
            this.axdoc_main.Name = "axdoc_main";
            this.axdoc_main.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axdoc_main.OcxState")));
            this.axdoc_main.Size = new System.Drawing.Size(1000, 712);
            this.axdoc_main.TabIndex = 37;
            // 
            // F_main
            // 
            this.AcceptButton = this.bt_jiansuo;
            this.ClientSize = new System.Drawing.Size(1428, 780);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.superTabControl1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "吉林大学马克思主义学院办公系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();
            this.superTabControl1.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_person)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qresult)).EndInit();
            this.cms_dgvAction.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.superTabControlPanel4.ResumeLayout(false);
            this.superTabControlPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_luru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_i_initime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_i_endtime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_i_schooltime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_i_worktime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_i_birthday)).EndInit();
            this.superTabControlPanel3.ResumeLayout(false);
            this.groupPanel4.ResumeLayout(false);
            this.groupPanel3.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axdoc_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            //this.axFramerControl1
            this.axdoc_main.Open(Application.StartupPath + @"\dll\jianli.docx");
            //this.axFramerControl1.Open(oDoc);
        }
    }
}