using _191105581_TruongQuangHy_BigSchool.DTOs;
using _191105581_TruongQuangHy_BigSchool.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _191105581_TruongQuangHy_BigSchool.Controllers
{
    public class FollowingsController : ApiController
    {
        // GET: Followings
        private readonly ApplicationDbContext _DbContext;
        public FollowingsController()
        {
            _DbContext = new ApplicationDbContext();
        }

        [System.Web.Http.HttpPost]
        public IHttpActionResult Follow(FollowingDto followingDto)
        {
            var userId = User.Identity.GetUserId();
            if (_DbContext.Followings.Any(f => f.FollowerId == userId && f.FolloweeId == followingDto.FolloweeId))
                return BadRequest("Following Already Axists !");


            var folowing = new Following
            {
                FollowerId = userId,
                FolloweeId = followingDto.FolloweeId
            };

            _DbContext.Followings.Add(folowing);
            _DbContext.SaveChanges();
            return Ok();
        }
        [HttpDelete]
        public IHttpActionResult DeleteFollow(string Id)
        {
            var userId = User.Identity.GetUserId();
            var following = _DbContext.Followings.SingleOrDefault(f => f.FollowerId == userId && f.FolloweeId == Id);
            if (following == null)
            {
                return NotFound();
            }
            _DbContext.Followings.Remove(following);
            _DbContext.SaveChanges();
            return Ok(Id);
        }
    }
}