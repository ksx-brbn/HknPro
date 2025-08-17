using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "販促企画内容マスタ")]
    public class MHansokuNaiyou
    {
        [Column("KY_KBN_SIKIBETU_CD")]
        [Display(Name = "区分識別CD")]
        public string? KyKbnSikibetuCd { get; set; }

        [Column("KY_KBN_CD")]
        [Display(Name = "区分CD")]
        public string? KyKbnCd { get; set; }

        [Column("HANSOKU_NAIYOU_NAME")]
        [Display(Name = "販促内容名")]
        public string? HansokuNaiyouName { get; set; }

        [Column("HANSOKU_NAIYOU_ORDER")]
        [Display(Name = "販促内容ソート順")]
        public short? HansokuNaiyouOrder { get; set; }

        [Column("HANSOKU_NAIYOU_HYOJI")]
        [Display(Name = "販促内容表示")]
        public bool? HansokuNaiyouHyoji { get; set; }

        [Column("URIAGE_KOUJYO_HANTEI")]
        [Display(Name = "売上控除判定")]
        public string? UriageKoujyoHantei { get; set; }

        [Column("KEIHI_BUNRUI")]
        [Display(Name = "経費分類")]
        public string? KeihiBunrui { get; set; }

        [Column("REMARKS1")]
        [Display(Name = "備考1")]
        public string? Remarks1 { get; set; }

        [Column("REMARKS2")]
        [Display(Name = "備考2")]
        public string? Remarks2 { get; set; }

        [Column("CREATED_ID")]
        [Display(Name = "登録者")]
        public string? CreatedId { get; set; }

        [Column("CREATED_AT")]
        [Display(Name = "登録日")]
        public DateTime? CreatedAt { get; set; }

        [Column("UPDATED_ID")]
        [Display(Name = "更新者")]
        public string? UpdatedId { get; set; }

        [Column("UPDATED_AT")]
        [Display(Name = "更新日")]
        public DateTime? UpdatedAt { get; set; }

        [Column("DELETED_FLG")]
        [Display(Name = "削除フラグ")]
        public bool? DeletedFlg { get; set; }

        [Column("LOCK_VERSION")]
        [Display(Name = "ロックバージョン")]
        public int? LockVersion { get; set; }

        [Column("ZEI_RITU_KBN")]
        [Display(Name = "税率区分")]
        public string? ZeiRituKbn { get; set; }

    }
}