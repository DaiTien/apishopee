using ApiShopee.App;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;

namespace ApiShopee.Controllers
{
    //[Authorize]
    [Route("api/product")]
    public class ProductController : AbpController, IProductAppService
    {
        public ProductController()
        {

        }
        [Route("test")]
        [HttpGet]
        public string OnTestApi()
        {
            return SignatureGenerated();
        }
        
        private string SignatureGenerated()
        {
            DateTime start = DateTime.Now;
            long timest = ((DateTimeOffset)start).ToUnixTimeSeconds();
            //Live
            //string host = "https://partner.shopeemobile.com";
            //string path = "/api/v2/shop/auth_partner";

            //Test
            string host = "https://partner.test-stable.shopeemobile.com";
            string path = "/api/v2/shop/auth_partner";

            string redirectUrl = "https://home-dev.innofin.vn";
            //Test
            long partner_id = 1006066;
            string partner_key = "0bda23006319db246fcf2c3323f18e25e0fed7e6a1b7590e7ab61666e38f7784";

            //Live
            //long partner_id = 845884;
            //string partner_key = "494171547251506b4c434a7a7848757958596b4f636c65686f596d7869566658";

            string base_string = String.Format("{0}{1}{2}", partner_id, path, timest);
            byte[] partnerKey = Encoding.UTF8.GetBytes(partner_key);
            byte[] baseString = Encoding.UTF8.GetBytes(base_string);
            var hash = new HMACSHA256(partnerKey);
            byte[] tmp_sign = hash.ComputeHash(baseString);
            string sign = BitConverter.ToString(tmp_sign).Replace("-", "").ToLower();
            string url = String.Format(host + path + "?partner_id={0}&timestamp={1}&sign={2}&redirect={3}", partner_id, timest, sign, redirectUrl);
            return url;
        }
    }
}
