using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "企業グループマスタ")]
    public class MGroupCompany
    {
        [Column("GROUP_KBN")]
        [Display(Name = "グループ区分")]
        public string? GroupKbn { get; set; }

        [Column("GROUP_CD")]
        [Display(Name = "グループCD")]
        public string? GroupCd { get; set; }

        [Column("KAISI_YM")]
        [Display(Name = "対象期間開始年月")]
        public string? KaisiYm { get; set; }

        [Column("SHURYO_YM")]
        [Display(Name = "対象期間終了年月")]
        public string? ShuryoYm { get; set; }

        [Column("SEIKYU_KBN")]
        [Display(Name = "請求区分")]
        public string? SeikyuKbn { get; set; }

        [Column("MISE_CD")]
        [Display(Name = "店CD")]
        public string? MiseCd { get; set; }

        [Column("MISE_NM")]
        [Display(Name = "店名")]
        public string? MiseNm { get; set; }

        [Column("ORDER_NO")]
        [Display(Name = "表示順")]
        public short? OrderNo { get; set; }

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