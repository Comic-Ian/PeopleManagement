namespace PeopleManagement.Model
{
    /// <summary>
    /// 人物模型
    /// </summary>
    public class PeopleModel
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string PeopleName { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public SexEnum Sex { get; set; }

    }
}
