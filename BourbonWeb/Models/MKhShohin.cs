using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "価格販促商品マスタ")]
    public class MKhShohin
    {
        [Column("KAKAKU_HANSOKU_NO")]
        [Display(Name = "価格販促番号")]
        public string? KakakuHansokuNo { get; set; }

        [Column("KAKAKU_HANSOKU_GYO_NO")]
        [Display(Name = "価格販促行番号")]
        public int? KakakuHansokuGyoNo { get; set; }

        [Column("HINBAN")]
        [Display(Name = "品番")]
        public string? Hinban { get; set; }

        [Column("SHOHIN_NM")]
        [Display(Name = "商品名")]
        public string? ShohinNm { get; set; }

        [Column("SHOHIN_GROUP_NM")]
        [Display(Name = "商品グループ名")]
        public string? ShohinGroupNm { get; set; }

        [Column("EIGYO_BUNRUI")]
        [Display(Name = "営業分類")]
        public string? EigyoBunrui { get; set; }

        [Column("CATEGORY_BUNRUI")]
        [Display(Name = "カテゴリー分類")]
        public string? CategoryBunrui { get; set; }

        [Column("OYA_HINBAN")]
        [Display(Name = "親品番")]
        public string? OyaHinban { get; set; }

        [Column("IRISU")]
        [Display(Name = "入り数")]
        public string? Irisu { get; set; }

        [Column("TANKA")]
        [Display(Name = "単価")]
        public decimal? Tanka { get; set; }

        [Column("SHOHIN_REMARKS1")]
        [Display(Name = "商品備考1")]
        public string? ShohinRemarks1 { get; set; }

        [Column("SHOHIN_REMARKS2")]
        [Display(Name = "商品備考2")]
        public string? ShohinRemarks2 { get; set; }

        [Column("DENPYO_KBN")]
        [Display(Name = "伝票区分")]
        public string? DenpyoKbn { get; set; }

        [Column("HANSOK_KBN")]
        [Display(Name = "販促区分")]
        public string? HansokKbn { get; set; }

        [Column("HANSOK_KBN_SHOSAI")]
        [Display(Name = "販促区分詳細")]
        public string? HansokKbnShosai { get; set; }

        [Column("HANSOK_KBN_KOBETU")]
        [Display(Name = "販促区分個別")]
        public string? HansokKbnKobetu { get; set; }

        [Column("HANSOK_HIMOKU_CD")]
        [Display(Name = "販促費目CD")]
        public string? HansokHimokuCd { get; set; }

        [Column("HANSOK_HIMOKU_NM")]
        [Display(Name = "販促費目名")]
        public string? HansokHimokuNm { get; set; }

        [Column("KYOSAN_JOKEN_RITU")]
        [Display(Name = "協賛条件")]
        public decimal? KyosanJokenRitu { get; set; }

        [Column("KYOSAN_JOKEN_GAKU")]
        [Display(Name = "協賛条件額")]
        public decimal? KyosanJokenGaku { get; set; }

        [Column("REMARKS")]
        [Display(Name = "備考")]
        public string? Remarks { get; set; }

        [Column("CREATED_AT")]
        [Display(Name = "登録日")]
        public DateTime? CreatedAt { get; set; }

        [Column("CREATED_ID")]
        [Display(Name = "登録者")]
        public string? CreatedId { get; set; }

        [Column("UPDATED_AT")]
        [Display(Name = "更新日")]
        public DateTime? UpdatedAt { get; set; }

        [Column("UPDATED_ID")]
        [Display(Name = "更新者")]
        public string? UpdatedId { get; set; }

        [Column("DELETED_FLG")]
        [Display(Name = "削除フラグ")]
        public bool? DeletedFlg { get; set; }

        [Column("LOCK_VERSION")]
        [Display(Name = "ロックバージョン")]
        public int? LockVersion { get; set; }
    }
}