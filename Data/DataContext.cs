using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PhoneWeb.Models;
using PhoneWeb.Models.Domain;

namespace PhoneWeb.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Category>().HasData(
               new Category() { CategoryId = 1, CategoryName = "Áo Thun Ngắn Tay" },
                 new Category() { CategoryId = 2, CategoryName = "Áo Thun Dài Tay" },
                   new Category() { CategoryId = 3, CategoryName = "Áo Thun Cổ" });

            //----------------------------------------------------------------------------------------------------------------
            builder.Entity<Product>().HasData(new Product()
            {
                ProductId = 1,
                ProductName = "Áo Thun TN R Thiết Kế BD-A93",
                ProductImage = "1.jpg",
                Descriptions = "Chất liệu: Cotton 2 chiều, " +
                               "Thành phần: 100% Cotton, " +
                               " Co dãn 2 chiều, " +
                               "Thấm hút mồ hôi tốt mang lại cảm giác thoáng mái, " +
                               "Họa tiết: ép Foil " ,
                ProductQuantity = 100,
                ProductPrice = 300000,
                CreateDate = DateTime.Now,
                CategoryId = 1

            }, new Product()
            {
                ProductId = 2,
                ProductName = "Áo Thun TN TC Đơn Giản BN01",
                ProductImage = "2.jpg",
                Descriptions = "Chất liệu: Cotton 2 chiều, " +
                               "Thành phần: 100% Cotton, " +
                               "Co dãn 2 chiều, " +
                               "Thấm hút mồ hôi tốt mang lại cảm giác thoáng mát " ,
                ProductQuantity = 100,
                ProductPrice = 300000,
                CreateDate = DateTime.Now,
                CategoryId = 1

            }, new Product()
            {
                ProductId = 3,
                ProductName = "Áo Thun Cổ Trụ TC Đơn Giản J01",
                ProductImage = "3.jpg",
                Descriptions = "Chất liệu: Cotton 4 Chiều, " +
                               "Thành phần: 95% cotton 5% Spandex, " +
                               "Co giãn tốt, " +
                               "Độ bền cao " ,
                ProductQuantity = 100,
                ProductPrice = 300000,
                CreateDate = DateTime.Now,
                CategoryId = 1
            }, new Product()
            {
                ProductId = 4,
                ProductName = "Áo Thun TN R Thiết Kế BO01",
                ProductImage = "4.jpg",
                Descriptions = "Chất liệu: Cotton 2 chiều, " +
                               "Thành phần: 100% Cotton, " +
                               "Co dãn 2 chiều, " +
                               "Thấm hút mồ hôi tốt mang lại cảm giác thoáng mái, " +
                               "Họa tiết: in trame, in dẻo " ,
                ProductQuantity = 100,
                ProductPrice = 300000,
                CreateDate = DateTime.Now,
                CategoryId = 1
            },
            new Product()
            {
                ProductId = 5,
                ProductName = "Áo Thun TN R Thiết Kế BD-A90",
                ProductImage = "5.jpg",
                Descriptions = "Chất liệu: Cotton 2 chiều, " +
                               "Thành phần: 100% Cotton, " +
                               "Co dãn 2 chiều, " +
                               "Thấm hút mồ hôi tốt mang lại cảm giác thoáng mái, " +
                               "Họa tiết: in trame " ,
                ProductQuantity = 100,
                ProductPrice = 300000,
                CreateDate = DateTime.Now,
                CategoryId = 1
            },
            new Product()
            {
                ProductId = 6,
                ProductName = "Áo Thun TN TC Thiết Kế B1CF06",
                ProductImage = "6.jpg",
                Descriptions = "Chất liệu: Cotton 2 chiều, " +
                               "Thành phần: 100% Cotton, " +
                               "Co dãn 2 chiều, " +
                               "Thấm hút mồ hôi tốt mang lại cảm giác thoáng mát ",
                ProductQuantity = 100,
                ProductPrice = 250000,
                CreateDate = DateTime.Now,
                CategoryId = 2
            },
            new Product()
            {
                ProductId = 7,
                ProductName = "Áo Thun TD R Thiết Kế A02",
                ProductImage = "7.jpg",
                Descriptions = "Chất liệu: Cotton 2 chiều, " +
                               "Thành phần: 100% Cotton, " +
                               " Co dãn 2 chiều, " +
                               "Thấm hút mồ hôi tốt mang lại cảm giác thoáng mái, " +
                               "Họa tiết: ép Foil ",
                ProductQuantity = 100,
                ProductPrice = 250000,
                CreateDate = DateTime.Now,
                CategoryId = 2
            },
             new Product()
             {
                 ProductId = 8,
                 ProductName = "Áo Thun TD R Thiết Kế B02",
                 ProductImage = "8.jpg",
                 Descriptions = "Chất liệu: Cotton 2 chiều, " +
                               "Thành phần: 100% Cotton, " +
                               "Co dãn 2 chiều, " +
                               "Thấm hút mồ hôi tốt mang lại cảm giác thoáng mát ",
                 ProductQuantity = 100,
                 ProductPrice = 250000,
                 CreateDate = DateTime.Now,
                 CategoryId = 2
             },
            new Product()
            {
                ProductId = 9,
                ProductName = "Áo Thun TD TC Đơn Giản B4AA01",
                ProductImage = "9.jpg",
                Descriptions = "COUPLE TAY DÀI, " +
                               "Diện áo thun couple đã trở thành xu hướng của giới trẻ hiện đại, " +
                               "Đặc biệt áo thun tay dài raplan, màu sắc tươi mới, " +
                               "Thiết kế Unisex, dễ dàng mix với nhiều trang phục khác nhau, " +
                               "Chất liệu cotton 2 chiều, thoáng mát, bề mặt mịn đẹp ",
                ProductQuantity = 100,
                ProductPrice = 250000,
                CreateDate = DateTime.Now,
                CategoryId = 2
            },
            new Product()
            {
                ProductId = 10,
                ProductName = "Samsung Galaxy A71",
                ProductImage = "10.jpg",
                Descriptions = "COUPLE TAY DÀI, " +
                               "Diện áo thun couple đã trở thành xu hướng của giới trẻ hiện đại, " +
                               "Đặc biệt áo thun tay dài raplan, màu sắc tươi mới, " +
                               "Thiết kế Unisex, dễ dàng mix với nhiều trang phục khác nhau, " +
                               "Chất liệu cotton 2 chiều, thoáng mát, bề mặt mịn đẹp ",
                ProductQuantity = 100,
                ProductPrice = 250000,
                CreateDate = DateTime.Now,
                CategoryId = 2
            },
            new Product()
            {
                ProductId = 11,
                ProductName = "Áo Thun Cổ Trụ TC Đơn Giản B2R01",
                ProductImage = "11.jpg",
                Descriptions = "COUPLE TAY DÀI, " +
                               "Diện áo thun couple đã trở thành xu hướng của giới trẻ hiện đại, " +
                               "Đặc biệt áo thun tay dài raplan, màu sắc tươi mới, " +
                               "Thiết kế Unisex, dễ dàng mix với nhiều trang phục khác nhau, " +
                               "Chất liệu cotton 2 chiều, thoáng mát, bề mặt mịn đẹp ",
                ProductQuantity = 100,
                ProductPrice = 250000,
                CreateDate = DateTime.Now,
                CategoryId = 3
            },
            new Product()
            {
                ProductId = 12,
                ProductName = "Áo Thun Cổ Trụ TC Thiết Kế B2R04",
                ProductImage = "12.jpg",
                Descriptions = "COUPLE TAY DÀI, " +
                               "Diện áo thun couple đã trở thành xu hướng của giới trẻ hiện đại, " +
                               "Đặc biệt áo thun tay dài raplan, màu sắc tươi mới, " +
                               "Thiết kế Unisex, dễ dàng mix với nhiều trang phục khác nhau, " +
                               "Chất liệu cotton 2 chiều, thoáng mát, bề mặt mịn đẹp ",
                ProductQuantity = 100,
                ProductPrice = 250000,
                CreateDate = DateTime.Now,
                CategoryId = 3
            },
            new Product()
            {
                ProductId = 13,
                ProductName = "Áo Thun Cổ Trụ TC Thiết Kế B04",
                ProductImage = "13.jpg",
                Descriptions = "COUPLE TAY DÀI, " +
                        "Diện áo thun couple đã trở thành xu hướng của giới trẻ hiện đại, " +
                        "Đặc biệt áo thun tay dài raplan, màu sắc tươi mới, " +
                        "Thiết kế Unisex, dễ dàng mix với nhiều trang phục khác nhau, " +
                        "Chất liệu cotton 2 chiều, thoáng mát, bề mặt mịn đẹp ",
                ProductQuantity = 100,
                ProductPrice = 250000,
                CreateDate = DateTime.Now,
                CategoryId = 3
            },
            new Product()
            {
                ProductId = 14,
                ProductName = "Áo Thun Cổ Trụ TC Thiết Kế B1Q02",
                ProductImage = "14.jpg",
                Descriptions = "COUPLE TAY DÀI, " +
                        "Diện áo thun couple đã trở thành xu hướng của giới trẻ hiện đại, " +
                        "Đặc biệt áo thun tay dài raplan, màu sắc tươi mới, " +
                        "Thiết kế Unisex, dễ dàng mix với nhiều trang phục khác nhau, " +
                        "Chất liệu cotton 2 chiều, thoáng mát, bề mặt mịn đẹp ",
                ProductQuantity = 100,
                ProductPrice = 250000,
                CreateDate = DateTime.Now,
                CategoryId = 3
            },
            new Product()
            {
                ProductId = 15,
                ProductName = "Áo Thun Cổ Trụ TC Thiết Kế F01",
                ProductImage = "15.jpg",
                Descriptions = "COUPLE TAY DÀI, " +
                        "Diện áo thun couple đã trở thành xu hướng của giới trẻ hiện đại, " +
                        "Đặc biệt áo thun tay dài raplan, màu sắc tươi mới, " +
                        "Thiết kế Unisex, dễ dàng mix với nhiều trang phục khác nhau, " +
                        "Chất liệu cotton 2 chiều, thoáng mát, bề mặt mịn đẹp ",
                ProductQuantity = 100,
                ProductPrice = 250000,
                CreateDate = DateTime.Now,
                CategoryId = 3
            }
            );


            //----------------------------------------------------------------------------------------------------------------
            builder.Entity<IdentityRole>().HasData(
              new IdentityRole
              {
                  Name = "Visitor",
                  NormalizedName = "VISITOR"
              },
             new IdentityRole
             {
                 Name = "Administrator",
                 NormalizedName = "ADMINISTRATOR"
             });


        }
    }
}
