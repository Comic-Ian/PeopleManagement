namespace PeopleManagement
{
    using System;
    using System.Text;
    using System.Windows.Forms;
    using System.Collections.Generic;
    using Model;

    public partial class FrmDemo : Form
    {
        //申明一个静态的泛型集合  泛型 IList<T>  T：代表放入的类型  这里放入的是模型类
        private static IList<PeopleModel> _peopleList = null;


        /// <summary>
        /// 构造函数
        /// </summary>
        public FrmDemo()
        {
            //初始化窗体
            InitializeComponent();
            //初始化人物存放集合
            _peopleList = new List<PeopleModel>();
            //初始化窗体的性别集合到控件Combbox
            InitSex();
        }

        /// <summary>
        /// 初始化性别
        /// </summary>
        private void InitSex()
        {
            //获取我定义的性别枚举的类型
            Type sexenumtype = typeof(SexEnum);

            //获取枚举的名字数组
            string[] sexnames = Enum.GetNames(sexenumtype);

            //将获取到的名字分别加入到控件中
            for (int i = 0; i < sexnames.Length; i++)
            {
                cmbSex.Items.Add(sexnames[i]);
            }
            //设置下拉框默认选中第一个
            cmbSex.SelectedIndex = 0;

        }


        /// <summary>
        /// 展示集合数据到Datagridview
        /// </summary>
        private void ShowListInDatagridView(PeopleModel people)
        {
            //添加一行获得添加的行号
            int index = dgv.Rows.Add();

            //给对应那一行 的每一列添加数据
            dgv.Rows[index].Cells[0].Value = people.PeopleName;
            dgv.Rows[index].Cells[1].Value = people.Age;
            dgv.Rows[index].Cells[2].Value = people.Sex.ToString();

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

            //获取数据
            string name = txtName.Text.ToString();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("添加人物,名字不能为空");
                return;
            }
            string age = txtAge.Text.ToString();
            if (string.IsNullOrEmpty(age))
            {
                MessageBox.Show("添加人物,年龄不能为空");
                return;
            }

            int peopleage = 0;
            //尝试将年龄转成int类型
            if (int.TryParse(age, out peopleage) == false)
            {
                MessageBox.Show("添加人物,请输入正确的年龄");
                return;
            }

            string sex = cmbSex.SelectedItem.ToString();

            PeopleModel people = new PeopleModel();
            people.PeopleName = name;
            people.Age = peopleage;
            if (sex == "男")
            {
                people.Sex = SexEnum.男;
            }
            else if (sex == "女")
            {
                people.Sex = SexEnum.女;
            }

            //加入到集合中
            _peopleList.Add(people);

            //加入到页面
            ShowListInDatagridView(people);

            MessageBox.Show("添加成功");

        }
    }
}
