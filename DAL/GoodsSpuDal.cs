using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GoodsSpuDal
    {
        //商品spu显示
        public List<GoodsSpu> GoodsSpuShow()
        {
            //string sql = $"select * from GoodsSpu";
            string sql = $"select a.GoodsName,b.BrandName,c.SKURepertory,c.SKUprice,d.ImgLink from GoodsSPU a join BrandInfo b on a.GoodsDrandID=b.BrandId join GoodsSku c on a.GoodsId = c.SPUId join ImgInfo d on c.SKUId = d.SkuId";
            return DbAccess.DBHelper.GetToList<GoodsSpu>(sql);
        }
        //商品spu添加
        public int AddGoodsSpu(GoodsSpu g)
        {
            string sql = $"insert into GoodsSpu(GoodsName,GoodsDetails) values('{g.GoodsName}','{g.GoodsDetails}')";
            return DbAccess.DBHelper.ExecuteNonQuery(sql);
        }
        //商品spu删除
        public int DelGoodsSpu(string id)
        {
            string sql = $"delete from GoodsSpu where GoodsId in ('{id}')";
            return DbAccess.DBHelper.ExecuteNonQuery(sql);
        }


        //商品sku显示
        public List<GoodsSpu> GoodsSkuShow()
        {
            string sql = $"select * from GoodsSku";
            return DbAccess.DBHelper.GetToList<GoodsSpu>(sql);
        }
        //商品sku添加
        public int AddGoodsSku(GoodsSpu g)
        {
            string sql = $"insert into GoodsSku(SKURepertory,SKUprice,IfAdded) values('{g.SKURepertory}','{g.SKUprice}','{g.IfAdded}')";
            return DbAccess.DBHelper.ExecuteNonQuery(sql);
        }

        //品牌显示
        public List<GoodsSpu> BrandInfoShow()
        {
            string sql = $"select * from BrandInfo";
            return DbAccess.DBHelper.GetToList<GoodsSpu>(sql);
        }
        //品牌添加
        public int AddBrandInfo(GoodsSpu g)
        {
            string sql = $"insert into BrandInfo(BrandName,BrandDetails) values('{g.BrandName}','{g.BrandDetails}')";
            return DbAccess.DBHelper.ExecuteNonQuery(sql);
        }

        //SKU规格显示
        public List<GoodsSpu> SKUspecificationShow()
        {
            string sql = $"select * from SKUspecification";
            return DbAccess.DBHelper.GetToList<GoodsSpu>(sql);
        }
    }
}
