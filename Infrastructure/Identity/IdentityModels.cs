using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Infrastructure;
using Infrastructure.Entities;
using Infrastructure.Enums;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Website.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        #region Properties
        [StringLength(255)]
        public string Avatar { get; set; }

        [Display(Name = "Địa chỉ")]
        [StringLength(100)]
        public string Address { get; set; }

        [Display(Name = "Giới tính")]
        public GenderEnum Gender { get; set; }

        [StringLength(100)]
        [Display(Name = "Họ và tên")]
        public string FullName { get; set; }

        [Display(Name = "Trạng thái")]
        public StatusEnum Status { get; set; }

        public DateTime? CreatedDate { get; set; }

        #endregion

        #region Relation

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Wishlist> Wishlists { get; set; }
        #endregion
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
}