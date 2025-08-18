using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "申請紐付け情報")]
    public class TSinseiAssociation
    {
        [Column("SINSEI_ASSOCIATION_CD")]
        [Display(Name = "申請紐づけCD")]
        public string? SinseiAssociationCd { get; set; }

        [Column("SINSEI_NO")]
        [Display(Name = "申請番号")]
        public string? SinseiNo { get; set; }

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