﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Abp.Domain.Entities;


namespace B2000_AbpEf.Model
{

    /// <summary>
    /// 测试教师表.
    /// </summary>
    [Table("test_abp_teacher")]
    public class Teacher : Entity<Int32>
    {


        /// <summary>
        /// 教师名.
        /// </summary>
        [Column("teacher_name")]
        [StringLength(32)]
        public string TeacherName { set; get; }





        #region 一对多.



        /// <summary>
        /// 学校代码
        /// </summary>
        public Int32? SchoolID { set; get; }


        /// <summary>  
        /// 执教的 学校.
        /// 这里是 一对多 关系中
        /// 一个学校，对应多个教师.
        /// </summary>  
        [ForeignKey(nameof(SchoolID))]
        public virtual School InSchool { get; set; }



        #endregion 一对多.







        #region 多对多.



        /// <summary>
        /// 一个学生，可能有多个老师对其进行授课.
        /// 一个老师，可能对多个同学进行授课.
        /// </summary>
        public virtual ICollection<Student> Students { get; set; }



        #endregion 多对多.







        public override string ToString()
        {
            return String.Format(@"Teacher [ id = {0};  name = {1};  schoolID = {2} ]", this.Id, this.TeacherName, this.SchoolID);
        }




    }
}
