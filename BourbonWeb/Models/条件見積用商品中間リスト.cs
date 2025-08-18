using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    public class 条件見積用商品中間リスト
    {
        [Column("対象年月")]
        [Display(Name = "対象年月")]
        public string? TaishoYm { get; set; }

        [Column("カテゴリブランド名")]
        [Display(Name = "カテゴリブランド名")]
        public string? CategoryBrandNm { get; set; }

        [Column("カテゴリ分類")]
        [Display(Name = "カテゴリ分類")]
        public string? CategoryBunrui { get; set; }

        [Column("カテゴリブランド")]
        [Display(Name = "カテゴリブランド")]
        public string? CategoryBrand { get; set; }

        [Column("品番")]
        [Display(Name = "品番")]
        public string? Hinban { get; set; }

        [Column("CHK")]
        [Display(Name = "CHK")]
        public bool? Chk { get; set; }

        [Column("商品名")]
        [Display(Name = "商品名")]
        public string? ShohinNm { get; set; }

        [Column("建値")]
        [Display(Name = "建値")]
        public decimal? Tatene { get; set; }

        [Column("営業分類コード")]
        [Display(Name = "営業分類コード")]
        public string? EigyoBunruiCd { get; set; }

        [Column("営業分類名")]
        [Display(Name = "営業分類名")]
        public string? EigyoBunruiNm { get; set; }

        [Column("入数")]
        [Display(Name = "入数")]
        public string? IriSu { get; set; }

        [Column("新商品FLG")]
        [Display(Name = "新商品FLG")]
        public string? ShinshohinFlg { get; set; }

        [Column("重点商品FLG")]
        [Display(Name = "重点商品FLG")]
        public string? JutenShohinFlg { get; set; }

        [Column("販売金額")]
        [Display(Name = "販売金額")]
        public decimal? HanbaiKingaku { get; set; }

        [Column("任意表示順")]
        [Display(Name = "任意表示順")]
        public int? NiniHyojiJun { get; set; }

        [Column("期間売上額")]
        [Display(Name = "期間売上額")]
        public decimal? KikanUriagegaku { get; set; }

        [Column("発売日")]
        [Display(Name = "発売日")]
        public string? Hatsubaibi { get; set; }

    }
}
