using DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DianShangAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoodsSpuController : ControllerBase
    {
        GoodsSpuDal goodsSpuDal = new GoodsSpuDal();
        //商品spu显示
        [HttpGet]
        [Route("Show")]
        public List<GoodsSpu> GoodsSpuShow()
        {
            return goodsSpuDal.GoodsSpuShow();
        }
        //商品spu添加
        [HttpPost]
        [Route("Add")]
        public int AddGoodsSpu(GoodsSpu g)
        {
            return goodsSpuDal.AddGoodsSpu(g);
        }
        //商品spu删除
        [HttpPost]
        [Route("Del")]
        public int DelGoodsSpu(string id)
        {
            return goodsSpuDal.DelGoodsSpu(id);
        }
    }
}
