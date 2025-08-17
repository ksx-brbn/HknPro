using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "消費税マスタ")]
    public class MShohizei
    {
        [Column("KY_KAISI_YMD")]
        [Display(Name = "開始年月日")]
        public string? KyKaisiYmd { get; set; }

        [Column("KY_SHURYO_YMD")]
        [Display(Name = "終了年月日")]
        public string? KyShuryoYmd { get; set; }

        [Column("KY_ZEI_RITU")]
        [Display(Name = "税率")]
        public decimal? KyZeiRitu { get; set; }

        [Column("ZEI_RITU_KBN")]
        [Display(Name = "税率区分")]
        public string? ZeiRituKbn { get; set; }

        [Column("ORDER_NO")]
        [Display(Name = "ソート順")]
        public int? OrderNo { get; set; }

        [Column("DISP_FLG")]
        [Display(Name = "表示フラグ")]
        public bool? DispFlg { get; set; }

        [Column("REMARKS")]
        [Display(Name = "備考")]
        public string? Remarks { get; set; }

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
    }
}