using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class GoodsSpu
    {
        //spu
        public Guid GoodsId      { get; set; }
        public string GoodsName    { get; set; }
        public string GoodsDrandID { get; set; }
        public string GoodsDetails { get; set; }

        //sku
        public Guid SKUId        { get; set; }
        public Guid SPUId        { get; set; }
        public int SKURepertory { get; set; }
        public decimal SKUprice     { get; set; }
        public string IfAdded { get; set; }


        //品牌
        public Guid BrandId      { get; set; }
        public string BrandName    { get; set; }
        public string BrandDetails { get; set; }


        //图片
        public Guid ImgId   { get; set; }
       
        public string ImgLink { get; set; }


        //SKU规格    
        public Guid SKUSID        { get; set; }
        public Guid GoodsSkuid    { get; set; }
        public Guid Specification { get; set; }


        //规格   
        public Guid SpecificationId    { get; set; }
        public string SpecificationName { get; set; }


        //规格值
        public Guid StandardValueID { get; set; }
        public string StandardValue   { get; set; }
        public Guid StandardId { get; set; }
    }
}
