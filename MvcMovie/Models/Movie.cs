using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [StringLength(60,MinimumLength =3)]
        public string Title { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }
        [Range(1,100)]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString ="{0:c}")]
        public decimal Price { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(5)]
        public string Rating { get; set; }
    }
    public class MovieDBContext:DbContext
    {
        public DbSet <Movie> Movies { get; set; }
    }
    /*
         我们将使用Movie类来表示数据库中的电影。 
         Movie对象的每个实例将对应数据库表的一行，
         Movie类的每个属性将对应表的一列。
         MovieDBContext类代表Entity Framework的电影数据库类，
         这个类负责在数据库中获取，存储，更新，处理 Movie 类的实例。
         MovieDBContext继承自Entity Framework的 DbContext基类
     */
}